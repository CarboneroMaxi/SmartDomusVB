Public Class Inicio
    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Me.Visible = False
        Clientes.Visible = True
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Me.Visible = False
        Empleados.Visible = True
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Me.Visible = False
        Servicios.Visible = True
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        Me.Visible = False
        Materiales.Visible = True
    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        Me.Visible = False
        LoginForm1.Visible = True
    End Sub

    Private Sub btnContratos_Click(sender As Object, e As EventArgs) Handles btnContratos.Click
        Me.Visible = False
        Contratos.Visible = True
    End Sub

    Private Sub Button6_Click(sender As Object, e As EventArgs) Handles Button6.Click
        Me.Visible = False
        Logsvb.Visible = True
    End Sub

    Private Sub Button7_Click(sender As Object, e As EventArgs) Handles Button7.Click
        Me.Visible = False
        PanelDeControl.Visible = True
    End Sub
End Class