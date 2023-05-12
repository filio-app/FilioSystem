Imports MySql.Data.MySqlClient
Public Class frmLocation
    Private Sub frmLocation_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        procDisplayAllLocations()
    End Sub

    Private Sub procDisplayAllLocations()
        datFilio = New DataTable
        sqlAdapterFilio = New MySqlDataAdapter

        Try
            With command
                .Parameters.Clear()
                .CommandText = "procDisplayAllLocations"
                .CommandType = CommandType.StoredProcedure
                sqlAdapterFilio.SelectCommand = command
                datFilio.Clear()
                sqlAdapterFilio.Fill(datFilio)
                lblTotalLocations.Text = datFilio.Rows.Count & " Locations"
            End With
            If datFilio.Rows.Count > 0 Then
                grdLocation.RowCount = datFilio.Rows.Count
                row = 0
                While Not datFilio.Rows.Count - 1 < row
                    With grdLocation
                        .Rows(row).Cells(1).Value = datFilio.Rows(row).Item("id").ToString
                        .Rows(row).Cells(2).Value = datFilio.Rows(row).Item("name").ToString
                        .Rows(row).Cells(6).Value = datFilio.Rows(row).Item("num_of_files").ToString
                    End With
                    row += 1
                End While

            Else
                grdLocation.Rows.Clear()
                MessageBox.Show("NO Record Found!", "Record Status", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)

            End If
            datFilio.Dispose()
            sqlAdapterFilio.Dispose()

        Catch ex As Exception
            MessageBox.Show("" & ex.Message)
        End Try
    End Sub

    Private Sub grdLocation_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles grdLocation.CellContentClick
        colName = grdLocation.Columns(e.ColumnIndex).Name
        locationID = CInt(grdLocation.CurrentRow.Cells(1).Value.ToString)

        '-- EDIT

        If colName = "edit" Then

            Try
                'procGetSelectedResident()
                clearControls(frmAddLocation)

                With frmAddLocation
                    .btnUpdate.Visible = True
                    .btnSubmit.Visible = False
                    .lblHeader.Text = "Update Location"

                    .txtName.Text = grdLocation.CurrentRow.Cells(2).Value.ToString()

                End With
                displayFormAsModal(frmMain, frmAddLocation)
                procDisplayAllLocations()
            Catch ex As Exception
                MessageBox.Show("" & ex.Message)
            End Try
            'If txtSearch.Text.Length > 0 And chkAuto.Checked = False Then
            '    btnSearch.PerformClick()
            'End If
        End If



        '-- DELETE 

        If colName = "delete" Then


            Try
                If MessageBox.Show("Warning: Deleting this location will also delete all the associated files. There are " & grdLocation.CurrentRow.Cells(6).Value.ToString & " files associated with this location. Do you want to proceed with the deletion?", "Delete Location", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) = DialogResult.Yes Then
                    ' Perform the deletion
                    With command
                        .Parameters.Clear()
                        .CommandText = "procDeleteLocation"
                        .CommandType = CommandType.StoredProcedure
                        .Parameters.AddWithValue("@p_id", locationID)
                        .ExecuteNonQuery()

                        frmFiles.Dispose()

                        MessageBox.Show("Record Successfully Deleted!", "Record Status", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)

                        procInsertLogEvent("Delete Location", grdLocation.CurrentRow.Cells(2).Value.ToString)

                    End With
                    ' refresh/reload customer records in data grid view
                    procDisplayAllLocations()
                End If
            Catch ex As Exception
                MessageBox.Show("" & ex.Message)
            End Try


        End If
    End Sub

    Private Sub btnAdd_Click(sender As Object, e As EventArgs) Handles btnAdd.Click
        Try
            clearControls(frmAddLocation)

            With frmAddLocation
                .btnUpdate.Visible = False
                .btnSubmit.Visible = True
                .lblHeader.Text = "Add Location"
            End With

            displayFormAsModal(frmMain, frmAddLocation)
            procDisplayAllLocations()
        Catch ex As Exception
            MessageBox.Show("" & ex.Message)
        End Try
    End Sub
End Class