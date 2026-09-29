<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmAdminRequestList
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
        Dim DataGridViewCellStyle3 As DataGridViewCellStyle = New DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As DataGridViewCellStyle = New DataGridViewCellStyle()
        pnlMainCard = New Panel()
        dgvRequests = New DataGridView()
        colRequestNo = New DataGridViewTextBoxColumn()
        colStudent = New DataGridViewTextBoxColumn()
        colDocuments = New DataGridViewTextBoxColumn()
        colDate = New DataGridViewTextBoxColumn()
        colAmount = New DataGridViewTextBoxColumn()
        colPayment = New DataGridViewTextBoxColumn()
        colStatus = New DataGridViewTextBoxColumn()
        pnlSearchFilter = New Panel()
        btnSearch = New Button()
        cboStatusFilter = New ComboBox()
        txtSearch = New TextBox()
        pnlHeader = New Panel()
        lblTitle = New Label()
        pnlMainCard.SuspendLayout()
        CType(dgvRequests, ComponentModel.ISupportInitialize).BeginInit()
        pnlSearchFilter.SuspendLayout()
        pnlHeader.SuspendLayout()
        SuspendLayout()
        ' 
        ' pnlMainCard
        ' 
        pnlMainCard.Anchor = AnchorStyles.Top Or AnchorStyles.Bottom Or AnchorStyles.Left Or AnchorStyles.Right
        pnlMainCard.BackColor = Color.White
        pnlMainCard.Controls.Add(dgvRequests)
        pnlMainCard.Controls.Add(pnlSearchFilter)
        pnlMainCard.Controls.Add(pnlHeader)
        pnlMainCard.Location = New Point(34, 33)
        pnlMainCard.Margin = New Padding(3, 4, 3, 4)
        pnlMainCard.Name = "pnlMainCard"
        pnlMainCard.Size = New Size(1074, 693)
        pnlMainCard.TabIndex = 0
        ' 
        ' dgvRequests
        ' 
        dgvRequests.AllowUserToAddRows = False
        dgvRequests.AllowUserToDeleteRows = False
        dgvRequests.Anchor = AnchorStyles.Top Or AnchorStyles.Bottom Or AnchorStyles.Left Or AnchorStyles.Right
        dgvRequests.BackgroundColor = Color.White
        dgvRequests.BorderStyle = BorderStyle.None
        dgvRequests.CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal
        dgvRequests.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None
        DataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle1.BackColor = Color.FromArgb(CByte(15), CByte(31), CByte(76))
        DataGridViewCellStyle1.Font = New Font("Segoe UI", 9F, FontStyle.Bold)
        DataGridViewCellStyle1.ForeColor = Color.White
        DataGridViewCellStyle1.SelectionBackColor = Color.FromArgb(CByte(15), CByte(31), CByte(76))
        DataGridViewCellStyle1.SelectionForeColor = Color.White
        DataGridViewCellStyle1.WrapMode = DataGridViewTriState.True
        dgvRequests.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle1
        dgvRequests.ColumnHeadersHeight = 38
        dgvRequests.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.DisableResizing
        dgvRequests.Columns.AddRange(New DataGridViewColumn() {colRequestNo, colStudent, colDocuments, colDate, colAmount, colPayment, colStatus})
        DataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle3.BackColor = Color.White
        DataGridViewCellStyle3.Font = New Font("Segoe UI", 9.5F)
        DataGridViewCellStyle3.ForeColor = Color.FromArgb(CByte(43), CByte(43), CByte(43))
        DataGridViewCellStyle3.SelectionBackColor = Color.FromArgb(CByte(240), CByte(244), CByte(255))
        DataGridViewCellStyle3.SelectionForeColor = Color.FromArgb(CByte(15), CByte(31), CByte(76))
        DataGridViewCellStyle3.WrapMode = DataGridViewTriState.False
        dgvRequests.DefaultCellStyle = DataGridViewCellStyle3
        dgvRequests.EnableHeadersVisualStyles = False
        dgvRequests.GridColor = Color.FromArgb(CByte(235), CByte(235), CByte(235))
        dgvRequests.Location = New Point(29, 167)
        dgvRequests.Margin = New Padding(3, 4, 3, 4)
        dgvRequests.Name = "dgvRequests"
        dgvRequests.ReadOnly = True
        dgvRequests.RowHeadersVisible = False
        dgvRequests.RowHeadersWidth = 51
        dgvRequests.RowTemplate.Height = 42
        dgvRequests.SelectionMode = DataGridViewSelectionMode.FullRowSelect
        dgvRequests.Size = New Size(1017, 487)
        dgvRequests.TabIndex = 2
        ' 
        ' colRequestNo
        ' 
        colRequestNo.HeaderText = "REQ NO."
        colRequestNo.MinimumWidth = 6
        colRequestNo.Name = "colRequestNo"
        colRequestNo.ReadOnly = True
        ' 
        ' colStudent
        ' 
        colStudent.HeaderText = "STUDENT"
        colStudent.MinimumWidth = 6
        colStudent.Name = "colStudent"
        colStudent.ReadOnly = True
        colStudent.Width = 180
        ' 
        ' colDocuments
        ' 
        colDocuments.HeaderText = "DOCUMENT(S)"
        colDocuments.MinimumWidth = 6
        colDocuments.Name = "colDocuments"
        colDocuments.ReadOnly = True
        colDocuments.Width = 220
        ' 
        ' colDate
        ' 
        colDate.HeaderText = "DATE"
        colDate.MinimumWidth = 6
        colDate.Name = "colDate"
        colDate.ReadOnly = True
        colDate.Width = 90
        ' 
        ' colAmount
        ' 
        DataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleRight
        colAmount.DefaultCellStyle = DataGridViewCellStyle2
        colAmount.HeaderText = "AMOUNT"
        colAmount.MinimumWidth = 6
        colAmount.Name = "colAmount"
        colAmount.ReadOnly = True
        colAmount.Width = 80
        ' 
        ' colPayment
        ' 
        colPayment.HeaderText = "PAYMENT"
        colPayment.MinimumWidth = 6
        colPayment.Name = "colPayment"
        colPayment.ReadOnly = True
        ' 
        ' colStatus
        ' 
        colStatus.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill
        colStatus.HeaderText = "STATUS"
        colStatus.MinimumWidth = 6
        colStatus.Name = "colStatus"
        colStatus.ReadOnly = True
        ' 
        ' pnlSearchFilter
        ' 
        pnlSearchFilter.Anchor = AnchorStyles.Top Or AnchorStyles.Left Or AnchorStyles.Right
        pnlSearchFilter.BackColor = Color.White
        pnlSearchFilter.Controls.Add(btnSearch)
        pnlSearchFilter.Controls.Add(cboStatusFilter)
        pnlSearchFilter.Controls.Add(txtSearch)
        pnlSearchFilter.Location = New Point(29, 91)
        pnlSearchFilter.Margin = New Padding(3, 4, 3, 4)
        pnlSearchFilter.Name = "pnlSearchFilter"
        pnlSearchFilter.Size = New Size(1017, 56)
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
        btnSearch.Location = New Point(903, 7)
        btnSearch.Margin = New Padding(3, 4, 3, 4)
        btnSearch.Name = "btnSearch"
        btnSearch.Size = New Size(114, 43)
        btnSearch.TabIndex = 2
        btnSearch.Text = "Search"
        btnSearch.UseVisualStyleBackColor = False
        ' 
        ' cboStatusFilter
        ' 
        cboStatusFilter.Anchor = AnchorStyles.Top Or AnchorStyles.Right
        cboStatusFilter.DropDownStyle = ComboBoxStyle.DropDownList
        cboStatusFilter.Font = New Font("Segoe UI", 10F)
        cboStatusFilter.ForeColor = Color.FromArgb(CByte(43), CByte(43), CByte(43))
        cboStatusFilter.FormattingEnabled = True
        cboStatusFilter.Items.AddRange(New Object() {"All Statuses", "Pending", "Ready for Release", "Released", "Cancelled"})
        cboStatusFilter.Location = New Point(686, 11)
        cboStatusFilter.Margin = New Padding(3, 4, 3, 4)
        cboStatusFilter.Name = "cboStatusFilter"
        cboStatusFilter.Size = New Size(199, 31)
        cboStatusFilter.TabIndex = 1
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
        txtSearch.Size = New Size(668, 31)
        txtSearch.TabIndex = 0
        ' 
        ' pnlHeader
        ' 
        pnlHeader.BackColor = Color.FromArgb(CByte(15), CByte(31), CByte(76))
        pnlHeader.Controls.Add(lblTitle)
        pnlHeader.Dock = DockStyle.Top
        pnlHeader.Location = New Point(0, 0)
        pnlHeader.Margin = New Padding(3, 4, 3, 4)
        pnlHeader.Name = "pnlHeader"
        pnlHeader.Size = New Size(1074, 69)
        pnlHeader.TabIndex = 0
        ' 
        ' lblTitle
        ' 
        lblTitle.AutoSize = True
        lblTitle.Font = New Font("Segoe UI", 12F, FontStyle.Bold)
        lblTitle.ForeColor = Color.White
        lblTitle.Location = New Point(23, 20)
        lblTitle.Name = "lblTitle"
        lblTitle.Size = New Size(201, 28)
        lblTitle.TabIndex = 0
        lblTitle.Text = "Document Requests"
        ' 
        ' frmAdminRequestList
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.FromArgb(CByte(245), CByte(246), CByte(248))
        ClientSize = New Size(1143, 760)
        Controls.Add(pnlMainCard)
        Margin = New Padding(3, 4, 3, 4)
        Name = "frmAdminRequestList"
        StartPosition = FormStartPosition.CenterScreen
        Text = "Document Requests"
        pnlMainCard.ResumeLayout(False)
        CType(dgvRequests, ComponentModel.ISupportInitialize).EndInit()
        pnlSearchFilter.ResumeLayout(False)
        pnlSearchFilter.PerformLayout()
        pnlHeader.ResumeLayout(False)
        pnlHeader.PerformLayout()
        ResumeLayout(False)
    End Sub

    Friend WithEvents pnlMainCard As System.Windows.Forms.Panel
    Friend WithEvents pnlHeader As System.Windows.Forms.Panel
    Friend WithEvents lblTitle As System.Windows.Forms.Label
    Friend WithEvents pnlSearchFilter As System.Windows.Forms.Panel
    Friend WithEvents txtSearch As System.Windows.Forms.TextBox
    Friend WithEvents cboStatusFilter As System.Windows.Forms.ComboBox
    Friend WithEvents btnSearch As System.Windows.Forms.Button
    Friend WithEvents dgvRequests As System.Windows.Forms.DataGridView
    Friend WithEvents colRequestNo As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents colStudent As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents colDocuments As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents colDate As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents colAmount As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents colPayment As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents colStatus As System.Windows.Forms.DataGridViewTextBoxColumn
End Class
