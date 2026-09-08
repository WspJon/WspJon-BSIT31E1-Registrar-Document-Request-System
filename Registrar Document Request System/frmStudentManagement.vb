Imports MySql.Data.MySqlClient

Public Class frmStudentManagement

    Private Sub frmStudentManagement_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ' Set default filter
        If cboCourseFilter.Items.Count > 0 Then
            cboCourseFilter.SelectedIndex = 0
        End If
        LoadStudents()
    End Sub

    Public Sub LoadStudents(Optional searchTerm As String = "", Optional courseFilter As String = "All Courses")
        Try
            Using conn = dbHelper.GetConnection()
                conn.Open()
                ' Note: Classmate's prompt said "Soft delete only (Status = 'Inactive')"
                Dim query As String = "SELECT StudentID, CONCAT(FirstName, ' ', LastName) AS Name, Course, YearLevel, Status FROM tblstudents WHERE Status != 'Deleted'"
                
                If Not String.IsNullOrWhiteSpace(searchTerm) Then
                    query &= " AND (StudentID LIKE @search OR LastName LIKE @search OR FirstName LIKE @search)"
                End If

                If courseFilter <> "All Courses" AndAlso Not String.IsNullOrEmpty(courseFilter) Then
                    query &= " AND Course = @course"
                End If

                Using cmd As New MySqlCommand(query, conn)
                    If Not String.IsNullOrWhiteSpace(searchTerm) Then
                        cmd.Parameters.AddWithValue("@search", "%" & searchTerm & "%")
                    End If
                    If courseFilter <> "All Courses" AndAlso Not String.IsNullOrEmpty(courseFilter) Then
                        cmd.Parameters.AddWithValue("@course", courseFilter)
                    End If

                    Dim adapter As New MySqlDataAdapter(cmd)
                    Dim dt As New DataTable()
                    adapter.Fill(dt)

                    dgvStudents.AutoGenerateColumns = False
                    colStudentID.DataPropertyName = "StudentID"
                    colName.DataPropertyName = "Name"
                    colCourse.DataPropertyName = "Course"
                    colYear.DataPropertyName = "YearLevel"
                    colStatus.DataPropertyName = "Status"
                    dgvStudents.DataSource = dt
                End Using
            End Using
        Catch ex As Exception
            ' Ignore error if database isn't ready
        End Try
    End Sub

    Private Sub btnSearch_Click(sender As Object, e As EventArgs) Handles btnSearch.Click
        LoadStudents(txtSearch.Text.Trim(), cboCourseFilter.SelectedItem.ToString())
    End Sub

    Private Sub btnAddStudent_Click(sender As Object, e As EventArgs) Handles btnAddStudent.Click
        Dim frm As New frmStudentAddEdit()
        frm.IsEditMode = False
        If frm.ShowDialog() = DialogResult.OK Then
            ' Refresh the table if a new student was added successfully
            LoadStudents(txtSearch.Text.Trim(), cboCourseFilter.SelectedItem.ToString())
        End If
    End Sub

End Class
