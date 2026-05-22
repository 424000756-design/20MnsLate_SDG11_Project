Imports Microsoft.Reporting.WinForms
Imports System.Data.SqlClient

Public Class ReportForm

    Private Sub ReportForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        Dim dt As New DataTable

        Dim da As New SqlDataAdapter("SELECT BuildingName, Address, Floors, SafetyScore, SafetyStatus FROM Buildings", DBConn.conn)

        da.Fill(dt)

        ReportViewer1.Reset()

        ReportViewer1.ProcessingMode = ProcessingMode.Local

        ReportViewer1.LocalReport.ReportPath = Application.StartupPath & "\BuildingsReport.rdlc"

        ReportViewer1.LocalReport.DataSources.Clear()

        Dim rds As New ReportDataSource("BuildingsDS", dt)

        ReportViewer1.LocalReport.DataSources.Add(rds)

        ReportViewer1.RefreshReport()

    End Sub

End Class