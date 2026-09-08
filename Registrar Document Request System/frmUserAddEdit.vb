Imports MySql.Data.MySqlClient
Imports System.Windows.Forms
Imports System.Security.Cryptography
Imports System.Text

Public Class frmUserAddEdit
    Public IsEditMode As Boolean = False
    Public EditUserID As Integer = 0
    Public OriginalUsername As String = ""

    Private Sub btnCancel_Click(sender As Object, e As EventArgs) Handles btnCancel.Click
        Me.DialogResult = DialogResult.Cancel
        Me.Close()
    End Sub

    Private Sub btnSave_Click(sender As Object, e As EventArgs) Handles btnSave.Click
        ' Validation
        If String.IsNullOrWhiteSpace(txtFullName.Text) OrElse String.IsNullOrWhiteSpace(txtUsername.Text) OrElse cboRole.SelectedIndex = -1 Then
            MessageBox.Show("Please fill in Full Name, Username, and Role.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Return
        End If

        If Not IsEditMode AndAlso String.IsNullOrWhiteSpace(txtPassword.Text) Then
            MessageBox.Show("Password is required for new users.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Return
        End If

        Try
            Using conn = dbHelper.GetConnection()
                conn.Open()

                ' Unique Username check (Rule 5.6)
                Dim checkQuery As String = "SELECT Username FROM tblusers WHERE Username = @uname"
                Using checkCmd As New MySqlCommand(checkQuery, conn)
                    checkCmd.Parameters.AddWithValue("@uname", txtUsername.Text.Trim())
                    Using reader = checkCmd.ExecuteReader()
                        If reader.HasRows Then
                            reader.Read()
                            If Not IsEditMode OrElse (IsEditMode AndAlso reader("Username").ToString() <> OriginalUsername) Then
                                MessageBox.Show("This username is already taken. Please choose another.", "Duplicate Username", MessageBoxButtons.OK, MessageBoxIcon.Error)
                                Return
                            End If
                        End If
                    End Using
                End Using

                Dim query As String
                Dim hasNewPassword As Boolean = Not String.IsNullOrWhiteSpace(txtPassword.Text)

                If IsEditMode Then
                    If hasNewPassword Then
                        query = "UPDATE tblusers SET FullName=@fname, Username=@uname, Password=@pass, Role=@role, Status=@status WHERE UserID=@id"
                    Else
                        query = "UPDATE tblusers SET FullName=@fname, Username=@uname, Role=@role, Status=@status WHERE UserID=@id"
                    End If
                Else
                    query = "INSERT INTO tblusers (FullName, Username, Password, Role, Status) VALUES (@fname, @uname, @pass, @role, @status)"
                End If

                Using cmd As New MySqlCommand(query, conn)
                    cmd.Parameters.AddWithValue("@fname", txtFullName.Text.Trim())
                    cmd.Parameters.AddWithValue("@uname", txtUsername.Text.Trim())
                    cmd.Parameters.AddWithValue("@role", cboRole.SelectedItem.ToString())
                    cmd.Parameters.AddWithValue("@status", If(cboStatus.SelectedIndex = -1, "Active", cboStatus.SelectedItem.ToString()))
                    
                    If IsEditMode Then
                        cmd.Parameters.AddWithValue("@id", EditUserID)
                    End If

                    If hasNewPassword Then
                        ' Hashing logic (Rule 5.6)
                        Dim hashedPass As String = HashPassword(txtPassword.Text)
                        cmd.Parameters.AddWithValue("@pass", hashedPass)
                    End If

                    cmd.ExecuteNonQuery()
                End Using

                MessageBox.Show("User details saved successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information)
                Me.DialogResult = DialogResult.OK
                Me.Close()
            End Using
        Catch ex As Exception
            MessageBox.Show("Database Error: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    ' SHA256 Hashing Implementation
    Private Function HashPassword(password As String) As String
        Using sha256 As SHA256 = SHA256.Create()
            Dim bytes As Byte() = Encoding.UTF8.GetBytes(password)
            Dim hashBytes As Byte() = sha256.ComputeHash(bytes)
            Dim builder As New StringBuilder()
            For i As Integer = 0 To hashBytes.Length - 1
                builder.Append(hashBytes(i).ToString("x2"))
            Next
            Return builder.ToString()
        End Using
    End Function

    Private Sub frmUserAddEdit_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        If Not IsEditMode Then
            lblTitle.Text = "Add System User"
            If cboRole.Items.Count > 0 Then cboRole.SelectedIndex = 0
            If cboStatus.Items.Count > 0 Then cboStatus.SelectedIndex = 0
        Else
            lblTitle.Text = "Edit System User"
        End If
    End Sub
End Class
