<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
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
        Me.pnlSidebar = New System.Windows.Forms.Panel()
        Me.pnlLogout = New System.Windows.Forms.Panel()
        Me.btnLogout = New System.Windows.Forms.Button()
        Me.btnUserManagement = New System.Windows.Forms.Button()
        Me.btnReports = New System.Windows.Forms.Button()
        Me.btnDocumentRequests = New System.Windows.Forms.Button()
        Me.btnDocumentManagement = New System.Windows.Forms.Button()
        Me.btnStudentManagement = New System.Windows.Forms.Button()
        Me.btnDashboard = New System.Windows.Forms.Button()
        Me.pnlLogo = New System.Windows.Forms.Panel()
        Me.lblLogo = New System.Windows.Forms.Label()
        Me.pnlContent = New System.Windows.Forms.Panel()
        Me.pnlTableCard = New System.Windows.Forms.Panel()
        Me.dgvRecentRequests = New System.Windows.Forms.DataGridView()
        Me.colRequestNo = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.colStudent = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.colDocument = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.colStatus = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.lblTableTitle = New System.Windows.Forms.Label()
        Me.pnlCard4 = New System.Windows.Forms.Panel()
        Me.lblCard4Value = New System.Windows.Forms.Label()
        Me.lblCard4Title = New System.Windows.Forms.Label()
        Me.pnlCard3 = New System.Windows.Forms.Panel()
        Me.lblCard3Value = New System.Windows.Forms.Label()
        Me.lblCard3Title = New System.Windows.Forms.Label()
        Me.pnlCard2 = New System.Windows.Forms.Panel()
        Me.lblCard2Value = New System.Windows.Forms.Label()
        Me.lblCard2Title = New System.Windows.Forms.Label()
        Me.pnlCard1 = New System.Windows.Forms.Panel()
        Me.lblCard1Value = New System.Windows.Forms.Label()
        Me.lblCard1Title = New System.Windows.Forms.Label()
        Me.lblSubtitle = New System.Windows.Forms.Label()
        Me.lblWelcome = New System.Windows.Forms.Label()
        Me.pnlSidebar.SuspendLayout()
        Me.pnlLogout.SuspendLayout()
        Me.pnlLogo.SuspendLayout()
        Me.pnlContent.SuspendLayout()
        Me.pnlTableCard.SuspendLayout()
        CType(Me.dgvRecentRequests, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.pnlCard4.SuspendLayout()
        Me.pnlCard3.SuspendLayout()
        Me.pnlCard2.SuspendLayout()
        Me.pnlCard1.SuspendLayout()
        Me.SuspendLayout()
        '
        'pnlSidebar
        '
        Me.pnlSidebar.BackColor = System.Drawing.Color.FromArgb(245, 197, 24)
        Me.pnlSidebar.Controls.Add(Me.pnlLogout)
        Me.pnlSidebar.Controls.Add(Me.btnUserManagement)
        Me.pnlSidebar.Controls.Add(Me.btnReports)
        Me.pnlSidebar.Controls.Add(Me.btnDocumentRequests)
        Me.pnlSidebar.Controls.Add(Me.btnDocumentManagement)
        Me.pnlSidebar.Controls.Add(Me.btnStudentManagement)
        Me.pnlSidebar.Controls.Add(Me.btnDashboard)
        Me.pnlSidebar.Controls.Add(Me.pnlLogo)
        Me.pnlSidebar.Dock = System.Windows.Forms.DockStyle.Left
        Me.pnlSidebar.Location = New System.Drawing.Point(0, 0)
        Me.pnlSidebar.Name = "pnlSidebar"
        Me.pnlSidebar.Size = New System.Drawing.Size(200, 600)
        Me.pnlSidebar.TabIndex = 0
        '
        'pnlLogout
        '
        Me.pnlLogout.Controls.Add(Me.btnLogout)
        Me.pnlLogout.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.pnlLogout.Location = New System.Drawing.Point(0, 540)
        Me.pnlLogout.Name = "pnlLogout"
        Me.pnlLogout.Size = New System.Drawing.Size(200, 60)
        Me.pnlLogout.TabIndex = 8
        '
        'btnLogout
        '
        Me.btnLogout.Dock = System.Windows.Forms.DockStyle.Top
        Me.btnLogout.FlatAppearance.BorderSize = 0
        Me.btnLogout.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnLogout.Font = New System.Drawing.Font("Segoe UI", 10.0!)
        Me.btnLogout.ForeColor = System.Drawing.Color.FromArgb(15, 31, 76)
        Me.btnLogout.Location = New System.Drawing.Point(0, 0)
        Me.btnLogout.Name = "btnLogout"
        Me.btnLogout.Padding = New System.Windows.Forms.Padding(20, 0, 0, 0)
        Me.btnLogout.Size = New System.Drawing.Size(200, 50)
        Me.btnLogout.TabIndex = 0
        Me.btnLogout.Text = "Logout"
        Me.btnLogout.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnLogout.UseVisualStyleBackColor = True
        '
        'btnUserManagement
        '
        Me.btnUserManagement.Dock = System.Windows.Forms.DockStyle.Top
        Me.btnUserManagement.FlatAppearance.BorderSize = 0
        Me.btnUserManagement.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnUserManagement.Font = New System.Drawing.Font("Segoe UI", 10.0!)
        Me.btnUserManagement.ForeColor = System.Drawing.Color.FromArgb(15, 31, 76)
        Me.btnUserManagement.Location = New System.Drawing.Point(0, 310)
        Me.btnUserManagement.Name = "btnUserManagement"
        Me.btnUserManagement.Padding = New System.Windows.Forms.Padding(20, 0, 0, 0)
        Me.btnUserManagement.Size = New System.Drawing.Size(200, 50)
        Me.btnUserManagement.TabIndex = 7
        Me.btnUserManagement.Text = "User Management"
        Me.btnUserManagement.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnUserManagement.UseVisualStyleBackColor = True
        '
        'btnReports
        '
        Me.btnReports.Dock = System.Windows.Forms.DockStyle.Top
        Me.btnReports.FlatAppearance.BorderSize = 0
        Me.btnReports.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnReports.Font = New System.Drawing.Font("Segoe UI", 10.0!)
        Me.btnReports.ForeColor = System.Drawing.Color.FromArgb(15, 31, 76)
        Me.btnReports.Location = New System.Drawing.Point(0, 260)
        Me.btnReports.Name = "btnReports"
        Me.btnReports.Padding = New System.Windows.Forms.Padding(20, 0, 0, 0)
        Me.btnReports.Size = New System.Drawing.Size(200, 50)
        Me.btnReports.TabIndex = 6
        Me.btnReports.Text = "Reports"
        Me.btnReports.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnReports.UseVisualStyleBackColor = True
        '
        'btnDocumentRequests
        '
        Me.btnDocumentRequests.Dock = System.Windows.Forms.DockStyle.Top
        Me.btnDocumentRequests.FlatAppearance.BorderSize = 0
        Me.btnDocumentRequests.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnDocumentRequests.Font = New System.Drawing.Font("Segoe UI", 10.0!)
        Me.btnDocumentRequests.ForeColor = System.Drawing.Color.FromArgb(15, 31, 76)
        Me.btnDocumentRequests.Location = New System.Drawing.Point(0, 210)
        Me.btnDocumentRequests.Name = "btnDocumentRequests"
        Me.btnDocumentRequests.Padding = New System.Windows.Forms.Padding(20, 0, 0, 0)
        Me.btnDocumentRequests.Size = New System.Drawing.Size(200, 50)
        Me.btnDocumentRequests.TabIndex = 5
        Me.btnDocumentRequests.Text = "Document Requests"
        Me.btnDocumentRequests.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnDocumentRequests.UseVisualStyleBackColor = True
        '
        'btnDocumentManagement
        '
        Me.btnDocumentManagement.Dock = System.Windows.Forms.DockStyle.Top
        Me.btnDocumentManagement.FlatAppearance.BorderSize = 0
        Me.btnDocumentManagement.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnDocumentManagement.Font = New System.Drawing.Font("Segoe UI", 10.0!)
        Me.btnDocumentManagement.ForeColor = System.Drawing.Color.FromArgb(15, 31, 76)
        Me.btnDocumentManagement.Location = New System.Drawing.Point(0, 160)
        Me.btnDocumentManagement.Name = "btnDocumentManagement"
        Me.btnDocumentManagement.Padding = New System.Windows.Forms.Padding(20, 0, 0, 0)
        Me.btnDocumentManagement.Size = New System.Drawing.Size(200, 50)
        Me.btnDocumentManagement.TabIndex = 4
        Me.btnDocumentManagement.Text = "Document Management"
        Me.btnDocumentManagement.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnDocumentManagement.UseVisualStyleBackColor = True
        '
        'btnStudentManagement
        '
        Me.btnStudentManagement.Dock = System.Windows.Forms.DockStyle.Top
        Me.btnStudentManagement.FlatAppearance.BorderSize = 0
        Me.btnStudentManagement.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnStudentManagement.Font = New System.Drawing.Font("Segoe UI", 10.0!)
        Me.btnStudentManagement.ForeColor = System.Drawing.Color.FromArgb(15, 31, 76)
        Me.btnStudentManagement.Location = New System.Drawing.Point(0, 110)
        Me.btnStudentManagement.Name = "btnStudentManagement"
        Me.btnStudentManagement.Padding = New System.Windows.Forms.Padding(20, 0, 0, 0)
        Me.btnStudentManagement.Size = New System.Drawing.Size(200, 50)
        Me.btnStudentManagement.TabIndex = 3
        Me.btnStudentManagement.Text = "Student Management"
        Me.btnStudentManagement.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnStudentManagement.UseVisualStyleBackColor = True
        '
        'btnDashboard
        '
        Me.btnDashboard.BackColor = System.Drawing.Color.FromArgb(15, 31, 76)
        Me.btnDashboard.Dock = System.Windows.Forms.DockStyle.Top
        Me.btnDashboard.FlatAppearance.BorderSize = 0
        Me.btnDashboard.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnDashboard.Font = New System.Drawing.Font("Segoe UI", 10.0!, System.Drawing.FontStyle.Bold)
        Me.btnDashboard.ForeColor = System.Drawing.Color.White
        Me.btnDashboard.Location = New System.Drawing.Point(0, 60)
        Me.btnDashboard.Name = "btnDashboard"
        Me.btnDashboard.Padding = New System.Windows.Forms.Padding(20, 0, 0, 0)
        Me.btnDashboard.Size = New System.Drawing.Size(200, 50)
        Me.btnDashboard.TabIndex = 2
        Me.btnDashboard.Text = "Dashboard"
        Me.btnDashboard.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnDashboard.UseVisualStyleBackColor = False
        '
        'pnlLogo
        '
        Me.pnlLogo.Controls.Add(Me.lblLogo)
        Me.pnlLogo.Dock = System.Windows.Forms.DockStyle.Top
        Me.pnlLogo.Location = New System.Drawing.Point(0, 0)
        Me.pnlLogo.Name = "pnlLogo"
        Me.pnlLogo.Size = New System.Drawing.Size(200, 60)
        Me.pnlLogo.TabIndex = 1
        '
        'lblLogo
        '
        Me.lblLogo.AutoSize = True
        Me.lblLogo.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold)
        Me.lblLogo.ForeColor = System.Drawing.Color.FromArgb(15, 31, 76)
        Me.lblLogo.Location = New System.Drawing.Point(12, 20)
        Me.lblLogo.Name = "lblLogo"
        Me.lblLogo.Size = New System.Drawing.Size(135, 21)
        Me.lblLogo.TabIndex = 0
        Me.lblLogo.Text = "Registrar System"
        '
        'pnlContent
        '
        Me.pnlContent.BackColor = System.Drawing.Color.FromArgb(15, 31, 76)
        Me.pnlContent.Controls.Add(Me.pnlTableCard)
        Me.pnlContent.Controls.Add(Me.pnlCard4)
        Me.pnlContent.Controls.Add(Me.pnlCard3)
        Me.pnlContent.Controls.Add(Me.pnlCard2)
        Me.pnlContent.Controls.Add(Me.pnlCard1)
        Me.pnlContent.Controls.Add(Me.lblSubtitle)
        Me.pnlContent.Controls.Add(Me.lblWelcome)
        Me.pnlContent.Dock = System.Windows.Forms.DockStyle.Fill
        Me.pnlContent.Location = New System.Drawing.Point(200, 0)
        Me.pnlContent.Name = "pnlContent"
        Me.pnlContent.Size = New System.Drawing.Size(784, 600)
        Me.pnlContent.TabIndex = 1
        '
        'pnlTableCard
        '
        Me.pnlTableCard.BackColor = System.Drawing.Color.FromArgb(26, 46, 99)
        Me.pnlTableCard.Controls.Add(Me.dgvRecentRequests)
        Me.pnlTableCard.Controls.Add(Me.lblTableTitle)
        Me.pnlTableCard.Location = New System.Drawing.Point(30, 240)
        Me.pnlTableCard.Name = "pnlTableCard"
        Me.pnlTableCard.Size = New System.Drawing.Size(720, 320)
        Me.pnlTableCard.TabIndex = 6
        Me.pnlTableCard.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        '
        'dgvRecentRequests
        '
        Me.dgvRecentRequests.AllowUserToAddRows = False
        Me.dgvRecentRequests.AllowUserToDeleteRows = False
        Me.dgvRecentRequests.BackgroundColor = System.Drawing.Color.FromArgb(26, 46, 99)
        Me.dgvRecentRequests.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.dgvRecentRequests.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal
        Me.dgvRecentRequests.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(26, 46, 99)
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        DataGridViewCellStyle1.ForeColor = System.Drawing.Color.LightGray
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgvRecentRequests.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle1
        Me.dgvRecentRequests.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvRecentRequests.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.colRequestNo, Me.colStudent, Me.colDocument, Me.colStatus})
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(26, 46, 99)
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Segoe UI", 10.0!)
        DataGridViewCellStyle2.ForeColor = System.Drawing.Color.White
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(39, 60, 117)
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.White
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.dgvRecentRequests.DefaultCellStyle = DataGridViewCellStyle2
        Me.dgvRecentRequests.EnableHeadersVisualStyles = False
        Me.dgvRecentRequests.Location = New System.Drawing.Point(20, 60)
        Me.dgvRecentRequests.Name = "dgvRecentRequests"
        Me.dgvRecentRequests.ReadOnly = True
        DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(26, 46, 99)
        DataGridViewCellStyle3.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        DataGridViewCellStyle3.ForeColor = System.Drawing.Color.White
        DataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgvRecentRequests.RowHeadersDefaultCellStyle = DataGridViewCellStyle3
        Me.dgvRecentRequests.RowHeadersVisible = False
        Me.dgvRecentRequests.RowTemplate.Height = 40
        Me.dgvRecentRequests.Size = New System.Drawing.Size(680, 240)
        Me.dgvRecentRequests.TabIndex = 1
        Me.dgvRecentRequests.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.dgvRecentRequests.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        '
        'colRequestNo
        '
        Me.colRequestNo.HeaderText = "REQUEST NO."
        Me.colRequestNo.Name = "colRequestNo"
        Me.colRequestNo.ReadOnly = True
        Me.colRequestNo.Width = 150
        '
        'colStudent
        '
        Me.colStudent.HeaderText = "STUDENT"
        Me.colStudent.Name = "colStudent"
        Me.colStudent.ReadOnly = True
        Me.colStudent.Width = 200
        '
        'colDocument
        '
        Me.colDocument.HeaderText = "DOCUMENT"
        Me.colDocument.Name = "colDocument"
        Me.colDocument.ReadOnly = True
        Me.colDocument.Width = 180
        '
        'colStatus
        '
        Me.colStatus.HeaderText = "STATUS"
        Me.colStatus.Name = "colStatus"
        Me.colStatus.ReadOnly = True
        Me.colStatus.Width = 120
        '
        'lblTableTitle
        '
        Me.lblTableTitle.AutoSize = True
        Me.lblTableTitle.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold)
        Me.lblTableTitle.ForeColor = System.Drawing.Color.White
        Me.lblTableTitle.Location = New System.Drawing.Point(16, 20)
        Me.lblTableTitle.Name = "lblTableTitle"
        Me.lblTableTitle.Size = New System.Drawing.Size(133, 21)
        Me.lblTableTitle.TabIndex = 0
        Me.lblTableTitle.Text = "Recent requests"
        '
        'pnlCard4
        '
        Me.pnlCard4.BackColor = System.Drawing.Color.FromArgb(26, 46, 99)
        Me.pnlCard4.Controls.Add(Me.lblCard4Value)
        Me.pnlCard4.Controls.Add(Me.lblCard4Title)
        Me.pnlCard4.Location = New System.Drawing.Point(555, 110)
        Me.pnlCard4.Name = "pnlCard4"
        Me.pnlCard4.Size = New System.Drawing.Size(160, 100)
        Me.pnlCard4.TabIndex = 5
        '
        'lblCard4Value
        '
        Me.lblCard4Value.AutoSize = True
        Me.lblCard4Value.Font = New System.Drawing.Font("Segoe UI", 20.0!, System.Drawing.FontStyle.Bold)
        Me.lblCard4Value.ForeColor = System.Drawing.Color.FromArgb(102, 187, 106)
        Me.lblCard4Value.Location = New System.Drawing.Point(15, 45)
        Me.lblCard4Value.Name = "lblCard4Value"
        Me.lblCard4Value.Size = New System.Drawing.Size(49, 37)
        Me.lblCard4Value.TabIndex = 1
        Me.lblCard4Value.Text = "92"
        '
        'lblCard4Title
        '
        Me.lblCard4Title.AutoSize = True
        Me.lblCard4Title.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.lblCard4Title.ForeColor = System.Drawing.Color.LightGray
        Me.lblCard4Title.Location = New System.Drawing.Point(15, 20)
        Me.lblCard4Title.Name = "lblCard4Title"
        Me.lblCard4Title.Size = New System.Drawing.Size(60, 15)
        Me.lblCard4Title.TabIndex = 0
        Me.lblCard4Title.Text = "RELEASED"
        '
        'pnlCard3
        '
        Me.pnlCard3.BackColor = System.Drawing.Color.FromArgb(26, 46, 99)
        Me.pnlCard3.Controls.Add(Me.lblCard3Value)
        Me.pnlCard3.Controls.Add(Me.lblCard3Title)
        Me.pnlCard3.Location = New System.Drawing.Point(380, 110)
        Me.pnlCard3.Name = "pnlCard3"
        Me.pnlCard3.Size = New System.Drawing.Size(160, 100)
        Me.pnlCard3.TabIndex = 4
        '
        'lblCard3Value
        '
        Me.lblCard3Value.AutoSize = True
        Me.lblCard3Value.Font = New System.Drawing.Font("Segoe UI", 20.0!, System.Drawing.FontStyle.Bold)
        Me.lblCard3Value.ForeColor = System.Drawing.Color.FromArgb(66, 165, 245)
        Me.lblCard3Value.Location = New System.Drawing.Point(15, 45)
        Me.lblCard3Value.Name = "lblCard3Value"
        Me.lblCard3Value.Size = New System.Drawing.Size(33, 37)
        Me.lblCard3Value.TabIndex = 1
        Me.lblCard3Value.Text = "6"
        '
        'lblCard3Title
        '
        Me.lblCard3Title.AutoSize = True
        Me.lblCard3Title.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.lblCard3Title.ForeColor = System.Drawing.Color.LightGray
        Me.lblCard3Title.Location = New System.Drawing.Point(15, 20)
        Me.lblCard3Title.Name = "lblCard3Title"
        Me.lblCard3Title.Size = New System.Drawing.Size(113, 15)
        Me.lblCard3Title.TabIndex = 0
        Me.lblCard3Title.Text = "READY FOR RELEASE"
        '
        'pnlCard2
        '
        Me.pnlCard2.BackColor = System.Drawing.Color.FromArgb(26, 46, 99)
        Me.pnlCard2.Controls.Add(Me.lblCard2Value)
        Me.pnlCard2.Controls.Add(Me.lblCard2Title)
        Me.pnlCard2.Location = New System.Drawing.Point(205, 110)
        Me.pnlCard2.Name = "pnlCard2"
        Me.pnlCard2.Size = New System.Drawing.Size(160, 100)
        Me.pnlCard2.TabIndex = 3
        '
        'lblCard2Value
        '
        Me.lblCard2Value.AutoSize = True
        Me.lblCard2Value.Font = New System.Drawing.Font("Segoe UI", 20.0!, System.Drawing.FontStyle.Bold)
        Me.lblCard2Value.ForeColor = System.Drawing.Color.FromArgb(255, 152, 0)
        Me.lblCard2Value.Location = New System.Drawing.Point(15, 45)
        Me.lblCard2Value.Name = "lblCard2Value"
        Me.lblCard2Value.Size = New System.Drawing.Size(49, 37)
        Me.lblCard2Value.TabIndex = 1
        Me.lblCard2Value.Text = "14"
        '
        'lblCard2Title
        '
        Me.lblCard2Title.AutoSize = True
        Me.lblCard2Title.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.lblCard2Title.ForeColor = System.Drawing.Color.LightGray
        Me.lblCard2Title.Location = New System.Drawing.Point(15, 20)
        Me.lblCard2Title.Name = "lblCard2Title"
        Me.lblCard2Title.Size = New System.Drawing.Size(57, 15)
        Me.lblCard2Title.TabIndex = 0
        Me.lblCard2Title.Text = "PENDING"
        '
        'pnlCard1
        '
        Me.pnlCard1.BackColor = System.Drawing.Color.FromArgb(26, 46, 99)
        Me.pnlCard1.Controls.Add(Me.lblCard1Value)
        Me.pnlCard1.Controls.Add(Me.lblCard1Title)
        Me.pnlCard1.Location = New System.Drawing.Point(30, 110)
        Me.pnlCard1.Name = "pnlCard1"
        Me.pnlCard1.Size = New System.Drawing.Size(160, 100)
        Me.pnlCard1.TabIndex = 2
        '
        'lblCard1Value
        '
        Me.lblCard1Value.AutoSize = True
        Me.lblCard1Value.Font = New System.Drawing.Font("Segoe UI", 20.0!, System.Drawing.FontStyle.Bold)
        Me.lblCard1Value.ForeColor = System.Drawing.Color.FromArgb(245, 197, 24)
        Me.lblCard1Value.Location = New System.Drawing.Point(15, 45)
        Me.lblCard1Value.Name = "lblCard1Value"
        Me.lblCard1Value.Size = New System.Drawing.Size(65, 37)
        Me.lblCard1Value.TabIndex = 1
        Me.lblCard1Value.Text = "128"
        '
        'lblCard1Title
        '
        Me.lblCard1Title.AutoSize = True
        Me.lblCard1Title.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.lblCard1Title.ForeColor = System.Drawing.Color.LightGray
        Me.lblCard1Title.Location = New System.Drawing.Point(15, 20)
        Me.lblCard1Title.Name = "lblCard1Title"
        Me.lblCard1Title.Size = New System.Drawing.Size(98, 15)
        Me.lblCard1Title.TabIndex = 0
        Me.lblCard1Title.Text = "TOTAL REQUESTS"
        '
        'lblSubtitle
        '
        Me.lblSubtitle.AutoSize = True
        Me.lblSubtitle.Font = New System.Drawing.Font("Segoe UI", 11.0!)
        Me.lblSubtitle.ForeColor = System.Drawing.Color.LightGray
        Me.lblSubtitle.Location = New System.Drawing.Point(26, 65)
        Me.lblSubtitle.Name = "lblSubtitle"
        Me.lblSubtitle.Size = New System.Drawing.Size(256, 20)
        Me.lblSubtitle.TabIndex = 1
        Me.lblSubtitle.Text = "Registrar Document Request System"
        '
        'lblWelcome
        '
        Me.lblWelcome.AutoSize = True
        Me.lblWelcome.Font = New System.Drawing.Font("Segoe UI", 18.0!, System.Drawing.FontStyle.Bold)
        Me.lblWelcome.ForeColor = System.Drawing.Color.White
        Me.lblWelcome.Location = New System.Drawing.Point(24, 25)
        Me.lblWelcome.Name = "lblWelcome"
        Me.lblWelcome.Size = New System.Drawing.Size(206, 32)
        Me.lblWelcome.TabIndex = 0
        Me.lblWelcome.Text = "Welcome, Admin"
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(984, 600)
        Me.Controls.Add(Me.pnlContent)
        Me.Controls.Add(Me.pnlSidebar)
        Me.Name = "Form1"
        Me.Text = "Registrar Document Request System"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.pnlSidebar.ResumeLayout(False)
        Me.pnlLogout.ResumeLayout(False)
        Me.pnlLogo.ResumeLayout(False)
        Me.pnlLogo.PerformLayout()
        Me.pnlContent.ResumeLayout(False)
        Me.pnlContent.PerformLayout()
        Me.pnlTableCard.ResumeLayout(False)
        Me.pnlTableCard.PerformLayout()
        CType(Me.dgvRecentRequests, System.ComponentModel.ISupportInitialize).EndInit()
        Me.pnlCard4.ResumeLayout(False)
        Me.pnlCard4.PerformLayout()
        Me.pnlCard3.ResumeLayout(False)
        Me.pnlCard3.PerformLayout()
        Me.pnlCard2.ResumeLayout(False)
        Me.pnlCard2.PerformLayout()
        Me.pnlCard1.ResumeLayout(False)
        Me.pnlCard1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents pnlSidebar As System.Windows.Forms.Panel
    Friend WithEvents btnDashboard As System.Windows.Forms.Button
    Friend WithEvents pnlLogo As System.Windows.Forms.Panel
    Friend WithEvents lblLogo As System.Windows.Forms.Label
    Friend WithEvents btnUserManagement As System.Windows.Forms.Button
    Friend WithEvents btnReports As System.Windows.Forms.Button
    Friend WithEvents btnDocumentRequests As System.Windows.Forms.Button
    Friend WithEvents btnDocumentManagement As System.Windows.Forms.Button
    Friend WithEvents btnStudentManagement As System.Windows.Forms.Button
    Friend WithEvents pnlLogout As System.Windows.Forms.Panel
    Friend WithEvents btnLogout As System.Windows.Forms.Button
    Friend WithEvents pnlContent As System.Windows.Forms.Panel
    Friend WithEvents lblWelcome As System.Windows.Forms.Label
    Friend WithEvents lblSubtitle As System.Windows.Forms.Label
    Friend WithEvents pnlCard1 As System.Windows.Forms.Panel
    Friend WithEvents lblCard1Value As System.Windows.Forms.Label
    Friend WithEvents lblCard1Title As System.Windows.Forms.Label
    Friend WithEvents pnlCard4 As System.Windows.Forms.Panel
    Friend WithEvents lblCard4Value As System.Windows.Forms.Label
    Friend WithEvents lblCard4Title As System.Windows.Forms.Label
    Friend WithEvents pnlCard3 As System.Windows.Forms.Panel
    Friend WithEvents lblCard3Value As System.Windows.Forms.Label
    Friend WithEvents lblCard3Title As System.Windows.Forms.Label
    Friend WithEvents pnlCard2 As System.Windows.Forms.Panel
    Friend WithEvents lblCard2Value As System.Windows.Forms.Label
    Friend WithEvents lblCard2Title As System.Windows.Forms.Label
    Friend WithEvents pnlTableCard As System.Windows.Forms.Panel
    Friend WithEvents dgvRecentRequests As System.Windows.Forms.DataGridView
    Friend WithEvents lblTableTitle As System.Windows.Forms.Label
    Friend WithEvents colRequestNo As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents colStudent As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents colDocument As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents colStatus As System.Windows.Forms.DataGridViewTextBoxColumn

End Class
