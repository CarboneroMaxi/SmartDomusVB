<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Empleados
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Empleados))
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.ComboBox1 = New System.Windows.Forms.ComboBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.TextBox2 = New System.Windows.Forms.TextBox()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.Button10 = New System.Windows.Forms.Button()
        Me.Button14 = New System.Windows.Forms.Button()
        Me.ComboBox2 = New System.Windows.Forms.ComboBox()
        Me.ListView1 = New System.Windows.Forms.ListView()
        Me.SuspendLayout()
        '
        'Button2
        '
        Me.Button2.Location = New System.Drawing.Point(38, 28)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(75, 23)
        Me.Button2.TabIndex = 33
        Me.Button2.Text = "Salir"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(639, 28)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(75, 23)
        Me.Button1.TabIndex = 32
        Me.Button1.Text = "Agregar"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(487, 90)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(40, 13)
        Me.Label5.TabIndex = 26
        Me.Label5.Text = "Estado"
        '
        'ComboBox1
        '
        Me.ComboBox1.FormattingEnabled = True
        Me.ComboBox1.Items.AddRange(New Object() {"Activo", "Inactivo"})
        Me.ComboBox1.Location = New System.Drawing.Point(490, 106)
        Me.ComboBox1.Name = "ComboBox1"
        Me.ComboBox1.Size = New System.Drawing.Size(100, 21)
        Me.ComboBox1.TabIndex = 25
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(354, 88)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(23, 13)
        Me.Label4.TabIndex = 24
        Me.Label4.Text = "Rol"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(190, 87)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(90, 13)
        Me.Label2.TabIndex = 22
        Me.Label2.Text = "Nombre completo"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(66, 87)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(40, 13)
        Me.Label1.TabIndex = 21
        Me.Label1.Text = "Cédula"
        '
        'TextBox2
        '
        Me.TextBox2.Location = New System.Drawing.Point(193, 106)
        Me.TextBox2.Name = "TextBox2"
        Me.TextBox2.Size = New System.Drawing.Size(100, 20)
        Me.TextBox2.TabIndex = 18
        '
        'TextBox1
        '
        Me.TextBox1.Location = New System.Drawing.Point(66, 106)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(100, 20)
        Me.TextBox1.TabIndex = 17
        '
        'Button3
        '
        Me.Button3.BackgroundImage = CType(resources.GetObject("Button3.BackgroundImage"), System.Drawing.Image)
        Me.Button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button3.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.Button3.Location = New System.Drawing.Point(604, 144)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(20, 23)
        Me.Button3.TabIndex = 34
        Me.Button3.UseVisualStyleBackColor = True
        '
        'Button10
        '
        Me.Button10.BackgroundImage = CType(resources.GetObject("Button10.BackgroundImage"), System.Drawing.Image)
        Me.Button10.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button10.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.Button10.Location = New System.Drawing.Point(639, 144)
        Me.Button10.Name = "Button10"
        Me.Button10.Size = New System.Drawing.Size(20, 23)
        Me.Button10.TabIndex = 38
        Me.Button10.UseVisualStyleBackColor = True
        '
        'Button14
        '
        Me.Button14.BackgroundImage = CType(resources.GetObject("Button14.BackgroundImage"), System.Drawing.Image)
        Me.Button14.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button14.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.Button14.Location = New System.Drawing.Point(676, 144)
        Me.Button14.Name = "Button14"
        Me.Button14.Size = New System.Drawing.Size(20, 23)
        Me.Button14.TabIndex = 42
        Me.Button14.UseVisualStyleBackColor = True
        '
        'ComboBox2
        '
        Me.ComboBox2.FormattingEnabled = True
        Me.ComboBox2.Items.AddRange(New Object() {"Activo", "Inactivo"})
        Me.ComboBox2.Location = New System.Drawing.Point(357, 106)
        Me.ComboBox2.Name = "ComboBox2"
        Me.ComboBox2.Size = New System.Drawing.Size(100, 21)
        Me.ComboBox2.TabIndex = 46
        '
        'ListView1
        '
        Me.ListView1.Location = New System.Drawing.Point(66, 144)
        Me.ListView1.Name = "ListView1"
        Me.ListView1.Size = New System.Drawing.Size(524, 238)
        Me.ListView1.TabIndex = 47
        Me.ListView1.UseCompatibleStateImageBehavior = False
        '
        'Empleados
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.ListView1)
        Me.Controls.Add(Me.ComboBox2)
        Me.Controls.Add(Me.Button14)
        Me.Controls.Add(Me.Button10)
        Me.Controls.Add(Me.Button3)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.ComboBox1)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.TextBox2)
        Me.Controls.Add(Me.TextBox1)
        Me.Name = "Empleados"
        Me.Text = "Empleados"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Button2 As Button
    Friend WithEvents Button1 As Button
    Friend WithEvents Label5 As Label
    Friend WithEvents ComboBox1 As ComboBox
    Friend WithEvents Label4 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents TextBox2 As TextBox
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents Button3 As Button
    Friend WithEvents Button10 As Button
    Friend WithEvents Button14 As Button
    Friend WithEvents ComboBox2 As ComboBox
    Friend WithEvents ListView1 As ListView
End Class
