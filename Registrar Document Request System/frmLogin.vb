Imports MySql.Data.MySqlClient

Public Class frmLogin

    ' Stores the currently selected role
    Private selectedRole As String = "Administrator"

    ' ──────────────────────────────────────────────
    ' FORM LOAD — Sets default button colors on startup
    ' ──────────────────────────────────────────────
    Private Sub frmLogin_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ' Unang bukas ng form: Administrator ang Active (Navy Blue bg, White text)
        SetActiveRoleUI("Administrator")
    End Sub

    ' ──────────────────────────────────────────────
    ' HELPER METHOD — Controls active/inactive tab appearance
    ' ──────────────────────────────────────────────
    Private Sub SetActiveRoleUI(role As String)
        Dim navyColor As System.Drawing.Color = System.Drawing.Color.FromArgb(15, 31, 76)
        Dim whiteColor As System.Drawing.Color = System.Drawing.Color.White

        If role = "Administrator" Then
            selectedRole = "Administrator"
            ' Administrator = ACTIVE (Navy Blue bg, White text)
            btnAdmin.BackColor = navyColor
            btnAdmin.ForeColor = whiteColor

            ' Registrar Staff = INACTIVE (White bg, Navy Blue text)
            btnStaff.BackColor = whiteColor
            btnStaff.ForeColor = navyColor
        Else
            selectedRole = "Registrar Staff"
            ' Registrar Staff = ACTIVE (Navy Blue bg, White text)
            btnStaff.BackColor = navyColor
            btnStaff.ForeColor = whiteColor

            ' Administrator = INACTIVE (White bg, Navy Blue text)
            btnAdmin.BackColor = whiteColor
            btnAdmin.ForeColor = navyColor
        End If
    End Sub

    ' ──────────────────────────────────────────────
    ' ROLE TOGGLE — Switches active tab styling
    ' ──────────────────────────────────────────────
    Private Sub btnAdmin_Click(sender As Object, e As EventArgs) Handles btnAdmin.Click
        SetActiveRoleUI("Administrator")
    End Sub

    Private Sub btnStaff_Click(sender As Object, e As EventArgs) Handles btnStaff.Click
        SetActiveRoleUI("Registrar Staff")
    End Sub

    ' ──────────────────────────────────────────────
    ' LOGIN BUTTON — Authentication logic with CourseAssigned
    ' ──────────────────────────────────────────────
    Private Sub btnLogin_Click(sender As Object, e As EventArgs) Handles btnLogin.Click
        Dim username As String = txtUsername.Text.Trim()
        Dim password As String = txtPassword.Text.Trim()

        If username = "" OrElse password = "" Then
            MessageBox.Show("Please enter both username and password.", "Required Fields", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Return
        End If

        Try
            Using conn = dbHelper.GetConnection()
                conn.Open()
                ' Query modified to include CourseAssigned
                Dim query As String = "SELECT UserID, FullName, Role, Status, CourseAssigned FROM tblusers WHERE Username = @username AND Password = @password AND Role = @role"

                Using cmd As New MySqlCommand(query, conn)
                    cmd.Parameters.AddWithValue("@username", username)
                    cmd.Parameters.AddWithValue("@password", password)
                    cmd.Parameters.AddWithValue("@role", selectedRole)

                    Using reader = cmd.ExecuteReader()
                        If reader.Read() Then
                            ' User found! Check if active
                            Dim status As String = reader("Status").ToString()

                            If status = "Inactive" Then
                                MessageBox.Show("This account has been deactivated. Please contact an administrator.", "Account Inactive", MessageBoxButtons.OK, MessageBoxIcon.Error)
                                Return
                            End If

                            ' Store user details globally in dbHelper
                            dbHelper.currentUserID = Convert.ToInt32(reader("UserID"))
                            dbHelper.currentUserName = reader("FullName").ToString()
                            dbHelper.currentUserRole = reader("Role").ToString()

                            ' Fetch CourseAssigned (BSIT, CTHM, BSCRIM, or ALL)
                            If Not DBNull.Value.Equals(reader("CourseAssigned")) Then
                                dbHelper.userCourseAssigned = reader("CourseAssigned").ToString()
                            Else
                                dbHelper.userCourseAssigned = "ALL"
                            End If

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

    Private Sub chkShowPassword_CheckedChanged(sender As Object, e As EventArgs) Handles chkShowPassword.CheckedChanged
        If chkShowPassword.Checked Then
            txtPassword.PasswordChar = ControlChars.NullChar
        Else
            txtPassword.PasswordChar = "•"c
        End If
    End Sub

    Private Sub pnlLeft_Paint(sender As Object, e As PaintEventArgs) Handles pnlLeft.Paint

    End Sub

    Private Sub pnlRight_Paint(sender As Object, e As PaintEventArgs) Handles pnlRight.Paint

    End Sub

End Class