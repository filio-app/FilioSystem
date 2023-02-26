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
                Command.Connection = conFilioSys
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



    Sub displayForm(ByVal frmParent As System.Windows.Forms.Form, ByVal frmChild As System.Windows.Forms.Form)

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
            '.txtUserName.PlaceholderText = "Username"
            '.txtPassword.PlaceholderText = "Password"
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



End Module
