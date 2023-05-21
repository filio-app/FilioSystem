Imports MySql.Data.MySqlClient
Public Class frmFilesBrowse
    Private Sub frmFilesBrowse_Load(sender As Object, e As EventArgs) Handles MyBase.Load
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
            End With

            ' Filter the DataTable based on the status column
            Dim filteredDatFilio As DataTable
            If transactionType.Equals("Issue") Then
                filteredDatFilio = datFilio.Select("status = 'Available'").CopyToDataTable()
            Else
                filteredDatFilio = datFilio.Select("status = 'Issued'").CopyToDataTable()
            End If

            If filteredDatFilio.Rows.Count > 0 Then
                grdFiles.RowCount = filteredDatFilio.Rows.Count
                row = 0
                While Not filteredDatFilio.Rows.Count - 1 < row
                    With grdFiles
                        .Rows(row).Cells(1).Value = filteredDatFilio.Rows(row).Item("id").ToString
                        .Rows(row).Cells(2).Value = filteredDatFilio.Rows(row).Item("name").ToString
                        .Rows(row).Cells(3).Value = filteredDatFilio.Rows(row).Item("description").ToString
                        .Rows(row).Cells(4).Value = filteredDatFilio.Rows(row).Item("location").ToString
                        .Rows(row).Cells(5).Value = filteredDatFilio.Rows(row).Item("status").ToString
                        .Rows(row).Cells(6).Value = filteredDatFilio.Rows(row).Item("date_added").ToString
                        .Rows(row).Cells(7).Value = filteredDatFilio.Rows(row).Item("date_modified").ToString
                    End With
                    row += 1
                End While
            Else
                grdFiles.Rows.Clear()
                'MessageBox.Show("NO Record Found!", "Record Status", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            End If

            filteredDatFilio.Dispose()
            datFilio.Dispose()
            sqlAdapterFilio.Dispose()

        Catch ex As Exception
            MessageBox.Show("" & ex.Message)
        End Try

    End Sub


    Private Sub txtSearch_TextChanged(sender As Object, e As EventArgs)
        procAutoDisplayFilesBySearchType(cmbSearchType.Text, txtSearchNew.Text)
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
            End With

            '' Filter the DataTable based on the status column
            Dim filteredDatFilio As DataTable
            If transactionType.Equals("Issue") Then
                filteredDatFilio = datFilio.Select("status = 'Available'").CopyToDataTable()
            Else
                filteredDatFilio = datFilio.Select("status = 'Issued'").CopyToDataTable()
            End If

            Try
                ' your code to fill the DataTable here '
            Catch ex As System.Data.StrongTypingException
                ' If the DataTable has no rows, display a custom message '
                MessageBox.Show("There are no records to display.", "No Records Found", MessageBoxButtons.OK, MessageBoxIcon.Information)
            End Try


            If filteredDatFilio.Rows.Count > 0 Then
                grdFiles.RowCount = filteredDatFilio.Rows.Count
                row = 0
                While Not filteredDatFilio.Rows.Count - 1 < row
                    With grdFiles
                        .Rows(row).Cells(1).Value = filteredDatFilio.Rows(row).Item("id").ToString
                        .Rows(row).Cells(2).Value = filteredDatFilio.Rows(row).Item("name").ToString
                        .Rows(row).Cells(3).Value = filteredDatFilio.Rows(row).Item("description").ToString
                        .Rows(row).Cells(4).Value = filteredDatFilio.Rows(row).Item("location").ToString
                        .Rows(row).Cells(5).Value = filteredDatFilio.Rows(row).Item("status").ToString
                        .Rows(row).Cells(6).Value = filteredDatFilio.Rows(row).Item("date_added").ToString
                        .Rows(row).Cells(7).Value = filteredDatFilio.Rows(row).Item("date_modified").ToString
                    End With
                    row += 1
                End While
            Else
                'grdFiles.Rows.Clear()
                'MessageBox.Show("NO Record Found!", "Record Status", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            End If


            filteredDatFilio.Dispose()
            datFilio.Dispose()
            sqlAdapterFilio.Dispose()

        Catch ex As Exception
            grdFiles.Rows.Clear()
            'MessageBox.Show("NO Record Found!", "Record Status", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
        End Try

    End Sub

    Private Sub btnCancel_Click(sender As Object, e As EventArgs) Handles btnCancel.Click
        Me.Close()
    End Sub

    Private Sub txtSearchNew_TextChanged(sender As Object, e As EventArgs) Handles txtSearchNew.TextChanged
        procAutoDisplayFilesBySearchType(cmbSearchType.Text, txtSearchNew.Text)
    End Sub

    Private Sub btnSelect_Click(sender As Object, e As EventArgs) Handles btnSelect.Click
        tempFileID = CInt(grdFiles.CurrentRow.Cells(1).Value.ToString)
        tempFileName = grdFiles.CurrentRow.Cells(2).Value.ToString
        With frmAddTransaction
            .txtFile.Text = tempFileName
        End With
        Me.Close()
    End Sub


End Class