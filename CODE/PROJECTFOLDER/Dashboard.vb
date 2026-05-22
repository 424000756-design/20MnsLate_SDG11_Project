Public Class Dashboard
    'admin or user'
    Public Shared CurrentRole As String

    Private Sub Dashboard_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'if user is the role button for manage buildings disable'
        lblRole.Text = "ROLE: " & CurrentRole

        If CurrentRole = "User" Then
            btnBuildings.Enabled = False
        End If

    End Sub

    Private Sub btnBuildings_Click(sender As Object, e As EventArgs) Handles btnBuildings.Click
        Buildings.Show()
        Me.Hide()
    End Sub

    'when log out, form closes and textbox for password and user clears'
    Private Sub btnLogOut_Click(sender As Object, e As EventArgs) Handles btnLogOut.Click
        Form1.Show()
        Me.Hide()

        Form1.txtPassword.Clear()
        Form1.txtUsername.Clear()
    End Sub

    Private Sub btnViewReport_Click(sender As Object, e As EventArgs) Handles btnViewReport.Click
        Dim r As New ReportForm
        r.Show()
    End Sub

    Private Sub Label3_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub Label1_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub Label3_Click_1(sender As Object, e As EventArgs) Handles Label3.Click

    End Sub

    Private Sub Label1_Click_1(sender As Object, e As EventArgs)

    End Sub

    Private Sub FlowLayoutPanel1_Paint(sender As Object, e As PaintEventArgs) Handles FlowLayoutPanel1.Paint

    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        Dim kasalukuyangOras As DateTime = DateTime.Now
        lblTime.Text = kasalukuyangOras.ToString("hh:mm:ss tt")
    End Sub
End Class