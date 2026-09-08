Public Class frmLogin

    ' Stores the currently selected role
    Private selectedRole As String = "Administrator"

    ' ──────────────────────────────────────────────
    ' ROLE TOGGLE — switches active tab styling
    ' ──────────────────────────────────────────────
    Private Sub btnAdmin_Click(sender As Object, e As EventArgs) Handles btnAdmin.Click
        selectedRole = "Administrator"
        ' Active: white bg, navy text
        btnAdmin.BackColor = System.Drawing.Color.White
        btnAdmin.ForeColor = System.Drawing.Color.FromArgb(15, 31, 76)
        ' Inactive: navy bg, white text
        btnStaff.BackColor = System.Drawing.Color.FromArgb(15, 31, 76)
        btnStaff.ForeColor = System.Drawing.Color.White
    End Sub

    Private Sub btnStaff_Click(sender As Object, e As EventArgs) Handles btnStaff.Click
        selectedRole = "Registrar Staff"
        ' Active: white bg, navy text
        btnStaff.BackColor = System.Drawing.Color.White
        btnStaff.ForeColor = System.Drawing.Color.FromArgb(15, 31, 76)
        ' Inactive: navy bg, white text
        btnAdmin.BackColor = System.Drawing.Color.FromArgb(15, 31, 76)
        btnAdmin.ForeColor = System.Drawing.Color.White
    End Sub

    ' ──────────────────────────────────────────────
    ' LOGIN BUTTON — placeholder for auth logic
    ' (the person doing functions will fill this in)
    ' ──────────────────────────────────────────────
    Private Sub btnLogin_Click(sender As Object, e As EventArgs) Handles btnLogin.Click
        Dim username As String = txtUsername.Text.Trim()
        Dim password As String = txtPassword.Text.Trim()

        If username = "" OrElse password = "" Then
            MessageBox.Show("Please enter both username and password.", "Required Fields", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Return
        End If

        ' --- TEMPORARY BYPASS FOR TESTING WITHOUT DATABASE ---
        If username = "test" And password = "123" Then
            dbHelper.currentUserName = "Test User"
            dbHelper.currentUserRole = selectedRole ' Use whatever role tab they clicked
            MessageBox.Show("Using Temporary Testing Bypass!", "Test Mode", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Me.Hide()
            
            If selectedRole = "Administrator" Then
                Dim adminDash As New frmAdminDashboard()
                adminDash.Show()
            Else
                Dim staffDash As New frmStaffDashboard()
                staffDash.Show()
            End If
            Return
        End If
        ' -----------------------------------------------------

        Try
            Using conn = dbHelper.GetConnection()
                conn.Open()
                ' Parameterized query to prevent SQL injection and check role
                Dim query As String = "SELECT UserID, FullName, Role, Status FROM tblusers WHERE Username = @username AND Password = @password AND Role = @role"
                
                Using cmd As New MySql.Data.MySqlClient.MySqlCommand(query, conn)
                    cmd.Parameters.AddWithValue("@username", username)
                    
                    ' Hash the password entered by the user before comparing it with the database (Rule 5.6)
                    Dim hashedPassword As String = HashPassword(password)
                    cmd.Parameters.AddWithValue("@password", hashedPassword)
                    
                    cmd.Parameters.AddWithValue("@role", selectedRole)

                    Using reader = cmd.ExecuteReader()
                        If reader.Read() Then
                            ' User found! Check if active
                            Dim status As String = reader("Status").ToString()
                            
                            If status = "Inactive" Then
                                MessageBox.Show("This account has been deactivated. Please contact an administrator.", "Account Inactive", MessageBoxButtons.OK, MessageBoxIcon.Error)
                                Return
                            End If

                            ' Store user details globally in our dbHelper
                            dbHelper.currentUserID = Convert.ToInt32(reader("UserID"))
                            dbHelper.currentUserName = reader("FullName").ToString()
                            dbHelper.currentUserRole = reader("Role").ToString()

                            MessageBox.Show($"Welcome, {dbHelper.currentUserName}!", "Login Success", MessageBoxButtons.OK, MessageBoxIcon.Information)

                            ' Route to the correct dashboard based on role
                            Me.Hide()
                            If dbHelper.currentUserRole = "Administrator" Then
                                Dim adminDash As New frmAdminDashboard()
                                adminDash.Show()
                            Else
                                Dim staffDash As New frmStaffDashboard()
                                staffDash.Show()
                            End If
                        Else
                            ' Incorrect details
                            MessageBox.Show("Invalid username, password, or role selection.", "Login Failed", MessageBoxButtons.OK, MessageBoxIcon.Error)
                        End If
                    End Using
                End Using
            End Using
        Catch ex As Exception
            MessageBox.Show("Database connection error: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub pnlLeft_Paint(sender As Object, e As PaintEventArgs) Handles pnlLeft.Paint

    End Sub

    ' SHA256 Hashing Implementation (Rule 5.6)
    Private Function HashPassword(password As String) As String
        Using sha256 As System.Security.Cryptography.SHA256 = System.Security.Cryptography.SHA256.Create()
            Dim bytes As Byte() = System.Text.Encoding.UTF8.GetBytes(password)
            Dim hashBytes As Byte() = sha256.ComputeHash(bytes)
            Dim builder As New System.Text.StringBuilder()
            For i As Integer = 0 To hashBytes.Length - 1
                builder.Append(hashBytes(i).ToString("x2"))
            Next
            Return builder.ToString()
        End Using
    End Function

End Class
