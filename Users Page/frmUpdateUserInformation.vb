Public Class frmUpdateUserInformation
    Private Sub btnUpdate_Click(sender As Object, e As EventArgs) Handles btnUpdateInfo.Click

        'TODO: Add descriptive message
        'TODO: validate email and phone no

        If txtFirstName.Text = "" Then
            clearEP()
            ErrorProviderHelper.SetError(txtFirstName, "First Name field is required.")
            Return
        ElseIf txtLastName.Text = "" Then
            clearEP()
            ErrorProviderHelper.SetError(txtLastName, "Last Name field is required.")
            Return
        ElseIf txtPhoneNo.Text = "" Then
            clearEP()
            ErrorProviderHelper.SetError(txtPhoneNo, "Phone No. field is required.")
            Return
        ElseIf Not IsValidPhoneNumber(txtPhoneNo.Text) Then
            clearEP()
            ErrorProviderHelper.SetError(txtPhoneNo, "Invalid phone number.")
            Return
        ElseIf txtEmailAdd.Text = "" Then
            clearEP()
            ErrorProviderHelper.SetError(txtEmailAdd, "Email Address field is required.")
            Return
        ElseIf Not IsValidEmail(txtEmailAdd.Text) Then
            clearEP()
            ErrorProviderHelper.SetError(txtEmailAdd, "Invalid email address.")
            Return
        Else
            clearEP()
        End If

        If MessageBox.Show("Are you sure you want to update the user information?", "Confirm Update", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = DialogResult.Yes Then

            Try


                With command
                    .Parameters.Clear()
                    .CommandText = "procUpdateUserInformation"
                    .CommandType = CommandType.StoredProcedure
                    .Parameters.AddWithValue("@p_id", userID)
                    .Parameters.AddWithValue("@p_first_name", txtFirstName.Text)
                    .Parameters.AddWithValue("@p_last_name", txtLastName.Text)
                    .Parameters.AddWithValue("@p_phone_no", txtPhoneNo.Text)
                    .Parameters.AddWithValue("@p_email_add", txtEmailAdd.Text)
                    .Parameters.AddWithValue("@p_role_name", tempRole)
                    .ExecuteNonQuery()
                End With

                MessageBox.Show("The user has been updated.", "Update Successful", MessageBoxButtons.OK, MessageBoxIcon.Information)

                'TODO: Should change to username
                procInsertLogEvent("Edit User Information", txtFirstName.Text)

                Me.Close()
                frmUpdateUser.Close()


            Catch ex As Exception
                MessageBox.Show("" & ex.Message)
            End Try
        End If

    End Sub



End Class