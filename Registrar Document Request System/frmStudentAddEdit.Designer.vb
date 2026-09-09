<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmStudentAddEdit
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
        lblStudentID = New Label()
        txtStudentID = New TextBox()
        txtLRN = New TextBox()
        lblLRN = New Label()
        txtFirstName = New TextBox()
        lblFirstName = New Label()
        txtLastName = New TextBox()
        lblLastName = New Label()
        txtMiddleName = New TextBox()
        lblMiddleName = New Label()
        lblCourse = New Label()
        cboCourse = New ComboBox()
        cboYearLevel = New ComboBox()
        lblYearLevel = New Label()
        txtSection = New TextBox()
        lblSection = New Label()
        txtContactNo = New TextBox()
        lblContactNo = New Label()
        cboStatus = New ComboBox()
        lblStatus = New Label()
        btnSave = New Button()
        btnCancel = New Button()
        pnlHeader.SuspendLayout()
        SuspendLayout()
        ' 
        ' lblTitle
        ' 
        lblTitle.AutoSize = True
        lblTitle.Font = New Font("Segoe UI", 14F, FontStyle.Bold)
        lblTitle.ForeColor = Color.White
        lblTitle.Location = New Point(20, 18)
        lblTitle.Name = "lblTitle"
        lblTitle.Size = New Size(170, 25)
        lblTitle.TabIndex = 0
        lblTitle.Text = "Add New Student"
        ' 
        ' pnlHeader
        ' 
        pnlHeader.BackColor = Color.FromArgb(CByte(15), CByte(31), CByte(76))
        pnlHeader.Controls.Add(lblTitle)
        pnlHeader.Dock = DockStyle.Top
        pnlHeader.Location = New Point(0, 0)
        pnlHeader.Name = "pnlHeader"
        pnlHeader.Size = New Size(450, 60)
        pnlHeader.TabIndex = 0
        ' 
        ' lblStudentID
        ' 
        lblStudentID.AutoSize = True
        lblStudentID.Font = New Font("Segoe UI", 9.5F)
        lblStudentID.Location = New Point(25, 80)
        lblStudentID.Name = "lblStudentID"
        lblStudentID.Size = New Size(68, 17)
        lblStudentID.TabIndex = 1
        lblStudentID.Text = "Student ID"
        ' 
        ' txtStudentID
        ' 
        txtStudentID.Font = New Font("Segoe UI", 10F)
        txtStudentID.Location = New Point(25, 100)
        txtStudentID.Name = "txtStudentID"
        txtStudentID.Size = New Size(190, 25)
        txtStudentID.TabIndex = 2
        ' 
        ' txtLRN
        ' 
        txtLRN.Font = New Font("Segoe UI", 10F)
        txtLRN.Location = New Point(235, 100)
        txtLRN.Name = "txtLRN"
        txtLRN.Size = New Size(190, 25)
        txtLRN.TabIndex = 4
        ' 
        ' lblLRN
        ' 
        lblLRN.AutoSize = True
        lblLRN.Font = New Font("Segoe UI", 9.5F)
        lblLRN.Location = New Point(235, 80)
        lblLRN.Name = "lblLRN"
        lblLRN.Size = New Size(32, 17)
        lblLRN.TabIndex = 3
        lblLRN.Text = "LRN"
        ' 
        ' txtFirstName
        ' 
        txtFirstName.Font = New Font("Segoe UI", 10F)
        txtFirstName.Location = New Point(25, 160)
        txtFirstName.Name = "txtFirstName"
        txtFirstName.Size = New Size(190, 25)
        txtFirstName.TabIndex = 6
        ' 
        ' lblFirstName
        ' 
        lblFirstName.AutoSize = True
        lblFirstName.Font = New Font("Segoe UI", 9.5F)
        lblFirstName.Location = New Point(25, 140)
        lblFirstName.Name = "lblFirstName"
        lblFirstName.Size = New Size(71, 17)
        lblFirstName.TabIndex = 5
        lblFirstName.Text = "First Name"
        ' 
        ' txtLastName
        ' 
        txtLastName.Font = New Font("Segoe UI", 10F)
        txtLastName.Location = New Point(25, 210)
        txtLastName.Name = "txtLastName"
        txtLastName.Size = New Size(190, 25)
        txtLastName.TabIndex = 8
        ' 
        ' lblLastName
        ' 
        lblLastName.AutoSize = True
        lblLastName.Font = New Font("Segoe UI", 9.5F)
        lblLastName.Location = New Point(26, 260)
        lblLastName.Name = "lblLastName"
        lblLastName.Size = New Size(70, 17)
        lblLastName.TabIndex = 7
        lblLastName.Text = "Last Name"
        ' 
        ' txtMiddleName
        ' 
        txtMiddleName.Font = New Font("Segoe UI", 10F)
        txtMiddleName.Location = New Point(25, 280)
        txtMiddleName.Name = "txtMiddleName"
        txtMiddleName.Size = New Size(190, 25)
        txtMiddleName.TabIndex = 10
        ' 
        ' lblMiddleName
        ' 
        lblMiddleName.AutoSize = True
        lblMiddleName.Font = New Font("Segoe UI", 9.5F)
        lblMiddleName.Location = New Point(25, 200)
        lblMiddleName.Name = "lblMiddleName"
        lblMiddleName.Size = New Size(88, 17)
        lblMiddleName.TabIndex = 9
        lblMiddleName.Text = "Middle Name"
        ' 
        ' lblCourse
        ' 
        lblCourse.AutoSize = True
        lblCourse.Font = New Font("Segoe UI", 9.5F)
        lblCourse.Location = New Point(235, 200)
        lblCourse.Name = "lblCourse"
        lblCourse.Size = New Size(49, 17)
        lblCourse.TabIndex = 11
        lblCourse.Text = "Course"
        ' 
        ' cboCourse
        ' 
        cboCourse.DropDownStyle = ComboBoxStyle.DropDownList
        cboCourse.Font = New Font("Segoe UI", 10F)
        cboCourse.FormattingEnabled = True
        cboCourse.Items.AddRange(New Object() {"BSIT", "BSCS", "BSA", "BSBA", "BSED"})
        cboCourse.Location = New Point(235, 220)
        cboCourse.Name = "cboCourse"
        cboCourse.Size = New Size(190, 25)
        cboCourse.TabIndex = 12
        ' 
        ' cboYearLevel
        ' 
        cboYearLevel.DropDownStyle = ComboBoxStyle.DropDownList
        cboYearLevel.Font = New Font("Segoe UI", 10F)
        cboYearLevel.FormattingEnabled = True
        cboYearLevel.Items.AddRange(New Object() {"1", "2", "3", "4"})
        cboYearLevel.Location = New Point(235, 160)
        cboYearLevel.Name = "cboYearLevel"
        cboYearLevel.Size = New Size(190, 25)
        cboYearLevel.TabIndex = 14
        ' 
        ' lblYearLevel
        ' 
        lblYearLevel.AutoSize = True
        lblYearLevel.Font = New Font("Segoe UI", 9.5F)
        lblYearLevel.Location = New Point(235, 140)
        lblYearLevel.Name = "lblYearLevel"
        lblYearLevel.Size = New Size(66, 17)
        lblYearLevel.TabIndex = 13
        lblYearLevel.Text = "Year Level"
        ' 
        ' txtSection
        ' 
        txtSection.Font = New Font("Segoe UI", 10F)
        txtSection.Location = New Point(235, 280)
        txtSection.Name = "txtSection"
        txtSection.Size = New Size(190, 25)
        txtSection.TabIndex = 16
        ' 
        ' lblSection
        ' 
        lblSection.AutoSize = True
        lblSection.Font = New Font("Segoe UI", 9.5F)
        lblSection.Location = New Point(235, 260)
        lblSection.Name = "lblSection"
        lblSection.Size = New Size(50, 17)
        lblSection.TabIndex = 15
        lblSection.Text = "Section"
        ' 
        ' txtContactNo
        ' 
        txtContactNo.Font = New Font("Segoe UI", 10F)
        txtContactNo.Location = New Point(25, 340)
        txtContactNo.Name = "txtContactNo"
        txtContactNo.Size = New Size(190, 25)
        txtContactNo.TabIndex = 18
        ' 
        ' lblContactNo
        ' 
        lblContactNo.AutoSize = True
        lblContactNo.Font = New Font("Segoe UI", 9.5F)
        lblContactNo.Location = New Point(25, 320)
        lblContactNo.Name = "lblContactNo"
        lblContactNo.Size = New Size(77, 17)
        lblContactNo.TabIndex = 17
        lblContactNo.Text = "Contact No."
        ' 
        ' cboStatus
        ' 
        cboStatus.DropDownStyle = ComboBoxStyle.DropDownList
        cboStatus.Font = New Font("Segoe UI", 10F)
        cboStatus.FormattingEnabled = True
        cboStatus.Items.AddRange(New Object() {"Active", "Inactive"})
        cboStatus.Location = New Point(235, 340)
        cboStatus.Name = "cboStatus"
        cboStatus.Size = New Size(190, 25)
        cboStatus.TabIndex = 20
        ' 
        ' lblStatus
        ' 
        lblStatus.AutoSize = True
        lblStatus.Font = New Font("Segoe UI", 9.5F)
        lblStatus.Location = New Point(235, 320)
        lblStatus.Name = "lblStatus"
        lblStatus.Size = New Size(43, 17)
        lblStatus.TabIndex = 19
        lblStatus.Text = "Status"
        ' 
        ' btnSave
        ' 
        btnSave.BackColor = Color.FromArgb(CByte(15), CByte(31), CByte(76))
        btnSave.Cursor = Cursors.Hand
        btnSave.FlatAppearance.BorderSize = 0
        btnSave.FlatStyle = FlatStyle.Flat
        btnSave.Font = New Font("Segoe UI", 10F, FontStyle.Bold)
        btnSave.ForeColor = Color.White
        btnSave.Location = New Point(315, 390)
        btnSave.Name = "btnSave"
        btnSave.Size = New Size(110, 35)
        btnSave.TabIndex = 21
        btnSave.Text = "Save"
        btnSave.UseVisualStyleBackColor = False
        ' 
        ' btnCancel
        ' 
        btnCancel.BackColor = Color.White
        btnCancel.Cursor = Cursors.Hand
        btnCancel.FlatAppearance.BorderColor = Color.FromArgb(CByte(15), CByte(31), CByte(76))
        btnCancel.FlatStyle = FlatStyle.Flat
        btnCancel.Font = New Font("Segoe UI", 10F)
        btnCancel.ForeColor = Color.FromArgb(CByte(15), CByte(31), CByte(76))
        btnCancel.Location = New Point(195, 390)
        btnCancel.Name = "btnCancel"
        btnCancel.Size = New Size(110, 35)
        btnCancel.TabIndex = 22
        btnCancel.Text = "Cancel"
        btnCancel.UseVisualStyleBackColor = False
        ' 
        ' frmStudentAddEdit
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.White
        ClientSize = New Size(450, 450)
        Controls.Add(btnCancel)
        Controls.Add(btnSave)
        Controls.Add(cboStatus)
        Controls.Add(lblStatus)
        Controls.Add(txtContactNo)
        Controls.Add(lblContactNo)
        Controls.Add(txtSection)
        Controls.Add(lblSection)
        Controls.Add(cboYearLevel)
        Controls.Add(lblYearLevel)
        Controls.Add(cboCourse)
        Controls.Add(lblCourse)
        Controls.Add(txtMiddleName)
        Controls.Add(lblMiddleName)
        Controls.Add(txtLastName)
        Controls.Add(lblLastName)
        Controls.Add(txtFirstName)
        Controls.Add(lblFirstName)
        Controls.Add(txtLRN)
        Controls.Add(lblLRN)
        Controls.Add(txtStudentID)
        Controls.Add(lblStudentID)
        Controls.Add(pnlHeader)
        Font = New Font("Segoe UI", 9F)
        FormBorderStyle = FormBorderStyle.FixedDialog
        MaximizeBox = False
        MinimizeBox = False
        Name = "frmStudentAddEdit"
        StartPosition = FormStartPosition.CenterParent
        Text = "Student Details"
        pnlHeader.ResumeLayout(False)
        pnlHeader.PerformLayout()
        ResumeLayout(False)
        PerformLayout()

    End Sub

    Friend WithEvents pnlHeader As System.Windows.Forms.Panel
    Friend WithEvents lblTitle As System.Windows.Forms.Label
    Friend WithEvents lblStudentID As System.Windows.Forms.Label
    Friend WithEvents txtStudentID As System.Windows.Forms.TextBox
    Friend WithEvents lblLRN As System.Windows.Forms.Label
    Friend WithEvents txtLRN As System.Windows.Forms.TextBox
    Friend WithEvents lblFirstName As System.Windows.Forms.Label
    Friend WithEvents txtFirstName As System.Windows.Forms.TextBox
    Friend WithEvents lblLastName As System.Windows.Forms.Label
    Friend WithEvents txtLastName As System.Windows.Forms.TextBox
    Friend WithEvents lblMiddleName As System.Windows.Forms.Label
    Friend WithEvents txtMiddleName As System.Windows.Forms.TextBox
    Friend WithEvents lblCourse As System.Windows.Forms.Label
    Friend WithEvents cboCourse As System.Windows.Forms.ComboBox
    Friend WithEvents lblYearLevel As System.Windows.Forms.Label
    Friend WithEvents cboYearLevel As System.Windows.Forms.ComboBox
    Friend WithEvents lblSection As System.Windows.Forms.Label
    Friend WithEvents txtSection As System.Windows.Forms.TextBox
    Friend WithEvents lblContactNo As System.Windows.Forms.Label
    Friend WithEvents txtContactNo As System.Windows.Forms.TextBox
    Friend WithEvents lblStatus As System.Windows.Forms.Label
    Friend WithEvents cboStatus As System.Windows.Forms.ComboBox
    Friend WithEvents btnSave As System.Windows.Forms.Button
    Friend WithEvents btnCancel As System.Windows.Forms.Button
End Class
