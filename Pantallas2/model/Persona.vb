Public Class Persona
    Inherits Generica

    Protected cedula As String
    Protected nombre As String
    Protected apellido As String
    Protected fechaNacimiento As Date
    Protected dirCalle As String
    Protected dirNumero As Integer
    Protected telefono As String
    Protected user As String
    Protected contrasenia As String

    ' TODO: terminar este método
    Public Sub New(cedula As String, nombre As String, apellido As String)
        Me.nombreTabla = "personas"
        Me.cedula = cedula
        ' Acá tienen que recibir todos los atributos como parámetro (excepto la contraseña)
        ' y cargar los valores recibidos en los atributos
    End Sub

End Class
