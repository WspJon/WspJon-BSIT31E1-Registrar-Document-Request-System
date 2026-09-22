Imports MySql.Data.MySqlClient

Public Class frmSearchStudent

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
                Dim query As String = "SELECT StudentID, CONCAT(FirstName, ' ', LastName) AS FullName, Course, YearLevel, ContactNo, Status FROM tblstudents WHERE 1=1"

                Dim search As String = txtSearch.Text.Trim()
                If Not String.IsNullOrEmpty(search) Then
                    query &= " AND (StudentID LIKE @search OR FirstName LIKE @search OR LastName LIKE @search)"
                End If

                If cboCourseFilter.SelectedIndex > 0 Then
                    query &= " AND Course = @course"
                End If

                If cboStatusFilter.SelectedIndex > 0 Then
                    query &= " AND Status = @status"
                End If

                Using cmd As New MySqlCommand(query, conn)
                    If Not String.IsNullOrEmpty(search) Then
                        cmd.Parameters.AddWithValue("@search", "%" & search & "%")
                    End If
                    If cboCourseFilter.SelectedIndex > 0 Then
                        cmd.Parameters.AddWithValue("@course", cboCourseFilter.SelectedItem.ToString())
                    End If
                    If cboStatusFilter.SelectedIndex > 0 Then
                        cmd.Parameters.AddWithValue("@status", cboStatusFilter.SelectedItem.ToString())
                    End If

                    Dim adapter As New MySqlDataAdapter(cmd)
                    Dim dt As New DataTable()
                    adapter.Fill(dt)

                    dgvStudents.AutoGenerateColumns = True
                    dgvStudents.DataSource = dt
                    lblResultInfo.Text = "Showing " & dt.Rows.Count & " results"
                End Using
            End Using
        Catch ex As Exception
            ' Ignore error if DB not ready
        End Try
    End Sub

    Private Sub btnSearch_Click(sender As Object, e As EventArgs) Handles btnSearch.Click
        LoadStudents()
    End Sub

    Private Sub btnReset_Click(sender As Object, e As EventArgs) Handles btnReset.Click
        txtSearch.Text = ""
        cboCourseFilter.SelectedIndex = 0
        cboStatusFilter.SelectedIndex = 0
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

End Class
