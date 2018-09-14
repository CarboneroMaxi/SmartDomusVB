Imports System.Data.SqlClient

Public Class Generica
    Protected nombreTabla As String


    Public Function obtenerListado() As SqlDataReader
        Return DBConn.Instance.SelectStatement("SELECT * FROM " + Me.nombreTabla)

    End Function
End Class
