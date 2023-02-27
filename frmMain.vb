Public Class frmMain
    Private Sub Main_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        chkDatabaseConnection()

        Me.Show()

        'TODO: (frmMain) Remove and Uncomment this for frmSignIn

        'btnCurrentUser.Visible = True
        'btnLogout.Visible = True

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
        With frmCurrentUser
            .TopLevel = False
            ' TODO: (REMINDER) adding pages directly -> bunifuPagesMain.SelectedTab().Controls.Add(frmCurrentUser)
            panelCurrentUser.Controls.Add(frmCurrentUser)
            .BringToFront()
            .Show()
        End With
    End Sub

    Private Sub btnLogout_Click(sender As Object, e As EventArgs) Handles btnLogout.Click

        btnLogout.Visible = False
        btnCurrentUser.Visible = False

        ' TODO: (frmMain) set other button checked to false
        btnDashboard.Checked = False



        displayForm(Me, frmSignIn)
    End Sub
End Class
