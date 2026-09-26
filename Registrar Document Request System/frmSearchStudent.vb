Imports MySql.Data.MySqlClient
Imports System.Drawing

Public Class frmSearchStudent

    Private currentPage As Integer = 1
    Private pageSize As Integer = 10
    Private totalRecords As Integer = 0

    Private Sub frmSearchStudent_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        cboCourseFilter.Items.Add("All Courses")
        cboCourseFilter.Items.Add("BSIT")
        cboCourseFilter.Items.Add("BSCS")
        cboCourseFilter.Items.Add("BSIS")
        cboCourseFilter.SelectedIndex = 0

        cboStatusFilter.Items.Add("All Status")
        cboStatusFilter.Items.Add("Active")
        cboStatusFilter.Items.Add("Inactive")
        cboStatusFilter.SelectedIndex = 0

        LoadStudents()
    End Sub

    Private Sub LoadStudents()
        Try
            Using conn = dbHelper.GetConnection()
                conn.Open()

                Dim whereClause As String = " WHERE 1=1"
                Dim search As String = txtSearch.Text.Trim()
                If Not String.IsNullOrEmpty(search) Then
                    whereClause &= " AND (StudentID LIKE @search OR FirstName LIKE @search OR LastName LIKE @search)"
                End If

                If cboCourseFilter.SelectedIndex > 0 Then
                    whereClause &= " AND Course = @course"
                End If

                If cboStatusFilter.SelectedIndex > 0 Then
                    whereClause &= " AND Status = @status"
                End If

                Dim countQuery As String = "SELECT COUNT(*) FROM tblstudents" & whereClause
                Using cmdCount As New MySqlCommand(countQuery, conn)
                    If Not String.IsNullOrEmpty(search) Then cmdCount.Parameters.AddWithValue("@search", "%" & search & "%")
                    If cboCourseFilter.SelectedIndex > 0 Then cmdCount.Parameters.AddWithValue("@course", cboCourseFilter.SelectedItem.ToString())
                    If cboStatusFilter.SelectedIndex > 0 Then cmdCount.Parameters.AddWithValue("@status", cboStatusFilter.SelectedItem.ToString())

                    totalRecords = Convert.ToInt32(cmdCount.ExecuteScalar())
                End Using

                Dim totalPages As Integer = Math.Ceiling(totalRecords / pageSize)
                If currentPage < 1 Then currentPage = 1
                If currentPage > totalPages AndAlso totalPages > 0 Then currentPage = totalPages

                Dim offset As Integer = (currentPage - 1) * pageSize
                If offset < 0 Then offset = 0

                Dim query As String = "SELECT StudentID, CONCAT(FirstName, ' ', LastName) AS FullName, Course, YearLevel, ContactNo, Status FROM tblstudents" & whereClause & " LIMIT @limit OFFSET @offset"
                Using cmd As New MySqlCommand(query, conn)
                    If Not String.IsNullOrEmpty(search) Then cmd.Parameters.AddWithValue("@search", "%" & search & "%")
                    If cboCourseFilter.SelectedIndex > 0 Then cmd.Parameters.AddWithValue("@course", cboCourseFilter.SelectedItem.ToString())
                    If cboStatusFilter.SelectedIndex > 0 Then cmd.Parameters.AddWithValue("@status", cboStatusFilter.SelectedItem.ToString())
                    cmd.Parameters.AddWithValue("@limit", pageSize)
                    cmd.Parameters.AddWithValue("@offset", offset)

                    Dim adapter As New MySqlDataAdapter(cmd)
                    Dim dt As New DataTable()
                    adapter.Fill(dt)

                    dgvStudents.AutoGenerateColumns = True
                    dgvStudents.DataSource = dt
                End Using

                UpdatePaginationUI(totalPages)
            End Using
        Catch ex As Exception
        End Try
    End Sub

    Private Sub UpdatePaginationUI(totalPages As Integer)
        If totalRecords = 0 Then
            lblPagination.Text = "Showing 0 records"
            lblResultInfo.Text = "0 results found"
            btnPage1.Visible = False
            btnPage2.Visible = False
            btnPrev.Enabled = False
            btnNext.Enabled = False
            Return
        End If

        Dim startRec As Integer = ((currentPage - 1) * pageSize) + 1
        Dim endRec As Integer = startRec + pageSize - 1
        If endRec > totalRecords Then endRec = totalRecords

        lblPagination.Text = "Showing " & startRec.ToString() & " to " & endRec.ToString() & " of " & totalRecords.ToString() & " records"
        lblResultInfo.Text = totalRecords.ToString() & " results found"

        btnPrev.Enabled = (currentPage > 1)
        btnNext.Enabled = (currentPage < totalPages)

        btnPage1.Visible = True
        btnPage1.Text = currentPage.ToString()
        btnPage1.BackColor = Color.FromArgb(245, 197, 24)
        btnPage1.ForeColor = Color.FromArgb(15, 31, 76)

        If currentPage < totalPages Then
            btnPage2.Visible = True
            btnPage2.Text = (currentPage + 1).ToString()
            btnPage2.BackColor = Color.FromArgb(26, 46, 99)
            btnPage2.ForeColor = Color.White
        Else
            btnPage2.Visible = False
        End If
    End Sub

    Private Sub btnPrev_Click(sender As Object, e As EventArgs) Handles btnPrev.Click
        If currentPage > 1 Then
            currentPage -= 1
            LoadStudents()
        End If
    End Sub

    Private Sub btnNext_Click(sender As Object, e As EventArgs) Handles btnNext.Click
        currentPage += 1
        LoadStudents()
    End Sub

    Private Sub btnPage2_Click(sender As Object, e As EventArgs) Handles btnPage2.Click
        currentPage += 1
        LoadStudents()
    End Sub

    Private Sub btnSearch_Click(sender As Object, e As EventArgs) Handles btnSearch.Click
        currentPage = 1
        LoadStudents()
    End Sub

    Private Sub cboCourseFilter_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cboCourseFilter.SelectedIndexChanged
        currentPage = 1
        LoadStudents()
    End Sub

    Private Sub cboStatusFilter_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cboStatusFilter.SelectedIndexChanged
        currentPage = 1
        LoadStudents()
    End Sub

    Private Sub btnReset_Click(sender As Object, e As EventArgs) Handles btnReset.Click
        txtSearch.Text = ""
        cboCourseFilter.SelectedIndex = 0
        cboStatusFilter.SelectedIndex = 0
        currentPage = 1
        LoadStudents()
    End Sub

    Private Sub btnDashboard_Click(sender As Object, e As EventArgs) Handles btnDashboard.Click
        Dim frm As New frmStaffDashboard()
        frm.Show()
        Me.Close()
    End Sub

    Private Sub btnNewRequest_Click(sender As Object, e As EventArgs) Handles btnNewRequest.Click
        Dim frm As New frmNewRequest()
        frm.Show()
        Me.Close()
    End Sub

    Private Sub btnRequestList_Click(sender As Object, e As EventArgs) Handles btnRequestList.Click
        Dim frm As New frmRequestList()
        frm.Show()
        Me.Close()
    End Sub

    Private Sub btnReports_Click(sender As Object, e As EventArgs) Handles btnReports.Click
        Dim frm As New frmReports()
        frm.Show()
        Me.Close()
    End Sub

    Private Sub btnLogout_Click(sender As Object, e As EventArgs) Handles btnLogout.Click
        dbHelper.currentUserID = 0
        dbHelper.currentUserName = ""
        dbHelper.currentUserRole = ""
        Dim login As New frmLogin()
        login.Show()
        Me.Close()
    End Sub

    Private Sub txtSearch_TextChanged(sender As Object, e As EventArgs) Handles txtSearch.TextChanged

    End Sub
End Class
