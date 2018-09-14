Public Class Servicio
    Inherits Generica

    Protected id As Integer
    Protected titulo As String
    Protected precio As Integer
    Protected descripcion As String
    'TODO: poner todos los atributos

    Public Sub New()
        Me.nombreTabla = "servicios"

    End Sub

    'TODO: después de poner los atributos, recibir todos los valores por parámetro
    Public Sub New(id As Integer, titulofasdfdsaf As String, precio As Integer, descripcion As String)
        Me.nombreTabla = "servicios"

        Me.id = id
        Me.titulo = titulofasdfdsaf
        Me.precio = precio
        Me.descripcion = descripcion
    End Sub


End Class
