Public Class Main
    Private Sub Main_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        chkDatabaseConnection()

        Me.Show()



        With frmSignIn
            .Guna2TextBox1.PlaceholderText = "test"
        End With
        displayForm(Me, frmSignIn)


    End Sub

    Private Sub btnDashboard_Click(sender As Object, e As EventArgs) Handles btnDashboard.Click
        bunifuPagesMain.SetPage(0)
        'With frmBrgyOfficial
        '    .TopLevel = False
        '    pnlBrgyOfficial.Controls.Add(frmBrgyOfficial)
        '    .BringToFront()
        '    .Show()
        'End With
    End Sub

    Private Sub btnFiles_Click(sender As Object, e As EventArgs) Handles btnFiles.Click
        bunifuPagesMain.SetPage(1)
        'With frmBrgyOfficial
        '    .TopLevel = False
        '    pnlBrgyOfficial.Controls.Add(frmBrgyOfficial)
        '    .BringToFront()
        '    .Show()
        'End With
    End Sub

    Private Sub btnUsers_Click(sender As Object, e As EventArgs) Handles btnUsers.Click
        bunifuPagesMain.SetPage(2)
        'With frmBrgyOfficial
        '    .TopLevel = False
        '    pnlBrgyOfficial.Controls.Add(frmBrgyOfficial)
        '    .BringToFront()
        '    .Show()
        'End With
    End Sub

    Private Sub btnHistory_Click(sender As Object, e As EventArgs) Handles btnHistory.Click
        bunifuPagesMain.SetPage(3)
        'With frmBrgyOfficial
        '    .TopLevel = False
        '    pnlBrgyOfficial.Controls.Add(frmBrgyOfficial)
        '    .BringToFront()
        '    .Show()
        'End With
    End Sub

    Private Sub btnSettings_Click(sender As Object, e As EventArgs) Handles btnSettings.Click
        bunifuPagesMain.SetPage(4)
        'With frmBrgyOfficial
        '    .TopLevel = False
        '    pnlBrgyOfficial.Controls.Add(frmBrgyOfficial)
        '    .BringToFront()
        '    .Show()
        'End With
    End Sub

    Private Sub btnCurrentUser_Click(sender As Object, e As EventArgs) Handles btnCurrentUser.Click
        bunifuPagesMain.SetPage(5)
        'With frmBrgyOfficial
        '    .TopLevel = False
        '    pnlBrgyOfficial.Controls.Add(frmBrgyOfficial)
        '    .BringToFront()
        '    .Show()
        'End With
    End Sub
End Class
