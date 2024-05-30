Imports MySql.Data.MySqlClient

Public Class frmBackupList
    Private Sub btnCancel_Click(sender As Object, e As EventArgs) Handles btnCancel.Click
        Me.Close()
    End Sub

    Private Sub frmBackupList_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        procDisplayBackupRecords()
    End Sub

    Private Sub procDisplayBackupRecords()
        datFilio = New DataTable
        sqlAdapterFilio = New MySqlDataAdapter

        Try
            With command
                .Parameters.Clear()
                .CommandText = "procDisplayBackupRecords"
                .CommandType = CommandType.StoredProcedure
                sqlAdapterFilio.SelectCommand = command
                datFilio.Clear()
                sqlAdapterFilio.Fill(datFilio)
            End With
            If datFilio.Rows.Count > 0 Then
                grdFiles.RowCount = datFilio.Rows.Count
                row = 0
                While Not datFilio.Rows.Count - 1 < row
                    With grdFiles
                        .Rows(row).Cells(1).Value = datFilio.Rows(row).Item("id").ToString
                        .Rows(row).Cells(2).Value = datFilio.Rows(row).Item("backup_name").ToString
                        .Rows(row).Cells(3).Value = datFilio.Rows(row).Item("file_path").ToString
                        .Rows(row).Cells(4).Value = DateTime.Parse(datFilio.Rows(row).Item("backup_date")).ToString("f")
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


End Class