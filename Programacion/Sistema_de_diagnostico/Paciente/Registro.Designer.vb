<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Registro
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Registro))
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.labAtras = New System.Windows.Forms.Label()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.btnRegistro = New System.Windows.Forms.Button()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        Me.txtPrimerNombre = New System.Windows.Forms.TextBox()
        Me.txtTelefono = New System.Windows.Forms.TextBox()
        Me.txtContraseña = New System.Windows.Forms.TextBox()
        Me.txtConfContraseña = New System.Windows.Forms.TextBox()
        Me.txtApellido = New System.Windows.Forms.TextBox()
        Me.txtCI = New System.Windows.Forms.TextBox()
        Me.txtDireccion = New System.Windows.Forms.TextBox()
        Me.txtEmail = New System.Windows.Forms.TextBox()
        Me.cbxSexo = New System.Windows.Forms.ComboBox()
        Me.dateFechaNacimiento = New System.Windows.Forms.DateTimePicker()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.txtSegundoNombre = New System.Windows.Forms.TextBox()
        Me.txtSegundoApellido = New System.Windows.Forms.TextBox()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.numPeso = New System.Windows.Forms.NumericUpDown()
        Me.numAltura = New System.Windows.Forms.NumericUpDown()
        Me.Label16 = New System.Windows.Forms.Label()
        Me.Label17 = New System.Windows.Forms.Label()
        Me.Label18 = New System.Windows.Forms.Label()
        Me.txtPatologiaPrevia = New System.Windows.Forms.TextBox()
        Me.btnMinimizar = New Guna.UI2.WinForms.Guna2CircleButton()
        Me.btnCerrar = New Guna.UI2.WinForms.Guna2CircleButton()
        Me.btnMostrarContraseña = New Guna.UI2.WinForms.Guna2CircleButton()
        Me.Panel1.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.numPeso, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.numAltura, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.FromArgb(CType(CType(40, Byte), Integer), CType(CType(117, Byte), Integer), CType(CType(207, Byte), Integer))
        Me.Panel1.Controls.Add(Me.labAtras)
        Me.Panel1.Controls.Add(Me.Label12)
        Me.Panel1.Controls.Add(Me.Label11)
        Me.Panel1.Controls.Add(Me.btnRegistro)
        Me.Panel1.Controls.Add(Me.PictureBox1)
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(284, 648)
        Me.Panel1.TabIndex = 1
        '
        'labAtras
        '
        Me.labAtras.AutoSize = True
        Me.labAtras.Font = New System.Drawing.Font("Yu Gothic UI", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.labAtras.Location = New System.Drawing.Point(3, 2)
        Me.labAtras.Name = "labAtras"
        Me.labAtras.Size = New System.Drawing.Size(31, 25)
        Me.labAtras.TabIndex = 22
        Me.labAtras.Text = "←"
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label12.ForeColor = System.Drawing.Color.White
        Me.Label12.Location = New System.Drawing.Point(12, 614)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(111, 13)
        Me.Label12.TabIndex = 21
        Me.Label12.Text = "Politicas de privacidad"
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Font = New System.Drawing.Font("Yu Gothic UI Semibold", 21.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.ForeColor = System.Drawing.Color.White
        Me.Label11.Location = New System.Drawing.Point(43, 69)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(185, 40)
        Me.Label11.TabIndex = 20
        Me.Label11.Text = "DiagnosTICK"
        '
        'btnRegistro
        '
        Me.btnRegistro.BackColor = System.Drawing.Color.FromArgb(CType(CType(24, Byte), Integer), CType(CType(69, Byte), Integer), CType(CType(122, Byte), Integer))
        Me.btnRegistro.FlatAppearance.BorderColor = System.Drawing.Color.White
        Me.btnRegistro.FlatAppearance.BorderSize = 0
        Me.btnRegistro.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnRegistro.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.btnRegistro.Location = New System.Drawing.Point(84, 283)
        Me.btnRegistro.Name = "btnRegistro"
        Me.btnRegistro.Size = New System.Drawing.Size(92, 28)
        Me.btnRegistro.TabIndex = 19
        Me.btnRegistro.Text = "Registrarse"
        Me.btnRegistro.UseVisualStyleBackColor = False
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(0, 177)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(284, 289)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 0
        Me.PictureBox1.TabStop = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(291, 86)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(135, 22)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Primer Nombre:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(367, 190)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(56, 22)
        Me.Label2.TabIndex = 9
        Me.Label2.Text = "Sexo:"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(698, 184)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(57, 22)
        Me.Label3.TabIndex = 10
        Me.Label3.Text = "Edad:"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(349, 337)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(86, 22)
        Me.Label4.TabIndex = 11
        Me.Label4.Text = "Teléfono:"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(327, 495)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(108, 22)
        Me.Label5.TabIndex = 12
        Me.Label5.Text = "Contraseña:"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(285, 553)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(191, 22)
        Me.Label6.TabIndex = 13
        Me.Label6.Text = "Confirmar Contraseña:"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(614, 82)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(136, 22)
        Me.Label7.TabIndex = 14
        Me.Label7.Text = "Primer Apellido:"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(427, 239)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(37, 22)
        Me.Label8.TabIndex = 15
        Me.Label8.Text = "C.I:"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.Location = New System.Drawing.Point(665, 239)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(90, 22)
        Me.Label9.TabIndex = 16
        Me.Label9.Text = "Dirección:"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.Location = New System.Drawing.Point(690, 284)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(65, 22)
        Me.Label10.TabIndex = 17
        Me.Label10.Text = "E-mail:"
        '
        'PictureBox2
        '
        Me.PictureBox2.Image = CType(resources.GetObject("PictureBox2.Image"), System.Drawing.Image)
        Me.PictureBox2.Location = New System.Drawing.Point(645, 339)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(334, 309)
        Me.PictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox2.TabIndex = 18
        Me.PictureBox2.TabStop = False
        '
        'txtPrimerNombre
        '
        Me.txtPrimerNombre.Location = New System.Drawing.Point(431, 88)
        Me.txtPrimerNombre.Name = "txtPrimerNombre"
        Me.txtPrimerNombre.Size = New System.Drawing.Size(167, 20)
        Me.txtPrimerNombre.TabIndex = 19
        '
        'txtTelefono
        '
        Me.txtTelefono.Location = New System.Drawing.Point(443, 339)
        Me.txtTelefono.Name = "txtTelefono"
        Me.txtTelefono.Size = New System.Drawing.Size(167, 20)
        Me.txtTelefono.TabIndex = 20
        '
        'txtContraseña
        '
        Me.txtContraseña.Location = New System.Drawing.Point(443, 497)
        Me.txtContraseña.Name = "txtContraseña"
        Me.txtContraseña.Size = New System.Drawing.Size(167, 20)
        Me.txtContraseña.TabIndex = 21
        '
        'txtConfContraseña
        '
        Me.txtConfContraseña.Location = New System.Drawing.Point(472, 555)
        Me.txtConfContraseña.Name = "txtConfContraseña"
        Me.txtConfContraseña.Size = New System.Drawing.Size(167, 20)
        Me.txtConfContraseña.TabIndex = 22
        '
        'txtApellido
        '
        Me.txtApellido.Location = New System.Drawing.Point(756, 84)
        Me.txtApellido.Name = "txtApellido"
        Me.txtApellido.Size = New System.Drawing.Size(200, 20)
        Me.txtApellido.TabIndex = 23
        '
        'txtCI
        '
        Me.txtCI.Location = New System.Drawing.Point(472, 241)
        Me.txtCI.MaxLength = 8
        Me.txtCI.Name = "txtCI"
        Me.txtCI.Size = New System.Drawing.Size(167, 20)
        Me.txtCI.TabIndex = 24
        '
        'txtDireccion
        '
        Me.txtDireccion.Location = New System.Drawing.Point(756, 241)
        Me.txtDireccion.Name = "txtDireccion"
        Me.txtDireccion.Size = New System.Drawing.Size(200, 20)
        Me.txtDireccion.TabIndex = 25
        '
        'txtEmail
        '
        Me.txtEmail.Location = New System.Drawing.Point(756, 291)
        Me.txtEmail.Name = "txtEmail"
        Me.txtEmail.Size = New System.Drawing.Size(200, 20)
        Me.txtEmail.TabIndex = 26
        '
        'cbxSexo
        '
        Me.cbxSexo.FormattingEnabled = True
        Me.cbxSexo.Items.AddRange(New Object() {"H", "M"})
        Me.cbxSexo.Location = New System.Drawing.Point(431, 190)
        Me.cbxSexo.Name = "cbxSexo"
        Me.cbxSexo.Size = New System.Drawing.Size(45, 21)
        Me.cbxSexo.TabIndex = 27
        '
        'dateFechaNacimiento
        '
        Me.dateFechaNacimiento.Location = New System.Drawing.Point(756, 187)
        Me.dateFechaNacimiento.Name = "dateFechaNacimiento"
        Me.dateFechaNacimiento.Size = New System.Drawing.Size(200, 20)
        Me.dateFechaNacimiento.TabIndex = 28
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label14.Location = New System.Drawing.Point(285, 132)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(155, 22)
        Me.Label14.TabIndex = 29
        Me.Label14.Text = "Segundo Nombre:"
        '
        'txtSegundoNombre
        '
        Me.txtSegundoNombre.Location = New System.Drawing.Point(443, 134)
        Me.txtSegundoNombre.Name = "txtSegundoNombre"
        Me.txtSegundoNombre.Size = New System.Drawing.Size(167, 20)
        Me.txtSegundoNombre.TabIndex = 30
        '
        'txtSegundoApellido
        '
        Me.txtSegundoApellido.Location = New System.Drawing.Point(765, 134)
        Me.txtSegundoApellido.Name = "txtSegundoApellido"
        Me.txtSegundoApellido.Size = New System.Drawing.Size(191, 20)
        Me.txtSegundoApellido.TabIndex = 32
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label15.Location = New System.Drawing.Point(611, 132)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(156, 22)
        Me.Label15.TabIndex = 31
        Me.Label15.Text = "Segundo Apellido:"
        '
        'numPeso
        '
        Me.numPeso.Location = New System.Drawing.Point(407, 292)
        Me.numPeso.Name = "numPeso"
        Me.numPeso.Size = New System.Drawing.Size(57, 20)
        Me.numPeso.TabIndex = 33
        '
        'numAltura
        '
        Me.numAltura.DecimalPlaces = 2
        Me.numAltura.Location = New System.Drawing.Point(584, 292)
        Me.numAltura.Name = "numAltura"
        Me.numAltura.Size = New System.Drawing.Size(55, 20)
        Me.numAltura.TabIndex = 34
        '
        'Label16
        '
        Me.Label16.AutoSize = True
        Me.Label16.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label16.Location = New System.Drawing.Point(345, 289)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(56, 22)
        Me.Label16.TabIndex = 35
        Me.Label16.Text = "Peso:"
        '
        'Label17
        '
        Me.Label17.AutoSize = True
        Me.Label17.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label17.Location = New System.Drawing.Point(520, 289)
        Me.Label17.Name = "Label17"
        Me.Label17.Size = New System.Drawing.Size(62, 22)
        Me.Label17.TabIndex = 36
        Me.Label17.Text = "Altura:"
        '
        'Label18
        '
        Me.Label18.AutoSize = True
        Me.Label18.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label18.Location = New System.Drawing.Point(291, 379)
        Me.Label18.Name = "Label18"
        Me.Label18.Size = New System.Drawing.Size(162, 22)
        Me.Label18.TabIndex = 37
        Me.Label18.Text = "Patologías previas:"
        '
        'txtPatologiaPrevia
        '
        Me.txtPatologiaPrevia.Location = New System.Drawing.Point(301, 404)
        Me.txtPatologiaPrevia.Multiline = True
        Me.txtPatologiaPrevia.Name = "txtPatologiaPrevia"
        Me.txtPatologiaPrevia.Size = New System.Drawing.Size(309, 69)
        Me.txtPatologiaPrevia.TabIndex = 38
        '
        'btnMinimizar
        '
        Me.btnMinimizar.Animated = True
        Me.btnMinimizar.BackColor = System.Drawing.Color.Transparent
        Me.btnMinimizar.CheckedState.Parent = Me.btnMinimizar
        Me.btnMinimizar.CustomImages.Parent = Me.btnMinimizar
        Me.btnMinimizar.FillColor = System.Drawing.Color.Gray
        Me.btnMinimizar.Font = New System.Drawing.Font("Segoe UI", 25.0!)
        Me.btnMinimizar.ForeColor = System.Drawing.Color.White
        Me.btnMinimizar.HoverState.Parent = Me.btnMinimizar
        Me.btnMinimizar.Location = New System.Drawing.Point(915, 1)
        Me.btnMinimizar.Name = "btnMinimizar"
        Me.btnMinimizar.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle
        Me.btnMinimizar.ShadowDecoration.Parent = Me.btnMinimizar
        Me.btnMinimizar.Size = New System.Drawing.Size(29, 30)
        Me.btnMinimizar.TabIndex = 52
        Me.btnMinimizar.Text = "-"
        Me.btnMinimizar.UseTransparentBackground = True
        '
        'btnCerrar
        '
        Me.btnCerrar.Animated = True
        Me.btnCerrar.BackColor = System.Drawing.Color.Transparent
        Me.btnCerrar.CheckedState.Parent = Me.btnCerrar
        Me.btnCerrar.CustomImages.Parent = Me.btnCerrar
        Me.btnCerrar.FillColor = System.Drawing.Color.DarkRed
        Me.btnCerrar.Font = New System.Drawing.Font("Segoe UI", 12.0!)
        Me.btnCerrar.ForeColor = System.Drawing.Color.White
        Me.btnCerrar.HoverState.Parent = Me.btnCerrar
        Me.btnCerrar.Location = New System.Drawing.Point(950, 1)
        Me.btnCerrar.Name = "btnCerrar"
        Me.btnCerrar.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle
        Me.btnCerrar.ShadowDecoration.Parent = Me.btnCerrar
        Me.btnCerrar.Size = New System.Drawing.Size(29, 30)
        Me.btnCerrar.TabIndex = 51
        Me.btnCerrar.Text = "X"
        Me.btnCerrar.UseTransparentBackground = True
        '
        'btnMostrarContraseña
        '
        Me.btnMostrarContraseña.CheckedState.Parent = Me.btnMostrarContraseña
        Me.btnMostrarContraseña.CustomImages.Parent = Me.btnMostrarContraseña
        Me.btnMostrarContraseña.FillColor = System.Drawing.Color.Green
        Me.btnMostrarContraseña.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.btnMostrarContraseña.ForeColor = System.Drawing.Color.White
        Me.btnMostrarContraseña.HoverState.Parent = Me.btnMostrarContraseña
        Me.btnMostrarContraseña.Location = New System.Drawing.Point(618, 495)
        Me.btnMostrarContraseña.Name = "btnMostrarContraseña"
        Me.btnMostrarContraseña.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle
        Me.btnMostrarContraseña.ShadowDecoration.Parent = Me.btnMostrarContraseña
        Me.btnMostrarContraseña.Size = New System.Drawing.Size(21, 22)
        Me.btnMostrarContraseña.TabIndex = 53
        '
        'Registro
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(980, 645)
        Me.Controls.Add(Me.btnMostrarContraseña)
        Me.Controls.Add(Me.btnMinimizar)
        Me.Controls.Add(Me.btnCerrar)
        Me.Controls.Add(Me.txtPatologiaPrevia)
        Me.Controls.Add(Me.Label18)
        Me.Controls.Add(Me.Label17)
        Me.Controls.Add(Me.Label16)
        Me.Controls.Add(Me.numAltura)
        Me.Controls.Add(Me.numPeso)
        Me.Controls.Add(Me.txtSegundoApellido)
        Me.Controls.Add(Me.Label15)
        Me.Controls.Add(Me.txtSegundoNombre)
        Me.Controls.Add(Me.Label14)
        Me.Controls.Add(Me.dateFechaNacimiento)
        Me.Controls.Add(Me.cbxSexo)
        Me.Controls.Add(Me.txtEmail)
        Me.Controls.Add(Me.txtDireccion)
        Me.Controls.Add(Me.txtCI)
        Me.Controls.Add(Me.txtApellido)
        Me.Controls.Add(Me.txtConfContraseña)
        Me.Controls.Add(Me.txtContraseña)
        Me.Controls.Add(Me.txtTelefono)
        Me.Controls.Add(Me.txtPrimerNombre)
        Me.Controls.Add(Me.PictureBox2)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Panel1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.MaximumSize = New System.Drawing.Size(980, 645)
        Me.MinimumSize = New System.Drawing.Size(980, 645)
        Me.Name = "Registro"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.numPeso, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.numAltura, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Panel1 As Panel
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents Label10 As Label
    Friend WithEvents PictureBox2 As PictureBox
    Friend WithEvents btnRegistro As Button
    Friend WithEvents txtPrimerNombre As TextBox
    Friend WithEvents txtTelefono As TextBox
    Friend WithEvents txtContraseña As TextBox
    Friend WithEvents txtConfContraseña As TextBox
    Friend WithEvents txtApellido As TextBox
    Friend WithEvents txtCI As TextBox
    Friend WithEvents txtDireccion As TextBox
    Friend WithEvents txtEmail As TextBox
    Friend WithEvents cbxSexo As ComboBox
    Friend WithEvents Label11 As Label
    Friend WithEvents Label12 As Label
    Friend WithEvents labAtras As Label
    Friend WithEvents dateFechaNacimiento As DateTimePicker
    Friend WithEvents Label14 As Label
    Friend WithEvents txtSegundoNombre As TextBox
    Friend WithEvents txtSegundoApellido As TextBox
    Friend WithEvents Label15 As Label
    Friend WithEvents numPeso As NumericUpDown
    Friend WithEvents numAltura As NumericUpDown
    Friend WithEvents Label16 As Label
    Friend WithEvents Label17 As Label
    Friend WithEvents Label18 As Label
    Friend WithEvents txtPatologiaPrevia As TextBox
    Friend WithEvents btnMinimizar As Guna.UI2.WinForms.Guna2CircleButton
    Friend WithEvents btnCerrar As Guna.UI2.WinForms.Guna2CircleButton
    Friend WithEvents btnMostrarContraseña As Guna.UI2.WinForms.Guna2CircleButton
End Class
