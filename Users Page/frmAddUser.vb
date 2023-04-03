Imports MySql.Data.MySqlClient

Public Class frmAddUser

    Private Sub frmAddUser_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub btnCancel_Click(sender As Object, e As EventArgs) Handles btnCancel.Click
        clearControls(Me)
        Me.Close()
    End Sub
    Private Sub btnSubmit_Click(sender As Object, e As EventArgs) Handles btnSubmit.Click



        Try
            With command
                .Parameters.Clear()
                .CommandText = "procInsertFile"
                .CommandType = CommandType.StoredProcedure
                .Parameters.AddWithValue("@p_name", txtName.Text)
                '.Parameters.AddWithValue("@p_description", txtDescription.Text)
                .Parameters.AddWithValue("@p_location", txtLocation.Text)
                .Parameters.AddWithValue("@p_status", cmbStatus.Text)
                .ExecuteNonQuery()
            End With

            MessageBox.Show("Record Successfully Save", "Save Record", MessageBoxButtons.OK, MessageBoxIcon.Information)

            Me.Close()
        Catch ex As Exception
            MessageBox.Show("" & ex.Message)
        End Try

    End Sub



    Private Sub btnUpdate_Click(sender As Object, e As EventArgs) Handles btnUpdate.Click
        Try

            With command
                .Parameters.Clear()
                .CommandText = "procUpdateFile"
                .CommandType = CommandType.StoredProcedure
                .Parameters.AddWithValue("@p_id", fileID)
                .Parameters.AddWithValue("@p_name", txtName.Text)
                '.Parameters.AddWithValue("@p_description", txtDescription.Text)
                .Parameters.AddWithValue("@p_location", txtLocation.Text)
                .Parameters.AddWithValue("@p_status", cmbStatus.Text)
                .ExecuteNonQuery()
            End With

            MessageBox.Show("Record Successfully Updated", "Update Record", MessageBoxButtons.OK, MessageBoxIcon.Information)

            Me.Close()
        Catch ex As Exception
            MessageBox.Show("" & ex.Message)
        End Try
    End Sub


End Class