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

                lblTotalUsers.Text = datFilio.Rows.Count & " Users"
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
            clearControlsInGroupBox(frmAddUser.gBPersonalInfo)
            clearControlsInGroupBox(frmAddUser.gBUserAcc)

            With frmAddUser
                .btnUpdate.Visible = False
                .btnSubmit.Visible = True
                .lblHeader.Text = "Add New User"
            End With

            displayFormAsModal(frmMain, frmAddUser)
            frmAddUser.Dispose()
            procDisplayAllUsers()
        Catch ex As Exception
            MessageBox.Show("" & ex.Message)
        End Try
    End Sub

    Private Sub grdUsers_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles grdUsers.CellContentClick
        colName = grdUsers.Columns(e.ColumnIndex).Name
        userID = CInt(grdUsers.CurrentRow.Cells(1).Value.ToString)
        tempRole = grdUsers.CurrentRow.Cells(7).Value.ToString


        '-- EDIT

        If colName = "edit" Then

            Try
                'procGetSelectedResident()
                clearControls(frmUpdateUserInformation)

                With frmUpdateUserInformation

                    .txtFirstName.Text = grdUsers.CurrentRow.Cells(4).Value.ToString()
                    .txtLastName.Text = grdUsers.CurrentRow.Cells(5).Value.ToString()
                    .txtPhoneNo.Text = grdUsers.CurrentRow.Cells(8).Value.ToString()
                    .txtEmailAdd.Text = grdUsers.CurrentRow.Cells(9).Value.ToString()

                End With

                With frmUpdateUserAccount
                    .txtUsername.Text = grdUsers.CurrentRow.Cells(3).Value.ToString()

                    If (grdUsers.CurrentRow.Cells(6).Value = 1) Then
                        .cmbRole.SelectedIndex = 0
                    Else
                        .cmbRole.SelectedIndex = 1
                    End If
                End With


                displayFormAsModal(frmMain, frmUpdateUser)
                frmUpdateUser.Close()
                procDisplayAllUsers()
            Catch ex As Exception
                MessageBox.Show("" & ex.Message)
            End Try

            'If txtSearch.Text.Length > 0 And chkAuto.Checked = False Then
            '    btnSearch.PerformClick()
            'End If
        End If



        '-- DELETE 

        If colName = "delete" Then

            'TODO: Test Delete functionality

            Try
                If MessageBox.Show("Are you sure you want to delete the selected record?", "Confirm Deletion", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = DialogResult.Yes Then
                    ' Perform the deletion
                    With command
                        .Parameters.Clear()
                        .CommandText = "procDeleteUser"
                        .CommandType = CommandType.StoredProcedure
                        .Parameters.AddWithValue("@p_user_id", CInt(grdUsers.CurrentRow.Cells(2).Value.ToString))
                        .Parameters.AddWithValue("@p_role_id", CInt(grdUsers.CurrentRow.Cells(6).Value.ToString))
                        .ExecuteNonQuery()
                        MessageBox.Show("The user has been deleted.", "Delete Successful", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)

                        procInsertLogEvent("Delete User", grdUsers.CurrentRow.Cells(3).Value.ToString)

                    End With
                    ' refresh/reload customer records in data grid view
                    procDisplayAllUsers()
                End If
            Catch ex As Exception
                MessageBox.Show("" & ex.Message)
            End Try


        End If

        '-- VIEW

        If colName = "view" Then
            Try


                With frmViewUser

                    .txtFirstName.Text = grdUsers.CurrentRow.Cells(4).Value.ToString()
                    .txtLastName.Text = grdUsers.CurrentRow.Cells(5).Value.ToString()
                    .txtPhoneNo.Text = grdUsers.CurrentRow.Cells(8).Value.ToString()
                    .txtEmailAdd.Text = grdUsers.CurrentRow.Cells(9).Value.ToString()

                End With

                displayFormAsModal(frmMain, frmViewUser)





            Catch ex As Exception
                MessageBox.Show("" & ex.Message)
            End Try


            'If txtSearch.Text.Length > 0 And chkAuto.Checked = False And colName <> "Delete" Then
            '    btnSearch.PerformClick()
            'End If
        End If
    End Sub

    Private Sub grdUsers_CellFormatting(sender As Object, e As DataGridViewCellFormattingEventArgs) Handles grdUsers.CellFormatting
        colName = grdUsers.Columns(e.ColumnIndex).Name
        If colName = "delete" Then ' Check if the cell is an image cell
            Dim cell As DataGridViewImageCell = grdUsers(e.ColumnIndex, e.RowIndex)
            cell.ToolTipText = "Delete" ' Set the tooltip tex
        End If

        If colName = "edit" Then ' Check if the cell is an image cell
            Dim cell As DataGridViewImageCell = grdUsers(e.ColumnIndex, e.RowIndex)
            cell.ToolTipText = "Edit/Update" ' Set the tooltip text
        End If

        If colName = "view" Then ' Check if the cell is an image cell
            Dim cell As DataGridViewImageCell = grdUsers(e.ColumnIndex, e.RowIndex)
            cell.ToolTipText = "View" ' Set the tooltip text
        End If
    End Sub

    Private Sub txtSearch_TextChanged(sender As Object, e As EventArgs) Handles txtSearch.TextChanged
        procAutoDisplayUsersBySearchType(txtSearch.Text)
    End Sub

    '=========================== Search Functionality
    Private Sub procAutoDisplayUsersBySearchType(ByVal p_searchText As String)
        Try
            With command
                .Parameters.Clear()
                .CommandText = "procAutoDisplayUsersBySearchType"
                .CommandType = CommandType.StoredProcedure
                .Parameters.AddWithValue("@p_value", p_searchText)
                sqlAdapterFilio.SelectCommand = command
                datFilio.Clear()
                sqlAdapterFilio.Fill(datFilio)
                'lblTotalFiles.Text = datFilio.Rows.Count & " Files"
            End With
            If datFilio.Rows.Count > 0 Then
                grdUsers.RowCount = datFilio.Rows.Count
                'lblTotalFiles.Text = datFilio.Rows.Count & " Files"
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
                'MessageBox.Show("NO Record Found!", "Record Status", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)

            End If
            datFilio.Dispose()
            sqlAdapterFilio.Dispose()

        Catch ex As Exception
            MessageBox.Show("" & ex.Message)
        End Try

    End Sub
End Class