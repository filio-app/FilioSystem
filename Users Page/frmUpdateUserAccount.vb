Public Class frmUpdateUserAccount

    Private isFormLoaded As Boolean = True
    Private isStrongPass As Boolean = False
    Private Sub frmChangePassword_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        isFormLoaded = False
        lblPassStr.Text = "Password must be 8+ characters" & Environment.NewLine & "with letters and numbers"


    End Sub



    'Password Strength

    Private Sub txtPass_TextChanged(sender As Object, e As EventArgs) Handles txtConfirmPass.TextChanged
        If Not isFormLoaded Then

            isStrongPass = CheckPasswordStrength(txtConfirmPass.Text)



            If txtConfirmPass.Text = txtPass.Text And isStrongPass Then
                ' Two conditions are true - enable update button
                lblPassStr.Visible = False
                lblPassErr.Visible = False
                txtPass.FocusedState.BorderColor = Color.Green
                txtPass.BorderColor = Color.Green

                txtConfirmPass.FocusedState.BorderColor = Color.Green
                txtConfirmPass.BorderColor = Color.Green

                btnUpdate.Enabled = True
            ElseIf Not isStrongPass And txtConfirmPass.Text <> txtPass.Text Then
                ' show two err
                lblPassStr.Visible = True
                lblPassErr.Visible = True
                txtPass.FocusedState.BorderColor = Color.Red
                txtPass.BorderColor = Color.Red

                txtConfirmPass.FocusedState.BorderColor = Color.Red
                txtConfirmPass.BorderColor = Color.Red

                btnUpdate.Enabled = False
            ElseIf txtConfirmPass.Text <> txtPass.Text And isStrongPass Then
                ' show not match err
                lblPassErr.Visible = True
                lblPassStr.Visible = False
                txtPass.FocusedState.BorderColor = Color.Green
                txtPass.BorderColor = Color.Green

                txtConfirmPass.FocusedState.BorderColor = Color.Red
                txtConfirmPass.BorderColor = Color.Red

                btnUpdate.Enabled = False
            ElseIf Not isStrongPass And txtConfirmPass.Text = txtPass.Text Then
                'show pass str er
                lblPassErr.Visible = False
                lblPassStr.Visible = True
                txtPass.FocusedState.BorderColor = Color.Red
                txtPass.BorderColor = Color.Red

                txtConfirmPass.FocusedState.BorderColor = Color.Green
                txtConfirmPass.BorderColor = Color.Green

                btnUpdate.Enabled = False
            End If




        End If
    End Sub

    Private Sub txtConfirmPass_TextChanged(sender As Object, e As EventArgs) Handles txtPass.TextChanged

        'TODO: Need to edit border color

        If Not isFormLoaded Then

            isStrongPass = CheckPasswordStrength(txtConfirmPass.Text)



            If txtConfirmPass.Text = txtPass.Text And isStrongPass Then
                ' Two conditions are true - enable update button
                lblPassStr.Visible = False
                lblPassErr.Visible = False
                txtPass.FocusedState.BorderColor = Color.Green
                txtPass.BorderColor = Color.Green

                txtConfirmPass.FocusedState.BorderColor = Color.Green
                txtConfirmPass.BorderColor = Color.Green

                btnUpdate.Enabled = True
            ElseIf Not isStrongPass And txtConfirmPass.Text <> txtPass.Text Then
                ' show two err
                lblPassStr.Visible = True
                lblPassErr.Visible = True
                txtPass.FocusedState.BorderColor = Color.Red
                txtPass.BorderColor = Color.Red

                txtConfirmPass.FocusedState.BorderColor = Color.Red
                txtConfirmPass.BorderColor = Color.Red

                btnUpdate.Enabled = False
            ElseIf txtConfirmPass.Text <> txtPass.Text And isStrongPass Then
                ' show not match err
                lblPassErr.Visible = True
                lblPassStr.Visible = False
                txtPass.FocusedState.BorderColor = Color.Green
                txtPass.BorderColor = Color.Green

                txtConfirmPass.FocusedState.BorderColor = Color.Red
                txtConfirmPass.BorderColor = Color.Red

                btnUpdate.Enabled = False
            ElseIf Not isStrongPass And txtConfirmPass.Text = txtPass.Text Then
                'show pass str er
                lblPassErr.Visible = False
                lblPassStr.Visible = True
                txtPass.FocusedState.BorderColor = Color.Red
                txtPass.BorderColor = Color.Red

                txtConfirmPass.FocusedState.BorderColor = Color.Green
                txtConfirmPass.BorderColor = Color.Green

                btnUpdate.Enabled = False
            End If



        End If


    End Sub

    Private Sub btnUpdate_Click(sender As Object, e As EventArgs) Handles btnUpdate.Click

        Try




            procUpdateUserAccount()


            MessageBox.Show("Password changed successfully.", "Update Successful", MessageBoxButtons.OK, MessageBoxIcon.Information)

            procInsertLogEvent("Changed User Password", "User: " & txtUsername.Text)

            Me.Close()
            frmUpdateUser.Close()


        Catch ex As Exception
            MessageBox.Show("" & ex.Message)
        End Try

    End Sub


    Private Sub procUpdateUserAccount()
        Try

            With command
                .Parameters.Clear()
                .CommandText = "procUpdateUserAccount"
                .CommandType = CommandType.StoredProcedure
                .Parameters.AddWithValue("@p_username", txtUsername.Text)
                .Parameters.AddWithValue("@p_password", txtPass.Text)
                .Parameters.AddWithValue("@p_role_name", cmbRole.Text)
                .ExecuteNonQuery()
            End With
        Catch ex As Exception
            MessageBox.Show("" & ex.Message)
        End Try

    End Sub

End Class