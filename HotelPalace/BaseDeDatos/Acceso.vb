Imports MySql.Data.MySqlClient

Public Class Acceso
    Public Shared Conexion As MySql.Data.MySqlClient.MySqlConnection
    Public Shared comando As MySql.Data.MySqlClient.MySqlCommand
    Public Shared adaptador As MySql.Data.MySqlClient.MySqlDataAdapter

    Public Shared ds As DataSet

    Public Shared Sub AbrirConexion()
        Try
            Conexion = New MySqlConnection("Data Source=localhost;Database=HOTEL_PALACE;User Id=root;Password=12345678")
        Catch ex As Exception
            Err.Description.ToString()
        End Try
    End Sub
End Class