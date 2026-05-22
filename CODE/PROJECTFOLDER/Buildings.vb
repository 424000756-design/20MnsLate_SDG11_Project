Imports System.Data.SqlClient

Public Class Buildings

    Private Sub Buildings_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        LoadData()
    End Sub

    Private Sub LoadData()
        Dim dt As New DataTable
        Dim da As New SqlDataAdapter("SELECT * FROM dbo.Buildings", DBConn.conn)
        da.Fill(dt)

        dgvBuildings.DataSource = dt
        dgvBuildings.ClearSelection()
    End Sub

    Private Sub btnAdd_Click(sender As Object, e As EventArgs) Handles btnAdd.Click

        Dim floors As Integer
        Dim score As Integer

        If txtName.Text = "" Or txtAddress.Text = "" Or txtFloors.Text = "" Or txtScore.Text = "" Then
            MessageBox.Show("Complete all fields")
            Exit Sub
        End If
        'error handlers, check if int is inputed'
        If Not Integer.TryParse(txtFloors.Text, floors) Then
            MessageBox.Show("Floors must be a number.")
            txtFloors.Focus()
            Exit Sub
        End If

        If Not Integer.TryParse(txtScore.Text, score) Then
            MessageBox.Show("Safety Score must be a number.")
            txtScore.Focus()
            Exit Sub
        End If
        'status calculator'
        Dim status As String
        If score >= 80 Then
            status = "SAFE"
        ElseIf score >= 50 Then
            status = "WARNING"
        Else
            status = "CRITICAL"
        End If

        'adding new datas to the sql'
        Try
            Dim cmd As New SqlCommand("INSERT INTO dbo.Buildings (BuildingName,Address,Floors,SafetyScore,SafetyStatus) VALUES (@n,@a,@f,@s,@st)", DBConn.conn)

            cmd.Parameters.AddWithValue("@n", txtName.Text)
            cmd.Parameters.AddWithValue("@a", txtAddress.Text)
            cmd.Parameters.AddWithValue("@f", floors)
            cmd.Parameters.AddWithValue("@s", score)
            cmd.Parameters.AddWithValue("@st", status)

            DBConn.conn.Open()
            cmd.ExecuteNonQuery()
            DBConn.conn.Close()

            MessageBox.Show("Added Successfully")
            LoadData()

        Catch ex As Exception
            MessageBox.Show("Error: " & ex.Message)
            DBConn.conn.Close()
        End Try

    End Sub
    'based on building names to delete'
    Private Sub btnDelete_Click(sender As Object, e As EventArgs) Handles btnDelete.Click

        Dim cmd As New SqlCommand("DELETE FROM dbo.Buildings WHERE BuildingName=@n", DBConn.conn)
        cmd.Parameters.AddWithValue("@n", txtName.Text)

        DBConn.conn.Open()
        cmd.ExecuteNonQuery()
        DBConn.conn.Close()

        MessageBox.Show("Deleted")
        LoadData()

    End Sub

    Private Sub btnUpdate_Click(sender As Object, e As EventArgs) Handles btnUpdate.Click

        Dim floors As Integer
        Dim score As Integer

        If Not Integer.TryParse(txtFloors.Text, floors) Or Not Integer.TryParse(txtScore.Text, score) Then
            MessageBox.Show("Floors and Score must be numbers.")
            Exit Sub
        End If

        Dim status As String
        If score >= 80 Then
            status = "SAFE"
        ElseIf score >= 50 Then
            status = "WARNING"
        Else
            status = "CRITICAL"
        End If

        Dim cmd As New SqlCommand("UPDATE dbo.Buildings SET Address=@a,Floors=@f,SafetyScore=@s,SafetyStatus=@st WHERE BuildingName=@n", DBConn.conn)

        cmd.Parameters.AddWithValue("@n", txtName.Text)
        cmd.Parameters.AddWithValue("@a", txtAddress.Text)
        cmd.Parameters.AddWithValue("@f", floors)
        cmd.Parameters.AddWithValue("@s", score)
        cmd.Parameters.AddWithValue("@st", status)

        DBConn.conn.Open()
        cmd.ExecuteNonQuery()
        DBConn.conn.Close()

        MessageBox.Show("Updated")
        LoadData()

    End Sub

    Private Sub dgvBuildings_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvBuildings.CellContentClick

        If e.RowIndex >= 0 Then
            Dim row As DataGridViewRow = dgvBuildings.Rows(e.RowIndex)

            txtName.Text = row.Cells(1).Value.ToString()
            txtAddress.Text = row.Cells(2).Value.ToString()
            txtFloors.Text = row.Cells(3).Value.ToString()
            txtScore.Text = row.Cells(4).Value.ToString()
            lblStatus.Text = row.Cells(5).Value.ToString()
        End If

    End Sub

    Private Sub btnClear_Click(sender As Object, e As EventArgs) Handles btnClear.Click

        txtName.Clear()
        txtAddress.Clear()
        txtFloors.Clear()
        txtScore.Clear()
        lblStatus.Text = ""
        dgvBuildings.ClearSelection()

    End Sub

    Private Sub btnBack_Click(sender As Object, e As EventArgs) Handles btnBack.Click
        Dashboard.Show()
        Me.Hide()
    End Sub

    Private Sub PictureBox1_Click(sender As Object, e As EventArgs) Handles PictureBox1.Click

    End Sub

    Private Sub Label6_Click(sender As Object, e As EventArgs) Handles Label6.Click

    End Sub
End Class