Public Class userlogin
    Private Sub btnLogin_Click(sender As Object, e As EventArgs) Handles btnLogin.Click
        Dim username = txtUsername.Text
        Dim password = txtPassword.Text

        If username = "user" AndAlso password = "user123" Then
            MessageBox.Show("User logged in successfully.", "Success")
            Dim userform As New UserForm()
            userform.Show()
            Me.Hide()
        Else
            MessageBox.Show("Invalid credentials.", "Login Failed")
        End If
    End Sub
End Class
