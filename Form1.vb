Public Class form1
    Private Sub btnLogin_Click(sender As Object, e As EventArgs) Handles BtnLogin.Click
        Dim username As String = Txtusername.Text ' Textbox for username
        Dim password As String = TxtPassword.Text ' Textbox for password

        ' Allow any username and password
        If Not String.IsNullOrEmpty(username) And Not String.IsNullOrEmpty(password) Then
            MessageBox.Show("Login Successful!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information)
            ' Navigate to admin form or dashboard
            Dim adminForm As New adminform() ' Replace with your actual form name
            adminForm.Show()
            Me.Hide()
        Else
            MessageBox.Show("Username or Password cannot be empty.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End If
    End Sub

    Private Sub AdminLogin_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ' Set the password textbox to mask characters
        TxtPassword.PasswordChar = "*"c
    End Sub
End Class
