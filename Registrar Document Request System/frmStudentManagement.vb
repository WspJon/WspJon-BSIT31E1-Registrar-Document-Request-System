Imports MySql.Data.MySqlClient
Imports System.Windows.Forms
Imports System.Runtime.InteropServices

Public Class frmStudentManagement

    <DllImport("user32.dll", CharSet:=CharSet.Auto)>
    Private Shared Function SendMessage(ByVal hWnd As IntPtr, ByVal msg As Integer, ByVal wParam As Integer, ByVal lParam As String) As IntPtr
    End Function

    Private Const EM_SETCUEBANNER As Integer = &H1501

    Private Sub frmStudentManagement_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        If cboCourseFilter.Items.Count > 0 Then
            cboCourseFilter.SelectedIndex = 0
        End If

        SendMessage(txtSearch.Handle, EM_SETCUEBANNER, 0, "Search...")

        LoadStudents()
    End Sub

    Public Sub LoadStudents(Optional searchTerm As String = "", Optional courseFilter As String = "All Courses")
        Try
            Using conn = dbHelper.GetConnection()
                conn.Open()
                Dim query As String = "SELECT StudentID, CONCAT(FirstName, ' ', LastName) AS Name, Course, YearLevel, Status FROM tblstudents WHERE Status != 'Deleted'"

                ' LAST NAME, FIRST NAME, AT STUDENT ID LANG ANG PWEDENG MA-SEARCH
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
        End Try
    End Sub

    Private Function GetSelectedCourse() As String
        If cboCourseFilter.SelectedItem IsNot Nothing Then
            Return cboCourseFilter.SelectedItem.ToString()
        End If
        Return "All Courses"
    End Function

    Private Sub btnSearch_Click(sender As Object, e As EventArgs) Handles btnSearch.Click
        LoadStudents(txtSearch.Text.Trim(), GetSelectedCourse())
    End Sub

    Private Sub btnAddStudent_Click(sender As Object, e As EventArgs) Handles btnAddStudent.Click
        Dim frm As New frmStudentAddEdit()
        frm.IsEditMode = False
        If frm.ShowDialog() = DialogResult.OK Then
            LoadStudents(txtSearch.Text.Trim(), GetSelectedCourse())
        End If
    End Sub

    Private Sub txtSearch_TextChanged(sender As Object, e As EventArgs) Handles txtSearch.TextChanged
        LoadStudents(txtSearch.Text.Trim(), GetSelectedCourse())
    End Sub

    Private Sub cboCourseFilter_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cboCourseFilter.SelectedIndexChanged
        LoadStudents(txtSearch.Text.Trim(), GetSelectedCourse())
    End Sub

End Class