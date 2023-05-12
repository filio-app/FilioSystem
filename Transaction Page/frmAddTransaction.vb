﻿Public Class frmAddTransaction
    Private Sub btnCancel_Click(sender As Object, e As EventArgs) Handles btnCancel.Click
        clearControls(Me)
        clearEP()
        Me.Close()
    End Sub

    Private Sub Guna2Button1_Click(sender As Object, e As EventArgs) Handles Guna2Button1.Click
        transactionType = cmbType.Text

        With frmFilesBrowse
            .ShowInTaskbar = False
            .TopMost = False
            .Owner = Me
            .StartPosition = FormStartPosition.CenterParent
            .ShowDialog()
        End With


    End Sub

    Private Sub btnSubmit_Click(sender As Object, e As EventArgs) Handles btnSubmit.Click

        If txtFile.Text = "" Then
            clearEP()
            ErrorProviderHelper.SetError(txtFile, "test")
            Return
        ElseIf txtNotes.Text = "" Then
            clearEP()
            ErrorProviderHelper.SetError(txtNotes, "test")
            Return
        Else
            clearEP()
        End If

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

                'UPDATE File to Issued or Available
                procUpdateFileStatus(cmbType.Text)

                frmFiles.Dispose()
            End With

            MessageBox.Show("Record Successfully Save", "Save Record", MessageBoxButtons.OK, MessageBoxIcon.Information)



            'procInsertLogEvent("Add File", txtName.Text)

            Me.Close()
        Catch ex As Exception
            MessageBox.Show("" & ex.Message)
        End Try
    End Sub

    Private Sub procUpdateFileStatus(ByVal type As String)
        Try

            With command
                .Parameters.Clear()
                .CommandText = "procUpdateFileStatus"
                .CommandType = CommandType.StoredProcedure
                .Parameters.AddWithValue("@p_id", tempFileID)

                If type.Equals("Issue") Then
                    .Parameters.AddWithValue("@p_status", "Issued")
                Else
                    .Parameters.AddWithValue("@p_status", "Available")
                End If

                .ExecuteNonQuery()
            End With
        Catch ex As Exception
            MessageBox.Show("" & ex.Message)
        End Try

    End Sub

    Private Sub cmbType_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmbType.SelectedIndexChanged
        txtFile.Text = ""
    End Sub

    Private Sub txtFile_TextChanged(sender As Object, e As EventArgs) Handles txtFile.TextChanged
        clearEP()
    End Sub
End Class