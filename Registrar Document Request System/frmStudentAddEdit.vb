Imports MySql.Data.MySqlClient
Imports System.Windows.Forms

Public Class frmStudentAddEdit
    Public IsEditMode As Boolean = False
    Public OriginalStudentID As String = ""
    Public OriginalLRN As String = ""

    Private Sub btnCancel_Click(sender As Object, e As EventArgs) Handles btnCancel.Click
        Me.DialogResult = DialogResult.Cancel
        Me.Close()
    End Sub

    Private Sub btnSave_Click(sender As Object, e As EventArgs) Handles btnSave.Click
        ' Validation
        If String.IsNullOrWhiteSpace(txtStudentID.Text) OrElse
           String.IsNullOrWhiteSpace(txtLRN.Text) OrElse
           String.IsNullOrWhiteSpace(txtFirstName.Text) OrElse
           String.IsNullOrWhiteSpace(txtLastName.Text) OrElse
           cboCourse.SelectedIndex = -1 OrElse
           cboYearLevel.SelectedIndex = -1 Then
            MessageBox.Show("Please fill in all required fields (Student ID, LRN, First Name, Last Name, Course, Year Level).", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Return
        End If

        Try
            Using conn = dbHelper.GetConnection()
                conn.Open()
                
                ' Check Uniqueness (Rule 5.3)
                Dim checkQuery As String = "SELECT StudentID, LRN FROM tblstudents WHERE StudentID = @id OR LRN = @lrn"
                Using checkCmd As New MySqlCommand(checkQuery, conn)
                    checkCmd.Parameters.AddWithValue("@id", txtStudentID.Text.Trim())
                    checkCmd.Parameters.AddWithValue("@lrn", txtLRN.Text.Trim())
                    
                    Using reader = checkCmd.ExecuteReader()
                        While reader.Read()
                            Dim foundID As String = reader("StudentID").ToString()
                            Dim foundLRN As String = reader("LRN").ToString()
                            
                            If IsEditMode Then
                                If foundID = txtStudentID.Text.Trim() AndAlso foundID <> OriginalStudentID Then
                                    MessageBox.Show("This Student ID is already registered to another student.", "Duplicate ID", MessageBoxButtons.OK, MessageBoxIcon.Error)
                                    Return
                                End If
                                If foundLRN = txtLRN.Text.Trim() AndAlso foundLRN <> OriginalLRN Then
                                    MessageBox.Show("This LRN is already registered to another student.", "Duplicate LRN", MessageBoxButtons.OK, MessageBoxIcon.Error)
                                    Return
                                End If
                            Else
                                If foundID = txtStudentID.Text.Trim() Then
                                    MessageBox.Show("This Student ID is already registered.", "Duplicate ID", MessageBoxButtons.OK, MessageBoxIcon.Error)
                                    Return
                                End If
                                If foundLRN = txtLRN.Text.Trim() Then
                                    MessageBox.Show("This LRN is already registered.", "Duplicate LRN", MessageBoxButtons.OK, MessageBoxIcon.Error)
                                    Return
                                End If
                            End If
                        End While
                    End Using
                End Using

                ' Insert or Update logic
                Dim query As String
                If IsEditMode Then
                    query = "UPDATE tblstudents SET StudentID=@newId, LRN=@lrn, FirstName=@fname, LastName=@lname, MiddleName=@mname, Course=@course, YearLevel=@year, Section=@section, ContactNo=@contact, Status=@status WHERE StudentID=@oldId"
                Else
                    query = "INSERT INTO tblstudents (StudentID, LRN, FirstName, LastName, MiddleName, Course, YearLevel, Section, ContactNo, Status) VALUES (@newId, @lrn, @fname, @lname, @mname, @course, @year, @section, @contact, @status)"
                End If

                Using cmd As New MySqlCommand(query, conn)
                    cmd.Parameters.AddWithValue("@newId", txtStudentID.Text.Trim())
                    cmd.Parameters.AddWithValue("@lrn", txtLRN.Text.Trim())
                    cmd.Parameters.AddWithValue("@fname", txtFirstName.Text.Trim())
                    cmd.Parameters.AddWithValue("@lname", txtLastName.Text.Trim())
                    cmd.Parameters.AddWithValue("@mname", txtMiddleName.Text.Trim())
                    cmd.Parameters.AddWithValue("@course", cboCourse.SelectedItem.ToString())
                    cmd.Parameters.AddWithValue("@year", cboYearLevel.SelectedItem.ToString())
                    cmd.Parameters.AddWithValue("@section", txtSection.Text.Trim())
                    cmd.Parameters.AddWithValue("@contact", txtContactNo.Text.Trim())
                    cmd.Parameters.AddWithValue("@status", If(cboStatus.SelectedIndex = -1, "Active", cboStatus.SelectedItem.ToString()))
                    
                    If IsEditMode Then
                        cmd.Parameters.AddWithValue("@oldId", OriginalStudentID)
                    End If

                    cmd.ExecuteNonQuery()
                End Using

                MessageBox.Show("Student details saved successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information)
                Me.DialogResult = DialogResult.OK
                Me.Close()
            End Using
        Catch ex As Exception
            MessageBox.Show("Database Error: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub frmStudentAddEdit_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        If Not IsEditMode Then
            lblTitle.Text = "Add New Student"
            If cboStatus.Items.Count > 0 Then cboStatus.SelectedIndex = 0
        Else
            lblTitle.Text = "Edit Student"
        End If
    End Sub
End Class
