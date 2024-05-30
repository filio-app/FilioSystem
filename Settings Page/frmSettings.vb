Imports System.IO
Imports MySql.Data.MySqlClient
Imports MySql.Data.MySqlClient.MySqlBackup
Imports DotNetEnv
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

        Env.TraversePath().Load()

        'Access the environment variables
        Dim host As String = Env.GetString("DB_HOST")
        Dim dbName As String = Env.GetString("DB_NAME")
        Dim user As String = Env.GetString("DB_USER")
        Dim pass As String = Env.GetString("DB_PASS")
        Dim port As String = Env.GetInt("DB_PORT")



        Dim selectedTables As New List(Of String) From {"file", "location"}

        Try
            BackupSelectedTables(selectedTables)
            'PerformBackupDatabase()
        Catch ex As Exception
            MessageBox.Show($"An error occurred during backup: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try



        'Try
        '    Dim backup As New SaveFileDialog

        '    backup.InitialDirectory = "C:\Filio Database Backup\"
        '    backup.Title = "Database Backup"
        '    backup.CheckFileExists = False
        '    backup.CheckPathExists = False
        '    backup.DefaultExt = "sql"
        '    backup.Filter = "sql files (*.sql)|*.sql|All files (*.*)|*.*"
        '    backup.RestoreDirectory = True

        '    Dim connectionString As String = "SERVER=" & host & ";" _
        '                          & "DATABASE=" & dbName & ";" _
        '                          & "USERNAME=" & user & ";" _
        '                          & "PASSWORD=" & pass & ";" _
        '                          & "PORT=" & port

        '    If backup.ShowDialog = Windows.Forms.DialogResult.OK Then
        '        Using con As New MySqlConnection(connectionString)
        '            con.Open()

        '            Using cmd As New MySqlCommand()
        '                cmd.Connection = con

        '                Dim mb As MySqlBackup = New MySqlBackup(cmd)
        '                mb.ExportToFile(backup.FileName)
        '                MessageBox.Show("Database backup created successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information)
        '                procInsertLogEvent("Manual Backup", "Database Backup")
        '            End Using
        '        End Using
        '    Else
        '        Exit Sub
        '    End If
        'Catch ex As Exception
        '    MessageBox.Show("Backup operation failed: " & ex.Message)
        'End Try






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


    Private Sub PerformBackupDatabase()
        Dim backupPath As String = BackupDirectory & String.Format("{0}-{1:yyyy-MM-dd-HH-mm-ss}.sql", "\filio", DateTime.Now) ' Set the backup file path

        Dim connectionString As String = "SERVER=localhost;DATABASE=filio_system;USERNAME=root;PASSWORD=LojaLeonard129025;PORT=3306"

        Try
            Using con As New MySqlConnection(connectionString)
                con.Open()

                Using cmd As New MySqlCommand()
                    cmd.Connection = con

                    Dim mb As New MySqlBackup(cmd)
                    mb.ExportToFile(backupPath)

                    InsertBackupRecord("USER_INPUT", backupPath)

                    procInsertLogEvent("Manual Backup", "Database Backup")
                    MessageBox.Show("Database backup created successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information)
                End Using
            End Using
        Catch ex As Exception
            MessageBox.Show("Backup operation failed: " & ex.Message)
        End Try

    End Sub

    Public Sub InsertBackupRecord(backupName As String, filePath As String)
        Try
            With command
                .Parameters.Clear()
                .CommandText = "procInsertBackupRecord"
                .CommandType = CommandType.StoredProcedure
                .Parameters.AddWithValue("@p_backup_name", backupName)
                .Parameters.AddWithValue("@p_file_path", filePath)
                .ExecuteNonQuery()
            End With

            datFilio.Dispose()
            sqlAdapterFilio.Dispose()
        Catch ex As Exception
            MessageBox.Show("" & ex.Message)
        End Try

    End Sub


    Private Sub BackupSelectedTables(selectedTables As List(Of String))
        Dim server As String = "localhost"
        Dim database As String = "filio_system"
        Dim user As String = "root"
        Dim password As String = "LojaLeonard129025"
        Dim backupPath As String = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData), "Filio", "Backups")
        Dim fileName As String = $"backup_{DateTime.Now.ToString("yyyyMMdd_HHmmss")}.sql"
        Dim fullPath As String = Path.Combine(backupPath, fileName)

        ' Ensure backup directory exists
        If Not Directory.Exists(backupPath) Then
            Directory.CreateDirectory(backupPath)
        End If

        ' Join selected tables into a single string separated by spaces
        Dim tables As String = String.Join(" ", selectedTables)

        ' Create the mysqldump command
        Dim command As String = $"mysqldump --host={server} --user={user} --password={password} --routines {database} {tables} > ""{fullPath}"""

        ' Execute the command
        Using process As New Process()
            process.StartInfo.FileName = "cmd.exe"
            process.StartInfo.Arguments = $"/c {command}"
            process.StartInfo.UseShellExecute = False
            process.StartInfo.RedirectStandardOutput = True
            process.StartInfo.RedirectStandardError = True
            process.Start()

            Dim output As String = process.StandardOutput.ReadToEnd()
            Dim errorOutput As String = process.StandardError.ReadToEnd()
            process.WaitForExit()

            If process.ExitCode <> 0 Then
                Throw New Exception($"Backup failed with the following error: {errorOutput}")
            End If

            InsertBackupRecord("USER_INPUT", fullPath)

            procInsertLogEvent("Manual Backup", "Database Backup")
        End Using

        MessageBox.Show("Backup completed successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information)
    End Sub



    Private Sub BackupDatabase()
        Dim dbName As String = "filio_system"
        Dim backupFile As String = "C:\Users\leonard\AppData\Roaming\Filio\Backups\file.sql"
        Dim mysqldumpPath As String = "C:\Program Files\MySQL\MySQL Server 8.0\bin\mysqldump.exe"
        Dim mysqlUsername As String = "root"
        Dim mysqlPassword As String = "LojaLeonard129025"

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
        displayFormAsModal(frmMain, frmBackupList)
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