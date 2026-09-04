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
        ' TODO: Pass selectedRole to the authentication logic
        ' e.g. AuthenticateUser(txtUsername.Text, txtPassword.Text, selectedRole)
    End Sub

    Private Sub pnlLeft_Paint(sender As Object, e As PaintEventArgs) Handles pnlLeft.Paint

    End Sub
End Class
