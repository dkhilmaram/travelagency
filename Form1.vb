Public Class Form1
    Private Sub btnLogin_Click(sender As Object, e As EventArgs) Handles btnLogin.Click
        Dim username = txtUsername.Text
        Dim password = txtPassword.Text

        If username = "admin" AndAlso password = "admin123" Then
            MessageBox.Show("Admin logged in successfully.", "Success")
            Dim adminform As New adminform()
            adminform.Show()
            Me.Hide()
        Else
            MessageBox.Show("Invalid credentials.", "Login Failed")
        End If
    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class

