Imports MySql.Data.MySqlClient
Public Class frmUsers
    Private Sub frmUsers_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        procDisplayAllUsers()
    End Sub

    Private Sub procDisplayAllUsers()
        datFilio = New DataTable
        sqlAdapterFilio = New MySqlDataAdapter

        Try
            With command
                .Parameters.Clear()
                .CommandText = "procDisplayAllUsers"
                .CommandType = CommandType.StoredProcedure
                sqlAdapterFilio.SelectCommand = command
                datFilio.Clear()
                sqlAdapterFilio.Fill(datFilio)
                'TODO: (frmFiles) Add total files as labels
                'lblTotal.Text = "Total Records : " & datHotel.Rows.Count
            End With
            If datFilio.Rows.Count > 0 Then
                grdUsers.RowCount = datFilio.Rows.Count
                row = 0
                While Not datFilio.Rows.Count - 1 < row
                    With grdUsers
                        .Rows(row).Cells(1).Value = datFilio.Rows(row).Item("id").ToString
                        .Rows(row).Cells(2).Value = datFilio.Rows(row).Item("user_id").ToString
                        .Rows(row).Cells(3).Value = datFilio.Rows(row).Item("username").ToString
                        .Rows(row).Cells(4).Value = datFilio.Rows(row).Item("first_name").ToString
                        .Rows(row).Cells(5).Value = datFilio.Rows(row).Item("last_name").ToString
                        .Rows(row).Cells(6).Value = datFilio.Rows(row).Item("role_id").ToString
                        .Rows(row).Cells(7).Value = datFilio.Rows(row).Item("role_name").ToString
                        .Rows(row).Cells(8).Value = datFilio.Rows(row).Item("phone_no").ToString
                        .Rows(row).Cells(9).Value = datFilio.Rows(row).Item("email_address").ToString
                    End With
                    row += 1
                End While

            Else
                grdUsers.Rows.Clear()
                MessageBox.Show("NO Record Found!", "Record Status", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)

            End If
            datFilio.Dispose()
            sqlAdapterFilio.Dispose()

        Catch ex As Exception
            MessageBox.Show("" & ex.Message)
        End Try
    End Sub
End Class