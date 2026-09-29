<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmReports
    Inherits System.Windows.Forms.Form

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

    Private components As System.ComponentModel.IContainer

    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Dim DataGridViewCellStyle1 As DataGridViewCellStyle = New DataGridViewCellStyle()
        pnlHeader = New Panel()
        lblTitle = New Label()
        lblSelectReport = New Label()
        cmbReportType = New ComboBox()
        btnGenerate = New Button()
        dgvReports = New DataGridView()
        colRequestNo = New DataGridViewTextBoxColumn()
        colDate = New DataGridViewTextBoxColumn()
        colStudent = New DataGridViewTextBoxColumn()
        colDocument = New DataGridViewTextBoxColumn()
        colAmount = New DataGridViewTextBoxColumn()
        colStatus = New DataGridViewTextBoxColumn()
        btnExport = New Button()
        pnlHeader.SuspendLayout()
        CType(dgvReports, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' pnlHeader
        ' 
        pnlHeader.BackColor = Color.FromArgb(CByte(15), CByte(31), CByte(76))
        pnlHeader.Controls.Add(lblTitle)
        pnlHeader.Dock = DockStyle.Top
        pnlHeader.Location = New Point(0, 0)
        pnlHeader.Name = "pnlHeader"
        pnlHeader.Size = New Size(1402, 60)
        pnlHeader.TabIndex = 0
        ' 
        ' lblTitle
        ' 
        lblTitle.AutoSize = True
        lblTitle.Font = New Font("Segoe UI", 16F, FontStyle.Bold)
        lblTitle.ForeColor = Color.White
        lblTitle.Location = New Point(20, 15)
        lblTitle.Name = "lblTitle"
        lblTitle.Size = New Size(94, 30)
        lblTitle.TabIndex = 0
        lblTitle.Text = "Reports"
        ' 
        ' lblSelectReport
        ' 
        lblSelectReport.AutoSize = True
        lblSelectReport.Font = New Font("Segoe UI", 9F, FontStyle.Bold)
        lblSelectReport.ForeColor = Color.DimGray
        lblSelectReport.Location = New Point(25, 80)
        lblSelectReport.Name = "lblSelectReport"
        lblSelectReport.Size = New Size(94, 15)
        lblSelectReport.TabIndex = 1
        lblSelectReport.Text = "SELECT REPORT"
        ' 
        ' cmbReportType
        ' 
        cmbReportType.Font = New Font("Segoe UI", 11.25F)
        cmbReportType.FormattingEnabled = True
        cmbReportType.Location = New Point(25, 100)
        cmbReportType.Name = "cmbReportType"
        cmbReportType.Size = New Size(1196, 28)
        cmbReportType.TabIndex = 2
        ' 
        ' btnGenerate
        ' 
        btnGenerate.BackColor = Color.FromArgb(CByte(15), CByte(31), CByte(76))
        btnGenerate.FlatAppearance.BorderSize = 0
        btnGenerate.FlatStyle = FlatStyle.Flat
        btnGenerate.Font = New Font("Segoe UI", 9.75F, FontStyle.Bold)
        btnGenerate.ForeColor = Color.White
        btnGenerate.Location = New Point(1227, 100)
        btnGenerate.Name = "btnGenerate"
        btnGenerate.Size = New Size(130, 30)
        btnGenerate.TabIndex = 3
        btnGenerate.Text = "Generate"
        btnGenerate.UseVisualStyleBackColor = False
        ' 
        ' dgvReports
        ' 
        dgvReports.AllowUserToAddRows = False
        dgvReports.AllowUserToDeleteRows = False
        dgvReports.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill
        dgvReports.BackgroundColor = Color.White
        dgvReports.BorderStyle = BorderStyle.None
        dgvReports.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.Single
        DataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle1.BackColor = Color.FromArgb(CByte(15), CByte(31), CByte(76))
        DataGridViewCellStyle1.Font = New Font("Segoe UI", 9.75F, FontStyle.Bold)
        DataGridViewCellStyle1.ForeColor = Color.White
        DataGridViewCellStyle1.SelectionBackColor = Color.FromArgb(CByte(15), CByte(31), CByte(76))
        DataGridViewCellStyle1.SelectionForeColor = SystemColors.HighlightText
        DataGridViewCellStyle1.WrapMode = DataGridViewTriState.True
        dgvReports.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle1
        dgvReports.ColumnHeadersHeight = 40
        dgvReports.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.DisableResizing
        dgvReports.Columns.AddRange(New DataGridViewColumn() {colRequestNo, colDate, colStudent, colDocument, colAmount, colStatus})
        dgvReports.EnableHeadersVisualStyles = False
        dgvReports.Location = New Point(25, 150)
        dgvReports.Name = "dgvReports"
        dgvReports.ReadOnly = True
        dgvReports.RowHeadersVisible = False
        dgvReports.RowTemplate.Height = 35
        dgvReports.SelectionMode = DataGridViewSelectionMode.FullRowSelect
        dgvReports.Size = New Size(1332, 537)
        dgvReports.TabIndex = 4
        ' 
        ' colRequestNo
        ' 
        colRequestNo.HeaderText = "REQUEST NO."
        colRequestNo.Name = "colRequestNo"
        colRequestNo.ReadOnly = True
        ' 
        ' colDate
        ' 
        colDate.HeaderText = "DATE"
        colDate.Name = "colDate"
        colDate.ReadOnly = True
        ' 
        ' colStudent
        ' 
        colStudent.HeaderText = "STUDENT"
        colStudent.Name = "colStudent"
        colStudent.ReadOnly = True
        ' 
        ' colDocument
        ' 
        colDocument.HeaderText = "DOCUMENT"
        colDocument.Name = "colDocument"
        colDocument.ReadOnly = True
        ' 
        ' colAmount
        ' 
        colAmount.HeaderText = "AMOUNT"
        colAmount.Name = "colAmount"
        colAmount.ReadOnly = True
        ' 
        ' colStatus
        ' 
        colStatus.HeaderText = "STATUS"
        colStatus.Name = "colStatus"
        colStatus.ReadOnly = True
        ' 
        ' btnExport
        ' 
        btnExport.BackColor = Color.FromArgb(CByte(245), CByte(197), CByte(24))
        btnExport.FlatAppearance.BorderSize = 0
        btnExport.FlatStyle = FlatStyle.Flat
        btnExport.Font = New Font("Segoe UI", 9.75F, FontStyle.Bold)
        btnExport.ForeColor = Color.Black
        btnExport.Location = New Point(1217, 706)
        btnExport.Name = "btnExport"
        btnExport.Size = New Size(140, 40)
        btnExport.TabIndex = 5
        btnExport.Text = "Export / Print"
        btnExport.UseVisualStyleBackColor = False
        ' 
        ' frmReports
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.White
        ClientSize = New Size(1402, 815)
        Controls.Add(btnExport)
        Controls.Add(dgvReports)
        Controls.Add(btnGenerate)
        Controls.Add(cmbReportType)
        Controls.Add(lblSelectReport)
        Controls.Add(pnlHeader)
        Cursor = Cursors.Default
        Name = "frmReports"
        StartPosition = FormStartPosition.CenterScreen
        Text = "Reports"
        pnlHeader.ResumeLayout(False)
        pnlHeader.PerformLayout()
        CType(dgvReports, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()

    End Sub

    Friend WithEvents pnlHeader As System.Windows.Forms.Panel
    Friend WithEvents lblTitle As System.Windows.Forms.Label
    Friend WithEvents lblSelectReport As System.Windows.Forms.Label
    Friend WithEvents cmbReportType As System.Windows.Forms.ComboBox
    Friend WithEvents btnGenerate As System.Windows.Forms.Button
    Friend WithEvents dgvReports As System.Windows.Forms.DataGridView
    Friend WithEvents colRequestNo As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents colDate As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents colStudent As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents colDocument As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents colAmount As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents colStatus As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents btnExport As System.Windows.Forms.Button
End Class
