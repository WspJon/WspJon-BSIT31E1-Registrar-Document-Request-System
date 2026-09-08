Imports MySql.Data.MySqlClient

Public Class frmUserManagement

    Private Sub frmUserManagement_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        LoadUsers()
    End Sub

    Public Sub LoadUsers(Optional searchTerm As String = "")
        Try
            Using conn = dbHelper.GetConnection()
                conn.Open()
                ' Note: Soft delete only (Rule 5.6)
                Dim query As String = "SELECT UserID, FullName, Username, Role, Status FROM tblusers WHERE Status != 'Deleted'"
                
                If Not String.IsNullOrWhiteSpace(searchTerm) Then
                    query &= " AND (FullName LIKE @search OR Username LIKE @search)"
                End If

                Using cmd As New MySqlCommand(query, conn)
                    If Not String.IsNullOrWhiteSpace(searchTerm) Then
                        cmd.Parameters.AddWithValue("@search", "%" & searchTerm & "%")
                    End If

                    Dim adapter As New MySqlDataAdapter(cmd)
                    Dim dt As New DataTable()
                    adapter.Fill(dt)

                    dgvUsers.AutoGenerateColumns = False
                    colFullName.DataPropertyName = "FullName"
                    colUsername.DataPropertyName = "Username"
                    colRole.DataPropertyName = "Role"
                    colStatus.DataPropertyName = "Status"
                    dgvUsers.DataSource = dt
                End Using
            End Using
        Catch ex As Exception
            ' Ignore error if database isn't ready
        End Try
    End Sub

    Private Sub btnSearch_Click(sender As Object, e As EventArgs) Handles btnSearch.Click
        LoadUsers(txtSearch.Text.Trim())
    End Sub

    Private Sub btnAddUser_Click(sender As Object, e As EventArgs) Handles btnAddUser.Click
        Dim frm As New frmUserAddEdit()
        frm.IsEditMode = False
        If frm.ShowDialog() = DialogResult.OK Then
            LoadUsers(txtSearch.Text.Trim())
        End If
    End Sub

End Class
