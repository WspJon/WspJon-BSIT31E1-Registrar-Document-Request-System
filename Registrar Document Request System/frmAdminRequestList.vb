Imports MySql.Data.MySqlClient
Imports System.Windows.Forms
Imports System.Runtime.InteropServices

Public Class frmAdminRequestList

    <DllImport("user32.dll", CharSet:=CharSet.Auto)>
    Private Shared Function SendMessage(ByVal hWnd As IntPtr, ByVal msg As Integer, ByVal wParam As Integer, ByVal lParam As String) As IntPtr
    End Function

    Private Const EM_SETCUEBANNER As Integer = &H1501

    Private Sub frmAdminRequestList_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        If cboStatusFilter.Items.Count > 0 Then
            cboStatusFilter.SelectedIndex = 0
        End If

        SendMessage(txtSearch.Handle, EM_SETCUEBANNER, 0, "Search...")

        LoadRequests()
    End Sub

    Public Sub LoadRequests(Optional searchTerm As String = "", Optional statusFilter As String = "All Statuses")
        Try
            Using conn = dbHelper.GetConnection()
                conn.Open()

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
                    query &= " AND (r.RequestNo LIKE @search 
                                OR r.StudentID LIKE @search 
                                OR s.StudentID LIKE @search 
                                OR s.LastName LIKE @search 
                                OR s.FirstName LIKE @search 
                                OR CONCAT(s.FirstName, ' ', s.LastName) LIKE @search) "
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
        End Try
    End Sub

    Private Function GetSelectedStatus() As String
        If cboStatusFilter.SelectedItem IsNot Nothing Then
            Return cboStatusFilter.SelectedItem.ToString()
        End If
        Return "All Statuses"
    End Function

    Private Sub btnSearch_Click(sender As Object, e As EventArgs) Handles btnSearch.Click
        LoadRequests(txtSearch.Text.Trim(), GetSelectedStatus())
    End Sub

    Private Sub txtSearch_TextChanged(sender As Object, e As EventArgs) Handles txtSearch.TextChanged
        LoadRequests(txtSearch.Text.Trim(), GetSelectedStatus())
    End Sub

    Private Sub cboStatusFilter_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cboStatusFilter.SelectedIndexChanged
        LoadRequests(txtSearch.Text.Trim(), GetSelectedStatus())
    End Sub

End Class