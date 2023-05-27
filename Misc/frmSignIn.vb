Imports MySql.Data.MySqlClient
Public Class frmSignIn

    Private Sub btnSignIn_Click(sender As Object, e As EventArgs) Handles btnSignIn.Click
        datFilio = New DataTable
        sqlAdapterFilio = New MySqlDataAdapter

        Try
            With command
                .Parameters.Clear()
                .CommandText = "procSearchUser"
                .Parameters.AddWithValue("@p_username", Trim(txtUsername.Text))
                .Parameters.AddWithValue("@p_password", Trim(txtPassword.Text))
                .CommandType = CommandType.StoredProcedure
                sqlAdapterFilio.SelectCommand = command
                datFilio.Clear()
                sqlAdapterFilio.Fill(datFilio)
                If datFilio.Rows.Count > 0 Then
                    'userName = txtUserName.Text
                    'userType = datBrgy.Rows(0).Item("position").ToString
                    currUsername = datFilio.Rows(0).Item("username").ToString
                    currUserID = datFilio.Rows(0).Item("id").ToString
                    currRole = datFilio.Rows(0).Item("role_name").ToString

                    procInsertLogEvent("Sign In", "Filio")
                    isLoggedIn = True

                    Me.Close()

                    txtUsername.Clear()
                    txtPassword.Clear()

                    With frmMain
                        '.btnLogInOut.Text = "Logout"
                        '.btnLogInOut.Location = locLogInOut
                        '.btnUser.Visible = True

                        '.btnDashboard.Enabled = True
                        '.btnBrgyOfficial.Enabled = True
                        '.btnResident.Enabled = True
                        '.btnBlotter.Enabled = True
                        '.btnCertificate.Enabled = True
                        '.btnAbout.Enabled = True

                        .pBLogo.Visible = True
                        .lblMenu.Visible = True
                        .btnDashboard.Visible = True
                        .btnFiles.Visible = True
                        .btnTransaction.Visible = True


                        If currRole.Equals("Employee") Then
                            .btnUsers.Visible = False
                            .btnHistory.Visible = False
                            .btnSettings.Visible = False

                            With frmFiles
                                .btnAdd.Visible = False
                                .grdFiles.Columns("Edit").Visible = False
                                .grdFiles.Columns("Delete").Visible = False
                            End With

                            With frmTransaction
                                .grdTransaction.Columns("Delete").Visible = False
                            End With

                        Else
                            .btnUsers.Visible = True
                            .btnHistory.Visible = True
                            .btnSettings.Visible = True

                            With frmFiles
                                .btnAdd.Visible = True
                                .grdFiles.Columns("Edit").Visible = True
                                .grdFiles.Columns("Delete").Visible = True
                            End With

                            'With frmTransaction
                            '    .grdTransaction.Columns("Delete").Visible = True
                            'End With

                        End If


                        .btnLogout.Visible = True
                        .btnCurrentUser.Visible = True
                        .btnCurrentUser.Text = LimitUsernameText(currUsername)
                        .btnDashboard.PerformClick()

                    End With

                    Me.Dispose()
                Else
                    MessageBox.Show("Invalid username or password. Please try again with valid credentials.", "Sign In Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                    txtUsername.Clear()
                    txtPassword.Clear()

                End If

            End With
            datFilio.Dispose()
            sqlAdapterFilio.Dispose()

        Catch ex As Exception
            MessageBox.Show("" + ex.Message)
        End Try
    End Sub

    Private Sub Guna2ControlBox1_Click(sender As Object, e As EventArgs) Handles Guna2ControlBox1.Click
        Application.DoEvents()
        Application.Exit()
    End Sub

    Private Sub txtUsername_KeyDown(sender As Object, e As KeyEventArgs) Handles txtUsername.KeyDown
        If e.KeyCode = Keys.Enter Then
            e.SuppressKeyPress = True ' Prevent the "Enter" key from adding a new line in the textbox
            btnSignIn.PerformClick() ' Trigger the click event of the sign-in button
        End If
    End Sub

    Private Sub txtPassword_KeyDown(sender As Object, e As KeyEventArgs) Handles txtPassword.KeyDown
        If e.KeyCode = Keys.Enter Then
            e.SuppressKeyPress = True ' Prevent the "Enter" key from adding a new line in the textbox
            btnSignIn.PerformClick() ' Trigger the click event of the sign-in button
        End If
    End Sub

    Private Sub frmSignIn_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        txtUsername.Focus()
    End Sub
End Class