Imports MySql.Data.MySqlClient
Public Class frmAddLocation
    Private Sub btnCancel_Click(sender As Object, e As EventArgs) Handles btnCancel.Click
        clearControls(Me)
        clearEP()
        Me.Close()
    End Sub

    Private Sub btnSubmit_Click(sender As Object, e As EventArgs) Handles btnSubmit.Click

        'TODO: Add descriptive message

        If txtName.Text = "" Then
            clearEP()
            ErrorProviderHelper.SetError(txtName, "Name field is required.")
            Return
        Else
            clearEP()
        End If


        Try
            With command
                .Parameters.Clear()
                .CommandText = "procInsertLocation"
                .CommandType = CommandType.StoredProcedure
                .Parameters.AddWithValue("@p_name", txtName.Text)
                .ExecuteNonQuery()
            End With

            MessageBox.Show("The location has been added", "Add Successful", MessageBoxButtons.OK, MessageBoxIcon.Information)

            procInsertLogEvent("Added Location", "Location: " & txtName.Text)

            Me.Close()
        Catch ex As Exception
            MessageBox.Show("" & ex.Message)
        End Try
    End Sub

    Private Sub btnUpdate_Click(sender As Object, e As EventArgs) Handles btnUpdate.Click

        If txtName.Text = "" Then
            clearEP()
            ErrorProviderHelper.SetError(txtName, "test")
            Return
        Else
            clearEP()
        End If
        If MessageBox.Show("Are you sure you want to update the location?", "Confirm Update", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = DialogResult.Yes Then
            Try

                With command
                    .Parameters.Clear()
                    .CommandText = "procUpdateLocation"
                    .CommandType = CommandType.StoredProcedure
                    .Parameters.AddWithValue("@p_id", locationID)
                    .Parameters.AddWithValue("@p_name", txtName.Text)
                    .ExecuteNonQuery()
                End With
                frmFiles.Dispose()
                frmArchive.Dispose()

                MessageBox.Show("The location has been updated.", "Update Successful", MessageBoxButtons.OK, MessageBoxIcon.Information)

                procInsertLogEvent("Updated Location", "Location: " & txtName.Text)

                Me.Close()
            Catch ex As Exception
                MessageBox.Show("" & ex.Message)
            End Try
        End If
    End Sub
End Class