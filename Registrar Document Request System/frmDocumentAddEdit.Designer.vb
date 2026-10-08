<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmDocumentAddEdit
    Inherits System.Windows.Forms.Form

    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    Private components As System.ComponentModel.IContainer

    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        lblTitle = New Label()
        pnlHeader = New Panel()
        lblDocName = New Label()
        txtDocName = New TextBox()
        lblDescription = New Label()
        txtDescription = New TextBox()
        lblFee = New Label()
        txtFee = New TextBox()
        lblStatus = New Label()
        cboStatus = New ComboBox()
        btnSave = New Button()
        btnCancel = New Button()
        pnlHeader.SuspendLayout()
        SuspendLayout()
        ' 
        ' lblTitle
        ' 
        lblTitle.AutoSize = True
        lblTitle.Font = New Font("Segoe UI", 14F, FontStyle.Bold)
        lblTitle.ForeColor = Color.White
        lblTitle.Location = New Point(23, 24)
        lblTitle.Name = "lblTitle"
        lblTitle.Size = New Size(248, 32)
        lblTitle.TabIndex = 0
        lblTitle.Text = "Add Document Type"
        ' 
        ' pnlHeader
        ' 
        pnlHeader.BackColor = Color.FromArgb(CByte(15), CByte(31), CByte(76))
        pnlHeader.Controls.Add(lblTitle)
        pnlHeader.Dock = DockStyle.Top
        pnlHeader.Location = New Point(0, 0)
        pnlHeader.Margin = New Padding(3, 4, 3, 4)
        pnlHeader.Name = "pnlHeader"
        pnlHeader.Size = New Size(457, 80)
        pnlHeader.TabIndex = 0
        ' 
        ' lblDocName
        ' 
        lblDocName.AutoSize = True
        lblDocName.Font = New Font("Segoe UI", 9.5F)
        lblDocName.Location = New Point(29, 107)
        lblDocName.Name = "lblDocName"
        lblDocName.Size = New Size(128, 21)
        lblDocName.TabIndex = 1
        lblDocName.Text = "Document Name"
        ' 
        ' txtDocName
        ' 
        txtDocName.Font = New Font("Segoe UI", 10F)
        txtDocName.Location = New Point(29, 133)
        txtDocName.Margin = New Padding(3, 4, 3, 4)
        txtDocName.Name = "txtDocName"
        txtDocName.Size = New Size(399, 30)
        txtDocName.TabIndex = 2
        ' 
        ' lblDescription
        ' 
        lblDescription.AutoSize = True
        lblDescription.Font = New Font("Segoe UI", 9.5F)
        lblDescription.Location = New Point(29, 187)
        lblDescription.Name = "lblDescription"
        lblDescription.Size = New Size(89, 21)
        lblDescription.TabIndex = 3
        lblDescription.Text = "Description"
        ' 
        ' txtDescription
        ' 
        txtDescription.Font = New Font("Segoe UI", 10F)
        txtDescription.Location = New Point(29, 213)
        txtDescription.Margin = New Padding(3, 4, 3, 4)
        txtDescription.Multiline = True
        txtDescription.Name = "txtDescription"
        txtDescription.Size = New Size(399, 79)
        txtDescription.TabIndex = 4
        ' 
        ' lblFee
        ' 
        lblFee.AutoSize = True
        lblFee.Font = New Font("Segoe UI", 9.5F)
        lblFee.Location = New Point(29, 320)
        lblFee.Name = "lblFee"
        lblFee.Size = New Size(34, 21)
        lblFee.TabIndex = 5
        lblFee.Text = "Fee"
        ' 
        ' txtFee
        ' 
        txtFee.Font = New Font("Segoe UI", 10F)
        txtFee.Location = New Point(29, 347)
        txtFee.Margin = New Padding(3, 4, 3, 4)
        txtFee.Name = "txtFee"
        txtFee.Size = New Size(182, 30)
        txtFee.TabIndex = 6
        txtFee.Text = "0.00"
        ' 
        ' lblStatus
        ' 
        lblStatus.AutoSize = True
        lblStatus.Font = New Font("Segoe UI", 9.5F)
        lblStatus.Location = New Point(246, 320)
        lblStatus.Name = "lblStatus"
        lblStatus.Size = New Size(52, 21)
        lblStatus.TabIndex = 7
        lblStatus.Text = "Status"
        ' 
        ' cboStatus
        ' 
        cboStatus.DropDownStyle = ComboBoxStyle.DropDownList
        cboStatus.Font = New Font("Segoe UI", 10F)
        cboStatus.FormattingEnabled = True
        cboStatus.Items.AddRange(New Object() {"Active", "Inactive"})
        cboStatus.Location = New Point(246, 347)
        cboStatus.Margin = New Padding(3, 4, 3, 4)
        cboStatus.Name = "cboStatus"
        cboStatus.Size = New Size(182, 31)
        cboStatus.TabIndex = 8
        ' 
        ' btnSave
        ' 
        btnSave.BackColor = Color.FromArgb(CByte(15), CByte(31), CByte(76))
        btnSave.Cursor = Cursors.Hand
        btnSave.FlatAppearance.BorderSize = 0
        btnSave.FlatStyle = FlatStyle.Flat
        btnSave.Font = New Font("Segoe UI", 10F, FontStyle.Bold)
        btnSave.ForeColor = Color.White
        btnSave.Location = New Point(303, 413)
        btnSave.Margin = New Padding(3, 4, 3, 4)
        btnSave.Name = "btnSave"
        btnSave.Size = New Size(126, 47)
        btnSave.TabIndex = 9
        btnSave.Text = "Save"
        btnSave.UseVisualStyleBackColor = False
        ' 
        ' btnCancel
        ' 
        btnCancel.BackColor = Color.White
        btnCancel.Cursor = Cursors.Hand
        btnCancel.FlatAppearance.BorderColor = Color.FromArgb(CByte(15), CByte(31), CByte(76))
        btnCancel.FlatStyle = FlatStyle.Flat
        btnCancel.Font = New Font("Segoe UI", 10F)
        btnCancel.ForeColor = Color.FromArgb(CByte(15), CByte(31), CByte(76))
        btnCancel.Location = New Point(166, 413)
        btnCancel.Margin = New Padding(3, 4, 3, 4)
        btnCancel.Name = "btnCancel"
        btnCancel.Size = New Size(126, 47)
        btnCancel.TabIndex = 10
        btnCancel.Text = "Cancel"
        btnCancel.UseVisualStyleBackColor = False
        ' 
        ' frmDocumentAddEdit
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.FromArgb(CByte(255), CByte(249), CByte(229))
        ClientSize = New Size(457, 493)
        Controls.Add(btnCancel)
        Controls.Add(btnSave)
        Controls.Add(cboStatus)
        Controls.Add(lblStatus)
        Controls.Add(txtFee)
        Controls.Add(lblFee)
        Controls.Add(txtDescription)
        Controls.Add(lblDescription)
        Controls.Add(txtDocName)
        Controls.Add(lblDocName)
        Controls.Add(pnlHeader)
        Font = New Font("Segoe UI", 9F)
        FormBorderStyle = FormBorderStyle.FixedDialog
        Margin = New Padding(3, 4, 3, 4)
        MaximizeBox = False
        MinimizeBox = False
        Name = "frmDocumentAddEdit"
        StartPosition = FormStartPosition.CenterParent
        Text = "Document Details"
        pnlHeader.ResumeLayout(False)
        pnlHeader.PerformLayout()
        ResumeLayout(False)
        PerformLayout()

    End Sub

    Friend WithEvents pnlHeader As System.Windows.Forms.Panel
    Friend WithEvents lblTitle As System.Windows.Forms.Label
    Friend WithEvents lblDocName As System.Windows.Forms.Label
    Friend WithEvents txtDocName As System.Windows.Forms.TextBox
    Friend WithEvents lblDescription As System.Windows.Forms.Label
    Friend WithEvents txtDescription As System.Windows.Forms.TextBox
    Friend WithEvents lblFee As System.Windows.Forms.Label
    Friend WithEvents txtFee As System.Windows.Forms.TextBox
    Friend WithEvents lblStatus As System.Windows.Forms.Label
    Friend WithEvents cboStatus As System.Windows.Forms.ComboBox
    Friend WithEvents btnSave As System.Windows.Forms.Button
    Friend WithEvents btnCancel As System.Windows.Forms.Button
End Class
