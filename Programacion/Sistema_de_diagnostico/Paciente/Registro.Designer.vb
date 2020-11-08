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
        Me.PictureBox3 = New System.Windows.Forms.PictureBox()
        Me.btnRegistro = New Guna.UI2.WinForms.Guna2Button()
        Me.Label12 = New System.Windows.Forms.Label()
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
        Me.dateFechaNacimiento = New System.Windows.Forms.DateTimePicker()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.Label16 = New System.Windows.Forms.Label()
        Me.Label17 = New System.Windows.Forms.Label()
        Me.Label18 = New System.Windows.Forms.Label()
        Me.btnMinimizar = New Guna.UI2.WinForms.Guna2CircleButton()
        Me.btnCerrar = New Guna.UI2.WinForms.Guna2CircleButton()
        Me.btnMostrarContraseña = New Guna.UI2.WinForms.Guna2CircleButton()
        Me.txtPrimerNombre = New Guna.UI2.WinForms.Guna2TextBox()
        Me.txtApellido = New Guna.UI2.WinForms.Guna2TextBox()
        Me.txtSegundoNombre = New Guna.UI2.WinForms.Guna2TextBox()
        Me.txtSegundoApellido = New Guna.UI2.WinForms.Guna2TextBox()
        Me.txtCI = New Guna.UI2.WinForms.Guna2TextBox()
        Me.txtDireccion = New Guna.UI2.WinForms.Guna2TextBox()
        Me.txtEmail = New Guna.UI2.WinForms.Guna2TextBox()
        Me.txtTelefono = New Guna.UI2.WinForms.Guna2TextBox()
        Me.txtContraseña = New Guna.UI2.WinForms.Guna2TextBox()
        Me.txtConfContraseña = New Guna.UI2.WinForms.Guna2TextBox()
        Me.txtPatologiaPrevia = New Guna.UI2.WinForms.Guna2TextBox()
        Me.numPeso = New Guna.UI2.WinForms.Guna2NumericUpDown()
        Me.numAltura = New Guna.UI2.WinForms.Guna2NumericUpDown()
        Me.cbxSexo = New Guna.UI2.WinForms.Guna2ComboBox()
        Me.Panel1.SuspendLayout()
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.numPeso, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.numAltura, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.FromArgb(CType(CType(40, Byte), Integer), CType(CType(117, Byte), Integer), CType(CType(207, Byte), Integer))
        Me.Panel1.Controls.Add(Me.PictureBox3)
        Me.Panel1.Controls.Add(Me.btnRegistro)
        Me.Panel1.Controls.Add(Me.Label12)
        Me.Panel1.Controls.Add(Me.PictureBox1)
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(284, 648)
        Me.Panel1.TabIndex = 1
        '
        'PictureBox3
        '
        Me.PictureBox3.Dock = System.Windows.Forms.DockStyle.Top
        Me.PictureBox3.Image = CType(resources.GetObject("PictureBox3.Image"), System.Drawing.Image)
        Me.PictureBox3.Location = New System.Drawing.Point(0, 0)
        Me.PictureBox3.Name = "PictureBox3"
        Me.PictureBox3.Size = New System.Drawing.Size(284, 179)
        Me.PictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox3.TabIndex = 70
        Me.PictureBox3.TabStop = False
        '
        'btnRegistro
        '
        Me.btnRegistro.Animated = True
        Me.btnRegistro.AutoRoundedCorners = True
        Me.btnRegistro.BackColor = System.Drawing.Color.FromArgb(CType(CType(40, Byte), Integer), CType(CType(117, Byte), Integer), CType(CType(207, Byte), Integer))
        Me.btnRegistro.BorderRadius = 18
        Me.btnRegistro.CheckedState.Parent = Me.btnRegistro
        Me.btnRegistro.CustomImages.Parent = Me.btnRegistro
        Me.btnRegistro.FillColor = System.Drawing.Color.FromArgb(CType(CType(24, Byte), Integer), CType(CType(69, Byte), Integer), CType(CType(122, Byte), Integer))
        Me.btnRegistro.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.btnRegistro.ForeColor = System.Drawing.Color.White
        Me.btnRegistro.HoverState.Parent = Me.btnRegistro
        Me.btnRegistro.Location = New System.Drawing.Point(73, 311)
        Me.btnRegistro.Name = "btnRegistro"
        Me.btnRegistro.ShadowDecoration.Parent = Me.btnRegistro
        Me.btnRegistro.Size = New System.Drawing.Size(116, 38)
        Me.btnRegistro.TabIndex = 69
        Me.btnRegistro.Text = "Registrarse"
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
        Me.Label2.Location = New System.Drawing.Point(554, 184)
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
        Me.Label4.Location = New System.Drawing.Point(292, 284)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(86, 22)
        Me.Label4.TabIndex = 11
        Me.Label4.Text = "Teléfono:"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(301, 495)
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
        Me.Label7.Location = New System.Drawing.Point(290, 133)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(136, 22)
        Me.Label7.TabIndex = 14
        Me.Label7.Text = "Primer Apellido:"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(290, 184)
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
        Me.Label10.Location = New System.Drawing.Point(641, 286)
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
        'dateFechaNacimiento
        '
        Me.dateFechaNacimiento.Location = New System.Drawing.Point(756, 185)
        Me.dateFechaNacimiento.Name = "dateFechaNacimiento"
        Me.dateFechaNacimiento.Size = New System.Drawing.Size(200, 20)
        Me.dateFechaNacimiento.TabIndex = 60
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label14.Location = New System.Drawing.Point(628, 86)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(155, 22)
        Me.Label14.TabIndex = 29
        Me.Label14.Text = "Segundo Nombre:"
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label15.Location = New System.Drawing.Point(627, 132)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(156, 22)
        Me.Label15.TabIndex = 31
        Me.Label15.Text = "Segundo Apellido:"
        '
        'Label16
        '
        Me.Label16.AutoSize = True
        Me.Label16.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label16.Location = New System.Drawing.Point(334, 239)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(56, 22)
        Me.Label16.TabIndex = 35
        Me.Label16.Text = "Peso:"
        '
        'Label17
        '
        Me.Label17.AutoSize = True
        Me.Label17.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label17.Location = New System.Drawing.Point(506, 238)
        Me.Label17.Name = "Label17"
        Me.Label17.Size = New System.Drawing.Size(62, 22)
        Me.Label17.TabIndex = 36
        Me.Label17.Text = "Altura:"
        '
        'Label18
        '
        Me.Label18.AutoSize = True
        Me.Label18.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label18.Location = New System.Drawing.Point(291, 339)
        Me.Label18.Name = "Label18"
        Me.Label18.Size = New System.Drawing.Size(162, 22)
        Me.Label18.TabIndex = 37
        Me.Label18.Text = "Patologías previas:"
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
        'txtPrimerNombre
        '
        Me.txtPrimerNombre.AutoRoundedCorners = True
        Me.txtPrimerNombre.BorderRadius = 11
        Me.txtPrimerNombre.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtPrimerNombre.DefaultText = ""
        Me.txtPrimerNombre.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.txtPrimerNombre.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.txtPrimerNombre.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txtPrimerNombre.DisabledState.Parent = Me.txtPrimerNombre
        Me.txtPrimerNombre.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txtPrimerNombre.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txtPrimerNombre.FocusedState.Parent = Me.txtPrimerNombre
        Me.txtPrimerNombre.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.txtPrimerNombre.ForeColor = System.Drawing.Color.FromArgb(CType(CType(213, Byte), Integer), CType(CType(218, Byte), Integer), CType(CType(223, Byte), Integer))
        Me.txtPrimerNombre.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txtPrimerNombre.HoverState.Parent = Me.txtPrimerNombre
        Me.txtPrimerNombre.Location = New System.Drawing.Point(431, 86)
        Me.txtPrimerNombre.Name = "txtPrimerNombre"
        Me.txtPrimerNombre.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtPrimerNombre.PlaceholderText = ""
        Me.txtPrimerNombre.SelectedText = ""
        Me.txtPrimerNombre.ShadowDecoration.Parent = Me.txtPrimerNombre
        Me.txtPrimerNombre.Size = New System.Drawing.Size(191, 25)
        Me.txtPrimerNombre.TabIndex = 54
        '
        'txtApellido
        '
        Me.txtApellido.AutoRoundedCorners = True
        Me.txtApellido.BorderRadius = 11
        Me.txtApellido.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtApellido.DefaultText = ""
        Me.txtApellido.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.txtApellido.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.txtApellido.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txtApellido.DisabledState.Parent = Me.txtApellido
        Me.txtApellido.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txtApellido.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txtApellido.FocusedState.Parent = Me.txtApellido
        Me.txtApellido.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.txtApellido.ForeColor = System.Drawing.Color.Black
        Me.txtApellido.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txtApellido.HoverState.Parent = Me.txtApellido
        Me.txtApellido.Location = New System.Drawing.Point(431, 132)
        Me.txtApellido.Name = "txtApellido"
        Me.txtApellido.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtApellido.PlaceholderText = ""
        Me.txtApellido.SelectedText = ""
        Me.txtApellido.ShadowDecoration.Parent = Me.txtApellido
        Me.txtApellido.Size = New System.Drawing.Size(193, 25)
        Me.txtApellido.TabIndex = 56
        '
        'txtSegundoNombre
        '
        Me.txtSegundoNombre.AutoRoundedCorners = True
        Me.txtSegundoNombre.BorderRadius = 11
        Me.txtSegundoNombre.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtSegundoNombre.DefaultText = ""
        Me.txtSegundoNombre.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.txtSegundoNombre.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.txtSegundoNombre.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txtSegundoNombre.DisabledState.Parent = Me.txtSegundoNombre
        Me.txtSegundoNombre.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txtSegundoNombre.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txtSegundoNombre.FocusedState.Parent = Me.txtSegundoNombre
        Me.txtSegundoNombre.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.txtSegundoNombre.ForeColor = System.Drawing.Color.Black
        Me.txtSegundoNombre.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txtSegundoNombre.HoverState.Parent = Me.txtSegundoNombre
        Me.txtSegundoNombre.Location = New System.Drawing.Point(780, 86)
        Me.txtSegundoNombre.Name = "txtSegundoNombre"
        Me.txtSegundoNombre.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtSegundoNombre.PlaceholderText = ""
        Me.txtSegundoNombre.SelectedText = ""
        Me.txtSegundoNombre.ShadowDecoration.Parent = Me.txtSegundoNombre
        Me.txtSegundoNombre.Size = New System.Drawing.Size(191, 25)
        Me.txtSegundoNombre.TabIndex = 55
        '
        'txtSegundoApellido
        '
        Me.txtSegundoApellido.AutoRoundedCorners = True
        Me.txtSegundoApellido.BorderRadius = 11
        Me.txtSegundoApellido.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtSegundoApellido.DefaultText = ""
        Me.txtSegundoApellido.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.txtSegundoApellido.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.txtSegundoApellido.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txtSegundoApellido.DisabledState.Parent = Me.txtSegundoApellido
        Me.txtSegundoApellido.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txtSegundoApellido.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txtSegundoApellido.FocusedState.Parent = Me.txtSegundoApellido
        Me.txtSegundoApellido.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.txtSegundoApellido.ForeColor = System.Drawing.Color.Black
        Me.txtSegundoApellido.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txtSegundoApellido.HoverState.Parent = Me.txtSegundoApellido
        Me.txtSegundoApellido.Location = New System.Drawing.Point(780, 133)
        Me.txtSegundoApellido.Name = "txtSegundoApellido"
        Me.txtSegundoApellido.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtSegundoApellido.PlaceholderText = ""
        Me.txtSegundoApellido.SelectedText = ""
        Me.txtSegundoApellido.ShadowDecoration.Parent = Me.txtSegundoApellido
        Me.txtSegundoApellido.Size = New System.Drawing.Size(191, 25)
        Me.txtSegundoApellido.TabIndex = 57
        '
        'txtCI
        '
        Me.txtCI.AutoRoundedCorners = True
        Me.txtCI.BorderRadius = 11
        Me.txtCI.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtCI.DefaultText = ""
        Me.txtCI.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.txtCI.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.txtCI.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txtCI.DisabledState.Parent = Me.txtCI
        Me.txtCI.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txtCI.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txtCI.FocusedState.Parent = Me.txtCI
        Me.txtCI.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.txtCI.ForeColor = System.Drawing.Color.Black
        Me.txtCI.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txtCI.HoverState.Parent = Me.txtCI
        Me.txtCI.Location = New System.Drawing.Point(333, 181)
        Me.txtCI.Name = "txtCI"
        Me.txtCI.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtCI.PlaceholderText = ""
        Me.txtCI.SelectedText = ""
        Me.txtCI.ShadowDecoration.Parent = Me.txtCI
        Me.txtCI.Size = New System.Drawing.Size(201, 25)
        Me.txtCI.TabIndex = 58
        '
        'txtDireccion
        '
        Me.txtDireccion.AutoRoundedCorners = True
        Me.txtDireccion.BorderRadius = 11
        Me.txtDireccion.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtDireccion.DefaultText = ""
        Me.txtDireccion.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.txtDireccion.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.txtDireccion.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txtDireccion.DisabledState.Parent = Me.txtDireccion
        Me.txtDireccion.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txtDireccion.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txtDireccion.FocusedState.Parent = Me.txtDireccion
        Me.txtDireccion.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.txtDireccion.ForeColor = System.Drawing.Color.Black
        Me.txtDireccion.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txtDireccion.HoverState.Parent = Me.txtDireccion
        Me.txtDireccion.Location = New System.Drawing.Point(756, 239)
        Me.txtDireccion.Name = "txtDireccion"
        Me.txtDireccion.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtDireccion.PlaceholderText = ""
        Me.txtDireccion.SelectedText = ""
        Me.txtDireccion.ShadowDecoration.Parent = Me.txtDireccion
        Me.txtDireccion.Size = New System.Drawing.Size(200, 25)
        Me.txtDireccion.TabIndex = 63
        '
        'txtEmail
        '
        Me.txtEmail.AutoRoundedCorners = True
        Me.txtEmail.BorderRadius = 11
        Me.txtEmail.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtEmail.DefaultText = ""
        Me.txtEmail.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.txtEmail.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.txtEmail.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txtEmail.DisabledState.Parent = Me.txtEmail
        Me.txtEmail.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txtEmail.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txtEmail.FocusedState.Parent = Me.txtEmail
        Me.txtEmail.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.txtEmail.ForeColor = System.Drawing.Color.Black
        Me.txtEmail.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txtEmail.HoverState.Parent = Me.txtEmail
        Me.txtEmail.Location = New System.Drawing.Point(730, 283)
        Me.txtEmail.Name = "txtEmail"
        Me.txtEmail.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtEmail.PlaceholderText = ""
        Me.txtEmail.SelectedText = ""
        Me.txtEmail.ShadowDecoration.Parent = Me.txtEmail
        Me.txtEmail.Size = New System.Drawing.Size(200, 25)
        Me.txtEmail.TabIndex = 65
        '
        'txtTelefono
        '
        Me.txtTelefono.AutoRoundedCorners = True
        Me.txtTelefono.BorderRadius = 11
        Me.txtTelefono.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtTelefono.DefaultText = ""
        Me.txtTelefono.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.txtTelefono.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.txtTelefono.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txtTelefono.DisabledState.Parent = Me.txtTelefono
        Me.txtTelefono.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txtTelefono.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txtTelefono.FocusedState.Parent = Me.txtTelefono
        Me.txtTelefono.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.txtTelefono.ForeColor = System.Drawing.Color.Black
        Me.txtTelefono.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txtTelefono.HoverState.Parent = Me.txtTelefono
        Me.txtTelefono.Location = New System.Drawing.Point(384, 286)
        Me.txtTelefono.Name = "txtTelefono"
        Me.txtTelefono.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtTelefono.PlaceholderText = ""
        Me.txtTelefono.SelectedText = ""
        Me.txtTelefono.ShadowDecoration.Parent = Me.txtTelefono
        Me.txtTelefono.Size = New System.Drawing.Size(207, 25)
        Me.txtTelefono.TabIndex = 64
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
        Me.txtContraseña.ForeColor = System.Drawing.Color.Black
        Me.txtContraseña.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txtContraseña.HoverState.Parent = Me.txtContraseña
        Me.txtContraseña.Location = New System.Drawing.Point(415, 495)
        Me.txtContraseña.Name = "txtContraseña"
        Me.txtContraseña.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtContraseña.PlaceholderText = ""
        Me.txtContraseña.SelectedText = ""
        Me.txtContraseña.ShadowDecoration.Parent = Me.txtContraseña
        Me.txtContraseña.Size = New System.Drawing.Size(193, 25)
        Me.txtContraseña.TabIndex = 67
        Me.txtContraseña.UseSystemPasswordChar = True
        '
        'txtConfContraseña
        '
        Me.txtConfContraseña.AutoRoundedCorners = True
        Me.txtConfContraseña.BorderRadius = 11
        Me.txtConfContraseña.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtConfContraseña.DefaultText = ""
        Me.txtConfContraseña.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.txtConfContraseña.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.txtConfContraseña.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txtConfContraseña.DisabledState.Parent = Me.txtConfContraseña
        Me.txtConfContraseña.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txtConfContraseña.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txtConfContraseña.FocusedState.Parent = Me.txtConfContraseña
        Me.txtConfContraseña.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.txtConfContraseña.ForeColor = System.Drawing.Color.Black
        Me.txtConfContraseña.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txtConfContraseña.HoverState.Parent = Me.txtConfContraseña
        Me.txtConfContraseña.Location = New System.Drawing.Point(472, 553)
        Me.txtConfContraseña.Name = "txtConfContraseña"
        Me.txtConfContraseña.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtConfContraseña.PlaceholderText = ""
        Me.txtConfContraseña.SelectedText = ""
        Me.txtConfContraseña.ShadowDecoration.Parent = Me.txtConfContraseña
        Me.txtConfContraseña.Size = New System.Drawing.Size(181, 25)
        Me.txtConfContraseña.TabIndex = 68
        Me.txtConfContraseña.UseSystemPasswordChar = True
        '
        'txtPatologiaPrevia
        '
        Me.txtPatologiaPrevia.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtPatologiaPrevia.DefaultText = ""
        Me.txtPatologiaPrevia.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.txtPatologiaPrevia.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.txtPatologiaPrevia.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txtPatologiaPrevia.DisabledState.Parent = Me.txtPatologiaPrevia
        Me.txtPatologiaPrevia.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txtPatologiaPrevia.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txtPatologiaPrevia.FocusedState.Parent = Me.txtPatologiaPrevia
        Me.txtPatologiaPrevia.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.txtPatologiaPrevia.ForeColor = System.Drawing.Color.Black
        Me.txtPatologiaPrevia.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txtPatologiaPrevia.HoverState.Parent = Me.txtPatologiaPrevia
        Me.txtPatologiaPrevia.Location = New System.Drawing.Point(295, 377)
        Me.txtPatologiaPrevia.Multiline = True
        Me.txtPatologiaPrevia.Name = "txtPatologiaPrevia"
        Me.txtPatologiaPrevia.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtPatologiaPrevia.PlaceholderText = ""
        Me.txtPatologiaPrevia.SelectedText = ""
        Me.txtPatologiaPrevia.ShadowDecoration.Parent = Me.txtPatologiaPrevia
        Me.txtPatologiaPrevia.Size = New System.Drawing.Size(329, 89)
        Me.txtPatologiaPrevia.TabIndex = 66
        '
        'numPeso
        '
        Me.numPeso.BackColor = System.Drawing.Color.Transparent
        Me.numPeso.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.numPeso.DecimalPlaces = 1
        Me.numPeso.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.numPeso.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.numPeso.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.numPeso.DisabledState.Parent = Me.numPeso
        Me.numPeso.DisabledState.UpDownButtonFillColor = System.Drawing.Color.FromArgb(CType(CType(177, Byte), Integer), CType(CType(177, Byte), Integer), CType(CType(177, Byte), Integer))
        Me.numPeso.DisabledState.UpDownButtonForeColor = System.Drawing.Color.FromArgb(CType(CType(203, Byte), Integer), CType(CType(203, Byte), Integer), CType(CType(203, Byte), Integer))
        Me.numPeso.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.numPeso.FocusedState.Parent = Me.numPeso
        Me.numPeso.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.numPeso.ForeColor = System.Drawing.Color.Black
        Me.numPeso.Location = New System.Drawing.Point(394, 241)
        Me.numPeso.Name = "numPeso"
        Me.numPeso.ShadowDecoration.Parent = Me.numPeso
        Me.numPeso.Size = New System.Drawing.Size(67, 21)
        Me.numPeso.TabIndex = 69
        '
        'numAltura
        '
        Me.numAltura.BackColor = System.Drawing.Color.Transparent
        Me.numAltura.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.numAltura.DecimalPlaces = 2
        Me.numAltura.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.numAltura.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.numAltura.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.numAltura.DisabledState.Parent = Me.numAltura
        Me.numAltura.DisabledState.UpDownButtonFillColor = System.Drawing.Color.FromArgb(CType(CType(177, Byte), Integer), CType(CType(177, Byte), Integer), CType(CType(177, Byte), Integer))
        Me.numAltura.DisabledState.UpDownButtonForeColor = System.Drawing.Color.FromArgb(CType(CType(203, Byte), Integer), CType(CType(203, Byte), Integer), CType(CType(203, Byte), Integer))
        Me.numAltura.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.numAltura.FocusedState.Parent = Me.numAltura
        Me.numAltura.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.numAltura.ForeColor = System.Drawing.Color.Black
        Me.numAltura.Increment = New Decimal(New Integer() {1, 0, 0, 131072})
        Me.numAltura.Location = New System.Drawing.Point(572, 240)
        Me.numAltura.Name = "numAltura"
        Me.numAltura.ShadowDecoration.Parent = Me.numAltura
        Me.numAltura.Size = New System.Drawing.Size(67, 21)
        Me.numAltura.TabIndex = 70
        '
        'cbxSexo
        '
        Me.cbxSexo.AutoRoundedCorners = True
        Me.cbxSexo.BackColor = System.Drawing.Color.Transparent
        Me.cbxSexo.BorderRadius = 17
        Me.cbxSexo.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed
        Me.cbxSexo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbxSexo.FocusedColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.cbxSexo.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.cbxSexo.FocusedState.Parent = Me.cbxSexo
        Me.cbxSexo.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.cbxSexo.ForeColor = System.Drawing.Color.FromArgb(CType(CType(68, Byte), Integer), CType(CType(88, Byte), Integer), CType(CType(112, Byte), Integer))
        Me.cbxSexo.HoverState.Parent = Me.cbxSexo
        Me.cbxSexo.ItemHeight = 30
        Me.cbxSexo.Items.AddRange(New Object() {"H", "M"})
        Me.cbxSexo.ItemsAppearance.Parent = Me.cbxSexo
        Me.cbxSexo.Location = New System.Drawing.Point(613, 177)
        Me.cbxSexo.Name = "cbxSexo"
        Me.cbxSexo.ShadowDecoration.Parent = Me.cbxSexo
        Me.cbxSexo.Size = New System.Drawing.Size(64, 36)
        Me.cbxSexo.TabIndex = 71
        Me.cbxSexo.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Registro
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(980, 645)
        Me.Controls.Add(Me.cbxSexo)
        Me.Controls.Add(Me.numAltura)
        Me.Controls.Add(Me.numPeso)
        Me.Controls.Add(Me.txtPatologiaPrevia)
        Me.Controls.Add(Me.txtConfContraseña)
        Me.Controls.Add(Me.txtContraseña)
        Me.Controls.Add(Me.txtTelefono)
        Me.Controls.Add(Me.txtEmail)
        Me.Controls.Add(Me.txtDireccion)
        Me.Controls.Add(Me.txtCI)
        Me.Controls.Add(Me.txtSegundoApellido)
        Me.Controls.Add(Me.txtSegundoNombre)
        Me.Controls.Add(Me.txtApellido)
        Me.Controls.Add(Me.txtPrimerNombre)
        Me.Controls.Add(Me.btnMostrarContraseña)
        Me.Controls.Add(Me.btnMinimizar)
        Me.Controls.Add(Me.btnCerrar)
        Me.Controls.Add(Me.Label18)
        Me.Controls.Add(Me.Label17)
        Me.Controls.Add(Me.Label16)
        Me.Controls.Add(Me.Label15)
        Me.Controls.Add(Me.Label14)
        Me.Controls.Add(Me.dateFechaNacimiento)
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
        Me.ForeColor = System.Drawing.Color.Black
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.MaximumSize = New System.Drawing.Size(980, 645)
        Me.MinimumSize = New System.Drawing.Size(980, 645)
        Me.Name = "Registro"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).EndInit()
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
    Friend WithEvents Label12 As Label
    Friend WithEvents dateFechaNacimiento As DateTimePicker
    Friend WithEvents Label14 As Label
    Friend WithEvents Label15 As Label
    Friend WithEvents Label16 As Label
    Friend WithEvents Label17 As Label
    Friend WithEvents Label18 As Label
    Friend WithEvents btnMinimizar As Guna.UI2.WinForms.Guna2CircleButton
    Friend WithEvents btnCerrar As Guna.UI2.WinForms.Guna2CircleButton
    Friend WithEvents btnMostrarContraseña As Guna.UI2.WinForms.Guna2CircleButton
    Friend WithEvents txtPrimerNombre As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents txtApellido As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents txtSegundoNombre As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents txtSegundoApellido As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents txtCI As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents txtDireccion As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents txtEmail As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents txtTelefono As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents txtContraseña As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents txtConfContraseña As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents txtPatologiaPrevia As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents btnRegistro As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents PictureBox3 As PictureBox
    Friend WithEvents numPeso As Guna.UI2.WinForms.Guna2NumericUpDown
    Friend WithEvents numAltura As Guna.UI2.WinForms.Guna2NumericUpDown
    Friend WithEvents cbxSexo As Guna.UI2.WinForms.Guna2ComboBox
End Class
