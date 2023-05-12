﻿Public Class frmMain
    Private Sub Main_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        chkDatabaseConnection()

        Me.Show()

        'TODO: (frmMain) Remove and Uncomment the following 2 statements for frmSignIn

        btnCurrentUser.Visible = True
        btnLogout.Visible = True


        bunifuPagesMain.SetPage(7)

        'displayFormAsModal(Me, frmSignIn)




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

    Private Sub btnLogout_Click(sender As Object, e As EventArgs) Handles btnLogout.Click

        btnLogout.Visible = False
        btnCurrentUser.Visible = False

        ' TODO: (frmMain) set other button checked to false
        btnDashboard.Checked = False


        bunifuPagesMain.SetPage(7)

        displayFormAsModal(Me, frmSignIn)
    End Sub


End Class
