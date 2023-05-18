Imports MySql.Data.MySqlClient
Public Class frmMain
    Private Sub Main_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        chkDatabaseConnection()

        Me.Show()

        'TODO: (frmMain) Remove and Uncomment the following 2 statements for frmSignIn

        'btnCurrentUser.Visible = True
        'btnLogout.Visible = True


        bunifuPagesMain.SetPage(7)

        displayFormAsModal(Me, frmSignIn)


        BackupDatabase()

    End Sub

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
            If datFilio.Rows.Count > 0 Then
                grdDTransaction.RowCount = datFilio.Rows.Count
                row = 0
                While Not datFilio.Rows.Count - 1 < row
                    With grdDTransaction
                        .Rows(row).Cells(2).Value = datFilio.Rows(row).Item("file_name").ToString
                        .Rows(row).Cells(3).Value = DateTime.Parse(datFilio.Rows(row).Item("date").ToString()).ToString("dddd, MMMM dd, yyyy h:mm:ss tt")
                        .Rows(row).Cells(4).Value = datFilio.Rows(row).Item("type").ToString

                    End With
                    row += 1
                End While

            Else
                grdDTransaction.Rows.Clear()
                MessageBox.Show("NO Record Found!", "Record Status", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)

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

        ' TODO: (frmMain) set other button checked to false
        btnDashboard.Checked = False



        frmCurrentUser.Dispose()
        frmHistory.Dispose()
        frmFiles.Dispose()
        frmSettings.Dispose()
        frmTransaction.Dispose()
        frmUsers.Dispose()

        procInsertLogEvent("Sign Out", "Filio")

        bunifuPagesMain.SetPage(7)

        displayFormAsModal(Me, frmSignIn)
    End Sub


End Class
