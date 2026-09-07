<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmLogin
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmLogin))
        pnlLeft = New Panel()
        picLogo = New PictureBox()
        pnlRight = New Panel()
        lblVersion = New Label()
        btnLogin = New Button()
        txtPassword = New TextBox()
        lblPassword = New Label()
        txtUsername = New TextBox()
        lblUsername = New Label()
        pnlToggle = New Panel()
        btnStaff = New Button()
        btnAdmin = New Button()
        lblTitle = New Label()
        pnlLeft.SuspendLayout()
        CType(picLogo, ComponentModel.ISupportInitialize).BeginInit()
        pnlRight.SuspendLayout()
        pnlToggle.SuspendLayout()
        SuspendLayout()
        ' 
        ' pnlLeft
        ' 
        pnlLeft.BackColor = Color.White
        pnlLeft.Controls.Add(picLogo)
        pnlLeft.Dock = DockStyle.Left
        pnlLeft.Location = New Point(0, 0)
        pnlLeft.Name = "pnlLeft"
        pnlLeft.Size = New Size(350, 520)
        pnlLeft.TabIndex = 0
        ' 
        ' picLogo
        ' 
        picLogo.Anchor = AnchorStyles.None
        picLogo.BackColor = Color.White
        picLogo.Image = CType(resources.GetObject("picLogo.Image"), Image)
        picLogo.Location = New Point(100, 160)
        picLogo.Name = "picLogo"
        picLogo.Size = New Size(150, 150)
        picLogo.SizeMode = PictureBoxSizeMode.Zoom
        picLogo.TabIndex = 0
        picLogo.TabStop = False
        ' 
        ' pnlRight
        ' 
        pnlRight.BackColor = Color.FromArgb(CByte(245), CByte(197), CByte(24))
        pnlRight.Controls.Add(lblVersion)
        pnlRight.Controls.Add(btnLogin)
        pnlRight.Controls.Add(txtPassword)
        pnlRight.Controls.Add(lblPassword)
        pnlRight.Controls.Add(txtUsername)
        pnlRight.Controls.Add(lblUsername)
        pnlRight.Controls.Add(pnlToggle)
        pnlRight.Controls.Add(lblTitle)
        pnlRight.Dock = DockStyle.Fill
        pnlRight.Location = New Point(350, 0)
        pnlRight.Name = "pnlRight"
        pnlRight.Size = New Size(400, 520)
        pnlRight.TabIndex = 1
        ' 
        ' lblVersion
        ' 
        lblVersion.Font = New Font("Segoe UI", 8F)
        lblVersion.ForeColor = Color.FromArgb(CByte(90), CByte(78), CByte(18))
        lblVersion.Location = New Point(40, 395)
        lblVersion.Name = "lblVersion"
        lblVersion.Size = New Size(310, 15)
        lblVersion.TabIndex = 8
        lblVersion.Text = "Registrar Document Request System v1.0"
        lblVersion.TextAlign = ContentAlignment.MiddleCenter
        ' 
        ' btnLogin
        ' 
        btnLogin.BackColor = Color.FromArgb(CByte(15), CByte(31), CByte(76))
        btnLogin.FlatAppearance.BorderSize = 0
        btnLogin.FlatStyle = FlatStyle.Flat
        btnLogin.Font = New Font("Segoe UI Semibold", 12F, FontStyle.Bold)
        btnLogin.ForeColor = Color.White
        btnLogin.Location = New Point(40, 330)
        btnLogin.Name = "btnLogin"
        btnLogin.Size = New Size(310, 48)
        btnLogin.TabIndex = 7
        btnLogin.Text = "Log in"
        btnLogin.UseVisualStyleBackColor = False
        ' 
        ' txtPassword
        ' 
        txtPassword.BackColor = Color.FromArgb(CByte(255), CByte(249), CByte(229))
        txtPassword.BorderStyle = BorderStyle.FixedSingle
        txtPassword.Font = New Font("Segoe UI", 11F)
        txtPassword.ForeColor = Color.FromArgb(CByte(43), CByte(43), CByte(43))
        txtPassword.Location = New Point(40, 282)
        txtPassword.Name = "txtPassword"
        txtPassword.PasswordChar = "●"c
        txtPassword.Size = New Size(310, 27)
        txtPassword.TabIndex = 6
        ' 
        ' lblPassword
        ' 
        lblPassword.AutoSize = True
        lblPassword.Font = New Font("Segoe UI Semibold", 8.5F, FontStyle.Bold)
        lblPassword.ForeColor = Color.FromArgb(CByte(15), CByte(31), CByte(76))
        lblPassword.Location = New Point(40, 262)
        lblPassword.Name = "lblPassword"
        lblPassword.Size = New Size(72, 15)
        lblPassword.TabIndex = 5
        lblPassword.Text = "PASSWORD"
        ' 
        ' txtUsername
        ' 
        txtUsername.BackColor = Color.FromArgb(CByte(255), CByte(249), CByte(229))
        txtUsername.BorderStyle = BorderStyle.FixedSingle
        txtUsername.Font = New Font("Segoe UI", 11F)
        txtUsername.ForeColor = Color.FromArgb(CByte(43), CByte(43), CByte(43))
        txtUsername.Location = New Point(40, 218)
        txtUsername.Name = "txtUsername"
        txtUsername.Size = New Size(310, 27)
        txtUsername.TabIndex = 4
        ' 
        ' lblUsername
        ' 
        lblUsername.AutoSize = True
        lblUsername.Font = New Font("Segoe UI Semibold", 8.5F, FontStyle.Bold)
        lblUsername.ForeColor = Color.FromArgb(CByte(15), CByte(31), CByte(76))
        lblUsername.Location = New Point(40, 198)
        lblUsername.Name = "lblUsername"
        lblUsername.Size = New Size(69, 15)
        lblUsername.TabIndex = 3
        lblUsername.Text = "USERNAME"
        ' 
        ' pnlToggle
        ' 
        pnlToggle.BackColor = Color.FromArgb(CByte(15), CByte(31), CByte(76))
        pnlToggle.Controls.Add(btnStaff)
        pnlToggle.Controls.Add(btnAdmin)
        pnlToggle.Location = New Point(40, 135)
        pnlToggle.Name = "pnlToggle"
        pnlToggle.Size = New Size(310, 42)
        pnlToggle.TabIndex = 2
        ' 
        ' btnStaff
        ' 
        btnStaff.BackColor = Color.FromArgb(CByte(15), CByte(31), CByte(76))
        btnStaff.Dock = DockStyle.Fill
        btnStaff.FlatAppearance.BorderSize = 0
        btnStaff.FlatStyle = FlatStyle.Flat
        btnStaff.Font = New Font("Segoe UI Semibold", 8.5F, FontStyle.Bold)
        btnStaff.ForeColor = Color.White
        btnStaff.Location = New Point(155, 0)
        btnStaff.Name = "btnStaff"
        btnStaff.Size = New Size(155, 42)
        btnStaff.TabIndex = 1
        btnStaff.Text = "REGISTRAR STAFF"
        btnStaff.UseVisualStyleBackColor = False
        ' 
        ' btnAdmin
        ' 
        btnAdmin.BackColor = Color.White
        btnAdmin.Dock = DockStyle.Left
        btnAdmin.FlatAppearance.BorderSize = 0
        btnAdmin.FlatStyle = FlatStyle.Flat
        btnAdmin.Font = New Font("Segoe UI Semibold", 8.5F, FontStyle.Bold)
        btnAdmin.ForeColor = Color.FromArgb(CByte(15), CByte(31), CByte(76))
        btnAdmin.Location = New Point(0, 0)
        btnAdmin.Name = "btnAdmin"
        btnAdmin.Size = New Size(155, 42)
        btnAdmin.TabIndex = 0
        btnAdmin.Text = "ADMINISTRATOR"
        btnAdmin.UseVisualStyleBackColor = False
        ' 
        ' lblTitle
        ' 
        lblTitle.AutoSize = True
        lblTitle.Font = New Font("Segoe UI Semibold", 18F, FontStyle.Bold)
        lblTitle.ForeColor = Color.FromArgb(CByte(15), CByte(31), CByte(76))
        lblTitle.Location = New Point(40, 78)
        lblTitle.Name = "lblTitle"
        lblTitle.Size = New Size(191, 32)
        lblTitle.TabIndex = 0
        lblTitle.Text = "Sign in to portal"
        ' 
        ' frmLogin
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(750, 520)
        Controls.Add(pnlRight)
        Controls.Add(pnlLeft)
        FormBorderStyle = FormBorderStyle.FixedSingle
        MaximizeBox = False
        Name = "frmLogin"
        StartPosition = FormStartPosition.CenterScreen
        Text = "Registrar Document Request System - Login"
        pnlLeft.ResumeLayout(False)
        CType(picLogo, ComponentModel.ISupportInitialize).EndInit()
        pnlRight.ResumeLayout(False)
        pnlRight.PerformLayout()
        pnlToggle.ResumeLayout(False)
        ResumeLayout(False)

    End Sub

    Friend WithEvents pnlLeft As System.Windows.Forms.Panel
    Friend WithEvents picLogo As System.Windows.Forms.PictureBox
    Friend WithEvents pnlRight As System.Windows.Forms.Panel
    Friend WithEvents lblTitle As System.Windows.Forms.Label
    Friend WithEvents pnlToggle As System.Windows.Forms.Panel
    Friend WithEvents btnAdmin As System.Windows.Forms.Button
    Friend WithEvents btnStaff As System.Windows.Forms.Button
    Friend WithEvents lblUsername As System.Windows.Forms.Label
    Friend WithEvents txtUsername As System.Windows.Forms.TextBox
    Friend WithEvents lblPassword As System.Windows.Forms.Label
    Friend WithEvents txtPassword As System.Windows.Forms.TextBox
    Friend WithEvents btnLogin As System.Windows.Forms.Button
    Friend WithEvents lblVersion As System.Windows.Forms.Label

End Class
