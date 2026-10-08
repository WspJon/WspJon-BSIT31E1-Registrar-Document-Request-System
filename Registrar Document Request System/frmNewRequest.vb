Imports MySql.Data.MySqlClient
Imports System.Drawing

Public Class frmNewRequest

    Private documentFees As New Dictionary(Of Integer, Decimal)()

    Private Sub frmNewRequest_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ' I-load muna ang listahan ng mga dokumento bago i-clear ang form
        LoadDocuments()
        ClearForm()
    End Sub

    ' Helper method para i-reset ang form at i-unlock ang lahat ng fields
    Private Sub ClearForm()
        txtStudentNumber.Text = ""
        txtFullName.Text = ""
        txtCourse.Text = ""
        cboYearLevel.SelectedIndex = -1
        txtContactNumber.Text = ""

        ' Gawing unselected/blanko ang document type at payment status
        cboDocumentType.SelectedIndex = -1
        cboPaymentStatus.SelectedIndex = -1

        ' I-unlock lahat para makapag-search uli
        SetStudentFieldsLock(False)

        ' Gawing blanko ang amount at copies sa simula
        txtAmountDue.Text = ""
        txtCopies.Text = ""
    End Sub

    ' Helper method para i-lock o i-unlock ang Student Number, Full Name, Course, Year Level, at Contact Number
    Private Sub SetStudentFieldsLock(isLocked As Boolean)
        txtStudentNumber.ReadOnly = isLocked
        txtFullName.ReadOnly = isLocked
        txtCourse.ReadOnly = isLocked
        cboYearLevel.Enabled = Not isLocked
        txtContactNumber.ReadOnly = isLocked
    End Sub

    Private Sub LoadDocuments()
        Try
            Using conn = dbHelper.GetConnection()
                conn.Open()
                Dim query As String = "SELECT DocumentID, DocumentName, Fee FROM tbldocuments WHERE Status = 'Active'"
                Using cmd As New MySqlCommand(query, conn)
                    Using reader = cmd.ExecuteReader()
                        cboDocumentType.Items.Clear()
                        documentFees.Clear()
                        While reader.Read()
                            Dim id As Integer = Convert.ToInt32(reader("DocumentID"))
                            Dim name As String = reader("DocumentName").ToString()
                            Dim fee As Decimal = Convert.ToDecimal(reader("Fee"))

                            cboDocumentType.Items.Add(New With {.Text = name, .Value = id})
                            documentFees.Add(id, fee)
                        End While
                    End Using
                End Using
            End Using

            cboDocumentType.DisplayMember = "Text"
            cboDocumentType.ValueMember = "Value"

            ' Naka-unselected para ang user ang mamili
            cboDocumentType.SelectedIndex = -1

        Catch ex As Exception
            MessageBox.Show("Error loading documents: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub btnSearchStudentNumber_Click(sender As Object, e As EventArgs) Handles btnSearchStudentNumber.Click
        ' Kapag naka-lock na ang Student Number at pinindot uli ang search button
        If txtStudentNumber.ReadOnly Then
            Dim changeResult = MessageBox.Show("Do you want to search for another student?", "Change Student", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
            If changeResult = DialogResult.Yes Then
                ClearForm()
                txtStudentNumber.Focus()
            End If
            Return
        End If

        If String.IsNullOrWhiteSpace(txtStudentNumber.Text) Then
            MessageBox.Show("Please enter a Student ID to search.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Return
        End If

        Try
            Using conn = dbHelper.GetConnection()
                conn.Open()

                ' QUERY NA MAY ROLE-BASED COURSE RESTRICTION
                Dim query As String = "SELECT FirstName, LastName, Course, YearLevel, ContactNo FROM tblstudents WHERE StudentID = @id"

                If dbHelper.currentUserRole <> "Administrator" Then
                    query &= " AND Course = (SELECT CourseAssigned FROM tblusers WHERE UserID = @staffUserID)"
                End If

                Using cmd As New MySqlCommand(query, conn)
                    cmd.Parameters.AddWithValue("@id", txtStudentNumber.Text.Trim())
                    If dbHelper.currentUserRole <> "Administrator" Then
                        cmd.Parameters.AddWithValue("@staffUserID", dbHelper.currentUserID)
                    End If

                    Using reader = cmd.ExecuteReader()
                        If reader.Read() Then
                            ' ILALAGAY ANG DATA NA NA-SEARCH
                            txtFullName.Text = reader("FirstName").ToString() & " " & reader("LastName").ToString()
                            txtCourse.Text = reader("Course").ToString()
                            Dim yLevel As String = reader("YearLevel").ToString().Trim()
                            Select Case yLevel
                                Case "1", "1st Year", "1st year", "1st"
                                    cboYearLevel.SelectedItem = "1st Year"
                                Case "2", "2nd Year", "2nd year", "2nd"
                                    cboYearLevel.SelectedItem = "2nd Year"
                                Case "3", "3rd Year", "3rd year", "3rd"
                                    cboYearLevel.SelectedItem = "3rd Year"
                                Case "4", "4th Year", "4th year", "4th"
                                    cboYearLevel.SelectedItem = "4th Year"
                                Case Else
                                    cboYearLevel.Text = yLevel
                            End Select
                            txtContactNumber.Text = reader("ContactNo").ToString()

                            ' I-LOCK ANG MGA STUDENT FIELDS PAGKATAPOS MA-SEARCH
                            SetStudentFieldsLock(True)

                        Else
                            MessageBox.Show("Student not found or not under your assigned department/course.", "Not Found / Unauthorized", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                            txtFullName.Text = ""
                            txtCourse.Text = ""
                            cboYearLevel.SelectedIndex = -1
                            txtContactNumber.Text = ""
                            SetStudentFieldsLock(False)
                        End If
                    End Using
                End Using
            End Using
        Catch ex As Exception
            MessageBox.Show("Error searching student: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    ' AUTOMATIC COMPUTATION SA AMOUNT DUE
    Private Sub CalculateAmount()
        If cboDocumentType.SelectedIndex >= 0 AndAlso documentFees.Count > 0 Then
            Dim selectedDoc = cboDocumentType.SelectedItem
            Dim docID As Integer = selectedDoc.Value
            If documentFees.ContainsKey(docID) Then
                Dim fee As Decimal = documentFees(docID)
                Dim copies As Integer = 0

                ' Nagku-compute lamang kapag may valid na bilang ng copies na inilagay ang user
                If Integer.TryParse(txtCopies.Text.Trim(), copies) AndAlso copies > 0 Then
                    Dim total As Decimal = fee * copies
                    txtAmountDue.Text = total.ToString("F2")
                Else
                    txtAmountDue.Text = "0.00"
                End If
            End If
        Else
            ' Kapag walang napiling document, nananatiling blanko ang Amount
            txtAmountDue.Text = ""
        End If
    End Sub

    Private Sub cboDocumentType_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cboDocumentType.SelectedIndexChanged
        CalculateAmount()
    End Sub

    Private Sub txtCopies_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtCopies.KeyPress
        If Not Char.IsDigit(e.KeyChar) AndAlso Not Char.IsControl(e.KeyChar) Then
            e.Handled = True
        End If
    End Sub

    Private Sub txtCopies_TextChanged(sender As Object, e As EventArgs) Handles txtCopies.TextChanged
        CalculateAmount()
    End Sub

    Private Sub btnSubmitRequest_Click(sender As Object, e As EventArgs) Handles btnSubmitRequest.Click
        ' VALIDATIONS
        If String.IsNullOrWhiteSpace(txtFullName.Text) Then
            MessageBox.Show("Please search and select a student first.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Return
        End If

        If cboDocumentType.SelectedIndex = -1 Then
            MessageBox.Show("Please select a document type.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            cboDocumentType.Focus()
            Return
        End If

        If cboPaymentStatus.SelectedIndex = -1 Then
            MessageBox.Show("Please select a payment status.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            cboPaymentStatus.Focus()
            Return
        End If

        ' Sisiguraduhing may inilagay na copies ang user
        Dim copies As Integer = 0
        If String.IsNullOrWhiteSpace(txtCopies.Text) OrElse Not Integer.TryParse(txtCopies.Text.Trim(), copies) OrElse copies <= 0 Then
            MessageBox.Show("Please enter a valid number of copies (must be at least 1).", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            txtCopies.Focus()
            txtCopies.SelectAll()
            Return
        End If

        If copies > 50 Then
            MessageBox.Show("You cannot request more than 50 copies at once.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            txtCopies.Focus()
            txtCopies.SelectAll()
            Return
        End If

        ' CONFIRMATION MESSAGE BOX (YES / NO)
        Dim confirmResult As DialogResult = MessageBox.Show("Are you sure you want to submit request?", "Confirm Submission", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
        If confirmResult <> DialogResult.Yes Then
            Return
        End If

        Using conn = dbHelper.GetConnection()
            conn.Open()

            ' 1. SIMULAN ANG DATABASE TRANSACTION
            Dim trans As MySqlTransaction = conn.BeginTransaction()

            Try
                Dim yearStr As String = DateTime.Now.Year.ToString()
                Dim requestNo As String = "REQ-" & yearStr & "-00001"

                ' KUNIN ANG HULING REQUEST NO SA LOOB NG TRANSACTION
                Dim qLast As String = "SELECT RequestNo FROM tblrequest WHERE RequestNo LIKE @prefix ORDER BY RequestID DESC LIMIT 1"
                Using cmdLast As New MySqlCommand(qLast, conn, trans)
                    cmdLast.Parameters.AddWithValue("@prefix", "REQ-" & yearStr & "-%")
                    Dim lastReq = cmdLast.ExecuteScalar()
                    If lastReq IsNot Nothing AndAlso Not DBNull.Value.Equals(lastReq) Then
                        Dim lastNo As String = lastReq.ToString()
                        Dim parts = lastNo.Split("-"c)
                        If parts.Length = 3 Then
                            Dim numPart As Integer
                            If Integer.TryParse(parts(2), numPart) Then
                                requestNo = "REQ-" & yearStr & "-" & (numPart + 1).ToString("D5")
                            End If
                        End If
                    End If
                End Using

                ' 2. INSERT SA tblrequest
                Dim qInsertReq As String = "INSERT INTO tblrequest (RequestNo, StudentID, RequestDate, TotalAmount, PaymentStatus, Status, CreatedBy) VALUES (@reqno, @studentid, @reqdate, @total, @paystatus, 'Pending', @createdby)"
                Dim newRequestID As Integer = 0
                Using cmdInsert As New MySqlCommand(qInsertReq, conn, trans)
                    cmdInsert.Parameters.AddWithValue("@reqno", requestNo)
                    cmdInsert.Parameters.AddWithValue("@studentid", txtStudentNumber.Text.Trim())
                    cmdInsert.Parameters.AddWithValue("@reqdate", DateTime.Now)
                    cmdInsert.Parameters.AddWithValue("@total", Convert.ToDecimal(txtAmountDue.Text))
                    cmdInsert.Parameters.AddWithValue("@paystatus", cboPaymentStatus.SelectedItem.ToString())
                    cmdInsert.Parameters.AddWithValue("@createdby", dbHelper.currentUserID)
                    cmdInsert.ExecuteNonQuery()

                    newRequestID = Convert.ToInt32(cmdInsert.LastInsertedId)
                End Using

                ' 3. INSERT SA tblrequestdetails
                Dim qInsertDet As String = "INSERT INTO tblrequestdetails (RequestID, DocumentID, Quantity, Amount, SubTotal) VALUES (@reqid, @docid, @qty, @amt, @subtotal)"
                Using cmdDet As New MySqlCommand(qInsertDet, conn, trans)
                    Dim docID As Integer = cboDocumentType.SelectedItem.Value
                    Dim fee As Decimal = documentFees(docID)

                    cmdDet.Parameters.AddWithValue("@reqid", newRequestID)
                    cmdDet.Parameters.AddWithValue("@docid", docID)
                    cmdDet.Parameters.AddWithValue("@qty", copies)
                    cmdDet.Parameters.AddWithValue("@amt", fee)
                    cmdDet.Parameters.AddWithValue("@subtotal", fee * copies)
                    cmdDet.ExecuteNonQuery()
                End Using

                ' 4. COMMIT TRANSACTION
                trans.Commit()

                MessageBox.Show("Document request created successfully!" & vbCrLf & "Request Number: " & requestNo, "Success", MessageBoxButtons.OK, MessageBoxIcon.Information)

                ' Reset ang buong form
                ClearForm()

                ' Pabalikin sa Dashboard view pagkatapos mag-submit
                GoToDashboard()

            Catch ex As Exception
                ' 5. ROLLBACK KAPAG MAY ERROR
                trans.Rollback()
                MessageBox.Show("Transaction failed. Request was not created to prevent orphaned data. Error: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End Try
        End Using
    End Sub

    ' HELPER METHOD: Pinakamaayos na paraan para bumalik sa Dashboard View ng Parent Form
    Private Sub GoToDashboard()
        Dim parentDashboard = TryCast(Me.ParentForm, frmStaffDashboard)
        If parentDashboard IsNot Nothing Then
            ' Executive trigger sa btnDashboard event ng Staff Dashboard
            parentDashboard.btnDashboard.PerformClick()
        Else
            Me.Close()
        End If
    End Sub

    ' CANCEL BUTTON
    Private Sub btnCancel_Click(sender As Object, e As EventArgs) Handles btnCancel.Click
        Dim result As DialogResult = MessageBox.Show("Are you sure you want to cancel?", "Confirm Cancel", MessageBoxButtons.YesNo, MessageBoxIcon.Question)

        If result = DialogResult.Yes Then
            ClearForm()
            GoToDashboard()
        End If
    End Sub

    ' DASHBOARD MENU BUTTON
    Private Sub btnDashboard_Click(sender As Object, e As EventArgs) Handles btnDashboard.Click
        ClearForm()
        GoToDashboard()
    End Sub

    ' MENU NAVIGATION (Tawagin ang buttons sa Parent Dashboard para pareho ang System behavior)
    Private Sub btnRequestList_Click(sender As Object, e As EventArgs) Handles btnRequestList.Click
        Dim parentDashboard = TryCast(Me.ParentForm, frmStaffDashboard)
        If parentDashboard IsNot Nothing Then
            parentDashboard.btnRequestList.PerformClick()
        End If
    End Sub

    Private Sub btnSearchStudent_Click(sender As Object, e As EventArgs) Handles btnSearchStudent.Click
        Dim parentDashboard = TryCast(Me.ParentForm, frmStaffDashboard)
        If parentDashboard IsNot Nothing Then
            parentDashboard.btnSearchStudent.PerformClick()
        End If
    End Sub

    Private Sub btnReports_Click(sender As Object, e As EventArgs) Handles btnReports.Click
        Dim parentDashboard = TryCast(Me.ParentForm, frmStaffDashboard)
        If parentDashboard IsNot Nothing Then
            parentDashboard.btnReports.PerformClick()
        End If
    End Sub

    Private Sub btnLogout_Click(sender As Object, e As EventArgs) Handles btnLogout.Click
        Dim parentDashboard = TryCast(Me.ParentForm, frmStaffDashboard)
        If parentDashboard IsNot Nothing Then
            parentDashboard.btnLogout.PerformClick()
        Else
            Me.Close()
        End If
    End Sub

    Private Sub pnlContent_Paint(sender As Object, e As PaintEventArgs) Handles pnlContent.Paint

    End Sub

End Class