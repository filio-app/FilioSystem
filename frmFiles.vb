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



    Private Sub grdFiles_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles grdFiles.CellContentClick

    End Sub


End Class