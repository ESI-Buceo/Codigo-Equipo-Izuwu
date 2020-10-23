<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class LoginGNew
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(LoginGNew))
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.btnEntrar = New Guna.UI2.WinForms.Guna2Button()
        Me.txtContraseña = New Guna.UI2.WinForms.Guna2TextBox()
        Me.txtUsuario = New Guna.UI2.WinForms.Guna2TextBox()
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.Guna2ControlBox1 = New Guna.UI2.WinForms.Guna2ControlBox()
        Me.Guna2ControlBox2 = New Guna.UI2.WinForms.Guna2ControlBox()
        Me.Panel1.SuspendLayout()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.FromArgb(CType(CType(48, Byte), Integer), CType(CType(48, Byte), Integer), CType(CType(48, Byte), Integer))
        Me.Panel1.Controls.Add(Me.btnEntrar)
        Me.Panel1.Controls.Add(Me.txtContraseña)
        Me.Panel1.Controls.Add(Me.txtUsuario)
        Me.Panel1.Controls.Add(Me.PictureBox2)
        Me.Panel1.Controls.Add(Me.Label4)
        Me.Panel1.Controls.Add(Me.Label3)
        Me.Panel1.Controls.Add(Me.Label2)
        Me.Panel1.Controls.Add(Me.Label5)
        Me.Panel1.Location = New System.Drawing.Point(-1, -2)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(284, 648)
        Me.Panel1.TabIndex = 0
        '
        'btnEntrar
        '
        Me.btnEntrar.Animated = True
        Me.btnEntrar.AutoRoundedCorners = True
        Me.btnEntrar.BorderRadius = 18
        Me.btnEntrar.CheckedState.Parent = Me.btnEntrar
        Me.btnEntrar.CustomImages.Parent = Me.btnEntrar
        Me.btnEntrar.FillColor = System.Drawing.Color.FromArgb(CType(CType(36, Byte), Integer), CType(CType(36, Byte), Integer), CType(CType(36, Byte), Integer))
        Me.btnEntrar.Font = New System.Drawing.Font("Yu Gothic UI", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnEntrar.ForeColor = System.Drawing.Color.White
        Me.btnEntrar.HoverState.Parent = Me.btnEntrar
        Me.btnEntrar.Location = New System.Drawing.Point(66, 437)
        Me.btnEntrar.Name = "btnEntrar"
        Me.btnEntrar.ShadowDecoration.Parent = Me.btnEntrar
        Me.btnEntrar.Size = New System.Drawing.Size(107, 38)
        Me.btnEntrar.TabIndex = 21
        Me.btnEntrar.Text = "Entrar"
        '
        'txtContraseña
        '
        Me.txtContraseña.AutoRoundedCorners = True
        Me.txtContraseña.BorderRadius = 11
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
        Me.txtContraseña.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txtContraseña.HoverState.Parent = Me.txtContraseña
        Me.txtContraseña.Location = New System.Drawing.Point(13, 291)
        Me.txtContraseña.Name = "txtContraseña"
        Me.txtContraseña.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtContraseña.PlaceholderForeColor = System.Drawing.Color.Silver
        Me.txtContraseña.PlaceholderText = "Ingrese contraseña..."
        Me.txtContraseña.SelectedText = ""
        Me.txtContraseña.ShadowDecoration.Parent = Me.txtContraseña
        Me.txtContraseña.Size = New System.Drawing.Size(192, 25)
        Me.txtContraseña.TabIndex = 20
        '
        'txtUsuario
        '
        Me.txtUsuario.AutoRoundedCorners = True
        Me.txtUsuario.BorderRadius = 11
        Me.txtUsuario.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtUsuario.DefaultText = ""
        Me.txtUsuario.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.txtUsuario.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.txtUsuario.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txtUsuario.DisabledState.Parent = Me.txtUsuario
        Me.txtUsuario.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txtUsuario.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txtUsuario.FocusedState.Parent = Me.txtUsuario
        Me.txtUsuario.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.txtUsuario.ForeColor = System.Drawing.Color.Black
        Me.txtUsuario.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txtUsuario.HoverState.Parent = Me.txtUsuario
        Me.txtUsuario.Location = New System.Drawing.Point(13, 219)
        Me.txtUsuario.Name = "txtUsuario"
        Me.txtUsuario.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtUsuario.PlaceholderForeColor = System.Drawing.Color.Silver
        Me.txtUsuario.PlaceholderText = "Ingrese su CI..."
        Me.txtUsuario.SelectedText = ""
        Me.txtUsuario.ShadowDecoration.Parent = Me.txtUsuario
        Me.txtUsuario.Size = New System.Drawing.Size(192, 25)
        Me.txtUsuario.TabIndex = 19
        '
        'PictureBox2
        '
        Me.PictureBox2.Dock = System.Windows.Forms.DockStyle.Top
        Me.PictureBox2.Image = CType(resources.GetObject("PictureBox2.Image"), System.Drawing.Image)
        Me.PictureBox2.Location = New System.Drawing.Point(0, 0)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(284, 179)
        Me.PictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox2.TabIndex = 18
        Me.PictureBox2.TabStop = False
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.White
        Me.Label4.Location = New System.Drawing.Point(13, 319)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(130, 13)
        Me.Label4.TabIndex = 13
        Me.Label4.Text = "¿Olvidaste tu contraseña?"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.White
        Me.Label3.Location = New System.Drawing.Point(10, 273)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(70, 15)
        Me.Label3.TabIndex = 11
        Me.Label3.Text = "Contraseña"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.White
        Me.Label2.Location = New System.Drawing.Point(10, 201)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(69, 15)
        Me.Label2.TabIndex = 9
        Me.Label2.Text = "Usuario(CI)"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.Color.White
        Me.Label5.Location = New System.Drawing.Point(12, 613)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(111, 13)
        Me.Label5.TabIndex = 7
        Me.Label5.Text = "Politicas de privacidad"
        '
        'PictureBox1
        '
        Me.PictureBox1.Enabled = False
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(247, -3)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(768, 652)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 5
        Me.PictureBox1.TabStop = False
        '
        'Guna2ControlBox1
        '
        Me.Guna2ControlBox1.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Guna2ControlBox1.BackColor = System.Drawing.Color.Transparent
        Me.Guna2ControlBox1.ControlBoxType = Guna.UI2.WinForms.Enums.ControlBoxType.MinimizeBox
        Me.Guna2ControlBox1.FillColor = System.Drawing.Color.Silver
        Me.Guna2ControlBox1.HoverState.FillColor = System.Drawing.Color.Gray
        Me.Guna2ControlBox1.HoverState.Parent = Me.Guna2ControlBox1
        Me.Guna2ControlBox1.IconColor = System.Drawing.Color.Black
        Me.Guna2ControlBox1.Location = New System.Drawing.Point(891, -3)
        Me.Guna2ControlBox1.Name = "Guna2ControlBox1"
        Me.Guna2ControlBox1.ShadowDecoration.Parent = Me.Guna2ControlBox1
        Me.Guna2ControlBox1.Size = New System.Drawing.Size(45, 29)
        Me.Guna2ControlBox1.TabIndex = 45
        '
        'Guna2ControlBox2
        '
        Me.Guna2ControlBox2.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Guna2ControlBox2.BackColor = System.Drawing.Color.Transparent
        Me.Guna2ControlBox2.FillColor = System.Drawing.Color.IndianRed
        Me.Guna2ControlBox2.HoverState.FillColor = System.Drawing.Color.Red
        Me.Guna2ControlBox2.HoverState.Parent = Me.Guna2ControlBox2
        Me.Guna2ControlBox2.IconColor = System.Drawing.Color.Black
        Me.Guna2ControlBox2.Location = New System.Drawing.Point(936, -3)
        Me.Guna2ControlBox2.Name = "Guna2ControlBox2"
        Me.Guna2ControlBox2.ShadowDecoration.Parent = Me.Guna2ControlBox2
        Me.Guna2ControlBox2.Size = New System.Drawing.Size(45, 29)
        Me.Guna2ControlBox2.TabIndex = 46
        '
        'LoginGNew
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.ClientSize = New System.Drawing.Size(980, 645)
        Me.Controls.Add(Me.Guna2ControlBox1)
        Me.Controls.Add(Me.Guna2ControlBox2)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.PictureBox1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.MaximumSize = New System.Drawing.Size(980, 645)
        Me.MinimizeBox = False
        Me.MinimumSize = New System.Drawing.Size(980, 645)
        Me.Name = "LoginGNew"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "LoginNew"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Panel1 As Panel
    Friend WithEvents Label5 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents PictureBox2 As PictureBox
    Friend WithEvents txtUsuario As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents txtContraseña As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents btnEntrar As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents Guna2ControlBox1 As Guna.UI2.WinForms.Guna2ControlBox
    Friend WithEvents Guna2ControlBox2 As Guna.UI2.WinForms.Guna2ControlBox
End Class
