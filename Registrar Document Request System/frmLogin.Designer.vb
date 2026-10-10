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
        Label2 = New Label()
        Label1 = New Label()
        picLogo = New PictureBox()
        pnlRight = New Panel()
        chkShowPassword = New CheckBox()
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
        pnlLeft.BackColor = Color.FromArgb(CByte(255), CByte(249), CByte(229))
        pnlLeft.Controls.Add(Label2)
        pnlLeft.Controls.Add(Label1)
        pnlLeft.Controls.Add(picLogo)
        pnlLeft.Dock = DockStyle.Left
        pnlLeft.Location = New Point(0, 0)
        pnlLeft.Margin = New Padding(3, 4, 3, 4)
        pnlLeft.Name = "pnlLeft"
        pnlLeft.Size = New Size(400, 693)
        pnlLeft.TabIndex = 0
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Font = New Font("Segoe UI Black", 18F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label2.ForeColor = Color.FromArgb(CByte(15), CByte(31), CByte(76))
        Label2.Location = New Point(103, 420)
        Label2.Name = "Label2"
        Label2.Size = New Size(194, 41)
        Label2.TabIndex = 2
        Label2.Text = "REGISTRAR "
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Font = New Font("Segoe UI Black", 18F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label1.ForeColor = Color.FromArgb(CByte(15), CByte(31), CByte(76))
        Label1.Location = New Point(33, 365)
        Label1.Name = "Label1"
        Label1.Size = New Size(348, 41)
        Label1.TabIndex = 1
        Label1.Text = "LYCEUM OF ALABANG"
        ' 
        ' picLogo
        ' 
        picLogo.Anchor = AnchorStyles.None
        picLogo.BackColor = Color.FromArgb(CByte(255), CByte(249), CByte(229))
        picLogo.Image = CType(resources.GetObject("picLogo.Image"), Image)
        picLogo.Location = New Point(103, 136)
        picLogo.Margin = New Padding(3, 4, 3, 4)
        picLogo.Name = "picLogo"
        picLogo.Size = New Size(171, 200)
        picLogo.SizeMode = PictureBoxSizeMode.Zoom
        picLogo.TabIndex = 0
        picLogo.TabStop = False
        ' 
        ' pnlRight
        ' 
        pnlRight.BackColor = Color.FromArgb(CByte(245), CByte(197), CByte(24))
        pnlRight.Controls.Add(chkShowPassword)
        pnlRight.Controls.Add(btnLogin)
        pnlRight.Controls.Add(txtPassword)
        pnlRight.Controls.Add(lblPassword)
        pnlRight.Controls.Add(txtUsername)
        pnlRight.Controls.Add(lblUsername)
        pnlRight.Controls.Add(pnlToggle)
        pnlRight.Controls.Add(lblTitle)
        pnlRight.Dock = DockStyle.Fill
        pnlRight.Location = New Point(400, 0)
        pnlRight.Margin = New Padding(3, 4, 3, 4)
        pnlRight.Name = "pnlRight"
        pnlRight.Size = New Size(457, 693)
        pnlRight.TabIndex = 1
        ' 
        ' chkShowPassword
        ' 
        chkShowPassword.AutoSize = True
        chkShowPassword.Location = New Point(46, 420)
        chkShowPassword.Margin = New Padding(3, 4, 3, 4)
        chkShowPassword.Name = "chkShowPassword"
        chkShowPassword.Size = New Size(132, 24)
        chkShowPassword.TabIndex = 8
        chkShowPassword.Text = "Show Password"
        chkShowPassword.UseVisualStyleBackColor = True
        ' 
        ' btnLogin
        ' 
        btnLogin.BackColor = Color.FromArgb(CByte(15), CByte(31), CByte(76))
        btnLogin.FlatAppearance.BorderSize = 0
        btnLogin.FlatStyle = FlatStyle.Flat
        btnLogin.Font = New Font("Segoe UI Semibold", 12F, FontStyle.Bold)
        btnLogin.ForeColor = Color.White
        btnLogin.Location = New Point(46, 449)
        btnLogin.Margin = New Padding(3, 4, 3, 4)
        btnLogin.Name = "btnLogin"
        btnLogin.Size = New Size(354, 64)
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
        txtPassword.Location = New Point(46, 376)
        txtPassword.Margin = New Padding(3, 4, 3, 4)
        txtPassword.Name = "txtPassword"
        txtPassword.PasswordChar = "●"c
        txtPassword.Size = New Size(354, 32)
        txtPassword.TabIndex = 6
        ' 
        ' lblPassword
        ' 
        lblPassword.AutoSize = True
        lblPassword.Font = New Font("Segoe UI Semibold", 8.5F, FontStyle.Bold)
        lblPassword.ForeColor = Color.FromArgb(CByte(15), CByte(31), CByte(76))
        lblPassword.Location = New Point(46, 349)
        lblPassword.Name = "lblPassword"
        lblPassword.Size = New Size(88, 20)
        lblPassword.TabIndex = 5
        lblPassword.Text = "PASSWORD"
        ' 
        ' txtUsername
        ' 
        txtUsername.BackColor = Color.FromArgb(CByte(255), CByte(249), CByte(229))
        txtUsername.BorderStyle = BorderStyle.FixedSingle
        txtUsername.Font = New Font("Segoe UI", 11F)
        txtUsername.ForeColor = Color.FromArgb(CByte(43), CByte(43), CByte(43))
        txtUsername.Location = New Point(46, 291)
        txtUsername.Margin = New Padding(3, 4, 3, 4)
        txtUsername.Name = "txtUsername"
        txtUsername.Size = New Size(354, 32)
        txtUsername.TabIndex = 4
        ' 
        ' lblUsername
        ' 
        lblUsername.AutoSize = True
        lblUsername.Font = New Font("Segoe UI Semibold", 8.5F, FontStyle.Bold)
        lblUsername.ForeColor = Color.FromArgb(CByte(15), CByte(31), CByte(76))
        lblUsername.Location = New Point(46, 264)
        lblUsername.Name = "lblUsername"
        lblUsername.Size = New Size(89, 20)
        lblUsername.TabIndex = 3
        lblUsername.Text = "USERNAME"
        ' 
        ' pnlToggle
        ' 
        pnlToggle.BackColor = Color.FromArgb(CByte(15), CByte(31), CByte(76))
        pnlToggle.Controls.Add(btnStaff)
        pnlToggle.Controls.Add(btnAdmin)
        pnlToggle.Location = New Point(46, 180)
        pnlToggle.Margin = New Padding(3, 4, 3, 4)
        pnlToggle.Name = "pnlToggle"
        pnlToggle.Size = New Size(354, 56)
        pnlToggle.TabIndex = 2
        ' 
        ' btnStaff
        ' 
        btnStaff.BackColor = Color.FromArgb(CByte(15), CByte(31), CByte(76))
        btnStaff.Dock = DockStyle.Fill
        btnStaff.FlatAppearance.BorderSize = 0
        btnStaff.FlatStyle = FlatStyle.Flat
        btnStaff.Font = New Font("Segoe UI Semibold", 8.5F, FontStyle.Bold)
        btnStaff.ForeColor = Color.FromArgb(CByte(255), CByte(249), CByte(229))
        btnStaff.Location = New Point(177, 0)
        btnStaff.Margin = New Padding(3, 4, 3, 4)
        btnStaff.Name = "btnStaff"
        btnStaff.Size = New Size(177, 56)
        btnStaff.TabIndex = 1
        btnStaff.Text = "REGISTRAR STAFF"
        btnStaff.UseVisualStyleBackColor = False
        ' 
        ' btnAdmin
        ' 
        btnAdmin.BackColor = Color.FromArgb(CByte(255), CByte(249), CByte(229))
        btnAdmin.Dock = DockStyle.Left
        btnAdmin.FlatAppearance.BorderSize = 0
        btnAdmin.FlatStyle = FlatStyle.Flat
        btnAdmin.Font = New Font("Segoe UI Semibold", 8.5F, FontStyle.Bold)
        btnAdmin.ForeColor = Color.FromArgb(CByte(15), CByte(31), CByte(76))
        btnAdmin.Location = New Point(0, 0)
        btnAdmin.Margin = New Padding(3, 4, 3, 4)
        btnAdmin.Name = "btnAdmin"
        btnAdmin.Size = New Size(177, 56)
        btnAdmin.TabIndex = 0
        btnAdmin.Text = "ADMINISTRATOR"
        btnAdmin.UseVisualStyleBackColor = False
        ' 
        ' lblTitle
        ' 
        lblTitle.AutoSize = True
        lblTitle.Font = New Font("Segoe UI Semibold", 18F, FontStyle.Bold)
        lblTitle.ForeColor = Color.FromArgb(CByte(15), CByte(31), CByte(76))
        lblTitle.Location = New Point(46, 104)
        lblTitle.Name = "lblTitle"
        lblTitle.Size = New Size(240, 41)
        lblTitle.TabIndex = 0
        lblTitle.Text = "Sign in to portal"
        ' 
        ' frmLogin
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(857, 693)
        Controls.Add(pnlRight)
        Controls.Add(pnlLeft)
        FormBorderStyle = FormBorderStyle.FixedSingle
        Margin = New Padding(3, 4, 3, 4)
        MaximizeBox = False
        Name = "frmLogin"
        StartPosition = FormStartPosition.CenterScreen
        Text = "Registrar Document Request System - Login"
        pnlLeft.ResumeLayout(False)
        pnlLeft.PerformLayout()
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
    Friend WithEvents chkShowPassword As CheckBox
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label

End Class
