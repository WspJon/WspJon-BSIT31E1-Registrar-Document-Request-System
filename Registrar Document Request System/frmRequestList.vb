Imports MySql.Data.MySqlClient
Imports System.Drawing

Public Class frmRequestList
    Private currentPage As Integer = 1
    Private pageSize As Integer = 10
    Private totalRecords As Integer = 0

    Private Sub frmRequestList_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        cboDateFilter.Items.Add("All Dates")
        cboDateFilter.Items.Add("Today")
        cboDateFilter.Items.Add("This Week")
        cboDateFilter.Items.Add("This Month")
        cboDateFilter.SelectedIndex = 0

        cboStatusFilter.Items.Add("All Status")
        cboStatusFilter.Items.Add("Pending")
        cboStatusFilter.Items.Add("Processing")
        cboStatusFilter.Items.Add("Ready for Release")
        cboStatusFilter.Items.Add("Released")
        cboStatusFilter.Items.Add("Cancelled")
        cboStatusFilter.SelectedIndex = 0

        LoadDocumentsFilter()
        LoadRequests()
    End Sub

    Private Sub LoadDocumentsFilter()
        Try
            Using conn = dbHelper.GetConnection()
                conn.Open()
                Dim query As String = "SELECT DocumentName FROM tbldocuments"
                Using cmd As New MySqlCommand(query, conn)
                    Using reader = cmd.ExecuteReader()
                        cboDocumentFilter.Items.Add("All Documents")
                        While reader.Read()
                            cboDocumentFilter.Items.Add(reader("DocumentName").ToString())
                        End While
                    End Using
                End Using
                cboDocumentFilter.SelectedIndex = 0
            End Using
        Catch ex As Exception
        End Try
    End Sub

    Private Sub LoadRequests()
        Try
            Using conn = dbHelper.GetConnection()
                conn.Open()
                Dim whereClause As String = ""
                
                If txtSearch.Text.Trim() <> "" Then
                    whereClause &= " AND (r.RequestNo LIKE @search OR s.StudentID LIKE @search OR s.FirstName LIKE @search OR s.LastName LIKE @search) "
                End If

                If cboStatusFilter.SelectedIndex > 0 Then
                    whereClause &= " AND r.Status = @status "
                End If

                If cboDateFilter.SelectedIndex = 1 Then
                    whereClause &= " AND DATE(r.RequestDate) = CURDATE() "
                ElseIf cboDateFilter.SelectedIndex = 2 Then
                    whereClause &= " AND YEARWEEK(r.RequestDate, 1) = YEARWEEK(CURDATE(), 1) "
                ElseIf cboDateFilter.SelectedIndex = 3 Then
                    whereClause &= " AND MONTH(r.RequestDate) = MONTH(CURDATE()) AND YEAR(r.RequestDate) = YEAR(CURDATE()) "
                End If
                
                Dim havingClause As String = ""
                If cboDocumentFilter.SelectedIndex > 0 Then
                    havingClause &= " HAVING Documents LIKE @doc "
                End If

                Dim countQuery As String = "SELECT COUNT(*) FROM (SELECT r.RequestID, GROUP_CONCAT(d.DocumentName SEPARATOR ', ') AS Documents FROM tblrequest r JOIN tblstudents s ON r.StudentID = s.StudentID LEFT JOIN tblrequestdetails rd ON r.RequestID = rd.RequestID LEFT JOIN tbldocuments d ON rd.DocumentID = d.DocumentID WHERE 1=1 " & whereClause & " GROUP BY r.RequestID " & havingClause & ") AS tempCount"
                Using cmdCount As New MySqlCommand(countQuery, conn)
                    If txtSearch.Text.Trim() <> "" Then cmdCount.Parameters.AddWithValue("@search", "%" & txtSearch.Text.Trim() & "%")
                    If cboStatusFilter.SelectedIndex > 0 Then cmdCount.Parameters.AddWithValue("@status", cboStatusFilter.SelectedItem.ToString())
                    If cboDocumentFilter.SelectedIndex > 0 Then cmdCount.Parameters.AddWithValue("@doc", "%" & cboDocumentFilter.SelectedItem.ToString() & "%")
                    
                    totalRecords = Convert.ToInt32(cmdCount.ExecuteScalar())
                End Using

                Dim totalPages As Integer = Math.Ceiling(totalRecords / pageSize)
                If currentPage < 1 Then currentPage = 1
                If currentPage > totalPages AndAlso totalPages > 0 Then currentPage = totalPages
                
                Dim offset As Integer = (currentPage - 1) * pageSize
                If offset < 0 Then offset = 0

                Dim query As String = "
                    SELECT 
                        r.RequestID,
                        r.RequestNo, 
                        CONCAT(s.FirstName, ' ', s.LastName) AS StudentName, 
                        GROUP_CONCAT(d.DocumentName SEPARATOR ', ') AS Documents,
                        r.PaymentStatus,
                        r.Status
                    FROM tblrequest r
                    JOIN tblstudents s ON r.StudentID = s.StudentID
                    LEFT JOIN tblrequestdetails rd ON r.RequestID = rd.RequestID
                    LEFT JOIN tbldocuments d ON rd.DocumentID = d.DocumentID
                    WHERE 1=1 " & whereClause & " GROUP BY r.RequestID " & havingClause & " ORDER BY r.RequestDate DESC LIMIT @limit OFFSET @offset"
                
                Using cmd As New MySqlCommand(query, conn)
                    If txtSearch.Text.Trim() <> "" Then cmd.Parameters.AddWithValue("@search", "%" & txtSearch.Text.Trim() & "%")
                    If cboStatusFilter.SelectedIndex > 0 Then cmd.Parameters.AddWithValue("@status", cboStatusFilter.SelectedItem.ToString())
                    If cboDocumentFilter.SelectedIndex > 0 Then cmd.Parameters.AddWithValue("@doc", "%" & cboDocumentFilter.SelectedItem.ToString() & "%")
                    cmd.Parameters.AddWithValue("@limit", pageSize)
                    cmd.Parameters.AddWithValue("@offset", offset)

                    Dim adapter As New MySqlDataAdapter(cmd)
                    Dim dt As New DataTable()
                    adapter.Fill(dt)

                    dgvRequests.AutoGenerateColumns = False
                    colRequestNo.DataPropertyName = "RequestNo"
                    colStudent.DataPropertyName = "StudentName"
                    colDocument.DataPropertyName = "Documents"
                    colPayment.DataPropertyName = "PaymentStatus"
                    colStatus.DataPropertyName = "Status"
                    
                    If Not dgvRequests.Columns.Contains("colRequestID") Then
                        Dim colID As New DataGridViewTextBoxColumn()
                        colID.Name = "colRequestID"
                        colID.DataPropertyName = "RequestID"
                        colID.Visible = False
                        dgvRequests.Columns.Add(colID)
                    End If

                    dgvRequests.DataSource = dt
                End Using
                
                UpdatePaginationUI(totalPages)
            End Using
        Catch ex As Exception
        End Try
    End Sub

    Private Sub UpdatePaginationUI(totalPages As Integer)
        If totalRecords = 0 Then
            lblPagination.Text = "Showing 0 records"
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
            LoadRequests()
        End If
    End Sub

    Private Sub btnNext_Click(sender As Object, e As EventArgs) Handles btnNext.Click
        currentPage += 1
        LoadRequests()
    End Sub

    Private Sub btnPage2_Click(sender As Object, e As EventArgs) Handles btnPage2.Click
        currentPage += 1
        LoadRequests()
    End Sub

    Private Sub cboDateFilter_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cboDateFilter.SelectedIndexChanged
        currentPage = 1
        LoadRequests()
    End Sub

    Private Sub cboDocumentFilter_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cboDocumentFilter.SelectedIndexChanged
        currentPage = 1
        LoadRequests()
    End Sub

    Private Sub cboStatusFilter_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cboStatusFilter.SelectedIndexChanged
        currentPage = 1
        LoadRequests()
    End Sub

    Private Sub txtSearch_TextChanged(sender As Object, e As EventArgs) Handles txtSearch.TextChanged
        currentPage = 1
        LoadRequests()
    End Sub

    Private Sub dgvRequests_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvRequests.CellContentClick
        If e.RowIndex >= 0 AndAlso dgvRequests.Columns(e.ColumnIndex).Name = "colAction" Then
            Dim reqID As Integer = Convert.ToInt32(dgvRequests.Rows(e.RowIndex).Cells("colRequestID").Value)
            Dim reqNo As String = dgvRequests.Rows(e.RowIndex).Cells("colRequestNo").Value.ToString()
            Dim currentPay As String = dgvRequests.Rows(e.RowIndex).Cells("colPayment").Value.ToString()
            Dim currentStatus As String = dgvRequests.Rows(e.RowIndex).Cells("colStatus").Value.ToString()

            ShowUpdateDialog(reqID, reqNo, currentPay, currentStatus)
        End If
    End Sub

    Private Sub ShowUpdateDialog(reqID As Integer, reqNo As String, currentPay As String, currentStatus As String)
        Dim frm As New Form()
        frm.Text = "Update Request: " & reqNo
        frm.Size = New Drawing.Size(350, 320)
        frm.StartPosition = FormStartPosition.CenterParent
        frm.FormBorderStyle = FormBorderStyle.FixedDialog
        frm.MaximizeBox = False
        frm.MinimizeBox = False

        Dim lblPay As New Label() With {.Text = "Payment Status:", .Location = New Drawing.Point(20, 20), .AutoSize = True}
        Dim cboPay As New ComboBox() With {.Location = New Drawing.Point(20, 40), .Width = 290, .DropDownStyle = ComboBoxStyle.DropDownList}
        cboPay.Items.AddRange(New String() {"Unpaid", "Paid"})
        cboPay.SelectedItem = currentPay

        Dim lblOR As New Label() With {.Text = "OR Number (if paid):", .Location = New Drawing.Point(20, 70), .AutoSize = True}
        Dim txtOR As New TextBox() With {.Location = New Drawing.Point(20, 90), .Width = 290}

        Dim lblORDate As New Label() With {.Text = "OR Date (if paid):", .Location = New Drawing.Point(20, 120), .AutoSize = True}
        Dim dtpORDate As New DateTimePicker() With {.Location = New Drawing.Point(20, 140), .Width = 290, .Format = DateTimePickerFormat.Short}

        Dim lblStatus As New Label() With {.Text = "Request Status:", .Location = New Drawing.Point(20, 170), .AutoSize = True}
        Dim cboStatus As New ComboBox() With {.Location = New Drawing.Point(20, 190), .Width = 290, .DropDownStyle = ComboBoxStyle.DropDownList}
        cboStatus.Items.AddRange(New String() {"Pending", "Processing", "Ready for Release", "Released", "Cancelled"})
        cboStatus.SelectedItem = currentStatus

        Dim btnSave As New Button() With {.Text = "Save Updates", .Location = New Drawing.Point(110, 230), .Width = 100}
        Dim btnClose As New Button() With {.Text = "Cancel", .Location = New Drawing.Point(220, 230), .Width = 90}

        frm.Controls.Add(lblPay)
        frm.Controls.Add(cboPay)
        frm.Controls.Add(lblOR)
        frm.Controls.Add(txtOR)
        frm.Controls.Add(lblORDate)
        frm.Controls.Add(dtpORDate)
        frm.Controls.Add(lblStatus)
        frm.Controls.Add(cboStatus)
        frm.Controls.Add(btnSave)
        frm.Controls.Add(btnClose)

        Try
            Using conn = dbHelper.GetConnection()
                conn.Open()
                Using cmd As New MySqlCommand("SELECT ORNo, ORDate FROM tblrequest WHERE RequestID = @id", conn)
                    cmd.Parameters.AddWithValue("@id", reqID)
                    Using reader = cmd.ExecuteReader()
                        If reader.Read() Then
                            If Not DBNull.Value.Equals(reader("ORNo")) Then txtOR.Text = reader("ORNo").ToString()
                            If Not DBNull.Value.Equals(reader("ORDate")) Then dtpORDate.Value = Convert.ToDateTime(reader("ORDate"))
                        End If
                    End Using
                End Using
            End Using
        Catch ex As Exception
        End Try

        AddHandler btnClose.Click, Sub(s, e) frm.Close()
        AddHandler btnSave.Click, Sub(s, e)
            Try
                Using conn = dbHelper.GetConnection()
                    conn.Open()
                    Dim qUpdate As String = "UPDATE tblrequest SET PaymentStatus=@pay, Status=@status"
                    If cboPay.SelectedItem.ToString() = "Paid" Then
                        qUpdate &= ", ORNo=@or, ORDate=@ordate"
                    Else
                        qUpdate &= ", ORNo=NULL, ORDate=NULL"
                    End If
                    qUpdate &= " WHERE RequestID=@id"
                    
                    Using cmd As New MySqlCommand(qUpdate, conn)
                        cmd.Parameters.AddWithValue("@pay", cboPay.SelectedItem.ToString())
                        cmd.Parameters.AddWithValue("@status", cboStatus.SelectedItem.ToString())
                        cmd.Parameters.AddWithValue("@id", reqID)
                        If cboPay.SelectedItem.ToString() = "Paid" Then
                            cmd.Parameters.AddWithValue("@or", txtOR.Text.Trim())
                            cmd.Parameters.AddWithValue("@ordate", dtpORDate.Value.Date)
                        End If
                        cmd.ExecuteNonQuery()
                    End Using
                End Using
                MessageBox.Show("Request updated successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information)
                frm.Close()
                LoadRequests()
            Catch ex As Exception
                MessageBox.Show("Error updating request.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End Try
        End Sub

        frm.ShowDialog()
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
