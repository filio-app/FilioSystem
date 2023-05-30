Imports System.IO
Imports MySql.Data.MySqlClient
Imports MySql.Data.MySqlClient.MySqlBackup
Public Class frmSettings

    Private Sub btnBackup_Click(sender As Object, e As EventArgs) Handles btnBackup.Click

        'Dim saveFileDialog1 As New SaveFileDialog()
        'saveFileDialog1.Filter = "SQL files (*.sql)|*.sql|All files (*.*)|*.*"
        'saveFileDialog1.FilterIndex = 1
        'saveFileDialog1.RestoreDirectory = True

        'If saveFileDialog1.ShowDialog() = DialogResult.OK Then
        '    Try
        '        Dim connString As String = "server=localhost;user id=root;password=filio;database=filio_system"
        '        Dim conn As New MySqlConnection(connString)
        '        Dim backup As New MySqlBackup
        '        backup.ExportToFile(saveFileDialog1.FileName)
        '        MessageBox.Show("Database backup complete.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information)
        '    Catch ex As Exception
        '        MessageBox.Show("Error: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        '    End Try
        'End If

        'BackupDatabase("filio_system", "C:\Users\lojal\OneDrive\Documents\Filio Backup")
        'BackupDatabaseNew("filio_system", "C:\Users\lojal\OneDrive\Documents\Filio Backup")

        'BackupDatabase()

        Try
            Dim backup As New SaveFileDialog

            backup.InitialDirectory = "C:\Filio Database Backup\"
            backup.Title = "Database Backup"
            backup.CheckFileExists = False
            backup.CheckPathExists = False
            backup.DefaultExt = "sql"
            backup.Filter = "sql files (*.sql)|*.sql|All files (*.*)|*.*"
            backup.RestoreDirectory = True

            Dim connectionString As String = "SERVER=localhost;DATABASE=filio_system;USERNAME=root;PASSWORD=filio;PORT=3306"

            If backup.ShowDialog = Windows.Forms.DialogResult.OK Then
                Using con As New MySqlConnection(connectionString)
                    con.Open()

                    Using cmd As New MySqlCommand()
                        cmd.Connection = con

                        Dim mb As MySqlBackup = New MySqlBackup(cmd)
                        mb.ExportToFile(backup.FileName)
                        MessageBox.Show("Database backup created successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information)
                        procInsertLogEvent("Manual Backup", "Database Backup")
                    End Using
                End Using
            Else
                Exit Sub
            End If
        Catch ex As Exception
            MessageBox.Show("Backup operation failed: " & ex.Message)
        End Try






        'Try
        '    Dim backup As New SaveFileDialog

        '    backup.InitialDirectory = "C:\Users\lojal\OneDrive\Documents\Filio Backup"
        '    backup.Title = "Database Backup"
        '    backup.CheckFileExists = False
        '    backup.CheckPathExists = False
        '    backup.DefaultExt = "sql"
        '    backup.Filter = "sql files (*.sql)|*.sql|All files (*.*)|*.*"
        '    backup.RestoreDirectory = True

        '    If backup.ShowDialog = Windows.Forms.DialogResult.OK Then



        '        Dim con As MySqlConnection = New MySqlConnection("SERVER=localhost;DATABASE=filio_system;USERNAME=root;PASSWORD=filio;PORT=3306")
        '        Dim cmd As MySqlCommand = New MySqlCommand
        '        cmd.Connection = con
        '        con.Open()

        '        Dim mb As MySqlBackup = New MySqlBackup(command)
        '        mb.ExportToFile(backup.FileName)
        '        MessageBox.Show("Database backup created successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information)

        '        con.Close()


        '    Else
        '        Exit Sub
        '    End If
        'Catch ex As Exception
        '    MessageBox.Show("Backup operation failed: " & ex.Message)
        'End Try



        'Try
        '    Dim backup As New SaveFileDialog

        '    backup.InitialDirectory = "C:\"
        '    backup.Title = "Database Backup"
        '    backup.CheckFileExists = False
        '    backup.CheckPathExists = False
        '    backup.DefaultExt = "sql"
        '    backup.Filter = "sql files (*.sql)|*.sql|All files (*.*)|*.*"
        '    backup.RestoreDirectory = True

        '    If backup.ShowDialog = Windows.Forms.DialogResult.OK Then
        '        'Dim connString As String = "server=localhost;user id=root;password=filio;database=filio_system;charset=utf8"
        '        'Dim conn As New MySqlConnection(connString)
        '        'Dim newCmd As MySqlCommand = New MySqlCommand
        '        'newCmd.Connection = conn
        '        'conn.Open()

        '        If conFilioSys.State = ConnectionState.Closed Then
        '            conFilioSys.Open()
        '        End If


        '        Dim mb As MySqlBackup = New MySqlBackup(command)
        '        mb.ExportToFile(backup.FileName)
        '        MessageBox.Show("Database backup created successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information)


        '        conFilioSys.Close()

        '        Else
        '        Exit Sub
        '    End If
        'Catch ex As Exception
        '    MessageBox.Show("Backup operation failed: " & ex.Message)
        'End Try

    End Sub


    Private Sub BackupDatabase()
        Dim dbName As String = "filio_system"
        Dim backupFile As String = "C:\Users\lojal\OneDrive\Documents\Filio Backup\file.sql"
        Dim mysqldumpPath As String = "C:\Program Files\MySQL\MySQL Server 8.0\bin\mysqldump.exe"
        Dim mysqlUsername As String = "root"
        Dim mysqlPassword As String = "filio"

        Dim processInfo As New ProcessStartInfo()
        processInfo.FileName = mysqldumpPath
        processInfo.Arguments = $"--user={mysqlUsername} --password={mysqlPassword} --databases {dbName} > ""{backupFile}"""
        processInfo.CreateNoWindow = True
        processInfo.UseShellExecute = False

        Try
            Dim process As Process = Process.Start(processInfo)
            process.WaitForExit()
            MessageBox.Show("Backup completed successfully.")
        Catch ex As Exception
            MessageBox.Show("An error occurred during the backup process: " & ex.Message)
        End Try
    End Sub

    Private Sub btnRestore_Click(sender As Object, e As EventArgs) Handles btnRestore.Click

        If MessageBox.Show("Before restoring the database, make sure you have a backup. Are you sure you want to proceed with the restore?", "Confirm Restore", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = DialogResult.Yes Then

            Dim openFileDialog As New OpenFileDialog()
            openFileDialog.InitialDirectory = "C:\Filio Database Backup\"
            openFileDialog.Title = "Select Database Backup File"
            openFileDialog.Filter = "SQL Files (*.sql)|*.sql|All files (*.*)|*.*"
            openFileDialog.RestoreDirectory = True


            If openFileDialog.ShowDialog() = DialogResult.OK Then
                Dim backupFile As String = openFileDialog.FileName

                Dim connectionString As String = "SERVER=localhost;DATABASE=filio_system;USERNAME=root;PASSWORD=filio;PORT=3306"

                Dim userInput As String = InputBox("To restore the database, please enter 'CONFIRM' in capital letters:", "Confirm Database Restore")

                If userInput.Trim() = "CONFIRM" Then
                    ' Perform the restore

                    Dim sqlContent As String = File.ReadAllText(backupFile)

                    '' Exclude the history table from the SQL script
                    'sqlContent = sqlContent.Replace("DROP TABLE IF EXISTS `history_log`;", "")
                    'sqlContent = sqlContent.Replace("CREATE TABLE `history_log`", "")
                    'sqlContent = sqlContent.Replace("INSERT INTO `history_log`", "")

                    Try
                        Using con As New MySqlConnection(connectionString)
                            con.Open()

                            Using cmd As New MySqlCommand()
                                cmd.Connection = con

                                Dim mb As MySqlBackup = New MySqlBackup(cmd)
                                mb.ImportFromFile(backupFile)
                                procInsertLogEvent("Restore", "Database Restore")
                                MessageBox.Show("The database has been successfully restored. Please restart the application to apply the changes.", "Restore Completed", MessageBoxButtons.OK, MessageBoxIcon.Information)
                            End Using
                        End Using
                    Catch ex As Exception
                        MessageBox.Show("Database restore failed: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                    End Try

                Else
                    ' Cancel deletion
                    MessageBox.Show("Database Restore canceled.", "Confirmation", MessageBoxButtons.OK, MessageBoxIcon.Information)
                End If


            End If
        End If
    End Sub

    Private Sub btnBackupAndRestore_Click(sender As Object, e As EventArgs) Handles btnBackupAndRestore.Click
        BunifuPagesSettings.SetPage(1)
    End Sub

    Private Sub btnLocation_Click(sender As Object, e As EventArgs) Handles btnLocation.Click
        BunifuPagesSettings.SetPage(0)
        With frmLocation
            .TopLevel = False
            panelLocation.Controls.Add(frmLocation)
            .BringToFront()
            .Show()
        End With
    End Sub

    Private Sub frmSettings_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        btnLocation.PerformClick()
    End Sub

    Private Sub panelBackupAndRestore_Paint(sender As Object, e As PaintEventArgs) Handles panelBackupAndRestore.Paint

    End Sub
End Class