Imports MySql.Data.MySqlClient
Public Class frmAddLocation
    Private Sub btnCancel_Click(sender As Object, e As EventArgs) Handles btnCancel.Click
        clearControls(Me)
        Me.Close()
    End Sub

    Private Sub btnSubmit_Click(sender As Object, e As EventArgs) Handles btnSubmit.Click
        Try
            With command
                .Parameters.Clear()
                .CommandText = "procInsertLocation"
                .CommandType = CommandType.StoredProcedure
                .Parameters.AddWithValue("@p_name", txtName.Text)
                .ExecuteNonQuery()
            End With

            MessageBox.Show("Record Successfully Save", "Save Record", MessageBoxButtons.OK, MessageBoxIcon.Information)

            procInsertLogEvent("Add Location", txtName.Text)

            Me.Close()
        Catch ex As Exception
            MessageBox.Show("" & ex.Message)
        End Try
    End Sub

    Private Sub btnUpdate_Click(sender As Object, e As EventArgs) Handles btnUpdate.Click
        Try

            With command
                .Parameters.Clear()
                .CommandText = "procUpdateLocation"
                .CommandType = CommandType.StoredProcedure
                .Parameters.AddWithValue("@p_id", locationID)
                .Parameters.AddWithValue("@p_name", txtName.Text)
                .ExecuteNonQuery()
            End With

            MessageBox.Show("Record Successfully Updated", "Update Record", MessageBoxButtons.OK, MessageBoxIcon.Information)

            procInsertLogEvent("Edit Location", txtName.Text)

            Me.Close()
        Catch ex As Exception
            MessageBox.Show("" & ex.Message)
        End Try
    End Sub
End Class