Imports MySql.Data.MySqlClient
Imports System.Windows.Forms

Public Class frmAdminRequestList

    Private Sub frmAdminRequestList_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ' Set default filter
        If cboStatusFilter.Items.Count > 0 Then
            cboStatusFilter.SelectedIndex = 0
        End If
        LoadRequests()
    End Sub

    Public Sub LoadRequests(Optional searchTerm As String = "", Optional statusFilter As String = "All Statuses")
        Try
            Using conn = dbHelper.GetConnection()
                conn.Open()
                
                ' Instruction 5.5: Read-only list of all requests (join tblrequest with tblstudents and tbldocuments)
                ' We use GROUP_CONCAT to list all documents requested in a single row
                Dim query As String = "
                    SELECT 
                        r.RequestNo, 
                        CONCAT(s.FirstName, ' ', s.LastName) AS StudentName, 
                        GROUP_CONCAT(d.DocumentName SEPARATOR ', ') AS Documents,
                        DATE_FORMAT(r.RequestDate, '%Y-%m-%d') AS ReqDate,
                        r.TotalAmount,
                        r.PaymentStatus,
                        r.Status
                    FROM tblrequest r
                    JOIN tblstudents s ON r.StudentID = s.StudentID
                    LEFT JOIN tblrequestdetails rd ON r.RequestID = rd.RequestID
                    LEFT JOIN tbldocuments d ON rd.DocumentID = d.DocumentID
                    WHERE 1=1 "
                
                If Not String.IsNullOrWhiteSpace(searchTerm) Then
                    query &= " AND (r.RequestNo LIKE @search OR s.LastName LIKE @search OR s.FirstName LIKE @search) "
                End If

                If statusFilter <> "All Statuses" AndAlso Not String.IsNullOrEmpty(statusFilter) Then
                    query &= " AND r.Status = @status "
                End If

                query &= " GROUP BY r.RequestID ORDER BY r.RequestDate DESC"

                Using cmd As New MySqlCommand(query, conn)
                    If Not String.IsNullOrWhiteSpace(searchTerm) Then
                        cmd.Parameters.AddWithValue("@search", "%" & searchTerm & "%")
                    End If
                    If statusFilter <> "All Statuses" AndAlso Not String.IsNullOrEmpty(statusFilter) Then
                        cmd.Parameters.AddWithValue("@status", statusFilter)
                    End If

                    Dim adapter As New MySqlDataAdapter(cmd)
                    Dim dt As New DataTable()
                    adapter.Fill(dt)

                    dgvRequests.AutoGenerateColumns = False
                    colRequestNo.DataPropertyName = "RequestNo"
                    colStudent.DataPropertyName = "StudentName"
                    colDocuments.DataPropertyName = "Documents"
                    colDate.DataPropertyName = "ReqDate"
                    colAmount.DataPropertyName = "TotalAmount"
                    colPayment.DataPropertyName = "PaymentStatus"
                    colStatus.DataPropertyName = "Status"
                    
                    dgvRequests.DataSource = dt
                End Using
            End Using
        Catch ex As Exception
            ' Ignore error if database isn't ready
        End Try
    End Sub

    Private Sub btnSearch_Click(sender As Object, e As EventArgs) Handles btnSearch.Click
        LoadRequests(txtSearch.Text.Trim(), cboStatusFilter.SelectedItem.ToString())
    End Sub

End Class
