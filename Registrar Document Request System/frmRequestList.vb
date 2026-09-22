Imports MySql.Data.MySqlClient

Public Class frmRequestList
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
                    WHERE 1=1 "
                
                If txtSearch.Text.Trim() <> "" Then
                    query &= " AND (r.RequestNo LIKE @search OR s.StudentID LIKE @search OR s.FirstName LIKE @search OR s.LastName LIKE @search) "
                End If

                If cboStatusFilter.SelectedIndex > 0 Then
                    query &= " AND r.Status = @status "
                End If

                If cboDateFilter.SelectedIndex = 1 Then
                    query &= " AND DATE(r.RequestDate) = CURDATE() "
                ElseIf cboDateFilter.SelectedIndex = 2 Then
                    query &= " AND YEARWEEK(r.RequestDate, 1) = YEARWEEK(CURDATE(), 1) "
                ElseIf cboDateFilter.SelectedIndex = 3 Then
                    query &= " AND MONTH(r.RequestDate) = MONTH(CURDATE()) AND YEAR(r.RequestDate) = YEAR(CURDATE()) "
                End If
                
                query &= " GROUP BY r.RequestID "

                If cboDocumentFilter.SelectedIndex > 0 Then
                    query &= " HAVING Documents LIKE @doc "
                End If

                query &= " ORDER BY r.RequestDate DESC"

                Using cmd As New MySqlCommand(query, conn)
                    If txtSearch.Text.Trim() <> "" Then
                        cmd.Parameters.AddWithValue("@search", "%" & txtSearch.Text.Trim() & "%")
                    End If
                    If cboStatusFilter.SelectedIndex > 0 Then
                        cmd.Parameters.AddWithValue("@status", cboStatusFilter.SelectedItem.ToString())
                    End If
                    If cboDocumentFilter.SelectedIndex > 0 Then
                        cmd.Parameters.AddWithValue("@doc", "%" & cboDocumentFilter.SelectedItem.ToString() & "%")
                    End If

                    Dim adapter As New MySqlDataAdapter(cmd)
                    Dim dt As New DataTable()
                    adapter.Fill(dt)

                    dgvRequests.AutoGenerateColumns = False
                    colRequestNo.DataPropertyName = "RequestNo"
                    colStudent.DataPropertyName = "StudentName"
                    colDocument.DataPropertyName = "Documents"
                    colPayment.DataPropertyName = "PaymentStatus"
                    colStatus.DataPropertyName = "Status"
                    
                    ' Add invisible RequestID column if not exists
                    If Not dgvRequests.Columns.Contains("colRequestID") Then
                        Dim colID As New DataGridViewTextBoxColumn()
                        colID.Name = "colRequestID"
                        colID.DataPropertyName = "RequestID"
                        colID.Visible = False
                        dgvRequests.Columns.Add(colID)
                    End If

                    dgvRequests.DataSource = dt
                End Using
            End Using
        Catch ex As Exception
        End Try
    End Sub

    Private Sub cboDateFilter_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cboDateFilter.SelectedIndexChanged
        LoadRequests()
    End Sub

    Private Sub cboDocumentFilter_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cboDocumentFilter.SelectedIndexChanged
        LoadRequests()
    End Sub

    Private Sub cboStatusFilter_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cboStatusFilter.SelectedIndexChanged
        LoadRequests()
    End Sub

    Private Sub txtSearch_TextChanged(sender As Object, e As EventArgs) Handles txtSearch.TextChanged
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

        ' Pre-fill OR details if already paid
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

    Private Sub btnRequestList_Click(sender As Object, e As EventArgs) Handles btnRequestList.Click

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
