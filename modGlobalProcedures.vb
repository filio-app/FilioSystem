Imports System.IO
Imports System.Text.RegularExpressions
Imports MySql.Data.MySqlClient

Module modGlobalProcedures

    Public Function fncConnectToDatabse() As Boolean

        Try
            serverName = "localhost"
            dbName = "filio_system"
            dbUserName = "root"
            dbPassword = "filio"
            port = "3306"

            If conFilioSys.State = ConnectionState.Closed Then
                conFilioSys = New MySqlConnection
                strConnectionString = "SERVER=" & serverName & ";" _
                                  & "DATABASE=" & dbName & ";" _
                                  & "USERNAME=" & dbUserName & ";" _
                                  & "PASSWORD=" & dbPassword & ";" _
                                  & "PORT=" & port

                conFilioSys.ConnectionString = strConnectionString
                conFilioSys.Open()
                command.Connection = conFilioSys
                Return True
            Else
                conFilioSys.Close()
                Return False

            End If

        Catch ex As Exception
            MessageBox.Show("" & ex.Message)
        End Try
        Return False
    End Function

    Public Sub chkDatabaseConnection()
        If fncConnectToDatabse() = True Then
        Else
            conFilioSys.Open()
        End If

    End Sub


    Sub clearControls(ByVal frm As System.Windows.Forms.Form)
        For Each ctrl As Control In frm.Controls
            If TypeOf ctrl Is Guna.UI2.WinForms.Guna2TextBox Then
                CType(ctrl, Guna.UI2.WinForms.Guna2TextBox).Clear()
            ElseIf TypeOf ctrl Is Guna.UI2.WinForms.Guna2ComboBox Then
                CType(ctrl, Guna.UI2.WinForms.Guna2ComboBox).SelectedIndex = 0
            ElseIf TypeOf ctrl Is CheckBox Then
                CType(ctrl, CheckBox).Checked = False
                ' Add more control types as needed
            End If
        Next
    End Sub

    Sub clearControlsInGroupBox(ByVal groupBox As Guna.UI2.WinForms.Guna2GroupBox)
        For Each ctrl As Control In groupBox.Controls
            If TypeOf ctrl Is Guna.UI2.WinForms.Guna2TextBox Then
                CType(ctrl, Guna.UI2.WinForms.Guna2TextBox).Clear()
            ElseIf TypeOf ctrl Is Guna.UI2.WinForms.Guna2ComboBox Then
                CType(ctrl, Guna.UI2.WinForms.Guna2ComboBox).SelectedIndex = 0
            ElseIf TypeOf ctrl Is CheckBox Then
                CType(ctrl, CheckBox).Checked = False
                ' Add more control types as needed
            End If
        Next
    End Sub

    Sub displayFormAsModal(ByVal frmParent As System.Windows.Forms.Form, ByVal frmChild As System.Windows.Forms.Form)

        frmModal.ShowInTaskbar = False
        'frmModal.BackColor = Color.Magenta
        'frmModal.TransparencyKey = Color.Magenta
        'frmModal.FormBorderStyle = FormBorderStyle.None
        frmModal.StartPosition = FormStartPosition.Manual
        frmModal.Location = frmParent.Location
        frmModal.Size = frmParent.Size
        frmModal.TopMost = False
        frmModal.Owner = frmParent
        frmModal.Show()
        With frmChild
            .ShowInTaskbar = False
            .TopMost = False
            .Owner = frmParent
            .StartPosition = FormStartPosition.CenterParent
            .ShowDialog()
        End With
        'btnUser.Text = StrConv(userName, VbStrConv.ProperCase)
        'frmLogin.Close()
        frmModal.Dispose()

    End Sub

    Public Function CheckPasswordStrength(ByVal password As String) As Boolean
        Dim regex As Regex
        ' Check minimum length of 8 characters and combination of letters and numbers
        regex = New Regex("^(?=.*[A-Za-z])(?=.*\d)[A-Za-z\d]{8,}$")
        If regex.IsMatch(password) Then
            Return True
        End If
        Return False
    End Function



    Public Sub procInsertLogEvent(ByVal action As String, ByVal target As String)
        Try
            With command
                .Parameters.Clear()
                .CommandText = "procInsertLogEvent"
                .CommandType = CommandType.StoredProcedure
                .Parameters.AddWithValue("@p_user_id", currUserID)
                .Parameters.AddWithValue("@p_action", action)
                .Parameters.AddWithValue("@p_target", target)
                .ExecuteNonQuery()
            End With
            frmHistory.Dispose()

        Catch ex As Exception
            MessageBox.Show("" & ex.Message)
        End Try

    End Sub

    'Public Sub BackupDatabaseOld(ByVal databaseName As String, ByVal backupPath As String)
    '    Try
    '        Dim fileName As String = String.Format("{0}-{1:yyyy-MM-dd-HH-mm-ss}.sql", databaseName, DateTime.Now)
    '        Dim filePath As String = Path.Combine(backupPath, fileName)

    '        Using process As New Process()
    '            process.StartInfo.FileName = "mysqldump.exe"
    '            process.StartInfo.Arguments = String.Format("-u {0} -p{1} -h {2} {3} > ""{4}""", "root", "filio", "localhost", databaseName, filePath)
    '            process.StartInfo.UseShellExecute = False
    '            process.StartInfo.RedirectStandardOutput = True
    '            process.Start()
    '            process.WaitForExit()
    '            MessageBox.Show("Database backup created successfully!")
    '        End Using
    '    Catch ex As Exception
    '        MessageBox.Show("Error creating database backup: " & ex.Message)
    '    End Try
    'End Sub

    'Public Sub BackupDatabaseNew(ByVal databaseName As String, ByVal backupPath As String)
    '    Try
    '        Dim fileName As String = String.Format("{0}-{1:yyyy-MM-dd-HH-mm-ss}.sql", databaseName, DateTime.Now)
    '        Dim filePath As String = Path.Combine(backupPath, fileName)

    '        Using process As New Process()
    '            process.StartInfo.FileName = "C:\Program Files\MySQL\MySQL Server 8.0\bin\mysqldump.exe"
    '            process.StartInfo.Arguments = String.Format("-u {0} -p{1} -h {2} --protocol=tcp --port=3306 --default-auth=filio {3} > ""{4}""", "root", "password", "localhost", databaseName, filePath)
    '            process.StartInfo.UseShellExecute = False
    '            process.StartInfo.RedirectStandardOutput = True
    '            process.Start()
    '            process.WaitForExit()
    '            MessageBox.Show("Database backup created successfully!")
    '        End Using
    '    Catch ex As Exception
    '        MessageBox.Show("Error creating database backup: " & ex.Message)
    '    End Try
    'End Sub





    Public Function LimitUsernameText(uname As String) As String
        Dim maxLength As Integer = 12
        If uname.Length >= maxLength Then
            Return uname.Substring(0, maxLength) & "..."
        End If
        Return uname
    End Function




End Module
