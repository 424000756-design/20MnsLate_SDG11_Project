Public Class Form1
    Private Sub btnLogin_Click(sender As Object, e As EventArgs) Handles btnLogin.Click
        'condition if admin or user'
        If txtUsername.Text = "admin" And txtPassword.Text = "admin123" Then

            MessageBox.Show("Welcome Admin")

            Dashboard.CurrentRole = "Admin"
            Dim dash As New Dashboard()
            dash.Show()
            Me.Hide()

        ElseIf txtUsername.Text = "user" And txtPassword.Text = "user123" Then

            MessageBox.Show("Welcome User")

            Dashboard.CurrentRole = "User"
            Dim dash As New Dashboard()
            dash.Show()
            Me.Hide()

        Else

            MessageBox.Show("Invalid username or password")

        End If

    End Sub

    Private Sub Panel1_Paint(sender As Object, e As PaintEventArgs) Handles Panel1.Paint

    End Sub

    Private Sub PictureBox1_Click(sender As Object, e As EventArgs) Handles PictureBox1.Click

    End Sub
End Class
