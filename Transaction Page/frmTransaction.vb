Imports MySql.Data.MySqlClient
Public Class frmTransaction
    Private Sub frmTransaction_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        procDisplayAllTransactions()
    End Sub


    Private Sub procDisplayAllTransactions()
        datFilio = New DataTable
        sqlAdapterFilio = New MySqlDataAdapter

        Try
            With command
                .Parameters.Clear()
                .CommandText = "procDisplayAllTransactions"
                .CommandType = CommandType.StoredProcedure
                sqlAdapterFilio.SelectCommand = command
                datFilio.Clear()
                sqlAdapterFilio.Fill(datFilio)

                lblTotalTransactions.Text = datFilio.Rows.Count & " Transactions"
            End With
            If datFilio.Rows.Count > 0 Then
                grdTransaction.RowCount = datFilio.Rows.Count
                row = 0
                While Not datFilio.Rows.Count - 1 < row
                    With grdTransaction
                        .Rows(row).Cells(1).Value = datFilio.Rows(row).Item("id").ToString
                        .Rows(row).Cells(2).Value = datFilio.Rows(row).Item("file_name").ToString
                        .Rows(row).Cells(3).Value = DateTime.Parse(datFilio.Rows(row).Item("date").ToString()).ToString("dddd, MMMM dd, yyyy h:mm:ss tt")
                        .Rows(row).Cells(4).Value = datFilio.Rows(row).Item("status").ToString
                        .Rows(row).Cells(5).Value = datFilio.Rows(row).Item("username").ToString
                        .Rows(row).Cells(6).Value = datFilio.Rows(row).Item("notes").ToString
                        .Rows(row).Cells(7).Value = datFilio.Rows(row).Item("type").ToString
                        .Rows(row).Cells(8).Value = datFilio.Rows(row).Item("borrower_name").ToString
                        .Rows(row).Cells(9).Value = datFilio.Rows(row).Item("returner_name").ToString
                        .Rows(row).Cells(10).Value = datFilio.Rows(row).Item("department").ToString

                    End With
                    row += 1
                End While

            Else
                grdTransaction.Rows.Clear()
                MessageBox.Show("No records found.", "Record Status", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)

            End If
            datFilio.Dispose()
            sqlAdapterFilio.Dispose()

        Catch ex As Exception
            MessageBox.Show("" & ex.Message)
        End Try
    End Sub

    Private Sub btnAdd_Click(sender As Object, e As EventArgs) Handles btnAdd.Click
        clearControls(frmAddTransaction)
        displayFormAsModal(frmMain, frmAddTransaction)
        procDisplayAllTransactions()
        txtSearch.Clear()
    End Sub

    Private Sub grdTransaction_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles grdTransaction.CellContentClick
        colName = grdTransaction.Columns(e.ColumnIndex).Name
        userID = CInt(grdTransaction.CurrentRow.Cells(1).Value.ToString)





        '-- DELETE 

        If colName = "delete" Then


            Try
                If MessageBox.Show("Are you sure you want to delete the selected record?", "Confirm Deletion", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = DialogResult.Yes Then
                    ' Perform the deletion
                    With command
                        .Parameters.Clear()
                        .CommandText = "-procDeleteTransaction"
                        .CommandType = CommandType.StoredProcedure
                        .Parameters.AddWithValue("@p_id", userID)
                        .ExecuteNonQuery()
                        MessageBox.Show("The file has been deleted.", "Delete Successful", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)

                        procInsertLogEvent("Delete File", grdTransaction.CurrentRow.Cells(2).Value.ToString)

                    End With
                    ' refresh/reload customer records in data grid view
                    procDisplayAllTransactions()
                End If
            Catch ex As Exception
                MessageBox.Show("" & ex.Message)
            End Try


        End If

        '-- VIEW

        If colName = "view" Then
            Try


                With frmViewTransaction

                    .txtFileName.Text = grdTransaction.CurrentRow.Cells(2).Value.ToString()
                    .txtNotes.Text = grdTransaction.CurrentRow.Cells(6).Value.ToString()

                    Dim idx As Integer

                    If grdTransaction.CurrentRow.Cells(7).Value.ToString().Equals("Issue") Then
                        idx = 0
                        .lblBRName.Text = "Borrower's Name"
                        .txtBRName.Text = grdTransaction.CurrentRow.Cells(8).Value.ToString()
                    Else
                        idx = 1
                        .lblBRName.Text = "Returner's Name"
                        .txtBRName.Text = grdTransaction.CurrentRow.Cells(9).Value.ToString()
                    End If

                    .cmbType.SelectedIndex = idx



                    .txtDate.Text = DateTime.Parse(grdTransaction.CurrentRow.Cells(3).Value.ToString()).ToString("dddd, MMMM dd, yyyy")
                    .txtIssuedBy.Text = grdTransaction.CurrentRow.Cells(5).Value.ToString()




                    .txtDepartment.Text = grdTransaction.CurrentRow.Cells(10).Value.ToString()

                End With
                displayFormAsModal(frmMain, frmViewTransaction)



            Catch ex As Exception
                MessageBox.Show("" & ex.Message)
            End Try


            'If txtSearch.Text.Length > 0 And chkAuto.Checked = False And colName <> "Delete" Then
            '    btnSearch.PerformClick()
            'End If
        End If
    End Sub

    Private Sub txtSearch_TextChanged(sender As Object, e As EventArgs) Handles txtSearch.TextChanged
        procAutoDisplayTransactionsBySearchType(txtSearch.Text)
    End Sub

    '=========================== Search Functionality
    Private Sub procAutoDisplayTransactionsBySearchType(ByVal p_searchText As String)
        Try
            With command
                .Parameters.Clear()
                .CommandText = "procAutoDisplayTransactionsBySearchType"
                .CommandType = CommandType.StoredProcedure
                .Parameters.AddWithValue("@p_value", p_searchText)
                sqlAdapterFilio.SelectCommand = command
                datFilio.Clear()
                sqlAdapterFilio.Fill(datFilio)
                lblTotalTransactions.Text = datFilio.Rows.Count & " Transactions"
            End With
            If datFilio.Rows.Count > 0 Then
                grdTransaction.RowCount = datFilio.Rows.Count
                'lblTotalFiles.Text = datFilio.Rows.Count & " Files"
                row = 0
                While Not datFilio.Rows.Count - 1 < row
                    With grdTransaction
                        .Rows(row).Cells(1).Value = datFilio.Rows(row).Item("id").ToString
                        .Rows(row).Cells(2).Value = datFilio.Rows(row).Item("file_name").ToString
                        .Rows(row).Cells(3).Value = DateTime.Parse(datFilio.Rows(row).Item("date").ToString()).ToString("dddd, MMMM dd, yyyy h:mm tt")
                        .Rows(row).Cells(4).Value = datFilio.Rows(row).Item("status").ToString
                        .Rows(row).Cells(5).Value = datFilio.Rows(row).Item("username").ToString
                        .Rows(row).Cells(6).Value = datFilio.Rows(row).Item("notes").ToString
                        .Rows(row).Cells(7).Value = datFilio.Rows(row).Item("type").ToString
                        .Rows(row).Cells(8).Value = datFilio.Rows(row).Item("borrower_name").ToString
                        .Rows(row).Cells(9).Value = datFilio.Rows(row).Item("returner_name").ToString
                        .Rows(row).Cells(10).Value = datFilio.Rows(row).Item("department").ToString

                    End With
                    row += 1
                End While

            Else
                grdTransaction.Rows.Clear()
                'MessageBox.Show("NO Record Found!", "Record Status", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)

            End If
            datFilio.Dispose()
            sqlAdapterFilio.Dispose()

        Catch ex As Exception
            MessageBox.Show("" & ex.Message)
        End Try

    End Sub

End Class