Public Class Main
    Private Sub Main_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        chkDatabaseConnection()

        Me.Show()



        With frmSignIn
            .Guna2TextBox1.PlaceholderText = "test"
        End With
        displayForm(Me, frmSignIn)


    End Sub

End Class
