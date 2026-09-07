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
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle4 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.pnlMainCard = New System.Windows.Forms.Panel()
        Me.btnSaveRequest = New System.Windows.Forms.Button()
        Me.btnCancel = New System.Windows.Forms.Button()
        Me.lblTotalAmountValue = New System.Windows.Forms.Label()
        Me.lblTotalAmountTitle = New System.Windows.Forms.Label()
        Me.cboRequestStatus = New System.Windows.Forms.ComboBox()
        Me.lblRequestStatus = New System.Windows.Forms.Label()
        Me.cboPaymentStatus = New System.Windows.Forms.ComboBox()
        Me.lblPaymentStatus = New System.Windows.Forms.Label()
        Me.btnAddDocument = New System.Windows.Forms.Button()
        Me.dgvDocuments = New System.Windows.Forms.DataGridView()
        Me.colDocument = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.colFee = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.colQty = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.colSubtotal = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.txtCourse = New System.Windows.Forms.TextBox()
        Me.lblCourse = New System.Windows.Forms.Label()
        Me.txtStudentName = New System.Windows.Forms.TextBox()
        Me.lblStudentName = New System.Windows.Forms.Label()
        Me.txtStudentID = New System.Windows.Forms.TextBox()
        Me.lblStudentID = New System.Windows.Forms.Label()
        Me.pnlHeader = New System.Windows.Forms.Panel()
        Me.lblRequestNo = New System.Windows.Forms.Label()
        Me.lblFormTitle = New System.Windows.Forms.Label()
        Me.pnlMainCard.SuspendLayout()
        CType(Me.dgvDocuments, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.pnlHeader.SuspendLayout()
        Me.SuspendLayout()
        '
        'pnlMainCard
        '
        Me.pnlMainCard.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.pnlMainCard.BackColor = System.Drawing.Color.White
        Me.pnlMainCard.Controls.Add(Me.btnSaveRequest)
        Me.pnlMainCard.Controls.Add(Me.btnCancel)
        Me.pnlMainCard.Controls.Add(Me.lblTotalAmountValue)
        Me.pnlMainCard.Controls.Add(Me.lblTotalAmountTitle)
        Me.pnlMainCard.Controls.Add(Me.cboRequestStatus)
        Me.pnlMainCard.Controls.Add(Me.lblRequestStatus)
        Me.pnlMainCard.Controls.Add(Me.cboPaymentStatus)
        Me.pnlMainCard.Controls.Add(Me.lblPaymentStatus)
        Me.pnlMainCard.Controls.Add(Me.btnAddDocument)
        Me.pnlMainCard.Controls.Add(Me.dgvDocuments)
        Me.pnlMainCard.Controls.Add(Me.txtCourse)
        Me.pnlMainCard.Controls.Add(Me.lblCourse)
        Me.pnlMainCard.Controls.Add(Me.txtStudentName)
        Me.pnlMainCard.Controls.Add(Me.lblStudentName)
        Me.pnlMainCard.Controls.Add(Me.txtStudentID)
        Me.pnlMainCard.Controls.Add(Me.lblStudentID)
        Me.pnlMainCard.Controls.Add(Me.pnlHeader)
        Me.pnlMainCard.Location = New System.Drawing.Point(35, 25)
        Me.pnlMainCard.Name = "pnlMainCard"
        Me.pnlMainCard.Size = New System.Drawing.Size(790, 520)
        Me.pnlMainCard.TabIndex = 0
        '
        'btnSaveRequest
        '
        Me.btnSaveRequest.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnSaveRequest.BackColor = System.Drawing.Color.FromArgb(245, 197, 24)
        Me.btnSaveRequest.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnSaveRequest.FlatAppearance.BorderSize = 0
        Me.btnSaveRequest.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnSaveRequest.Font = New System.Drawing.Font("Segoe UI", 10.0!, System.Drawing.FontStyle.Bold)
        Me.btnSaveRequest.ForeColor = System.Drawing.Color.FromArgb(15, 31, 76)
        Me.btnSaveRequest.Location = New System.Drawing.Point(645, 455)
        Me.btnSaveRequest.Name = "btnSaveRequest"
        Me.btnSaveRequest.Size = New System.Drawing.Size(120, 40)
        Me.btnSaveRequest.TabIndex = 16
        Me.btnSaveRequest.Text = "Save Request"
        Me.btnSaveRequest.UseVisualStyleBackColor = False
        '
        'btnCancel
        '
        Me.btnCancel.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnCancel.BackColor = System.Drawing.Color.White
        Me.btnCancel.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnCancel.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(15, 31, 76)
        Me.btnCancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnCancel.Font = New System.Drawing.Font("Segoe UI", 10.0!, System.Drawing.FontStyle.Bold)
        Me.btnCancel.ForeColor = System.Drawing.Color.FromArgb(15, 31, 76)
        Me.btnCancel.Location = New System.Drawing.Point(535, 455)
        Me.btnCancel.Name = "btnCancel"
        Me.btnCancel.Size = New System.Drawing.Size(95, 40)
        Me.btnCancel.TabIndex = 15
        Me.btnCancel.Text = "Cancel"
        Me.btnCancel.UseVisualStyleBackColor = False
        '
        'lblTotalAmountValue
        '
        Me.lblTotalAmountValue.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lblTotalAmountValue.AutoSize = True
        Me.lblTotalAmountValue.Font = New System.Drawing.Font("Segoe UI", 20.0!, System.Drawing.FontStyle.Bold)
        Me.lblTotalAmountValue.ForeColor = System.Drawing.Color.FromArgb(15, 31, 76)
        Me.lblTotalAmountValue.Location = New System.Drawing.Point(636, 350)
        Me.lblTotalAmountValue.Name = "lblTotalAmountValue"
        Me.lblTotalAmountValue.Size = New System.Drawing.Size(126, 37)
        Me.lblTotalAmountValue.TabIndex = 14
        Me.lblTotalAmountValue.Text = "₱350.00"
        '
        'lblTotalAmountTitle
        '
        Me.lblTotalAmountTitle.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lblTotalAmountTitle.AutoSize = True
        Me.lblTotalAmountTitle.Font = New System.Drawing.Font("Segoe UI", 8.5!, System.Drawing.FontStyle.Bold)
        Me.lblTotalAmountTitle.ForeColor = System.Drawing.Color.FromArgb(90, 90, 90)
        Me.lblTotalAmountTitle.Location = New System.Drawing.Point(640, 330)
        Me.lblTotalAmountTitle.Name = "lblTotalAmountTitle"
        Me.lblTotalAmountTitle.Size = New System.Drawing.Size(97, 15)
        Me.lblTotalAmountTitle.TabIndex = 13
        Me.lblTotalAmountTitle.Text = "TOTAL AMOUNT"
        '
        'cboRequestStatus
        '
        Me.cboRequestStatus.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboRequestStatus.Font = New System.Drawing.Font("Segoe UI", 10.0!)
        Me.cboRequestStatus.ForeColor = System.Drawing.Color.FromArgb(43, 43, 43)
        Me.cboRequestStatus.FormattingEnabled = True
        Me.cboRequestStatus.Items.AddRange(New Object() {"Pending", "Processing", "Ready for Release", "Released", "Cancelled"})
        Me.cboRequestStatus.Location = New System.Drawing.Point(265, 354)
        Me.cboRequestStatus.Name = "cboRequestStatus"
        Me.cboRequestStatus.Size = New System.Drawing.Size(210, 25)
        Me.cboRequestStatus.TabIndex = 12
        '
        'lblRequestStatus
        '
        Me.lblRequestStatus.AutoSize = True
        Me.lblRequestStatus.Font = New System.Drawing.Font("Segoe UI", 8.5!, System.Drawing.FontStyle.Bold)
        Me.lblRequestStatus.ForeColor = System.Drawing.Color.FromArgb(90, 90, 90)
        Me.lblRequestStatus.Location = New System.Drawing.Point(265, 330)
        Me.lblRequestStatus.Name = "lblRequestStatus"
        Me.lblRequestStatus.Size = New System.Drawing.Size(103, 15)
        Me.lblRequestStatus.TabIndex = 11
        Me.lblRequestStatus.Text = "REQUEST STATUS"
        '
        'cboPaymentStatus
        '
        Me.cboPaymentStatus.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboPaymentStatus.Font = New System.Drawing.Font("Segoe UI", 10.0!)
        Me.cboPaymentStatus.ForeColor = System.Drawing.Color.FromArgb(43, 43, 43)
        Me.cboPaymentStatus.FormattingEnabled = True
        Me.cboPaymentStatus.Items.AddRange(New Object() {"Unpaid", "Paid"})
        Me.cboPaymentStatus.Location = New System.Drawing.Point(25, 354)
        Me.cboPaymentStatus.Name = "cboPaymentStatus"
        Me.cboPaymentStatus.Size = New System.Drawing.Size(210, 25)
        Me.cboPaymentStatus.TabIndex = 10
        '
        'lblPaymentStatus
        '
        Me.lblPaymentStatus.AutoSize = True
        Me.lblPaymentStatus.Font = New System.Drawing.Font("Segoe UI", 8.5!, System.Drawing.FontStyle.Bold)
        Me.lblPaymentStatus.ForeColor = System.Drawing.Color.FromArgb(90, 90, 90)
        Me.lblPaymentStatus.Location = New System.Drawing.Point(25, 330)
        Me.lblPaymentStatus.Name = "lblPaymentStatus"
        Me.lblPaymentStatus.Size = New System.Drawing.Size(105, 15)
        Me.lblPaymentStatus.TabIndex = 9
        Me.lblPaymentStatus.Text = "PAYMENT STATUS"
        '
        'btnAddDocument
        '
        Me.btnAddDocument.BackColor = System.Drawing.Color.Transparent
        Me.btnAddDocument.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnAddDocument.FlatAppearance.BorderSize = 0
        Me.btnAddDocument.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnAddDocument.Font = New System.Drawing.Font("Segoe UI", 9.5!, System.Drawing.FontStyle.Bold)
        Me.btnAddDocument.ForeColor = System.Drawing.Color.FromArgb(15, 31, 76)
        Me.btnAddDocument.Location = New System.Drawing.Point(20, 275)
        Me.btnAddDocument.Name = "btnAddDocument"
        Me.btnAddDocument.Size = New System.Drawing.Size(145, 30)
        Me.btnAddDocument.TabIndex = 8
        Me.btnAddDocument.Text = "+ Add document"
        Me.btnAddDocument.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnAddDocument.UseVisualStyleBackColor = False
        '
        'dgvDocuments
        '
        Me.dgvDocuments.AllowUserToAddRows = False
        Me.dgvDocuments.AllowUserToDeleteRows = False
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
        Me.dgvDocuments.ColumnHeadersHeight = 36
        Me.dgvDocuments.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing
        Me.dgvDocuments.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.colDocument, Me.colFee, Me.colQty, Me.colSubtotal})
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle2.BackColor = System.Drawing.Color.White
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Segoe UI", 9.5!)
        DataGridViewCellStyle2.ForeColor = System.Drawing.Color.FromArgb(43, 43, 43)
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(242, 245, 252)
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.FromArgb(15, 31, 76)
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.dgvDocuments.DefaultCellStyle = DataGridViewCellStyle2
        Me.dgvDocuments.EnableHeadersVisualStyles = False
        Me.dgvDocuments.GridColor = System.Drawing.Color.FromArgb(235, 235, 235)
        Me.dgvDocuments.Location = New System.Drawing.Point(25, 145)
        Me.dgvDocuments.Name = "dgvDocuments"
        Me.dgvDocuments.RowHeadersVisible = False
        Me.dgvDocuments.RowTemplate.Height = 38
        Me.dgvDocuments.ScrollBars = System.Windows.Forms.ScrollBars.None
        Me.dgvDocuments.Size = New System.Drawing.Size(740, 125)
        Me.dgvDocuments.TabIndex = 7
        '
        'colDocument
        '
        Me.colDocument.HeaderText = "DOCUMENT"
        Me.colDocument.Name = "colDocument"
        Me.colDocument.ReadOnly = True
        Me.colDocument.Width = 330
        '
        'colFee
        '
        DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
        Me.colFee.DefaultCellStyle = DataGridViewCellStyle3
        Me.colFee.HeaderText = "FEE"
        Me.colFee.Name = "colFee"
        Me.colFee.ReadOnly = True
        Me.colFee.Width = 130
        '
        'colQty
        '
        DataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        Me.colQty.DefaultCellStyle = DataGridViewCellStyle4
        Me.colQty.HeaderText = "QTY"
        Me.colQty.Name = "colQty"
        Me.colQty.Width = 120
        '
        'colSubtotal
        '
        Me.colSubtotal.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.colSubtotal.HeaderText = "SUBTOTAL"
        Me.colSubtotal.Name = "colSubtotal"
        Me.colSubtotal.ReadOnly = True
        '
        'txtCourse
        '
        Me.txtCourse.BackColor = System.Drawing.Color.FromArgb(245, 246, 248)
        Me.txtCourse.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtCourse.Font = New System.Drawing.Font("Segoe UI", 10.0!)
        Me.txtCourse.ForeColor = System.Drawing.Color.FromArgb(43, 43, 43)
        Me.txtCourse.Location = New System.Drawing.Point(580, 92)
        Me.txtCourse.Name = "txtCourse"
        Me.txtCourse.ReadOnly = True
        Me.txtCourse.Size = New System.Drawing.Size(185, 25)
        Me.txtCourse.TabIndex = 6
        '
        'lblCourse
        '
        Me.lblCourse.AutoSize = True
        Me.lblCourse.Font = New System.Drawing.Font("Segoe UI", 8.5!, System.Drawing.FontStyle.Bold)
        Me.lblCourse.ForeColor = System.Drawing.Color.FromArgb(90, 90, 90)
        Me.lblCourse.Location = New System.Drawing.Point(580, 70)
        Me.lblCourse.Name = "lblCourse"
        Me.lblCourse.Size = New System.Drawing.Size(53, 15)
        Me.lblCourse.TabIndex = 5
        Me.lblCourse.Text = "COURSE"
        '
        'txtStudentName
        '
        Me.txtStudentName.BackColor = System.Drawing.Color.FromArgb(245, 246, 248)
        Me.txtStudentName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtStudentName.Font = New System.Drawing.Font("Segoe UI", 10.0!)
        Me.txtStudentName.ForeColor = System.Drawing.Color.FromArgb(43, 43, 43)
        Me.txtStudentName.Location = New System.Drawing.Point(220, 92)
        Me.txtStudentName.Name = "txtStudentName"
        Me.txtStudentName.ReadOnly = True
        Me.txtStudentName.Size = New System.Drawing.Size(340, 25)
        Me.txtStudentName.TabIndex = 4
        '
        'lblStudentName
        '
        Me.lblStudentName.AutoSize = True
        Me.lblStudentName.Font = New System.Drawing.Font("Segoe UI", 8.5!, System.Drawing.FontStyle.Bold)
        Me.lblStudentName.ForeColor = System.Drawing.Color.FromArgb(90, 90, 90)
        Me.lblStudentName.Location = New System.Drawing.Point(220, 70)
        Me.lblStudentName.Name = "lblStudentName"
        Me.lblStudentName.Size = New System.Drawing.Size(95, 15)
        Me.lblStudentName.TabIndex = 3
        Me.lblStudentName.Text = "STUDENT NAME"
        '
        'txtStudentID
        '
        Me.txtStudentID.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtStudentID.Font = New System.Drawing.Font("Segoe UI", 10.0!)
        Me.txtStudentID.ForeColor = System.Drawing.Color.FromArgb(43, 43, 43)
        Me.txtStudentID.Location = New System.Drawing.Point(25, 92)
        Me.txtStudentID.Name = "txtStudentID"
        Me.txtStudentID.Size = New System.Drawing.Size(175, 25)
        Me.txtStudentID.TabIndex = 2
        '
        'lblStudentID
        '
        Me.lblStudentID.AutoSize = True
        Me.lblStudentID.Font = New System.Drawing.Font("Segoe UI", 8.5!, System.Drawing.FontStyle.Bold)
        Me.lblStudentID.ForeColor = System.Drawing.Color.FromArgb(90, 90, 90)
        Me.lblStudentID.Location = New System.Drawing.Point(25, 70)
        Me.lblStudentID.Name = "lblStudentID"
        Me.lblStudentID.Size = New System.Drawing.Size(76, 15)
        Me.lblStudentID.TabIndex = 1
        Me.lblStudentID.Text = "STUDENT ID"
        '
        'pnlHeader
        '
        Me.pnlHeader.BackColor = System.Drawing.Color.FromArgb(15, 31, 76)
        Me.pnlHeader.Controls.Add(Me.lblRequestNo)
        Me.pnlHeader.Controls.Add(Me.lblFormTitle)
        Me.pnlHeader.Dock = System.Windows.Forms.DockStyle.Top
        Me.pnlHeader.Location = New System.Drawing.Point(0, 0)
        Me.pnlHeader.Name = "pnlHeader"
        Me.pnlHeader.Size = New System.Drawing.Size(790, 48)
        Me.pnlHeader.TabIndex = 0
        '
        'lblRequestNo
        '
        Me.lblRequestNo.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lblRequestNo.Font = New System.Drawing.Font("Segoe UI", 11.0!, System.Drawing.FontStyle.Bold)
        Me.lblRequestNo.ForeColor = System.Drawing.Color.FromArgb(245, 197, 24)
        Me.lblRequestNo.Location = New System.Drawing.Point(590, 14)
        Me.lblRequestNo.Name = "lblRequestNo"
        Me.lblRequestNo.Size = New System.Drawing.Size(180, 20)
        Me.lblRequestNo.TabIndex = 1
        Me.lblRequestNo.Text = "REQ-2026-00129"
        Me.lblRequestNo.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'lblFormTitle
        '
        Me.lblFormTitle.AutoSize = True
        Me.lblFormTitle.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold)
        Me.lblFormTitle.ForeColor = System.Drawing.Color.White
        Me.lblFormTitle.Location = New System.Drawing.Point(20, 13)
        Me.lblFormTitle.Name = "lblFormTitle"
        Me.lblFormTitle.Size = New System.Drawing.Size(200, 21)
        Me.lblFormTitle.TabIndex = 0
        Me.lblFormTitle.Text = "New Document Request"
        '
        'frmDocumentRequest
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(245, 246, 248)
        Me.ClientSize = New System.Drawing.Size(860, 570)
        Me.Controls.Add(Me.pnlMainCard)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.MaximizeBox = False
        Me.Name = "frmDocumentRequest"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "New Document Request"
        Me.pnlMainCard.ResumeLayout(False)
        Me.pnlMainCard.PerformLayout()
        CType(Me.dgvDocuments, System.ComponentModel.ISupportInitialize).EndInit()
        Me.pnlHeader.ResumeLayout(False)
        Me.pnlHeader.PerformLayout()
        Me.ResumeLayout(False)

        ' Preview rows for DataGridView (Design properties representation)
        Me.dgvDocuments.Rows.Add("Transcript of Records", "150.00", "1", "150.00")
        Me.dgvDocuments.Rows.Add("Certificate of Good Moral", "100.00", "2", "200.00")
        Me.cboPaymentStatus.SelectedIndex = 0
        Me.cboRequestStatus.SelectedIndex = 0
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
