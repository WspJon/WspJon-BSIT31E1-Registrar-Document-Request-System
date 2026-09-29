Imports MySql.Data.MySqlClient
Imports System.Windows.Forms
Imports System.Runtime.InteropServices

Public Class frmUserManagement

    <DllImport("user32.dll", CharSet:=CharSet.Auto)>
    Private Shared Function SendMessage(ByVal hWnd As IntPtr, ByVal msg As Integer, ByVal wParam As Integer, ByVal lParam As String) As IntPtr
    End Function

    Private Const EM_SETCUEBANNER As Integer = &H1501

    Private Sub frmUserManagement_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        SendMessage(txtSearch.Handle, EM_SETCUEBANNER, 0, "Search...")
        LoadUsers()
    End Sub

    Public Sub LoadUsers(Optional searchTerm As String = "")
        Try
            Using conn = dbHelper.GetConnection()
                conn.Open()
                Dim query As String = "SELECT UserID, FullName, Username, Role, Status FROM tblusers WHERE Status != 'Deleted'"

                ' FULL NAME AT USERNAME LANG ANG PWEDENG MA-SEARCH
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

    Private Sub txtSearch_TextChanged(sender As Object, e As EventArgs) Handles txtSearch.TextChanged
        LoadUsers(txtSearch.Text.Trim())
    End Sub

End Class