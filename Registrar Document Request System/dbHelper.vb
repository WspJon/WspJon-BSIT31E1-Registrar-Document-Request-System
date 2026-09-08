Imports MySql.Data.MySqlClient

Public Class dbHelper
    ' IMPORTANT: You will need to change these values later if your classmate 
    ' set up the database with a specific password or database name.
    Private Shared server As String = "localhost"
    Private Shared user As String = "root"
    Private Shared password As String = "" ' Put the MySQL password here if there is one
    Private Shared database As String = "registrar_db" ' Change to the actual database name

    ' The connection string that puts those variables together
    Private Shared connectionString As String = $"server={server};user id={user};password={password};database={database};"

    ' This function allows any screen to easily grab a database connection
    Public Shared Function GetConnection() As MySqlConnection
        Return New MySqlConnection(connectionString)
    End Function

    ' Global variables to store the logged-in user's details (Requested in Step 5.1)
    Public Shared currentUserRole As String = ""
    Public Shared currentUserID As Integer = 0
    Public Shared currentUserName As String = ""
End Class
