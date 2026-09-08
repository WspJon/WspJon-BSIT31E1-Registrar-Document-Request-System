Imports MySql.Data.MySqlClient
Imports System.Windows.Forms

Public Class frmDocumentAddEdit
    Public IsEditMode As Boolean = False
    Public EditDocumentID As Integer = 0

    Private Sub btnCancel_Click(sender As Object, e As EventArgs) Handles btnCancel.Click
        Me.DialogResult = DialogResult.Cancel
        Me.Close()
    End Sub

    Private Sub btnSave_Click(sender As Object, e As EventArgs) Handles btnSave.Click
        ' Basic empty validation
        If String.IsNullOrWhiteSpace(txtDocName.Text) OrElse String.IsNullOrWhiteSpace(txtFee.Text) Then
            MessageBox.Show("Please fill in the Document Name and Fee.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Return
        End If

        ' Validate Fee > 0 (Rule 5.4)
        Dim feeValue As Decimal = 0
        If Not Decimal.TryParse(txtFee.Text, feeValue) OrElse feeValue <= 0 Then
            MessageBox.Show("Please enter a valid Fee amount greater than 0.", "Invalid Fee", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Return
        End If

        Try
            Using conn = dbHelper.GetConnection()
                conn.Open()
                
                Dim query As String
                If IsEditMode Then
                    query = "UPDATE tbldocuments SET DocumentName=@name, Description=@desc, Fee=@fee, Status=@status WHERE DocumentID=@id"
                Else
                    query = "INSERT INTO tbldocuments (DocumentName, Description, Fee, Status) VALUES (@name, @desc, @fee, @status)"
                End If

                Using cmd As New MySqlCommand(query, conn)
                    cmd.Parameters.AddWithValue("@name", txtDocName.Text.Trim())
                    cmd.Parameters.AddWithValue("@desc", txtDescription.Text.Trim())
                    cmd.Parameters.AddWithValue("@fee", feeValue)
                    cmd.Parameters.AddWithValue("@status", If(cboStatus.SelectedIndex = -1, "Active", cboStatus.SelectedItem.ToString()))
                    
                    If IsEditMode Then
                        cmd.Parameters.AddWithValue("@id", EditDocumentID)
                    End If

                    cmd.ExecuteNonQuery()
                End Using

                MessageBox.Show("Document details saved successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information)
                Me.DialogResult = DialogResult.OK
                Me.Close()
            End Using
        Catch ex As Exception
            MessageBox.Show("Database Error: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub frmDocumentAddEdit_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        If Not IsEditMode Then
            lblTitle.Text = "Add Document Type"
            If cboStatus.Items.Count > 0 Then cboStatus.SelectedIndex = 0
        Else
            lblTitle.Text = "Edit Document Type"
        End If
    End Sub
End Class
