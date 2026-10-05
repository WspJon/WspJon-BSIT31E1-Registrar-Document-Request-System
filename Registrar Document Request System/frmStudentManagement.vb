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

    Private Sub dgvStudents_CellFormatting(sender As Object, e As DataGridViewCellFormattingEventArgs) Handles dgvStudents.CellFormatting
        If e.RowIndex < 0 OrElse Not dgvStudents.Columns.Contains("colActions") OrElse e.ColumnIndex <> dgvStudents.Columns("colActions").Index Then
            Exit Sub
        End If

        Dim status As String = Convert.ToString(dgvStudents.Rows(e.RowIndex).Cells("colStatus").Value)
        If status.Equals("Active", StringComparison.OrdinalIgnoreCase) Then
            e.Value = "Deactivate"
        Else
            e.Value = "Activate"
        End If
    End Sub

    Private Sub dgvStudents_CellPainting(sender As Object, e As DataGridViewCellPaintingEventArgs) Handles dgvStudents.CellPainting
        If e.RowIndex < 0 OrElse Not dgvStudents.Columns.Contains("colActions") OrElse e.ColumnIndex <> dgvStudents.Columns("colActions").Index Then
            Exit Sub
        End If

        e.PaintBackground(e.CellBounds, True)
        Dim status As String = Convert.ToString(dgvStudents.Rows(e.RowIndex).Cells("colStatus").Value)
        Dim buttonColor As Color
        Dim buttonText As String

        If status.Equals("Active", StringComparison.OrdinalIgnoreCase) Then
            buttonColor = Color.FromArgb(220, 53, 69) ' RED DEACTIVATE
            buttonText = "Deactivate"
        Else
            buttonColor = Color.FromArgb(40, 167, 69) ' GREEN ACTIVATE
            buttonText = "Activate"
        End If

        Dim buttonRect As New Rectangle(e.CellBounds.X + 5, e.CellBounds.Y + 5, e.CellBounds.Width - 10, e.CellBounds.Height - 10)
        Using brush As New SolidBrush(buttonColor)
            e.Graphics.FillRectangle(brush, buttonRect)
        End Using

        Using font As New Font(e.CellStyle.Font, FontStyle.Bold)
            Dim textSize As SizeF = e.Graphics.MeasureString(buttonText, font)
            Dim textX As Single = buttonRect.X + (buttonRect.Width - textSize.Width) / 2
            Dim textY As Single = buttonRect.Y + (buttonRect.Height - textSize.Height) / 2
            e.Graphics.DrawString(buttonText, font, Brushes.White, textX, textY)
        End Using

        e.Handled = True
    End Sub

    Private Sub dgvStudents_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvStudents.CellClick
        If e.RowIndex >= 0 AndAlso dgvStudents.Columns(e.ColumnIndex).Name = "colActions" Then
            Dim studentID As String = dgvStudents.Rows(e.RowIndex).Cells("colStudentID").Value.ToString()
            Dim currentStatus As String = dgvStudents.Rows(e.RowIndex).Cells("colStatus").Value.ToString()
            Dim studentName As String = dgvStudents.Rows(e.RowIndex).Cells("colName").Value.ToString()
            
            Dim newStatus As String = If(currentStatus = "Active", "Inactive", "Active")
            Dim actionText As String = If(newStatus = "Inactive", "deactivate", "activate")
            
            Dim result As DialogResult = MessageBox.Show($"Are you sure you want to {actionText} {studentName}'s account?", "Confirm Status Change", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
            
            If result = DialogResult.Yes Then
                Try
                    Using conn = dbHelper.GetConnection()
                        conn.Open()
                        Dim query As String = "UPDATE tblstudents SET Status = @status WHERE StudentID = @id"
                        Using cmd As New MySqlCommand(query, conn)
                            cmd.Parameters.AddWithValue("@status", newStatus)
                            cmd.Parameters.AddWithValue("@id", studentID)
                            cmd.ExecuteNonQuery()
                        End Using
                    End Using
                    MessageBox.Show($"Student successfully {actionText}d.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information)
                    LoadStudents(txtSearch.Text.Trim(), GetSelectedCourse())
                Catch ex As Exception
                    MessageBox.Show("Error updating status.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                End Try
            End If
        End If
    End Sub

End Class
