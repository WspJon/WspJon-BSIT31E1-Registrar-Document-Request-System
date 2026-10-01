Imports MySql.Data.MySqlClient

Public Class dbHelper
    Private Shared server As String = "127.0.0.1"
    Private Shared user As String = "root"
    Private Shared password As String = ""
    Private Shared database As String = "registrar_dbnew"

    Private Shared connectionString As String = $"server={server};user id={user};password={password};database={database};"

    Public Shared Function GetConnection() As MySqlConnection
        Return New MySqlConnection(connectionString)
    End Function

    ' Global variables to store the logged-in user's details
    Public Shared currentUserRole As String = ""
    Public Shared currentUserID As Integer = 0
    Public Shared currentUserName As String = ""

    ' IDINAGDAG: Para matukoy kung BSIT, CTHM, BSCRIM, o ALL ang nakatalaga sa staff
    Public Shared userCourseAssigned As String = ""
End Class