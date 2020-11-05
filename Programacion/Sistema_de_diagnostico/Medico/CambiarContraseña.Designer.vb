<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class CambiarContraseña
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
        Me.btnAceptar = New Guna.UI2.WinForms.Guna2Button()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txtConfirmarContraseña = New Guna.UI2.WinForms.Guna2TextBox()
        Me.txtContraseña = New Guna.UI2.WinForms.Guna2TextBox()
        Me.btnCerrar = New Guna.UI2.WinForms.Guna2CircleButton()
        Me.btnMostrarContraseña = New Guna.UI2.WinForms.Guna2CircleButton()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Panel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.White
        Me.Panel1.Controls.Add(Me.Label3)
        Me.Panel1.Controls.Add(Me.btnMostrarContraseña)
        Me.Panel1.Controls.Add(Me.btnAceptar)
        Me.Panel1.Controls.Add(Me.Label2)
        Me.Panel1.Controls.Add(Me.Label1)
        Me.Panel1.Controls.Add(Me.txtConfirmarContraseña)
        Me.Panel1.Controls.Add(Me.txtContraseña)
        Me.Panel1.Location = New System.Drawing.Point(0, 29)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(426, 151)
        Me.Panel1.TabIndex = 0
        '
        'btnAceptar
        '
        Me.btnAceptar.Animated = True
        Me.btnAceptar.AutoRoundedCorners = True
        Me.btnAceptar.BorderRadius = 21
        Me.btnAceptar.CheckedState.Parent = Me.btnAceptar
        Me.btnAceptar.CustomImages.Parent = Me.btnAceptar
        Me.btnAceptar.FillColor = System.Drawing.Color.FromArgb(CType(CType(38, Byte), Integer), CType(CType(131, Byte), Integer), CType(CType(108, Byte), Integer))
        Me.btnAceptar.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.btnAceptar.ForeColor = System.Drawing.Color.White
        Me.btnAceptar.HoverState.Parent = Me.btnAceptar
        Me.btnAceptar.Location = New System.Drawing.Point(299, 96)
        Me.btnAceptar.Name = "btnAceptar"
        Me.btnAceptar.ShadowDecoration.Parent = Me.btnAceptar
        Me.btnAceptar.Size = New System.Drawing.Size(115, 45)
        Me.btnAceptar.TabIndex = 5
        Me.btnAceptar.Text = "Aceptar"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(55, 75)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(166, 20)
        Me.Label2.TabIndex = 4
        Me.Label2.Text = "Confirmar contraseña:"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(55, 6)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(143, 20)
        Me.Label1.TabIndex = 3
        Me.Label1.Text = "Contraseña nueva:"
        '
        'txtConfirmarContraseña
        '
        Me.txtConfirmarContraseña.AutoRoundedCorners = True
        Me.txtConfirmarContraseña.BorderRadius = 17
        Me.txtConfirmarContraseña.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtConfirmarContraseña.DefaultText = ""
        Me.txtConfirmarContraseña.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.txtConfirmarContraseña.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.txtConfirmarContraseña.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txtConfirmarContraseña.DisabledState.Parent = Me.txtConfirmarContraseña
        Me.txtConfirmarContraseña.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txtConfirmarContraseña.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txtConfirmarContraseña.FocusedState.Parent = Me.txtConfirmarContraseña
        Me.txtConfirmarContraseña.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.txtConfirmarContraseña.ForeColor = System.Drawing.Color.Black
        Me.txtConfirmarContraseña.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txtConfirmarContraseña.HoverState.Parent = Me.txtConfirmarContraseña
        Me.txtConfirmarContraseña.Location = New System.Drawing.Point(44, 96)
        Me.txtConfirmarContraseña.Name = "txtConfirmarContraseña"
        Me.txtConfirmarContraseña.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtConfirmarContraseña.PlaceholderText = ""
        Me.txtConfirmarContraseña.SelectedText = ""
        Me.txtConfirmarContraseña.ShadowDecoration.Parent = Me.txtConfirmarContraseña
        Me.txtConfirmarContraseña.Size = New System.Drawing.Size(200, 36)
        Me.txtConfirmarContraseña.TabIndex = 1
        Me.txtConfirmarContraseña.UseSystemPasswordChar = True
        '
        'txtContraseña
        '
        Me.txtContraseña.AutoRoundedCorners = True
        Me.txtContraseña.BorderRadius = 17
        Me.txtContraseña.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtContraseña.DefaultText = ""
        Me.txtContraseña.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.txtContraseña.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.txtContraseña.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txtContraseña.DisabledState.Parent = Me.txtContraseña
        Me.txtContraseña.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txtContraseña.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txtContraseña.FocusedState.Parent = Me.txtContraseña
        Me.txtContraseña.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.txtContraseña.ForeColor = System.Drawing.Color.Black
        Me.txtContraseña.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txtContraseña.HoverState.Parent = Me.txtContraseña
        Me.txtContraseña.Location = New System.Drawing.Point(44, 26)
        Me.txtContraseña.Name = "txtContraseña"
        Me.txtContraseña.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtContraseña.PlaceholderText = ""
        Me.txtContraseña.SelectedText = ""
        Me.txtContraseña.ShadowDecoration.Parent = Me.txtContraseña
        Me.txtContraseña.Size = New System.Drawing.Size(200, 36)
        Me.txtContraseña.TabIndex = 0
        Me.txtContraseña.UseSystemPasswordChar = True
        '
        'btnCerrar
        '
        Me.btnCerrar.CheckedState.Parent = Me.btnCerrar
        Me.btnCerrar.CustomImages.Parent = Me.btnCerrar
        Me.btnCerrar.FillColor = System.Drawing.Color.FromArgb(CType(CType(38, Byte), Integer), CType(CType(131, Byte), Integer), CType(CType(108, Byte), Integer))
        Me.btnCerrar.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.btnCerrar.ForeColor = System.Drawing.Color.White
        Me.btnCerrar.HoverState.Parent = Me.btnCerrar
        Me.btnCerrar.Location = New System.Drawing.Point(391, 2)
        Me.btnCerrar.Name = "btnCerrar"
        Me.btnCerrar.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle
        Me.btnCerrar.ShadowDecoration.Parent = Me.btnCerrar
        Me.btnCerrar.Size = New System.Drawing.Size(29, 26)
        Me.btnCerrar.TabIndex = 6
        Me.btnCerrar.Text = "X"
        '
        'btnMostrarContraseña
        '
        Me.btnMostrarContraseña.CheckedState.Parent = Me.btnMostrarContraseña
        Me.btnMostrarContraseña.CustomImages.Parent = Me.btnMostrarContraseña
        Me.btnMostrarContraseña.FillColor = System.Drawing.Color.Green
        Me.btnMostrarContraseña.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.btnMostrarContraseña.ForeColor = System.Drawing.Color.White
        Me.btnMostrarContraseña.HoverState.Parent = Me.btnMostrarContraseña
        Me.btnMostrarContraseña.Location = New System.Drawing.Point(256, 31)
        Me.btnMostrarContraseña.Name = "btnMostrarContraseña"
        Me.btnMostrarContraseña.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle
        Me.btnMostrarContraseña.ShadowDecoration.Parent = Me.btnMostrarContraseña
        Me.btnMostrarContraseña.Size = New System.Drawing.Size(21, 22)
        Me.btnMostrarContraseña.TabIndex = 25
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.Gray
        Me.Label3.Location = New System.Drawing.Point(283, 36)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(98, 13)
        Me.Label3.TabIndex = 26
        Me.Label3.Text = "Mostrar contraseña"
        '
        'CambiarContraseña
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(50, Byte), Integer), CType(CType(174, Byte), Integer), CType(CType(144, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(423, 181)
        Me.Controls.Add(Me.btnCerrar)
        Me.Controls.Add(Me.Panel1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "CambiarContraseña"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "CambiarContraseña"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Panel1 As Panel
    Friend WithEvents txtContraseña As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents btnAceptar As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents txtConfirmarContraseña As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents btnCerrar As Guna.UI2.WinForms.Guna2CircleButton
    Friend WithEvents btnMostrarContraseña As Guna.UI2.WinForms.Guna2CircleButton
    Friend WithEvents Label3 As Label
End Class
