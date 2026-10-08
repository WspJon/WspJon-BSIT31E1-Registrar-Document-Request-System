<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmUserAddEdit
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
        lblTitle = New Label()
        pnlHeader = New Panel()
        lblFullName = New Label()
        txtFullName = New TextBox()
        lblUsername = New Label()
        txtUsername = New TextBox()
        lblPassword = New Label()
        txtPassword = New TextBox()
        lblRole = New Label()
        cboRole = New ComboBox()
        lblStatus = New Label()
        cboStatus = New ComboBox()
        btnSave = New Button()
        btnCancel = New Button()
        pnlHeader.SuspendLayout()
        SuspendLayout()
        ' 
        ' lblTitle
        ' 
        lblTitle.AutoSize = True
        lblTitle.Font = New Font("Segoe UI", 14.0F, FontStyle.Bold)
        lblTitle.ForeColor = Color.White
        lblTitle.Location = New Point(23, 24)
        lblTitle.Name = "lblTitle"
        lblTitle.Size = New Size(206, 32)
        lblTitle.TabIndex = 0
        lblTitle.Text = "Add System User"
        ' 
        ' pnlHeader
        ' 
        pnlHeader.BackColor = Color.FromArgb(CByte(15), CByte(31), CByte(76))
        pnlHeader.Controls.Add(lblTitle)
        pnlHeader.Dock = DockStyle.Top
        pnlHeader.Location = New Point(0, 0)
        pnlHeader.Margin = New Padding(3, 4, 3, 4)
        pnlHeader.Name = "pnlHeader"
        pnlHeader.Size = New Size(457, 80)
        pnlHeader.TabIndex = 0
        ' 
        ' lblFullName
        ' 
        lblFullName.AutoSize = True
        lblFullName.Font = New Font("Segoe UI", 9.5F)
        lblFullName.Location = New Point(29, 107)
        lblFullName.Name = "lblFullName"
        lblFullName.Size = New Size(81, 21)
        lblFullName.TabIndex = 1
        lblFullName.Text = "Full Name"
        ' 
        ' txtFullName
        ' 
        txtFullName.Font = New Font("Segoe UI", 10.0F)
        txtFullName.Location = New Point(29, 133)
        txtFullName.Margin = New Padding(3, 4, 3, 4)
        txtFullName.Name = "txtFullName"
        txtFullName.Size = New Size(399, 30)
        txtFullName.TabIndex = 2
        ' 
        ' lblUsername
        ' 
        lblUsername.AutoSize = True
        lblUsername.Font = New Font("Segoe UI", 9.5F)
        lblUsername.Location = New Point(29, 187)
        lblUsername.Name = "lblUsername"
        lblUsername.Size = New Size(81, 21)
        lblUsername.TabIndex = 3
        lblUsername.Text = "Username"
        ' 
        ' txtUsername
        ' 
        txtUsername.Font = New Font("Segoe UI", 10.0F)
        txtUsername.Location = New Point(29, 213)
        txtUsername.Margin = New Padding(3, 4, 3, 4)
        txtUsername.Name = "txtUsername"
        txtUsername.Size = New Size(399, 30)
        txtUsername.TabIndex = 4
        ' 
        ' lblPassword
        ' 
        lblPassword.AutoSize = True
        lblPassword.Font = New Font("Segoe UI", 9.5F)
        lblPassword.Location = New Point(29, 267)
        lblPassword.Name = "lblPassword"
        lblPassword.Size = New Size(76, 21)
        lblPassword.TabIndex = 5
        lblPassword.Text = "Password"
        ' 
        ' txtPassword
        ' 
        txtPassword.Font = New Font("Segoe UI", 10.0F)
        txtPassword.Location = New Point(29, 293)
        txtPassword.Margin = New Padding(3, 4, 3, 4)
        txtPassword.Name = "txtPassword"
        txtPassword.Size = New Size(399, 30)
        txtPassword.TabIndex = 6
        txtPassword.UseSystemPasswordChar = True
        ' 
        ' lblRole
        ' 
        lblRole.AutoSize = True
        lblRole.Font = New Font("Segoe UI", 9.5F)
        lblRole.Location = New Point(29, 347)
        lblRole.Name = "lblRole"
        lblRole.Size = New Size(41, 21)
        lblRole.TabIndex = 7
        lblRole.Text = "Role"
        ' 
        ' cboRole
        ' 
        cboRole.DropDownStyle = ComboBoxStyle.DropDownList
        cboRole.Font = New Font("Segoe UI", 10.0F)
        cboRole.FormattingEnabled = True
        cboRole.Items.AddRange(New Object() {"Administrator", "Registrar Staff"})
        cboRole.Location = New Point(29, 373)
        cboRole.Margin = New Padding(3, 4, 3, 4)
        cboRole.Name = "cboRole"
        cboRole.Size = New Size(182, 31)
        cboRole.TabIndex = 8
        ' 
        ' lblStatus
        ' 
        lblStatus.AutoSize = True
        lblStatus.Font = New Font("Segoe UI", 9.5F)
        lblStatus.Location = New Point(246, 347)
        lblStatus.Name = "lblStatus"
        lblStatus.Size = New Size(52, 21)
        lblStatus.TabIndex = 9
        lblStatus.Text = "Status"
        ' 
        ' cboStatus
        ' 
        cboStatus.DropDownStyle = ComboBoxStyle.DropDownList
        cboStatus.Font = New Font("Segoe UI", 10.0F)
        cboStatus.FormattingEnabled = True
        cboStatus.Items.AddRange(New Object() {"Active", "Inactive"})
        cboStatus.Location = New Point(246, 373)
        cboStatus.Margin = New Padding(3, 4, 3, 4)
        cboStatus.Name = "cboStatus"
        cboStatus.Size = New Size(182, 31)
        cboStatus.TabIndex = 10
        ' 
        ' btnSave
        ' 
        btnSave.BackColor = Color.FromArgb(CByte(15), CByte(31), CByte(76))
        btnSave.Cursor = Cursors.Hand
        btnSave.FlatAppearance.BorderSize = 0
        btnSave.FlatStyle = FlatStyle.Flat
        btnSave.Font = New Font("Segoe UI", 10.0F, FontStyle.Bold)
        btnSave.ForeColor = Color.White
        btnSave.Location = New Point(303, 440)
        btnSave.Margin = New Padding(3, 4, 3, 4)
        btnSave.Name = "btnSave"
        btnSave.Size = New Size(126, 47)
        btnSave.TabIndex = 11
        btnSave.Text = "Save"
        btnSave.UseVisualStyleBackColor = False
        ' 
        ' btnCancel
        ' 
        btnCancel.BackColor = Color.White
        btnCancel.Cursor = Cursors.Hand
        btnCancel.FlatAppearance.BorderColor = Color.FromArgb(CByte(15), CByte(31), CByte(76))
        btnCancel.FlatStyle = FlatStyle.Flat
        btnCancel.Font = New Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        btnCancel.ForeColor = Color.FromArgb(CByte(15), CByte(31), CByte(76))
        btnCancel.Location = New Point(166, 440)
        btnCancel.Margin = New Padding(3, 4, 3, 4)
        btnCancel.Name = "btnCancel"
        btnCancel.Size = New Size(126, 47)
        btnCancel.TabIndex = 12
        btnCancel.Text = "Cancel"
        btnCancel.UseVisualStyleBackColor = False
        ' 
        ' frmUserAddEdit
        ' 
        AutoScaleDimensions = New SizeF(8.0F, 20.0F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.FromArgb(CByte(255), CByte(249), CByte(229))
        ClientSize = New Size(457, 520)
        Controls.Add(btnCancel)
        Controls.Add(btnSave)
        Controls.Add(cboStatus)
        Controls.Add(lblStatus)
        Controls.Add(cboRole)
        Controls.Add(lblRole)
        Controls.Add(txtPassword)
        Controls.Add(lblPassword)
        Controls.Add(txtUsername)
        Controls.Add(lblUsername)
        Controls.Add(txtFullName)
        Controls.Add(lblFullName)
        Controls.Add(pnlHeader)
        Font = New Font("Segoe UI", 9.0F)
        FormBorderStyle = FormBorderStyle.FixedDialog
        Margin = New Padding(3, 4, 3, 4)
        MaximizeBox = False
        MinimizeBox = False
        Name = "frmUserAddEdit"
        StartPosition = FormStartPosition.CenterParent
        Text = "User Details"
        pnlHeader.ResumeLayout(False)
        pnlHeader.PerformLayout()
        ResumeLayout(False)
        PerformLayout()

    End Sub

    Friend WithEvents pnlHeader As System.Windows.Forms.Panel
    Friend WithEvents lblTitle As System.Windows.Forms.Label
    Friend WithEvents lblFullName As System.Windows.Forms.Label
    Friend WithEvents txtFullName As System.Windows.Forms.TextBox
    Friend WithEvents lblUsername As System.Windows.Forms.Label
    Friend WithEvents txtUsername As System.Windows.Forms.TextBox
    Friend WithEvents lblPassword As System.Windows.Forms.Label
    Friend WithEvents txtPassword As System.Windows.Forms.TextBox
    Friend WithEvents lblRole As System.Windows.Forms.Label
    Friend WithEvents cboRole As System.Windows.Forms.ComboBox
    Friend WithEvents lblStatus As System.Windows.Forms.Label
    Friend WithEvents cboStatus As System.Windows.Forms.ComboBox
    Friend WithEvents btnSave As System.Windows.Forms.Button
    Friend WithEvents btnCancel As System.Windows.Forms.Button
End Class
