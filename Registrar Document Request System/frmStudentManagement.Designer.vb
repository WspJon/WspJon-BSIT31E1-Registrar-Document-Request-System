<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmStudentManagement
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
        Dim DataGridViewCellStyle4 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.pnlMainCard = New System.Windows.Forms.Panel()
        Me.dgvStudents = New System.Windows.Forms.DataGridView()
        Me.colStudentID = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.colName = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.colCourse = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.colYear = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.colStatus = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.colActions = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.pnlSearchFilter = New System.Windows.Forms.Panel()
        Me.btnSearch = New System.Windows.Forms.Button()
        Me.cboCourseFilter = New System.Windows.Forms.ComboBox()
        Me.txtSearch = New System.Windows.Forms.TextBox()
        Me.pnlHeader = New System.Windows.Forms.Panel()
        Me.btnAddStudent = New System.Windows.Forms.Button()
        Me.lblTitle = New System.Windows.Forms.Label()
        Me.pnlMainCard.SuspendLayout()
        CType(Me.dgvStudents, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.pnlSearchFilter.SuspendLayout()
        Me.pnlHeader.SuspendLayout()
        Me.SuspendLayout()
        '
        'pnlMainCard
        '
        Me.pnlMainCard.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.pnlMainCard.BackColor = System.Drawing.Color.White
        Me.pnlMainCard.Controls.Add(Me.dgvStudents)
        Me.pnlMainCard.Controls.Add(Me.pnlSearchFilter)
        Me.pnlMainCard.Controls.Add(Me.pnlHeader)
        Me.pnlMainCard.Location = New System.Drawing.Point(30, 25)
        Me.pnlMainCard.Name = "pnlMainCard"
        Me.pnlMainCard.Size = New System.Drawing.Size(860, 520)
        Me.pnlMainCard.TabIndex = 0
        '
        'dgvStudents
        '
        Me.dgvStudents.AllowUserToAddRows = False
        Me.dgvStudents.AllowUserToDeleteRows = False
        Me.dgvStudents.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.dgvStudents.BackgroundColor = System.Drawing.Color.White
        Me.dgvStudents.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.dgvStudents.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal
        Me.dgvStudents.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(15, 31, 76)
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold)
        DataGridViewCellStyle1.ForeColor = System.Drawing.Color.White
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(15, 31, 76)
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.White
        DataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgvStudents.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle1
        Me.dgvStudents.ColumnHeadersHeight = 38
        Me.dgvStudents.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing
        Me.dgvStudents.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.colStudentID, Me.colName, Me.colCourse, Me.colYear, Me.colStatus, Me.colActions})
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle2.BackColor = System.Drawing.Color.White
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Segoe UI", 9.5!)
        DataGridViewCellStyle2.ForeColor = System.Drawing.Color.FromArgb(43, 43, 43)
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(240, 244, 255)
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.FromArgb(15, 31, 76)
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.dgvStudents.DefaultCellStyle = DataGridViewCellStyle2
        Me.dgvStudents.EnableHeadersVisualStyles = False
        Me.dgvStudents.GridColor = System.Drawing.Color.FromArgb(235, 235, 235)
        Me.dgvStudents.Location = New System.Drawing.Point(25, 125)
        Me.dgvStudents.Name = "dgvStudents"
        Me.dgvStudents.ReadOnly = True
        Me.dgvStudents.RowHeadersVisible = False
        Me.dgvStudents.RowTemplate.Height = 42
        Me.dgvStudents.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgvStudents.Size = New System.Drawing.Size(810, 365)
        Me.dgvStudents.TabIndex = 2
        '
        'colStudentID
        '
        Me.colStudentID.HeaderText = "STUDENT ID"
        Me.colStudentID.Name = "colStudentID"
        Me.colStudentID.ReadOnly = True
        Me.colStudentID.Width = 130
        '
        'colName
        '
        Me.colName.HeaderText = "NAME"
        Me.colName.Name = "colName"
        Me.colName.ReadOnly = True
        Me.colName.Width = 200
        '
        'colCourse
        '
        Me.colCourse.HeaderText = "COURSE"
        Me.colCourse.Name = "colCourse"
        Me.colCourse.ReadOnly = True
        Me.colCourse.Width = 110
        '
        'colYear
        '
        DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        Me.colYear.DefaultCellStyle = DataGridViewCellStyle3
        Me.colYear.HeaderText = "YEAR"
        Me.colYear.Name = "colYear"
        Me.colYear.ReadOnly = True
        Me.colYear.Width = 90
        '
        'colStatus
        '
        DataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle4.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold)
        Me.colStatus.DefaultCellStyle = DataGridViewCellStyle4
        Me.colStatus.HeaderText = "STATUS"
        Me.colStatus.Name = "colStatus"
        Me.colStatus.ReadOnly = True
        Me.colStatus.Width = 110
        '
        'colActions
        '
        Me.colActions.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.colActions.HeaderText = "ACTIONS"
        Me.colActions.Name = "colActions"
        Me.colActions.ReadOnly = True
        '
        'pnlSearchFilter
        '
        Me.pnlSearchFilter.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.pnlSearchFilter.BackColor = System.Drawing.Color.White
        Me.pnlSearchFilter.Controls.Add(Me.btnSearch)
        Me.pnlSearchFilter.Controls.Add(Me.cboCourseFilter)
        Me.pnlSearchFilter.Controls.Add(Me.txtSearch)
        Me.pnlSearchFilter.Location = New System.Drawing.Point(25, 68)
        Me.pnlSearchFilter.Name = "pnlSearchFilter"
        Me.pnlSearchFilter.Size = New System.Drawing.Size(810, 42)
        Me.pnlSearchFilter.TabIndex = 1
        '
        'btnSearch
        '
        Me.btnSearch.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnSearch.BackColor = System.Drawing.Color.FromArgb(15, 31, 76)
        Me.btnSearch.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnSearch.FlatAppearance.BorderSize = 0
        Me.btnSearch.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnSearch.Font = New System.Drawing.Font("Segoe UI", 9.5!, System.Drawing.FontStyle.Bold)
        Me.btnSearch.ForeColor = System.Drawing.Color.White
        Me.btnSearch.Location = New System.Drawing.Point(710, 5)
        Me.btnSearch.Name = "btnSearch"
        Me.btnSearch.Size = New System.Drawing.Size(100, 32)
        Me.btnSearch.TabIndex = 2
        Me.btnSearch.Text = "Search"
        Me.btnSearch.UseVisualStyleBackColor = False
        '
        'cboCourseFilter
        '
        Me.cboCourseFilter.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.cboCourseFilter.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboCourseFilter.Font = New System.Drawing.Font("Segoe UI", 10.0!)
        Me.cboCourseFilter.ForeColor = System.Drawing.Color.FromArgb(43, 43, 43)
        Me.cboCourseFilter.FormattingEnabled = True
        Me.cboCourseFilter.Items.AddRange(New Object() {"All Courses", "BSIT", "BSCS", "BSA", "BSBA", "BSED"})
        Me.cboCourseFilter.Location = New System.Drawing.Point(520, 8)
        Me.cboCourseFilter.Name = "cboCourseFilter"
        Me.cboCourseFilter.Size = New System.Drawing.Size(175, 25)
        Me.cboCourseFilter.TabIndex = 1
        '
        'txtSearch
        '
        Me.txtSearch.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtSearch.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtSearch.Font = New System.Drawing.Font("Segoe UI", 10.5!)
        Me.txtSearch.ForeColor = System.Drawing.Color.FromArgb(43, 43, 43)
        Me.txtSearch.Location = New System.Drawing.Point(0, 8)
        Me.txtSearch.Name = "txtSearch"
        Me.txtSearch.Size = New System.Drawing.Size(505, 26)
        Me.txtSearch.TabIndex = 0
        '
        'pnlHeader
        '
        Me.pnlHeader.BackColor = System.Drawing.Color.FromArgb(15, 31, 76)
        Me.pnlHeader.Controls.Add(Me.btnAddStudent)
        Me.pnlHeader.Controls.Add(Me.lblTitle)
        Me.pnlHeader.Dock = System.Windows.Forms.DockStyle.Top
        Me.pnlHeader.Location = New System.Drawing.Point(0, 0)
        Me.pnlHeader.Name = "pnlHeader"
        Me.pnlHeader.Size = New System.Drawing.Size(860, 52)
        Me.pnlHeader.TabIndex = 0
        '
        'btnAddStudent
        '
        Me.btnAddStudent.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnAddStudent.BackColor = System.Drawing.Color.FromArgb(245, 197, 24)
        Me.btnAddStudent.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnAddStudent.FlatAppearance.BorderSize = 0
        Me.btnAddStudent.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnAddStudent.Font = New System.Drawing.Font("Segoe UI", 9.5!, System.Drawing.FontStyle.Bold)
        Me.btnAddStudent.ForeColor = System.Drawing.Color.FromArgb(15, 31, 76)
        Me.btnAddStudent.Location = New System.Drawing.Point(715, 10)
        Me.btnAddStudent.Name = "btnAddStudent"
        Me.btnAddStudent.Size = New System.Drawing.Size(130, 32)
        Me.btnAddStudent.TabIndex = 1
        Me.btnAddStudent.Text = "+ Add Student"
        Me.btnAddStudent.UseVisualStyleBackColor = False
        '
        'lblTitle
        '
        Me.lblTitle.AutoSize = True
        Me.lblTitle.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold)
        Me.lblTitle.ForeColor = System.Drawing.Color.White
        Me.lblTitle.Location = New System.Drawing.Point(20, 15)
        Me.lblTitle.Name = "lblTitle"
        Me.lblTitle.Size = New System.Drawing.Size(166, 21)
        Me.lblTitle.TabIndex = 0
        Me.lblTitle.Text = "Student Management"
        '
        'frmStudentManagement
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(245, 246, 248)
        Me.ClientSize = New System.Drawing.Size(920, 570)
        Me.Controls.Add(Me.pnlMainCard)
        Me.Name = "frmStudentManagement"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Student Management"
        Me.pnlMainCard.ResumeLayout(False)
        CType(Me.dgvStudents, System.ComponentModel.ISupportInitialize).EndInit()
        Me.pnlSearchFilter.ResumeLayout(False)
        Me.pnlSearchFilter.PerformLayout()
        Me.pnlHeader.ResumeLayout(False)
        Me.pnlHeader.PerformLayout()
        Me.ResumeLayout(False)

        Me.cboCourseFilter.SelectedIndex = 0
    End Sub

    Friend WithEvents pnlMainCard As System.Windows.Forms.Panel
    Friend WithEvents pnlHeader As System.Windows.Forms.Panel
    Friend WithEvents lblTitle As System.Windows.Forms.Label
    Friend WithEvents btnAddStudent As System.Windows.Forms.Button
    Friend WithEvents pnlSearchFilter As System.Windows.Forms.Panel
    Friend WithEvents txtSearch As System.Windows.Forms.TextBox
    Friend WithEvents cboCourseFilter As System.Windows.Forms.ComboBox
    Friend WithEvents btnSearch As System.Windows.Forms.Button
    Friend WithEvents dgvStudents As System.Windows.Forms.DataGridView
    Friend WithEvents colStudentID As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents colName As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents colCourse As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents colYear As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents colStatus As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents colActions As System.Windows.Forms.DataGridViewTextBoxColumn

End Class
