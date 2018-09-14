Public Class Cliente
    Inherits Generica

    Protected cedulaPersonas As String
    Protected numeroTarjeta As Integer
    Public Sub New()
        Me.nombreTabla = "clientes"

    End Sub

    'TODO: después de poner los atributos, recibir todos los valores por parámetro
    Public Sub New(cedulaPersonas As String, numeroTarjeta As Integer)
        Me.nombreTabla = "clientes"

        Me.cedulaPersonas = cedulaPersonas
        Me.numeroTarjeta = numeroTarjeta
    End Sub
End Class
