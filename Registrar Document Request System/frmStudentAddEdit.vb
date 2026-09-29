Imports MySql.Data.MySqlClient
Imports System.Windows.Forms
Imports System.Text.RegularExpressions

Public Class frmStudentAddEdit

    Public IsEditMode As Boolean = False
    Public OriginalStudentID As String = ""
    Public OriginalLRN As String = ""

    Private Sub btnCancel_Click(sender As Object, e As EventArgs) Handles btnCancel.Click
        Me.DialogResult = DialogResult.Cancel
        Me.Close()
    End Sub

    Private Function IsValidName(ByVal value As String) As Boolean
        If String.IsNullOrWhiteSpace(value) Then
            Return False
        End If

        Return Regex.IsMatch(value.Trim(), "^[A-Za-zÀ-ÿ\s'-]+$")
    End Function

    Private Function IsValidStudentID(ByVal value As String) As Boolean
        If String.IsNullOrWhiteSpace(value) Then
            Return False
        End If

        Return Regex.IsMatch(value.Trim(), "^[A-Za-z0-9-]+$")
    End Function

    Private Function IsValidLRN(ByVal value As String) As Boolean
        If String.IsNullOrWhiteSpace(value) Then
            Return False
        End If

        Return Regex.IsMatch(value.Trim(), "^\d{12}$")
    End Function

    Private Function IsValidContact(ByVal value As String) As Boolean
        If String.IsNullOrWhiteSpace(value) Then
            Return False
        End If

        Return Regex.IsMatch(value.Trim(), "^\d{11}$")
    End Function

    Private Sub btnSave_Click(sender As Object, e As EventArgs) Handles btnSave.Click

        txtStudentID.Text = txtStudentID.Text.Trim()
        txtLRN.Text = txtLRN.Text.Trim()
        txtFirstName.Text = txtFirstName.Text.Trim()
        txtMiddleName.Text = txtMiddleName.Text.Trim()
        txtLastName.Text = txtLastName.Text.Trim()
        txtSection.Text = txtSection.Text.Trim()
        txtContactNo.Text = txtContactNo.Text.Trim()

        If String.IsNullOrWhiteSpace(txtStudentID.Text) Then
            MessageBox.Show("Please enter the Student ID.",
                            "Validation Error",
                            MessageBoxButtons.OK,
                            MessageBoxIcon.Warning)
            txtStudentID.Focus()
            Return
        End If

        If String.IsNullOrWhiteSpace(txtLRN.Text) Then
            MessageBox.Show("Please enter the LRN.",
                            "Validation Error",
                            MessageBoxButtons.OK,
                            MessageBoxIcon.Warning)
            txtLRN.Focus()
            Return
        End If

        If String.IsNullOrWhiteSpace(txtFirstName.Text) Then
            MessageBox.Show("Please enter the First Name.",
                            "Validation Error",
                            MessageBoxButtons.OK,
                            MessageBoxIcon.Warning)
            txtFirstName.Focus()
            Return
        End If

        If String.IsNullOrWhiteSpace(txtLastName.Text) Then
            MessageBox.Show("Please enter the Last Name.",
                            "Validation Error",
                            MessageBoxButtons.OK,
                            MessageBoxIcon.Warning)
            txtLastName.Focus()
            Return
        End If

        If cboYearLevel.SelectedIndex = -1 Then
            MessageBox.Show("Please select a Year Level.",
                            "Validation Error",
                            MessageBoxButtons.OK,
                            MessageBoxIcon.Warning)
            cboYearLevel.Focus()
            Return
        End If

        If cboCourse.SelectedIndex = -1 Then
            MessageBox.Show("Please select a Course.",
                            "Validation Error",
                            MessageBoxButtons.OK,
                            MessageBoxIcon.Warning)
            cboCourse.Focus()
            Return
        End If

        If String.IsNullOrWhiteSpace(txtSection.Text) Then
            MessageBox.Show("Please enter the Section.",
                            "Validation Error",
                            MessageBoxButtons.OK,
                            MessageBoxIcon.Warning)
            txtSection.Focus()
            Return
        End If

        If String.IsNullOrWhiteSpace(txtContactNo.Text) Then
            MessageBox.Show("Please enter the Contact No.",
                            "Validation Error",
                            MessageBoxButtons.OK,
                            MessageBoxIcon.Warning)
            txtContactNo.Focus()
            Return
        End If

        If Not IsValidStudentID(txtStudentID.Text) Then
            MessageBox.Show("Student ID can only contain letters, numbers, and hyphens.",
                            "Invalid Student ID",
                            MessageBoxButtons.OK,
                            MessageBoxIcon.Warning)
            txtStudentID.Focus()
            Return
        End If

        If Not IsValidLRN(txtLRN.Text) Then
            MessageBox.Show("LRN must contain exactly 12 digits.",
                            "Invalid LRN",
                            MessageBoxButtons.OK,
                            MessageBoxIcon.Warning)
            txtLRN.Focus()
            Return
        End If

        If Not IsValidName(txtFirstName.Text) Then
            MessageBox.Show("First Name can only contain letters, spaces, hyphens, and apostrophes.",
                            "Invalid First Name",
                            MessageBoxButtons.OK,
                            MessageBoxIcon.Warning)
            txtFirstName.Focus()
            Return
        End If

        If Not String.IsNullOrWhiteSpace(txtMiddleName.Text) Then
            If Not IsValidName(txtMiddleName.Text) Then
                MessageBox.Show("Middle Name can only contain letters, spaces, hyphens, and apostrophes.",
                                "Invalid Middle Name",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Warning)
                txtMiddleName.Focus()
                Return
            End If
        End If

        If Not IsValidName(txtLastName.Text) Then
            MessageBox.Show("Last Name can only contain letters, spaces, hyphens, and apostrophes.",
                            "Invalid Last Name",
                            MessageBoxButtons.OK,
                            MessageBoxIcon.Warning)
            txtLastName.Focus()
            Return
        End If

        If Not Regex.IsMatch(txtSection.Text, "^[A-Za-z0-9-]+$") Then
            MessageBox.Show("Section can only contain letters, numbers, and hyphens.",
                            "Invalid Section",
                            MessageBoxButtons.OK,
                            MessageBoxIcon.Warning)
            txtSection.Focus()
            Return
        End If

        If Not IsValidContact(txtContactNo.Text) Then
            MessageBox.Show("Contact No. must contain exactly 11 digits.",
                            "Invalid Contact Number",
                            MessageBoxButtons.OK,
                            MessageBoxIcon.Warning)
            txtContactNo.Focus()
            Return
        End If

        Try

            Using conn = dbHelper.GetConnection()

                conn.Open()

                Dim checkQuery As String =
                    "SELECT StudentID, LRN FROM tblstudents " &
                    "WHERE StudentID = @id OR LRN = @lrn"

                Using checkCmd As New MySqlCommand(checkQuery, conn)

                    checkCmd.Parameters.AddWithValue("@id", txtStudentID.Text.Trim())
                    checkCmd.Parameters.AddWithValue("@lrn", txtLRN.Text.Trim())

                    Using reader = checkCmd.ExecuteReader()

                        While reader.Read()

                            Dim foundID As String = reader("StudentID").ToString()
                            Dim foundLRN As String = reader("LRN").ToString()

                            If IsEditMode Then

                                If foundID = txtStudentID.Text.Trim() AndAlso
                                   foundID <> OriginalStudentID Then

                                    MessageBox.Show(
                                        "This Student ID is already registered to another student.",
                                        "Duplicate ID",
                                        MessageBoxButtons.OK,
                                        MessageBoxIcon.Error)

                                    txtStudentID.Focus()
                                    Return

                                End If

                                If foundLRN = txtLRN.Text.Trim() AndAlso
                                   foundLRN <> OriginalLRN Then

                                    MessageBox.Show(
                                        "This LRN is already registered to another student.",
                                        "Duplicate LRN",
                                        MessageBoxButtons.OK,
                                        MessageBoxIcon.Error)

                                    txtLRN.Focus()
                                    Return

                                End If

                            Else

                                If foundID = txtStudentID.Text.Trim() Then

                                    MessageBox.Show(
                                        "This Student ID is already registered.",
                                        "Duplicate ID",
                                        MessageBoxButtons.OK,
                                        MessageBoxIcon.Error)

                                    txtStudentID.Focus()
                                    Return

                                End If

                                If foundLRN = txtLRN.Text.Trim() Then

                                    MessageBox.Show(
                                        "This LRN is already registered.",
                                        "Duplicate LRN",
                                        MessageBoxButtons.OK,
                                        MessageBoxIcon.Error)

                                    txtLRN.Focus()
                                    Return

                                End If

                            End If

                        End While

                    End Using

                End Using

                Dim query As String

                If IsEditMode Then

                    query =
                        "UPDATE tblstudents SET " &
                        "StudentID=@newId, " &
                        "LRN=@lrn, " &
                        "FirstName=@fname, " &
                        "LastName=@lname, " &
                        "MiddleName=@mname, " &
                        "Course=@course, " &
                        "YearLevel=@year, " &
                        "Section=@section, " &
                        "ContactNo=@contact, " &
                        "Status=@status " &
                        "WHERE StudentID=@oldId"

                Else

                    query =
                        "INSERT INTO tblstudents " &
                        "(StudentID, LRN, FirstName, LastName, MiddleName, Course, YearLevel, Section, ContactNo, Status) " &
                        "VALUES " &
                        "(@newId, @lrn, @fname, @lname, @mname, @course, @year, @section, @contact, @status)"

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
                    cmd.Parameters.AddWithValue("@status",
                                               If(cboStatus.SelectedIndex = -1,
                                                  "Active",
                                                  cboStatus.SelectedItem.ToString()))

                    If IsEditMode Then
                        cmd.Parameters.AddWithValue("@oldId", OriginalStudentID)
                    End If

                    cmd.ExecuteNonQuery()

                End Using

                MessageBox.Show(
                    "Student details saved successfully!",
                    "Success",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information)

                Me.DialogResult = DialogResult.OK
                Me.Close()

            End Using

        Catch ex As Exception

            MessageBox.Show(
                "Database Error: " & ex.Message,
                "Error",
                MessageBoxButtons.OK,
                MessageBoxIcon.Error)

        End Try

    End Sub

    Private Sub frmStudentAddEdit_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        If Not IsEditMode Then

            lblTitle.Text = "Add New Student"

            If cboStatus.Items.Count > 0 Then
                cboStatus.SelectedIndex = 0
            End If

        Else

            lblTitle.Text = "Edit Student"

        End If

    End Sub

    Private Sub txtLRN_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtLRN.KeyPress

        If Not Char.IsControl(e.KeyChar) AndAlso
           Not Char.IsDigit(e.KeyChar) Then
            e.Handled = True
        End If

        If Char.IsDigit(e.KeyChar) AndAlso
           txtLRN.Text.Length >= 12 AndAlso
           txtLRN.SelectionLength = 0 Then
            e.Handled = True
        End If

    End Sub

    Private Sub txtContactNo_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtContactNo.KeyPress

        If Not Char.IsControl(e.KeyChar) AndAlso
           Not Char.IsDigit(e.KeyChar) Then
            e.Handled = True
        End If

        If Char.IsDigit(e.KeyChar) AndAlso
           txtContactNo.Text.Length >= 11 AndAlso
           txtContactNo.SelectionLength = 0 Then
            e.Handled = True
        End If

    End Sub

    Private Sub Name_KeyPress(sender As Object, e As KeyPressEventArgs) _
        Handles txtFirstName.KeyPress,
                txtMiddleName.KeyPress,
                txtLastName.KeyPress

        If Not Char.IsControl(e.KeyChar) AndAlso
           Not Char.IsLetter(e.KeyChar) AndAlso
           e.KeyChar <> " "c AndAlso
           e.KeyChar <> "-"c AndAlso
           e.KeyChar <> "'"c Then
            e.Handled = True
        End If

    End Sub

    Private Sub txtStudentID_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtStudentID.KeyPress

        If Not Char.IsControl(e.KeyChar) AndAlso
           Not Char.IsLetterOrDigit(e.KeyChar) AndAlso
           e.KeyChar <> "-"c Then
            e.Handled = True
        End If

    End Sub

    Private Sub txtSection_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtSection.KeyPress

        If Not Char.IsControl(e.KeyChar) AndAlso
           Not Char.IsLetterOrDigit(e.KeyChar) AndAlso
           e.KeyChar <> "-"c Then
            e.Handled = True
        End If

    End Sub

End Class