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
                lblTotalFiles.Text = datFilio.Rows.Count & " Files"
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
                grdFiles.Rows(0).Selected = True
            Else
                grdFiles.Rows.Clear()
                MessageBox.Show("No records found.", "Record Status", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)

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
            txtSearch.Clear()
        Catch ex As Exception
            MessageBox.Show("" & ex.Message)
        End Try
    End Sub

    Private Sub grdFiles_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles grdFiles.CellContentClick
        colName = grdFiles.Columns(e.ColumnIndex).Name
        fileId = CInt(grdFiles.CurrentRow.Cells(1).Value.ToString)

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
                    locationName = grdFiles.CurrentRow.Cells(4).Value.ToString()

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

                If txtSearch.Text.Length > 0 Then
                    procAutoDisplayFilesBySearchType(cmbSearchType.Text, txtSearch.Text)
                End If

                clearControls(frmAddFile)
                clearEP()
                'txtSearch.Clear()
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
                If MessageBox.Show("Are you sure you want to delete the selected file?", "Confirm Deletion", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = DialogResult.Yes Then
                    ' Perform the deletion

                    Dim userInput As String = InputBox("Please enter 'CONFIRM' in capital letters to delete the file:", "Confirm Deletion")

                    If userInput.Trim() = "CONFIRM" Then
                        With command
                            .Parameters.Clear()
                            .CommandText = "procDeleteFile"
                            .CommandType = CommandType.StoredProcedure
                            .Parameters.AddWithValue("@p_id", fileId)
                            .ExecuteNonQuery()
                            MessageBox.Show("The file has been deleted.", "Delete Successful", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)

                            procInsertLogEvent("Deleted File", "File: " & grdFiles.CurrentRow.Cells(2).Value.ToString)
                        End With
                        ' refresh/reload customer records in data grid view
                        procDisplayAllFiles()
                        frmArchive.Dispose()
                        txtSearch.Clear()
                    Else
                        ' Cancel deletion
                        MessageBox.Show("Deletion canceled.", "Confirmation", MessageBoxButtons.OK, MessageBoxIcon.Information)
                    End If
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

                    .txtDateAdded.Text = DateTime.Parse(grdFiles.CurrentRow.Cells(6).Value.ToString()).ToString("dddd, MMMM dd, yyyy")
                    .txtDateModified.Text = DateTime.Parse(grdFiles.CurrentRow.Cells(7).Value.ToString()).ToString("dddd, MMMM dd, yyyy")
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

    Private Sub txtSearch_TextChanged(sender As Object, e As EventArgs) Handles txtSearch.TextChanged
        procAutoDisplayFilesBySearchType(cmbSearchType.Text, txtSearch.Text)
    End Sub

    '=========================== Search Functionality
    Private Sub procAutoDisplayFilesBySearchType(ByVal p_searchType As String, ByVal p_searchText As String)
        Try
            With command
                .Parameters.Clear()
                .CommandText = "procAutoDisplayFilesBySearchType"
                .CommandType = CommandType.StoredProcedure
                .Parameters.AddWithValue("@p_search_type", p_searchType)
                .Parameters.AddWithValue("@p_value", p_searchText)
                sqlAdapterFilio.SelectCommand = command
                datFilio.Clear()
                sqlAdapterFilio.Fill(datFilio)
                lblTotalFiles.Text = datFilio.Rows.Count & " Files"
            End With
            If datFilio.Rows.Count > 0 Then
                grdFiles.RowCount = datFilio.Rows.Count
                lblTotalFiles.Text = datFilio.Rows.Count & " Files"
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
                'MessageBox.Show("NO Record Found!", "Record Status", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)

            End If
            datFilio.Dispose()
            sqlAdapterFilio.Dispose()

        Catch ex As Exception
            MessageBox.Show("" & ex.Message)
        End Try

    End Sub

    Private Sub grdFiles_CellFormatting(sender As Object, e As DataGridViewCellFormattingEventArgs) Handles grdFiles.CellFormatting
        colName = grdFiles.Columns(e.ColumnIndex).Name
        If colName = "delete" Then ' Check if the cell is an image cell
            Dim cell As DataGridViewImageCell = grdFiles(e.ColumnIndex, e.RowIndex)
            cell.ToolTipText = "Delete" ' Set the tooltip tex
        End If

        If colName = "edit" Then ' Check if the cell is an image cell
            Dim cell As DataGridViewImageCell = grdFiles(e.ColumnIndex, e.RowIndex)
            cell.ToolTipText = "Edit/Update" ' Set the tooltip text
        End If

        If colName = "view" Then ' Check if the cell is an image cell
            Dim cell As DataGridViewImageCell = grdFiles(e.ColumnIndex, e.RowIndex)
            cell.ToolTipText = "View" ' Set the tooltip text
        End If
    End Sub


End Class