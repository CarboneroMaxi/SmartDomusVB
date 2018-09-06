Public Class PerfilEmpleado
    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Me.Visible = False
        ModificarEmpleados.Visible = True
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Me.Visible = False
        Empleados.Visible = True
    End Sub
End Class