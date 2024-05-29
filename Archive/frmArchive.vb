Imports MySql.Data.MySqlClient

Public Class frmArchive
    Private Sub frmArchive_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        procDisplayArchivedFiles()
    End Sub

    Private Sub procDisplayArchivedFiles()
        datFilio = New DataTable
        sqlAdapterFilio = New MySqlDataAdapter

        Try
            With command
                .Parameters.Clear()
                .CommandText = "procDisplayArchivedFiles"
                .CommandType = CommandType.StoredProcedure
                sqlAdapterFilio.SelectCommand = command
                datFilio.Clear()
                sqlAdapterFilio.Fill(datFilio)
                lblTotalFiles.Text = datFilio.Rows.Count & " Files"
            End With
            If datFilio.Rows.Count > 0 Then
                grdArchivedFiles.RowCount = datFilio.Rows.Count
                row = 0
                While Not datFilio.Rows.Count - 1 < row
                    With grdArchivedFiles
                        .Rows(row).Cells(1).Value = datFilio.Rows(row).Item("id").ToString
                        .Rows(row).Cells(2).Value = datFilio.Rows(row).Item("name").ToString
                        .Rows(row).Cells(3).Value = datFilio.Rows(row).Item("description").ToString
                        .Rows(row).Cells(4).Value = datFilio.Rows(row).Item("location").ToString
                        .Rows(row).Cells(5).Value = datFilio.Rows(row).Item("status").ToString
                        .Rows(row).Cells(6).Value = datFilio.Rows(row).Item("date_added").ToString
                        .Rows(row).Cells(7).Value = datFilio.Rows(row).Item("date_modified").ToString
                        .Rows(row).Cells(8).Value = DateTime.Parse(datFilio.Rows(row).Item("deleted_at")).ToString("f")
                    End With
                    row += 1
                End While
                grdArchivedFiles.Rows(0).Selected = True
            Else
                grdArchivedFiles.Rows.Clear()
                MessageBox.Show("No records found.", "Record Status", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)

            End If

            datFilio.Dispose()
            sqlAdapterFilio.Dispose()

        Catch ex As Exception
            MessageBox.Show("" & ex.Message)
        End Try
    End Sub

    Private Sub grdArchivedFiles_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles grdArchivedFiles.CellContentClick
        colName = grdArchivedFiles.Columns(e.ColumnIndex).Name
        fileId = CInt(grdArchivedFiles.CurrentRow.Cells(1).Value.ToString)
        '-- VIEW

        If colName = "view" Then
            Try


                With frmViewFile

                    .txtName.Text = grdArchivedFiles.CurrentRow.Cells(2).Value.ToString()
                    .txtDescription.Text = grdArchivedFiles.CurrentRow.Cells(3).Value.ToString()
                    .txtLocation.Text = grdArchivedFiles.CurrentRow.Cells(4).Value.ToString()

                    Dim idx As Integer

                    If grdArchivedFiles.CurrentRow.Cells(5).Value.ToString().Equals("Available") Then
                        idx = 0
                    Else
                        idx = 1
                    End If

                    .cmbStatus.SelectedIndex = idx

                    .txtDateAdded.Text = DateTime.Parse(grdArchivedFiles.CurrentRow.Cells(6).Value.ToString()).ToString("dddd, MMMM dd, yyyy")
                    .txtDateModified.Text = DateTime.Parse(grdArchivedFiles.CurrentRow.Cells(7).Value.ToString()).ToString("dddd, MMMM dd, yyyy")
                End With
                displayFormAsModal(frmMain, frmViewFile)



            Catch ex As Exception
                MessageBox.Show("" & ex.Message)
            End Try


            'If txtSearch.Text.Length > 0 And chkAuto.Checked = False And colName <> "Delete" Then
            '    btnSearch.PerformClick()
            'End If
        End If


        '-- RESTORE 

        If colName = "restore" Then


            Try
                If MessageBox.Show("Are you sure you want to restore the selected file?", "Confirm Restoration", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = DialogResult.Yes Then
                    ' Perform the restoration

                    Dim userInput As String = InputBox("Please enter 'CONFIRM' in capital letters to restore the file:", "Confirm Restoration")

                    If userInput.Trim() = "CONFIRM" Then
                        With command
                            .Parameters.Clear()
                            .CommandText = "procRestoreFile"
                            .CommandType = CommandType.StoredProcedure
                            .Parameters.AddWithValue("@p_id", fileId)
                            .ExecuteNonQuery()
                            MessageBox.Show("The file has been restored.", "Restore Successful", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)

                            procInsertLogEvent("Restored File", "File: " & grdArchivedFiles.CurrentRow.Cells(2).Value.ToString)
                        End With
                        ' refresh/reload customer records in data grid view
                        procDisplayArchivedFiles()
                        frmFiles.Dispose()
                    Else
                        ' Cancel deletion
                        MessageBox.Show("Restoration canceled.", "Confirmation", MessageBoxButtons.OK, MessageBoxIcon.Information)
                    End If
                End If
            Catch ex As Exception
                MessageBox.Show("" & ex.Message)
            End Try


        End If



    End Sub

End Class