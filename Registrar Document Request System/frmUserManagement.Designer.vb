<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmUserManagement
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
        Dim DataGridViewCellStyle6 As DataGridViewCellStyle = New DataGridViewCellStyle()
        Dim DataGridViewCellStyle5 As DataGridViewCellStyle = New DataGridViewCellStyle()
        pnlMainCard = New Panel()
        dgvUsers = New DataGridView()
        colFullName = New DataGridViewTextBoxColumn()
        colUsername = New DataGridViewTextBoxColumn()
        colRole = New DataGridViewTextBoxColumn()
        colStatus = New DataGridViewTextBoxColumn()
        colActions = New DataGridViewTextBoxColumn()
        pnlSearchFilter = New Panel()
        btnSearch = New Button()
        txtSearch = New TextBox()
        pnlHeader = New Panel()
        btnAddUser = New Button()
        lblTitle = New Label()
        pnlMainCard.SuspendLayout()
        CType(dgvUsers, ComponentModel.ISupportInitialize).BeginInit()
        pnlSearchFilter.SuspendLayout()
        pnlHeader.SuspendLayout()
        SuspendLayout()
        ' 
        ' pnlMainCard
        ' 
        pnlMainCard.Anchor = AnchorStyles.Top Or AnchorStyles.Bottom Or AnchorStyles.Left Or AnchorStyles.Right
        pnlMainCard.BackColor = Color.FromArgb(CByte(255), CByte(249), CByte(229))
        pnlMainCard.Controls.Add(dgvUsers)
        pnlMainCard.Controls.Add(pnlSearchFilter)
        pnlMainCard.Controls.Add(pnlHeader)
        pnlMainCard.Location = New Point(34, 33)
        pnlMainCard.Margin = New Padding(3, 4, 3, 4)
        pnlMainCard.Name = "pnlMainCard"
        pnlMainCard.Size = New Size(983, 693)
        pnlMainCard.TabIndex = 0
        ' 
        ' dgvUsers
        ' 
        dgvUsers.AllowUserToAddRows = False
        dgvUsers.AllowUserToDeleteRows = False
        dgvUsers.Anchor = AnchorStyles.Top Or AnchorStyles.Bottom Or AnchorStyles.Left Or AnchorStyles.Right
        dgvUsers.BackgroundColor = Color.White
        dgvUsers.BorderStyle = BorderStyle.None
        dgvUsers.CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal
        dgvUsers.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None
        DataGridViewCellStyle4.Alignment = DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle4.BackColor = Color.FromArgb(CByte(15), CByte(31), CByte(76))
        DataGridViewCellStyle4.Font = New Font("Segoe UI", 9F, FontStyle.Bold)
        DataGridViewCellStyle4.ForeColor = Color.White
        DataGridViewCellStyle4.SelectionBackColor = Color.FromArgb(CByte(15), CByte(31), CByte(76))
        DataGridViewCellStyle4.SelectionForeColor = Color.White
        DataGridViewCellStyle4.WrapMode = DataGridViewTriState.True
        dgvUsers.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle4
        dgvUsers.ColumnHeadersHeight = 38
        dgvUsers.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.DisableResizing
        dgvUsers.Columns.AddRange(New DataGridViewColumn() {colFullName, colUsername, colRole, colStatus, colActions})
        DataGridViewCellStyle6.Alignment = DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle6.BackColor = Color.White
        DataGridViewCellStyle6.Font = New Font("Segoe UI", 9.5F)
        DataGridViewCellStyle6.ForeColor = Color.FromArgb(CByte(43), CByte(43), CByte(43))
        DataGridViewCellStyle6.SelectionBackColor = Color.FromArgb(CByte(240), CByte(244), CByte(255))
        DataGridViewCellStyle6.SelectionForeColor = Color.FromArgb(CByte(15), CByte(31), CByte(76))
        DataGridViewCellStyle6.WrapMode = DataGridViewTriState.False
        dgvUsers.DefaultCellStyle = DataGridViewCellStyle6
        dgvUsers.EnableHeadersVisualStyles = False
        dgvUsers.GridColor = Color.FromArgb(CByte(235), CByte(235), CByte(235))
        dgvUsers.Location = New Point(29, 167)
        dgvUsers.Margin = New Padding(3, 4, 3, 4)
        dgvUsers.Name = "dgvUsers"
        dgvUsers.ReadOnly = True
        dgvUsers.RowHeadersVisible = False
        dgvUsers.RowHeadersWidth = 51
        dgvUsers.RowTemplate.Height = 42
        dgvUsers.SelectionMode = DataGridViewSelectionMode.FullRowSelect
        dgvUsers.Size = New Size(926, 487)
        dgvUsers.TabIndex = 2
        ' 
        ' colFullName
        ' 
        colFullName.HeaderText = "FULL NAME"
        colFullName.MinimumWidth = 6
        colFullName.Name = "colFullName"
        colFullName.ReadOnly = True
        colFullName.Width = 240
        ' 
        ' colUsername
        ' 
        colUsername.HeaderText = "USERNAME"
        colUsername.MinimumWidth = 6
        colUsername.Name = "colUsername"
        colUsername.ReadOnly = True
        colUsername.Width = 180
        ' 
        ' colRole
        ' 
        colRole.HeaderText = "ROLE"
        colRole.MinimumWidth = 6
        colRole.Name = "colRole"
        colRole.ReadOnly = True
        colRole.Width = 160
        ' 
        ' colStatus
        ' 
        DataGridViewCellStyle5.Alignment = DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle5.Font = New Font("Segoe UI", 9F, FontStyle.Bold)
        colStatus.DefaultCellStyle = DataGridViewCellStyle5
        colStatus.HeaderText = "STATUS"
        colStatus.MinimumWidth = 6
        colStatus.Name = "colStatus"
        colStatus.ReadOnly = True
        colStatus.Width = 125
        ' 
        ' colActions
        ' 
        colActions.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill
        colActions.HeaderText = "ACTIONS"
        colActions.MinimumWidth = 6
        colActions.Name = "colActions"
        colActions.ReadOnly = True
        ' 
        ' pnlSearchFilter
        ' 
        pnlSearchFilter.Anchor = AnchorStyles.Top Or AnchorStyles.Left Or AnchorStyles.Right
        pnlSearchFilter.BackColor = Color.FromArgb(CByte(255), CByte(249), CByte(229))
        pnlSearchFilter.Controls.Add(btnSearch)
        pnlSearchFilter.Controls.Add(txtSearch)
        pnlSearchFilter.Location = New Point(29, 91)
        pnlSearchFilter.Margin = New Padding(3, 4, 3, 4)
        pnlSearchFilter.Name = "pnlSearchFilter"
        pnlSearchFilter.Size = New Size(926, 56)
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
        btnSearch.Location = New Point(811, 7)
        btnSearch.Margin = New Padding(3, 4, 3, 4)
        btnSearch.Name = "btnSearch"
        btnSearch.Size = New Size(114, 43)
        btnSearch.TabIndex = 1
        btnSearch.Text = "Search"
        btnSearch.UseVisualStyleBackColor = False
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
        txtSearch.Size = New Size(794, 31)
        txtSearch.TabIndex = 0
        ' 
        ' pnlHeader
        ' 
        pnlHeader.BackColor = Color.FromArgb(CByte(15), CByte(31), CByte(76))
        pnlHeader.Controls.Add(btnAddUser)
        pnlHeader.Controls.Add(lblTitle)
        pnlHeader.Dock = DockStyle.Top
        pnlHeader.Location = New Point(0, 0)
        pnlHeader.Margin = New Padding(3, 4, 3, 4)
        pnlHeader.Name = "pnlHeader"
        pnlHeader.Size = New Size(983, 69)
        pnlHeader.TabIndex = 0
        ' 
        ' btnAddUser
        ' 
        btnAddUser.Anchor = AnchorStyles.Top Or AnchorStyles.Right
        btnAddUser.BackColor = Color.FromArgb(CByte(245), CByte(197), CByte(24))
        btnAddUser.Cursor = Cursors.Hand
        btnAddUser.FlatAppearance.BorderSize = 0
        btnAddUser.FlatStyle = FlatStyle.Flat
        btnAddUser.Font = New Font("Segoe UI", 9.5F, FontStyle.Bold)
        btnAddUser.ForeColor = Color.FromArgb(CByte(15), CByte(31), CByte(76))
        btnAddUser.Location = New Point(771, 13)
        btnAddUser.Margin = New Padding(3, 4, 3, 4)
        btnAddUser.Name = "btnAddUser"
        btnAddUser.Size = New Size(194, 43)
        btnAddUser.TabIndex = 1
        btnAddUser.Text = "+ Add System User"
        btnAddUser.UseVisualStyleBackColor = False
        ' 
        ' lblTitle
        ' 
        lblTitle.AutoSize = True
        lblTitle.Font = New Font("Segoe UI", 12F, FontStyle.Bold)
        lblTitle.ForeColor = Color.White
        lblTitle.Location = New Point(23, 20)
        lblTitle.Name = "lblTitle"
        lblTitle.Size = New Size(185, 28)
        lblTitle.TabIndex = 0
        lblTitle.Text = "User Management"
        ' 
        ' frmUserManagement
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.FromArgb(CByte(255), CByte(249), CByte(229))
        ClientSize = New Size(1051, 760)
        Controls.Add(pnlMainCard)
        Margin = New Padding(3, 4, 3, 4)
        Name = "frmUserManagement"
        StartPosition = FormStartPosition.CenterScreen
        Text = "User Management"
        pnlMainCard.ResumeLayout(False)
        CType(dgvUsers, ComponentModel.ISupportInitialize).EndInit()
        pnlSearchFilter.ResumeLayout(False)
        pnlSearchFilter.PerformLayout()
        pnlHeader.ResumeLayout(False)
        pnlHeader.PerformLayout()
        ResumeLayout(False)

    End Sub

    Friend WithEvents pnlMainCard As System.Windows.Forms.Panel
    Friend WithEvents pnlHeader As System.Windows.Forms.Panel
    Friend WithEvents lblTitle As System.Windows.Forms.Label
    Friend WithEvents btnAddUser As System.Windows.Forms.Button
    Friend WithEvents pnlSearchFilter As System.Windows.Forms.Panel
    Friend WithEvents txtSearch As System.Windows.Forms.TextBox
    Friend WithEvents btnSearch As System.Windows.Forms.Button
    Friend WithEvents dgvUsers As System.Windows.Forms.DataGridView
    Friend WithEvents colFullName As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents colUsername As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents colRole As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents colStatus As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents colActions As System.Windows.Forms.DataGridViewTextBoxColumn

End Class
