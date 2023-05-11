Imports MySql.Data.MySqlClient
Public Class frmSettings

    Private Sub btnBackup_Click(sender As Object, e As EventArgs) Handles btnBackup.Click

        Dim saveFileDialog1 As New SaveFileDialog()
        saveFileDialog1.Filter = "SQL files (*.sql)|*.sql|All files (*.*)|*.*"
        saveFileDialog1.FilterIndex = 1
        saveFileDialog1.RestoreDirectory = True

        If saveFileDialog1.ShowDialog() = DialogResult.OK Then
            Try
                Dim connString As String = "server=localhost;user id=root;password=filio;database=filio_system"
                Dim conn As New MySqlConnection(connString)
                Dim backup As New MySqlBackup
                backup.ExportToFile(saveFileDialog1.FileName)
                MessageBox.Show("Database backup complete.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Catch ex As Exception
                MessageBox.Show("Error: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End Try
        End If


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
        '        chkDatabaseConnection()
        '        Dim mb As MySqlBackup = New MySqlBackup(command)
        '        mb.ExportToFile(backup.FileName)
        '        MessageBox.Show("Database backup created successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information)
        '    Else
        '        Exit Sub
        '    End If
        'Catch ex As Exception
        '    MessageBox.Show("Error creating database backup: " & ex.Message)
        'End Try

    End Sub

    Private Sub btnRestore_Click(sender As Object, e As EventArgs) Handles btnRestore.Click
        Dim openFileDialog As New OpenFileDialog()
        openFileDialog.Filter = "SQL backup files (*.sql)|*.sql|All files (*.*)|*.*"
        If openFileDialog.ShowDialog() = DialogResult.OK Then
            Try
                ' Connect to the database and create a new backup object '
                chkDatabaseConnection()
                Dim backup As New MySqlBackup(command)

                ' Restore the contents of the backup file to the database '
                backup.ImportFromFile(openFileDialog.FileName)

                MessageBox.Show("Restore completed successfully.")
            Catch ex As Exception
                MessageBox.Show("Error restoring database: " + ex.Message)
            End Try
        End If
    End Sub
End Class