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

    ' --- HELPER TO EMBED FORMS ---
    Private Sub ShowFormInPanel(frm As Form)
        ' Hide all default dashboard elements (cards, table, labels)
        For Each ctrl As Control In pnlContent.Controls
            If Not TypeOf ctrl Is Form Then
                ctrl.Visible = False
            End If
        Next
        
        ' Close any previously opened embedded forms
        For i As Integer = pnlContent.Controls.Count - 1 To 0 Step -1
            Dim ctrl As Control = pnlContent.Controls(i)
            If TypeOf ctrl Is Form Then
                pnlContent.Controls.Remove(ctrl)
                ctrl.Dispose()
            End If
        Next

        ' Prepare and inject the new form
        frm.TopLevel = False
        frm.FormBorderStyle = FormBorderStyle.None
        frm.Dock = DockStyle.Fill
        pnlContent.Controls.Add(frm)
        frm.BringToFront()
        frm.Show()
    End Sub

    ' --- NAVIGATION BUTTONS ---
    Private Sub btnDashboard_Click(sender As Object, e As EventArgs) Handles btnDashboard.Click
        ' Remove embedded forms
        For i As Integer = pnlContent.Controls.Count - 1 To 0 Step -1
            Dim ctrl As Control = pnlContent.Controls(i)
            If TypeOf ctrl Is Form Then
                pnlContent.Controls.Remove(ctrl)
                ctrl.Dispose()
            End If
        Next
        
        ' Restore original dashboard controls
        For Each ctrl As Control In pnlContent.Controls
            ctrl.Visible = True
        Next
        
        LoadDashboardData()
    End Sub

    Private Sub btnDocumentManagement_Click(sender As Object, e As EventArgs) Handles btnDocumentManagement.Click
        ShowFormInPanel(New frmDocumentManagement())
    End Sub

    Private Sub btnStudentManagement_Click(sender As Object, e As EventArgs) Handles btnStudentManagement.Click
        ShowFormInPanel(New frmStudentManagement())
    End Sub

    Private Sub btnDocumentRequests_Click(sender As Object, e As EventArgs) Handles btnDocumentRequests.Click
        ShowFormInPanel(New frmAdminRequestList())
    End Sub

    Private Sub btnUserManagement_Click(sender As Object, e As EventArgs) Handles btnUserManagement.Click
        ShowFormInPanel(New frmUserManagement())
    End Sub

    Private Sub btnReports_Click(sender As Object, e As EventArgs) Handles btnReports.Click
        ShowFormInPanel(New frmReports())
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
