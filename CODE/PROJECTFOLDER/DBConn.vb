Imports System.Data.SqlClient
Public Class DBConn
    Public Shared conn As New SqlConnection(
        "Data Source=DESKTOP-SC149DP\SQLEXPRESS;
         Initial Catalog=BuildingSafety_DB;
         Integrated Security=True"
    )
End Class

