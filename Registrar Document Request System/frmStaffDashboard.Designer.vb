<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmStaffDashboard
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmStaffDashboard))
        Dim DataGridViewCellStyle7 As DataGridViewCellStyle = New DataGridViewCellStyle()
        Dim DataGridViewCellStyle8 As DataGridViewCellStyle = New DataGridViewCellStyle()
        Dim DataGridViewCellStyle9 As DataGridViewCellStyle = New DataGridViewCellStyle()
        pnlSidebar = New Panel()
        pnlLogout = New Panel()
        btnLogout = New Button()
        btnReports = New Button()
        btnSearchStudent = New Button()
        btnRequestList = New Button()
        btnNewRequest = New Button()
        btnDashboard = New Button()
        pnlLogoArea = New Panel()
        picLogo = New PictureBox()
        lblRegistrarSystem = New Label()
        pnlContent = New Panel()
        pnlRecentCard = New Panel()
        dgvRecent = New DataGridView()
        colRequestNo = New DataGridViewTextBoxColumn()
        colStudent = New DataGridViewTextBoxColumn()
        colDocument = New DataGridViewTextBoxColumn()
        colStatus = New DataGridViewTextBoxColumn()
        lblRecentTitle = New Label()
        btnCreateRequest = New Button()
        pnlCard3 = New Panel()
        lblCard3Value = New Label()
        lblCard3Title = New Label()
        pnlCard2 = New Panel()
        lblCard2Value = New Label()
        lblCard2Title = New Label()
        pnlCard1 = New Panel()
        lblCard1Value = New Label()
        lblCard1Title = New Label()
        lblWelcomeSub = New Label()
        lblWelcome = New Label()
        pnlSidebar.SuspendLayout()
        pnlLogout.SuspendLayout()
        pnlLogoArea.SuspendLayout()
        CType(picLogo, ComponentModel.ISupportInitialize).BeginInit()
        pnlContent.SuspendLayout()
        pnlRecentCard.SuspendLayout()
        CType(dgvRecent, ComponentModel.ISupportInitialize).BeginInit()
        pnlCard3.SuspendLayout()
        pnlCard2.SuspendLayout()
        pnlCard1.SuspendLayout()
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
        pnlSidebar.Size = New Size(200, 600)
        pnlSidebar.TabIndex = 0
        ' 
        ' pnlLogout
        ' 
        pnlLogout.Controls.Add(btnLogout)
        pnlLogout.Dock = DockStyle.Bottom
        pnlLogout.Location = New Point(0, 545)
        pnlLogout.Name = "pnlLogout"
        pnlLogout.Size = New Size(200, 55)
        pnlLogout.TabIndex = 7
        ' 
        ' btnLogout
        ' 
        btnLogout.Dock = DockStyle.Fill
        btnLogout.FlatAppearance.BorderSize = 0
        btnLogout.FlatStyle = FlatStyle.Flat
        btnLogout.Font = New Font("Segoe UI", 10.0F)
        btnLogout.ForeColor = Color.FromArgb(CByte(15), CByte(31), CByte(76))
        btnLogout.Location = New Point(0, 0)
        btnLogout.Name = "btnLogout"
        btnLogout.Padding = New Padding(20, 0, 0, 0)
        btnLogout.Size = New Size(200, 55)
        btnLogout.TabIndex = 0
        btnLogout.Text = "Logout"
        btnLogout.TextAlign = ContentAlignment.MiddleLeft
        btnLogout.UseVisualStyleBackColor = True
        ' 
        ' btnReports
        ' 
        btnReports.Dock = DockStyle.Top
        btnReports.FlatAppearance.BorderSize = 0
        btnReports.FlatStyle = FlatStyle.Flat
        btnReports.Font = New Font("Segoe UI", 10.0F)
        btnReports.ForeColor = Color.FromArgb(CByte(15), CByte(31), CByte(76))
        btnReports.Location = New Point(0, 257)
        btnReports.Name = "btnReports"
        btnReports.Padding = New Padding(20, 0, 0, 0)
        btnReports.Size = New Size(200, 48)
        btnReports.TabIndex = 6
        btnReports.Text = "Reports"
        btnReports.TextAlign = ContentAlignment.MiddleLeft
        btnReports.UseVisualStyleBackColor = True
        ' 
        ' btnSearchStudent
        ' 
        btnSearchStudent.Dock = DockStyle.Top
        btnSearchStudent.FlatAppearance.BorderSize = 0
        btnSearchStudent.FlatStyle = FlatStyle.Flat
        btnSearchStudent.Font = New Font("Segoe UI", 10.0F)
        btnSearchStudent.ForeColor = Color.FromArgb(CByte(15), CByte(31), CByte(76))
        btnSearchStudent.Location = New Point(0, 209)
        btnSearchStudent.Name = "btnSearchStudent"
        btnSearchStudent.Padding = New Padding(20, 0, 0, 0)
        btnSearchStudent.Size = New Size(200, 48)
        btnSearchStudent.TabIndex = 5
        btnSearchStudent.Text = "Search Student"
        btnSearchStudent.TextAlign = ContentAlignment.MiddleLeft
        btnSearchStudent.UseVisualStyleBackColor = True
        ' 
        ' btnRequestList
        ' 
        btnRequestList.Dock = DockStyle.Top
        btnRequestList.FlatAppearance.BorderSize = 0
        btnRequestList.FlatStyle = FlatStyle.Flat
        btnRequestList.Font = New Font("Segoe UI", 10.0F)
        btnRequestList.ForeColor = Color.FromArgb(CByte(15), CByte(31), CByte(76))
        btnRequestList.Location = New Point(0, 161)
        btnRequestList.Name = "btnRequestList"
        btnRequestList.Padding = New Padding(20, 0, 0, 0)
        btnRequestList.Size = New Size(200, 48)
        btnRequestList.TabIndex = 4
        btnRequestList.Text = "Request List"
        btnRequestList.TextAlign = ContentAlignment.MiddleLeft
        btnRequestList.UseVisualStyleBackColor = True
        ' 
        ' btnNewRequest
        ' 
        btnNewRequest.Dock = DockStyle.Top
        btnNewRequest.FlatAppearance.BorderSize = 0
        btnNewRequest.FlatStyle = FlatStyle.Flat
        btnNewRequest.Font = New Font("Segoe UI", 10.0F)
        btnNewRequest.ForeColor = Color.FromArgb(CByte(15), CByte(31), CByte(76))
        btnNewRequest.Location = New Point(0, 113)
        btnNewRequest.Name = "btnNewRequest"
        btnNewRequest.Padding = New Padding(20, 0, 0, 0)
        btnNewRequest.Size = New Size(200, 48)
        btnNewRequest.TabIndex = 3
        btnNewRequest.Text = "New Request"
        btnNewRequest.TextAlign = ContentAlignment.MiddleLeft
        btnNewRequest.UseVisualStyleBackColor = True
        ' 
        ' btnDashboard
        ' 
        btnDashboard.BackColor = Color.FromArgb(CByte(245), CByte(197), CByte(24))
        btnDashboard.Dock = DockStyle.Top
        btnDashboard.FlatAppearance.BorderSize = 0
        btnDashboard.FlatStyle = FlatStyle.Flat
        btnDashboard.Font = New Font("Segoe UI", 10.0F)
        btnDashboard.ForeColor = Color.FromArgb(CByte(15), CByte(31), CByte(76))
        btnDashboard.Location = New Point(0, 65)
        btnDashboard.Name = "btnDashboard"
        btnDashboard.Padding = New Padding(20, 0, 0, 0)
        btnDashboard.Size = New Size(200, 48)
        btnDashboard.TabIndex = 2
        btnDashboard.Text = "Dashboard"
        btnDashboard.TextAlign = ContentAlignment.MiddleLeft
        btnDashboard.UseVisualStyleBackColor = False
        ' 
        ' pnlLogoArea
        ' 
        pnlLogoArea.BackColor = Color.Transparent
        pnlLogoArea.Controls.Add(picLogo)
        pnlLogoArea.Controls.Add(lblRegistrarSystem)
        pnlLogoArea.Dock = DockStyle.Top
        pnlLogoArea.Location = New Point(0, 0)
        pnlLogoArea.Name = "pnlLogoArea"
        pnlLogoArea.Size = New Size(200, 65)
        pnlLogoArea.TabIndex = 0
        ' 
        ' picLogo
        ' 
        picLogo.BackColor = Color.FromArgb(CByte(15), CByte(31), CByte(76))
        picLogo.Image = CType(resources.GetObject("picLogo.Image"), Image)
        picLogo.Location = New Point(10, 10)
        picLogo.Name = "picLogo"
        picLogo.Size = New Size(42, 42)
        picLogo.SizeMode = PictureBoxSizeMode.Zoom
        picLogo.TabIndex = 0
        picLogo.TabStop = False
        ' 
        ' lblRegistrarSystem
        ' 
        lblRegistrarSystem.Font = New Font("Segoe UI", 10.0F, FontStyle.Bold)
        lblRegistrarSystem.ForeColor = Color.FromArgb(CByte(15), CByte(31), CByte(76))
        lblRegistrarSystem.Location = New Point(58, 22)
        lblRegistrarSystem.Name = "lblRegistrarSystem"
        lblRegistrarSystem.Size = New Size(135, 30)
        lblRegistrarSystem.TabIndex = 1
        lblRegistrarSystem.Text = "Registrar System"
        ' 
        ' pnlContent
        ' 
        pnlContent.BackColor = Color.FromArgb(CByte(15), CByte(31), CByte(76))
        pnlContent.Controls.Add(pnlRecentCard)
        pnlContent.Controls.Add(btnCreateRequest)
        pnlContent.Controls.Add(pnlCard3)
        pnlContent.Controls.Add(pnlCard2)
        pnlContent.Controls.Add(pnlCard1)
        pnlContent.Controls.Add(lblWelcomeSub)
        pnlContent.Controls.Add(lblWelcome)
        pnlContent.Dock = DockStyle.Fill
        pnlContent.Location = New Point(200, 0)
        pnlContent.Name = "pnlContent"
        pnlContent.Size = New Size(784, 600)
        pnlContent.TabIndex = 1
        ' 
        ' pnlRecentCard
        ' 
        pnlRecentCard.Anchor = AnchorStyles.Top Or AnchorStyles.Bottom Or AnchorStyles.Left Or AnchorStyles.Right
        pnlRecentCard.BackColor = Color.FromArgb(CByte(26), CByte(46), CByte(99))
        pnlRecentCard.Controls.Add(dgvRecent)
        pnlRecentCard.Controls.Add(lblRecentTitle)
        pnlRecentCard.Location = New Point(25, 270)
        pnlRecentCard.Name = "pnlRecentCard"
        pnlRecentCard.Size = New Size(700, 300)
        pnlRecentCard.TabIndex = 6
        ' 
        ' dgvRecent
        ' 
        dgvRecent.AllowUserToAddRows = False
        dgvRecent.AllowUserToDeleteRows = False
        dgvRecent.Anchor = AnchorStyles.Top Or AnchorStyles.Bottom Or AnchorStyles.Left Or AnchorStyles.Right
        dgvRecent.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill
        dgvRecent.BackgroundColor = Color.FromArgb(CByte(26), CByte(46), CByte(99))
        dgvRecent.BorderStyle = BorderStyle.None
        dgvRecent.CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal
        dgvRecent.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None
        DataGridViewCellStyle7.Alignment = DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle7.BackColor = Color.FromArgb(CByte(26), CByte(46), CByte(99))
        DataGridViewCellStyle7.Font = New Font("Segoe UI", 8.5F)
        DataGridViewCellStyle7.ForeColor = Color.LightGray
        DataGridViewCellStyle7.SelectionBackColor = SystemColors.Highlight
        DataGridViewCellStyle7.SelectionForeColor = SystemColors.HighlightText
        DataGridViewCellStyle7.WrapMode = DataGridViewTriState.True
        dgvRecent.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle7
        dgvRecent.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        dgvRecent.Columns.AddRange(New DataGridViewColumn() {colRequestNo, colStudent, colDocument, colStatus})
        DataGridViewCellStyle8.Alignment = DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle8.BackColor = Color.FromArgb(CByte(26), CByte(46), CByte(99))
        DataGridViewCellStyle8.Font = New Font("Segoe UI", 10.0F)
        DataGridViewCellStyle8.ForeColor = Color.White
        DataGridViewCellStyle8.SelectionBackColor = Color.FromArgb(CByte(39), CByte(60), CByte(117))
        DataGridViewCellStyle8.SelectionForeColor = Color.White
        DataGridViewCellStyle8.WrapMode = DataGridViewTriState.False
        dgvRecent.DefaultCellStyle = DataGridViewCellStyle8
        dgvRecent.EnableHeadersVisualStyles = False
        dgvRecent.Location = New Point(15, 50)
        dgvRecent.Name = "dgvRecent"
        dgvRecent.ReadOnly = True
        DataGridViewCellStyle9.BackColor = Color.FromArgb(CByte(26), CByte(46), CByte(99))
        DataGridViewCellStyle9.ForeColor = Color.White
        dgvRecent.RowHeadersDefaultCellStyle = DataGridViewCellStyle9
        dgvRecent.RowHeadersVisible = False
        dgvRecent.RowTemplate.Height = 40
        dgvRecent.Size = New Size(670, 235)
        dgvRecent.TabIndex = 1
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
        ' lblRecentTitle
        ' 
        lblRecentTitle.AutoSize = True
        lblRecentTitle.Font = New Font("Segoe UI", 11.0F, FontStyle.Bold)
        lblRecentTitle.ForeColor = Color.White
        lblRecentTitle.Location = New Point(15, 18)
        lblRecentTitle.Name = "lblRecentTitle"
        lblRecentTitle.Size = New Size(143, 20)
        lblRecentTitle.TabIndex = 0
        lblRecentTitle.Text = "My recent requests"
        ' 
        ' btnCreateRequest
        ' 
        btnCreateRequest.Anchor = AnchorStyles.Top Or AnchorStyles.Left Or AnchorStyles.Right
        btnCreateRequest.BackColor = Color.FromArgb(CByte(245), CByte(197), CByte(24))
        btnCreateRequest.FlatAppearance.BorderSize = 0
        btnCreateRequest.FlatStyle = FlatStyle.Flat
        btnCreateRequest.Font = New Font("Segoe UI", 12.0F, FontStyle.Bold)
        btnCreateRequest.ForeColor = Color.FromArgb(CByte(15), CByte(31), CByte(76))
        btnCreateRequest.Location = New Point(25, 205)
        btnCreateRequest.Name = "btnCreateRequest"
        btnCreateRequest.Size = New Size(700, 50)
        btnCreateRequest.TabIndex = 5
        btnCreateRequest.Text = "+ Create New Document Request"
        btnCreateRequest.UseVisualStyleBackColor = False
        ' 
        ' pnlCard3
        ' 
        pnlCard3.BackColor = Color.FromArgb(CByte(26), CByte(46), CByte(99))
        pnlCard3.Controls.Add(lblCard3Value)
        pnlCard3.Controls.Add(lblCard3Title)
        pnlCard3.Location = New Point(505, 95)
        pnlCard3.Name = "pnlCard3"
        pnlCard3.Size = New Size(220, 90)
        pnlCard3.TabIndex = 4
        ' 
        ' lblCard3Value
        ' 
        lblCard3Value.AutoSize = True
        lblCard3Value.Font = New Font("Segoe UI", 22.0F, FontStyle.Bold)
        lblCard3Value.ForeColor = Color.FromArgb(CByte(185), CByte(74), CByte(72))
        lblCard3Value.Location = New Point(12, 40)
        lblCard3Value.Name = "lblCard3Value"
        lblCard3Value.Size = New Size(35, 41)
        lblCard3Value.TabIndex = 1
        lblCard3Value.Text = "4"
        ' 
        ' lblCard3Title
        ' 
        lblCard3Title.AutoSize = True
        lblCard3Title.Font = New Font("Segoe UI", 8.5F)
        lblCard3Title.ForeColor = Color.LightGray
        lblCard3Title.Location = New Point(15, 18)
        lblCard3Title.Name = "lblCard3Title"
        lblCard3Title.Size = New Size(49, 15)
        lblCard3Title.TabIndex = 0
        lblCard3Title.Text = "UNPAID"
        ' 
        ' pnlCard2
        ' 
        pnlCard2.BackColor = Color.FromArgb(CByte(26), CByte(46), CByte(99))
        pnlCard2.Controls.Add(lblCard2Value)
        pnlCard2.Controls.Add(lblCard2Title)
        pnlCard2.Location = New Point(265, 95)
        pnlCard2.Name = "pnlCard2"
        pnlCard2.Size = New Size(220, 90)
        pnlCard2.TabIndex = 3
        ' 
        ' lblCard2Value
        ' 
        lblCard2Value.AutoSize = True
        lblCard2Value.Font = New Font("Segoe UI", 22.0F, FontStyle.Bold)
        lblCard2Value.ForeColor = Color.FromArgb(CByte(90), CByte(168), CByte(224))
        lblCard2Value.Location = New Point(12, 40)
        lblCard2Value.Name = "lblCard2Value"
        lblCard2Value.Size = New Size(35, 41)
        lblCard2Value.TabIndex = 1
        lblCard2Value.Text = "6"
        ' 
        ' lblCard2Title
        ' 
        lblCard2Title.AutoSize = True
        lblCard2Title.Font = New Font("Segoe UI", 8.5F)
        lblCard2Title.ForeColor = Color.LightGray
        lblCard2Title.Location = New Point(15, 18)
        lblCard2Title.Name = "lblCard2Title"
        lblCard2Title.Size = New Size(110, 15)
        lblCard2Title.TabIndex = 0
        lblCard2Title.Text = "TO RELEASE TODAY"
        ' 
        ' pnlCard1
        ' 
        pnlCard1.BackColor = Color.FromArgb(CByte(26), CByte(46), CByte(99))
        pnlCard1.Controls.Add(lblCard1Value)
        pnlCard1.Controls.Add(lblCard1Title)
        pnlCard1.Location = New Point(25, 95)
        pnlCard1.Name = "pnlCard1"
        pnlCard1.Size = New Size(220, 90)
        pnlCard1.TabIndex = 2
        ' 
        ' lblCard1Value
        ' 
        lblCard1Value.AutoSize = True
        lblCard1Value.Font = New Font("Segoe UI", 22.0F, FontStyle.Bold)
        lblCard1Value.ForeColor = Color.FromArgb(CByte(232), CByte(163), CByte(61))
        lblCard1Value.Location = New Point(12, 40)
        lblCard1Value.Name = "lblCard1Value"
        lblCard1Value.Size = New Size(52, 41)
        lblCard1Value.TabIndex = 1
        lblCard1Value.Text = "14"
        ' 
        ' lblCard1Title
        ' 
        lblCard1Title.AutoSize = True
        lblCard1Title.Font = New Font("Segoe UI", 8.5F)
        lblCard1Title.ForeColor = Color.LightGray
        lblCard1Title.Location = New Point(15, 18)
        lblCard1Title.Name = "lblCard1Title"
        lblCard1Title.Size = New Size(57, 15)
        lblCard1Title.TabIndex = 0
        lblCard1Title.Text = "PENDING"
        ' 
        ' lblWelcomeSub
        ' 
        lblWelcomeSub.AutoSize = True
        lblWelcomeSub.Font = New Font("Segoe UI", 10.0F)
        lblWelcomeSub.ForeColor = Color.LightGray
        lblWelcomeSub.Location = New Point(25, 60)
        lblWelcomeSub.Name = "lblWelcomeSub"
        lblWelcomeSub.Size = New Size(132, 19)
        lblWelcomeSub.TabIndex = 1
        lblWelcomeSub.Text = "Your requests today"
        ' 
        ' lblWelcome
        ' 
        lblWelcome.AutoSize = True
        lblWelcome.Font = New Font("Segoe UI", 18.0F, FontStyle.Bold)
        lblWelcome.ForeColor = Color.White
        lblWelcome.Location = New Point(25, 22)
        lblWelcome.Name = "lblWelcome"
        lblWelcome.Size = New Size(185, 32)
        lblWelcome.TabIndex = 0
        lblWelcome.Text = "Welcome, Staff"
        ' 
        ' frmStaffDashboard
        ' 
        AutoScaleDimensions = New SizeF(7.0F, 15.0F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(984, 600)
        Controls.Add(pnlContent)
        Controls.Add(pnlSidebar)
        Name = "frmStaffDashboard"
        Text = "Registrar Document Request System"
        WindowState = FormWindowState.Maximized
        pnlSidebar.ResumeLayout(False)
        pnlLogout.ResumeLayout(False)
        pnlLogoArea.ResumeLayout(False)
        CType(picLogo, ComponentModel.ISupportInitialize).EndInit()
        pnlContent.ResumeLayout(False)
        pnlContent.PerformLayout()
        pnlRecentCard.ResumeLayout(False)
        pnlRecentCard.PerformLayout()
        CType(dgvRecent, ComponentModel.ISupportInitialize).EndInit()
        pnlCard3.ResumeLayout(False)
        pnlCard3.PerformLayout()
        pnlCard2.ResumeLayout(False)
        pnlCard2.PerformLayout()
        pnlCard1.ResumeLayout(False)
        pnlCard1.PerformLayout()
        ResumeLayout(False)

    End Sub

    Friend WithEvents pnlSidebar As System.Windows.Forms.Panel
    Friend WithEvents pnlLogoArea As System.Windows.Forms.Panel
    Friend WithEvents picLogo As System.Windows.Forms.PictureBox
    Friend WithEvents lblRegistrarSystem As System.Windows.Forms.Label
    Friend WithEvents btnDashboard As System.Windows.Forms.Button
    Friend WithEvents btnNewRequest As System.Windows.Forms.Button
    Friend WithEvents btnRequestList As System.Windows.Forms.Button
    Friend WithEvents btnSearchStudent As System.Windows.Forms.Button
    Friend WithEvents btnReports As System.Windows.Forms.Button
    Friend WithEvents pnlLogout As System.Windows.Forms.Panel
    Friend WithEvents btnLogout As System.Windows.Forms.Button
    Friend WithEvents pnlContent As System.Windows.Forms.Panel
    Friend WithEvents lblWelcome As System.Windows.Forms.Label
    Friend WithEvents lblWelcomeSub As System.Windows.Forms.Label
    Friend WithEvents pnlCard1 As System.Windows.Forms.Panel
    Friend WithEvents lblCard1Title As System.Windows.Forms.Label
    Friend WithEvents lblCard1Value As System.Windows.Forms.Label
    Friend WithEvents pnlCard2 As System.Windows.Forms.Panel
    Friend WithEvents lblCard2Title As System.Windows.Forms.Label
    Friend WithEvents lblCard2Value As System.Windows.Forms.Label
    Friend WithEvents pnlCard3 As System.Windows.Forms.Panel
    Friend WithEvents lblCard3Title As System.Windows.Forms.Label
    Friend WithEvents lblCard3Value As System.Windows.Forms.Label
    Friend WithEvents btnCreateRequest As System.Windows.Forms.Button
    Friend WithEvents pnlRecentCard As System.Windows.Forms.Panel
    Friend WithEvents lblRecentTitle As System.Windows.Forms.Label
    Friend WithEvents dgvRecent As System.Windows.Forms.DataGridView
    Friend WithEvents colRequestNo As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents colStudent As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents colDocument As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents colStatus As System.Windows.Forms.DataGridViewTextBoxColumn

End Class
