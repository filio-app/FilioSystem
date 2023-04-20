Imports MySql.Data.MySqlClient
Public Class frmSettings
    Private Sub btnBackup_Click(sender As Object, e As EventArgs) Handles btnBackup.Click


        Dim backup As New SaveFileDialog

        backup.InitialDirectory = "C:\"
        backup.Title = "Database Backup"
        backup.CheckFileExists = False
        backup.CheckPathExists = False
        backup.DefaultExt = "sql"
        backup.Filter = "sql files (*.sql)|*.sql|All files (*.*)|*.*"
        backup.RestoreDirectory = True

        If backup.ShowDialog = Windows.Forms.DialogResult.OK Then
            chkDatabaseConnection()
            Dim mb As MySqlBackup = New MySqlBackup(command)
            mb.ExportToFile(backup.FileName)
            MessageBox.Show("Database backup created successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information)
        Else
            Exit Sub
        End If

    End Sub
End Class