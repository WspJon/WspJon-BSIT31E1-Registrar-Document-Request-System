<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmDocumentRequest
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
        btnSaveRequest = New Button()
        btnCancel = New Button()
        lblTotalAmountValue = New Label()
        lblTotalAmountTitle = New Label()
        cboRequestStatus = New ComboBox()
        lblRequestStatus = New Label()
        cboPaymentStatus = New ComboBox()
        lblPaymentStatus = New Label()
        btnAddDocument = New Button()
        dgvDocuments = New DataGridView()
        colDocument = New DataGridViewTextBoxColumn()
        colFee = New DataGridViewTextBoxColumn()
        colQty = New DataGridViewTextBoxColumn()
        colSubtotal = New DataGridViewTextBoxColumn()
        txtCourse = New TextBox()
        lblCourse = New Label()
        txtStudentName = New TextBox()
        lblStudentName = New Label()
        txtStudentID = New TextBox()
        lblStudentID = New Label()
        pnlHeader = New Panel()
        lblRequestNo = New Label()
        lblFormTitle = New Label()
        pnlMainCard.SuspendLayout()
        CType(dgvDocuments, ComponentModel.ISupportInitialize).BeginInit()
        pnlHeader.SuspendLayout()
        SuspendLayout()
        ' 
        ' pnlMainCard
        ' 
        pnlMainCard.Anchor = AnchorStyles.None
        pnlMainCard.BackColor = Color.FromArgb(CByte(255), CByte(249), CByte(229))
        pnlMainCard.Controls.Add(btnSaveRequest)
        pnlMainCard.Controls.Add(btnCancel)
        pnlMainCard.Controls.Add(lblTotalAmountValue)
        pnlMainCard.Controls.Add(lblTotalAmountTitle)
        pnlMainCard.Controls.Add(cboRequestStatus)
        pnlMainCard.Controls.Add(lblRequestStatus)
        pnlMainCard.Controls.Add(cboPaymentStatus)
        pnlMainCard.Controls.Add(lblPaymentStatus)
        pnlMainCard.Controls.Add(btnAddDocument)
        pnlMainCard.Controls.Add(dgvDocuments)
        pnlMainCard.Controls.Add(txtCourse)
        pnlMainCard.Controls.Add(lblCourse)
        pnlMainCard.Controls.Add(txtStudentName)
        pnlMainCard.Controls.Add(lblStudentName)
        pnlMainCard.Controls.Add(txtStudentID)
        pnlMainCard.Controls.Add(lblStudentID)
        pnlMainCard.Controls.Add(pnlHeader)
        pnlMainCard.Location = New Point(40, 33)
        pnlMainCard.Margin = New Padding(3, 4, 3, 4)
        pnlMainCard.Name = "pnlMainCard"
        pnlMainCard.Size = New Size(903, 693)
        pnlMainCard.TabIndex = 0
        ' 
        ' btnSaveRequest
        ' 
        btnSaveRequest.Anchor = AnchorStyles.Bottom Or AnchorStyles.Right
        btnSaveRequest.BackColor = Color.FromArgb(CByte(245), CByte(197), CByte(24))
        btnSaveRequest.Cursor = Cursors.Hand
        btnSaveRequest.FlatAppearance.BorderSize = 0
        btnSaveRequest.FlatStyle = FlatStyle.Flat
        btnSaveRequest.Font = New Font("Segoe UI", 10F, FontStyle.Bold)
        btnSaveRequest.ForeColor = Color.FromArgb(CByte(15), CByte(31), CByte(76))
        btnSaveRequest.Location = New Point(737, 607)
        btnSaveRequest.Margin = New Padding(3, 4, 3, 4)
        btnSaveRequest.Name = "btnSaveRequest"
        btnSaveRequest.Size = New Size(137, 53)
        btnSaveRequest.TabIndex = 16
        btnSaveRequest.Text = "Save Request"
        btnSaveRequest.UseVisualStyleBackColor = False
        ' 
        ' btnCancel
        ' 
        btnCancel.Anchor = AnchorStyles.Bottom Or AnchorStyles.Right
        btnCancel.BackColor = Color.White
        btnCancel.Cursor = Cursors.Hand
        btnCancel.FlatAppearance.BorderColor = Color.FromArgb(CByte(15), CByte(31), CByte(76))
        btnCancel.FlatStyle = FlatStyle.Flat
        btnCancel.Font = New Font("Segoe UI", 10F, FontStyle.Bold)
        btnCancel.ForeColor = Color.FromArgb(CByte(15), CByte(31), CByte(76))
        btnCancel.Location = New Point(611, 607)
        btnCancel.Margin = New Padding(3, 4, 3, 4)
        btnCancel.Name = "btnCancel"
        btnCancel.Size = New Size(109, 53)
        btnCancel.TabIndex = 15
        btnCancel.Text = "Cancel"
        btnCancel.UseVisualStyleBackColor = False
        ' 
        ' lblTotalAmountValue
        ' 
        lblTotalAmountValue.Anchor = AnchorStyles.Top Or AnchorStyles.Right
        lblTotalAmountValue.AutoSize = True
        lblTotalAmountValue.Font = New Font("Segoe UI", 20F, FontStyle.Bold)
        lblTotalAmountValue.ForeColor = Color.FromArgb(CByte(15), CByte(31), CByte(76))
        lblTotalAmountValue.Location = New Point(727, 467)
        lblTotalAmountValue.Name = "lblTotalAmountValue"
        lblTotalAmountValue.Size = New Size(111, 46)
        lblTotalAmountValue.TabIndex = 14
        lblTotalAmountValue.Text = "₱0.00"
        ' 
        ' lblTotalAmountTitle
        ' 
        lblTotalAmountTitle.Anchor = AnchorStyles.Top Or AnchorStyles.Right
        lblTotalAmountTitle.AutoSize = True
        lblTotalAmountTitle.Font = New Font("Segoe UI", 8.5F, FontStyle.Bold)
        lblTotalAmountTitle.ForeColor = Color.FromArgb(CByte(90), CByte(90), CByte(90))
        lblTotalAmountTitle.Location = New Point(731, 440)
        lblTotalAmountTitle.Name = "lblTotalAmountTitle"
        lblTotalAmountTitle.Size = New Size(126, 20)
        lblTotalAmountTitle.TabIndex = 13
        lblTotalAmountTitle.Text = "TOTAL AMOUNT"
        ' 
        ' cboRequestStatus
        ' 
        cboRequestStatus.DropDownStyle = ComboBoxStyle.DropDownList
        cboRequestStatus.Font = New Font("Segoe UI", 10F)
        cboRequestStatus.ForeColor = Color.FromArgb(CByte(43), CByte(43), CByte(43))
        cboRequestStatus.FormattingEnabled = True
        cboRequestStatus.Items.AddRange(New Object() {"Pending", "Processing", "Ready for Release", "Released", "Cancelled"})
        cboRequestStatus.Location = New Point(303, 472)
        cboRequestStatus.Margin = New Padding(3, 4, 3, 4)
        cboRequestStatus.Name = "cboRequestStatus"
        cboRequestStatus.Size = New Size(239, 31)
        cboRequestStatus.TabIndex = 12
        ' 
        ' lblRequestStatus
        ' 
        lblRequestStatus.AutoSize = True
        lblRequestStatus.Font = New Font("Segoe UI", 8.5F, FontStyle.Bold)
        lblRequestStatus.ForeColor = Color.FromArgb(CByte(90), CByte(90), CByte(90))
        lblRequestStatus.Location = New Point(303, 440)
        lblRequestStatus.Name = "lblRequestStatus"
        lblRequestStatus.Size = New Size(132, 20)
        lblRequestStatus.TabIndex = 11
        lblRequestStatus.Text = "REQUEST STATUS"
        ' 
        ' cboPaymentStatus
        ' 
        cboPaymentStatus.DropDownStyle = ComboBoxStyle.DropDownList
        cboPaymentStatus.Font = New Font("Segoe UI", 10F)
        cboPaymentStatus.ForeColor = Color.FromArgb(CByte(43), CByte(43), CByte(43))
        cboPaymentStatus.FormattingEnabled = True
        cboPaymentStatus.Items.AddRange(New Object() {"Unpaid", "Paid"})
        cboPaymentStatus.Location = New Point(29, 472)
        cboPaymentStatus.Margin = New Padding(3, 4, 3, 4)
        cboPaymentStatus.Name = "cboPaymentStatus"
        cboPaymentStatus.Size = New Size(239, 31)
        cboPaymentStatus.TabIndex = 10
        ' 
        ' lblPaymentStatus
        ' 
        lblPaymentStatus.AutoSize = True
        lblPaymentStatus.Font = New Font("Segoe UI", 8.5F, FontStyle.Bold)
        lblPaymentStatus.ForeColor = Color.FromArgb(CByte(90), CByte(90), CByte(90))
        lblPaymentStatus.Location = New Point(29, 440)
        lblPaymentStatus.Name = "lblPaymentStatus"
        lblPaymentStatus.Size = New Size(137, 20)
        lblPaymentStatus.TabIndex = 9
        lblPaymentStatus.Text = "PAYMENT STATUS"
        ' 
        ' btnAddDocument
        ' 
        btnAddDocument.BackColor = Color.Transparent
        btnAddDocument.Cursor = Cursors.Hand
        btnAddDocument.FlatAppearance.BorderSize = 0
        btnAddDocument.FlatStyle = FlatStyle.Flat
        btnAddDocument.Font = New Font("Segoe UI", 9.5F, FontStyle.Bold)
        btnAddDocument.ForeColor = Color.FromArgb(CByte(15), CByte(31), CByte(76))
        btnAddDocument.Location = New Point(23, 367)
        btnAddDocument.Margin = New Padding(3, 4, 3, 4)
        btnAddDocument.Name = "btnAddDocument"
        btnAddDocument.Size = New Size(166, 40)
        btnAddDocument.TabIndex = 8
        btnAddDocument.Text = "+ Add document"
        btnAddDocument.TextAlign = ContentAlignment.MiddleLeft
        btnAddDocument.UseVisualStyleBackColor = False
        ' 
        ' dgvDocuments
        ' 
        dgvDocuments.AllowUserToAddRows = False
        dgvDocuments.AllowUserToDeleteRows = False
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
        dgvDocuments.ColumnHeadersHeight = 36
        dgvDocuments.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.DisableResizing
        dgvDocuments.Columns.AddRange(New DataGridViewColumn() {colDocument, colFee, colQty, colSubtotal})
        DataGridViewCellStyle4.Alignment = DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle4.BackColor = Color.White
        DataGridViewCellStyle4.Font = New Font("Segoe UI", 9.5F)
        DataGridViewCellStyle4.ForeColor = Color.FromArgb(CByte(43), CByte(43), CByte(43))
        DataGridViewCellStyle4.SelectionBackColor = Color.FromArgb(CByte(242), CByte(245), CByte(252))
        DataGridViewCellStyle4.SelectionForeColor = Color.FromArgb(CByte(15), CByte(31), CByte(76))
        DataGridViewCellStyle4.WrapMode = DataGridViewTriState.False
        dgvDocuments.DefaultCellStyle = DataGridViewCellStyle4
        dgvDocuments.EnableHeadersVisualStyles = False
        dgvDocuments.GridColor = Color.FromArgb(CByte(235), CByte(235), CByte(235))
        dgvDocuments.Location = New Point(29, 193)
        dgvDocuments.Margin = New Padding(3, 4, 3, 4)
        dgvDocuments.Name = "dgvDocuments"
        dgvDocuments.RowHeadersVisible = False
        dgvDocuments.RowHeadersWidth = 51
        dgvDocuments.RowTemplate.Height = 38
        dgvDocuments.ScrollBars = ScrollBars.None
        dgvDocuments.Size = New Size(846, 167)
        dgvDocuments.TabIndex = 7
        ' 
        ' colDocument
        ' 
        colDocument.HeaderText = "DOCUMENT"
        colDocument.MinimumWidth = 6
        colDocument.Name = "colDocument"
        colDocument.ReadOnly = True
        colDocument.Width = 330
        ' 
        ' colFee
        ' 
        DataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleRight
        colFee.DefaultCellStyle = DataGridViewCellStyle2
        colFee.HeaderText = "FEE"
        colFee.MinimumWidth = 6
        colFee.Name = "colFee"
        colFee.ReadOnly = True
        colFee.Width = 130
        ' 
        ' colQty
        ' 
        DataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleCenter
        colQty.DefaultCellStyle = DataGridViewCellStyle3
        colQty.HeaderText = "QTY"
        colQty.MinimumWidth = 6
        colQty.Name = "colQty"
        colQty.Width = 120
        ' 
        ' colSubtotal
        ' 
        colSubtotal.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill
        colSubtotal.HeaderText = "SUBTOTAL"
        colSubtotal.MinimumWidth = 6
        colSubtotal.Name = "colSubtotal"
        colSubtotal.ReadOnly = True
        ' 
        ' txtCourse
        ' 
        txtCourse.BackColor = Color.FromArgb(CByte(245), CByte(246), CByte(248))
        txtCourse.BorderStyle = BorderStyle.FixedSingle
        txtCourse.Font = New Font("Segoe UI", 10F)
        txtCourse.ForeColor = Color.FromArgb(CByte(43), CByte(43), CByte(43))
        txtCourse.Location = New Point(663, 123)
        txtCourse.Margin = New Padding(3, 4, 3, 4)
        txtCourse.Name = "txtCourse"
        txtCourse.ReadOnly = True
        txtCourse.Size = New Size(211, 30)
        txtCourse.TabIndex = 6
        ' 
        ' lblCourse
        ' 
        lblCourse.AutoSize = True
        lblCourse.Font = New Font("Segoe UI", 8.5F, FontStyle.Bold)
        lblCourse.ForeColor = Color.FromArgb(CByte(90), CByte(90), CByte(90))
        lblCourse.Location = New Point(663, 93)
        lblCourse.Name = "lblCourse"
        lblCourse.Size = New Size(66, 20)
        lblCourse.TabIndex = 5
        lblCourse.Text = "COURSE"
        ' 
        ' txtStudentName
        ' 
        txtStudentName.BackColor = Color.FromArgb(CByte(245), CByte(246), CByte(248))
        txtStudentName.BorderStyle = BorderStyle.FixedSingle
        txtStudentName.Font = New Font("Segoe UI", 10F)
        txtStudentName.ForeColor = Color.FromArgb(CByte(43), CByte(43), CByte(43))
        txtStudentName.Location = New Point(251, 123)
        txtStudentName.Margin = New Padding(3, 4, 3, 4)
        txtStudentName.Name = "txtStudentName"
        txtStudentName.ReadOnly = True
        txtStudentName.Size = New Size(388, 30)
        txtStudentName.TabIndex = 4
        ' 
        ' lblStudentName
        ' 
        lblStudentName.AutoSize = True
        lblStudentName.Font = New Font("Segoe UI", 8.5F, FontStyle.Bold)
        lblStudentName.ForeColor = Color.FromArgb(CByte(90), CByte(90), CByte(90))
        lblStudentName.Location = New Point(251, 93)
        lblStudentName.Name = "lblStudentName"
        lblStudentName.Size = New Size(126, 20)
        lblStudentName.TabIndex = 3
        lblStudentName.Text = "STUDENT NAME"
        ' 
        ' txtStudentID
        ' 
        txtStudentID.BorderStyle = BorderStyle.FixedSingle
        txtStudentID.Font = New Font("Segoe UI", 10F)
        txtStudentID.ForeColor = Color.FromArgb(CByte(43), CByte(43), CByte(43))
        txtStudentID.Location = New Point(29, 123)
        txtStudentID.Margin = New Padding(3, 4, 3, 4)
        txtStudentID.Name = "txtStudentID"
        txtStudentID.Size = New Size(200, 30)
        txtStudentID.TabIndex = 2
        ' 
        ' lblStudentID
        ' 
        lblStudentID.AutoSize = True
        lblStudentID.Font = New Font("Segoe UI", 8.5F, FontStyle.Bold)
        lblStudentID.ForeColor = Color.FromArgb(CByte(90), CByte(90), CByte(90))
        lblStudentID.Location = New Point(29, 93)
        lblStudentID.Name = "lblStudentID"
        lblStudentID.Size = New Size(97, 20)
        lblStudentID.TabIndex = 1
        lblStudentID.Text = "STUDENT ID"
        ' 
        ' pnlHeader
        ' 
        pnlHeader.BackColor = Color.FromArgb(CByte(15), CByte(31), CByte(76))
        pnlHeader.Controls.Add(lblRequestNo)
        pnlHeader.Controls.Add(lblFormTitle)
        pnlHeader.Dock = DockStyle.Top
        pnlHeader.Location = New Point(0, 0)
        pnlHeader.Margin = New Padding(3, 4, 3, 4)
        pnlHeader.Name = "pnlHeader"
        pnlHeader.Size = New Size(903, 64)
        pnlHeader.TabIndex = 0
        ' 
        ' lblRequestNo
        ' 
        lblRequestNo.Anchor = AnchorStyles.Top Or AnchorStyles.Right
        lblRequestNo.Font = New Font("Segoe UI", 11F, FontStyle.Bold)
        lblRequestNo.ForeColor = Color.FromArgb(CByte(245), CByte(197), CByte(24))
        lblRequestNo.Location = New Point(674, 19)
        lblRequestNo.Name = "lblRequestNo"
        lblRequestNo.Size = New Size(206, 27)
        lblRequestNo.TabIndex = 1
        lblRequestNo.Text = "REQ-2026-00129"
        lblRequestNo.TextAlign = ContentAlignment.MiddleRight
        ' 
        ' lblFormTitle
        ' 
        lblFormTitle.AutoSize = True
        lblFormTitle.Font = New Font("Segoe UI", 12F, FontStyle.Bold)
        lblFormTitle.ForeColor = Color.White
        lblFormTitle.Location = New Point(23, 17)
        lblFormTitle.Name = "lblFormTitle"
        lblFormTitle.Size = New Size(241, 28)
        lblFormTitle.TabIndex = 0
        lblFormTitle.Text = "New Document Request"
        ' 
        ' frmDocumentRequest
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.FromArgb(CByte(255), CByte(249), CByte(229))
        ClientSize = New Size(983, 760)
        Controls.Add(pnlMainCard)
        FormBorderStyle = FormBorderStyle.FixedDialog
        Margin = New Padding(3, 4, 3, 4)
        MaximizeBox = False
        Name = "frmDocumentRequest"
        StartPosition = FormStartPosition.CenterScreen
        Text = "New Document Request"
        pnlMainCard.ResumeLayout(False)
        pnlMainCard.PerformLayout()
        CType(dgvDocuments, ComponentModel.ISupportInitialize).EndInit()
        pnlHeader.ResumeLayout(False)
        pnlHeader.PerformLayout()
        ResumeLayout(False)
    End Sub

    Friend WithEvents pnlMainCard As System.Windows.Forms.Panel
    Friend WithEvents pnlHeader As System.Windows.Forms.Panel
    Friend WithEvents lblFormTitle As System.Windows.Forms.Label
    Friend WithEvents lblRequestNo As System.Windows.Forms.Label
    Friend WithEvents lblStudentID As System.Windows.Forms.Label
    Friend WithEvents txtStudentID As System.Windows.Forms.TextBox
    Friend WithEvents lblStudentName As System.Windows.Forms.Label
    Friend WithEvents txtStudentName As System.Windows.Forms.TextBox
    Friend WithEvents lblCourse As System.Windows.Forms.Label
    Friend WithEvents txtCourse As System.Windows.Forms.TextBox
    Friend WithEvents dgvDocuments As System.Windows.Forms.DataGridView
    Friend WithEvents colDocument As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents colFee As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents colQty As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents colSubtotal As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents btnAddDocument As System.Windows.Forms.Button
    Friend WithEvents lblPaymentStatus As System.Windows.Forms.Label
    Friend WithEvents cboPaymentStatus As System.Windows.Forms.ComboBox
    Friend WithEvents lblRequestStatus As System.Windows.Forms.Label
    Friend WithEvents cboRequestStatus As System.Windows.Forms.ComboBox
    Friend WithEvents lblTotalAmountTitle As System.Windows.Forms.Label
    Friend WithEvents lblTotalAmountValue As System.Windows.Forms.Label
    Friend WithEvents btnCancel As System.Windows.Forms.Button
    Friend WithEvents btnSaveRequest As System.Windows.Forms.Button

End Class
