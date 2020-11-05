<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class EditarPerfil
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
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.btnMostrarContraseña = New Guna.UI2.WinForms.Guna2CircleButton()
        Me.btnAceptar = New Guna.UI2.WinForms.Guna2Button()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.numPeso = New System.Windows.Forms.NumericUpDown()
        Me.numAltura = New System.Windows.Forms.NumericUpDown()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.txtConfirmarContraseña = New System.Windows.Forms.TextBox()
        Me.txtContraseña = New System.Windows.Forms.TextBox()
        Me.txtTelefono = New System.Windows.Forms.TextBox()
        Me.txtEmail = New System.Windows.Forms.TextBox()
        Me.txtDireccion = New System.Windows.Forms.TextBox()
        Me.Guna2CircleButton1 = New Guna.UI2.WinForms.Guna2CircleButton()
        Me.Panel1.SuspendLayout()
        CType(Me.numPeso, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.numAltura, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.White
        Me.Panel1.Controls.Add(Me.Label1)
        Me.Panel1.Controls.Add(Me.btnMostrarContraseña)
        Me.Panel1.Controls.Add(Me.btnAceptar)
        Me.Panel1.Controls.Add(Me.Label11)
        Me.Panel1.Controls.Add(Me.Label10)
        Me.Panel1.Controls.Add(Me.Label9)
        Me.Panel1.Controls.Add(Me.Label8)
        Me.Panel1.Controls.Add(Me.numPeso)
        Me.Panel1.Controls.Add(Me.numAltura)
        Me.Panel1.Controls.Add(Me.Label7)
        Me.Panel1.Controls.Add(Me.Label6)
        Me.Panel1.Controls.Add(Me.Label5)
        Me.Panel1.Controls.Add(Me.txtConfirmarContraseña)
        Me.Panel1.Controls.Add(Me.txtContraseña)
        Me.Panel1.Controls.Add(Me.txtTelefono)
        Me.Panel1.Controls.Add(Me.txtEmail)
        Me.Panel1.Controls.Add(Me.txtDireccion)
        Me.Panel1.Location = New System.Drawing.Point(1, 34)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(657, 320)
        Me.Panel1.TabIndex = 0
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.Gray
        Me.Label1.Location = New System.Drawing.Point(367, 195)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(98, 13)
        Me.Label1.TabIndex = 25
        Me.Label1.Text = "Mostrar contraseña"
        '
        'btnMostrarContraseña
        '
        Me.btnMostrarContraseña.CheckedState.Parent = Me.btnMostrarContraseña
        Me.btnMostrarContraseña.CustomImages.Parent = Me.btnMostrarContraseña
        Me.btnMostrarContraseña.FillColor = System.Drawing.Color.Green
        Me.btnMostrarContraseña.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.btnMostrarContraseña.ForeColor = System.Drawing.Color.White
        Me.btnMostrarContraseña.HoverState.Parent = Me.btnMostrarContraseña
        Me.btnMostrarContraseña.Location = New System.Drawing.Point(345, 190)
        Me.btnMostrarContraseña.Name = "btnMostrarContraseña"
        Me.btnMostrarContraseña.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle
        Me.btnMostrarContraseña.ShadowDecoration.Parent = Me.btnMostrarContraseña
        Me.btnMostrarContraseña.Size = New System.Drawing.Size(21, 22)
        Me.btnMostrarContraseña.TabIndex = 24
        '
        'btnAceptar
        '
        Me.btnAceptar.Animated = True
        Me.btnAceptar.AutoRoundedCorners = True
        Me.btnAceptar.BorderRadius = 21
        Me.btnAceptar.CheckedState.Parent = Me.btnAceptar
        Me.btnAceptar.CustomImages.Parent = Me.btnAceptar
        Me.btnAceptar.Font = New System.Drawing.Font("Segoe UI", 13.0!)
        Me.btnAceptar.ForeColor = System.Drawing.Color.White
        Me.btnAceptar.HoverState.Parent = Me.btnAceptar
        Me.btnAceptar.Location = New System.Drawing.Point(489, 235)
        Me.btnAceptar.Name = "btnAceptar"
        Me.btnAceptar.ShadowDecoration.Parent = Me.btnAceptar
        Me.btnAceptar.Size = New System.Drawing.Size(146, 44)
        Me.btnAceptar.TabIndex = 23
        Me.btnAceptar.Text = "Aceptar"
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.Location = New System.Drawing.Point(22, 235)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(187, 22)
        Me.Label11.TabIndex = 22
        Me.Label11.Text = "Confirmar contraseña:"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.Location = New System.Drawing.Point(45, 192)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(108, 22)
        Me.Label10.TabIndex = 21
        Me.Label10.Text = "Contraseña:"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.Location = New System.Drawing.Point(91, 90)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(62, 22)
        Me.Label9.TabIndex = 20
        Me.Label9.Text = "Altura:"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(91, 145)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(56, 22)
        Me.Label8.TabIndex = 19
        Me.Label8.Text = "Peso:"
        '
        'numPeso
        '
        Me.numPeso.DecimalPlaces = 1
        Me.numPeso.Location = New System.Drawing.Point(159, 145)
        Me.numPeso.Name = "numPeso"
        Me.numPeso.Size = New System.Drawing.Size(62, 20)
        Me.numPeso.TabIndex = 18
        '
        'numAltura
        '
        Me.numAltura.DecimalPlaces = 2
        Me.numAltura.Location = New System.Drawing.Point(159, 90)
        Me.numAltura.Name = "numAltura"
        Me.numAltura.Size = New System.Drawing.Size(62, 20)
        Me.numAltura.TabIndex = 17
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(371, 126)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(86, 22)
        Me.Label7.TabIndex = 16
        Me.Label7.Text = "Teléfono:"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(392, 38)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(65, 22)
        Me.Label6.TabIndex = 15
        Me.Label6.Text = "E-mail:"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(66, 35)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(90, 22)
        Me.Label5.TabIndex = 14
        Me.Label5.Text = "Dirección:"
        '
        'txtConfirmarContraseña
        '
        Me.txtConfirmarContraseña.Location = New System.Drawing.Point(215, 235)
        Me.txtConfirmarContraseña.Name = "txtConfirmarContraseña"
        Me.txtConfirmarContraseña.Size = New System.Drawing.Size(175, 20)
        Me.txtConfirmarContraseña.TabIndex = 9
        Me.txtConfirmarContraseña.UseSystemPasswordChar = True
        '
        'txtContraseña
        '
        Me.txtContraseña.Location = New System.Drawing.Point(159, 192)
        Me.txtContraseña.Name = "txtContraseña"
        Me.txtContraseña.Size = New System.Drawing.Size(175, 20)
        Me.txtContraseña.TabIndex = 7
        Me.txtContraseña.UseSystemPasswordChar = True
        '
        'txtTelefono
        '
        Me.txtTelefono.Location = New System.Drawing.Point(463, 128)
        Me.txtTelefono.Name = "txtTelefono"
        Me.txtTelefono.Size = New System.Drawing.Size(160, 20)
        Me.txtTelefono.TabIndex = 6
        '
        'txtEmail
        '
        Me.txtEmail.Location = New System.Drawing.Point(463, 40)
        Me.txtEmail.Name = "txtEmail"
        Me.txtEmail.Size = New System.Drawing.Size(170, 20)
        Me.txtEmail.TabIndex = 5
        '
        'txtDireccion
        '
        Me.txtDireccion.Location = New System.Drawing.Point(159, 37)
        Me.txtDireccion.Name = "txtDireccion"
        Me.txtDireccion.Size = New System.Drawing.Size(122, 20)
        Me.txtDireccion.TabIndex = 4
        '
        'Guna2CircleButton1
        '
        Me.Guna2CircleButton1.CheckedState.Parent = Me.Guna2CircleButton1
        Me.Guna2CircleButton1.CustomImages.Parent = Me.Guna2CircleButton1
        Me.Guna2CircleButton1.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.Guna2CircleButton1.ForeColor = System.Drawing.Color.White
        Me.Guna2CircleButton1.HoverState.Parent = Me.Guna2CircleButton1
        Me.Guna2CircleButton1.Location = New System.Drawing.Point(627, 4)
        Me.Guna2CircleButton1.Name = "Guna2CircleButton1"
        Me.Guna2CircleButton1.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle
        Me.Guna2CircleButton1.ShadowDecoration.Parent = Me.Guna2CircleButton1
        Me.Guna2CircleButton1.Size = New System.Drawing.Size(28, 27)
        Me.Guna2CircleButton1.TabIndex = 0
        Me.Guna2CircleButton1.Text = "X"
        '
        'EditarPerfil
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(40, Byte), Integer), CType(CType(117, Byte), Integer), CType(CType(207, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(658, 355)
        Me.Controls.Add(Me.Guna2CircleButton1)
        Me.Controls.Add(Me.Panel1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "EditarPerfil"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "EditarPerfil"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        CType(Me.numPeso, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.numAltura, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Panel1 As Panel
    Friend WithEvents Guna2CircleButton1 As Guna.UI2.WinForms.Guna2CircleButton
    Friend WithEvents txtConfirmarContraseña As TextBox
    Friend WithEvents txtContraseña As TextBox
    Friend WithEvents txtTelefono As TextBox
    Friend WithEvents txtEmail As TextBox
    Friend WithEvents txtDireccion As TextBox
    Friend WithEvents Label7 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents numAltura As NumericUpDown
    Friend WithEvents Label11 As Label
    Friend WithEvents Label10 As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents numPeso As NumericUpDown
    Friend WithEvents btnAceptar As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents btnMostrarContraseña As Guna.UI2.WinForms.Guna2CircleButton
    Friend WithEvents Label1 As Label
End Class
