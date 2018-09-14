Imports System.Data.SqlClient

Public NotInheritable Class DBConn

    Private myConn As SqlConnection

    Private myCmd As SqlCommand
    Private myReader As SqlDataReader

    Private Shared ReadOnly _instance As New Lazy(Of DBConn) _
        (Function() New DBConn(), System.Threading.LazyThreadSafetyMode.ExecutionAndPublication)

    Private Sub New()
        myConn = New SqlConnection("Server=MAXI-DOMIN-TIC\SQLEXPRESS;Database=smartdomus; Trusted_Connection=true")
    End Sub

    Public Shared ReadOnly Property Instance() As DBConn
        Get
            Return _instance.Value
        End Get
    End Property



    Public Function SelectStatement(sql As String) As SqlDataReader
        myCmd = myConn.CreateCommand
        myCmd.CommandText = sql

        myConn.Open()

        Return myCmd.ExecuteReader()
    End Function

End Class
