<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmDocumentManagement
    Inherits System.Windows.Forms.Form

    <System.Diagnostics.DebuggerNonUserCode()>
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

    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle4 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.pnlMainCard = New System.Windows.Forms.Panel()
        Me.dgvDocuments = New System.Windows.Forms.DataGridView()
        Me.colDocName = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.colDescription = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.colFee = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.colStatus = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.colActions = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.pnlSearchFilter = New System.Windows.Forms.Panel()
        Me.btnSearch = New System.Windows.Forms.Button()
        Me.txtSearch = New System.Windows.Forms.TextBox()
        Me.pnlHeader = New System.Windows.Forms.Panel()
        Me.btnAddDocumentType = New System.Windows.Forms.Button()
        Me.lblTitle = New System.Windows.Forms.Label()
        Me.pnlMainCard.SuspendLayout()
        CType(Me.dgvDocuments, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.pnlSearchFilter.SuspendLayout()
        Me.pnlHeader.SuspendLayout()
        Me.SuspendLayout()
        '
        'pnlMainCard
        '
        Me.pnlMainCard.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.pnlMainCard.BackColor = System.Drawing.Color.White
        Me.pnlMainCard.Controls.Add(Me.dgvDocuments)
        Me.pnlMainCard.Controls.Add(Me.pnlSearchFilter)
        Me.pnlMainCard.Controls.Add(Me.pnlHeader)
        Me.pnlMainCard.Location = New System.Drawing.Point(30, 25)
        Me.pnlMainCard.Name = "pnlMainCard"
        Me.pnlMainCard.Size = New System.Drawing.Size(860, 520)
        Me.pnlMainCard.TabIndex = 0
        '
        'dgvDocuments
        '
        Me.dgvDocuments.AllowUserToAddRows = False
        Me.dgvDocuments.AllowUserToDeleteRows = False
        Me.dgvDocuments.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.dgvDocuments.BackgroundColor = System.Drawing.Color.White
        Me.dgvDocuments.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.dgvDocuments.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal
        Me.dgvDocuments.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(15, 31, 76)
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold)
        DataGridViewCellStyle1.ForeColor = System.Drawing.Color.White
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(15, 31, 76)
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.White
        DataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgvDocuments.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle1
        Me.dgvDocuments.ColumnHeadersHeight = 38
        Me.dgvDocuments.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing
        Me.dgvDocuments.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.colDocName, Me.colDescription, Me.colFee, Me.colStatus, Me.colActions})
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle2.BackColor = System.Drawing.Color.White
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Segoe UI", 9.5!)
        DataGridViewCellStyle2.ForeColor = System.Drawing.Color.FromArgb(43, 43, 43)
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(240, 244, 255)
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.FromArgb(15, 31, 76)
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.dgvDocuments.DefaultCellStyle = DataGridViewCellStyle2
        Me.dgvDocuments.EnableHeadersVisualStyles = False
        Me.dgvDocuments.GridColor = System.Drawing.Color.FromArgb(235, 235, 235)
        Me.dgvDocuments.Location = New System.Drawing.Point(25, 125)
        Me.dgvDocuments.Name = "dgvDocuments"
        Me.dgvDocuments.ReadOnly = True
        Me.dgvDocuments.RowHeadersVisible = False
        Me.dgvDocuments.RowTemplate.Height = 42
        Me.dgvDocuments.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgvDocuments.Size = New System.Drawing.Size(810, 365)
        Me.dgvDocuments.TabIndex = 2
        '
        'colDocName
        '
        Me.colDocName.HeaderText = "DOCUMENT NAME"
        Me.colDocName.Name = "colDocName"
        Me.colDocName.ReadOnly = True
        Me.colDocName.Width = 240
        '
        'colDescription
        '
        Me.colDescription.HeaderText = "DESCRIPTION"
        Me.colDescription.Name = "colDescription"
        Me.colDescription.ReadOnly = True
        Me.colDescription.Width = 260
        '
        'colFee
        '
        DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
        Me.colFee.DefaultCellStyle = DataGridViewCellStyle3
        Me.colFee.HeaderText = "FEE"
        Me.colFee.Name = "colFee"
        Me.colFee.ReadOnly = True
        Me.colFee.Width = 100
        '
        'colStatus
        '
        DataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle4.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold)
        Me.colStatus.DefaultCellStyle = DataGridViewCellStyle4
        Me.colStatus.HeaderText = "STATUS"
        Me.colStatus.Name = "colStatus"
        Me.colStatus.ReadOnly = True
        Me.colStatus.Width = 100
        '
        'colActions
        '
        Me.colActions.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.colActions.HeaderText = "ACTIONS"
        Me.colActions.Name = "colActions"
        Me.colActions.ReadOnly = True
        '
        'pnlSearchFilter
        '
        Me.pnlSearchFilter.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.pnlSearchFilter.BackColor = System.Drawing.Color.White
        Me.pnlSearchFilter.Controls.Add(Me.btnSearch)
        Me.pnlSearchFilter.Controls.Add(Me.txtSearch)
        Me.pnlSearchFilter.Location = New System.Drawing.Point(25, 68)
        Me.pnlSearchFilter.Name = "pnlSearchFilter"
        Me.pnlSearchFilter.Size = New System.Drawing.Size(810, 42)
        Me.pnlSearchFilter.TabIndex = 1
        '
        'btnSearch
        '
        Me.btnSearch.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnSearch.BackColor = System.Drawing.Color.FromArgb(15, 31, 76)
        Me.btnSearch.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnSearch.FlatAppearance.BorderSize = 0
        Me.btnSearch.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnSearch.Font = New System.Drawing.Font("Segoe UI", 9.5!, System.Drawing.FontStyle.Bold)
        Me.btnSearch.ForeColor = System.Drawing.Color.White
        Me.btnSearch.Location = New System.Drawing.Point(710, 5)
        Me.btnSearch.Name = "btnSearch"
        Me.btnSearch.Size = New System.Drawing.Size(100, 32)
        Me.btnSearch.TabIndex = 1
        Me.btnSearch.Text = "Search"
        Me.btnSearch.UseVisualStyleBackColor = False
        '
        'txtSearch
        '
        Me.txtSearch.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtSearch.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtSearch.Font = New System.Drawing.Font("Segoe UI", 10.5!)
        Me.txtSearch.ForeColor = System.Drawing.Color.FromArgb(43, 43, 43)
        Me.txtSearch.Location = New System.Drawing.Point(0, 8)
        Me.txtSearch.Name = "txtSearch"
        Me.txtSearch.Size = New System.Drawing.Size(695, 26)
        Me.txtSearch.TabIndex = 0
        '
        'pnlHeader
        '
        Me.pnlHeader.BackColor = System.Drawing.Color.FromArgb(15, 31, 76)
        Me.pnlHeader.Controls.Add(Me.btnAddDocumentType)
        Me.pnlHeader.Controls.Add(Me.lblTitle)
        Me.pnlHeader.Dock = System.Windows.Forms.DockStyle.Top
        Me.pnlHeader.Location = New System.Drawing.Point(0, 0)
        Me.pnlHeader.Name = "pnlHeader"
        Me.pnlHeader.Size = New System.Drawing.Size(860, 52)
        Me.pnlHeader.TabIndex = 0
        '
        'btnAddDocumentType
        '
        Me.btnAddDocumentType.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnAddDocumentType.BackColor = System.Drawing.Color.FromArgb(245, 197, 24)
        Me.btnAddDocumentType.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnAddDocumentType.FlatAppearance.BorderSize = 0
        Me.btnAddDocumentType.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnAddDocumentType.Font = New System.Drawing.Font("Segoe UI", 9.5!, System.Drawing.FontStyle.Bold)
        Me.btnAddDocumentType.ForeColor = System.Drawing.Color.FromArgb(15, 31, 76)
        Me.btnAddDocumentType.Location = New System.Drawing.Point(675, 10)
        Me.btnAddDocumentType.Name = "btnAddDocumentType"
        Me.btnAddDocumentType.Size = New System.Drawing.Size(170, 32)
        Me.btnAddDocumentType.TabIndex = 1
        Me.btnAddDocumentType.Text = "+ Add Document Type"
        Me.btnAddDocumentType.UseVisualStyleBackColor = False
        '
        'lblTitle
        '
        Me.lblTitle.AutoSize = True
        Me.lblTitle.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold)
        Me.lblTitle.ForeColor = System.Drawing.Color.White
        Me.lblTitle.Location = New System.Drawing.Point(20, 15)
        Me.lblTitle.Name = "lblTitle"
        Me.lblTitle.Size = New System.Drawing.Size(185, 21)
        Me.lblTitle.TabIndex = 0
        Me.lblTitle.Text = "Document Management"
        '
        'frmDocumentManagement
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(245, 246, 248)
        Me.ClientSize = New System.Drawing.Size(920, 570)
        Me.Controls.Add(Me.pnlMainCard)
        Me.Name = "frmDocumentManagement"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Document Management"
        Me.pnlMainCard.ResumeLayout(False)
        CType(Me.dgvDocuments, System.ComponentModel.ISupportInitialize).EndInit()
        Me.pnlSearchFilter.ResumeLayout(False)
        Me.pnlSearchFilter.PerformLayout()
        Me.pnlHeader.ResumeLayout(False)
        Me.pnlHeader.PerformLayout()
        Me.ResumeLayout(False)

        ' Sample preview rows for design view
        Me.dgvDocuments.Rows.Add("Transcript of Records", "Official academic record", "150.00", "Active", "Edit | Deactivate")
        Me.dgvDocuments.Rows.Add("Certificate of Enrollment", "Proof of current enrollment", "50.00", "Active", "Edit | Deactivate")
        Me.dgvDocuments.Rows.Add("Certificate of Good Moral", "Character reference", "100.00", "Active", "Edit | Deactivate")
    End Sub

    Friend WithEvents pnlMainCard As System.Windows.Forms.Panel
    Friend WithEvents pnlHeader As System.Windows.Forms.Panel
    Friend WithEvents lblTitle As System.Windows.Forms.Label
    Friend WithEvents btnAddDocumentType As System.Windows.Forms.Button
    Friend WithEvents pnlSearchFilter As System.Windows.Forms.Panel
    Friend WithEvents txtSearch As System.Windows.Forms.TextBox
    Friend WithEvents btnSearch As System.Windows.Forms.Button
    Friend WithEvents dgvDocuments As System.Windows.Forms.DataGridView
    Friend WithEvents colDocName As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents colDescription As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents colFee As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents colStatus As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents colActions As System.Windows.Forms.DataGridViewTextBoxColumn

End Class
