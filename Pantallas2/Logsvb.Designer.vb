<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Logsvb
    Inherits System.Windows.Forms.Form

    'Form reemplaza a Dispose para limpiar la lista de componentes.
    <System.Diagnostics.DebuggerNonUserCode()> _
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
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.ListView1 = New System.Windows.Forms.ListView()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.TextBox2 = New System.Windows.Forms.TextBox()
        Me.TextBox3 = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.ComboBox2 = New System.Windows.Forms.ComboBox()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'ListView1
        '
        Me.ListView1.Location = New System.Drawing.Point(69, 96)
        Me.ListView1.Name = "ListView1"
        Me.ListView1.Size = New System.Drawing.Size(681, 249)
        Me.ListView1.TabIndex = 0
        Me.ListView1.UseCompatibleStateImageBehavior = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(66, 48)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(27, 13)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "user"
        '
        'TextBox1
        '
        Me.TextBox1.Location = New System.Drawing.Point(69, 65)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(100, 20)
        Me.TextBox1.TabIndex = 2
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(223, 48)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(30, 13)
        Me.Label2.TabIndex = 3
        Me.Label2.Text = "Hora"
        '
        'TextBox2
        '
        Me.TextBox2.Location = New System.Drawing.Point(205, 64)
        Me.TextBox2.Name = "TextBox2"
        Me.TextBox2.Size = New System.Drawing.Size(32, 20)
        Me.TextBox2.TabIndex = 4
        '
        'TextBox3
        '
        Me.TextBox3.Location = New System.Drawing.Point(256, 64)
        Me.TextBox3.Name = "TextBox3"
        Me.TextBox3.Size = New System.Drawing.Size(32, 20)
        Me.TextBox3.TabIndex = 5
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(243, 68)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(10, 13)
        Me.Label3.TabIndex = 6
        Me.Label3.Text = ":"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(373, 47)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(71, 13)
        Me.Label4.TabIndex = 7
        Me.Label4.Text = "Login/Logout"
        '
        'ComboBox2
        '
        Me.ComboBox2.FormattingEnabled = True
        Me.ComboBox2.Location = New System.Drawing.Point(376, 65)
        Me.ComboBox2.Name = "ComboBox2"
        Me.ComboBox2.Size = New System.Drawing.Size(121, 21)
        Me.ComboBox2.TabIndex = 61
        '
        'Button2
        '
        Me.Button2.Location = New System.Drawing.Point(37, 12)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(75, 23)
        Me.Button2.TabIndex = 79
        Me.Button2.Text = "Salir"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'Logsvb
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.ComboBox2)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.TextBox3)
        Me.Controls.Add(Me.TextBox2)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.TextBox1)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.ListView1)
        Me.Name = "Logsvb"
        Me.Text = "Logsvb"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents ListView1 As ListView
    Friend WithEvents Label1 As Label
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents TextBox2 As TextBox
    Friend WithEvents TextBox3 As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents ComboBox2 As ComboBox
    Friend WithEvents Button2 As Button
End Class
