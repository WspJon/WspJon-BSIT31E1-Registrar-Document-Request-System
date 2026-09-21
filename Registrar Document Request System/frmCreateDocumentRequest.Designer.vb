<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmCreateDocumentRequest
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
        Me.pnlDialogContainer = New System.Windows.Forms.Panel()
        Me.lblTitle = New System.Windows.Forms.Label()
        Me.lblSubtitle = New System.Windows.Forms.Label()
        Me.btnClose = New System.Windows.Forms.Button()
        Me.pnlHeaderSeparator = New System.Windows.Forms.Panel()
        Me.lblStudentHeader = New System.Windows.Forms.Label()
        Me.pnlStudentSearch = New System.Windows.Forms.Panel()
        Me.txtStudentSearch = New System.Windows.Forms.TextBox()
        Me.lblSearchIcon = New System.Windows.Forms.Label()
        Me.txtCourseYear = New System.Windows.Forms.TextBox()
        Me.lblDocumentsHeader = New System.Windows.Forms.Label()
        Me.lblColDocType = New System.Windows.Forms.Label()
        Me.lblColCopies = New System.Windows.Forms.Label()
        Me.lblColPurpose = New System.Windows.Forms.Label()
        Me.lblColAmount = New System.Windows.Forms.Label()
        Me.cboDocType1 = New System.Windows.Forms.ComboBox()
        Me.txtCopies1 = New System.Windows.Forms.TextBox()
        Me.txtPurpose1 = New System.Windows.Forms.TextBox()
        Me.lblAmount1 = New System.Windows.Forms.Label()
        Me.btnDelete1 = New System.Windows.Forms.Button()
        Me.cboDocType2 = New System.Windows.Forms.ComboBox()
        Me.txtCopies2 = New System.Windows.Forms.TextBox()
        Me.txtPurpose2 = New System.Windows.Forms.TextBox()
        Me.lblAmount2 = New System.Windows.Forms.Label()
        Me.btnDelete2 = New System.Windows.Forms.Button()
        Me.btnAddRow = New System.Windows.Forms.Button()
        Me.lblReleaseHeader = New System.Windows.Forms.Label()
        Me.lblClaimDate = New System.Windows.Forms.Label()
        Me.dtpClaimDate = New System.Windows.Forms.DateTimePicker()
        Me.lblClaimMethod = New System.Windows.Forms.Label()
        Me.cboClaimMethod = New System.Windows.Forms.ComboBox()
        Me.lblPaymentHeader = New System.Windows.Forms.Label()
        Me.pnlPaymentCard = New System.Windows.Forms.Panel()
        Me.lblSubtotalTitle = New System.Windows.Forms.Label()
        Me.lblSubtotalValue = New System.Windows.Forms.Label()
        Me.lblFeeTitle = New System.Windows.Forms.Label()
        Me.lblFeeValue = New System.Windows.Forms.Label()
        Me.lblTotalDueTitle = New System.Windows.Forms.Label()
        Me.lblTotalDueValue = New System.Windows.Forms.Label()
        Me.pnlStatusToggle = New System.Windows.Forms.Panel()
        Me.btnStatusUnpaid = New System.Windows.Forms.Button()
        Me.btnStatusPaid = New System.Windows.Forms.Button()
        Me.lblReceiptNote = New System.Windows.Forms.Label()
        Me.btnCancel = New System.Windows.Forms.Button()
        Me.btnSaveRequest = New System.Windows.Forms.Button()
        Me.pnlDialogContainer.SuspendLayout()
        Me.pnlStudentSearch.SuspendLayout()
        Me.pnlPaymentCard.SuspendLayout()
        Me.pnlStatusToggle.SuspendLayout()
        Me.SuspendLayout()
        '
        'pnlDialogContainer
        '
        Me.pnlDialogContainer.BackColor = System.Drawing.Color.FromArgb(22, 32, 74)
        Me.pnlDialogContainer.Controls.Add(Me.btnSaveRequest)
        Me.pnlDialogContainer.Controls.Add(Me.btnCancel)
        Me.pnlDialogContainer.Controls.Add(Me.lblReceiptNote)
        Me.pnlDialogContainer.Controls.Add(Me.pnlPaymentCard)
        Me.pnlDialogContainer.Controls.Add(Me.lblPaymentHeader)
        Me.pnlDialogContainer.Controls.Add(Me.cboClaimMethod)
        Me.pnlDialogContainer.Controls.Add(Me.lblClaimMethod)
        Me.pnlDialogContainer.Controls.Add(Me.dtpClaimDate)
        Me.pnlDialogContainer.Controls.Add(Me.lblClaimDate)
        Me.pnlDialogContainer.Controls.Add(Me.lblReleaseHeader)
        Me.pnlDialogContainer.Controls.Add(Me.btnAddRow)
        Me.pnlDialogContainer.Controls.Add(Me.btnDelete2)
        Me.pnlDialogContainer.Controls.Add(Me.lblAmount2)
        Me.pnlDialogContainer.Controls.Add(Me.txtPurpose2)
        Me.pnlDialogContainer.Controls.Add(Me.txtCopies2)
        Me.pnlDialogContainer.Controls.Add(Me.cboDocType2)
        Me.pnlDialogContainer.Controls.Add(Me.btnDelete1)
        Me.pnlDialogContainer.Controls.Add(Me.lblAmount1)
        Me.pnlDialogContainer.Controls.Add(Me.txtPurpose1)
        Me.pnlDialogContainer.Controls.Add(Me.txtCopies1)
        Me.pnlDialogContainer.Controls.Add(Me.cboDocType1)
        Me.pnlDialogContainer.Controls.Add(Me.lblColAmount)
        Me.pnlDialogContainer.Controls.Add(Me.lblColPurpose)
        Me.pnlDialogContainer.Controls.Add(Me.lblColCopies)
        Me.pnlDialogContainer.Controls.Add(Me.lblColDocType)
        Me.pnlDialogContainer.Controls.Add(Me.lblDocumentsHeader)
        Me.pnlDialogContainer.Controls.Add(Me.txtCourseYear)
        Me.pnlDialogContainer.Controls.Add(Me.pnlStudentSearch)
        Me.pnlDialogContainer.Controls.Add(Me.lblStudentHeader)
        Me.pnlDialogContainer.Controls.Add(Me.pnlHeaderSeparator)
        Me.pnlDialogContainer.Controls.Add(Me.btnClose)
        Me.pnlDialogContainer.Controls.Add(Me.lblSubtitle)
        Me.pnlDialogContainer.Controls.Add(Me.lblTitle)
        Me.pnlDialogContainer.Dock = System.Windows.Forms.DockStyle.Fill
        Me.pnlDialogContainer.Location = New System.Drawing.Point(1, 1)
        Me.pnlDialogContainer.Name = "pnlDialogContainer"
        Me.pnlDialogContainer.Size = New System.Drawing.Size(678, 538)
        Me.pnlDialogContainer.TabIndex = 0
        '
        'lblTitle
        '
        Me.lblTitle.AutoSize = True
        Me.lblTitle.Font = New System.Drawing.Font("Segoe UI", 15.0!, System.Drawing.FontStyle.Bold)
        Me.lblTitle.ForeColor = System.Drawing.Color.White
        Me.lblTitle.Location = New System.Drawing.Point(24, 18)
        Me.lblTitle.Name = "lblTitle"
        Me.lblTitle.Size = New System.Drawing.Size(250, 28)
        Me.lblTitle.TabIndex = 0
        Me.lblTitle.Text = "Create document request"
        '
        'lblSubtitle
        '
        Me.lblSubtitle.AutoSize = True
        Me.lblSubtitle.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.lblSubtitle.ForeColor = System.Drawing.Color.FromArgb(131, 175, 214)
        Me.lblSubtitle.Location = New System.Drawing.Point(24, 46)
        Me.lblSubtitle.Name = "lblSubtitle"
        Me.lblSubtitle.Size = New System.Drawing.Size(176, 15)
        Me.lblSubtitle.TabIndex = 1
        Me.lblSubtitle.Text = "REQ-2026-00129 — Sep 21, 2026"
        '
        'btnClose
        '
        Me.btnClose.BackColor = System.Drawing.Color.Transparent
        Me.btnClose.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnClose.FlatAppearance.BorderSize = 0
        Me.btnClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnClose.Font = New System.Drawing.Font("Segoe UI", 11.0!, System.Drawing.FontStyle.Bold)
        Me.btnClose.ForeColor = System.Drawing.Color.FromArgb(131, 175, 214)
        Me.btnClose.Location = New System.Drawing.Point(636, 18)
        Me.btnClose.Name = "btnClose"
        Me.btnClose.Size = New System.Drawing.Size(24, 24)
        Me.btnClose.TabIndex = 2
        Me.btnClose.Text = "✕"
        Me.btnClose.UseVisualStyleBackColor = False
        '
        'pnlHeaderSeparator
        '
        Me.pnlHeaderSeparator.BackColor = System.Drawing.Color.FromArgb(61, 76, 135)
        Me.pnlHeaderSeparator.Location = New System.Drawing.Point(24, 70)
        Me.pnlHeaderSeparator.Name = "pnlHeaderSeparator"
        Me.pnlHeaderSeparator.Size = New System.Drawing.Size(630, 1)
        Me.pnlHeaderSeparator.TabIndex = 3
        '
        'lblStudentHeader
        '
        Me.lblStudentHeader.AutoSize = True
        Me.lblStudentHeader.Font = New System.Drawing.Font("Segoe UI", 8.5!, System.Drawing.FontStyle.Bold)
        Me.lblStudentHeader.ForeColor = System.Drawing.Color.FromArgb(247, 197, 36)
        Me.lblStudentHeader.Location = New System.Drawing.Point(24, 82)
        Me.lblStudentHeader.Name = "lblStudentHeader"
        Me.lblStudentHeader.Size = New System.Drawing.Size(57, 15)
        Me.lblStudentHeader.TabIndex = 4
        Me.lblStudentHeader.Text = "STUDENT"
        '
        'pnlStudentSearch
        '
        Me.pnlStudentSearch.BackColor = System.Drawing.Color.FromArgb(27, 39, 85)
        Me.pnlStudentSearch.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.pnlStudentSearch.Controls.Add(Me.lblSearchIcon)
        Me.pnlStudentSearch.Controls.Add(Me.txtStudentSearch)
        Me.pnlStudentSearch.Location = New System.Drawing.Point(24, 102)
        Me.pnlStudentSearch.Name = "pnlStudentSearch"
        Me.pnlStudentSearch.Size = New System.Drawing.Size(430, 30)
        Me.pnlStudentSearch.TabIndex = 5
        '
        'txtStudentSearch
        '
        Me.txtStudentSearch.BackColor = System.Drawing.Color.FromArgb(27, 39, 85)
        Me.txtStudentSearch.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtStudentSearch.Font = New System.Drawing.Font("Segoe UI", 9.5!)
        Me.txtStudentSearch.ForeColor = System.Drawing.Color.White
        Me.txtStudentSearch.Location = New System.Drawing.Point(8, 6)
        Me.txtStudentSearch.Name = "txtStudentSearch"
        Me.txtStudentSearch.Size = New System.Drawing.Size(390, 17)
        Me.txtStudentSearch.TabIndex = 0
        Me.txtStudentSearch.Text = "2021-00432 — Juan Dela Cruz"
        '
        'lblSearchIcon
        '
        Me.lblSearchIcon.Cursor = System.Windows.Forms.Cursors.Hand
        Me.lblSearchIcon.Font = New System.Drawing.Font("Segoe UI", 10.0!)
        Me.lblSearchIcon.ForeColor = System.Drawing.Color.FromArgb(131, 175, 214)
        Me.lblSearchIcon.Location = New System.Drawing.Point(402, 3)
        Me.lblSearchIcon.Name = "lblSearchIcon"
        Me.lblSearchIcon.Size = New System.Drawing.Size(22, 22)
        Me.lblSearchIcon.TabIndex = 1
        Me.lblSearchIcon.Text = "🔍"
        Me.lblSearchIcon.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'txtCourseYear
        '
        Me.txtCourseYear.BackColor = System.Drawing.Color.FromArgb(27, 39, 85)
        Me.txtCourseYear.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtCourseYear.Font = New System.Drawing.Font("Segoe UI", 9.5!)
        Me.txtCourseYear.ForeColor = System.Drawing.Color.White
        Me.txtCourseYear.Location = New System.Drawing.Point(468, 102)
        Me.txtCourseYear.Name = "txtCourseYear"
        Me.txtCourseYear.ReadOnly = True
        Me.txtCourseYear.Size = New System.Drawing.Size(186, 24)
        Me.txtCourseYear.TabIndex = 6
        Me.txtCourseYear.Text = "BSIT — 4th year"
        '
        'lblDocumentsHeader
        '
        Me.lblDocumentsHeader.AutoSize = True
        Me.lblDocumentsHeader.Font = New System.Drawing.Font("Segoe UI", 8.5!, System.Drawing.FontStyle.Bold)
        Me.lblDocumentsHeader.ForeColor = System.Drawing.Color.FromArgb(247, 197, 36)
        Me.lblDocumentsHeader.Location = New System.Drawing.Point(24, 144)
        Me.lblDocumentsHeader.Name = "lblDocumentsHeader"
        Me.lblDocumentsHeader.Size = New System.Drawing.Size(76, 15)
        Me.lblDocumentsHeader.TabIndex = 7
        Me.lblDocumentsHeader.Text = "DOCUMENTS"
        '
        'lblColDocType
        '
        Me.lblColDocType.AutoSize = True
        Me.lblColDocType.Font = New System.Drawing.Font("Segoe UI", 8.0!, System.Drawing.FontStyle.Bold)
        Me.lblColDocType.ForeColor = System.Drawing.Color.FromArgb(131, 175, 214)
        Me.lblColDocType.Location = New System.Drawing.Point(24, 166)
        Me.lblColDocType.Name = "lblColDocType"
        Me.lblColDocType.Size = New System.Drawing.Size(95, 13)
        Me.lblColDocType.TabIndex = 8
        Me.lblColDocType.Text = "DOCUMENT TYPE"
        '
        'lblColCopies
        '
        Me.lblColCopies.AutoSize = True
        Me.lblColCopies.Font = New System.Drawing.Font("Segoe UI", 8.0!, System.Drawing.FontStyle.Bold)
        Me.lblColCopies.ForeColor = System.Drawing.Color.FromArgb(131, 175, 214)
        Me.lblColCopies.Location = New System.Drawing.Point(246, 166)
        Me.lblColCopies.Name = "lblColCopies"
        Me.lblColCopies.Size = New System.Drawing.Size(43, 13)
        Me.lblColCopies.TabIndex = 9
        Me.lblColCopies.Text = "COPIES"
        '
        'lblColPurpose
        '
        Me.lblColPurpose.AutoSize = True
        Me.lblColPurpose.Font = New System.Drawing.Font("Segoe UI", 8.0!, System.Drawing.FontStyle.Bold)
        Me.lblColPurpose.ForeColor = System.Drawing.Color.FromArgb(131, 175, 214)
        Me.lblColPurpose.Location = New System.Drawing.Point(314, 166)
        Me.lblColPurpose.Name = "lblColPurpose"
        Me.lblColPurpose.Size = New System.Drawing.Size(56, 13)
        Me.lblColPurpose.TabIndex = 10
        Me.lblColPurpose.Text = "PURPOSE"
        '
        'lblColAmount
        '
        Me.lblColAmount.Font = New System.Drawing.Font("Segoe UI", 8.0!, System.Drawing.FontStyle.Bold)
        Me.lblColAmount.ForeColor = System.Drawing.Color.FromArgb(131, 175, 214)
        Me.lblColAmount.Location = New System.Drawing.Point(484, 166)
        Me.lblColAmount.Name = "lblColAmount"
        Me.lblColAmount.Size = New System.Drawing.Size(90, 13)
        Me.lblColAmount.TabIndex = 11
        Me.lblColAmount.Text = "AMOUNT"
        Me.lblColAmount.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'cboDocType1
        '
        Me.cboDocType1.BackColor = System.Drawing.Color.FromArgb(27, 39, 85)
        Me.cboDocType1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboDocType1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cboDocType1.Font = New System.Drawing.Font("Segoe UI", 9.5!)
        Me.cboDocType1.ForeColor = System.Drawing.Color.White
        Me.cboDocType1.FormattingEnabled = True
        Me.cboDocType1.Items.AddRange(New Object() {"Transcript of records", "Cert. of enrollment", "Certificate of Good Moral", "Honorable Dismissal", "Diploma copy"})
        Me.cboDocType1.Location = New System.Drawing.Point(24, 184)
        Me.cboDocType1.Name = "cboDocType1"
        Me.cboDocType1.Size = New System.Drawing.Size(214, 25)
        Me.cboDocType1.TabIndex = 12
        Me.cboDocType1.SelectedIndex = 0
        '
        'txtCopies1
        '
        Me.txtCopies1.BackColor = System.Drawing.Color.FromArgb(27, 39, 85)
        Me.txtCopies1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtCopies1.Font = New System.Drawing.Font("Segoe UI", 9.5!)
        Me.txtCopies1.ForeColor = System.Drawing.Color.White
        Me.txtCopies1.Location = New System.Drawing.Point(246, 184)
        Me.txtCopies1.Name = "txtCopies1"
        Me.txtCopies1.Size = New System.Drawing.Size(60, 24)
        Me.txtCopies1.TabIndex = 13
        Me.txtCopies1.Text = "2"
        Me.txtCopies1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'txtPurpose1
        '
        Me.txtPurpose1.BackColor = System.Drawing.Color.FromArgb(27, 39, 85)
        Me.txtPurpose1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtPurpose1.Font = New System.Drawing.Font("Segoe UI", 9.5!)
        Me.txtPurpose1.ForeColor = System.Drawing.Color.White
        Me.txtPurpose1.Location = New System.Drawing.Point(314, 184)
        Me.txtPurpose1.Name = "txtPurpose1"
        Me.txtPurpose1.Size = New System.Drawing.Size(160, 24)
        Me.txtPurpose1.TabIndex = 14
        Me.txtPurpose1.Text = "Employment"
        '
        'lblAmount1
        '
        Me.lblAmount1.Font = New System.Drawing.Font("Segoe UI", 9.5!, System.Drawing.FontStyle.Bold)
        Me.lblAmount1.ForeColor = System.Drawing.Color.White
        Me.lblAmount1.Location = New System.Drawing.Point(484, 186)
        Me.lblAmount1.Name = "lblAmount1"
        Me.lblAmount1.Size = New System.Drawing.Size(90, 22)
        Me.lblAmount1.TabIndex = 15
        Me.lblAmount1.Text = "300.00"
        Me.lblAmount1.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'btnDelete1
        '
        Me.btnDelete1.BackColor = System.Drawing.Color.Transparent
        Me.btnDelete1.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnDelete1.FlatAppearance.BorderSize = 0
        Me.btnDelete1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnDelete1.Font = New System.Drawing.Font("Segoe UI", 11.0!)
        Me.btnDelete1.ForeColor = System.Drawing.Color.FromArgb(220, 53, 69)
        Me.btnDelete1.Location = New System.Drawing.Point(624, 182)
        Me.btnDelete1.Name = "btnDelete1"
        Me.btnDelete1.Size = New System.Drawing.Size(30, 28)
        Me.btnDelete1.TabIndex = 16
        Me.btnDelete1.Text = "🗑"
        Me.btnDelete1.UseVisualStyleBackColor = False
        '
        'cboDocType2
        '
        Me.cboDocType2.BackColor = System.Drawing.Color.FromArgb(27, 39, 85)
        Me.cboDocType2.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboDocType2.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cboDocType2.Font = New System.Drawing.Font("Segoe UI", 9.5!)
        Me.cboDocType2.ForeColor = System.Drawing.Color.White
        Me.cboDocType2.FormattingEnabled = True
        Me.cboDocType2.Items.AddRange(New Object() {"Transcript of records", "Cert. of enrollment", "Certificate of Good Moral", "Honorable Dismissal", "Diploma copy"})
        Me.cboDocType2.Location = New System.Drawing.Point(24, 220)
        Me.cboDocType2.Name = "cboDocType2"
        Me.cboDocType2.Size = New System.Drawing.Size(214, 25)
        Me.cboDocType2.TabIndex = 17
        Me.cboDocType2.SelectedIndex = 1
        '
        'txtCopies2
        '
        Me.txtCopies2.BackColor = System.Drawing.Color.FromArgb(27, 39, 85)
        Me.txtCopies2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtCopies2.Font = New System.Drawing.Font("Segoe UI", 9.5!)
        Me.txtCopies2.ForeColor = System.Drawing.Color.White
        Me.txtCopies2.Location = New System.Drawing.Point(246, 220)
        Me.txtCopies2.Name = "txtCopies2"
        Me.txtCopies2.Size = New System.Drawing.Size(60, 24)
        Me.txtCopies2.TabIndex = 18
        Me.txtCopies2.Text = "1"
        Me.txtCopies2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'txtPurpose2
        '
        Me.txtPurpose2.BackColor = System.Drawing.Color.FromArgb(27, 39, 85)
        Me.txtPurpose2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtPurpose2.Font = New System.Drawing.Font("Segoe UI", 9.5!)
        Me.txtPurpose2.ForeColor = System.Drawing.Color.White
        Me.txtPurpose2.Location = New System.Drawing.Point(314, 220)
        Me.txtPurpose2.Name = "txtPurpose2"
        Me.txtPurpose2.Size = New System.Drawing.Size(160, 24)
        Me.txtPurpose2.TabIndex = 19
        Me.txtPurpose2.Text = "Scholarship"
        '
        'lblAmount2
        '
        Me.lblAmount2.Font = New System.Drawing.Font("Segoe UI", 9.5!, System.Drawing.FontStyle.Bold)
        Me.lblAmount2.ForeColor = System.Drawing.Color.White
        Me.lblAmount2.Location = New System.Drawing.Point(484, 222)
        Me.lblAmount2.Name = "lblAmount2"
        Me.lblAmount2.Size = New System.Drawing.Size(90, 22)
        Me.lblAmount2.TabIndex = 20
        Me.lblAmount2.Text = "50.00"
        Me.lblAmount2.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'btnDelete2
        '
        Me.btnDelete2.BackColor = System.Drawing.Color.Transparent
        Me.btnDelete2.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnDelete2.FlatAppearance.BorderSize = 0
        Me.btnDelete2.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnDelete2.Font = New System.Drawing.Font("Segoe UI", 11.0!)
        Me.btnDelete2.ForeColor = System.Drawing.Color.FromArgb(220, 53, 69)
        Me.btnDelete2.Location = New System.Drawing.Point(624, 218)
        Me.btnDelete2.Name = "btnDelete2"
        Me.btnDelete2.Size = New System.Drawing.Size(30, 28)
        Me.btnDelete2.TabIndex = 21
        Me.btnDelete2.Text = "🗑"
        Me.btnDelete2.UseVisualStyleBackColor = False
        '
        'btnAddRow
        '
        Me.btnAddRow.BackColor = System.Drawing.Color.FromArgb(22, 32, 74)
        Me.btnAddRow.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnAddRow.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(61, 76, 135)
        Me.btnAddRow.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnAddRow.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold)
        Me.btnAddRow.ForeColor = System.Drawing.Color.FromArgb(247, 197, 36)
        Me.btnAddRow.Location = New System.Drawing.Point(24, 258)
        Me.btnAddRow.Name = "btnAddRow"
        Me.btnAddRow.Size = New System.Drawing.Size(630, 32)
        Me.btnAddRow.TabIndex = 22
        Me.btnAddRow.Text = "+ Add row"
        Me.btnAddRow.UseVisualStyleBackColor = False
        '
        'lblReleaseHeader
        '
        Me.lblReleaseHeader.AutoSize = True
        Me.lblReleaseHeader.Font = New System.Drawing.Font("Segoe UI", 8.5!, System.Drawing.FontStyle.Bold)
        Me.lblReleaseHeader.ForeColor = System.Drawing.Color.FromArgb(247, 197, 36)
        Me.lblReleaseHeader.Location = New System.Drawing.Point(24, 306)
        Me.lblReleaseHeader.Name = "lblReleaseHeader"
        Me.lblReleaseHeader.Size = New System.Drawing.Size(53, 15)
        Me.lblReleaseHeader.TabIndex = 23
        Me.lblReleaseHeader.Text = "RELEASE"
        '
        'lblClaimDate
        '
        Me.lblClaimDate.AutoSize = True
        Me.lblClaimDate.Font = New System.Drawing.Font("Segoe UI", 8.5!)
        Me.lblClaimDate.ForeColor = System.Drawing.Color.FromArgb(131, 175, 214)
        Me.lblClaimDate.Location = New System.Drawing.Point(24, 330)
        Me.lblClaimDate.Name = "lblClaimDate"
        Me.lblClaimDate.Size = New System.Drawing.Size(63, 15)
        Me.lblClaimDate.TabIndex = 24
        Me.lblClaimDate.Text = "Claim date"
        '
        'dtpClaimDate
        '
        Me.dtpClaimDate.CalendarForeColor = System.Drawing.Color.White
        Me.dtpClaimDate.CalendarMonthBackground = System.Drawing.Color.FromArgb(27, 39, 85)
        Me.dtpClaimDate.CalendarTitleBackColor = System.Drawing.Color.FromArgb(22, 32, 74)
        Me.dtpClaimDate.CalendarTitleForeColor = System.Drawing.Color.White
        Me.dtpClaimDate.CustomFormat = "MMM dd, yyyy"
        Me.dtpClaimDate.Font = New System.Drawing.Font("Segoe UI", 9.5!)
        Me.dtpClaimDate.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.dtpClaimDate.Location = New System.Drawing.Point(24, 350)
        Me.dtpClaimDate.Name = "dtpClaimDate"
        Me.dtpClaimDate.Size = New System.Drawing.Size(280, 24)
        Me.dtpClaimDate.TabIndex = 25
        Me.dtpClaimDate.Value = New System.DateTime(2026, 9, 28, 0, 0, 0, 0)
        '
        'lblClaimMethod
        '
        Me.lblClaimMethod.AutoSize = True
        Me.lblClaimMethod.Font = New System.Drawing.Font("Segoe UI", 8.5!)
        Me.lblClaimMethod.ForeColor = System.Drawing.Color.FromArgb(131, 175, 214)
        Me.lblClaimMethod.Location = New System.Drawing.Point(24, 390)
        Me.lblClaimMethod.Name = "lblClaimMethod"
        Me.lblClaimMethod.Size = New System.Drawing.Size(81, 15)
        Me.lblClaimMethod.TabIndex = 26
        Me.lblClaimMethod.Text = "Claim method"
        '
        'cboClaimMethod
        '
        Me.cboClaimMethod.BackColor = System.Drawing.Color.FromArgb(27, 39, 85)
        Me.cboClaimMethod.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboClaimMethod.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cboClaimMethod.Font = New System.Drawing.Font("Segoe UI", 9.5!)
        Me.cboClaimMethod.ForeColor = System.Drawing.Color.White
        Me.cboClaimMethod.FormattingEnabled = True
        Me.cboClaimMethod.Items.AddRange(New Object() {"Walk In", "Courier Delivery", "Authorized Representative"})
        Me.cboClaimMethod.Location = New System.Drawing.Point(24, 410)
        Me.cboClaimMethod.Name = "cboClaimMethod"
        Me.cboClaimMethod.Size = New System.Drawing.Size(280, 25)
        Me.cboClaimMethod.TabIndex = 27
        Me.cboClaimMethod.SelectedIndex = 0
        '
        'lblPaymentHeader
        '
        Me.lblPaymentHeader.AutoSize = True
        Me.lblPaymentHeader.Font = New System.Drawing.Font("Segoe UI", 8.5!, System.Drawing.FontStyle.Bold)
        Me.lblPaymentHeader.ForeColor = System.Drawing.Color.FromArgb(247, 197, 36)
        Me.lblPaymentHeader.Location = New System.Drawing.Point(324, 306)
        Me.lblPaymentHeader.Name = "lblPaymentHeader"
        Me.lblPaymentHeader.Size = New System.Drawing.Size(59, 15)
        Me.lblPaymentHeader.TabIndex = 28
        Me.lblPaymentHeader.Text = "PAYMENT"
        '
        'pnlPaymentCard
        '
        Me.pnlPaymentCard.BackColor = System.Drawing.Color.FromArgb(27, 39, 85)
        Me.pnlPaymentCard.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.pnlPaymentCard.Controls.Add(Me.pnlStatusToggle)
        Me.pnlPaymentCard.Controls.Add(Me.lblTotalDueValue)
        Me.pnlPaymentCard.Controls.Add(Me.lblTotalDueTitle)
        Me.pnlPaymentCard.Controls.Add(Me.lblFeeValue)
        Me.pnlPaymentCard.Controls.Add(Me.lblFeeTitle)
        Me.pnlPaymentCard.Controls.Add(Me.lblSubtotalValue)
        Me.pnlPaymentCard.Controls.Add(Me.lblSubtotalTitle)
        Me.pnlPaymentCard.Location = New System.Drawing.Point(324, 330)
        Me.pnlPaymentCard.Name = "pnlPaymentCard"
        Me.pnlPaymentCard.Size = New System.Drawing.Size(330, 110)
        Me.pnlPaymentCard.TabIndex = 29
        '
        'lblSubtotalTitle
        '
        Me.lblSubtotalTitle.AutoSize = True
        Me.lblSubtotalTitle.Font = New System.Drawing.Font("Segoe UI", 8.5!)
        Me.lblSubtotalTitle.ForeColor = System.Drawing.Color.FromArgb(131, 175, 214)
        Me.lblSubtotalTitle.Location = New System.Drawing.Point(14, 10)
        Me.lblSubtotalTitle.Name = "lblSubtotalTitle"
        Me.lblSubtotalTitle.Size = New System.Drawing.Size(51, 15)
        Me.lblSubtotalTitle.TabIndex = 0
        Me.lblSubtotalTitle.Text = "Subtotal"
        '
        'lblSubtotalValue
        '
        Me.lblSubtotalValue.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.lblSubtotalValue.ForeColor = System.Drawing.Color.White
        Me.lblSubtotalValue.Location = New System.Drawing.Point(190, 10)
        Me.lblSubtotalValue.Name = "lblSubtotalValue"
        Me.lblSubtotalValue.Size = New System.Drawing.Size(124, 16)
        Me.lblSubtotalValue.TabIndex = 1
        Me.lblSubtotalValue.Text = "PHP 350.00"
        Me.lblSubtotalValue.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'lblFeeTitle
        '
        Me.lblFeeTitle.AutoSize = True
        Me.lblFeeTitle.Font = New System.Drawing.Font("Segoe UI", 8.5!)
        Me.lblFeeTitle.ForeColor = System.Drawing.Color.FromArgb(131, 175, 214)
        Me.lblFeeTitle.Location = New System.Drawing.Point(14, 28)
        Me.lblFeeTitle.Name = "lblFeeTitle"
        Me.lblFeeTitle.Size = New System.Drawing.Size(84, 15)
        Me.lblFeeTitle.TabIndex = 2
        Me.lblFeeTitle.Text = "Processing fee"
        '
        'lblFeeValue
        '
        Me.lblFeeValue.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.lblFeeValue.ForeColor = System.Drawing.Color.White
        Me.lblFeeValue.Location = New System.Drawing.Point(190, 28)
        Me.lblFeeValue.Name = "lblFeeValue"
        Me.lblFeeValue.Size = New System.Drawing.Size(124, 16)
        Me.lblFeeValue.TabIndex = 3
        Me.lblFeeValue.Text = "PHP 20.00"
        Me.lblFeeValue.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'lblTotalDueTitle
        '
        Me.lblTotalDueTitle.AutoSize = True
        Me.lblTotalDueTitle.Font = New System.Drawing.Font("Segoe UI", 9.5!, System.Drawing.FontStyle.Bold)
        Me.lblTotalDueTitle.ForeColor = System.Drawing.Color.FromArgb(247, 197, 36)
        Me.lblTotalDueTitle.Location = New System.Drawing.Point(14, 48)
        Me.lblTotalDueTitle.Name = "lblTotalDueTitle"
        Me.lblTotalDueTitle.Size = New System.Drawing.Size(63, 17)
        Me.lblTotalDueTitle.TabIndex = 4
        Me.lblTotalDueTitle.Text = "Total due"
        '
        'lblTotalDueValue
        '
        Me.lblTotalDueValue.Font = New System.Drawing.Font("Segoe UI", 10.5!, System.Drawing.FontStyle.Bold)
        Me.lblTotalDueValue.ForeColor = System.Drawing.Color.FromArgb(247, 197, 36)
        Me.lblTotalDueValue.Location = New System.Drawing.Point(170, 46)
        Me.lblTotalDueValue.Name = "lblTotalDueValue"
        Me.lblTotalDueValue.Size = New System.Drawing.Size(144, 20)
        Me.lblTotalDueValue.TabIndex = 5
        Me.lblTotalDueValue.Text = "PHP 370.00"
        Me.lblTotalDueValue.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'pnlStatusToggle
        '
        Me.pnlStatusToggle.BackColor = System.Drawing.Color.FromArgb(38, 53, 107)
        Me.pnlStatusToggle.Controls.Add(Me.btnStatusPaid)
        Me.pnlStatusToggle.Controls.Add(Me.btnStatusUnpaid)
        Me.pnlStatusToggle.Location = New System.Drawing.Point(12, 72)
        Me.pnlStatusToggle.Name = "pnlStatusToggle"
        Me.pnlStatusToggle.Size = New System.Drawing.Size(304, 26)
        Me.pnlStatusToggle.TabIndex = 6
        '
        'btnStatusUnpaid
        '
        Me.btnStatusUnpaid.BackColor = System.Drawing.Color.FromArgb(74, 58, 18)
        Me.btnStatusUnpaid.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnStatusUnpaid.FlatAppearance.BorderSize = 0
        Me.btnStatusUnpaid.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnStatusUnpaid.Font = New System.Drawing.Font("Segoe UI", 8.5!, System.Drawing.FontStyle.Bold)
        Me.btnStatusUnpaid.ForeColor = System.Drawing.Color.FromArgb(247, 197, 36)
        Me.btnStatusUnpaid.Location = New System.Drawing.Point(0, 0)
        Me.btnStatusUnpaid.Name = "btnStatusUnpaid"
        Me.btnStatusUnpaid.Size = New System.Drawing.Size(152, 26)
        Me.btnStatusUnpaid.TabIndex = 0
        Me.btnStatusUnpaid.Text = "Unpaid"
        Me.btnStatusUnpaid.UseVisualStyleBackColor = False
        '
        'btnStatusPaid
        '
        Me.btnStatusPaid.BackColor = System.Drawing.Color.FromArgb(38, 53, 107)
        Me.btnStatusPaid.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnStatusPaid.FlatAppearance.BorderSize = 0
        Me.btnStatusPaid.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnStatusPaid.Font = New System.Drawing.Font("Segoe UI", 8.5!)
        Me.btnStatusPaid.ForeColor = System.Drawing.Color.FromArgb(131, 175, 214)
        Me.btnStatusPaid.Location = New System.Drawing.Point(152, 0)
        Me.btnStatusPaid.Name = "btnStatusPaid"
        Me.btnStatusPaid.Size = New System.Drawing.Size(152, 26)
        Me.btnStatusPaid.TabIndex = 1
        Me.btnStatusPaid.Text = "Paid"
        Me.btnStatusPaid.UseVisualStyleBackColor = False
        '
        'lblReceiptNote
        '
        Me.lblReceiptNote.AutoSize = True
        Me.lblReceiptNote.Font = New System.Drawing.Font("Segoe UI", 8.5!)
        Me.lblReceiptNote.ForeColor = System.Drawing.Color.FromArgb(131, 175, 214)
        Me.lblReceiptNote.Location = New System.Drawing.Point(24, 480)
        Me.lblReceiptNote.Name = "lblReceiptNote"
        Me.lblReceiptNote.Size = New System.Drawing.Size(155, 15)
        Me.lblReceiptNote.TabIndex = 30
        Me.lblReceiptNote.Text = "Receipt printed after saving"
        '
        'btnCancel
        '
        Me.btnCancel.BackColor = System.Drawing.Color.FromArgb(22, 32, 74)
        Me.btnCancel.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnCancel.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(108, 122, 174)
        Me.btnCancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnCancel.Font = New System.Drawing.Font("Segoe UI", 9.5!)
        Me.btnCancel.ForeColor = System.Drawing.Color.White
        Me.btnCancel.Location = New System.Drawing.Point(420, 470)
        Me.btnCancel.Name = "btnCancel"
        Me.btnCancel.Size = New System.Drawing.Size(96, 36)
        Me.btnCancel.TabIndex = 31
        Me.btnCancel.Text = "Cancel"
        Me.btnCancel.UseVisualStyleBackColor = False
        '
        'btnSaveRequest
        '
        Me.btnSaveRequest.BackColor = System.Drawing.Color.FromArgb(247, 197, 36)
        Me.btnSaveRequest.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnSaveRequest.FlatAppearance.BorderSize = 0
        Me.btnSaveRequest.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnSaveRequest.Font = New System.Drawing.Font("Segoe UI", 9.5!, System.Drawing.FontStyle.Bold)
        Me.btnSaveRequest.ForeColor = System.Drawing.Color.FromArgb(22, 32, 74)
        Me.btnSaveRequest.Location = New System.Drawing.Point(524, 470)
        Me.btnSaveRequest.Name = "btnSaveRequest"
        Me.btnSaveRequest.Size = New System.Drawing.Size(130, 36)
        Me.btnSaveRequest.TabIndex = 32
        Me.btnSaveRequest.Text = "Save request"
        Me.btnSaveRequest.UseVisualStyleBackColor = False
        '
        'frmCreateDocumentRequest
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(61, 76, 135)
        Me.ClientSize = New System.Drawing.Size(680, 540)
        Me.Controls.Add(Me.pnlDialogContainer)
        Me.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmCreateDocumentRequest"
        Me.Padding = New System.Windows.Forms.Padding(1)
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Create document request"
        Me.pnlDialogContainer.ResumeLayout(False)
        Me.pnlDialogContainer.PerformLayout()
        Me.pnlStudentSearch.ResumeLayout(False)
        Me.pnlStudentSearch.PerformLayout()
        Me.pnlPaymentCard.ResumeLayout(False)
        Me.pnlPaymentCard.PerformLayout()
        Me.pnlStatusToggle.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents pnlDialogContainer As System.Windows.Forms.Panel
    Friend WithEvents lblTitle As System.Windows.Forms.Label
    Friend WithEvents lblSubtitle As System.Windows.Forms.Label
    Friend WithEvents btnClose As System.Windows.Forms.Button
    Friend WithEvents pnlHeaderSeparator As System.Windows.Forms.Panel
    Friend WithEvents lblStudentHeader As System.Windows.Forms.Label
    Friend WithEvents pnlStudentSearch As System.Windows.Forms.Panel
    Friend WithEvents txtStudentSearch As System.Windows.Forms.TextBox
    Friend WithEvents lblSearchIcon As System.Windows.Forms.Label
    Friend WithEvents txtCourseYear As System.Windows.Forms.TextBox
    Friend WithEvents lblDocumentsHeader As System.Windows.Forms.Label
    Friend WithEvents lblColDocType As System.Windows.Forms.Label
    Friend WithEvents lblColCopies As System.Windows.Forms.Label
    Friend WithEvents lblColPurpose As System.Windows.Forms.Label
    Friend WithEvents lblColAmount As System.Windows.Forms.Label
    Friend WithEvents cboDocType1 As System.Windows.Forms.ComboBox
    Friend WithEvents txtCopies1 As System.Windows.Forms.TextBox
    Friend WithEvents txtPurpose1 As System.Windows.Forms.TextBox
    Friend WithEvents lblAmount1 As System.Windows.Forms.Label
    Friend WithEvents btnDelete1 As System.Windows.Forms.Button
    Friend WithEvents cboDocType2 As System.Windows.Forms.ComboBox
    Friend WithEvents txtCopies2 As System.Windows.Forms.TextBox
    Friend WithEvents txtPurpose2 As System.Windows.Forms.TextBox
    Friend WithEvents lblAmount2 As System.Windows.Forms.Label
    Friend WithEvents btnDelete2 As System.Windows.Forms.Button
    Friend WithEvents btnAddRow As System.Windows.Forms.Button
    Friend WithEvents lblReleaseHeader As System.Windows.Forms.Label
    Friend WithEvents lblClaimDate As System.Windows.Forms.Label
    Friend WithEvents dtpClaimDate As System.Windows.Forms.DateTimePicker
    Friend WithEvents lblClaimMethod As System.Windows.Forms.Label
    Friend WithEvents cboClaimMethod As System.Windows.Forms.ComboBox
    Friend WithEvents lblPaymentHeader As System.Windows.Forms.Label
    Friend WithEvents pnlPaymentCard As System.Windows.Forms.Panel
    Friend WithEvents lblSubtotalTitle As System.Windows.Forms.Label
    Friend WithEvents lblSubtotalValue As System.Windows.Forms.Label
    Friend WithEvents lblFeeTitle As System.Windows.Forms.Label
    Friend WithEvents lblFeeValue As System.Windows.Forms.Label
    Friend WithEvents lblTotalDueTitle As System.Windows.Forms.Label
    Friend WithEvents lblTotalDueValue As System.Windows.Forms.Label
    Friend WithEvents pnlStatusToggle As System.Windows.Forms.Panel
    Friend WithEvents btnStatusUnpaid As System.Windows.Forms.Button
    Friend WithEvents btnStatusPaid As System.Windows.Forms.Button
    Friend WithEvents lblReceiptNote As System.Windows.Forms.Label
    Friend WithEvents btnCancel As System.Windows.Forms.Button
    Friend WithEvents btnSaveRequest As System.Windows.Forms.Button
End Class

