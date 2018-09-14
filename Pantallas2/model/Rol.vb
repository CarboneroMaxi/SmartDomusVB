Public Class Contrato
    Inherits Generica

    Protected id As Integer
    Protected fechaVencimiento As Date
    'TODO: poner todos los atributos

    Public Sub New()
        Me.nombreTabla = "contrato"

    End Sub

    'TODO: después de poner los atributos, recibir todos los valores por parámetro
    Public Sub New(id As Integer, fechaVencimiento As Date)
        Me.nombreTabla = "contrato"

        Me.id = id
        Me.fechaVencimiento = fechaVencimiento
    End Sub
End Class
