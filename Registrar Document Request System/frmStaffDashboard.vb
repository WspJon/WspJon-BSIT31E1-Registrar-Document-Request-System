Imports MySql.Data.MySqlClient

Public Class frmStaffDashboard

    Private Sub frmStaffDashboard_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        lblWelcome.Text = "Welcome, " & dbHelper.currentUserName & "!"
        LoadDashboardStats()
        LoadRecentRequests()
    End Sub

    Private Sub LoadDashboardStats()
        Try
            Using conn = dbHelper.GetConnection()
                conn.Open()
                
                Dim q1 As String = "SELECT COUNT(*) FROM tblrequest WHERE Status = 'Pending'"
                Using cmd1 As New MySqlCommand(q1, conn)
                    lblCard1Value.Text = cmd1.ExecuteScalar().ToString()
                End Using

                Dim q2 As String = "SELECT COUNT(*) FROM tblrequest WHERE Status = 'Ready for Release'"
                Using cmd2 As New MySqlCommand(q2, conn)
                    lblCard2Value.Text = cmd2.ExecuteScalar().ToString()
                End Using

                Dim q3 As String = "SELECT COUNT(*) FROM tblrequest WHERE Status = 'Released' AND DATE(RequestDate) = CURDATE()"
                Using cmd3 As New MySqlCommand(q3, conn)
                    lblCard3Value.Text = cmd3.ExecuteScalar().ToString()
                End Using
            End Using
        Catch ex As Exception
            
        End Try
    End Sub

    Private Sub LoadRecentRequests()
        Try
            Using conn = dbHelper.GetConnection()
                conn.Open()
                Dim query As String = "
                    SELECT 
                        r.RequestNo, 
                        CONCAT(s.FirstName, ' ', s.LastName) AS StudentName, 
                        GROUP_CONCAT(d.DocumentName SEPARATOR ', ') AS Documents,
                        r.Status
                    FROM tblrequest r
                    JOIN tblstudents s ON r.StudentID = s.StudentID
                    LEFT JOIN tblrequestdetails rd ON r.RequestID = rd.RequestID
                    LEFT JOIN tbldocuments d ON rd.DocumentID = d.DocumentID
                    GROUP BY r.RequestID
                    ORDER BY r.RequestDate DESC LIMIT 10"
                
                Using cmd As New MySqlCommand(query, conn)
                    Dim adapter As New MySqlDataAdapter(cmd)
                    Dim dt As New DataTable()
                    adapter.Fill(dt)
                    
                    dgvRecent.AutoGenerateColumns = False
                    colRequestNo.DataPropertyName = "RequestNo"
                    colStudent.DataPropertyName = "StudentName"
                    colDocument.DataPropertyName = "Documents"
                    colStatus.DataPropertyName = "Status"
                    dgvRecent.DataSource = dt
                End Using
            End Using
        Catch ex As Exception
            
        End Try
    End Sub

    Private Sub ShowFormInPanel(frm As Form)
        For Each ctrl As Control In pnlContent.Controls
            If Not TypeOf ctrl Is Form Then
                ctrl.Visible = False
            End If
        Next
        
        For i As Integer = pnlContent.Controls.Count - 1 To 0 Step -1
            Dim ctrl As Control = pnlContent.Controls(i)
            If TypeOf ctrl Is Form Then
                pnlContent.Controls.Remove(ctrl)
                ctrl.Dispose()
            End If
        Next

        frm.TopLevel = False
        frm.FormBorderStyle = FormBorderStyle.None
        
        Dim childSidebar As Control = frm.Controls("pnlSidebar")
        If childSidebar IsNot Nothing Then
            childSidebar.Visible = False
        End If

        frm.Dock = DockStyle.Fill
        pnlContent.Controls.Add(frm)
        frm.BringToFront()
        frm.Show()
    End Sub

    Private Sub btnNewRequest_Click(sender As Object, e As EventArgs) Handles btnNewRequest.Click, btnCreateRequest.Click
        ShowFormInPanel(New frmNewRequest())
    End Sub

    Private Sub btnRequestList_Click(sender As Object, e As EventArgs) Handles btnRequestList.Click
        ShowFormInPanel(New frmRequestList())
    End Sub

    Private Sub btnSearchStudent_Click(sender As Object, e As EventArgs) Handles btnSearchStudent.Click
        ShowFormInPanel(New frmSearchStudent())
    End Sub

    Private Sub btnReports_Click(sender As Object, e As EventArgs) Handles btnReports.Click
        ShowFormInPanel(New frmReports())
    End Sub

    Private Sub btnDashboard_Click(sender As Object, e As EventArgs) Handles btnDashboard.Click
        For i As Integer = pnlContent.Controls.Count - 1 To 0 Step -1
            Dim ctrl As Control = pnlContent.Controls(i)
            If TypeOf ctrl Is Form Then
                pnlContent.Controls.Remove(ctrl)
                ctrl.Dispose()
            End If
        Next
        
        For Each ctrl As Control In pnlContent.Controls
            ctrl.Visible = True
        Next
        
        LoadDashboardStats()
        LoadRecentRequests()
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
