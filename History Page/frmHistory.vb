Imports MySql.Data.MySqlClient
Public Class frmHistory

    Private isFormLoaded As Boolean = False
    Private Sub frmHistory_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        procDisplayAllHistory()
        'Dim defaultDate As New DateTime(2023, 3, 20)
        dtFrom.Value = DateTime.Now.AddDays(-2)
        dtTo.Value = DateTime.Now.AddDays(1)





    End Sub

    Private Sub procDisplayAllHistory()

        isFormLoaded = True

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
                'lblTotalFiles.Text = datFilio.Rows.Count & " Results"
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
                        .Rows(row).Cells(9).Value = DateTime.Parse(datFilio.Rows(row).Item("timestamp")).ToString("dddd, MMMM dd, yyyy h:mm:ss tt")
                        '.Rows(row).Cells(9).Value = datFilio.Rows(row).Item("timestamp").ToString


                    End With
                    row += 1
                End While

            Else
                grdHistory.Rows.Clear()
                'MessageBox.Show("NO Record Found!", "Record Status", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)

            End If
            datFilio.Dispose()
            sqlAdapterFilio.Dispose()

        Catch ex As Exception
            MessageBox.Show("" & ex.Message)
        End Try
    End Sub

    Private Sub dtFrom_ValueChanged(sender As Object, e As EventArgs) Handles dtFrom.ValueChanged
        If isFormLoaded Then
            procDisplayHistoryByDateRange()
        End If
    End Sub

    Private Sub dtTo_ValueChanged(sender As Object, e As EventArgs) Handles dtTo.ValueChanged
        If isFormLoaded Then
            procDisplayHistoryByDateRange()
        End If
    End Sub

    Private Sub procDisplayHistoryByDateRange()
        datFilio = New DataTable
        sqlAdapterFilio = New MySqlDataAdapter

        Try
            With command
                .Parameters.Clear()
                .CommandText = "procDisplayHistoryByDateRange"
                .CommandType = CommandType.StoredProcedure
                .Parameters.AddWithValue("@p_start_date", dtFrom.Value)
                .Parameters.AddWithValue("@p_end_date", dtTo.Value)
                sqlAdapterFilio.SelectCommand = command
                datFilio.Clear()
                sqlAdapterFilio.Fill(datFilio)
                lblTotalFiles.Text = datFilio.Rows.Count & " Results"
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
                        .Rows(row).Cells(9).Value = DateTime.Parse(datFilio.Rows(row).Item("timestamp")).ToString("dddd, MMMM dd, yyyy h:mm:ss tt")
                        '.Rows(row).Cells(9).Value = datFilio.Rows(row).Item("timestamp").ToString


                    End With
                    row += 1
                End While

            Else
                grdHistory.Rows.Clear()
                'MessageBox.Show("NO Record Found!", "Record Status", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)

            End If
            datFilio.Dispose()
            sqlAdapterFilio.Dispose()

        Catch ex As Exception
            MessageBox.Show("" & ex.Message)
        End Try
    End Sub


End Class