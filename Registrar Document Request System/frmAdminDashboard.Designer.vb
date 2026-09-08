<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmAdminDashboard
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
        Dim DataGridViewCellStyle4 As DataGridViewCellStyle = New DataGridViewCellStyle()
        Dim DataGridViewCellStyle5 As DataGridViewCellStyle = New DataGridViewCellStyle()
        Dim DataGridViewCellStyle6 As DataGridViewCellStyle = New DataGridViewCellStyle()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmAdminDashboard))
        pnlSidebar = New Panel()
        pnlLogout = New Panel()
        btnLogout = New Button()
        btnUserManagement = New Button()
        btnReports = New Button()
        btnDocumentRequests = New Button()
        btnDocumentManagement = New Button()
        btnStudentManagement = New Button()
        btnDashboard = New Button()
        pnlContent = New Panel()
        pnlTableCard = New Panel()
        dgvRecentRequests = New DataGridView()
        colRequestNo = New DataGridViewTextBoxColumn()
        colStudent = New DataGridViewTextBoxColumn()
        colDocument = New DataGridViewTextBoxColumn()
        colStatus = New DataGridViewTextBoxColumn()
        lblTableTitle = New Label()
        pnlCard4 = New Panel()
        lblCard4Value = New Label()
        lblCard4Title = New Label()
        pnlCard3 = New Panel()
        lblCard3Value = New Label()
        lblCard3Title = New Label()
        pnlCard2 = New Panel()
        lblCard2Value = New Label()
        lblCard2Title = New Label()
        pnlCard1 = New Panel()
        lblCard1Value = New Label()
        lblCard1Title = New Label()
        lblSubtitle = New Label()
        lblWelcome = New Label()
        lblLogo = New Label()
        picLogo = New PictureBox()
        pnlLogo = New Panel()
        pnlSidebar.SuspendLayout()
        pnlLogout.SuspendLayout()
        pnlContent.SuspendLayout()
        pnlTableCard.SuspendLayout()
        CType(dgvRecentRequests, ComponentModel.ISupportInitialize).BeginInit()
        pnlCard4.SuspendLayout()
        pnlCard3.SuspendLayout()
        pnlCard2.SuspendLayout()
        pnlCard1.SuspendLayout()
        CType(picLogo, ComponentModel.ISupportInitialize).BeginInit()
        pnlLogo.SuspendLayout()
        SuspendLayout()
        ' 
        ' pnlSidebar
        ' 
        pnlSidebar.BackColor = Color.FromArgb(CByte(245), CByte(197), CByte(24))
        pnlSidebar.Controls.Add(pnlLogout)
        pnlSidebar.Controls.Add(btnUserManagement)
        pnlSidebar.Controls.Add(btnReports)
        pnlSidebar.Controls.Add(btnDocumentRequests)
        pnlSidebar.Controls.Add(btnDocumentManagement)
        pnlSidebar.Controls.Add(btnStudentManagement)
        pnlSidebar.Controls.Add(btnDashboard)
        pnlSidebar.Controls.Add(pnlLogo)
        pnlSidebar.Dock = DockStyle.Left
        pnlSidebar.Location = New Point(0, 0)
        pnlSidebar.Name = "pnlSidebar"
        pnlSidebar.Size = New Size(200, 600)
        pnlSidebar.TabIndex = 0
        ' 
        ' pnlLogout
        ' 
        pnlLogout.Controls.Add(btnLogout)
        pnlLogout.Dock = DockStyle.Bottom
        pnlLogout.Location = New Point(0, 540)
        pnlLogout.Name = "pnlLogout"
        pnlLogout.Size = New Size(200, 60)
        pnlLogout.TabIndex = 8
        ' 
        ' btnLogout
        ' 
        btnLogout.Dock = DockStyle.Top
        btnLogout.FlatAppearance.BorderSize = 0
        btnLogout.FlatStyle = FlatStyle.Flat
        btnLogout.Font = New Font("Segoe UI", 10.0F)
        btnLogout.ForeColor = Color.FromArgb(CByte(15), CByte(31), CByte(76))
        btnLogout.Location = New Point(0, 0)
        btnLogout.Name = "btnLogout"
        btnLogout.Padding = New Padding(20, 0, 0, 0)
        btnLogout.Size = New Size(200, 50)
        btnLogout.TabIndex = 0
        btnLogout.Text = "Logout"
        btnLogout.TextAlign = ContentAlignment.MiddleLeft
        btnLogout.UseVisualStyleBackColor = True
        ' 
        ' btnUserManagement
        ' 
        btnUserManagement.Dock = DockStyle.Top
        btnUserManagement.FlatAppearance.BorderSize = 0
        btnUserManagement.FlatStyle = FlatStyle.Flat
        btnUserManagement.Font = New Font("Segoe UI", 10.0F)
        btnUserManagement.ForeColor = Color.FromArgb(CByte(15), CByte(31), CByte(76))
        btnUserManagement.Location = New Point(0, 310)
        btnUserManagement.Name = "btnUserManagement"
        btnUserManagement.Padding = New Padding(20, 0, 0, 0)
        btnUserManagement.Size = New Size(200, 59)
        btnUserManagement.TabIndex = 7
        btnUserManagement.Text = "User Management"
        btnUserManagement.TextAlign = ContentAlignment.MiddleLeft
        btnUserManagement.UseVisualStyleBackColor = True
        ' 
        ' btnReports
        ' 
        btnReports.Dock = DockStyle.Top
        btnReports.FlatAppearance.BorderSize = 0
        btnReports.FlatStyle = FlatStyle.Flat
        btnReports.Font = New Font("Segoe UI", 10.0F)
        btnReports.ForeColor = Color.FromArgb(CByte(15), CByte(31), CByte(76))
        btnReports.Location = New Point(0, 260)
        btnReports.Name = "btnReports"
        btnReports.Padding = New Padding(20, 0, 0, 0)
        btnReports.Size = New Size(200, 50)
        btnReports.TabIndex = 6
        btnReports.Text = "Reports"
        btnReports.TextAlign = ContentAlignment.MiddleLeft
        btnReports.UseVisualStyleBackColor = True
        ' 
        ' btnDocumentRequests
        ' 
        btnDocumentRequests.Dock = DockStyle.Top
        btnDocumentRequests.FlatAppearance.BorderSize = 0
        btnDocumentRequests.FlatStyle = FlatStyle.Flat
        btnDocumentRequests.Font = New Font("Segoe UI", 10.0F)
        btnDocumentRequests.ForeColor = Color.FromArgb(CByte(15), CByte(31), CByte(76))
        btnDocumentRequests.Location = New Point(0, 210)
        btnDocumentRequests.Name = "btnDocumentRequests"
        btnDocumentRequests.Padding = New Padding(20, 0, 0, 0)
        btnDocumentRequests.Size = New Size(200, 50)
        btnDocumentRequests.TabIndex = 5
        btnDocumentRequests.Text = "Document Requests"
        btnDocumentRequests.TextAlign = ContentAlignment.MiddleLeft
        btnDocumentRequests.UseVisualStyleBackColor = True
        ' 
        ' btnDocumentManagement
        ' 
        btnDocumentManagement.Dock = DockStyle.Top
        btnDocumentManagement.FlatAppearance.BorderSize = 0
        btnDocumentManagement.FlatStyle = FlatStyle.Flat
        btnDocumentManagement.Font = New Font("Segoe UI", 10.0F)
        btnDocumentManagement.ForeColor = Color.FromArgb(CByte(15), CByte(31), CByte(76))
        btnDocumentManagement.Location = New Point(0, 160)
        btnDocumentManagement.Name = "btnDocumentManagement"
        btnDocumentManagement.Padding = New Padding(20, 0, 0, 0)
        btnDocumentManagement.Size = New Size(200, 50)
        btnDocumentManagement.TabIndex = 4
        btnDocumentManagement.Text = "Document Management"
        btnDocumentManagement.TextAlign = ContentAlignment.MiddleLeft
        btnDocumentManagement.UseVisualStyleBackColor = True
        ' 
        ' btnStudentManagement
        ' 
        btnStudentManagement.Dock = DockStyle.Top
        btnStudentManagement.FlatAppearance.BorderSize = 0
        btnStudentManagement.FlatStyle = FlatStyle.Flat
        btnStudentManagement.Font = New Font("Segoe UI", 10.0F)
        btnStudentManagement.ForeColor = Color.FromArgb(CByte(15), CByte(31), CByte(76))
        btnStudentManagement.Location = New Point(0, 110)
        btnStudentManagement.Name = "btnStudentManagement"
        btnStudentManagement.Padding = New Padding(20, 0, 0, 0)
        btnStudentManagement.Size = New Size(200, 50)
        btnStudentManagement.TabIndex = 3
        btnStudentManagement.Text = "Student Management"
        btnStudentManagement.TextAlign = ContentAlignment.MiddleLeft
        btnStudentManagement.UseVisualStyleBackColor = True
        ' 
        ' btnDashboard
        ' 
        btnDashboard.BackColor = Color.FromArgb(CByte(245), CByte(197), CByte(24))
        btnDashboard.Dock = DockStyle.Top
        btnDashboard.FlatAppearance.BorderSize = 0
        btnDashboard.FlatStyle = FlatStyle.Flat
        btnDashboard.Font = New Font("Segoe UI", 10.0F)
        btnDashboard.ForeColor = Color.FromArgb(CByte(15), CByte(31), CByte(76))
        btnDashboard.Location = New Point(0, 60)
        btnDashboard.Name = "btnDashboard"
        btnDashboard.Padding = New Padding(20, 0, 0, 0)
        btnDashboard.Size = New Size(200, 50)
        btnDashboard.TabIndex = 2
        btnDashboard.Text = "Dashboard"
        btnDashboard.TextAlign = ContentAlignment.MiddleLeft
        btnDashboard.UseVisualStyleBackColor = False
        ' 
        ' pnlContent
        ' 
        pnlContent.BackColor = Color.FromArgb(CByte(15), CByte(31), CByte(76))
        pnlContent.Controls.Add(pnlTableCard)
        pnlContent.Controls.Add(pnlCard4)
        pnlContent.Controls.Add(pnlCard3)
        pnlContent.Controls.Add(pnlCard2)
        pnlContent.Controls.Add(pnlCard1)
        pnlContent.Controls.Add(lblSubtitle)
        pnlContent.Controls.Add(lblWelcome)
        pnlContent.Dock = DockStyle.Fill
        pnlContent.Location = New Point(200, 0)
        pnlContent.Name = "pnlContent"
        pnlContent.Size = New Size(784, 600)
        pnlContent.TabIndex = 1
        ' 
        ' pnlTableCard
        ' 
        pnlTableCard.Anchor = AnchorStyles.Top Or AnchorStyles.Bottom Or AnchorStyles.Left Or AnchorStyles.Right
        pnlTableCard.BackColor = Color.FromArgb(CByte(26), CByte(46), CByte(99))
        pnlTableCard.Controls.Add(dgvRecentRequests)
        pnlTableCard.Controls.Add(lblTableTitle)
        pnlTableCard.Location = New Point(30, 240)
        pnlTableCard.Name = "pnlTableCard"
        pnlTableCard.Size = New Size(720, 320)
        pnlTableCard.TabIndex = 6
        ' 
        ' dgvRecentRequests
        ' 
        dgvRecentRequests.AllowUserToAddRows = False
        dgvRecentRequests.AllowUserToDeleteRows = False
        dgvRecentRequests.Anchor = AnchorStyles.Top Or AnchorStyles.Bottom Or AnchorStyles.Left Or AnchorStyles.Right
        dgvRecentRequests.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill
        dgvRecentRequests.BackgroundColor = Color.FromArgb(CByte(26), CByte(46), CByte(99))
        dgvRecentRequests.BorderStyle = BorderStyle.None
        dgvRecentRequests.CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal
        dgvRecentRequests.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None
        DataGridViewCellStyle4.Alignment = DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle4.BackColor = Color.FromArgb(CByte(26), CByte(46), CByte(99))
        DataGridViewCellStyle4.Font = New Font("Segoe UI", 9.0F)
        DataGridViewCellStyle4.ForeColor = Color.LightGray
        DataGridViewCellStyle4.SelectionBackColor = SystemColors.Highlight
        DataGridViewCellStyle4.SelectionForeColor = SystemColors.HighlightText
        DataGridViewCellStyle4.WrapMode = DataGridViewTriState.True
        dgvRecentRequests.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle4
        dgvRecentRequests.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        dgvRecentRequests.Columns.AddRange(New DataGridViewColumn() {colRequestNo, colStudent, colDocument, colStatus})
        DataGridViewCellStyle5.Alignment = DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle5.BackColor = Color.FromArgb(CByte(26), CByte(46), CByte(99))
        DataGridViewCellStyle5.Font = New Font("Segoe UI", 10.0F)
        DataGridViewCellStyle5.ForeColor = Color.White
        DataGridViewCellStyle5.SelectionBackColor = Color.FromArgb(CByte(39), CByte(60), CByte(117))
        DataGridViewCellStyle5.SelectionForeColor = Color.White
        DataGridViewCellStyle5.WrapMode = DataGridViewTriState.False
        dgvRecentRequests.DefaultCellStyle = DataGridViewCellStyle5
        dgvRecentRequests.EnableHeadersVisualStyles = False
        dgvRecentRequests.Location = New Point(20, 60)
        dgvRecentRequests.Name = "dgvRecentRequests"
        dgvRecentRequests.ReadOnly = True
        DataGridViewCellStyle6.Alignment = DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle6.BackColor = Color.FromArgb(CByte(26), CByte(46), CByte(99))
        DataGridViewCellStyle6.Font = New Font("Segoe UI", 9.0F)
        DataGridViewCellStyle6.ForeColor = Color.White
        DataGridViewCellStyle6.SelectionBackColor = SystemColors.Highlight
        DataGridViewCellStyle6.SelectionForeColor = SystemColors.HighlightText
        DataGridViewCellStyle6.WrapMode = DataGridViewTriState.True
        dgvRecentRequests.RowHeadersDefaultCellStyle = DataGridViewCellStyle6
        dgvRecentRequests.RowHeadersVisible = False
        dgvRecentRequests.RowTemplate.Height = 40
        dgvRecentRequests.Size = New Size(680, 240)
        dgvRecentRequests.TabIndex = 1
        ' 
        ' colRequestNo
        ' 
        colRequestNo.HeaderText = "REQUEST NO."
        colRequestNo.Name = "colRequestNo"
        colRequestNo.ReadOnly = True
        ' 
        ' colStudent
        ' 
        colStudent.HeaderText = "STUDENT"
        colStudent.Name = "colStudent"
        colStudent.ReadOnly = True
        ' 
        ' colDocument
        ' 
        colDocument.HeaderText = "DOCUMENT"
        colDocument.Name = "colDocument"
        colDocument.ReadOnly = True
        ' 
        ' colStatus
        ' 
        colStatus.HeaderText = "STATUS"
        colStatus.Name = "colStatus"
        colStatus.ReadOnly = True
        ' 
        ' lblTableTitle
        ' 
        lblTableTitle.AutoSize = True
        lblTableTitle.Font = New Font("Segoe UI", 12.0F, FontStyle.Bold)
        lblTableTitle.ForeColor = Color.White
        lblTableTitle.Location = New Point(16, 20)
        lblTableTitle.Name = "lblTableTitle"
        lblTableTitle.Size = New Size(130, 21)
        lblTableTitle.TabIndex = 0
        lblTableTitle.Text = "Recent requests"
        ' 
        ' pnlCard4
        ' 
        pnlCard4.BackColor = Color.FromArgb(CByte(26), CByte(46), CByte(99))
        pnlCard4.Controls.Add(lblCard4Value)
        pnlCard4.Controls.Add(lblCard4Title)
        pnlCard4.Location = New Point(555, 110)
        pnlCard4.Name = "pnlCard4"
        pnlCard4.Size = New Size(160, 100)
        pnlCard4.TabIndex = 5
        ' 
        ' lblCard4Value
        ' 
        lblCard4Value.AutoSize = True
        lblCard4Value.Font = New Font("Segoe UI", 20.0F, FontStyle.Bold)
        lblCard4Value.ForeColor = Color.FromArgb(CByte(60), CByte(140), CByte(94))
        lblCard4Value.Location = New Point(15, 45)
        lblCard4Value.Name = "lblCard4Value"
        lblCard4Value.Size = New Size(49, 37)
        lblCard4Value.TabIndex = 1
        lblCard4Value.Text = "92"
        ' 
        ' lblCard4Title
        ' 
        lblCard4Title.AutoSize = True
        lblCard4Title.Font = New Font("Segoe UI", 9.0F)
        lblCard4Title.ForeColor = Color.LightGray
        lblCard4Title.Location = New Point(15, 20)
        lblCard4Title.Name = "lblCard4Title"
        lblCard4Title.Size = New Size(60, 15)
        lblCard4Title.TabIndex = 0
        lblCard4Title.Text = "RELEASED"
        ' 
        ' pnlCard3
        ' 
        pnlCard3.BackColor = Color.FromArgb(CByte(26), CByte(46), CByte(99))
        pnlCard3.Controls.Add(lblCard3Value)
        pnlCard3.Controls.Add(lblCard3Title)
        pnlCard3.Location = New Point(380, 110)
        pnlCard3.Name = "pnlCard3"
        pnlCard3.Size = New Size(160, 100)
        pnlCard3.TabIndex = 4
        ' 
        ' lblCard3Value
        ' 
        lblCard3Value.AutoSize = True
        lblCard3Value.Font = New Font("Segoe UI", 20.0F, FontStyle.Bold)
        lblCard3Value.ForeColor = Color.FromArgb(CByte(90), CByte(168), CByte(224))
        lblCard3Value.Location = New Point(15, 45)
        lblCard3Value.Name = "lblCard3Value"
        lblCard3Value.Size = New Size(33, 37)
        lblCard3Value.TabIndex = 1
        lblCard3Value.Text = "6"
        ' 
        ' lblCard3Title
        ' 
        lblCard3Title.AutoSize = True
        lblCard3Title.Font = New Font("Segoe UI", 9.0F)
        lblCard3Title.ForeColor = Color.LightGray
        lblCard3Title.Location = New Point(15, 20)
        lblCard3Title.Name = "lblCard3Title"
        lblCard3Title.Size = New Size(116, 15)
        lblCard3Title.TabIndex = 0
        lblCard3Title.Text = "READY FOR RELEASE"
        ' 
        ' pnlCard2
        ' 
        pnlCard2.BackColor = Color.FromArgb(CByte(26), CByte(46), CByte(99))
        pnlCard2.Controls.Add(lblCard2Value)
        pnlCard2.Controls.Add(lblCard2Title)
        pnlCard2.Location = New Point(205, 110)
        pnlCard2.Name = "pnlCard2"
        pnlCard2.Size = New Size(160, 100)
        pnlCard2.TabIndex = 3
        ' 
        ' lblCard2Value
        ' 
        lblCard2Value.AutoSize = True
        lblCard2Value.Font = New Font("Segoe UI", 20.0F, FontStyle.Bold)
        lblCard2Value.ForeColor = Color.FromArgb(CByte(232), CByte(163), CByte(61))
        lblCard2Value.Location = New Point(15, 45)
        lblCard2Value.Name = "lblCard2Value"
        lblCard2Value.Size = New Size(49, 37)
        lblCard2Value.TabIndex = 1
        lblCard2Value.Text = "14"
        ' 
        ' lblCard2Title
        ' 
        lblCard2Title.AutoSize = True
        lblCard2Title.Font = New Font("Segoe UI", 9.0F)
        lblCard2Title.ForeColor = Color.LightGray
        lblCard2Title.Location = New Point(15, 20)
        lblCard2Title.Name = "lblCard2Title"
        lblCard2Title.Size = New Size(57, 15)
        lblCard2Title.TabIndex = 0
        lblCard2Title.Text = "PENDING"
        ' 
        ' pnlCard1
        ' 
        pnlCard1.BackColor = Color.FromArgb(CByte(26), CByte(46), CByte(99))
        pnlCard1.Controls.Add(lblCard1Value)
        pnlCard1.Controls.Add(lblCard1Title)
        pnlCard1.Location = New Point(30, 110)
        pnlCard1.Name = "pnlCard1"
        pnlCard1.Size = New Size(160, 100)
        pnlCard1.TabIndex = 2
        ' 
        ' lblCard1Value
        ' 
        lblCard1Value.AutoSize = True
        lblCard1Value.Font = New Font("Segoe UI", 20.0F, FontStyle.Bold)
        lblCard1Value.ForeColor = Color.FromArgb(CByte(245), CByte(197), CByte(24))
        lblCard1Value.Location = New Point(15, 45)
        lblCard1Value.Name = "lblCard1Value"
        lblCard1Value.Size = New Size(65, 37)
        lblCard1Value.TabIndex = 1
        lblCard1Value.Text = "128"
        ' 
        ' lblCard1Title
        ' 
        lblCard1Title.AutoSize = True
        lblCard1Title.Font = New Font("Segoe UI", 9.0F)
        lblCard1Title.ForeColor = Color.LightGray
        lblCard1Title.Location = New Point(15, 20)
        lblCard1Title.Name = "lblCard1Title"
        lblCard1Title.Size = New Size(99, 15)
        lblCard1Title.TabIndex = 0
        lblCard1Title.Text = "TOTAL REQUESTS"
        ' 
        ' lblSubtitle
        ' 
        lblSubtitle.AutoSize = True
        lblSubtitle.Font = New Font("Segoe UI", 11.0F)
        lblSubtitle.ForeColor = Color.LightGray
        lblSubtitle.Location = New Point(26, 65)
        lblSubtitle.Name = "lblSubtitle"
        lblSubtitle.Size = New Size(249, 20)
        lblSubtitle.TabIndex = 1
        lblSubtitle.Text = "Registrar Document Request System"
        ' 
        ' lblWelcome
        ' 
        lblWelcome.AutoSize = True
        lblWelcome.Font = New Font("Segoe UI", 18.0F, FontStyle.Bold)
        lblWelcome.ForeColor = Color.White
        lblWelcome.Location = New Point(24, 25)
        lblWelcome.Name = "lblWelcome"
        lblWelcome.Size = New Size(209, 32)
        lblWelcome.TabIndex = 0
        lblWelcome.Text = "Welcome, Admin"
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
        ' pnlLogo
        ' 
        pnlLogo.Controls.Add(picLogo)
        pnlLogo.Controls.Add(lblLogo)
        pnlLogo.Dock = DockStyle.Top
        pnlLogo.Location = New Point(0, 0)
        pnlLogo.Name = "pnlLogo"
        pnlLogo.Size = New Size(200, 60)
        pnlLogo.TabIndex = 1
        ' 
        ' Form1
        ' 
        AutoScaleDimensions = New SizeF(7.0F, 15.0F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(984, 600)
        Controls.Add(pnlContent)
        Controls.Add(pnlSidebar)
        Name = "Form1"
        Text = "Registrar Document Request System"
        WindowState = FormWindowState.Maximized
        pnlSidebar.ResumeLayout(False)
        pnlLogout.ResumeLayout(False)
        pnlContent.ResumeLayout(False)
        pnlContent.PerformLayout()
        pnlTableCard.ResumeLayout(False)
        pnlTableCard.PerformLayout()
        CType(dgvRecentRequests, ComponentModel.ISupportInitialize).EndInit()
        pnlCard4.ResumeLayout(False)
        pnlCard4.PerformLayout()
        pnlCard3.ResumeLayout(False)
        pnlCard3.PerformLayout()
        pnlCard2.ResumeLayout(False)
        pnlCard2.PerformLayout()
        pnlCard1.ResumeLayout(False)
        pnlCard1.PerformLayout()
        CType(picLogo, ComponentModel.ISupportInitialize).EndInit()
        pnlLogo.ResumeLayout(False)
        pnlLogo.PerformLayout()
        ResumeLayout(False)

    End Sub

    Friend WithEvents pnlSidebar As System.Windows.Forms.Panel
    Friend WithEvents btnDashboard As System.Windows.Forms.Button
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
    Friend WithEvents pnlLogo As Panel
    Friend WithEvents picLogo As PictureBox
    Friend WithEvents lblLogo As Label

End Class
