Imports MySql.Data.MySqlClient
Public Class frmHistory
    Private Sub frmHistory_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        procDisplayAllHistory()
    End Sub

    Private Sub procDisplayAllHistory()
        datFilio = New DataTable
        sqlAdapterFilio = New MySqlDataAdapter

        Try
            With command
                .Parameters.Clear()
                .CommandText = "procDisplayAllHistory"
                .CommandType = CommandType.StoredProcedure
                sqlAdapterFilio.SelectCommand = command
                datFilio.Clear()
                sqlAdapterFilio.Fill(datFilio)
            End With
            If datFilio.Rows.Count > 0 Then
                grdHistory.RowCount = datFilio.Rows.Count
                row = 0
                While Not datFilio.Rows.Count - 1 < row
                    With grdHistory
                        'TODO: Add Account Type
                        '.Rows(row).Cells(1).Value = datFilio.Rows(row).Item("id").ToString
                        .Rows(row).Cells(3).Value = datFilio.Rows(row).Item("username").ToString
                        '.Rows(row).Cells(4).Value = datFilio.Rows(row).Item("first_name").ToString
                        '.Rows(row).Cells(5).Value = datFilio.Rows(row).Item("last_name").ToString
                        .Rows(row).Cells(7).Value = datFilio.Rows(row).Item("action").ToString
                        .Rows(row).Cells(8).Value = datFilio.Rows(row).Item("target").ToString
                        .Rows(row).Cells(9).Value = datFilio.Rows(row).Item("timestamp").ToString
                    End With
                    row += 1
                End While

            Else
                grdHistory.Rows.Clear()
                MessageBox.Show("NO Record Found!", "Record Status", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)

            End If
            datFilio.Dispose()
            sqlAdapterFilio.Dispose()

        Catch ex As Exception
            MessageBox.Show("" & ex.Message)
        End Try
    End Sub
End Class