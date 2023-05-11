Public Class frmUpdateUserInformation
    Private Sub btnUpdate_Click(sender As Object, e As EventArgs) Handles btnUpdateInfo.Click


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

            MessageBox.Show("Record Successfully Save", "Save Record", MessageBoxButtons.OK, MessageBoxIcon.Information)

            Me.Close()
            frmUpdateUser.Close()


        Catch ex As Exception
            MessageBox.Show("" & ex.Message)
        End Try


    End Sub



End Class