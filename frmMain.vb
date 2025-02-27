﻿Imports System.IO
Imports MySql.Data.MySqlClient
Public Class frmMain

    Private backupPerformed As Boolean = False

    Private Sub Main_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        chkDatabaseConnection()

        Me.Show()

        'TODO: (frmMain) Remove and Uncomment the following 2 statements for frmSignIn

        'btnCurrentUser.Visible = True
        'btnLogout.Visible = True


        bunifuPagesMain.SetPage(7)

        displayFormAsModal(Me, frmSignIn)
        'BackupDatabase()
        CheckLastDayOfWeek()

        EnsureBackupDirectoryExists()



    End Sub

    Private Sub EnsureBackupDirectoryExists()
        If Not Directory.Exists(BackupDirectory) Then
            Directory.CreateDirectory(BackupDirectory)
        End If
    End Sub




    Private Sub CheckLastDayOfWeek()
        Dim currentDate As DateTime = DateTime.Now
        Dim lastDayOfWeek As DateTime = GetLastDayOfWeek(currentDate)

        ' Check if weekly backup has already been performed within the current week
        Dim backupPerformed As Boolean = IsWeeklyBackupPerformed(lastDayOfWeek)

        If currentDate.Date = lastDayOfWeek.Date AndAlso Not backupPerformed Then
            Try
                '' full backup
                BackupDatabase()

                '' files and locations backup
                Dim selectedTables As New List(Of String) From {"file", "location"}
                BackupSelectedTables(selectedTables)
                'PerformBackupDatabase()
            Catch ex As Exception
                MessageBox.Show($"An error occurred during backup: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End Try


        End If
    End Sub

    Private Function GetLastDayOfWeek(ByVal currentDate As DateTime) As DateTime
        Dim lastDayOfWeek As DateTime = currentDate.AddDays(6 - currentDate.DayOfWeek)
        Return lastDayOfWeek
    End Function

    Private Function IsWeeklyBackupPerformed(ByVal lastDayOfWeek As DateTime) As Boolean
        Dim firstDayOfWeek As DateTime = lastDayOfWeek.AddDays(-6).Date
        Dim backupPerformed As Boolean = False


        datFilio = New DataTable
        sqlAdapterFilio = New MySqlDataAdapter

        Try
            With command
                .Parameters.Clear()
                .CommandText = "procSearchWeeklyBackup"
                .Parameters.AddWithValue("@p_start_date", firstDayOfWeek)
                .Parameters.AddWithValue("@p_end_date", lastDayOfWeek)
                .CommandType = CommandType.StoredProcedure
                sqlAdapterFilio.SelectCommand = command
                datFilio.Clear()
                sqlAdapterFilio.Fill(datFilio)
                If datFilio.Rows.Count > 0 Then

                    backupPerformed = True

                Else

                    backupPerformed = False

                End If

            End With
            datFilio.Dispose()
            sqlAdapterFilio.Dispose()

        Catch ex As Exception
            MessageBox.Show("" + ex.Message)
        End Try


        Return backupPerformed
    End Function


    'DASHBOARD

    Private Sub procDisplayAllTransactions()
        datFilio = New DataTable
        sqlAdapterFilio = New MySqlDataAdapter

        Try
            With command
                .Parameters.Clear()
                .CommandText = "procDisplayAllTransactions"
                .CommandType = CommandType.StoredProcedure
                sqlAdapterFilio.SelectCommand = command
                datFilio.Clear()
                sqlAdapterFilio.Fill(datFilio)
            End With
            Dim count As Integer = 0
            If datFilio.Rows.Count > 0 Then
                grdDTransaction.RowCount = datFilio.Rows.Count


                row = 0
                While Not datFilio.Rows.Count - 1 < row
                    'Showing only 30 latest transactions
                    If count = 30 Then
                        Exit While
                    End If
                    With grdDTransaction
                        .Rows(row).Cells(2).Value = datFilio.Rows(row).Item("file_name").ToString
                        .Rows(row).Cells(3).Value = DateTime.Parse(datFilio.Rows(row).Item("date").ToString()).ToString("dddd, MMMM dd, yyyy h:mm:ss tt")

                        If datFilio.Rows(row).Item("type").ToString.Equals("Issue") Then
                            .Rows(row).Cells(4).Value = "Issued"
                        Else
                            .Rows(row).Cells(4).Value = "Returned"
                        End If

                    End With
                    row += 1
                    count += 1

                End While

            Else
                grdDTransaction.Rows.Clear()
                'MessageBox.Show("NO Record Found!", "Record Status", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)

            End If
            datFilio.Dispose()
            sqlAdapterFilio.Dispose()

        Catch ex As Exception
            MessageBox.Show("" & ex.Message)
        End Try
    End Sub

    Private Function getTotalRecords(ByVal tableName As String) As Integer
        sqlAdapterFilio = New MySqlDataAdapter
        datFilio = New DataTable
        Dim cmdText As String

        If tableName.Equals("transaction") Then
            cmdText = "SELECT * FROM " & tableName
        Else
            cmdText = "SELECT * FROM " & tableName & " WHERE deleted_at IS NULL"
        End If

        Try
            With command
                .Parameters.Clear()
                .CommandText = cmdText
                .CommandType = CommandType.Text
                .ExecuteNonQuery()
                sqlAdapterFilio.SelectCommand = command
                datFilio.Clear()
                sqlAdapterFilio.Fill(datFilio)
                Return datFilio.Rows.Count
            End With

            datFilio.Dispose()
            sqlAdapterFilio.Dispose()

        Catch ex As Exception
            MessageBox.Show("" + ex.Message)
        End Try
        Return 0
    End Function



    Private Sub btnDashboard_Click(sender As Object, e As EventArgs) Handles btnDashboard.Click
        bunifuPagesMain.SetPage(0)

        procDisplayAllTransactions()

        lblTotalFiles.Text = getTotalRecords("file").ToString
        lblTotalLocations.Text = getTotalRecords("location").ToString
        lblTotalTransactions.Text = getTotalRecords("transaction").ToString

        'With frmBrgyOfficial
        '    .TopLevel = False
        '    pnlBrgyOfficial.Controls.Add(frmBrgyOfficial)
        '    .BringToFront()
        '    .Show()
        'End With
    End Sub

    Private Sub btnFiles_Click(sender As Object, e As EventArgs) Handles btnFiles.Click
        bunifuPagesMain.SetPage(1)
        With frmFiles
            .TopLevel = False
            panelFiles.Controls.Add(frmFiles)
            .BringToFront()
            .Show()
        End With
    End Sub


    Private Sub btnTransaction_Click(sender As Object, e As EventArgs) Handles btnTransaction.Click
        bunifuPagesMain.SetPage(2)
        With frmTransaction
            .TopLevel = False
            panelTransaction.Controls.Add(frmTransaction)
            .BringToFront()
            .Show()
        End With
    End Sub

    Private Sub btnUsers_Click(sender As Object, e As EventArgs) Handles btnUsers.Click
        bunifuPagesMain.SetPage(3)
        With frmUsers
            .TopLevel = False
            panelUsers.Controls.Add(frmUsers)
            .BringToFront()
            .Show()
        End With
    End Sub

    Private Sub btnHistory_Click(sender As Object, e As EventArgs) Handles btnHistory.Click
        bunifuPagesMain.SetPage(4)
        With frmHistory
            .TopLevel = False
            panelHistory.Controls.Add(frmHistory)
            .BringToFront()
            .Show()
        End With
    End Sub

    Private Sub btnSettings_Click(sender As Object, e As EventArgs) Handles btnSettings.Click
        bunifuPagesMain.SetPage(5)
        With frmSettings
            .TopLevel = False
            panelSettings.Controls.Add(frmSettings)
            .BringToFront()
            .Show()
        End With
    End Sub

    Private Sub btnCurrentUser_Click(sender As Object, e As EventArgs) Handles btnCurrentUser.Click
        bunifuPagesMain.SetPage(6)
        With frmCurrentUser
            .TopLevel = False
            panelCurrentUser.Controls.Add(frmCurrentUser)
            .BringToFront()
            .Show()
        End With
    End Sub


    Private Sub btnArchive_Click(sender As Object, e As EventArgs) Handles btnArchive.Click
        bunifuPagesMain.SetPage(8)
        With frmArchive
            .TopLevel = False
            panelArchive.Controls.Add(frmArchive)
            .BringToFront()
            .Show()
        End With

    End Sub

    Private Sub btnLogout_Click(sender As Object, e As EventArgs) Handles btnLogout.Click

        btnLogout.Visible = False
        btnCurrentUser.Visible = False

        pBLogo.Visible = False
        lblMenu.Visible = False
        btnDashboard.Visible = False
        btnFiles.Visible = False
        btnTransaction.Visible = False
        btnUsers.Visible = False
        btnHistory.Visible = False
        btnSettings.Visible = False
        btnArchive.Visible = False

        ' TODO: (frmMain) set other button checked to false
        btnDashboard.Checked = False



        frmCurrentUser.Dispose()
        frmHistory.Dispose()
        frmFiles.Dispose()
        frmSettings.Dispose()
        frmTransaction.Dispose()
        frmUsers.Dispose()
        frmArchive.Dispose()

        procInsertLogEvent("Signed Out", "System")
        isLoggedIn = False

        bunifuPagesMain.SetPage(7)

        displayFormAsModal(Me, frmSignIn)
    End Sub



    '' FULL BACKUP

    Private Sub BackupDatabase()
        'Dim backupPath As String = "C:\Filio Database Backup\Automated\"
        Dim backupPath As String = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData), "Filio", "FullBackups") & String.Format("{0}-{1:yyyy-MM-dd-HH-mm-ss}.sql", "filio", DateTime.Now)

        Dim connectionString As String = "SERVER=localhost;DATABASE=filio_system;USERNAME=root;PASSWORD=filio;PORT=3306"

        Try
            Using con As New MySqlConnection(connectionString)
                con.Open()

                Using cmd As New MySqlCommand()
                    cmd.Connection = con

                    Dim mb As MySqlBackup = New MySqlBackup(cmd)
                    mb.ExportToFile(backupPath)
                    'MessageBox.Show("Database backup created successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information)
                End Using
            End Using
        Catch ex As Exception
            MessageBox.Show("Backup operation failed: " & ex.Message)
        End Try
    End Sub


    '' FILES AND LOCATIONS BACKUP

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

            InsertBackupRecord("Weekly Backup", fullPath)
            procInsertLogEvent("Automatic Backup", "Database Weekly Backup")
        End Using

    End Sub



    Private Sub frmMain_FormClosing(sender As Object, e As FormClosingEventArgs) Handles MyBase.FormClosing
        If isLoggedIn Then
            procInsertLogEvent("Signed Out", "System")
        End If
    End Sub

    Private Sub panelArchive_Paint(sender As Object, e As PaintEventArgs) Handles panelArchive.Paint

    End Sub
End Class
