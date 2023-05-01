Public Class frmAddTransaction
    Private Sub btnCancel_Click(sender As Object, e As EventArgs) Handles btnCancel.Click
        clearControls(Me)
        Me.Close()
    End Sub

    Private Sub Guna2Button1_Click(sender As Object, e As EventArgs) Handles Guna2Button1.Click
        Dim type As String = cmbType.Text



        With frmFilesBrowse
            .ShowInTaskbar = False
            .TopMost = False
            .Owner = Me
            .StartPosition = FormStartPosition.CenterParent
            .ShowDialog()
        End With


    End Sub

    Private Sub btnSubmit_Click(sender As Object, e As EventArgs) Handles btnSubmit.Click
        Try
            With command
                .Parameters.Clear()
                .CommandText = "procInsertTransaction"
                .CommandType = CommandType.StoredProcedure
                .Parameters.AddWithValue("@p_user_id", currUserID)
                .Parameters.AddWithValue("@p_file_id", tempFileID)
                '.Parameters.AddWithValue("@date", txtLocation.Text)
                .Parameters.AddWithValue("@p_type", cmbType.Text)
                .Parameters.AddWithValue("@p_notes", txtNotes.Text)
                .ExecuteNonQuery()
            End With

            MessageBox.Show("Record Successfully Save", "Save Record", MessageBoxButtons.OK, MessageBoxIcon.Information)

            'TODO: (frmAddTransaction) add log event
            'procInsertLogEvent("Add File", txtName.Text)

            Me.Close()
        Catch ex As Exception
            MessageBox.Show("" & ex.Message)
        End Try
    End Sub
End Class