Imports MySql.Data.MySqlClient

Public Class frmDocumentManagement

    Private Sub frmDocumentManagement_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        LoadDocuments()
    End Sub

    Public Sub LoadDocuments(Optional searchTerm As String = "")
        Try
            Using conn = dbHelper.GetConnection()
                conn.Open()
                ' Note: Soft delete only
                Dim query As String = "SELECT DocumentID, DocumentName, Description, Fee, Status FROM tbldocuments WHERE Status != 'Deleted'"
                
                If Not String.IsNullOrWhiteSpace(searchTerm) Then
                    query &= " AND (DocumentName LIKE @search OR Description LIKE @search)"
                End If

                Using cmd As New MySqlCommand(query, conn)
                    If Not String.IsNullOrWhiteSpace(searchTerm) Then
                        cmd.Parameters.AddWithValue("@search", "%" & searchTerm & "%")
                    End If

                    Dim adapter As New MySqlDataAdapter(cmd)
                    Dim dt As New DataTable()
                    adapter.Fill(dt)

                    dgvDocuments.AutoGenerateColumns = False
                    ' Create a hidden column for DocumentID if needed for editing later, but for now just map visuals
                    colDocName.DataPropertyName = "DocumentName"
                    colDescription.DataPropertyName = "Description"
                    colFee.DataPropertyName = "Fee"
                    colStatus.DataPropertyName = "Status"
                    dgvDocuments.DataSource = dt
                End Using
            End Using
        Catch ex As Exception
            ' Ignore error if database isn't ready
        End Try
    End Sub

    Private Sub btnSearch_Click(sender As Object, e As EventArgs) Handles btnSearch.Click
        LoadDocuments(txtSearch.Text.Trim())
    End Sub

    Private Sub btnAddDocumentType_Click(sender As Object, e As EventArgs) Handles btnAddDocumentType.Click
        Dim frm As New frmDocumentAddEdit()
        frm.IsEditMode = False
        If frm.ShowDialog() = DialogResult.OK Then
            LoadDocuments(txtSearch.Text.Trim())
        End If
    End Sub

End Class
