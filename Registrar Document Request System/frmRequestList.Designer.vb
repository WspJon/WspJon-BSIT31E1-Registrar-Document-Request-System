<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmRequestList
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmRequestList))
        Dim DataGridViewCellStyle15 As DataGridViewCellStyle = New DataGridViewCellStyle()
        Dim DataGridViewCellStyle16 As DataGridViewCellStyle = New DataGridViewCellStyle()
        Dim DataGridViewCellStyle21 As DataGridViewCellStyle = New DataGridViewCellStyle()
        Dim DataGridViewCellStyle17 As DataGridViewCellStyle = New DataGridViewCellStyle()
        Dim DataGridViewCellStyle18 As DataGridViewCellStyle = New DataGridViewCellStyle()
        Dim DataGridViewCellStyle19 As DataGridViewCellStyle = New DataGridViewCellStyle()
        Dim DataGridViewCellStyle20 As DataGridViewCellStyle = New DataGridViewCellStyle()
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
        btnHeaderOptions = New Button()
        pnlTableCard = New Panel()
        dgvRequests = New DataGridView()
        colRequestNo = New DataGridViewTextBoxColumn()
        colStudent = New DataGridViewTextBoxColumn()
        colDocument = New DataGridViewTextBoxColumn()
        colPayment = New DataGridViewTextBoxColumn()
        colStatus = New DataGridViewTextBoxColumn()
        colAction = New DataGridViewTextBoxColumn()
        pnlTableFooter = New Panel()
        pnlFooterDivider = New Panel()
        lblPagination = New Label()
        btnPrev = New Button()
        btnPage1 = New Button()
        btnPage2 = New Button()
        btnNext = New Button()
        pnlSearchFilter = New Panel()
        cboDateFilter = New ComboBox()
        cboDocumentFilter = New ComboBox()
        cboStatusFilter = New ComboBox()
        pnlSearchBox = New Panel()
        lblSearchIcon = New Label()
        txtSearch = New TextBox()
        lblSubtitle = New Label()
        lblTitle = New Label()
        pnlSidebar.SuspendLayout()
        pnlLogout.SuspendLayout()
        pnlLogoArea.SuspendLayout()
        pnlLogo.SuspendLayout()
        CType(picLogo, ComponentModel.ISupportInitialize).BeginInit()
        pnlContent.SuspendLayout()
        pnlTableCard.SuspendLayout()
        CType(dgvRequests, ComponentModel.ISupportInitialize).BeginInit()
        pnlTableFooter.SuspendLayout()
        pnlSearchFilter.SuspendLayout()
        pnlSearchBox.SuspendLayout()
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
        pnlSidebar.Margin = New Padding(3, 4, 3, 4)
        pnlSidebar.Name = "pnlSidebar"
        pnlSidebar.Size = New Size(263, 1055)
        pnlSidebar.TabIndex = 0
        ' 
        ' pnlLogout
        ' 
        pnlLogout.BackColor = Color.Transparent
        pnlLogout.Controls.Add(btnLogout)
        pnlLogout.Dock = DockStyle.Bottom
        pnlLogout.Location = New Point(0, 962)
        pnlLogout.Margin = New Padding(3, 4, 3, 4)
        pnlLogout.Name = "pnlLogout"
        pnlLogout.Size = New Size(263, 93)
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
        btnLogout.Margin = New Padding(3, 4, 3, 4)
        btnLogout.Name = "btnLogout"
        btnLogout.Padding = New Padding(27, 0, 0, 0)
        btnLogout.Size = New Size(263, 93)
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
        btnReports.Location = New Point(0, 433)
        btnReports.Margin = New Padding(3, 4, 3, 4)
        btnReports.Name = "btnReports"
        btnReports.Padding = New Padding(27, 0, 0, 0)
        btnReports.Size = New Size(263, 80)
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
        btnSearchStudent.Location = New Point(0, 353)
        btnSearchStudent.Margin = New Padding(3, 4, 3, 4)
        btnSearchStudent.Name = "btnSearchStudent"
        btnSearchStudent.Padding = New Padding(27, 0, 0, 0)
        btnSearchStudent.Size = New Size(263, 80)
        btnSearchStudent.TabIndex = 4
        btnSearchStudent.Text = "Search student"
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
        btnRequestList.Location = New Point(0, 273)
        btnRequestList.Margin = New Padding(3, 4, 3, 4)
        btnRequestList.Name = "btnRequestList"
        btnRequestList.Padding = New Padding(27, 0, 0, 0)
        btnRequestList.Size = New Size(263, 80)
        btnRequestList.TabIndex = 3
        btnRequestList.Text = "Request list"
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
        btnNewRequest.Location = New Point(0, 193)
        btnNewRequest.Margin = New Padding(3, 4, 3, 4)
        btnNewRequest.Name = "btnNewRequest"
        btnNewRequest.Padding = New Padding(27, 0, 0, 0)
        btnNewRequest.Size = New Size(263, 80)
        btnNewRequest.TabIndex = 2
        btnNewRequest.Text = "New request"
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
        btnDashboard.Location = New Point(0, 113)
        btnDashboard.Margin = New Padding(3, 4, 3, 4)
        btnDashboard.Name = "btnDashboard"
        btnDashboard.Padding = New Padding(27, 0, 0, 0)
        btnDashboard.Size = New Size(263, 80)
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
        pnlLogoArea.Margin = New Padding(3, 4, 3, 4)
        pnlLogoArea.Name = "pnlLogoArea"
        pnlLogoArea.Size = New Size(263, 113)
        pnlLogoArea.TabIndex = 0
        ' 
        ' pnlLogo
        ' 
        pnlLogo.Controls.Add(picLogo)
        pnlLogo.Controls.Add(lblLogo)
        pnlLogo.Dock = DockStyle.Top
        pnlLogo.Location = New Point(0, 0)
        pnlLogo.Margin = New Padding(3, 4, 3, 4)
        pnlLogo.Name = "pnlLogo"
        pnlLogo.Size = New Size(263, 80)
        pnlLogo.TabIndex = 5
        ' 
        ' picLogo
        ' 
        picLogo.BackColor = Color.FromArgb(CByte(15), CByte(31), CByte(76))
        picLogo.Image = CType(resources.GetObject("picLogo.Image"), Image)
        picLogo.Location = New Point(11, 16)
        picLogo.Margin = New Padding(3, 4, 3, 4)
        picLogo.Name = "picLogo"
        picLogo.Size = New Size(48, 56)
        picLogo.SizeMode = PictureBoxSizeMode.Zoom
        picLogo.TabIndex = 0
        picLogo.TabStop = False
        ' 
        ' lblLogo
        ' 
        lblLogo.AutoSize = True
        lblLogo.Font = New Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        lblLogo.ForeColor = Color.FromArgb(CByte(15), CByte(31), CByte(76))
        lblLogo.Location = New Point(66, 33)
        lblLogo.Name = "lblLogo"
        lblLogo.Size = New Size(146, 23)
        lblLogo.TabIndex = 0
        lblLogo.Text = "Registrar System"
        ' 
        ' pnlContent
        ' 
        pnlContent.BackColor = Color.FromArgb(CByte(15), CByte(31), CByte(76))
        pnlContent.Controls.Add(btnHeaderOptions)
        pnlContent.Controls.Add(pnlTableCard)
        pnlContent.Controls.Add(pnlSearchFilter)
        pnlContent.Controls.Add(lblSubtitle)
        pnlContent.Controls.Add(lblTitle)
        pnlContent.Dock = DockStyle.Fill
        pnlContent.Location = New Point(263, 0)
        pnlContent.Margin = New Padding(3, 4, 3, 4)
        pnlContent.Name = "pnlContent"
        pnlContent.Size = New Size(1108, 1055)
        pnlContent.TabIndex = 1
        ' 
        ' btnHeaderOptions
        ' 
        btnHeaderOptions.Anchor = AnchorStyles.Top Or AnchorStyles.Right
        btnHeaderOptions.BackColor = Color.FromArgb(CByte(22), CByte(32), CByte(74))
        btnHeaderOptions.Cursor = Cursors.Hand
        btnHeaderOptions.FlatAppearance.BorderSize = 0
        btnHeaderOptions.FlatStyle = FlatStyle.Flat
        btnHeaderOptions.Font = New Font("Segoe UI", 9F, FontStyle.Bold)
        btnHeaderOptions.ForeColor = Color.FromArgb(CByte(160), CByte(174), CByte(192))
        btnHeaderOptions.Location = New Point(1032, 27)
        btnHeaderOptions.Margin = New Padding(3, 4, 3, 4)
        btnHeaderOptions.Name = "btnHeaderOptions"
        btnHeaderOptions.Size = New Size(41, 43)
        btnHeaderOptions.TabIndex = 4
        btnHeaderOptions.Text = "•••"
        btnHeaderOptions.UseVisualStyleBackColor = False
        ' 
        ' pnlTableCard
        ' 
        pnlTableCard.Anchor = AnchorStyles.Top Or AnchorStyles.Bottom Or AnchorStyles.Left Or AnchorStyles.Right
        pnlTableCard.BackColor = Color.FromArgb(CByte(26), CByte(46), CByte(99))
        pnlTableCard.Controls.Add(dgvRequests)
        pnlTableCard.Controls.Add(pnlTableFooter)
        pnlTableCard.Location = New Point(34, 200)
        pnlTableCard.Margin = New Padding(3, 4, 3, 4)
        pnlTableCard.Name = "pnlTableCard"
        pnlTableCard.Size = New Size(1039, 815)
        pnlTableCard.TabIndex = 3
        ' 
        ' dgvRequests
        ' 
        dgvRequests.AllowUserToAddRows = False
        dgvRequests.AllowUserToDeleteRows = False
        dgvRequests.AllowUserToResizeRows = False
        DataGridViewCellStyle15.BackColor = Color.FromArgb(CByte(21), CByte(38), CByte(84))
        DataGridViewCellStyle15.Font = New Font("Segoe UI", 9.5F)
        DataGridViewCellStyle15.ForeColor = Color.White
        DataGridViewCellStyle15.SelectionBackColor = Color.FromArgb(CByte(39), CByte(60), CByte(117))
        DataGridViewCellStyle15.SelectionForeColor = Color.White
        dgvRequests.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle15
        dgvRequests.Anchor = AnchorStyles.Top Or AnchorStyles.Bottom Or AnchorStyles.Left Or AnchorStyles.Right
        dgvRequests.BackgroundColor = Color.FromArgb(CByte(26), CByte(46), CByte(99))
        dgvRequests.BorderStyle = BorderStyle.None
        dgvRequests.CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal
        dgvRequests.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None
        DataGridViewCellStyle16.Alignment = DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle16.BackColor = Color.FromArgb(CByte(26), CByte(46), CByte(99))
        DataGridViewCellStyle16.Font = New Font("Segoe UI", 9F, FontStyle.Bold)
        DataGridViewCellStyle16.ForeColor = Color.FromArgb(CByte(160), CByte(174), CByte(192))
        DataGridViewCellStyle16.SelectionBackColor = Color.FromArgb(CByte(26), CByte(46), CByte(99))
        DataGridViewCellStyle16.SelectionForeColor = Color.FromArgb(CByte(160), CByte(174), CByte(192))
        DataGridViewCellStyle16.WrapMode = DataGridViewTriState.False
        dgvRequests.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle16
        dgvRequests.ColumnHeadersHeight = 42
        dgvRequests.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.DisableResizing
        dgvRequests.Columns.AddRange(New DataGridViewColumn() {colRequestNo, colStudent, colDocument, colPayment, colStatus, colAction})
        DataGridViewCellStyle21.Alignment = DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle21.BackColor = Color.FromArgb(CByte(26), CByte(46), CByte(99))
        DataGridViewCellStyle21.Font = New Font("Segoe UI", 9.5F)
        DataGridViewCellStyle21.ForeColor = Color.White
        DataGridViewCellStyle21.SelectionBackColor = Color.FromArgb(CByte(39), CByte(60), CByte(117))
        DataGridViewCellStyle21.SelectionForeColor = Color.White
        DataGridViewCellStyle21.WrapMode = DataGridViewTriState.False
        dgvRequests.DefaultCellStyle = DataGridViewCellStyle21
        dgvRequests.EnableHeadersVisualStyles = False
        dgvRequests.GridColor = Color.FromArgb(CByte(39), CByte(60), CByte(117))
        dgvRequests.Location = New Point(18, 16)
        dgvRequests.Margin = New Padding(3, 4, 3, 4)
        dgvRequests.MultiSelect = False
        dgvRequests.Name = "dgvRequests"
        dgvRequests.ReadOnly = True
        dgvRequests.RowHeadersVisible = False
        dgvRequests.RowHeadersWidth = 51
        dgvRequests.RowTemplate.Height = 42
        dgvRequests.SelectionMode = DataGridViewSelectionMode.FullRowSelect
        dgvRequests.Size = New Size(1002, 721)
        dgvRequests.TabIndex = 2
        ' 
        ' colRequestNo
        ' 
        DataGridViewCellStyle17.Font = New Font("Segoe UI", 9.5F, FontStyle.Bold)
        colRequestNo.DefaultCellStyle = DataGridViewCellStyle17
        colRequestNo.HeaderText = "REQUEST NO."
        colRequestNo.MinimumWidth = 6
        colRequestNo.Name = "colRequestNo"
        colRequestNo.ReadOnly = True
        colRequestNo.Width = 145
        ' 
        ' colStudent
        ' 
        colStudent.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill
        colStudent.HeaderText = "STUDENT"
        colStudent.MinimumWidth = 140
        colStudent.Name = "colStudent"
        colStudent.ReadOnly = True
        ' 
        ' colDocument
        ' 
        colDocument.HeaderText = "DOCUMENT"
        colDocument.MinimumWidth = 6
        colDocument.Name = "colDocument"
        colDocument.ReadOnly = True
        colDocument.Width = 135
        ' 
        ' colPayment
        ' 
        DataGridViewCellStyle18.Font = New Font("Segoe UI", 9.5F, FontStyle.Bold)
        colPayment.DefaultCellStyle = DataGridViewCellStyle18
        colPayment.HeaderText = "PAYMENT"
        colPayment.MinimumWidth = 6
        colPayment.Name = "colPayment"
        colPayment.ReadOnly = True
        colPayment.Width = 110
        ' 
        ' colStatus
        ' 
        DataGridViewCellStyle19.Alignment = DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle19.Font = New Font("Segoe UI", 8.5F, FontStyle.Bold)
        colStatus.DefaultCellStyle = DataGridViewCellStyle19
        colStatus.HeaderText = "STATUS"
        colStatus.MinimumWidth = 6
        colStatus.Name = "colStatus"
        colStatus.ReadOnly = True
        colStatus.Width = 120
        ' 
        ' colAction
        ' 
        DataGridViewCellStyle20.Alignment = DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle20.Font = New Font("Segoe UI", 10F, FontStyle.Bold)
        DataGridViewCellStyle20.ForeColor = Color.FromArgb(CByte(160), CByte(174), CByte(192))
        DataGridViewCellStyle20.NullValue = "..."
        colAction.DefaultCellStyle = DataGridViewCellStyle20
        colAction.HeaderText = "ACTION"
        colAction.MinimumWidth = 6
        colAction.Name = "colAction"
        colAction.ReadOnly = True
        colAction.Width = 80
        ' 
        ' pnlTableFooter
        ' 
        pnlTableFooter.BackColor = Color.FromArgb(CByte(20), CByte(36), CByte(78))
        pnlTableFooter.Controls.Add(pnlFooterDivider)
        pnlTableFooter.Controls.Add(lblPagination)
        pnlTableFooter.Controls.Add(btnPrev)
        pnlTableFooter.Controls.Add(btnPage1)
        pnlTableFooter.Controls.Add(btnPage2)
        pnlTableFooter.Controls.Add(btnNext)
        pnlTableFooter.Dock = DockStyle.Bottom
        pnlTableFooter.Location = New Point(0, 746)
        pnlTableFooter.Margin = New Padding(3, 4, 3, 4)
        pnlTableFooter.Name = "pnlTableFooter"
        pnlTableFooter.Size = New Size(1039, 69)
        pnlTableFooter.TabIndex = 3
        ' 
        ' pnlFooterDivider
        ' 
        pnlFooterDivider.BackColor = Color.FromArgb(CByte(39), CByte(60), CByte(117))
        pnlFooterDivider.Dock = DockStyle.Top
        pnlFooterDivider.Location = New Point(0, 0)
        pnlFooterDivider.Margin = New Padding(3, 4, 3, 4)
        pnlFooterDivider.Name = "pnlFooterDivider"
        pnlFooterDivider.Size = New Size(1039, 1)
        pnlFooterDivider.TabIndex = 5
        ' 
        ' lblPagination
        ' 
        lblPagination.AutoSize = True
        lblPagination.Font = New Font("Segoe UI", 9F)
        lblPagination.ForeColor = Color.FromArgb(CByte(160), CByte(174), CByte(192))
        lblPagination.Location = New Point(23, 24)
        lblPagination.Name = "lblPagination"
        lblPagination.Size = New Size(205, 20)
        lblPagination.TabIndex = 0
        lblPagination.Text = "Showing 1 to 5 of 24 requests"
        ' 
        ' btnPrev
        ' 
        btnPrev.Anchor = AnchorStyles.Top Or AnchorStyles.Right
        btnPrev.BackColor = Color.FromArgb(CByte(26), CByte(46), CByte(99))
        btnPrev.Cursor = Cursors.Hand
        btnPrev.FlatAppearance.BorderSize = 0
        btnPrev.FlatStyle = FlatStyle.Flat
        btnPrev.Font = New Font("Segoe UI", 8.5F)
        btnPrev.ForeColor = Color.FromArgb(CByte(160), CByte(174), CByte(192))
        btnPrev.Location = New Point(765, 16)
        btnPrev.Margin = New Padding(3, 4, 3, 4)
        btnPrev.Name = "btnPrev"
        btnPrev.Size = New Size(74, 37)
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
        btnPage1.Location = New Point(850, 16)
        btnPage1.Margin = New Padding(3, 4, 3, 4)
        btnPage1.Name = "btnPage1"
        btnPage1.Size = New Size(37, 37)
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
        btnPage2.Location = New Point(896, 16)
        btnPage2.Margin = New Padding(3, 4, 3, 4)
        btnPage2.Name = "btnPage2"
        btnPage2.Size = New Size(37, 37)
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
        btnNext.Location = New Point(942, 16)
        btnNext.Margin = New Padding(3, 4, 3, 4)
        btnNext.Name = "btnNext"
        btnNext.Size = New Size(74, 37)
        btnNext.TabIndex = 4
        btnNext.Text = "Next"
        btnNext.UseVisualStyleBackColor = False
        ' 
        ' pnlSearchFilter
        ' 
        pnlSearchFilter.Anchor = AnchorStyles.Top Or AnchorStyles.Left Or AnchorStyles.Right
        pnlSearchFilter.BackColor = Color.FromArgb(CByte(15), CByte(31), CByte(76))
        pnlSearchFilter.Controls.Add(cboDateFilter)
        pnlSearchFilter.Controls.Add(cboDocumentFilter)
        pnlSearchFilter.Controls.Add(cboStatusFilter)
        pnlSearchFilter.Controls.Add(pnlSearchBox)
        pnlSearchFilter.Location = New Point(34, 128)
        pnlSearchFilter.Margin = New Padding(3, 4, 3, 4)
        pnlSearchFilter.Name = "pnlSearchFilter"
        pnlSearchFilter.Size = New Size(1039, 56)
        pnlSearchFilter.TabIndex = 2
        ' 
        ' cboDateFilter
        ' 
        cboDateFilter.BackColor = Color.FromArgb(CByte(26), CByte(46), CByte(99))
        cboDateFilter.DropDownStyle = ComboBoxStyle.DropDownList
        cboDateFilter.FlatStyle = FlatStyle.Flat
        cboDateFilter.Font = New Font("Segoe UI", 9.5F)
        cboDateFilter.ForeColor = Color.White
        cboDateFilter.FormattingEnabled = True
        cboDateFilter.Items.AddRange(New Object() {"Date", "Today", "This week", "This month", "All time"})
        cboDateFilter.Location = New Point(686, 7)
        cboDateFilter.Margin = New Padding(3, 4, 3, 4)
        cboDateFilter.Name = "cboDateFilter"
        cboDateFilter.Size = New Size(108, 29)
        cboDateFilter.TabIndex = 3
        ' 
        ' cboDocumentFilter
        ' 
        cboDocumentFilter.BackColor = Color.FromArgb(CByte(26), CByte(46), CByte(99))
        cboDocumentFilter.DropDownStyle = ComboBoxStyle.DropDownList
        cboDocumentFilter.FlatStyle = FlatStyle.Flat
        cboDocumentFilter.Font = New Font("Segoe UI", 9.5F)
        cboDocumentFilter.ForeColor = Color.White
        cboDocumentFilter.FormattingEnabled = True
        cboDocumentFilter.Items.AddRange(New Object() {"Document", "TOR", "Good moral", "Diploma copy", "COR"})
        cboDocumentFilter.Location = New Point(531, 7)
        cboDocumentFilter.Margin = New Padding(3, 4, 3, 4)
        cboDocumentFilter.Name = "cboDocumentFilter"
        cboDocumentFilter.Size = New Size(142, 29)
        cboDocumentFilter.TabIndex = 2
        ' 
        ' cboStatusFilter
        ' 
        cboStatusFilter.BackColor = Color.FromArgb(CByte(26), CByte(46), CByte(99))
        cboStatusFilter.DropDownStyle = ComboBoxStyle.DropDownList
        cboStatusFilter.FlatStyle = FlatStyle.Flat
        cboStatusFilter.Font = New Font("Segoe UI", 9.5F)
        cboStatusFilter.ForeColor = Color.White
        cboStatusFilter.FormattingEnabled = True
        cboStatusFilter.Items.AddRange(New Object() {"Status: all", "Pending", "Ready", "Released", "Processing"})
        cboStatusFilter.Location = New Point(383, 7)
        cboStatusFilter.Margin = New Padding(3, 4, 3, 4)
        cboStatusFilter.Name = "cboStatusFilter"
        cboStatusFilter.Size = New Size(137, 29)
        cboStatusFilter.TabIndex = 1
        ' 
        ' pnlSearchBox
        ' 
        pnlSearchBox.BackColor = Color.FromArgb(CByte(22), CByte(32), CByte(74))
        pnlSearchBox.Controls.Add(lblSearchIcon)
        pnlSearchBox.Controls.Add(txtSearch)
        pnlSearchBox.Location = New Point(0, 4)
        pnlSearchBox.Margin = New Padding(3, 4, 3, 4)
        pnlSearchBox.Name = "pnlSearchBox"
        pnlSearchBox.Size = New Size(366, 40)
        pnlSearchBox.TabIndex = 0
        ' 
        ' lblSearchIcon
        ' 
        lblSearchIcon.Font = New Font("Segoe UI", 9.5F)
        lblSearchIcon.ForeColor = Color.FromArgb(CByte(131), CByte(175), CByte(214))
        lblSearchIcon.Location = New Point(7, 5)
        lblSearchIcon.Name = "lblSearchIcon"
        lblSearchIcon.Size = New Size(25, 29)
        lblSearchIcon.TabIndex = 0
        lblSearchIcon.Text = "🔍"
        lblSearchIcon.TextAlign = ContentAlignment.MiddleCenter
        ' 
        ' txtSearch
        ' 
        txtSearch.BackColor = Color.FromArgb(CByte(26), CByte(46), CByte(99))
        txtSearch.BorderStyle = BorderStyle.None
        txtSearch.Font = New Font("Segoe UI", 9.5F)
        txtSearch.ForeColor = Color.FromArgb(CByte(131), CByte(175), CByte(214))
        txtSearch.Location = New Point(38, 9)
        txtSearch.Margin = New Padding(3, 4, 3, 4)
        txtSearch.Name = "txtSearch"
        txtSearch.Size = New Size(320, 22)
        txtSearch.TabIndex = 1
        ' 
        ' lblSubtitle
        ' 
        lblSubtitle.AutoSize = True
        lblSubtitle.Font = New Font("Segoe UI", 9.5F)
        lblSubtitle.ForeColor = Color.FromArgb(CByte(131), CByte(175), CByte(214))
        lblSubtitle.Location = New Point(34, 83)
        lblSubtitle.Name = "lblSubtitle"
        lblSubtitle.Size = New Size(165, 21)
        lblSubtitle.TabIndex = 1
        lblSubtitle.Text = "All document requests"
        ' 
        ' lblTitle
        ' 
        lblTitle.AutoSize = True
        lblTitle.Font = New Font("Segoe UI", 18F, FontStyle.Bold)
        lblTitle.ForeColor = Color.White
        lblTitle.Location = New Point(34, 29)
        lblTitle.Name = "lblTitle"
        lblTitle.Size = New Size(182, 41)
        lblTitle.TabIndex = 0
        lblTitle.Text = "Request list"
        ' 
        ' frmRequestList
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.FromArgb(CByte(15), CByte(31), CByte(76))
        ClientSize = New Size(1371, 1055)
        Controls.Add(pnlContent)
        Controls.Add(pnlSidebar)
        Font = New Font("Segoe UI", 9F)
        Margin = New Padding(3, 4, 3, 4)
        Name = "frmRequestList"
        StartPosition = FormStartPosition.CenterScreen
        Text = "Request List - Registrar Document Request System"
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
        CType(dgvRequests, ComponentModel.ISupportInitialize).EndInit()
        pnlTableFooter.ResumeLayout(False)
        pnlTableFooter.PerformLayout()
        pnlSearchFilter.ResumeLayout(False)
        pnlSearchBox.ResumeLayout(False)
        pnlSearchBox.PerformLayout()
        ResumeLayout(False)
    End Sub

    Friend WithEvents pnlSidebar As System.Windows.Forms.Panel
    Friend WithEvents pnlLogout As System.Windows.Forms.Panel
    Friend WithEvents btnLogout As System.Windows.Forms.Button
    Friend WithEvents btnReports As System.Windows.Forms.Button
    Friend WithEvents btnSearchStudent As System.Windows.Forms.Button
    Friend WithEvents btnRequestList As System.Windows.Forms.Button
    Friend WithEvents btnNewRequest As System.Windows.Forms.Button
    Friend WithEvents btnDashboard As System.Windows.Forms.Button
    Friend WithEvents pnlLogoArea As System.Windows.Forms.Panel
    Friend WithEvents pnlContent As System.Windows.Forms.Panel
    Friend WithEvents btnHeaderOptions As System.Windows.Forms.Button
    Friend WithEvents pnlTableCard As System.Windows.Forms.Panel
    Friend WithEvents dgvRequests As System.Windows.Forms.DataGridView
    Friend WithEvents colRequestNo As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents colStudent As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents colDocument As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents colPayment As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents colStatus As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents colAction As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents pnlTableFooter As System.Windows.Forms.Panel
    Friend WithEvents pnlFooterDivider As System.Windows.Forms.Panel
    Friend WithEvents lblPagination As System.Windows.Forms.Label
    Friend WithEvents btnPrev As System.Windows.Forms.Button
    Friend WithEvents btnPage1 As System.Windows.Forms.Button
    Friend WithEvents btnPage2 As System.Windows.Forms.Button
    Friend WithEvents btnNext As System.Windows.Forms.Button
    Friend WithEvents pnlSearchFilter As System.Windows.Forms.Panel
    Friend WithEvents cboDateFilter As System.Windows.Forms.ComboBox
    Friend WithEvents cboDocumentFilter As System.Windows.Forms.ComboBox
    Friend WithEvents cboStatusFilter As System.Windows.Forms.ComboBox
    Friend WithEvents pnlSearchBox As System.Windows.Forms.Panel
    Friend WithEvents lblSearchIcon As System.Windows.Forms.Label
    Friend WithEvents txtSearch As System.Windows.Forms.TextBox
    Friend WithEvents lblSubtitle As System.Windows.Forms.Label
    Friend WithEvents lblTitle As System.Windows.Forms.Label
    Friend WithEvents pnlLogo As Panel
    Friend WithEvents picLogo As PictureBox
    Friend WithEvents lblLogo As Label
End Class



