<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ReportForm
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Me.ReportViewer1 = New Microsoft.Reporting.WinForms.ReportViewer()
        Me.BuildingSafety_DBDataSet = New AIO.BuildingSafety_DBDataSet()
        Me.BuildingSafetyDBDataSetBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.BuildingsBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        CType(Me.BuildingSafety_DBDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BuildingSafetyDBDataSetBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BuildingsBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'ReportViewer1
        '
        Me.ReportViewer1.BackColor = System.Drawing.Color.PowderBlue
        Me.ReportViewer1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.ReportViewer1.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ReportViewer1.ForeColor = System.Drawing.Color.Black
        Me.ReportViewer1.LocalReport.ReportEmbeddedResource = "AIO.BuildingsReport.rdlc"
        Me.ReportViewer1.Location = New System.Drawing.Point(0, 0)
        Me.ReportViewer1.Name = "ReportViewer1"
        Me.ReportViewer1.ServerReport.BearerToken = Nothing
        Me.ReportViewer1.Size = New System.Drawing.Size(684, 373)
        Me.ReportViewer1.TabIndex = 0
        '
        'BuildingSafety_DBDataSet
        '
        Me.BuildingSafety_DBDataSet.DataSetName = "BuildingSafety_DBDataSet"
        Me.BuildingSafety_DBDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'BuildingSafetyDBDataSetBindingSource
        '
        Me.BuildingSafetyDBDataSetBindingSource.DataSource = Me.BuildingSafety_DBDataSet
        Me.BuildingSafetyDBDataSetBindingSource.Position = 0
        '
        'BuildingsBindingSource
        '
        Me.BuildingsBindingSource.DataMember = "Buildings"
        Me.BuildingsBindingSource.DataSource = Me.BuildingSafety_DBDataSet
        '
        'ReportForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(684, 373)
        Me.Controls.Add(Me.ReportViewer1)
        Me.Name = "ReportForm"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "ReportForm"
        CType(Me.BuildingSafety_DBDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BuildingSafetyDBDataSetBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BuildingsBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents ReportViewer1 As Microsoft.Reporting.WinForms.ReportViewer
    Friend WithEvents BuildingSafety_DBDataSet As BuildingSafety_DBDataSet
    Friend WithEvents BuildingSafetyDBDataSetBindingSource As BindingSource
    Friend WithEvents BuildingsBindingSource As BindingSource
End Class
