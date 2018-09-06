Public Class PerfilCliente
    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Me.Visible = False
        Clientes.Visible = True
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Me.Visible = False
        ModificarClientes.Visible = True
    End Sub
End Class