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
        Dim DataGridViewCellStyle1 As DataGridViewCellStyle = New DataGridViewCellStyle()
        Dim DataGridViewCellStyle4 As DataGridViewCellStyle = New DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As DataGridViewCellStyle = New DataGridViewCellStyle()
        Dim DataGridViewCellStyle3 As DataGridViewCellStyle = New DataGridViewCellStyle()
        pnlMainCard = New Panel()
        dgvDocuments = New DataGridView()
        colDocName = New DataGridViewTextBoxColumn()
        colDescription = New DataGridViewTextBoxColumn()
        colFee = New DataGridViewTextBoxColumn()
        colStatus = New DataGridViewTextBoxColumn()
        colActions = New DataGridViewTextBoxColumn()
        pnlSearchFilter = New Panel()
        btnSearch = New Button()
        txtSearch = New TextBox()
        pnlHeader = New Panel()
        btnAddDocumentType = New Button()
        lblTitle = New Label()
        pnlMainCard.SuspendLayout()
        CType(dgvDocuments, ComponentModel.ISupportInitialize).BeginInit()
        pnlSearchFilter.SuspendLayout()
        pnlHeader.SuspendLayout()
        SuspendLayout()
        ' 
        ' pnlMainCard
        ' 
        pnlMainCard.Anchor = AnchorStyles.Top Or AnchorStyles.Bottom Or AnchorStyles.Left Or AnchorStyles.Right
        pnlMainCard.BackColor = Color.White
        pnlMainCard.Controls.Add(dgvDocuments)
        pnlMainCard.Controls.Add(pnlSearchFilter)
        pnlMainCard.Controls.Add(pnlHeader)
        pnlMainCard.Location = New Point(34, 33)
        pnlMainCard.Margin = New Padding(3, 4, 3, 4)
        pnlMainCard.Name = "pnlMainCard"
        pnlMainCard.Size = New Size(983, 693)
        pnlMainCard.TabIndex = 0
        ' 
        ' dgvDocuments
        ' 
        dgvDocuments.AllowUserToAddRows = False
        dgvDocuments.AllowUserToDeleteRows = False
        dgvDocuments.Anchor = AnchorStyles.Top Or AnchorStyles.Bottom Or AnchorStyles.Left Or AnchorStyles.Right
        dgvDocuments.BackgroundColor = Color.White
        dgvDocuments.BorderStyle = BorderStyle.None
        dgvDocuments.CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal
        dgvDocuments.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None
        DataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle1.BackColor = Color.FromArgb(CByte(15), CByte(31), CByte(76))
        DataGridViewCellStyle1.Font = New Font("Segoe UI", 9F, FontStyle.Bold)
        DataGridViewCellStyle1.ForeColor = Color.White
        DataGridViewCellStyle1.SelectionBackColor = Color.FromArgb(CByte(15), CByte(31), CByte(76))
        DataGridViewCellStyle1.SelectionForeColor = Color.White
        DataGridViewCellStyle1.WrapMode = DataGridViewTriState.True
        dgvDocuments.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle1
        dgvDocuments.ColumnHeadersHeight = 38
        dgvDocuments.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.DisableResizing
        dgvDocuments.Columns.AddRange(New DataGridViewColumn() {colDocName, colDescription, colFee, colStatus, colActions})
        DataGridViewCellStyle4.Alignment = DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle4.BackColor = Color.White
        DataGridViewCellStyle4.Font = New Font("Segoe UI", 9.5F)
        DataGridViewCellStyle4.ForeColor = Color.FromArgb(CByte(43), CByte(43), CByte(43))
        DataGridViewCellStyle4.SelectionBackColor = Color.FromArgb(CByte(240), CByte(244), CByte(255))
        DataGridViewCellStyle4.SelectionForeColor = Color.FromArgb(CByte(15), CByte(31), CByte(76))
        DataGridViewCellStyle4.WrapMode = DataGridViewTriState.False
        dgvDocuments.DefaultCellStyle = DataGridViewCellStyle4
        dgvDocuments.EnableHeadersVisualStyles = False
        dgvDocuments.GridColor = Color.FromArgb(CByte(235), CByte(235), CByte(235))
        dgvDocuments.Location = New Point(29, 167)
        dgvDocuments.Margin = New Padding(3, 4, 3, 4)
        dgvDocuments.Name = "dgvDocuments"
        dgvDocuments.ReadOnly = True
        dgvDocuments.RowHeadersVisible = False
        dgvDocuments.RowHeadersWidth = 51
        dgvDocuments.RowTemplate.Height = 42
        dgvDocuments.SelectionMode = DataGridViewSelectionMode.FullRowSelect
        dgvDocuments.Size = New Size(926, 487)
        dgvDocuments.TabIndex = 2
        ' 
        ' colDocName
        ' 
        colDocName.HeaderText = "DOCUMENT NAME"
        colDocName.MinimumWidth = 6
        colDocName.Name = "colDocName"
        colDocName.ReadOnly = True
        colDocName.Width = 240
        ' 
        ' colDescription
        ' 
        colDescription.HeaderText = "DESCRIPTION"
        colDescription.MinimumWidth = 6
        colDescription.Name = "colDescription"
        colDescription.ReadOnly = True
        colDescription.Width = 260
        ' 
        ' colFee
        ' 
        DataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleRight
        colFee.DefaultCellStyle = DataGridViewCellStyle2
        colFee.HeaderText = "FEE"
        colFee.MinimumWidth = 6
        colFee.Name = "colFee"
        colFee.ReadOnly = True
        ' 
        ' colStatus
        ' 
        DataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle3.Font = New Font("Segoe UI", 9F, FontStyle.Bold)
        colStatus.DefaultCellStyle = DataGridViewCellStyle3
        colStatus.HeaderText = "STATUS"
        colStatus.MinimumWidth = 6
        colStatus.Name = "colStatus"
        colStatus.ReadOnly = True
        ' 
        ' colActions
        ' 
        colActions.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill
        colActions.HeaderText = "ACTIONS"
        colActions.MinimumWidth = 6
        colActions.Name = "colActions"
        colActions.ReadOnly = True
        ' 
        ' pnlSearchFilter
        ' 
        pnlSearchFilter.Anchor = AnchorStyles.Top Or AnchorStyles.Left Or AnchorStyles.Right
        pnlSearchFilter.BackColor = Color.White
        pnlSearchFilter.Controls.Add(btnSearch)
        pnlSearchFilter.Controls.Add(txtSearch)
        pnlSearchFilter.Location = New Point(29, 91)
        pnlSearchFilter.Margin = New Padding(3, 4, 3, 4)
        pnlSearchFilter.Name = "pnlSearchFilter"
        pnlSearchFilter.Size = New Size(926, 56)
        pnlSearchFilter.TabIndex = 1
        ' 
        ' btnSearch
        ' 
        btnSearch.Anchor = AnchorStyles.Top Or AnchorStyles.Right
        btnSearch.BackColor = Color.FromArgb(CByte(15), CByte(31), CByte(76))
        btnSearch.Cursor = Cursors.Hand
        btnSearch.FlatAppearance.BorderSize = 0
        btnSearch.FlatStyle = FlatStyle.Flat
        btnSearch.Font = New Font("Segoe UI", 9.5F, FontStyle.Bold)
        btnSearch.ForeColor = Color.White
        btnSearch.Location = New Point(811, 7)
        btnSearch.Margin = New Padding(3, 4, 3, 4)
        btnSearch.Name = "btnSearch"
        btnSearch.Size = New Size(114, 43)
        btnSearch.TabIndex = 1
        btnSearch.Text = "Search"
        btnSearch.UseVisualStyleBackColor = False
        ' 
        ' txtSearch
        ' 
        txtSearch.Anchor = AnchorStyles.Top Or AnchorStyles.Left Or AnchorStyles.Right
        txtSearch.BorderStyle = BorderStyle.FixedSingle
        txtSearch.Font = New Font("Segoe UI", 10.5F)
        txtSearch.ForeColor = Color.FromArgb(CByte(43), CByte(43), CByte(43))
        txtSearch.Location = New Point(0, 11)
        txtSearch.Margin = New Padding(3, 4, 3, 4)
        txtSearch.Name = "txtSearch"
        txtSearch.Size = New Size(794, 31)
        txtSearch.TabIndex = 0
        ' 
        ' pnlHeader
        ' 
        pnlHeader.BackColor = Color.FromArgb(CByte(15), CByte(31), CByte(76))
        pnlHeader.Controls.Add(btnAddDocumentType)
        pnlHeader.Controls.Add(lblTitle)
        pnlHeader.Dock = DockStyle.Top
        pnlHeader.Location = New Point(0, 0)
        pnlHeader.Margin = New Padding(3, 4, 3, 4)
        pnlHeader.Name = "pnlHeader"
        pnlHeader.Size = New Size(983, 69)
        pnlHeader.TabIndex = 0
        ' 
        ' btnAddDocumentType
        ' 
        btnAddDocumentType.Anchor = AnchorStyles.Top Or AnchorStyles.Right
        btnAddDocumentType.BackColor = Color.FromArgb(CByte(245), CByte(197), CByte(24))
        btnAddDocumentType.Cursor = Cursors.Hand
        btnAddDocumentType.FlatAppearance.BorderSize = 0
        btnAddDocumentType.FlatStyle = FlatStyle.Flat
        btnAddDocumentType.Font = New Font("Segoe UI", 9.5F, FontStyle.Bold)
        btnAddDocumentType.ForeColor = Color.FromArgb(CByte(15), CByte(31), CByte(76))
        btnAddDocumentType.Location = New Point(771, 13)
        btnAddDocumentType.Margin = New Padding(3, 4, 3, 4)
        btnAddDocumentType.Name = "btnAddDocumentType"
        btnAddDocumentType.Size = New Size(194, 43)
        btnAddDocumentType.TabIndex = 1
        btnAddDocumentType.Text = "+ Add Document Type"
        btnAddDocumentType.UseVisualStyleBackColor = False
        ' 
        ' lblTitle
        ' 
        lblTitle.AutoSize = True
        lblTitle.Font = New Font("Segoe UI", 12F, FontStyle.Bold)
        lblTitle.ForeColor = Color.White
        lblTitle.Location = New Point(23, 20)
        lblTitle.Name = "lblTitle"
        lblTitle.Size = New Size(241, 28)
        lblTitle.TabIndex = 0
        lblTitle.Text = "Document Management"
        ' 
        ' frmDocumentManagement
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.FromArgb(CByte(245), CByte(246), CByte(248))
        ClientSize = New Size(1051, 760)
        Controls.Add(pnlMainCard)
        Margin = New Padding(3, 4, 3, 4)
        Name = "frmDocumentManagement"
        StartPosition = FormStartPosition.CenterScreen
        Text = "Document Management"
        pnlMainCard.ResumeLayout(False)
        CType(dgvDocuments, ComponentModel.ISupportInitialize).EndInit()
        pnlSearchFilter.ResumeLayout(False)
        pnlSearchFilter.PerformLayout()
        pnlHeader.ResumeLayout(False)
        pnlHeader.PerformLayout()
        ResumeLayout(False)

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
