Imports MySql.Data.MySqlClient

Public Class frmNewRequest
    
    Private documentFees As New Dictionary(Of Integer, Decimal)()

    Private Sub frmNewRequest_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        txtStudentNumber.Text = ""
        txtFullName.Text = ""
        txtCourseYear.Text = ""
        txtContactNumber.Text = ""
        txtAmountDue.Text = "0.00"
        txtCopies.Text = "1"
        cboPaymentStatus.SelectedIndex = 0
        
        LoadDocuments()
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
            
            If cboDocumentType.Items.Count > 0 Then
                cboDocumentType.SelectedIndex = 0
            End If
        Catch ex As Exception
            ' ignore
        End Try
    End Sub

    Private Sub btnSearchStudentNumber_Click(sender As Object, e As EventArgs) Handles btnSearchStudentNumber.Click
        If String.IsNullOrWhiteSpace(txtStudentNumber.Text) Then
            MessageBox.Show("Please enter a Student ID to search.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Return
        End If
        
        Try
            Using conn = dbHelper.GetConnection()
                conn.Open()
                Dim query As String = "SELECT FirstName, LastName, Course, YearLevel, ContactNo FROM tblstudents WHERE StudentID = @id"
                Using cmd As New MySqlCommand(query, conn)
                    cmd.Parameters.AddWithValue("@id", txtStudentNumber.Text.Trim())
                    Using reader = cmd.ExecuteReader()
                        If reader.Read() Then
                            txtFullName.Text = reader("FirstName").ToString() & " " & reader("LastName").ToString()
                            txtCourseYear.Text = reader("Course").ToString() & " - " & reader("YearLevel").ToString()
                            txtContactNumber.Text = reader("ContactNo").ToString()
                        Else
                            MessageBox.Show("Student not found.", "Not Found", MessageBoxButtons.OK, MessageBoxIcon.Information)
                            txtFullName.Text = ""
                            txtCourseYear.Text = ""
                            txtContactNumber.Text = ""
                        End If
                    End Using
                End Using
            End Using
        Catch ex As Exception
            MessageBox.Show("Error searching student.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub CalculateAmount()
        If cboDocumentType.SelectedIndex >= 0 AndAlso documentFees.Count > 0 Then
            Dim selectedDoc = cboDocumentType.SelectedItem
            Dim docID As Integer = selectedDoc.Value
            If documentFees.ContainsKey(docID) Then
                Dim fee As Decimal = documentFees(docID)
                Dim copies As Integer = 1
                Integer.TryParse(txtCopies.Text, copies)
                If copies < 1 Then copies = 1
                
                Dim total As Decimal = fee * copies
                txtAmountDue.Text = total.ToString("F2")
            End If
        End If
    End Sub

    Private Sub cboDocumentType_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cboDocumentType.SelectedIndexChanged
        CalculateAmount()
    End Sub

    Private Sub txtCopies_TextChanged(sender As Object, e As EventArgs) Handles txtCopies.TextChanged
        CalculateAmount()
    End Sub

    Private Sub btnSubmitRequest_Click(sender As Object, e As EventArgs) Handles btnSubmitRequest.Click
        If String.IsNullOrWhiteSpace(txtFullName.Text) Then
            MessageBox.Show("Please search and select a student first.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Return
        End If
        
        Dim copies As Integer = 1
        Integer.TryParse(txtCopies.Text, copies)
        
        Try
            Using conn = dbHelper.GetConnection()
                conn.Open()
                
                ' Generate Request No: REQ-yyyy-xxxxx
                Dim yearStr As String = DateTime.Now.Year.ToString()
                Dim requestNo As String = "REQ-" & yearStr & "-00001"
                
                Dim qLast As String = "SELECT RequestNo FROM tblrequest WHERE RequestNo LIKE @prefix ORDER BY RequestID DESC LIMIT 1"
                Using cmdLast As New MySqlCommand(qLast, conn)
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
                
                ' Insert into tblrequest
                Dim qInsertReq As String = "INSERT INTO tblrequest (RequestNo, StudentID, RequestDate, TotalAmount, PaymentStatus, Status, CreatedBy) VALUES (@reqno, @studentid, @reqdate, @total, @paystatus, 'Pending', @createdby)"
                Dim newRequestID As Integer = 0
                Using cmdInsert As New MySqlCommand(qInsertReq, conn)
                    cmdInsert.Parameters.AddWithValue("@reqno", requestNo)
                    cmdInsert.Parameters.AddWithValue("@studentid", txtStudentNumber.Text.Trim())
                    cmdInsert.Parameters.AddWithValue("@reqdate", DateTime.Now)
                    cmdInsert.Parameters.AddWithValue("@total", Convert.ToDecimal(txtAmountDue.Text))
                    cmdInsert.Parameters.AddWithValue("@paystatus", cboPaymentStatus.SelectedItem.ToString())
                    cmdInsert.Parameters.AddWithValue("@createdby", dbHelper.currentUserID)
                    cmdInsert.ExecuteNonQuery()
                    
                    newRequestID = Convert.ToInt32(cmdInsert.LastInsertedId)
                End Using
                
                ' Insert into tblrequestdetails
                Dim qInsertDet As String = "INSERT INTO tblrequestdetails (RequestID, DocumentID, Quantity, Amount, SubTotal) VALUES (@reqid, @docid, @qty, @amt, @subtotal)"
                Using cmdDet As New MySqlCommand(qInsertDet, conn)
                    Dim docID As Integer = cboDocumentType.SelectedItem.Value
                    Dim fee As Decimal = documentFees(docID)
                    
                    cmdDet.Parameters.AddWithValue("@reqid", newRequestID)
                    cmdDet.Parameters.AddWithValue("@docid", docID)
                    cmdDet.Parameters.AddWithValue("@qty", copies)
                    cmdDet.Parameters.AddWithValue("@amt", fee)
                    cmdDet.Parameters.AddWithValue("@subtotal", fee * copies)
                    cmdDet.ExecuteNonQuery()
                End Using
                
                MessageBox.Show("Document request created successfully!" & vbCrLf & "Request Number: " & requestNo, "Success", MessageBoxButtons.OK, MessageBoxIcon.Information)
                
                ' Reset
                txtStudentNumber.Text = ""
                txtFullName.Text = ""
                txtCourseYear.Text = ""
                txtContactNumber.Text = ""
                txtCopies.Text = "1"
            End Using
        Catch ex As Exception
            MessageBox.Show("Error creating request: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub btnCancel_Click(sender As Object, e As EventArgs) Handles btnCancel.Click
        Me.Close()
    End Sub
    
    Private Sub btnDashboard_Click(sender As Object, e As EventArgs) Handles btnDashboard.Click
        Dim frm As New frmStaffDashboard()
        frm.Show()
        Me.Close()
    End Sub

    Private Sub btnRequestList_Click(sender As Object, e As EventArgs) Handles btnRequestList.Click
        Dim frm As New frmRequestList()
        frm.Show()
        Me.Close()
    End Sub

    Private Sub btnSearchStudent_Click(sender As Object, e As EventArgs) Handles btnSearchStudent.Click
        Dim frm As New frmSearchStudent()
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
