Public Class Main
    Private Sub Main_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        chkDatabaseConnection()

        Me.Show()


        ' Open login form

        frmModal.ShowInTaskbar = False
        frmModal.StartPosition = FormStartPosition.Manual
        frmModal.Location = Me.Location
        frmModal.Size = Me.Size
        frmModal.TopMost = False
        frmModal.Owner = Me
        frmModal.Show()
        With frmSignIn
            '.txtUserName.PlaceholderText = "Username"
            '.txtPassword.PlaceholderText = "Password"
            .ShowInTaskbar = False
            .TopMost = False
            .Owner = Me
            .StartPosition = FormStartPosition.CenterParent
            .ShowDialog()
        End With
        'btnUser.Text = StrConv(userName, VbStrConv.ProperCase)
        'frmLogin.Close()
        frmModal.Dispose()



    End Sub

End Class
