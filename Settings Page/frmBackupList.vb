Imports System.IO
Imports MySql.Data.MySqlClient

Public Class frmBackupList
    Private Sub btnCancel_Click(sender As Object, e As EventArgs) Handles btnCancel.Click
        Me.Close()
    End Sub

    Private Sub frmBackupList_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        procDisplayBackupRecords()
    End Sub

    Private Sub procDisplayBackupRecords()
        datFilio = New DataTable
        sqlAdapterFilio = New MySqlDataAdapter

        Try
            With command
                .Parameters.Clear()
                .CommandText = "procDisplayBackupRecords"
                .CommandType = CommandType.StoredProcedure
                sqlAdapterFilio.SelectCommand = command
                datFilio.Clear()
                sqlAdapterFilio.Fill(datFilio)
            End With
            If datFilio.Rows.Count > 0 Then
                grdBackupList.RowCount = datFilio.Rows.Count
                row = 0
                While Not datFilio.Rows.Count - 1 < row
                    With grdBackupList
                        .Rows(row).Cells(1).Value = datFilio.Rows(row).Item("id").ToString
                        .Rows(row).Cells(2).Value = datFilio.Rows(row).Item("backup_name").ToString
                        .Rows(row).Cells(3).Value = datFilio.Rows(row).Item("file_path").ToString
                        .Rows(row).Cells(4).Value = DateTime.Parse(datFilio.Rows(row).Item("backup_date")).ToString("f")
                    End With
                    row += 1
                End While
                grdBackupList.Rows(0).Selected = True
            Else
                grdBackupList.Rows.Clear()
                MessageBox.Show("No records found.", "Record Status", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)

            End If
            datFilio.Dispose()
            sqlAdapterFilio.Dispose()

        Catch ex As Exception
            MessageBox.Show("" & ex.Message)
        End Try
    End Sub

    Private Sub restoreBackup()
        Dim backupFile As String = grdBackupList.CurrentRow.Cells(3).Value.ToString
        Dim dbName As String = "filio_system"
        Dim mysqlPath As String = "C:\Program Files\MySQL\MySQL Server 8.0\bin\mysql.exe"
        Dim mysqlUsername As String = "root"
        Dim mysqlPassword As String = "filio"

        Dim processInfo As New ProcessStartInfo()
        processInfo.FileName = mysqlPath
        processInfo.Arguments = $"--user={mysqlUsername} --password={mysqlPassword} {dbName} < ""{backupFile}"""
        processInfo.CreateNoWindow = True
        processInfo.UseShellExecute = False

        Try
            Dim process As Process = Process.Start(processInfo)
            process.WaitForExit()
            MessageBox.Show("Database restored successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information)
        Catch ex As Exception
            MessageBox.Show("An error occurred during the restore process: " & ex.Message)
        End Try
    End Sub

    Private Sub procRestoreDatabase(backupPath As String)
        If MessageBox.Show("Before restoring the database, make sure you have a backup. Are you sure you want to proceed with the restore?", "Confirm Restore", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = DialogResult.Yes Then

            'Dim openFileDialog As New OpenFileDialog()
            'openFileDialog.InitialDirectory = "C:\Filio Database Backup\"
            'openFileDialog.Title = "Select Database Backup File"
            'openFileDialog.Filter = "SQL Files (*.sql)|*.sql|All files (*.*)|*.*"
            'openFileDialog.RestoreDirectory = True


            'If openFileDialog.ShowDialog() = DialogResult.OK Then
            'Dim backupFile As String = openFileDialog.FileName

            Dim connectionString As String = "SERVER=localhost;DATABASE=filio_system;USERNAME=root;PASSWORD=LojaLeonard129025;PORT=3306"

            Dim userInput As String = InputBox("To restore the database, please enter 'CONFIRM' in capital letters:", "Confirm Database Restore")

            If userInput.Trim() = "CONFIRM" Then
                ' Perform the restore

                'Dim sqlContent As String = File.ReadAllText(tempBackupPath)

                '' Exclude the history table from the SQL script
                'sqlContent = sqlContent.Replace("DROP TABLE IF EXISTS `history_log`;", "")
                'sqlContent = sqlContent.Replace("CREATE TABLE `history_log`", "")
                'sqlContent = sqlContent.Replace("INSERT INTO `history_log`", "")

                Try
                    Using con As New MySqlConnection(connectionString)
                        con.Open()

                        Using cmd As New MySqlCommand()
                            cmd.Connection = con

                            Dim mb As New MySqlBackup(cmd)
                            mb.ImportFromFile(backupPath)

                        End Using
                    End Using
                Catch ex As Exception
                    MessageBox.Show("Database restore failed: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                End Try

            Else
                ' Cancel deletion
                MessageBox.Show("Database Restore canceled.", "Confirmation", MessageBoxButtons.OK, MessageBoxIcon.Information)
            End If


            'End If
        End If
    End Sub

    Private Sub btnSelect_Click(sender As Object, e As EventArgs) Handles btnSelect.Click

        Dim encryptedFilePath As String = grdBackupList.CurrentRow.Cells(3).Value.ToString & ".enc"
        Dim decryptedFilePath As String = Path.ChangeExtension(encryptedFilePath, Nothing)


        Try
            ' Decrypt the backup file
            EncryptionUtility.DecryptFile(encryptedFilePath, decryptedFilePath)

            ' Restore the database
            'RestoreDatabase(decryptedFilePath)
            procRestoreDatabase(decryptedFilePath)

            frmFiles.Dispose()
            frmLocation.Dispose()
            frmArchive.Dispose()
            Me.Dispose()

            ' Delete the decrypted file after restoration
            File.Delete(decryptedFilePath)

            procInsertLogEvent("Restore", "Database Restore")
            MessageBox.Show("Database restored successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information)
        Catch ex As Exception
            MessageBox.Show($"An error occurred: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try

    End Sub
End Class