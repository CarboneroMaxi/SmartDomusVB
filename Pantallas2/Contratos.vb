Public Class Contratos
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Me.Visible = False
        AgregarContrato.Visible = True
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        EliminarContrato.Visible = True
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) 
        EliminarContrato.Visible = True
    End Sub

    Private Sub Button6_Click(sender As Object, e As EventArgs) 
        EliminarContrato.Visible = True
    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) 
        EliminarContrato.Visible = True
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Me.Visible = False
        Inicio.Visible = True
    End Sub

    Private Sub Button10_Click(sender As Object, e As EventArgs) Handles Button10.Click
        Me.Visible = False
        ModificarContrato.Visible = True
    End Sub

    Private Sub Button9_Click(sender As Object, e As EventArgs) 
        Me.Visible = False
        ModificarContrato.Visible = True
    End Sub

    Private Sub Button8_Click(sender As Object, e As EventArgs) 
        Me.Visible = False
        ModificarContrato.Visible = True
    End Sub

    Private Sub Button7_Click(sender As Object, e As EventArgs) 
        Me.Visible = False
        ModificarContrato.Visible = True
    End Sub
End Class