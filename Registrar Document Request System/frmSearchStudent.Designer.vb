<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmSearchStudent
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmSearchStudent))
        Dim DataGridViewCellStyle1 As DataGridViewCellStyle = New DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As DataGridViewCellStyle = New DataGridViewCellStyle()
        Dim DataGridViewCellStyle4 As DataGridViewCellStyle = New DataGridViewCellStyle()
        Dim DataGridViewCellStyle3 As DataGridViewCellStyle = New DataGridViewCellStyle()
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
        pnlTableCard = New Panel()
        pnlTableFooter = New Panel()
        lblPagination = New Label()
        btnPrev = New Button()
        btnPage1 = New Button()
        btnPage2 = New Button()
        btnNext = New Button()
        dgvStudents = New DataGridView()
        colAction = New DataGridViewTextBoxColumn()
        lblResultInfo = New Label()
        lblTableTitle = New Label()
        pnlSearchFilter = New Panel()
        btnReset = New Button()
        cboStatusFilter = New ComboBox()
        cboCourseFilter = New ComboBox()
        btnSearch = New Button()
        txtSearch = New TextBox()
        lblSearchPrompt = New Label()
        lblSubtitle = New Label()
        lblTitle = New Label()
        pnlSidebar.SuspendLayout()
        pnlLogout.SuspendLayout()
        pnlLogoArea.SuspendLayout()
        pnlLogo.SuspendLayout()
        CType(picLogo, ComponentModel.ISupportInitialize).BeginInit()
        pnlContent.SuspendLayout()
        pnlTableCard.SuspendLayout()
        pnlTableFooter.SuspendLayout()
        CType(dgvStudents, ComponentModel.ISupportInitialize).BeginInit()
        pnlSearchFilter.SuspendLayout()
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
        btnNewRequest.Font = New Font("Segoe UI", 10F)
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
        pnlLogo.TabIndex = 2
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
        pnlContent.Controls.Add(pnlTableCard)
        pnlContent.Controls.Add(pnlSearchFilter)
        pnlContent.Controls.Add(lblSubtitle)
        pnlContent.Controls.Add(lblTitle)
        pnlContent.Dock = DockStyle.Fill
        pnlContent.Location = New Point(230, 0)
        pnlContent.Name = "pnlContent"
        pnlContent.Size = New Size(970, 800)
        pnlContent.TabIndex = 1
        ' 
        ' pnlTableCard
        ' 
        pnlTableCard.Anchor = AnchorStyles.Top Or AnchorStyles.Bottom Or AnchorStyles.Left Or AnchorStyles.Right
        pnlTableCard.BackColor = Color.FromArgb(CByte(26), CByte(46), CByte(99))
        pnlTableCard.Controls.Add(pnlTableFooter)
        pnlTableCard.Controls.Add(dgvStudents)
        pnlTableCard.Controls.Add(lblResultInfo)
        pnlTableCard.Controls.Add(lblTableTitle)
        pnlTableCard.Location = New Point(30, 170)
        pnlTableCard.Name = "pnlTableCard"
        pnlTableCard.Size = New Size(910, 600)
        pnlTableCard.TabIndex = 3
        ' 
        ' pnlTableFooter
        ' 
        pnlTableFooter.BackColor = Color.FromArgb(CByte(20), CByte(36), CByte(78))
        pnlTableFooter.Controls.Add(lblPagination)
        pnlTableFooter.Controls.Add(btnPrev)
        pnlTableFooter.Controls.Add(btnPage1)
        pnlTableFooter.Controls.Add(btnPage2)
        pnlTableFooter.Controls.Add(btnNext)
        pnlTableFooter.Dock = DockStyle.Bottom
        pnlTableFooter.Location = New Point(0, 552)
        pnlTableFooter.Name = "pnlTableFooter"
        pnlTableFooter.Size = New Size(910, 48)
        pnlTableFooter.TabIndex = 3
        ' 
        ' lblPagination
        ' 
        lblPagination.AutoSize = True
        lblPagination.Font = New Font("Segoe UI", 9F)
        lblPagination.ForeColor = Color.FromArgb(CByte(160), CByte(174), CByte(192))
        lblPagination.Location = New Point(20, 16)
        lblPagination.Name = "lblPagination"
        lblPagination.Size = New Size(156, 15)
        lblPagination.TabIndex = 0
        lblPagination.Text = "Showing 1 to 5 of 24 records"
        ' 
        ' btnPrev
        ' 
        btnPrev.Anchor = AnchorStyles.Top Or AnchorStyles.Right
        btnPrev.BackColor = Color.FromArgb(CByte(26), CByte(46), CByte(99))
        btnPrev.Cursor = Cursors.Hand
        btnPrev.FlatAppearance.BorderSize = 0
        btnPrev.FlatStyle = FlatStyle.Flat
        btnPrev.Font = New Font("Segoe UI", 8.5F)
        btnPrev.ForeColor = Color.White
        btnPrev.Location = New Point(670, 10)
        btnPrev.Name = "btnPrev"
        btnPrev.Size = New Size(65, 28)
        btnPrev.TabIndex = 1
        btnPrev.Text = "Prev"
        btnPrev.UseVisualStyleBackColor = False
        ' 
        ' btnPage1
        ' 
        btnPage1.Anchor = AnchorStyles.Top Or AnchorStyles.Right
        btnPage1.BackColor = Color.FromArgb(CByte(245), CByte(197), CByte(24))
        btnPage1.Cursor = Cursors.Hand
        btnPage1.FlatAppearance.BorderSize = 0
        btnPage1.FlatStyle = FlatStyle.Flat
        btnPage1.Font = New Font("Segoe UI", 8.5F, FontStyle.Bold)
        btnPage1.ForeColor = Color.FromArgb(CByte(15), CByte(31), CByte(76))
        btnPage1.Location = New Point(745, 10)
        btnPage1.Name = "btnPage1"
        btnPage1.Size = New Size(32, 28)
        btnPage1.TabIndex = 2
        btnPage1.Text = "1"
        btnPage1.UseVisualStyleBackColor = False
        ' 
        ' btnPage2
        ' 
        btnPage2.Anchor = AnchorStyles.Top Or AnchorStyles.Right
        btnPage2.BackColor = Color.FromArgb(CByte(26), CByte(46), CByte(99))
        btnPage2.Cursor = Cursors.Hand
        btnPage2.FlatAppearance.BorderSize = 0
        btnPage2.FlatStyle = FlatStyle.Flat
        btnPage2.Font = New Font("Segoe UI", 8.5F)
        btnPage2.ForeColor = Color.White
        btnPage2.Location = New Point(785, 10)
        btnPage2.Name = "btnPage2"
        btnPage2.Size = New Size(32, 28)
        btnPage2.TabIndex = 3
        btnPage2.Text = "2"
        btnPage2.UseVisualStyleBackColor = False
        ' 
        ' btnNext
        ' 
        btnNext.Anchor = AnchorStyles.Top Or AnchorStyles.Right
        btnNext.BackColor = Color.FromArgb(CByte(26), CByte(46), CByte(99))
        btnNext.Cursor = Cursors.Hand
        btnNext.FlatAppearance.BorderSize = 0
        btnNext.FlatStyle = FlatStyle.Flat
        btnNext.Font = New Font("Segoe UI", 8.5F)
        btnNext.ForeColor = Color.White
        btnNext.Location = New Point(825, 10)
        btnNext.Name = "btnNext"
        btnNext.Size = New Size(65, 28)
        btnNext.TabIndex = 4
        btnNext.Text = "Next"
        btnNext.UseVisualStyleBackColor = False
        ' 
        ' dgvStudents
        ' 
        dgvStudents.AllowUserToAddRows = False
        dgvStudents.AllowUserToDeleteRows = False
        dgvStudents.AllowUserToResizeRows = False
        DataGridViewCellStyle1.BackColor = Color.FromArgb(CByte(21), CByte(38), CByte(84))
        DataGridViewCellStyle1.Font = New Font("Segoe UI", 9.5F)
        DataGridViewCellStyle1.ForeColor = Color.White
        DataGridViewCellStyle1.SelectionBackColor = Color.FromArgb(CByte(39), CByte(60), CByte(117))
        DataGridViewCellStyle1.SelectionForeColor = Color.White
        dgvStudents.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle1
        dgvStudents.Anchor = AnchorStyles.Top Or AnchorStyles.Bottom Or AnchorStyles.Left Or AnchorStyles.Right
        dgvStudents.BackgroundColor = Color.FromArgb(CByte(26), CByte(46), CByte(99))
        dgvStudents.BorderStyle = BorderStyle.None
        dgvStudents.CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal
        dgvStudents.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None
        DataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle2.BackColor = Color.FromArgb(CByte(26), CByte(46), CByte(99))
        DataGridViewCellStyle2.Font = New Font("Segoe UI", 9F, FontStyle.Bold)
        DataGridViewCellStyle2.ForeColor = Color.FromArgb(CByte(160), CByte(174), CByte(192))
        DataGridViewCellStyle2.SelectionBackColor = Color.FromArgb(CByte(26), CByte(46), CByte(99))
        DataGridViewCellStyle2.SelectionForeColor = Color.FromArgb(CByte(160), CByte(174), CByte(192))
        DataGridViewCellStyle2.WrapMode = DataGridViewTriState.True
        dgvStudents.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle2
        dgvStudents.ColumnHeadersHeight = 40
        dgvStudents.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.DisableResizing
        dgvStudents.Columns.AddRange(New DataGridViewColumn() {colAction})
        DataGridViewCellStyle4.Alignment = DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle4.BackColor = Color.FromArgb(CByte(26), CByte(46), CByte(99))
        DataGridViewCellStyle4.Font = New Font("Segoe UI", 9.5F)
        DataGridViewCellStyle4.ForeColor = Color.White
        DataGridViewCellStyle4.SelectionBackColor = Color.FromArgb(CByte(39), CByte(60), CByte(117))
        DataGridViewCellStyle4.SelectionForeColor = Color.White
        DataGridViewCellStyle4.WrapMode = DataGridViewTriState.False
        dgvStudents.DefaultCellStyle = DataGridViewCellStyle4
        dgvStudents.EnableHeadersVisualStyles = False
        dgvStudents.GridColor = Color.FromArgb(CByte(39), CByte(60), CByte(117))
        dgvStudents.Location = New Point(20, 55)
        dgvStudents.MultiSelect = False
        dgvStudents.Name = "dgvStudents"
        dgvStudents.ReadOnly = True
        dgvStudents.RowHeadersVisible = False
        dgvStudents.RowTemplate.Height = 42
        dgvStudents.SelectionMode = DataGridViewSelectionMode.FullRowSelect
        dgvStudents.Size = New Size(870, 480)
        dgvStudents.TabIndex = 2
        ' 
        ' colAction
        ' 
        DataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle3.Font = New Font("Segoe UI", 10F, FontStyle.Bold)
        DataGridViewCellStyle3.ForeColor = Color.FromArgb(CByte(160), CByte(174), CByte(192))
        DataGridViewCellStyle3.NullValue = "..."
        colAction.DefaultCellStyle = DataGridViewCellStyle3
        colAction.HeaderText = "ACTION"
        colAction.Name = "colAction"
        colAction.ReadOnly = True
        colAction.Width = 80
        ' 
        ' lblResultInfo
        ' 
        lblResultInfo.AutoSize = True
        lblResultInfo.Font = New Font("Segoe UI", 9F)
        lblResultInfo.ForeColor = Color.FromArgb(CByte(160), CByte(174), CByte(192))
        lblResultInfo.Location = New Point(170, 21)
        lblResultInfo.Name = "lblResultInfo"
        lblResultInfo.Size = New Size(208, 15)
        lblResultInfo.TabIndex = 1
        lblResultInfo.Text = "Showing all registered student profiles"
        ' 
        ' lblTableTitle
        ' 
        lblTableTitle.AutoSize = True
        lblTableTitle.Font = New Font("Segoe UI", 12F, FontStyle.Bold)
        lblTableTitle.ForeColor = Color.White
        lblTableTitle.Location = New Point(20, 17)
        lblTableTitle.Name = "lblTableTitle"
        lblTableTitle.Size = New Size(134, 21)
        lblTableTitle.TabIndex = 0
        lblTableTitle.Text = "Student Records"
        ' 
        ' pnlSearchFilter
        ' 
        pnlSearchFilter.Anchor = AnchorStyles.Top Or AnchorStyles.Left Or AnchorStyles.Right
        pnlSearchFilter.BackColor = Color.FromArgb(CByte(15), CByte(31), CByte(76))
        pnlSearchFilter.Controls.Add(btnReset)
        pnlSearchFilter.Controls.Add(cboStatusFilter)
        pnlSearchFilter.Controls.Add(cboCourseFilter)
        pnlSearchFilter.Controls.Add(btnSearch)
        pnlSearchFilter.Controls.Add(txtSearch)
        pnlSearchFilter.Controls.Add(lblSearchPrompt)
        pnlSearchFilter.Location = New Point(30, 95)
        pnlSearchFilter.Name = "pnlSearchFilter"
        pnlSearchFilter.Size = New Size(910, 60)
        pnlSearchFilter.TabIndex = 2
        ' 
        ' btnReset
        ' 
        btnReset.BackColor = Color.Red
        btnReset.Cursor = Cursors.Hand
        btnReset.FlatAppearance.BorderColor = Color.FromArgb(CByte(45), CByte(68), CByte(125))
        btnReset.FlatStyle = FlatStyle.Flat
        btnReset.Font = New Font("Segoe UI", 10F, FontStyle.Bold)
        btnReset.ForeColor = Color.White
        btnReset.Location = New Point(730, 14)
        btnReset.Name = "btnReset"
        btnReset.Size = New Size(65, 32)
        btnReset.TabIndex = 5
        btnReset.Text = "Clear"
        btnReset.UseVisualStyleBackColor = False
        ' 
        ' cboStatusFilter
        ' 
        cboStatusFilter.BackColor = Color.FromArgb(CByte(26), CByte(46), CByte(99))
        cboStatusFilter.DropDownStyle = ComboBoxStyle.DropDownList
        cboStatusFilter.FlatStyle = FlatStyle.Flat
        cboStatusFilter.Font = New Font("Segoe UI", 9.5F)
        cboStatusFilter.ForeColor = Color.White
        cboStatusFilter.FormattingEnabled = True
        cboStatusFilter.Items.AddRange(New Object() {"All Status", "Enrolled", "Graduated", "Undergraduate", "Inactive"})
        cboStatusFilter.Location = New Point(595, 17)
        cboStatusFilter.Name = "cboStatusFilter"
        cboStatusFilter.Size = New Size(125, 25)
        cboStatusFilter.TabIndex = 4
        ' 
        ' cboCourseFilter
        ' 
        cboCourseFilter.BackColor = Color.FromArgb(CByte(26), CByte(46), CByte(99))
        cboCourseFilter.DropDownStyle = ComboBoxStyle.DropDownList
        cboCourseFilter.FlatStyle = FlatStyle.Flat
        cboCourseFilter.Font = New Font("Segoe UI", 9.5F)
        cboCourseFilter.ForeColor = Color.White
        cboCourseFilter.FormattingEnabled = True
        cboCourseFilter.Items.AddRange(New Object() {"All Courses", "BSIT", "BSCS", "BSIS", "BSEd"})
        cboCourseFilter.Location = New Point(460, 17)
        cboCourseFilter.Name = "cboCourseFilter"
        cboCourseFilter.Size = New Size(125, 25)
        cboCourseFilter.TabIndex = 3
        ' 
        ' btnSearch
        ' 
        btnSearch.BackColor = Color.FromArgb(CByte(245), CByte(197), CByte(24))
        btnSearch.Cursor = Cursors.Hand
        btnSearch.FlatAppearance.BorderSize = 0
        btnSearch.FlatStyle = FlatStyle.Flat
        btnSearch.Font = New Font("Segoe UI", 10F, FontStyle.Bold)
        btnSearch.ForeColor = Color.FromArgb(CByte(15), CByte(31), CByte(76))
        btnSearch.Location = New Point(365, 14)
        btnSearch.Name = "btnSearch"
        btnSearch.Size = New Size(85, 32)
        btnSearch.TabIndex = 2
        btnSearch.Text = "Search"
        btnSearch.UseVisualStyleBackColor = False
        ' 
        ' txtSearch
        ' 
        txtSearch.BackColor = Color.FromArgb(CByte(26), CByte(46), CByte(99))
        txtSearch.BorderStyle = BorderStyle.FixedSingle
        txtSearch.Font = New Font("Segoe UI", 10.5F)
        txtSearch.ForeColor = Color.White
        txtSearch.Location = New Point(75, 16)
        txtSearch.Name = "txtSearch"
        txtSearch.PlaceholderText = "Search student number, name..."
        txtSearch.Size = New Size(280, 26)
        txtSearch.TabIndex = 1
        ' 
        ' lblSearchPrompt
        ' 
        lblSearchPrompt.AutoSize = True
        lblSearchPrompt.Font = New Font("Segoe UI", 9F, FontStyle.Bold)
        lblSearchPrompt.ForeColor = Color.FromArgb(CByte(245), CByte(197), CByte(24))
        lblSearchPrompt.Location = New Point(15, 21)
        lblSearchPrompt.Name = "lblSearchPrompt"
        lblSearchPrompt.Size = New Size(55, 15)
        lblSearchPrompt.TabIndex = 0
        lblSearchPrompt.Text = "SEARCH:"
        ' 
        ' lblSubtitle
        ' 
        lblSubtitle.AutoSize = True
        lblSubtitle.Font = New Font("Segoe UI", 9.5F)
        lblSubtitle.ForeColor = Color.FromArgb(CByte(160), CByte(174), CByte(192))
        lblSubtitle.Location = New Point(30, 62)
        lblSubtitle.Name = "lblSubtitle"
        lblSubtitle.Size = New Size(376, 17)
        lblSubtitle.TabIndex = 1
        lblSubtitle.Text = "Search and view student records, enrollment status, and details"
        ' 
        ' lblTitle
        ' 
        lblTitle.AutoSize = True
        lblTitle.Font = New Font("Segoe UI", 18F, FontStyle.Bold)
        lblTitle.ForeColor = Color.White
        lblTitle.Location = New Point(30, 25)
        lblTitle.Name = "lblTitle"
        lblTitle.Size = New Size(184, 32)
        lblTitle.TabIndex = 0
        lblTitle.Text = "Search Student"
        ' 
        ' frmSearchStudent
        ' 
        AcceptButton = btnSearch
        AutoScaleDimensions = New SizeF(7F, 17F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.FromArgb(CByte(15), CByte(31), CByte(76))
        ClientSize = New Size(1200, 800)
        Controls.Add(pnlContent)
        Controls.Add(pnlSidebar)
        Font = New Font("Segoe UI", 9.5F)
        MinimumSize = New Size(1024, 700)
        Name = "frmSearchStudent"
        StartPosition = FormStartPosition.CenterScreen
        Text = "Registrar Document Request System - Search Student"
        WindowState = FormWindowState.Maximized
        pnlSidebar.ResumeLayout(False)
        pnlLogout.ResumeLayout(False)
        pnlLogoArea.ResumeLayout(False)
        pnlLogo.ResumeLayout(False)
        pnlLogo.PerformLayout()
        CType(picLogo, ComponentModel.ISupportInitialize).EndInit()
        pnlContent.ResumeLayout(False)
        pnlContent.PerformLayout()
        pnlTableCard.ResumeLayout(False)
        pnlTableCard.PerformLayout()
        pnlTableFooter.ResumeLayout(False)
        pnlTableFooter.PerformLayout()
        CType(dgvStudents, ComponentModel.ISupportInitialize).EndInit()
        pnlSearchFilter.ResumeLayout(False)
        pnlSearchFilter.PerformLayout()
        ResumeLayout(False)

    End Sub

    Friend WithEvents pnlSidebar As System.Windows.Forms.Panel
    Friend WithEvents pnlLogoArea As System.Windows.Forms.Panel
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
    Friend WithEvents pnlSearchFilter As System.Windows.Forms.Panel
    Friend WithEvents lblSearchPrompt As System.Windows.Forms.Label
    Friend WithEvents txtSearch As System.Windows.Forms.TextBox
    Friend WithEvents btnSearch As System.Windows.Forms.Button
    Friend WithEvents cboCourseFilter As System.Windows.Forms.ComboBox
    Friend WithEvents cboStatusFilter As System.Windows.Forms.ComboBox
    Friend WithEvents btnReset As System.Windows.Forms.Button
    Friend WithEvents pnlTableCard As System.Windows.Forms.Panel
    Friend WithEvents lblTableTitle As System.Windows.Forms.Label
    Friend WithEvents lblResultInfo As System.Windows.Forms.Label
    Friend WithEvents dgvStudents As System.Windows.Forms.DataGridView
    Friend WithEvents colStudentNo As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents colFullName As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents colCourse As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents colYearLevel As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents colContactNo As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents colStatus As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents colAction As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents pnlTableFooter As System.Windows.Forms.Panel
    Friend WithEvents lblPagination As System.Windows.Forms.Label
    Friend WithEvents btnPrev As System.Windows.Forms.Button
    Friend WithEvents btnPage1 As System.Windows.Forms.Button
    Friend WithEvents btnPage2 As System.Windows.Forms.Button
    Friend WithEvents btnNext As System.Windows.Forms.Button
    Friend WithEvents pnlLogo As Panel
    Friend WithEvents picLogo As PictureBox
    Friend WithEvents lblLogo As Label

End Class



