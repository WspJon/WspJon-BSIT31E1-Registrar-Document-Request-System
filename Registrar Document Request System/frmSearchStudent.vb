Imports MySql.Data.MySqlClient
Imports System.Drawing

Public Class frmSearchStudent

    Private currentPage As Integer = 1
    Private pageSize As Integer = 10
    Private totalRecords As Integer = 0


    '===========================================================
    ' FORM LOAD
    '===========================================================
    Private Sub frmSearchStudent_Load(
        sender As Object,
        e As EventArgs
    ) Handles MyBase.Load

        '=============================
        ' COURSE FILTER
        '=============================
        cboCourseFilter.Items.Clear()
        cboCourseFilter.Items.Add("All Courses")
        cboCourseFilter.Items.Add("BSIT")
        cboCourseFilter.Items.Add("CTHM")
        cboCourseFilter.Items.Add("BSCRIM")
        cboCourseFilter.SelectedIndex = 0


        '=============================
        ' STATUS FILTER
        '=============================
        cboStatusFilter.Items.Clear()
        cboStatusFilter.Items.Add("All Status")
        cboStatusFilter.Items.Add("Active")
        cboStatusFilter.Items.Add("Inactive")
        cboStatusFilter.SelectedIndex = 0


        '=============================
        ' STAFF COURSE RESTRICTION
        '=============================
        If dbHelper.currentUserRole <> "Administrator" AndAlso
           Not String.IsNullOrEmpty(dbHelper.userCourseAssigned) AndAlso
           dbHelper.userCourseAssigned <> "ALL" Then

            If cboCourseFilter.Items.Contains(
                dbHelper.userCourseAssigned
            ) Then

                cboCourseFilter.SelectedItem =
                    dbHelper.userCourseAssigned

                cboCourseFilter.Enabled = False

            End If

        End If


        '=============================
        ' DATAGRIDVIEW SETTINGS
        '=============================
        dgvStudents.DataSource = Nothing

        ' REMOVE ALL OLD DESIGNER COLUMNS
        ' PARA WALANG DUPLICATE ACTION / DOTS
        dgvStudents.Columns.Clear()

        dgvStudents.AllowUserToAddRows = False
        dgvStudents.AllowUserToDeleteRows = False
        dgvStudents.ReadOnly = False

        dgvStudents.SelectionMode =
            DataGridViewSelectionMode.FullRowSelect

        dgvStudents.MultiSelect = False

        dgvStudents.AutoGenerateColumns = True

        dgvStudents.AutoSizeColumnsMode =
            DataGridViewAutoSizeColumnsMode.Fill


        LoadStudents()

    End Sub



    '===========================================================
    ' LOAD STUDENTS
    '===========================================================
    Private Sub LoadStudents()

        Try

            Using conn = dbHelper.GetConnection()

                conn.Open()

                Dim whereClause As String =
                    " WHERE 1=1"

                Dim search As String =
                    txtSearch.Text.Trim()


                '=============================
                ' COURSE FILTER
                '=============================
                If dbHelper.currentUserRole <> "Administrator" AndAlso
                   Not String.IsNullOrEmpty(dbHelper.userCourseAssigned) AndAlso
                   dbHelper.userCourseAssigned <> "ALL" Then

                    whereClause &=
                        " AND Course = @assignedCourse"

                ElseIf cboCourseFilter.SelectedIndex > 0 Then

                    whereClause &=
                        " AND Course = @course"

                End If


                '=============================
                ' SEARCH FILTER
                '=============================
                If Not String.IsNullOrEmpty(search) Then

                    whereClause &=
                        " AND (" &
                        "StudentID LIKE @search OR " &
                        "FirstName LIKE @search OR " &
                        "LastName LIKE @search" &
                        ")"

                End If


                '=============================
                ' STATUS FILTER
                '=============================
                If cboStatusFilter.SelectedIndex > 0 Then

                    whereClause &=
                        " AND Status = @status"

                End If



                '===================================================
                ' COUNT TOTAL RECORDS
                '===================================================
                Dim countQuery As String =
                    "SELECT COUNT(*) FROM tblstudents" &
                    whereClause


                Using cmdCount As New MySqlCommand(
                    countQuery,
                    conn
                )

                    ' COURSE
                    If dbHelper.currentUserRole <> "Administrator" AndAlso
                       Not String.IsNullOrEmpty(dbHelper.userCourseAssigned) AndAlso
                       dbHelper.userCourseAssigned <> "ALL" Then

                        cmdCount.Parameters.AddWithValue(
                            "@assignedCourse",
                            dbHelper.userCourseAssigned
                        )

                    ElseIf cboCourseFilter.SelectedIndex > 0 Then

                        cmdCount.Parameters.AddWithValue(
                            "@course",
                            cboCourseFilter.SelectedItem.ToString()
                        )

                    End If


                    ' SEARCH
                    If Not String.IsNullOrEmpty(search) Then

                        cmdCount.Parameters.AddWithValue(
                            "@search",
                            "%" & search & "%"
                        )

                    End If


                    ' STATUS
                    If cboStatusFilter.SelectedIndex > 0 Then

                        cmdCount.Parameters.AddWithValue(
                            "@status",
                            cboStatusFilter.SelectedItem.ToString()
                        )

                    End If


                    totalRecords =
                        Convert.ToInt32(
                            cmdCount.ExecuteScalar()
                        )

                End Using



                '===================================================
                ' PAGINATION
                '===================================================
                Dim totalPages As Integer =
                    CInt(
                        Math.Ceiling(
                            totalRecords / CDbl(pageSize)
                        )
                    )


                If currentPage < 1 Then
                    currentPage = 1
                End If


                If currentPage > totalPages AndAlso
                   totalPages > 0 Then

                    currentPage = totalPages

                End If


                If totalPages = 0 Then
                    currentPage = 1
                End If


                Dim offset As Integer =
                    (currentPage - 1) * pageSize


                If offset < 0 Then
                    offset = 0
                End If



                '===================================================
                ' GET STUDENTS
                '===================================================
                Dim query As String =
                    "SELECT StudentID, " &
                    "CONCAT(FirstName, ' ', LastName) AS FullName, " &
                    "Course, " &
                    "YearLevel, " &
                    "ContactNo, " &
                    "Status " &
                    "FROM tblstudents" &
                    whereClause &
                    " ORDER BY StudentID " &
                    "LIMIT @limit OFFSET @offset"


                Using cmd As New MySqlCommand(
                    query,
                    conn
                )

                    ' COURSE
                    If dbHelper.currentUserRole <> "Administrator" AndAlso
                       Not String.IsNullOrEmpty(dbHelper.userCourseAssigned) AndAlso
                       dbHelper.userCourseAssigned <> "ALL" Then

                        cmd.Parameters.AddWithValue(
                            "@assignedCourse",
                            dbHelper.userCourseAssigned
                        )

                    ElseIf cboCourseFilter.SelectedIndex > 0 Then

                        cmd.Parameters.AddWithValue(
                            "@course",
                            cboCourseFilter.SelectedItem.ToString()
                        )

                    End If


                    ' SEARCH
                    If Not String.IsNullOrEmpty(search) Then

                        cmd.Parameters.AddWithValue(
                            "@search",
                            "%" & search & "%"
                        )

                    End If


                    ' STATUS
                    If cboStatusFilter.SelectedIndex > 0 Then

                        cmd.Parameters.AddWithValue(
                            "@status",
                            cboStatusFilter.SelectedItem.ToString()
                        )

                    End If


                    ' PAGINATION
                    cmd.Parameters.AddWithValue(
                        "@limit",
                        pageSize
                    )

                    cmd.Parameters.AddWithValue(
                        "@offset",
                        offset
                    )


                    Dim adapter As New MySqlDataAdapter(cmd)

                    Dim dt As New DataTable()

                    adapter.Fill(dt)


                    ' REMOVE OLD DATASOURCE
                    dgvStudents.DataSource = Nothing

                    ' REMOVE OLD COLUMNS
                    dgvStudents.Columns.Clear()

                    ' AUTO GENERATE NORMAL COLUMNS
                    dgvStudents.AutoGenerateColumns = True

                    dgvStudents.DataSource = dt

                End Using


                '===================================================
                ' ADD ONLY ONE ACTION COLUMN
                '===================================================
                SetupActionColumn()


                '===================================================
                ' UPDATE PAGINATION
                '===================================================
                UpdatePaginationUI(totalPages)

            End Using


        Catch ex As Exception

            MessageBox.Show(
                "Error loading students: " &
                ex.Message,
                "Error",
                MessageBoxButtons.OK,
                MessageBoxIcon.Error
            )

        End Try

    End Sub



    '===========================================================
    ' ACTION COLUMN
    '===========================================================
    Private Sub SetupActionColumn()

        ' REMOVE ANY EXISTING ACTION COLUMN FIRST
        For i As Integer =
            dgvStudents.Columns.Count - 1 To 0 Step -1

            Dim col As DataGridViewColumn =
                dgvStudents.Columns(i)

            If col.Name.Equals(
                "Action",
                StringComparison.OrdinalIgnoreCase
            ) OrElse
               col.HeaderText.Trim().Equals(
                "ACTION",
                StringComparison.OrdinalIgnoreCase
            ) Then

                dgvStudents.Columns.RemoveAt(i)

            End If

        Next


        ' CREATE ONE ACTION BUTTON COLUMN
        Dim actionColumn As New DataGridViewButtonColumn()

        actionColumn.Name = "Action"
        actionColumn.HeaderText = "ACTION"

        actionColumn.Width = 125

        actionColumn.ReadOnly = True

        actionColumn.UseColumnTextForButtonValue = False

        actionColumn.SortMode =
            DataGridViewColumnSortMode.NotSortable


        ' PUT ACTION FIRST
        dgvStudents.Columns.Insert(
            0,
            actionColumn
        )


        dgvStudents.AutoSizeColumnsMode =
            DataGridViewAutoSizeColumnsMode.Fill


        dgvStudents.Columns("Action").AutoSizeMode =
            DataGridViewAutoSizeColumnMode.None


        dgvStudents.Columns("Action").Width = 125

    End Sub



    '===========================================================
    ' ACTION BUTTON TEXT
    '===========================================================
    Private Sub dgvStudents_CellFormatting(
        sender As Object,
        e As DataGridViewCellFormattingEventArgs
    ) Handles dgvStudents.CellFormatting

        If e.RowIndex < 0 Then
            Exit Sub
        End If


        If Not dgvStudents.Columns.Contains("Action") Then
            Exit Sub
        End If


        If e.ColumnIndex <>
           dgvStudents.Columns("Action").Index Then

            Exit Sub

        End If


        Dim status As String =
            Convert.ToString(
                dgvStudents.Rows(e.RowIndex).
                Cells("Status").Value
            )


        If status.Equals(
            "Active",
            StringComparison.OrdinalIgnoreCase
        ) Then

            e.Value = "Deactivate"

        Else

            e.Value = "Activate"

        End If

    End Sub



    '===========================================================
    ' ACTION BUTTON DESIGN
    '===========================================================
    Private Sub dgvStudents_CellPainting(
        sender As Object,
        e As DataGridViewCellPaintingEventArgs
    ) Handles dgvStudents.CellPainting

        If e.RowIndex < 0 Then
            Exit Sub
        End If


        If Not dgvStudents.Columns.Contains("Action") Then
            Exit Sub
        End If


        If e.ColumnIndex <>
           dgvStudents.Columns("Action").Index Then

            Exit Sub

        End If


        e.PaintBackground(
            e.CellBounds,
            True
        )


        Dim status As String =
            Convert.ToString(
                dgvStudents.Rows(e.RowIndex).
                Cells("Status").Value
            )


        Dim buttonColor As Color
        Dim buttonText As String


        If status.Equals(
            "Active",
            StringComparison.OrdinalIgnoreCase
        ) Then

            ' RED DEACTIVATE
            buttonColor =
                Color.FromArgb(
                    220,
                    53,
                    69
                )

            buttonText = "Deactivate"

        Else

            ' GREEN ACTIVATE
            buttonColor =
                Color.FromArgb(
                    40,
                    167,
                    69
                )

            buttonText = "Activate"

        End If


        Dim buttonRect As New Rectangle(
            e.CellBounds.X + 5,
            e.CellBounds.Y + 5,
            e.CellBounds.Width - 10,
            e.CellBounds.Height - 10
        )


        Using brush As New SolidBrush(
            buttonColor
        )

            e.Graphics.FillRectangle(
                brush,
                buttonRect
            )

        End Using


        Using brush As New SolidBrush(
            Color.White
        )

            Using font As New Font(
                e.CellStyle.Font,
                FontStyle.Bold
            )

                Dim sf As New StringFormat()

                sf.Alignment =
                    StringAlignment.Center

                sf.LineAlignment =
                    StringAlignment.Center


                e.Graphics.DrawString(
                    buttonText,
                    font,
                    brush,
                    buttonRect,
                    sf
                )

            End Using

        End Using


        e.Handled = True

    End Sub



    '===========================================================
    ' ACTION BUTTON CLICK
    '===========================================================
    Private Sub dgvStudents_CellContentClick(
        sender As Object,
        e As DataGridViewCellEventArgs
    ) Handles dgvStudents.CellContentClick

        If e.RowIndex < 0 Then
            Exit Sub
        End If


        If e.ColumnIndex < 0 Then
            Exit Sub
        End If


        If dgvStudents.Columns(e.ColumnIndex).Name <>
           "Action" Then

            Exit Sub

        End If


        Try

            '===================================================
            ' GET STUDENT ID
            '===================================================
            Dim studentID As String =
                Convert.ToString(
                    dgvStudents.Rows(e.RowIndex).
                    Cells("StudentID").Value
                )


            '===================================================
            ' GET CURRENT STATUS
            '===================================================
            Dim currentStatus As String =
                Convert.ToString(
                    dgvStudents.Rows(e.RowIndex).
                    Cells("Status").Value
                )


            '===================================================
            ' DETERMINE NEW STATUS
            '===================================================
            Dim newStatus As String


            If currentStatus.Equals(
                "Active",
                StringComparison.OrdinalIgnoreCase
            ) Then

                newStatus = "Inactive"

            Else

                newStatus = "Active"

            End If


            '===================================================
            ' CONFIRMATION TEXT
            '===================================================
            Dim actionText As String


            If newStatus = "Inactive" Then

                actionText = "deactivate"

            Else

                actionText = "activate"

            End If


            '===================================================
            ' CONFIRMATION
            '===================================================
            Dim result As DialogResult =
                MessageBox.Show(
                    "Are you sure you want to " &
                    actionText &
                    " student " &
                    studentID &
                    "?",
                    "Confirm Status Change",
                    MessageBoxButtons.YesNo,
                    MessageBoxIcon.Question
                )


            If result = DialogResult.No Then
                Exit Sub
            End If


            '===================================================
            ' UPDATE DATABASE
            '===================================================
            Using conn = dbHelper.GetConnection()

                conn.Open()


                Dim updateQuery As String =
                    "UPDATE tblstudents " &
                    "SET Status = @status " &
                    "WHERE StudentID = @studentID"


                Using cmd As New MySqlCommand(
                    updateQuery,
                    conn
                )

                    cmd.Parameters.AddWithValue(
                        "@status",
                        newStatus
                    )

                    cmd.Parameters.AddWithValue(
                        "@studentID",
                        studentID
                    )


                    cmd.ExecuteNonQuery()

                End Using

            End Using


            '===================================================
            ' REFRESH GRID
            '===================================================
            LoadStudents()


            '===================================================
            ' SUCCESS MESSAGE
            '===================================================
            MessageBox.Show(
                "Student " &
                studentID &
                " is now " &
                newStatus &
                ".",
                "Status Updated",
                MessageBoxButtons.OK,
                MessageBoxIcon.Information
            )


        Catch ex As Exception

            MessageBox.Show(
                "Error updating student status: " &
                ex.Message,
                "Error",
                MessageBoxButtons.OK,
                MessageBoxIcon.Error
            )

        End Try

    End Sub



    '===========================================================
    ' PAGINATION UI
    '===========================================================
    Private Sub UpdatePaginationUI(
        totalPages As Integer
    )

        If totalRecords = 0 Then

            lblPagination.Text =
                "Showing 0 records"

            lblResultInfo.Text =
                "0 results found"

            btnPage1.Visible = False
            btnPage2.Visible = False

            btnPrev.Enabled = False
            btnNext.Enabled = False

            Return

        End If


        Dim startRec As Integer =
            ((currentPage - 1) * pageSize) + 1


        Dim endRec As Integer =
            startRec + pageSize - 1


        If endRec > totalRecords Then
            endRec = totalRecords
        End If


        lblPagination.Text =
            "Showing " &
            startRec.ToString() &
            " to " &
            endRec.ToString() &
            " of " &
            totalRecords.ToString() &
            " records"


        lblResultInfo.Text =
            totalRecords.ToString() &
            " results found"


        btnPrev.Enabled =
            (currentPage > 1)


        btnNext.Enabled =
            (currentPage < totalPages)


        '=======================================================
        ' PAGE 1
        '=======================================================
        btnPage1.Visible = True

        btnPage1.Text =
            currentPage.ToString()

        btnPage1.BackColor =
            Color.FromArgb(
                245,
                197,
                24
            )

        btnPage1.ForeColor =
            Color.FromArgb(
                15,
                31,
                76
            )


        '=======================================================
        ' PAGE 2
        '=======================================================
        If currentPage < totalPages Then

            btnPage2.Visible = True

            btnPage2.Text =
                (currentPage + 1).ToString()

            btnPage2.BackColor =
                Color.FromArgb(
                    26,
                    46,
                    99
                )

            btnPage2.ForeColor =
                Color.White

        Else

            btnPage2.Visible = False

        End If

    End Sub



    '===========================================================
    ' PREVIOUS PAGE
    '===========================================================
    Private Sub btnPrev_Click(
        sender As Object,
        e As EventArgs
    ) Handles btnPrev.Click

        If currentPage > 1 Then

            currentPage -= 1

            LoadStudents()

        End If

    End Sub



    '===========================================================
    ' NEXT PAGE
    '===========================================================
    Private Sub btnNext_Click(
        sender As Object,
        e As EventArgs
    ) Handles btnNext.Click

        Dim totalPages As Integer =
            CInt(
                Math.Ceiling(
                    totalRecords / CDbl(pageSize)
                )
            )


        If currentPage < totalPages Then

            currentPage += 1

            LoadStudents()

        End If

    End Sub



    '===========================================================
    ' PAGE 1 BUTTON
    '===========================================================
    Private Sub btnPage1_Click(
        sender As Object,
        e As EventArgs
    ) Handles btnPage1.Click

        LoadStudents()

    End Sub



    '===========================================================
    ' PAGE 2 BUTTON
    '===========================================================
    Private Sub btnPage2_Click(
        sender As Object,
        e As EventArgs
    ) Handles btnPage2.Click

        Dim totalPages As Integer =
            CInt(
                Math.Ceiling(
                    totalRecords / CDbl(pageSize)
                )
            )


        If currentPage < totalPages Then

            currentPage += 1

            LoadStudents()

        End If

    End Sub



    '===========================================================
    ' SEARCH BUTTON
    '===========================================================
    Private Sub btnSearch_Click(
        sender As Object,
        e As EventArgs
    ) Handles btnSearch.Click

        currentPage = 1

        LoadStudents()

    End Sub



    '===========================================================
    ' COURSE FILTER
    '===========================================================
    Private Sub cboCourseFilter_SelectedIndexChanged(
        sender As Object,
        e As EventArgs
    ) Handles cboCourseFilter.SelectedIndexChanged

        If Not Me.IsHandleCreated Then
            Exit Sub
        End If


        currentPage = 1

        LoadStudents()

    End Sub



    '===========================================================
    ' STATUS FILTER
    '===========================================================
    Private Sub cboStatusFilter_SelectedIndexChanged(
        sender As Object,
        e As EventArgs
    ) Handles cboStatusFilter.SelectedIndexChanged

        If Not Me.IsHandleCreated Then
            Exit Sub
        End If


        currentPage = 1

        LoadStudents()

    End Sub



    '===========================================================
    ' RESET
    '===========================================================
    Private Sub btnReset_Click(
        sender As Object,
        e As EventArgs
    ) Handles btnReset.Click

        txtSearch.Text = ""


        ' RESET COURSE ONLY IF NOT LOCKED
        If dbHelper.currentUserRole = "Administrator" OrElse
           String.IsNullOrEmpty(dbHelper.userCourseAssigned) OrElse
           dbHelper.userCourseAssigned = "ALL" Then

            cboCourseFilter.SelectedIndex = 0

        End If


        cboStatusFilter.SelectedIndex = 0

        currentPage = 1

        LoadStudents()

    End Sub



    '===========================================================
    ' DASHBOARD
    '===========================================================
    Private Sub btnDashboard_Click(
        sender As Object,
        e As EventArgs
    ) Handles btnDashboard.Click

        Dim frm As New frmStaffDashboard()

        frm.Show()

        Me.Close()

    End Sub



    '===========================================================
    ' NEW REQUEST
    '===========================================================
    Private Sub btnNewRequest_Click(
        sender As Object,
        e As EventArgs
    ) Handles btnNewRequest.Click

        Dim frm As New frmNewRequest()

        frm.Show()

        Me.Close()

    End Sub



    '===========================================================
    ' REQUEST LIST
    '===========================================================
    Private Sub btnRequestList_Click(
        sender As Object,
        e As EventArgs
    ) Handles btnRequestList.Click

        Dim frm As New frmRequestList()

        frm.Show()

        Me.Close()

    End Sub



    '===========================================================
    ' REPORTS
    '===========================================================
    Private Sub btnReports_Click(
        sender As Object,
        e As EventArgs
    ) Handles btnReports.Click

        Dim frm As New frmReports()

        frm.Show()

        Me.Close()

    End Sub



    '===========================================================
    ' LOGOUT
    '===========================================================
    Private Sub btnLogout_Click(
        sender As Object,
        e As EventArgs
    ) Handles btnLogout.Click

        dbHelper.currentUserID = 0
        dbHelper.currentUserName = ""
        dbHelper.currentUserRole = ""
        dbHelper.userCourseAssigned = ""


        Dim login As New frmLogin()

        login.Show()

        Me.Close()

    End Sub



    '===========================================================
    ' LIVE SEARCH
    '===========================================================
    Private Sub txtSearch_TextChanged(
        sender As Object,
        e As EventArgs
    ) Handles txtSearch.TextChanged

        If Not Me.IsHandleCreated Then
            Exit Sub
        End If


        currentPage = 1

        LoadStudents()

    End Sub

End Class