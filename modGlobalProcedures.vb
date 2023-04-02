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
                CType(ctrl, Guna.UI2.WinForms.Guna2ComboBox).SelectedIndex = -1
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

    Private Function CheckPasswordStrength(password As String) As Boolean
        Dim regex As Regex
        ' Check minimum length of 8 characters and combination of letters and numbers
        regex = New Regex("^(?=.*[A-Za-z])(?=.*\d)[A-Za-z\d]{8,}$")
        Return regex.IsMatch(password)

        'If regex.IsMatch(password) Then
        'Return True;
        'strength &= "Minimum length of 8 characters and combination of letters and numbers" & vbCrLf
        'Password must be 8+ characters and include letters and numbers.
        'End If
        ' Return the password strength
        'Return False
    End Function



End Module
