﻿Imports MySql.Data.MySqlClient

Public Class frmAddFile

    Dim selectedName As String
    Dim selectedId As Integer

    Private Sub btnCancel_Click(sender As Object, e As EventArgs) Handles btnCancel.Click

        Me.Close()
    End Sub
    Private Sub btnSubmit_Click(sender As Object, e As EventArgs) Handles btnSubmit.Click

        'TODO: Add descriptive message

        If txtName.Text = "" Then
            clearEP()
            ErrorProviderHelper.SetError(txtName, "Name field is required.")
            Return
        ElseIf txtDescription.Text = "" Then
            clearEP()
            ErrorProviderHelper.SetError(txtDescription, "Description field is required.")
            Return
        ElseIf cmbLocation.Text = "" Then
            clearEP()
            ErrorProviderHelper.SetError(cmbLocation, "Location field is required.")
            Return
        Else
            clearEP()
        End If


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

            frmSettings.Dispose()

            datFilio.Dispose()
            sqlAdapterFilio.Dispose()
            MessageBox.Show("The file has been added.", "Add Successful", MessageBoxButtons.OK, MessageBoxIcon.Information)

            procInsertLogEvent("Added File", "File: " & txtName.Text)

            Me.Close()
        Catch ex As Exception
            MessageBox.Show("" & ex.Message)
        End Try



    End Sub



    Private Sub btnUpdate_Click(sender As Object, e As EventArgs) Handles btnUpdate.Click


        'TODO: Add descriptive message

        If txtName.Text = "" Then
            clearEP()
            ErrorProviderHelper.SetError(txtName, "Name field is required.")
            Return
        ElseIf txtDescription.Text = "" Then
            clearEP()
            ErrorProviderHelper.SetError(txtDescription, "Description field is required.")
            Return
        ElseIf cmbLocation.Text = "" Then
            clearEP()
            ErrorProviderHelper.SetError(cmbLocation, "Location field is required.")
            Return
        Else
            clearEP()
        End If


        If MessageBox.Show("Are you sure you want to update the file?", "Confirm Update", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = DialogResult.Yes Then
            Try

                With command
                    .Parameters.Clear()
                    .CommandText = "procUpdateFile"
                    .CommandType = CommandType.StoredProcedure
                    .Parameters.AddWithValue("@p_id", fileId)
                    .Parameters.AddWithValue("@p_name", txtName.Text)
                    .Parameters.AddWithValue("@p_description", txtDescription.Text)
                    .Parameters.AddWithValue("@p_location_id", selectedId)
                    .Parameters.AddWithValue("@p_status", cmbStatus.Text)
                    .ExecuteNonQuery()
                End With

                frmSettings.Dispose()

                datFilio.Dispose()
                sqlAdapterFilio.Dispose()

                MessageBox.Show("The file has been updated.", "Update Successful", MessageBoxButtons.OK, MessageBoxIcon.Information)

                procInsertLogEvent("Updated File", "File: " & txtName.Text)

                frmFiles.txtSearch.Clear()

                Me.Close()
            Catch ex As Exception
                MessageBox.Show("" & ex.Message)
            End Try

        End If
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
                .CommandText = "SELECT * FROM location WHERE deleted_at IS NULL"
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