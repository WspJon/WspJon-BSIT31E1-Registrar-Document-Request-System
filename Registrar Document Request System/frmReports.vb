Imports MySql.Data.MySqlClient
Imports System.Windows.Forms
Imports System.Drawing

Public Class frmReports

    Private dtpFrom As DateTimePicker
    Private dtpTo As DateTimePicker
    Private lblFrom As Label
    Private lblTo As Label

    Private Sub frmReports_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ' Add the Date Pickers programmatically since they were missing from the Designer (Rule 5.7)
        lblFrom = New Label() With {.Text = "FROM DATE", .Location = New Point(300, 80), .AutoSize = True, .Font = lblSelectReport.Font, .ForeColor = lblSelectReport.ForeColor}
        dtpFrom = New DateTimePicker() With {.Format = DateTimePickerFormat.Short, .Location = New Point(300, 100), .Width = 120, .Font = cmbReportType.Font}
        
        lblTo = New Label() With {.Text = "TO DATE", .Location = New Point(450, 80), .AutoSize = True, .Font = lblSelectReport.Font, .ForeColor = lblSelectReport.ForeColor}
        dtpTo = New DateTimePicker() With {.Format = DateTimePickerFormat.Short, .Location = New Point(450, 100), .Width = 120, .Font = cmbReportType.Font}

        ' Resize cmbReportType so it doesn't overlap with our new date pickers
        cmbReportType.Width = 250

        Me.Controls.Add(lblFrom)
        Me.Controls.Add(dtpFrom)
        Me.Controls.Add(lblTo)
        Me.Controls.Add(dtpTo)

        ' Setup ComboBox options
        cmbReportType.Items.Add("Total Collected Fees")
        cmbReportType.Items.Add("List of Documents Released")
        If cmbReportType.Items.Count > 0 Then cmbReportType.SelectedIndex = 0
    End Sub

    Private Sub btnGenerate_Click(sender As Object, e As EventArgs) Handles btnGenerate.Click
        Try
            Using conn = dbHelper.GetConnection()
                conn.Open()
                
                Dim query As String = ""
                Dim isFeeReport As Boolean = (cmbReportType.SelectedItem.ToString() = "Total Collected Fees")

                If isFeeReport Then
                    ' Total collected fees (We look for paid requests within date range)
                    query = "
                        SELECT 
                            r.RequestNo, 
                            DATE_FORMAT(r.RequestDate, '%Y-%m-%d') AS ReqDate,
                            CONCAT(s.FirstName, ' ', s.LastName) AS StudentName, 
                            'N/A' AS Documents,
                            r.TotalAmount,
                            r.Status
                        FROM tblrequest r
                        JOIN tblstudents s ON r.StudentID = s.StudentID
                        WHERE r.PaymentStatus = 'Paid' 
                        AND DATE(r.RequestDate) >= @fromDate 
                        AND DATE(r.RequestDate) <= @toDate
                        ORDER BY r.RequestDate DESC"
                Else
                    ' List of Documents Released
                    query = "
                        SELECT 
                            r.RequestNo, 
                            DATE_FORMAT(r.RequestDate, '%Y-%m-%d') AS ReqDate,
                            CONCAT(s.FirstName, ' ', s.LastName) AS StudentName, 
                            GROUP_CONCAT(d.DocumentName SEPARATOR ', ') AS Documents,
                            r.TotalAmount,
                            r.Status
                        FROM tblrequest r
                        JOIN tblstudents s ON r.StudentID = s.StudentID
                        JOIN tblrequestdetails rd ON r.RequestID = rd.RequestID
                        JOIN tbldocuments d ON rd.DocumentID = d.DocumentID
                        WHERE r.Status = 'Released'
                        AND DATE(r.RequestDate) >= @fromDate 
                        AND DATE(r.RequestDate) <= @toDate
                        GROUP BY r.RequestID
                        ORDER BY r.RequestDate DESC"
                End If

                Using cmd As New MySqlCommand(query, conn)
                    cmd.Parameters.AddWithValue("@fromDate", dtpFrom.Value.ToString("yyyy-MM-dd"))
                    cmd.Parameters.AddWithValue("@toDate", dtpTo.Value.ToString("yyyy-MM-dd"))

                    Dim adapter As New MySqlDataAdapter(cmd)
                    Dim dt As New DataTable()
                    adapter.Fill(dt)

                    dgvReports.AutoGenerateColumns = False
                    colRequestNo.DataPropertyName = "RequestNo"
                    colDate.DataPropertyName = "ReqDate"
                    colStudent.DataPropertyName = "StudentName"
                    colDocument.DataPropertyName = "Documents"
                    colAmount.DataPropertyName = "TotalAmount"
                    colStatus.DataPropertyName = "Status"
                    
                    dgvReports.DataSource = dt

                    ' Feature: If it's a fee report, pop up the grand total sum
                    If isFeeReport AndAlso dt.Rows.Count > 0 Then
                        Dim totalSum As Decimal = 0
                        For Each row As DataRow In dt.Rows
                            If Not IsDBNull(row("TotalAmount")) Then
                                totalSum += Convert.ToDecimal(row("TotalAmount"))
                            End If
                        Next
                        MessageBox.Show($"Total Collected Fees for selected period: ₱{totalSum.ToString("0.00")}", "Total Fees Generated", MessageBoxButtons.OK, MessageBoxIcon.Information)
                    End If
                End Using
            End Using
        Catch ex As Exception
            ' Database error fallback
        End Try
    End Sub

    Private Sub btnExport_Click(sender As Object, e As EventArgs) Handles btnExport.Click
        MessageBox.Show("Export to PDF/Excel functionality is a stretch goal that will be added if time permits.", "Export Coming Soon", MessageBoxButtons.OK, MessageBoxIcon.Information)
    End Sub

End Class
