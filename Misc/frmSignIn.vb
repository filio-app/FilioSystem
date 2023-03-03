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

                        .btnLogout.Visible = True
                        .btnCurrentUser.Visible = True
                        .btnDashboard.PerformClick()

                    End With


                Else
                    MessageBox.Show("User not found/Invalid Password", "Sign In", MessageBoxButtons.OK, MessageBoxIcon.Error)
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
        Application.Exit()
    End Sub


End Class