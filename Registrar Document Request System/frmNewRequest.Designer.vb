<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmNewRequest
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmNewRequest))
        pnlSidebar = New Panel()
        pnlLogout = New Panel()
        btnLogout = New Button()
        btnReports = New Button()
        btnSearchStudent = New Button()
        btnRequestList = New Button()
        btnNewRequest = New Button()
        btnDashboard = New Button()
        pnlLogoArea = New Panel()
        pnlLogo = New Panel()
        picLogo = New PictureBox()
        lblLogo = New Label()
        pnlContent = New Panel()
        pnlActionButtons = New Panel()
        btnCancel = New Button()
        btnSubmitRequest = New Button()
        pnlDocDetails = New Panel()
        cboPaymentStatus = New ComboBox()
        lblPaymentStatus = New Label()
        pnlAmountDueBox = New Panel()
        txtAmountDue = New TextBox()
        lblAmountDue = New Label()
        dtpDateNeeded = New DateTimePicker()
        lblDateNeeded = New Label()
        cboPurpose = New ComboBox()
        lblPurpose = New Label()
        pnlCopiesBox = New Panel()
        txtCopies = New TextBox()
        lblCopies = New Label()
        cboDocumentType = New ComboBox()
        lblDocumentType = New Label()
        lblDocDetailsHeader = New Label()
        pnlStudentInfo = New Panel()
        pnlContactNumberBox = New Panel()
        txtContactNumber = New TextBox()
        lblContactNumber = New Label()
        cboYearLevel = New ComboBox()
        lblYearLevel = New Label()
        pnlCourseBox = New Panel()
        txtCourse = New TextBox()
        lblCourse = New Label()
        pnlFullNameBox = New Panel()
        txtFullName = New TextBox()
        lblFullName = New Label()
        pnlStudentNumberBox = New Panel()
        btnSearchStudentNumber = New Button()
        txtStudentNumber = New TextBox()
        lblStudentNumber = New Label()
        lblStudentInfoHeader = New Label()
        lblSubtitle = New Label()
        lblTitle = New Label()
        pnlSidebar.SuspendLayout()
        pnlLogout.SuspendLayout()
        pnlLogoArea.SuspendLayout()
        pnlLogo.SuspendLayout()
        CType(picLogo, ComponentModel.ISupportInitialize).BeginInit()
        pnlContent.SuspendLayout()
        pnlActionButtons.SuspendLayout()
        pnlDocDetails.SuspendLayout()
        pnlAmountDueBox.SuspendLayout()
        pnlCopiesBox.SuspendLayout()
        pnlStudentInfo.SuspendLayout()
        pnlContactNumberBox.SuspendLayout()
        pnlCourseBox.SuspendLayout()
        pnlFullNameBox.SuspendLayout()
        pnlStudentNumberBox.SuspendLayout()
        SuspendLayout()
        ' 
        ' pnlSidebar
        ' 
        pnlSidebar.BackColor = Color.FromArgb(CByte(245), CByte(197), CByte(24))
        pnlSidebar.Controls.Add(pnlLogout)
        pnlSidebar.Controls.Add(btnReports)
        pnlSidebar.Controls.Add(btnSearchStudent)
        pnlSidebar.Controls.Add(btnRequestList)
        pnlSidebar.Controls.Add(btnNewRequest)
        pnlSidebar.Controls.Add(btnDashboard)
        pnlSidebar.Controls.Add(pnlLogoArea)
        pnlSidebar.Dock = DockStyle.Left
        pnlSidebar.Location = New Point(0, 0)
        pnlSidebar.Name = "pnlSidebar"
        pnlSidebar.Size = New Size(230, 800)
        pnlSidebar.TabIndex = 0
        ' 
        ' pnlLogout
        ' 
        pnlLogout.BackColor = Color.Transparent
        pnlLogout.Controls.Add(btnLogout)
        pnlLogout.Dock = DockStyle.Bottom
        pnlLogout.Location = New Point(0, 730)
        pnlLogout.Name = "pnlLogout"
        pnlLogout.Size = New Size(230, 70)
        pnlLogout.TabIndex = 6
        ' 
        ' btnLogout
        ' 
        btnLogout.BackColor = Color.FromArgb(CByte(245), CByte(197), CByte(24))
        btnLogout.Cursor = Cursors.Hand
        btnLogout.Dock = DockStyle.Fill
        btnLogout.FlatAppearance.BorderSize = 0
        btnLogout.FlatStyle = FlatStyle.Flat
        btnLogout.Font = New Font("Segoe UI", 10F)
        btnLogout.ForeColor = Color.FromArgb(CByte(15), CByte(31), CByte(76))
        btnLogout.Location = New Point(0, 0)
        btnLogout.Name = "btnLogout"
        btnLogout.Padding = New Padding(24, 0, 0, 0)
        btnLogout.Size = New Size(230, 70)
        btnLogout.TabIndex = 0
        btnLogout.Text = "Logout"
        btnLogout.TextAlign = ContentAlignment.MiddleLeft
        btnLogout.UseVisualStyleBackColor = False
        ' 
        ' btnReports
        ' 
        btnReports.BackColor = Color.FromArgb(CByte(245), CByte(197), CByte(24))
        btnReports.Cursor = Cursors.Hand
        btnReports.Dock = DockStyle.Top
        btnReports.FlatAppearance.BorderSize = 0
        btnReports.FlatStyle = FlatStyle.Flat
        btnReports.Font = New Font("Segoe UI", 10F)
        btnReports.ForeColor = Color.FromArgb(CByte(15), CByte(31), CByte(76))
        btnReports.Location = New Point(0, 325)
        btnReports.Name = "btnReports"
        btnReports.Padding = New Padding(24, 0, 0, 0)
        btnReports.Size = New Size(230, 60)
        btnReports.TabIndex = 5
        btnReports.Text = "Reports"
        btnReports.TextAlign = ContentAlignment.MiddleLeft
        btnReports.UseVisualStyleBackColor = False
        ' 
        ' btnSearchStudent
        ' 
        btnSearchStudent.BackColor = Color.FromArgb(CByte(245), CByte(197), CByte(24))
        btnSearchStudent.Cursor = Cursors.Hand
        btnSearchStudent.Dock = DockStyle.Top
        btnSearchStudent.FlatAppearance.BorderSize = 0
        btnSearchStudent.FlatStyle = FlatStyle.Flat
        btnSearchStudent.Font = New Font("Segoe UI", 10F)
        btnSearchStudent.ForeColor = Color.FromArgb(CByte(15), CByte(31), CByte(76))
        btnSearchStudent.Location = New Point(0, 265)
        btnSearchStudent.Name = "btnSearchStudent"
        btnSearchStudent.Padding = New Padding(24, 0, 0, 0)
        btnSearchStudent.Size = New Size(230, 60)
        btnSearchStudent.TabIndex = 4
        btnSearchStudent.Text = "Search Student"
        btnSearchStudent.TextAlign = ContentAlignment.MiddleLeft
        btnSearchStudent.UseVisualStyleBackColor = False
        ' 
        ' btnRequestList
        ' 
        btnRequestList.BackColor = Color.FromArgb(CByte(245), CByte(197), CByte(24))
        btnRequestList.Cursor = Cursors.Hand
        btnRequestList.Dock = DockStyle.Top
        btnRequestList.FlatAppearance.BorderSize = 0
        btnRequestList.FlatStyle = FlatStyle.Flat
        btnRequestList.Font = New Font("Segoe UI", 10F)
        btnRequestList.ForeColor = Color.FromArgb(CByte(15), CByte(31), CByte(76))
        btnRequestList.Location = New Point(0, 205)
        btnRequestList.Name = "btnRequestList"
        btnRequestList.Padding = New Padding(24, 0, 0, 0)
        btnRequestList.Size = New Size(230, 60)
        btnRequestList.TabIndex = 3
        btnRequestList.Text = "Request List"
        btnRequestList.TextAlign = ContentAlignment.MiddleLeft
        btnRequestList.UseVisualStyleBackColor = False
        ' 
        ' btnNewRequest
        ' 
        btnNewRequest.BackColor = Color.FromArgb(CByte(245), CByte(197), CByte(24))
        btnNewRequest.Cursor = Cursors.Hand
        btnNewRequest.Dock = DockStyle.Top
        btnNewRequest.FlatAppearance.BorderSize = 0
        btnNewRequest.FlatStyle = FlatStyle.Flat
        btnNewRequest.Font = New Font("Segoe UI", 10F, FontStyle.Bold)
        btnNewRequest.ForeColor = Color.FromArgb(CByte(15), CByte(31), CByte(76))
        btnNewRequest.Location = New Point(0, 145)
        btnNewRequest.Name = "btnNewRequest"
        btnNewRequest.Padding = New Padding(24, 0, 0, 0)
        btnNewRequest.Size = New Size(230, 60)
        btnNewRequest.TabIndex = 2
        btnNewRequest.Text = "New Request"
        btnNewRequest.TextAlign = ContentAlignment.MiddleLeft
        btnNewRequest.UseVisualStyleBackColor = False
        ' 
        ' btnDashboard
        ' 
        btnDashboard.BackColor = Color.FromArgb(CByte(245), CByte(197), CByte(24))
        btnDashboard.Cursor = Cursors.Hand
        btnDashboard.Dock = DockStyle.Top
        btnDashboard.FlatAppearance.BorderSize = 0
        btnDashboard.FlatStyle = FlatStyle.Flat
        btnDashboard.Font = New Font("Segoe UI", 10F)
        btnDashboard.ForeColor = Color.FromArgb(CByte(15), CByte(31), CByte(76))
        btnDashboard.Location = New Point(0, 85)
        btnDashboard.Name = "btnDashboard"
        btnDashboard.Padding = New Padding(24, 0, 0, 0)
        btnDashboard.Size = New Size(230, 60)
        btnDashboard.TabIndex = 1
        btnDashboard.Text = "Dashboard"
        btnDashboard.TextAlign = ContentAlignment.MiddleLeft
        btnDashboard.UseVisualStyleBackColor = False
        ' 
        ' pnlLogoArea
        ' 
        pnlLogoArea.BackColor = Color.Transparent
        pnlLogoArea.Controls.Add(pnlLogo)
        pnlLogoArea.Dock = DockStyle.Top
        pnlLogoArea.Location = New Point(0, 0)
        pnlLogoArea.Name = "pnlLogoArea"
        pnlLogoArea.Size = New Size(230, 85)
        pnlLogoArea.TabIndex = 0
        ' 
        ' pnlLogo
        ' 
        pnlLogo.Controls.Add(picLogo)
        pnlLogo.Controls.Add(lblLogo)
        pnlLogo.Dock = DockStyle.Top
        pnlLogo.Location = New Point(0, 0)
        pnlLogo.Name = "pnlLogo"
        pnlLogo.Size = New Size(230, 60)
        pnlLogo.TabIndex = 3
        ' 
        ' picLogo
        ' 
        picLogo.BackColor = Color.FromArgb(CByte(15), CByte(31), CByte(76))
        picLogo.Image = CType(resources.GetObject("picLogo.Image"), Image)
        picLogo.Location = New Point(10, 12)
        picLogo.Name = "picLogo"
        picLogo.Size = New Size(42, 42)
        picLogo.SizeMode = PictureBoxSizeMode.Zoom
        picLogo.TabIndex = 0
        picLogo.TabStop = False
        ' 
        ' lblLogo
        ' 
        lblLogo.AutoSize = True
        lblLogo.Font = New Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        lblLogo.ForeColor = Color.FromArgb(CByte(15), CByte(31), CByte(76))
        lblLogo.Location = New Point(58, 25)
        lblLogo.Name = "lblLogo"
        lblLogo.Size = New Size(111, 17)
        lblLogo.TabIndex = 0
        lblLogo.Text = "Registrar System"
        ' 
        ' pnlContent
        ' 
        pnlContent.BackColor = Color.FromArgb(CByte(15), CByte(31), CByte(76))
        pnlContent.Controls.Add(pnlActionButtons)
        pnlContent.Controls.Add(pnlDocDetails)
        pnlContent.Controls.Add(pnlStudentInfo)
        pnlContent.Controls.Add(lblSubtitle)
        pnlContent.Controls.Add(lblTitle)
        pnlContent.Dock = DockStyle.Fill
        pnlContent.Location = New Point(230, 0)
        pnlContent.Name = "pnlContent"
        pnlContent.Size = New Size(970, 800)
        pnlContent.TabIndex = 1
        ' 
        ' pnlActionButtons
        ' 
        pnlActionButtons.Anchor = AnchorStyles.Top Or AnchorStyles.Right
        pnlActionButtons.BackColor = Color.Transparent
        pnlActionButtons.Controls.Add(btnCancel)
        pnlActionButtons.Controls.Add(btnSubmitRequest)
        pnlActionButtons.Location = New Point(645, 520)
        pnlActionButtons.Name = "pnlActionButtons"
        pnlActionButtons.Size = New Size(295, 45)
        pnlActionButtons.TabIndex = 4
        ' 
        ' btnCancel
        ' 
        btnCancel.BackColor = Color.FromArgb(CByte(15), CByte(31), CByte(76))
        btnCancel.Cursor = Cursors.Hand
        btnCancel.FlatAppearance.BorderColor = Color.FromArgb(CByte(108), CByte(122), CByte(174))
        btnCancel.FlatStyle = FlatStyle.Flat
        btnCancel.Font = New Font("Segoe UI", 9.5F)
        btnCancel.ForeColor = Color.White
        btnCancel.Location = New Point(10, 4)
        btnCancel.Name = "btnCancel"
        btnCancel.Size = New Size(100, 36)
        btnCancel.TabIndex = 0
        btnCancel.Text = "Cancel"
        btnCancel.UseVisualStyleBackColor = False
        ' 
        ' btnSubmitRequest
        ' 
        btnSubmitRequest.BackColor = Color.FromArgb(CByte(245), CByte(197), CByte(24))
        btnSubmitRequest.Cursor = Cursors.Hand
        btnSubmitRequest.FlatAppearance.BorderSize = 0
        btnSubmitRequest.FlatStyle = FlatStyle.Flat
        btnSubmitRequest.Font = New Font("Segoe UI", 10F, FontStyle.Bold)
        btnSubmitRequest.ForeColor = Color.FromArgb(CByte(15), CByte(31), CByte(76))
        btnSubmitRequest.Location = New Point(125, 4)
        btnSubmitRequest.Name = "btnSubmitRequest"
        btnSubmitRequest.Size = New Size(160, 36)
        btnSubmitRequest.TabIndex = 1
        btnSubmitRequest.Text = "Submit request"
        btnSubmitRequest.UseVisualStyleBackColor = False
        ' 
        ' pnlDocDetails
        ' 
        pnlDocDetails.Anchor = AnchorStyles.Top Or AnchorStyles.Left Or AnchorStyles.Right
        pnlDocDetails.BackColor = Color.FromArgb(CByte(26), CByte(46), CByte(99))
        pnlDocDetails.Controls.Add(cboPaymentStatus)
        pnlDocDetails.Controls.Add(lblPaymentStatus)
        pnlDocDetails.Controls.Add(pnlAmountDueBox)
        pnlDocDetails.Controls.Add(lblAmountDue)
        pnlDocDetails.Controls.Add(dtpDateNeeded)
        pnlDocDetails.Controls.Add(lblDateNeeded)
        pnlDocDetails.Controls.Add(cboPurpose)
        pnlDocDetails.Controls.Add(lblPurpose)
        pnlDocDetails.Controls.Add(pnlCopiesBox)
        pnlDocDetails.Controls.Add(lblCopies)
        pnlDocDetails.Controls.Add(cboDocumentType)
        pnlDocDetails.Controls.Add(lblDocumentType)
        pnlDocDetails.Controls.Add(lblDocDetailsHeader)
        pnlDocDetails.Location = New Point(30, 305)
        pnlDocDetails.Name = "pnlDocDetails"
        pnlDocDetails.Size = New Size(910, 195)
        pnlDocDetails.TabIndex = 3
        ' 
        ' cboPaymentStatus
        ' 
        cboPaymentStatus.BackColor = Color.FromArgb(CByte(22), CByte(32), CByte(74))
        cboPaymentStatus.DropDownStyle = ComboBoxStyle.DropDownList
        cboPaymentStatus.FlatStyle = FlatStyle.Flat
        cboPaymentStatus.Font = New Font("Segoe UI", 10F)
        cboPaymentStatus.ForeColor = Color.White
        cboPaymentStatus.FormattingEnabled = True
        cboPaymentStatus.Items.AddRange(New Object() {"Unpaid", "Paid"})
        cboPaymentStatus.Location = New Point(635, 131)
        cboPaymentStatus.Name = "cboPaymentStatus"
        cboPaymentStatus.Size = New Size(245, 25)
        cboPaymentStatus.TabIndex = 12
        ' 
        ' lblPaymentStatus
        ' 
        lblPaymentStatus.AutoSize = True
        lblPaymentStatus.Font = New Font("Segoe UI", 8.5F)
        lblPaymentStatus.ForeColor = Color.FromArgb(CByte(160), CByte(174), CByte(192))
        lblPaymentStatus.Location = New Point(635, 110)
        lblPaymentStatus.Name = "lblPaymentStatus"
        lblPaymentStatus.Size = New Size(88, 15)
        lblPaymentStatus.TabIndex = 11
        lblPaymentStatus.Text = "Payment status"
        ' 
        ' pnlAmountDueBox
        ' 
        pnlAmountDueBox.BackColor = Color.FromArgb(CByte(22), CByte(32), CByte(74))
        pnlAmountDueBox.BorderStyle = BorderStyle.FixedSingle
        pnlAmountDueBox.Controls.Add(txtAmountDue)
        pnlAmountDueBox.Location = New Point(445, 131)
        pnlAmountDueBox.Name = "pnlAmountDueBox"
        pnlAmountDueBox.Size = New Size(170, 32)
        pnlAmountDueBox.TabIndex = 10
        ' 
        ' txtAmountDue
        ' 
        txtAmountDue.BackColor = Color.FromArgb(CByte(22), CByte(32), CByte(74))
        txtAmountDue.BorderStyle = BorderStyle.None
        txtAmountDue.Font = New Font("Segoe UI", 10F, FontStyle.Bold)
        txtAmountDue.ForeColor = Color.FromArgb(CByte(245), CByte(197), CByte(24))
        txtAmountDue.Location = New Point(8, 6)
        txtAmountDue.Name = "txtAmountDue"
        txtAmountDue.ReadOnly = True
        txtAmountDue.Size = New Size(150, 18)
        txtAmountDue.TabIndex = 0
        txtAmountDue.Text = "PHP 300.00"
        ' 
        ' lblAmountDue
        ' 
        lblAmountDue.AutoSize = True
        lblAmountDue.Font = New Font("Segoe UI", 8.5F)
        lblAmountDue.ForeColor = Color.FromArgb(CByte(160), CByte(174), CByte(192))
        lblAmountDue.Location = New Point(445, 110)
        lblAmountDue.Name = "lblAmountDue"
        lblAmountDue.Size = New Size(74, 15)
        lblAmountDue.TabIndex = 9
        lblAmountDue.Text = "Amount due"
        ' 
        ' dtpDateNeeded
        ' 
        dtpDateNeeded.CalendarForeColor = Color.White
        dtpDateNeeded.CalendarMonthBackground = Color.FromArgb(CByte(26), CByte(46), CByte(99))
        dtpDateNeeded.CalendarTitleBackColor = Color.FromArgb(CByte(15), CByte(31), CByte(76))
        dtpDateNeeded.CalendarTitleForeColor = Color.FromArgb(CByte(245), CByte(197), CByte(24))
        dtpDateNeeded.CustomFormat = "MMM dd, yyyy"
        dtpDateNeeded.Font = New Font("Segoe UI", 10F)
        dtpDateNeeded.Format = DateTimePickerFormat.Custom
        dtpDateNeeded.Location = New Point(25, 131)
        dtpDateNeeded.Name = "dtpDateNeeded"
        dtpDateNeeded.Size = New Size(400, 25)
        dtpDateNeeded.TabIndex = 8
        dtpDateNeeded.Value = New Date(2026, 9, 28, 0, 0, 0, 0)
        ' 
        ' lblDateNeeded
        ' 
        lblDateNeeded.AutoSize = True
        lblDateNeeded.Font = New Font("Segoe UI", 8.5F)
        lblDateNeeded.ForeColor = Color.FromArgb(CByte(160), CByte(174), CByte(192))
        lblDateNeeded.Location = New Point(25, 110)
        lblDateNeeded.Name = "lblDateNeeded"
        lblDateNeeded.Size = New Size(73, 15)
        lblDateNeeded.TabIndex = 7
        lblDateNeeded.Text = "Date needed"
        ' 
        ' cboPurpose
        ' 
        cboPurpose.BackColor = Color.FromArgb(CByte(22), CByte(32), CByte(74))
        cboPurpose.DropDownStyle = ComboBoxStyle.DropDownList
        cboPurpose.FlatStyle = FlatStyle.Flat
        cboPurpose.Font = New Font("Segoe UI", 10F)
        cboPurpose.ForeColor = Color.White
        cboPurpose.FormattingEnabled = True
        cboPurpose.Items.AddRange(New Object() {"Employment", "Scholarship", "Further Studies / Transfer", "Board Exam / PRC", "Personal Copy"})
        cboPurpose.Location = New Point(635, 65)
        cboPurpose.Name = "cboPurpose"
        cboPurpose.Size = New Size(245, 25)
        cboPurpose.TabIndex = 6
        ' 
        ' lblPurpose
        ' 
        lblPurpose.AutoSize = True
        lblPurpose.Font = New Font("Segoe UI", 8.5F)
        lblPurpose.ForeColor = Color.FromArgb(CByte(160), CByte(174), CByte(192))
        lblPurpose.Location = New Point(635, 44)
        lblPurpose.Name = "lblPurpose"
        lblPurpose.Size = New Size(50, 15)
        lblPurpose.TabIndex = 5
        lblPurpose.Text = "Purpose"
        ' 
        ' pnlCopiesBox
        ' 
        pnlCopiesBox.BackColor = Color.FromArgb(CByte(22), CByte(32), CByte(74))
        pnlCopiesBox.BorderStyle = BorderStyle.FixedSingle
        pnlCopiesBox.Controls.Add(txtCopies)
        pnlCopiesBox.Location = New Point(445, 65)
        pnlCopiesBox.Name = "pnlCopiesBox"
        pnlCopiesBox.Size = New Size(170, 32)
        pnlCopiesBox.TabIndex = 4
        ' 
        ' txtCopies
        ' 
        txtCopies.BackColor = Color.FromArgb(CByte(22), CByte(32), CByte(74))
        txtCopies.BorderStyle = BorderStyle.None
        txtCopies.Font = New Font("Segoe UI", 10F)
        txtCopies.ForeColor = Color.White
        txtCopies.Location = New Point(8, 6)
        txtCopies.Name = "txtCopies"
        txtCopies.Size = New Size(150, 18)
        txtCopies.TabIndex = 0
        txtCopies.Text = "2"
        ' 
        ' lblCopies
        ' 
        lblCopies.AutoSize = True
        lblCopies.Font = New Font("Segoe UI", 8.5F)
        lblCopies.ForeColor = Color.FromArgb(CByte(160), CByte(174), CByte(192))
        lblCopies.Location = New Point(445, 44)
        lblCopies.Name = "lblCopies"
        lblCopies.Size = New Size(43, 15)
        lblCopies.TabIndex = 3
        lblCopies.Text = "Copies"
        ' 
        ' cboDocumentType
        ' 
        cboDocumentType.BackColor = Color.FromArgb(CByte(22), CByte(32), CByte(74))
        cboDocumentType.DropDownStyle = ComboBoxStyle.DropDownList
        cboDocumentType.FlatStyle = FlatStyle.Flat
        cboDocumentType.Font = New Font("Segoe UI", 10F)
        cboDocumentType.ForeColor = Color.White
        cboDocumentType.FormattingEnabled = True
        cboDocumentType.Items.AddRange(New Object() {"Transcript of records", "Certificate of Good Moral", "Certificate of Enrollment", "Diploma Copy", "Certified True Copy"})
        cboDocumentType.Location = New Point(25, 65)
        cboDocumentType.Name = "cboDocumentType"
        cboDocumentType.Size = New Size(400, 25)
        cboDocumentType.TabIndex = 2
        ' 
        ' lblDocumentType
        ' 
        lblDocumentType.AutoSize = True
        lblDocumentType.Font = New Font("Segoe UI", 8.5F)
        lblDocumentType.ForeColor = Color.FromArgb(CByte(160), CByte(174), CByte(192))
        lblDocumentType.Location = New Point(25, 44)
        lblDocumentType.Name = "lblDocumentType"
        lblDocumentType.Size = New Size(89, 15)
        lblDocumentType.TabIndex = 1
        lblDocumentType.Text = "Document type"
        ' 
        ' lblDocDetailsHeader
        ' 
        lblDocDetailsHeader.AutoSize = True
        lblDocDetailsHeader.Font = New Font("Segoe UI", 8.5F, FontStyle.Bold)
        lblDocDetailsHeader.ForeColor = Color.FromArgb(CByte(245), CByte(197), CByte(24))
        lblDocDetailsHeader.Location = New Point(25, 16)
        lblDocDetailsHeader.Name = "lblDocDetailsHeader"
        lblDocDetailsHeader.Size = New Size(123, 15)
        lblDocDetailsHeader.TabIndex = 0
        lblDocDetailsHeader.Text = "DOCUMENT DETAILS"
        ' 
        ' pnlStudentInfo
        ' 
        pnlStudentInfo.Anchor = AnchorStyles.Top Or AnchorStyles.Left Or AnchorStyles.Right
        pnlStudentInfo.BackColor = Color.FromArgb(CByte(26), CByte(46), CByte(99))
        pnlStudentInfo.Controls.Add(pnlContactNumberBox)
        pnlStudentInfo.Controls.Add(lblContactNumber)
        pnlStudentInfo.Controls.Add(cboYearLevel)
        pnlStudentInfo.Controls.Add(lblYearLevel)
        pnlStudentInfo.Controls.Add(pnlCourseBox)
        pnlStudentInfo.Controls.Add(lblCourse)
        pnlStudentInfo.Controls.Add(pnlFullNameBox)
        pnlStudentInfo.Controls.Add(lblFullName)
        pnlStudentInfo.Controls.Add(pnlStudentNumberBox)
        pnlStudentInfo.Controls.Add(lblStudentNumber)
        pnlStudentInfo.Controls.Add(lblStudentInfoHeader)
        pnlStudentInfo.Location = New Point(30, 100)
        pnlStudentInfo.Name = "pnlStudentInfo"
        pnlStudentInfo.Size = New Size(910, 185)
        pnlStudentInfo.TabIndex = 2
        ' 
        ' pnlContactNumberBox
        ' 
        pnlContactNumberBox.BackColor = Color.FromArgb(CByte(22), CByte(32), CByte(74))
        pnlContactNumberBox.BorderStyle = BorderStyle.FixedSingle
        pnlContactNumberBox.Controls.Add(txtContactNumber)
        pnlContactNumberBox.Location = New Point(455, 131)
        pnlContactNumberBox.Name = "pnlContactNumberBox"
        pnlContactNumberBox.Size = New Size(425, 32)
        pnlContactNumberBox.TabIndex = 8
        ' 
        ' txtContactNumber
        ' 
        txtContactNumber.BackColor = Color.FromArgb(CByte(22), CByte(32), CByte(74))
        txtContactNumber.BorderStyle = BorderStyle.None
        txtContactNumber.Font = New Font("Segoe UI", 10F)
        txtContactNumber.ForeColor = Color.FromArgb(CByte(160), CByte(174), CByte(192))
        txtContactNumber.Location = New Point(8, 6)
        txtContactNumber.Name = "txtContactNumber"
        txtContactNumber.Size = New Size(405, 18)
        txtContactNumber.TabIndex = 0
        txtContactNumber.Text = "09XX XXX XXXX"
        ' 
        ' lblContactNumber
        ' 
        lblContactNumber.AutoSize = True
        lblContactNumber.Font = New Font("Segoe UI", 8.5F)
        lblContactNumber.ForeColor = Color.FromArgb(CByte(160), CByte(174), CByte(192))
        lblContactNumber.Location = New Point(455, 110)
        lblContactNumber.Name = "lblContactNumber"
        lblContactNumber.Size = New Size(94, 15)
        lblContactNumber.TabIndex = 7
        lblContactNumber.Text = "Contact number"
        ' 
        ' cboYearLevel
        ' 
        cboYearLevel.BackColor = Color.FromArgb(CByte(22), CByte(32), CByte(74))
        cboYearLevel.DropDownStyle = ComboBoxStyle.DropDownList
        cboYearLevel.FlatStyle = FlatStyle.Flat
        cboYearLevel.Font = New Font("Segoe UI", 10F, FontStyle.Bold)
        cboYearLevel.ForeColor = Color.White
        cboYearLevel.FormattingEnabled = True
        cboYearLevel.Items.AddRange(New Object() {"1st Year", "2nd Year", "3rd Year", "4th Year"})
        cboYearLevel.Location = New Point(260, 131)
        cboYearLevel.Name = "cboYearLevel"
        cboYearLevel.Size = New Size(165, 25)
        cboYearLevel.TabIndex = 7
        ' 
        ' lblYearLevel
        ' 
        lblYearLevel.AutoSize = True
        lblYearLevel.Font = New Font("Segoe UI", 8.5F)
        lblYearLevel.ForeColor = Color.FromArgb(CByte(160), CByte(174), CByte(192))
        lblYearLevel.Location = New Point(260, 110)
        lblYearLevel.Name = "lblYearLevel"
        lblYearLevel.Size = New Size(29, 15)
        lblYearLevel.TabIndex = 6
        lblYearLevel.Text = "Year"
        ' 
        ' pnlCourseBox
        ' 
        pnlCourseBox.BackColor = Color.FromArgb(CByte(22), CByte(32), CByte(74))
        pnlCourseBox.BorderStyle = BorderStyle.FixedSingle
        pnlCourseBox.Controls.Add(txtCourse)
        pnlCourseBox.Location = New Point(25, 131)
        pnlCourseBox.Name = "pnlCourseBox"
        pnlCourseBox.Size = New Size(220, 32)
        pnlCourseBox.TabIndex = 5
        ' 
        ' txtCourse
        ' 
        txtCourse.BackColor = Color.FromArgb(CByte(22), CByte(32), CByte(74))
        txtCourse.BorderStyle = BorderStyle.None
        txtCourse.Font = New Font("Segoe UI", 10F, FontStyle.Bold)
        txtCourse.ForeColor = Color.White
        txtCourse.Location = New Point(8, 6)
        txtCourse.Name = "txtCourse"
        txtCourse.Size = New Size(204, 18)
        txtCourse.TabIndex = 0
        txtCourse.Text = "BSIT"
        ' 
        ' lblCourse
        ' 
        lblCourse.AutoSize = True
        lblCourse.Font = New Font("Segoe UI", 8.5F)
        lblCourse.ForeColor = Color.FromArgb(CByte(160), CByte(174), CByte(192))
        lblCourse.Location = New Point(25, 110)
        lblCourse.Name = "lblCourse"
        lblCourse.Size = New Size(44, 15)
        lblCourse.TabIndex = 4
        lblCourse.Text = "Course"
        ' 
        ' pnlFullNameBox
        ' 
        pnlFullNameBox.BackColor = Color.FromArgb(CByte(22), CByte(32), CByte(74))
        pnlFullNameBox.BorderStyle = BorderStyle.FixedSingle
        pnlFullNameBox.Controls.Add(txtFullName)
        pnlFullNameBox.Location = New Point(455, 65)
        pnlFullNameBox.Name = "pnlFullNameBox"
        pnlFullNameBox.Size = New Size(425, 32)
        pnlFullNameBox.TabIndex = 4
        ' 
        ' txtFullName
        ' 
        txtFullName.BackColor = Color.FromArgb(CByte(22), CByte(32), CByte(74))
        txtFullName.BorderStyle = BorderStyle.None
        txtFullName.Font = New Font("Segoe UI", 10F, FontStyle.Bold)
        txtFullName.ForeColor = Color.White
        txtFullName.Location = New Point(8, 6)
        txtFullName.Name = "txtFullName"
        txtFullName.Size = New Size(405, 18)
        txtFullName.TabIndex = 0
        txtFullName.Text = "Jancris Tiu"
        ' 
        ' lblFullName
        ' 
        lblFullName.AutoSize = True
        lblFullName.Font = New Font("Segoe UI", 8.5F)
        lblFullName.ForeColor = Color.FromArgb(CByte(160), CByte(174), CByte(192))
        lblFullName.Location = New Point(455, 44)
        lblFullName.Name = "lblFullName"
        lblFullName.Size = New Size(59, 15)
        lblFullName.TabIndex = 3
        lblFullName.Text = "Full name"
        ' 
        ' pnlStudentNumberBox
        ' 
        pnlStudentNumberBox.BackColor = Color.FromArgb(CByte(22), CByte(32), CByte(74))
        pnlStudentNumberBox.BorderStyle = BorderStyle.FixedSingle
        pnlStudentNumberBox.Controls.Add(btnSearchStudentNumber)
        pnlStudentNumberBox.Controls.Add(txtStudentNumber)
        pnlStudentNumberBox.Location = New Point(25, 65)
        pnlStudentNumberBox.Name = "pnlStudentNumberBox"
        pnlStudentNumberBox.Size = New Size(400, 32)
        pnlStudentNumberBox.TabIndex = 2
        ' 
        ' btnSearchStudentNumber
        ' 
        btnSearchStudentNumber.BackColor = Color.Transparent
        btnSearchStudentNumber.Cursor = Cursors.Hand
        btnSearchStudentNumber.FlatAppearance.BorderSize = 0
        btnSearchStudentNumber.FlatStyle = FlatStyle.Flat
        btnSearchStudentNumber.Font = New Font("Segoe UI", 9F)
        btnSearchStudentNumber.ForeColor = Color.FromArgb(CByte(160), CByte(174), CByte(192))
        btnSearchStudentNumber.Location = New Point(368, 2)
        btnSearchStudentNumber.Name = "btnSearchStudentNumber"
        btnSearchStudentNumber.Size = New Size(26, 26)
        btnSearchStudentNumber.TabIndex = 1
        btnSearchStudentNumber.Text = "🔍"
        btnSearchStudentNumber.UseVisualStyleBackColor = True
        ' 
        ' txtStudentNumber
        ' 
        txtStudentNumber.BackColor = Color.FromArgb(CByte(22), CByte(32), CByte(74))
        txtStudentNumber.BorderStyle = BorderStyle.None
        txtStudentNumber.Font = New Font("Segoe UI", 10F)
        txtStudentNumber.ForeColor = Color.White
        txtStudentNumber.Location = New Point(8, 6)
        txtStudentNumber.Name = "txtStudentNumber"
        txtStudentNumber.Size = New Size(355, 18)
        txtStudentNumber.TabIndex = 0
        txtStudentNumber.Text = "2021-00432"
        ' 
        ' lblStudentNumber
        ' 
        lblStudentNumber.AutoSize = True
        lblStudentNumber.Font = New Font("Segoe UI", 8.5F)
        lblStudentNumber.ForeColor = Color.FromArgb(CByte(160), CByte(174), CByte(192))
        lblStudentNumber.Location = New Point(25, 44)
        lblStudentNumber.Name = "lblStudentNumber"
        lblStudentNumber.Size = New Size(93, 15)
        lblStudentNumber.TabIndex = 1
        lblStudentNumber.Text = "Student number"
        ' 
        ' lblStudentInfoHeader
        ' 
        lblStudentInfoHeader.AutoSize = True
        lblStudentInfoHeader.Font = New Font("Segoe UI", 8.5F, FontStyle.Bold)
        lblStudentInfoHeader.ForeColor = Color.FromArgb(CByte(245), CByte(197), CByte(24))
        lblStudentInfoHeader.Location = New Point(25, 16)
        lblStudentInfoHeader.Name = "lblStudentInfoHeader"
        lblStudentInfoHeader.Size = New Size(147, 15)
        lblStudentInfoHeader.TabIndex = 0
        lblStudentInfoHeader.Text = "STUDENT INFORMATION"
        ' 
        ' lblSubtitle
        ' 
        lblSubtitle.AutoSize = True
        lblSubtitle.Font = New Font("Segoe UI", 9.5F)
        lblSubtitle.ForeColor = Color.FromArgb(CByte(160), CByte(174), CByte(192))
        lblSubtitle.Location = New Point(30, 62)
        lblSubtitle.Name = "lblSubtitle"
        lblSubtitle.Size = New Size(214, 17)
        lblSubtitle.TabIndex = 1
        lblSubtitle.Text = "Fill in student and document details"
        ' 
        ' lblTitle
        ' 
        lblTitle.AutoSize = True
        lblTitle.Font = New Font("Segoe UI", 18F, FontStyle.Bold)
        lblTitle.ForeColor = Color.White
        lblTitle.Location = New Point(30, 25)
        lblTitle.Name = "lblTitle"
        lblTitle.Size = New Size(281, 32)
        lblTitle.TabIndex = 0
        lblTitle.Text = "New document request"
        ' 
        ' frmNewRequest
        ' 
        AcceptButton = btnSubmitRequest
        AutoScaleDimensions = New SizeF(7F, 17F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.FromArgb(CByte(15), CByte(31), CByte(76))
        CancelButton = btnCancel
        ClientSize = New Size(1200, 800)
        Controls.Add(pnlContent)
        Controls.Add(pnlSidebar)
        Font = New Font("Segoe UI", 9.5F)
        MinimumSize = New Size(1024, 700)
        Name = "frmNewRequest"
        StartPosition = FormStartPosition.CenterScreen
        Text = "Registrar Document Request System - New Document Request"
        WindowState = FormWindowState.Maximized
        pnlSidebar.ResumeLayout(False)
        pnlLogout.ResumeLayout(False)
        pnlLogoArea.ResumeLayout(False)
        pnlLogo.ResumeLayout(False)
        pnlLogo.PerformLayout()
        CType(picLogo, ComponentModel.ISupportInitialize).EndInit()
        pnlContent.ResumeLayout(False)
        pnlContent.PerformLayout()
        pnlActionButtons.ResumeLayout(False)
        pnlDocDetails.ResumeLayout(False)
        pnlDocDetails.PerformLayout()
        pnlAmountDueBox.ResumeLayout(False)
        pnlAmountDueBox.PerformLayout()
        pnlCopiesBox.ResumeLayout(False)
        pnlCopiesBox.PerformLayout()
        pnlStudentInfo.ResumeLayout(False)
        pnlStudentInfo.PerformLayout()
        pnlContactNumberBox.ResumeLayout(False)
        pnlContactNumberBox.PerformLayout()
        pnlCourseBox.ResumeLayout(False)
        pnlCourseBox.PerformLayout()
        pnlFullNameBox.ResumeLayout(False)
        pnlFullNameBox.PerformLayout()
        pnlStudentNumberBox.ResumeLayout(False)
        pnlStudentNumberBox.PerformLayout()
        ResumeLayout(False)

    End Sub

    Friend WithEvents pnlSidebar As System.Windows.Forms.Panel
    Friend WithEvents btnDashboard As System.Windows.Forms.Button
    Friend WithEvents btnNewRequest As System.Windows.Forms.Button
    Friend WithEvents btnRequestList As System.Windows.Forms.Button
    Friend WithEvents btnSearchStudent As System.Windows.Forms.Button
    Friend WithEvents btnReports As System.Windows.Forms.Button
    Friend WithEvents pnlLogout As System.Windows.Forms.Panel
    Friend WithEvents btnLogout As System.Windows.Forms.Button
    Friend WithEvents pnlContent As System.Windows.Forms.Panel
    Friend WithEvents lblTitle As System.Windows.Forms.Label
    Friend WithEvents lblSubtitle As System.Windows.Forms.Label
    Friend WithEvents pnlStudentInfo As System.Windows.Forms.Panel
    Friend WithEvents lblStudentInfoHeader As System.Windows.Forms.Label
    Friend WithEvents lblStudentNumber As System.Windows.Forms.Label
    Friend WithEvents pnlStudentNumberBox As System.Windows.Forms.Panel
    Friend WithEvents txtStudentNumber As System.Windows.Forms.TextBox
    Friend WithEvents btnSearchStudentNumber As System.Windows.Forms.Button
    Friend WithEvents lblFullName As System.Windows.Forms.Label
    Friend WithEvents pnlFullNameBox As System.Windows.Forms.Panel
    Friend WithEvents txtFullName As System.Windows.Forms.TextBox
    Friend WithEvents lblCourse As System.Windows.Forms.Label
    Friend WithEvents pnlCourseBox As System.Windows.Forms.Panel
    Friend WithEvents txtCourse As System.Windows.Forms.TextBox
    Friend WithEvents lblYearLevel As System.Windows.Forms.Label
    Friend WithEvents cboYearLevel As System.Windows.Forms.ComboBox
    Friend WithEvents lblContactNumber As System.Windows.Forms.Label
    Friend WithEvents pnlContactNumberBox As System.Windows.Forms.Panel
    Friend WithEvents txtContactNumber As System.Windows.Forms.TextBox
    Friend WithEvents pnlDocDetails As System.Windows.Forms.Panel
    Friend WithEvents lblDocDetailsHeader As System.Windows.Forms.Label
    Friend WithEvents lblDocumentType As System.Windows.Forms.Label
    Friend WithEvents cboDocumentType As System.Windows.Forms.ComboBox
    Friend WithEvents lblCopies As System.Windows.Forms.Label
    Friend WithEvents pnlCopiesBox As System.Windows.Forms.Panel
    Friend WithEvents txtCopies As System.Windows.Forms.TextBox
    Friend WithEvents lblPurpose As System.Windows.Forms.Label
    Friend WithEvents cboPurpose As System.Windows.Forms.ComboBox
    Friend WithEvents lblDateNeeded As System.Windows.Forms.Label
    Friend WithEvents dtpDateNeeded As System.Windows.Forms.DateTimePicker
    Friend WithEvents lblAmountDue As System.Windows.Forms.Label
    Friend WithEvents pnlAmountDueBox As System.Windows.Forms.Panel
    Friend WithEvents txtAmountDue As System.Windows.Forms.TextBox
    Friend WithEvents lblPaymentStatus As System.Windows.Forms.Label
    Friend WithEvents cboPaymentStatus As System.Windows.Forms.ComboBox
    Friend WithEvents pnlActionButtons As System.Windows.Forms.Panel
    Friend WithEvents btnCancel As System.Windows.Forms.Button
    Friend WithEvents btnSubmitRequest As System.Windows.Forms.Button
    Friend WithEvents pnlLogoArea As Panel
    Friend WithEvents pnlLogo As Panel
    Friend WithEvents picLogo As PictureBox
    Friend WithEvents lblLogo As Label

End Class



