Public Class frmUpdateUser
    Private Sub frmUpdateUser_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        btnUpdateUserInfo.PerformClick()
    End Sub

    Private Sub btnUpdateUserInfo_Click(sender As Object, e As EventArgs) Handles btnUpdateUserInfo.Click
        BunifuPagesUser.SetPage(0)
        With frmUpdateUserInformation
            .TopLevel = False
            panelUserInfo.Controls.Add(frmUpdateUserInformation)
            .BringToFront()
            .Show()
        End With
    End Sub

    Private Sub btnUpdateUserPassword_Click(sender As Object, e As EventArgs) Handles btnUpdateUserPassword.Click
        BunifuPagesUser.SetPage(1)
        With frmUpdateUserAccount
            .TopLevel = False
            panelUserPass.Controls.Add(frmUpdateUserAccount)
            .BringToFront()
            .Show()
        End With
    End Sub

    Private Sub Guna2ControlBox1_Click(sender As Object, e As EventArgs) Handles Guna2ControlBox1.Click
        'Me.Dispose()
        frmUpdateUserInformation.Dispose()
        frmUpdateUserAccount.Dispose()
    End Sub
End Class