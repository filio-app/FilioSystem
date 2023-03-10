Imports MySql.Data.MySqlClient
Public Class frmFiles

    Private Sub frmFiles_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        procDisplayAllFiles()
    End Sub

    Private Sub procDisplayAllFiles()
        datFilio = New DataTable
        sqlAdapterFilio = New MySqlDataAdapter

        Try
            With command
                .Parameters.Clear()
                .CommandText = "procDisplayAllFiles"
                .CommandType = CommandType.StoredProcedure
                sqlAdapterFilio.SelectCommand = command
                datFilio.Clear()
                sqlAdapterFilio.Fill(datFilio)
                'TODO: (frmFiles) Add total files as labels
                'lblTotal.Text = "Total Records : " & datHotel.Rows.Count
            End With
            If datFilio.Rows.Count > 0 Then
                grdFiles.RowCount = datFilio.Rows.Count
                row = 0
                While Not datFilio.Rows.Count - 1 < row
                    With grdFiles
                        .Rows(row).Cells(1).Value = datFilio.Rows(row).Item("id").ToString
                        .Rows(row).Cells(2).Value = datFilio.Rows(row).Item("name").ToString
                        .Rows(row).Cells(3).Value = datFilio.Rows(row).Item("description").ToString
                        .Rows(row).Cells(4).Value = datFilio.Rows(row).Item("location").ToString
                        .Rows(row).Cells(5).Value = datFilio.Rows(row).Item("status").ToString
                        .Rows(row).Cells(6).Value = datFilio.Rows(row).Item("date_added").ToString
                        .Rows(row).Cells(7).Value = datFilio.Rows(row).Item("date_modified").ToString
                    End With
                    row += 1
                End While

            Else
                grdFiles.Rows.Clear()
                MessageBox.Show("NO Record Found!", "Record Status", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)

            End If
            datFilio.Dispose()
            sqlAdapterFilio.Dispose()

        Catch ex As Exception
            MessageBox.Show("" & ex.Message)
        End Try
    End Sub

    Private Sub btnAdd_Click(sender As Object, e As EventArgs) Handles btnAdd.Click
        Try
            clearControls(frmAddFile)

            With frmAddFile
                .btnUpdate.Visible = False
                .btnSubmit.Visible = True
                .lblHeader.Text = "Add File"
            End With

            displayFormAsModal(frmMain, frmAddFile)
            procDisplayAllFiles()
        Catch ex As Exception
            MessageBox.Show("" & ex.Message)
        End Try
    End Sub

    Private Sub grdFiles_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles grdFiles.CellContentClick
        colName = grdFiles.Columns(e.ColumnIndex).Name
        fileID = CInt(grdFiles.CurrentRow.Cells(1).Value.ToString)

        '-- EDIT

        If colName = "edit" Then

            Try
                'procGetSelectedResident()
                clearControls(frmAddFile)

                With frmAddFile
                    .btnUpdate.Visible = True
                    .btnSubmit.Visible = False
                    .lblHeader.Text = "Update File"

                    .txtName.Text = grdFiles.CurrentRow.Cells(2).Value.ToString()
                    .txtDescription.Text = grdFiles.CurrentRow.Cells(3).Value.ToString()
                    .txtLocation.Text = grdFiles.CurrentRow.Cells(4).Value.ToString()

                    Dim idx As Integer

                    If grdFiles.CurrentRow.Cells(5).Value.ToString().Equals("Available") Then
                        idx = 0
                    Else
                        idx = 1
                    End If

                    .cmbStatus.SelectedIndex = idx

                End With
                displayFormAsModal(frmMain, frmAddFile)
                procDisplayAllFiles()
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
                If MessageBox.Show("Are you sure you want to delete the selected record?", "Confirm Deletion", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = DialogResult.Yes Then
                    ' Perform the deletion
                    With command
                        .Parameters.Clear()
                        .CommandText = "procDeleteFile"
                        .CommandType = CommandType.StoredProcedure
                        .Parameters.AddWithValue("@p_id", fileID)
                        .ExecuteNonQuery()
                        MessageBox.Show("Record Successfully Deleted!", "Record Status", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                    End With
                    ' refresh/reload customer records in data grid view
                    procDisplayAllFiles()
                End If
            Catch ex As Exception
                MessageBox.Show("" & ex.Message)
            End Try


        End If

        '-- VIEW

        If colName = "view" Then
            Try


                With frmViewFile

                    .txtName.Text = grdFiles.CurrentRow.Cells(2).Value.ToString()
                    .txtDescription.Text = grdFiles.CurrentRow.Cells(3).Value.ToString()
                    .txtLocation.Text = grdFiles.CurrentRow.Cells(4).Value.ToString()

                    Dim idx As Integer

                    If grdFiles.CurrentRow.Cells(5).Value.ToString().Equals("Available") Then
                        idx = 0
                    Else
                        idx = 1
                    End If

                    .cmbStatus.SelectedIndex = idx

                    .txtDateAdded.Text = grdFiles.CurrentRow.Cells(6).Value.ToString()
                    .txtDateModified.Text = grdFiles.CurrentRow.Cells(7).Value.ToString()
                End With
                displayFormAsModal(frmMain, frmViewFile)



            Catch ex As Exception
                MessageBox.Show("" & ex.Message)
            End Try


            'If txtSearch.Text.Length > 0 And chkAuto.Checked = False And colName <> "Delete" Then
            '    btnSearch.PerformClick()
            'End If
        End If
    End Sub
End Class