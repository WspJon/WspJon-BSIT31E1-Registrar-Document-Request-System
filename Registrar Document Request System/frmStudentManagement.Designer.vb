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
        Dim DataGridViewCellStyle1 As DataGridViewCellStyle = New DataGridViewCellStyle()
        Dim DataGridViewCellStyle4 As DataGridViewCellStyle = New DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As DataGridViewCellStyle = New DataGridViewCellStyle()
        Dim DataGridViewCellStyle3 As DataGridViewCellStyle = New DataGridViewCellStyle()
        pnlMainCard = New Panel()
        dgvStudents = New DataGridView()
        colStudentID = New DataGridViewTextBoxColumn()
        colName = New DataGridViewTextBoxColumn()
        colCourse = New DataGridViewTextBoxColumn()
        colYear = New DataGridViewTextBoxColumn()
        colStatus = New DataGridViewTextBoxColumn()
        colActions = New DataGridViewTextBoxColumn()
        pnlSearchFilter = New Panel()
        btnSearch = New Button()
        cboCourseFilter = New ComboBox()
        txtSearch = New TextBox()
        pnlHeader = New Panel()
        btnAddStudent = New Button()
        lblTitle = New Label()
        pnlMainCard.SuspendLayout()
        CType(dgvStudents, ComponentModel.ISupportInitialize).BeginInit()
        pnlSearchFilter.SuspendLayout()
        pnlHeader.SuspendLayout()
        SuspendLayout()
        ' 
        ' pnlMainCard
        ' 
        pnlMainCard.Anchor = AnchorStyles.Top Or AnchorStyles.Bottom Or AnchorStyles.Left Or AnchorStyles.Right
        pnlMainCard.BackColor = Color.FromArgb(CByte(255), CByte(249), CByte(229))
        pnlMainCard.Controls.Add(dgvStudents)
        pnlMainCard.Controls.Add(pnlSearchFilter)
        pnlMainCard.Controls.Add(pnlHeader)
        pnlMainCard.Location = New Point(34, 33)
        pnlMainCard.Margin = New Padding(3, 4, 3, 4)
        pnlMainCard.Name = "pnlMainCard"
        pnlMainCard.Size = New Size(983, 693)
        pnlMainCard.TabIndex = 0
        ' 
        ' dgvStudents
        ' 
        dgvStudents.AllowUserToAddRows = False
        dgvStudents.AllowUserToDeleteRows = False
        dgvStudents.Anchor = AnchorStyles.Top Or AnchorStyles.Bottom Or AnchorStyles.Left Or AnchorStyles.Right
        dgvStudents.BackgroundColor = Color.White
        dgvStudents.BorderStyle = BorderStyle.None
        dgvStudents.CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal
        dgvStudents.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None
        DataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle1.BackColor = Color.FromArgb(CByte(15), CByte(31), CByte(76))
        DataGridViewCellStyle1.Font = New Font("Segoe UI", 9F, FontStyle.Bold)
        DataGridViewCellStyle1.ForeColor = Color.White
        DataGridViewCellStyle1.SelectionBackColor = Color.FromArgb(CByte(15), CByte(31), CByte(76))
        DataGridViewCellStyle1.SelectionForeColor = Color.White
        DataGridViewCellStyle1.WrapMode = DataGridViewTriState.True
        dgvStudents.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle1
        dgvStudents.ColumnHeadersHeight = 38
        dgvStudents.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.DisableResizing
        dgvStudents.Columns.AddRange(New DataGridViewColumn() {colStudentID, colName, colCourse, colYear, colStatus, colActions})
        DataGridViewCellStyle4.Alignment = DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle4.BackColor = Color.White
        DataGridViewCellStyle4.Font = New Font("Segoe UI", 9.5F)
        DataGridViewCellStyle4.ForeColor = Color.FromArgb(CByte(43), CByte(43), CByte(43))
        DataGridViewCellStyle4.SelectionBackColor = Color.FromArgb(CByte(240), CByte(244), CByte(255))
        DataGridViewCellStyle4.SelectionForeColor = Color.FromArgb(CByte(15), CByte(31), CByte(76))
        DataGridViewCellStyle4.WrapMode = DataGridViewTriState.False
        dgvStudents.DefaultCellStyle = DataGridViewCellStyle4
        dgvStudents.EnableHeadersVisualStyles = False
        dgvStudents.GridColor = Color.FromArgb(CByte(235), CByte(235), CByte(235))
        dgvStudents.Location = New Point(29, 167)
        dgvStudents.Margin = New Padding(3, 4, 3, 4)
        dgvStudents.Name = "dgvStudents"
        dgvStudents.ReadOnly = True
        dgvStudents.RowHeadersVisible = False
        dgvStudents.RowHeadersWidth = 51
        dgvStudents.RowTemplate.Height = 42
        dgvStudents.SelectionMode = DataGridViewSelectionMode.FullRowSelect
        dgvStudents.Size = New Size(926, 487)
        dgvStudents.TabIndex = 2
        ' 
        ' colStudentID
        ' 
        colStudentID.HeaderText = "STUDENT ID"
        colStudentID.MinimumWidth = 6
        colStudentID.Name = "colStudentID"
        colStudentID.ReadOnly = True
        colStudentID.Width = 130
        ' 
        ' colName
        ' 
        colName.HeaderText = "NAME"
        colName.MinimumWidth = 6
        colName.Name = "colName"
        colName.ReadOnly = True
        colName.Width = 200
        ' 
        ' colCourse
        ' 
        colCourse.HeaderText = "COURSE"
        colCourse.MinimumWidth = 6
        colCourse.Name = "colCourse"
        colCourse.ReadOnly = True
        colCourse.Width = 110
        ' 
        ' colYear
        ' 
        DataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleCenter
        colYear.DefaultCellStyle = DataGridViewCellStyle2
        colYear.HeaderText = "YEAR"
        colYear.MinimumWidth = 6
        colYear.Name = "colYear"
        colYear.ReadOnly = True
        colYear.Width = 90
        ' 
        ' colStatus
        ' 
        DataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle3.Font = New Font("Segoe UI", 9F, FontStyle.Bold)
        colStatus.DefaultCellStyle = DataGridViewCellStyle3
        colStatus.HeaderText = "STATUS"
        colStatus.MinimumWidth = 6
        colStatus.Name = "colStatus"
        colStatus.ReadOnly = True
        colStatus.Width = 110
        ' 
        ' colActions
        ' 
        colActions.AutoSizeMode = DataGridViewAutoSizeColumnMode.None
        colActions.HeaderText = "ACTIONS"
        colActions.MinimumWidth = 6
        colActions.Name = "colActions"
        colActions.ReadOnly = True
        colActions.Width = 125
        ' 
        ' pnlSearchFilter
        ' 
        pnlSearchFilter.Anchor = AnchorStyles.Top Or AnchorStyles.Left Or AnchorStyles.Right
        pnlSearchFilter.BackColor = Color.FromArgb(CByte(255), CByte(249), CByte(229))
        pnlSearchFilter.Controls.Add(btnSearch)
        pnlSearchFilter.Controls.Add(cboCourseFilter)
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
        btnSearch.TabIndex = 2
        btnSearch.Text = "Search"
        btnSearch.UseVisualStyleBackColor = False
        ' 
        ' cboCourseFilter
        ' 
        cboCourseFilter.Anchor = AnchorStyles.Top Or AnchorStyles.Right
        cboCourseFilter.DropDownStyle = ComboBoxStyle.DropDownList
        cboCourseFilter.Font = New Font("Segoe UI", 10F)
        cboCourseFilter.ForeColor = Color.FromArgb(CByte(43), CByte(43), CByte(43))
        cboCourseFilter.FormattingEnabled = True
        cboCourseFilter.Items.AddRange(New Object() {"All Courses", "BSIT", "BSCS", "BSA", "BSBA", "BSED"})
        cboCourseFilter.Location = New Point(594, 11)
        cboCourseFilter.Margin = New Padding(3, 4, 3, 4)
        cboCourseFilter.Name = "cboCourseFilter"
        cboCourseFilter.Size = New Size(199, 31)
        cboCourseFilter.TabIndex = 1
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
        txtSearch.Size = New Size(577, 31)
        txtSearch.TabIndex = 0
        ' 
        ' pnlHeader
        ' 
        pnlHeader.BackColor = Color.FromArgb(CByte(15), CByte(31), CByte(76))
        pnlHeader.Controls.Add(btnAddStudent)
        pnlHeader.Controls.Add(lblTitle)
        pnlHeader.Dock = DockStyle.Top
        pnlHeader.Location = New Point(0, 0)
        pnlHeader.Margin = New Padding(3, 4, 3, 4)
        pnlHeader.Name = "pnlHeader"
        pnlHeader.Size = New Size(983, 69)
        pnlHeader.TabIndex = 0
        ' 
        ' btnAddStudent
        ' 
        btnAddStudent.Anchor = AnchorStyles.Top Or AnchorStyles.Right
        btnAddStudent.BackColor = Color.FromArgb(CByte(245), CByte(197), CByte(24))
        btnAddStudent.Cursor = Cursors.Hand
        btnAddStudent.FlatAppearance.BorderSize = 0
        btnAddStudent.FlatStyle = FlatStyle.Flat
        btnAddStudent.Font = New Font("Segoe UI", 9.5F, FontStyle.Bold)
        btnAddStudent.ForeColor = Color.FromArgb(CByte(15), CByte(31), CByte(76))
        btnAddStudent.Location = New Point(817, 13)
        btnAddStudent.Margin = New Padding(3, 4, 3, 4)
        btnAddStudent.Name = "btnAddStudent"
        btnAddStudent.Size = New Size(149, 43)
        btnAddStudent.TabIndex = 1
        btnAddStudent.Text = "+ Add Student"
        btnAddStudent.UseVisualStyleBackColor = False
        ' 
        ' lblTitle
        ' 
        lblTitle.AutoSize = True
        lblTitle.Font = New Font("Segoe UI", 12F, FontStyle.Bold)
        lblTitle.ForeColor = Color.White
        lblTitle.Location = New Point(23, 20)
        lblTitle.Name = "lblTitle"
        lblTitle.Size = New Size(217, 28)
        lblTitle.TabIndex = 0
        lblTitle.Text = "Student Management"
        ' 
        ' frmStudentManagement
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.FromArgb(CByte(255), CByte(249), CByte(229))
        ClientSize = New Size(1051, 760)
        Controls.Add(pnlMainCard)
        Margin = New Padding(3, 4, 3, 4)
        Name = "frmStudentManagement"
        StartPosition = FormStartPosition.CenterScreen
        Text = "Student Management"
        pnlMainCard.ResumeLayout(False)
        CType(dgvStudents, ComponentModel.ISupportInitialize).EndInit()
        pnlSearchFilter.ResumeLayout(False)
        pnlSearchFilter.PerformLayout()
        pnlHeader.ResumeLayout(False)
        pnlHeader.PerformLayout()
        ResumeLayout(False)
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
