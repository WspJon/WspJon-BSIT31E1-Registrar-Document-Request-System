Imports MySql.Data.MySqlClient

Public Class frmAdminDashboard
    
    ' This runs every time the dashboard is opened or brought to the front
    Private Sub frmAdminDashboard_Activated(sender As Object, e As EventArgs) Handles Me.Activated
        ' Show the current user's name
        lblWelcome.Text = "Welcome, " & dbHelper.currentUserName

        LoadDashboardData()
    End Sub

    Private Sub LoadDashboardData()
        Try
            Using conn = dbHelper.GetConnection()
                conn.Open()

                ' 1. Total Requests
                Dim cmdTotal As New MySqlCommand("SELECT COUNT(*) FROM tblrequest", conn)
                lblCard1Value.Text = Convert.ToInt32(cmdTotal.ExecuteScalar()).ToString()

                ' 2. Pending Requests
                Dim cmdPending As New MySqlCommand("SELECT COUNT(*) FROM tblrequest WHERE Status = 'Pending'", conn)
                lblCard2Value.Text = Convert.ToInt32(cmdPending.ExecuteScalar()).ToString()

                ' 3. Ready for Release
                Dim cmdReady As New MySqlCommand("SELECT COUNT(*) FROM tblrequest WHERE Status = 'Ready for Release'", conn)
                lblCard3Value.Text = Convert.ToInt32(cmdReady.ExecuteScalar()).ToString()

                ' 4. Released Requests
                Dim cmdReleased As New MySqlCommand("SELECT COUNT(*) FROM tblrequest WHERE Status = 'Released'", conn)
                lblCard4Value.Text = Convert.ToInt32(cmdReleased.ExecuteScalar()).ToString()

                ' 5. Load Recent Requests into DataGridView
                Dim queryRecent As String = "
                    SELECT r.RequestNo, CONCAT(s.FirstName, ' ', s.LastName) AS Student, d.DocumentName, r.Status 
                    FROM tblrequest r 
                    JOIN tblstudents s ON r.StudentID = s.StudentID 
                    JOIN tblrequestdetails rd ON r.RequestID = rd.RequestID 
                    JOIN tbldocuments d ON rd.DocumentID = d.DocumentID 
                    ORDER BY r.RequestDate DESC LIMIT 10"
                
                Using adapter As New MySqlDataAdapter(queryRecent, conn)
                    Dim dt As New DataTable()
                    adapter.Fill(dt)
                    dgvRecentRequests.AutoGenerateColumns = False
                    colRequestNo.DataPropertyName = "RequestNo"
                    colStudent.DataPropertyName = "Student"
                    colDocument.DataPropertyName = "DocumentName"
                    colStatus.DataPropertyName = "Status"
                    dgvRecentRequests.DataSource = dt
                End Using
            End Using
        Catch ex As Exception
            ' If database isn't ready yet, just show 0 to avoid crashing
            lblCard1Value.Text = "0"
            lblCard2Value.Text = "0"
            lblCard3Value.Text = "0"
            lblCard4Value.Text = "0"
        End Try
    End Sub

    ' --- NAVIGATION BUTTONS ---
    Private Sub btnDocumentManagement_Click(sender As Object, e As EventArgs) Handles btnDocumentManagement.Click
        Dim frmDoc As New frmDocumentManagement()
        frmDoc.ShowDialog()
    End Sub

    Private Sub btnStudentManagement_Click(sender As Object, e As EventArgs) Handles btnStudentManagement.Click
        Dim frmStudent As New frmStudentManagement()
        frmStudent.ShowDialog()
    End Sub

    Private Sub btnDocumentRequests_Click(sender As Object, e As EventArgs) Handles btnDocumentRequests.Click
        Dim frmReq As New frmAdminRequestList()
        frmReq.ShowDialog()
    End Sub

    Private Sub btnUserManagement_Click(sender As Object, e As EventArgs) Handles btnUserManagement.Click
        Dim frmUser As New frmUserManagement()
        frmUser.ShowDialog()
    End Sub

    Private Sub btnReports_Click(sender As Object, e As EventArgs) Handles btnReports.Click
        Dim frmRep As New frmReports()
        frmRep.ShowDialog()
    End Sub

    Private Sub btnLogout_Click(sender As Object, e As EventArgs) Handles btnLogout.Click
        ' Clear global user details
        dbHelper.currentUserID = 0
        dbHelper.currentUserName = ""
        dbHelper.currentUserRole = ""
        
        Me.Close()
        frmLogin.Show()
    End Sub
End Class
