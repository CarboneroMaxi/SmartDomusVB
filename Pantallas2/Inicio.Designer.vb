<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Inicio
    Inherits System.Windows.Forms.Form

    'Form reemplaza a Dispose para limpiar la lista de componentes.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Requerido por el Diseñador de Windows Forms
    Private components As System.ComponentModel.IContainer

    'NOTA: el Diseñador de Windows Forms necesita el siguiente procedimiento
    'Se puede modificar usando el Diseñador de Windows Forms.  
    'No lo modifique con el editor de código.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Button4 = New System.Windows.Forms.Button()
        Me.Button5 = New System.Windows.Forms.Button()
        Me.btnContratos = New System.Windows.Forms.Button()
        Me.Button6 = New System.Windows.Forms.Button()
        Me.Button7 = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'Button2
        '
        Me.Button2.BackColor = System.Drawing.SystemColors.Control
        Me.Button2.Location = New System.Drawing.Point(544, 175)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(116, 23)
        Me.Button2.TabIndex = 1
        Me.Button2.Text = "Clientes"
        Me.Button2.UseVisualStyleBackColor = False
        '
        'Button3
        '
        Me.Button3.BackColor = System.Drawing.SystemColors.Control
        Me.Button3.Location = New System.Drawing.Point(544, 214)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(116, 23)
        Me.Button3.TabIndex = 2
        Me.Button3.Text = "Servicios"
        Me.Button3.UseVisualStyleBackColor = False
        '
        'Button1
        '
        Me.Button1.BackColor = System.Drawing.SystemColors.Control
        Me.Button1.Location = New System.Drawing.Point(544, 135)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(116, 23)
        Me.Button1.TabIndex = 0
        Me.Button1.Text = "Empleados"
        Me.Button1.UseVisualStyleBackColor = False
        '
        'Button4
        '
        Me.Button4.BackColor = System.Drawing.SystemColors.Control
        Me.Button4.Location = New System.Drawing.Point(544, 254)
        Me.Button4.Name = "Button4"
        Me.Button4.Size = New System.Drawing.Size(116, 23)
        Me.Button4.TabIndex = 3
        Me.Button4.Text = "Materiales"
        Me.Button4.UseVisualStyleBackColor = False
        '
        'Button5
        '
        Me.Button5.Location = New System.Drawing.Point(67, 80)
        Me.Button5.Name = "Button5"
        Me.Button5.Size = New System.Drawing.Size(75, 23)
        Me.Button5.TabIndex = 4
        Me.Button5.Text = "Salir"
        Me.Button5.UseVisualStyleBackColor = True
        '
        'btnContratos
        '
        Me.btnContratos.BackColor = System.Drawing.SystemColors.Control
        Me.btnContratos.Location = New System.Drawing.Point(544, 292)
        Me.btnContratos.Name = "btnContratos"
        Me.btnContratos.Size = New System.Drawing.Size(116, 23)
        Me.btnContratos.TabIndex = 5
        Me.btnContratos.Text = "Contratos"
        Me.btnContratos.UseVisualStyleBackColor = False
        '
        'Button6
        '
        Me.Button6.BackColor = System.Drawing.SystemColors.Control
        Me.Button6.Location = New System.Drawing.Point(544, 330)
        Me.Button6.Name = "Button6"
        Me.Button6.Size = New System.Drawing.Size(116, 23)
        Me.Button6.TabIndex = 6
        Me.Button6.Text = "Logs"
        Me.Button6.UseVisualStyleBackColor = False
        '
        'Button7
        '
        Me.Button7.BackColor = System.Drawing.SystemColors.Control
        Me.Button7.Location = New System.Drawing.Point(544, 371)
        Me.Button7.Name = "Button7"
        Me.Button7.Size = New System.Drawing.Size(116, 23)
        Me.Button7.TabIndex = 7
        Me.Button7.Text = "Panel de Control"
        Me.Button7.UseVisualStyleBackColor = False
        '
        'Inicio
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.Button7)
        Me.Controls.Add(Me.Button6)
        Me.Controls.Add(Me.btnContratos)
        Me.Controls.Add(Me.Button5)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.Button4)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.Button3)
        Me.IsMdiContainer = True
        Me.Name = "Inicio"
        Me.Text = "Inicio"
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Button2 As Button
    Friend WithEvents Button3 As Button
    Friend WithEvents Button1 As Button
    Friend WithEvents Button4 As Button
    Friend WithEvents Button5 As Button
    Friend WithEvents btnContratos As Button
    Friend WithEvents Button6 As Button
    Friend WithEvents Button7 As Button
End Class
