Public Class Servicios
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Me.Visible = False
        Inicio.Visible = True
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Me.Visible = False
        AgregarServicio.Visible = True
    End Sub

    Private Sub Button10_Click(sender As Object, e As EventArgs) Handles Button10.Click
        Me.Visible = False
        ModificarServicio.Visible = True
    End Sub

    Private Sub Button9_Click(sender As Object, e As EventArgs) 
        Me.Visible = False
        ModificarServicio.Visible = True
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        EliminarServicio.Visible = True
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) 
        EliminarServicio.Visible = True
    End Sub
End Class