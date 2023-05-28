Imports MySql.Data.MySqlClient

Public Class frmCurrentUser

    Private isFormLoaded As Boolean = True
    Private isStrongPass As Boolean = False


    Private Sub frmCurrentUser_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: (frmCurrentUser) Automatically add username to txtUsername and !! ROLE ID
        txtUsername.Text = currUsername
    End Sub

    Private Sub btnEdit_Click(sender As Object, e As EventArgs) Handles btnEdit.Click
        txtCurrentPass.Enabled = True
        txtNewPass.Enabled = True
        txtConfirmNewPass.Enabled = True

        btnEdit.Visible = False
        btnCancel.Visible = True
        btnUpdate.Visible = True

        isFormLoaded = False
    End Sub

    Private Sub btnCancel_Click(sender As Object, e As EventArgs) Handles btnCancel.Click
        'EPNewPass.Clear()

        txtCurrentPass.Clear()
        txtNewPass.Clear()
        txtConfirmNewPass.Clear()

        txtCurrentPass.Enabled = False
        txtNewPass.Enabled = False
        txtConfirmNewPass.Enabled = False

        btnEdit.Visible = True
        btnCancel.Visible = False
        btnUpdate.Visible = False
        lblPassErr.Visible = False
        lblPassStr.Visible = False


    End Sub

    Private Sub btnUpdate_Click(sender As Object, e As EventArgs) Handles btnUpdate.Click

        'TODO: (frmCurrentUser) Add Error Provider Control

        'If txtConfirmNewPass.Text = "" Then
        '    EPNewPass.SetIconPadding(txtConfirmNewPass, 3)
        '    EPNewPass.SetError(txtConfirmNewPass, "New Password is Required")
        '    Exit Sub
        'Else
        '    EPNewPass.Clear()
        'End If

        procUpdateUserPassword()
    End Sub

    Private Sub txtConfirmNewPass_TextChanged(sender As Object, e As EventArgs) Handles txtConfirmNewPass.TextChanged

        'TODO: Need to edit border color

        If Not isFormLoaded Then


            If txtNewPass.Text = txtConfirmNewPass.Text And isStrongPass Then
                ' Two conditions are true - enable update button
                lblPassStr.Visible = False
                lblPassErr.Visible = False
                txtConfirmNewPass.FocusedState.BorderColor = Color.Green
                txtConfirmNewPass.BorderColor = Color.Green
                txtNewPass.FocusedState.BorderColor = Color.Green
                txtNewPass.BorderColor = Color.Green
                btnUpdate.Enabled = True
            ElseIf Not isStrongPass And txtNewPass.Text <> txtConfirmNewPass.Text Then
                ' show two err
                lblPassStr.Visible = True
                lblPassErr.Visible = True
                txtConfirmNewPass.FocusedState.BorderColor = Color.Red
                txtConfirmNewPass.BorderColor = Color.Red
                txtNewPass.FocusedState.BorderColor = Color.Red
                txtNewPass.BorderColor = Color.Red

                btnUpdate.Enabled = False
            ElseIf txtNewPass.Text <> txtConfirmNewPass.Text And isStrongPass Then
                ' show not match err
                lblPassErr.Visible = True
                lblPassStr.Visible = False

                txtNewPass.FocusedState.BorderColor = Color.Green
                txtNewPass.BorderColor = Color.Green

                txtConfirmNewPass.FocusedState.BorderColor = Color.Red
                txtConfirmNewPass.BorderColor = Color.Red
                btnUpdate.Enabled = False
            ElseIf Not isStrongPass And txtNewPass.Text = txtConfirmNewPass.Text Then
                'show pass str er
                lblPassErr.Visible = False
                lblPassStr.Visible = True

                txtNewPass.FocusedState.BorderColor = Color.Red
                txtNewPass.BorderColor = Color.Red

                txtConfirmNewPass.FocusedState.BorderColor = Color.Green
                txtConfirmNewPass.BorderColor = Color.Green
                btnUpdate.Enabled = False
            End If


        End If

    End Sub

    Private Sub txtConfirmNewPass_Leave(sender As Object, e As EventArgs) Handles txtConfirmNewPass.Leave
        'If txtNewPass.Text <> txtConfirmNewPass.Text Then
        '    txtConfirmNewPass.BorderColor = Color.Red
        '    lblPassErr.Visible = True
        'Else
        '    txtConfirmNewPass.BorderColor = Color.Green
        '    lblPassErr.Visible = False
        'End If
    End Sub

    Private Sub txtNewPass_TextChanged(sender As Object, e As EventArgs) Handles txtNewPass.TextChanged

        'If Not checkPasswordStrength(txtNewPass.Text) Then
        '    lblPassStr.Visible = True
        'Else
        '    lblPassStr.Visible = False
        'End If

        If Not isFormLoaded Then

            isStrongPass = CheckPasswordStrength(txtNewPass.Text)



            If txtNewPass.Text = txtConfirmNewPass.Text And isStrongPass Then
                ' Two conditions are true - enable update button
                lblPassStr.Visible = False
                lblPassErr.Visible = False
                txtConfirmNewPass.FocusedState.BorderColor = Color.Green
                txtConfirmNewPass.BorderColor = Color.Green
                txtNewPass.FocusedState.BorderColor = Color.Green
                txtNewPass.BorderColor = Color.Green
                btnUpdate.Enabled = True
            ElseIf Not isStrongPass And txtNewPass.Text <> txtConfirmNewPass.Text Then
                ' show two err
                lblPassStr.Visible = True
                lblPassErr.Visible = True
                txtConfirmNewPass.FocusedState.BorderColor = Color.Red
                txtConfirmNewPass.BorderColor = Color.Red
                txtNewPass.FocusedState.BorderColor = Color.Red
                txtNewPass.BorderColor = Color.Red

                btnUpdate.Enabled = False
            ElseIf txtNewPass.Text <> txtConfirmNewPass.Text And isStrongPass Then
                ' show not match err
                lblPassErr.Visible = True
                lblPassStr.Visible = False

                txtNewPass.FocusedState.BorderColor = Color.Green
                txtNewPass.BorderColor = Color.Green

                txtConfirmNewPass.FocusedState.BorderColor = Color.Red
                txtConfirmNewPass.BorderColor = Color.Red
                btnUpdate.Enabled = False
            ElseIf Not isStrongPass And txtNewPass.Text = txtConfirmNewPass.Text Then
                'show pass str er
                lblPassErr.Visible = False
                lblPassStr.Visible = True

                txtNewPass.FocusedState.BorderColor = Color.Red
                txtNewPass.BorderColor = Color.Red

                txtConfirmNewPass.FocusedState.BorderColor = Color.Green
                txtConfirmNewPass.BorderColor = Color.Green
                btnUpdate.Enabled = False
            End If





        End If



    End Sub

    Private Sub procUpdateUserPassword()
        sqlAdapterFilio = New MySqlDataAdapter
        datFilio = New DataTable

        Try

            With command
                .Parameters.Clear()
                .CommandText = "procSelectUserLogin"
                .CommandType = CommandType.StoredProcedure
                .Parameters.AddWithValue("@p_username", txtUsername.Text)
                .Parameters.AddWithValue("@p_password", txtCurrentPass.Text)
                sqlAdapterFilio.SelectCommand = command
                datFilio.Clear()
                sqlAdapterFilio.Fill(datFilio)
                If datFilio.Rows.Count > 0 Then
                    'TODO: (frmCurrentUser) Add confirmation message
                    updatePassword(txtUsername.Text, txtNewPass.Text)
                    MessageBox.Show("Password changed successfully.", "Update Successful", MessageBoxButtons.OK, MessageBoxIcon.Information)
                    procInsertLogEvent("Changed User Password", "User: " & txtUsername.Text)
                    btnCancel.PerformClick()
                Else
                    MessageBox.Show("The username and current password do not match. Please verify your credentials and try again.", "Password Mismatch", MessageBoxButtons.OK, MessageBoxIcon.Information)
                End If
            End With

            sqlAdapterFilio.Dispose()
            datFilio.Dispose()

        Catch ex As Exception
            MessageBox.Show("" & ex.Message)
        End Try

    End Sub


    Private Sub updatePassword(ByVal username As String, ByVal newPassword As String)
        Try
            With command
                .Parameters.Clear()
                .CommandText = "procUpdatePassword"
                .Parameters.AddWithValue("@p_username", username)
                .Parameters.AddWithValue("@p_password", newPassword)
                .ExecuteNonQuery()
            End With
        Catch ex As Exception
            MessageBox.Show("" + ex.Message)
        End Try
    End Sub

End Class