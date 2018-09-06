Public Class Clientes
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Me.Visible = False
        AgregarClientes.Visible = True
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Me.Visible = False
        Inicio.Visible = True
    End Sub

    Private Sub Button10_Click(sender As Object, e As EventArgs) Handles Button10.Click
        Me.Visible = False
        ModificarClientes.Visible = True
    End Sub

    Private Sub Button9_Click(sender As Object, e As EventArgs) 
        Me.Visible = False
        ModificarClientes.Visible = True
    End Sub

    Private Sub Button8_Click(sender As Object, e As EventArgs) 
        Me.Visible = False
        ModificarClientes.Visible = True
    End Sub

    Private Sub Button7_Click(sender As Object, e As EventArgs) 
        Me.Visible = False
        ModificarClientes.Visible = True
    End Sub

    Private Sub Button14_Click(sender As Object, e As EventArgs) Handles Button14.Click
        Me.Visible = False
        PerfilCliente.Visible = True
    End Sub

    Private Sub Button13_Click(sender As Object, e As EventArgs) 
        Me.Visible = False
        PerfilCliente.Visible = True
    End Sub

    Private Sub Button12_Click(sender As Object, e As EventArgs) 
        Me.Visible = False
        PerfilCliente.Visible = True
    End Sub

    Private Sub Button11_Click(sender As Object, e As EventArgs) 
        Me.Visible = False
        PerfilCliente.Visible = True
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        EliminarCliente.Visible = True
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) 
        EliminarCliente.Visible = True
    End Sub

    Private Sub Button6_Click(sender As Object, e As EventArgs) 
        EliminarCliente.Visible = True
    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) 
        EliminarCliente.Visible = True
    End Sub
End Class
