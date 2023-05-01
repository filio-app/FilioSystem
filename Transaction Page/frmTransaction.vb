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
                'TODO: (frmFiles) Add total files as labels
                'lblTotal.Text = "Total Records : " & datHotel.Rows.Count
            End With
            If datFilio.Rows.Count > 0 Then
                grdTransaction.RowCount = datFilio.Rows.Count
                row = 0
                While Not datFilio.Rows.Count - 1 < row
                    With grdTransaction
                        .Rows(row).Cells(1).Value = datFilio.Rows(row).Item("id").ToString
                        .Rows(row).Cells(2).Value = datFilio.Rows(row).Item("file_name").ToString
                        .Rows(row).Cells(3).Value = DateTime.Parse(datFilio.Rows(row).Item("date").ToString()).ToString("MM/dd/yyyy")
                        .Rows(row).Cells(4).Value = datFilio.Rows(row).Item("type").ToString
                        .Rows(row).Cells(5).Value = datFilio.Rows(row).Item("username").ToString
                        .Rows(row).Cells(6).Value = datFilio.Rows(row).Item("notes").ToString

                    End With
                    row += 1
                End While

            Else
                grdTransaction.Rows.Clear()
                MessageBox.Show("NO Record Found!", "Record Status", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)

            End If
            datFilio.Dispose()
            sqlAdapterFilio.Dispose()

        Catch ex As Exception
            MessageBox.Show("" & ex.Message)
        End Try
    End Sub

    Private Sub btnAdd_Click(sender As Object, e As EventArgs) Handles btnAdd.Click
        displayFormAsModal(frmMain, frmAddTransaction)
        procDisplayAllTransactions()
    End Sub
End Class