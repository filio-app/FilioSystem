Imports MySql.Data.MySqlClient

Public Class frmAddUser

    Private isFormLoaded As Boolean = True
    Private isStrongPass As Boolean = False

    Private Sub frmAddUser_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        lblPassStr.Height = 40
        lblPassStr.Text = "Password must be 8+ characters with letters and" & vbCrLf & "numbers"
        isFormLoaded = False
    End Sub

    Private Sub btnCancel_Click(sender As Object, e As EventArgs) Handles btnCancel.Click
        'TODO: opening the frmAddUser trigger textChangedEvent
        'isFormLoaded = True
        clearControlsInGroupBox(gBPersonalInfo)
        clearControlsInGroupBox(gBUserAcc)

        clearEP()

        'TODO: Change close() to dipose() if possible

        Me.Close()
        Me.Dispose()
    End Sub

    '=============================================== Submit ========================================




    Private Sub btnSubmit_Click(sender As Object, e As EventArgs) Handles btnSubmit.Click
        'TODO: Add descriptive message
        'TODO: validate email and phone no

        If txtFirstName.Text = "" Then
            clearEP()
            ErrorProviderHelper.SetError(txtFirstName, "test")
            Return
        ElseIf txtLastName.Text = "" Then
            clearEP()
            ErrorProviderHelper.SetError(txtLastName, "test")
            Return
        ElseIf txtPhoneNo.Text = "" Then
            clearEP()
            ErrorProviderHelper.SetError(txtPhoneNo, "test")
            Return
        ElseIf txtEmailAdd.Text = "" Then
            clearEP()
            ErrorProviderHelper.SetError(txtEmailAdd, "test")
            Return
        ElseIf txtUsername.Text = "" Then
            clearEP()
            ErrorProviderHelper.SetError(txtUsername, "test")
            Return
        Else
            clearEP()
        End If

        Try


            If Not checkUserNameAvailability() Then
                MessageBox.Show("Username Already Registered", "Save Record", MessageBoxButtons.OK, MessageBoxIcon.Information)
                Exit Sub
            End If

            procInsertUser()

            procInsertAdminOrEmployee()

            MessageBox.Show("Record Successfully Save", "Save Record", MessageBoxButtons.OK, MessageBoxIcon.Information)

            Me.Close()


        Catch ex As Exception
            MessageBox.Show("" & ex.Message)
        End Try


    End Sub



    Private Sub procInsertUser()
        Try

            With command
                .Parameters.Clear()
                .CommandText = "procInsertUser"
                .CommandType = CommandType.StoredProcedure
                .Parameters.AddWithValue("@p_username", txtUsername.Text)
                .Parameters.AddWithValue("@p_password", txtPass.Text)
                .Parameters.AddWithValue("@p_role_name", cmbRole.Text)
                .ExecuteNonQuery()
            End With
        Catch ex As Exception
            MessageBox.Show("" & ex.Message)
        End Try

    End Sub


    Private Sub procInsertAdminOrEmployee()
        Try

            With command
                .Parameters.Clear()
                .CommandText = "procInsertAdminOrEmployee"
                .CommandType = CommandType.StoredProcedure
                .Parameters.AddWithValue("@p_first_name", txtFirstName.Text)
                .Parameters.AddWithValue("@p_last_name", txtLastName.Text)
                .Parameters.AddWithValue("@p_phone_no", txtPhoneNo.Text)
                .Parameters.AddWithValue("@p_email_add", txtEmailAdd.Text)
                .Parameters.AddWithValue("@p_role_name", cmbRole.Text)
                .ExecuteNonQuery()
            End With
        Catch ex As Exception
            MessageBox.Show("" & ex.Message)
        End Try

    End Sub


    Public Function checkUserNameAvailability() As Boolean

        Dim result As Boolean = True

        Try

            With command
                .Parameters.Clear()
                .CommandText = "procCheckUsernameAvailability"
                .CommandType = CommandType.StoredProcedure
                .Parameters.AddWithValue("@p_username", txtUsername.Text)
                sqlAdapterFilio.SelectCommand = command
                datFilio.Clear()
                sqlAdapterFilio.Fill(datFilio)

            End With
            If datFilio.Rows.Count > 0 Then
                result = False
            End If

            datFilio.Dispose()
            sqlAdapterFilio.Dispose()

        Catch ex As Exception
            MessageBox.Show("" & ex.Message)
        End Try

        Return result
    End Function


    '=============================================== Password TextChanged Event =================================

    Private Sub txtPass_TextChanged(sender As Object, e As EventArgs) Handles txtPass.TextChanged
        If Not isFormLoaded Then

            isStrongPass = CheckPasswordStrength(txtPass.Text)



            If txtPass.Text = txtConfirmPass.Text And isStrongPass Then
                ' Two conditions are true - enable update button
                lblPassStr.Visible = False
                lblPassErr.Visible = False
                txtConfirmPass.FocusedState.BorderColor = Color.Green
                txtConfirmPass.BorderColor = Color.Green

                btnUpdate.Enabled = True
                btnSubmit.Enabled = True
            ElseIf Not isStrongPass And txtPass.Text <> txtConfirmPass.Text Then
                ' show two err
                lblPassStr.Visible = True
                lblPassErr.Visible = True
                txtConfirmPass.FocusedState.BorderColor = Color.Red
                txtConfirmPass.BorderColor = Color.Red

                btnUpdate.Enabled = False
                btnSubmit.Enabled = False
            ElseIf txtPass.Text <> txtConfirmPass.Text And isStrongPass Then
                ' show not match err
                lblPassErr.Visible = True
                lblPassStr.Visible = False
                txtConfirmPass.FocusedState.BorderColor = Color.Red
                txtConfirmPass.BorderColor = Color.Red

                btnUpdate.Enabled = False
                btnSubmit.Enabled = False
            ElseIf Not isStrongPass And txtPass.Text = txtConfirmPass.Text Then
                'show pass str er
                lblPassErr.Visible = False
                lblPassStr.Visible = True
                txtConfirmPass.FocusedState.BorderColor = Color.Red
                txtConfirmPass.BorderColor = Color.Red

                btnUpdate.Enabled = False
                btnSubmit.Enabled = False
            End If



        End If
    End Sub

    Private Sub txtConfirmPass_TextChanged(sender As Object, e As EventArgs) Handles txtConfirmPass.TextChanged

        'TODO: Need to edit border color

        If Not isFormLoaded Then

            isStrongPass = CheckPasswordStrength(txtPass.Text)



            If txtPass.Text = txtConfirmPass.Text And isStrongPass Then
                ' Two conditions are true - enable update button
                lblPassStr.Visible = False
                lblPassErr.Visible = False
                txtConfirmPass.FocusedState.BorderColor = Color.Green
                txtConfirmPass.BorderColor = Color.Green

                btnUpdate.Enabled = True
                btnSubmit.Enabled = True
            ElseIf Not isStrongPass And txtPass.Text <> txtConfirmPass.Text Then
                ' show two err
                lblPassStr.Visible = True
                lblPassErr.Visible = True
                txtConfirmPass.FocusedState.BorderColor = Color.Red
                txtConfirmPass.BorderColor = Color.Red

                btnUpdate.Enabled = False
                btnSubmit.Enabled = False
            ElseIf txtPass.Text <> txtConfirmPass.Text And isStrongPass Then
                ' show not match err
                lblPassErr.Visible = True
                lblPassStr.Visible = False
                txtConfirmPass.FocusedState.BorderColor = Color.Red
                txtConfirmPass.BorderColor = Color.Red

                btnUpdate.Enabled = False
                btnSubmit.Enabled = False
            ElseIf Not isStrongPass And txtPass.Text = txtConfirmPass.Text Then
                'show pass str er
                lblPassErr.Visible = False
                lblPassStr.Visible = True
                txtConfirmPass.FocusedState.BorderColor = Color.Red
                txtConfirmPass.BorderColor = Color.Red

                btnUpdate.Enabled = False
                btnSubmit.Enabled = False
            End If



        End If


    End Sub


End Class