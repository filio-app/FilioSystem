Imports MySql.Data.MySqlClient

Public Class frmAddFile

    Dim selectedName As String
    Dim selectedId As Integer

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
                .Parameters.AddWithValue("@p_description", txtDescription.Text)
                .Parameters.AddWithValue("@p_location_id", selectedId)
                .Parameters.AddWithValue("@p_status", cmbStatus.Text)
                .ExecuteNonQuery()
            End With

            datFilio.Dispose()
            sqlAdapterFilio.Dispose()

            MessageBox.Show("Record Successfully Save", "Save Record", MessageBoxButtons.OK, MessageBoxIcon.Information)

            procInsertLogEvent("Add File", txtName.Text)

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
                .Parameters.AddWithValue("@p_id", userID)
                .Parameters.AddWithValue("@p_name", txtName.Text)
                .Parameters.AddWithValue("@p_description", txtDescription.Text)
                .Parameters.AddWithValue("@p_location_id", selectedId)
                .Parameters.AddWithValue("@p_status", cmbStatus.Text)
                .ExecuteNonQuery()
            End With

            datFilio.Dispose()
            sqlAdapterFilio.Dispose()

            MessageBox.Show("Record Successfully Updated", "Update Record", MessageBoxButtons.OK, MessageBoxIcon.Information)

            procInsertLogEvent("Edit File", txtName.Text)

            Me.Close()
        Catch ex As Exception
            MessageBox.Show("" & ex.Message)
        End Try
    End Sub

    Private Sub frmAddFile_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        cmbLocation.Items.Clear()
        locationTable.Clear()

        fillDataComboLocation()
        If lblHeader.Text = "Update File" Then
            cmbLocation.SelectedIndex = cmbLocation.Items.IndexOf(locationName)
        End If
    End Sub

    Private Sub fillDataComboLocation()
        sqlAdapterFilio = New MySqlDataAdapter
        datFilio = New DataTable

        Try
            With command
                .Parameters.Clear()
                'TODO: (frmAddFile) add Where clause deleted_at
                .CommandText = "SELECT * FROM location"
                .CommandType = CommandType.Text
                .ExecuteNonQuery()
                sqlAdapterFilio.SelectCommand = command
                datFilio.Clear()
                sqlAdapterFilio.Fill(datFilio)
                If datFilio.Rows.Count > 0 Then
                    row = 0
                    While Not datFilio.Rows.Count - 1 < row
                        cmbLocation.Items.Add("" & datFilio.Rows(row).Item("name").ToString)

                        locationTable.Add(datFilio.Rows(row).Item("name").ToString, CInt(datFilio.Rows(row).Item("id")))

                        row = row + 1
                    End While
                End If
            End With

            datFilio.Dispose()
            sqlAdapterFilio.Dispose()

        Catch ex As Exception
            MessageBox.Show("" + ex.Message)
        End Try
    End Sub

    Private Sub cmbLocation_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmbLocation.SelectedIndexChanged
        ' Get the ID of the selected location from the HashTable
        selectedName = cmbLocation.SelectedItem.ToString()
        selectedId = locationTable(selectedName)
    End Sub
End Class