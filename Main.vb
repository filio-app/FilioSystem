Public Class Main
    Private Sub Main_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        chkDatabaseConnection()

        Me.Show()



        With frmSignIn
            .Guna2TextBox1.PlaceholderText = "test"
        End With
        displayForm(Me, frmSignIn)


    End Sub

    Private Sub PictureBox1_Click(sender As Object, e As EventArgs) Handles PictureBox1.Click

    End Sub

    Private Sub panelTopLogo_Paint(sender As Object, e As PaintEventArgs) Handles panelTopLogo.Paint

    End Sub
End Class
