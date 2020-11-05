<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class MenuGestor
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(MenuGestor))
        Me.panelMenuInicio = New System.Windows.Forms.Panel()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.labIniciales = New System.Windows.Forms.Label()
        Me.labNombre = New System.Windows.Forms.Label()
        Me.btnMenu_AgregarMedico = New Guna.UI2.WinForms.Guna2Button()
        Me.btn_ABMSinPat = New Guna.UI2.WinForms.Guna2Button()
        Me.btnMenu_ModUsuario = New Guna.UI2.WinForms.Guna2Button()
        Me.panelModificarEliminarMedico = New System.Windows.Forms.Panel()
        Me.btnAceptarModificar = New Guna.UI2.WinForms.Guna2Button()
        Me.btnEliminarMedico = New Guna.UI2.WinForms.Guna2Button()
        Me.cbxModDel_Especializacion = New System.Windows.Forms.ComboBox()
        Me.txtModDel_CI = New System.Windows.Forms.TextBox()
        Me.txtModDel_Segundoapellido = New System.Windows.Forms.TextBox()
        Me.Label32 = New System.Windows.Forms.Label()
        Me.Label31 = New System.Windows.Forms.Label()
        Me.cbxModDel_Sexo = New System.Windows.Forms.ComboBox()
        Me.Label30 = New System.Windows.Forms.Label()
        Me.lstModDel_Medicos = New System.Windows.Forms.ListView()
        Me.Label17 = New System.Windows.Forms.Label()
        Me.dateModDel_FechaNacimiento = New System.Windows.Forms.DateTimePicker()
        Me.Label16 = New System.Windows.Forms.Label()
        Me.txtModDel_Telefono = New System.Windows.Forms.TextBox()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.txtModDel_ConfContraseña = New System.Windows.Forms.TextBox()
        Me.txtModDel_Contraseña = New System.Windows.Forms.TextBox()
        Me.txtModDel_SegundoNombre = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txtModDel_Empresa = New System.Windows.Forms.TextBox()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.txtModDel_Email = New System.Windows.Forms.TextBox()
        Me.txtModDel_Direccion = New System.Windows.Forms.TextBox()
        Me.txtModDel_Apellido = New System.Windows.Forms.TextBox()
        Me.txtModDel_PrimerNombre = New System.Windows.Forms.TextBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.panelABMSintoma = New System.Windows.Forms.Panel()
        Me.btnEliminarPatologia = New System.Windows.Forms.Button()
        Me.btnEliminarSintoma = New System.Windows.Forms.Button()
        Me.btnModPatologia = New System.Windows.Forms.Button()
        Me.btnModSintoma = New System.Windows.Forms.Button()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.lstPatologia = New System.Windows.Forms.ListView()
        Me.lstSintomas = New System.Windows.Forms.ListView()
        Me.txtBuscarSintoma = New Guna.UI2.WinForms.Guna2TextBox()
        Me.txtBuscarPatologia = New Guna.UI2.WinForms.Guna2TextBox()
        Me.btnAgregarSintoma = New Guna.UI2.WinForms.Guna2Button()
        Me.btnAgregarPatologia = New Guna.UI2.WinForms.Guna2Button()
        Me.panelAgregarUsuario = New System.Windows.Forms.Panel()
        Me.btnAgregarMedico = New Guna.UI2.WinForms.Guna2Button()
        Me.cbxEspecializacion = New System.Windows.Forms.ComboBox()
        Me.txtCI = New System.Windows.Forms.TextBox()
        Me.Label34 = New System.Windows.Forms.Label()
        Me.cbxSexo = New System.Windows.Forms.ComboBox()
        Me.txtSegundoApellido = New System.Windows.Forms.TextBox()
        Me.Label33 = New System.Windows.Forms.Label()
        Me.Label18 = New System.Windows.Forms.Label()
        Me.dateFechaNacimiento = New System.Windows.Forms.DateTimePicker()
        Me.Label19 = New System.Windows.Forms.Label()
        Me.txtTelefono = New System.Windows.Forms.TextBox()
        Me.Label20 = New System.Windows.Forms.Label()
        Me.Label21 = New System.Windows.Forms.Label()
        Me.txtConfContraseña = New System.Windows.Forms.TextBox()
        Me.txtContraseña = New System.Windows.Forms.TextBox()
        Me.txtSegundoNombre = New System.Windows.Forms.TextBox()
        Me.Label22 = New System.Windows.Forms.Label()
        Me.txtEmpresa = New System.Windows.Forms.TextBox()
        Me.Label23 = New System.Windows.Forms.Label()
        Me.txtEmail = New System.Windows.Forms.TextBox()
        Me.txtDireccion = New System.Windows.Forms.TextBox()
        Me.txtApellido = New System.Windows.Forms.TextBox()
        Me.txtPrimerNombre = New System.Windows.Forms.TextBox()
        Me.Label24 = New System.Windows.Forms.Label()
        Me.Label25 = New System.Windows.Forms.Label()
        Me.Label26 = New System.Windows.Forms.Label()
        Me.Label27 = New System.Windows.Forms.Label()
        Me.Label28 = New System.Windows.Forms.Label()
        Me.Label29 = New System.Windows.Forms.Label()
        Me.btnMinimizar = New Guna.UI2.WinForms.Guna2CircleButton()
        Me.btnCerrar = New Guna.UI2.WinForms.Guna2CircleButton()
        Me.panelMenuInicio.SuspendLayout()
        Me.panelModificarEliminarMedico.SuspendLayout()
        Me.panelABMSintoma.SuspendLayout()
        Me.panelAgregarUsuario.SuspendLayout()
        Me.SuspendLayout()
        '
        'panelMenuInicio
        '
        Me.panelMenuInicio.BackColor = System.Drawing.Color.FromArgb(CType(CType(48, Byte), Integer), CType(CType(48, Byte), Integer), CType(CType(48, Byte), Integer))
        Me.panelMenuInicio.Controls.Add(Me.Label2)
        Me.panelMenuInicio.Controls.Add(Me.labIniciales)
        Me.panelMenuInicio.Controls.Add(Me.labNombre)
        Me.panelMenuInicio.Controls.Add(Me.btnMenu_AgregarMedico)
        Me.panelMenuInicio.Controls.Add(Me.btn_ABMSinPat)
        Me.panelMenuInicio.Controls.Add(Me.btnMenu_ModUsuario)
        Me.panelMenuInicio.Location = New System.Drawing.Point(0, 0)
        Me.panelMenuInicio.Name = "panelMenuInicio"
        Me.panelMenuInicio.Size = New System.Drawing.Size(284, 648)
        Me.panelMenuInicio.TabIndex = 1
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.White
        Me.Label2.Location = New System.Drawing.Point(12, 620)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(111, 13)
        Me.Label2.TabIndex = 33
        Me.Label2.Text = "Politicas de privacidad"
        '
        'labIniciales
        '
        Me.labIniciales.AutoSize = True
        Me.labIniciales.Font = New System.Drawing.Font("Microsoft Sans Serif", 28.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.labIniciales.ForeColor = System.Drawing.Color.White
        Me.labIniciales.Location = New System.Drawing.Point(12, 16)
        Me.labIniciales.Name = "labIniciales"
        Me.labIniciales.Size = New System.Drawing.Size(53, 44)
        Me.labIniciales.TabIndex = 8
        Me.labIniciales.Text = "IF"
        '
        'labNombre
        '
        Me.labNombre.AutoSize = True
        Me.labNombre.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.labNombre.ForeColor = System.Drawing.Color.White
        Me.labNombre.Location = New System.Drawing.Point(103, 9)
        Me.labNombre.Name = "labNombre"
        Me.labNombre.Size = New System.Drawing.Size(141, 25)
        Me.labNombre.TabIndex = 5
        Me.labNombre.Text = "Ignacio Franco"
        '
        'btnMenu_AgregarMedico
        '
        Me.btnMenu_AgregarMedico.Animated = True
        Me.btnMenu_AgregarMedico.CheckedState.Parent = Me.btnMenu_AgregarMedico
        Me.btnMenu_AgregarMedico.CustomImages.Parent = Me.btnMenu_AgregarMedico
        Me.btnMenu_AgregarMedico.FillColor = System.Drawing.Color.FromArgb(CType(CType(48, Byte), Integer), CType(CType(48, Byte), Integer), CType(CType(48, Byte), Integer))
        Me.btnMenu_AgregarMedico.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.btnMenu_AgregarMedico.ForeColor = System.Drawing.Color.White
        Me.btnMenu_AgregarMedico.HoverState.Parent = Me.btnMenu_AgregarMedico
        Me.btnMenu_AgregarMedico.Location = New System.Drawing.Point(0, 180)
        Me.btnMenu_AgregarMedico.Name = "btnMenu_AgregarMedico"
        Me.btnMenu_AgregarMedico.ShadowDecoration.Parent = Me.btnMenu_AgregarMedico
        Me.btnMenu_AgregarMedico.Size = New System.Drawing.Size(291, 51)
        Me.btnMenu_AgregarMedico.TabIndex = 36
        Me.btnMenu_AgregarMedico.Text = "Agregar Médico"
        '
        'btn_ABMSinPat
        '
        Me.btn_ABMSinPat.Animated = True
        Me.btn_ABMSinPat.CheckedState.Parent = Me.btn_ABMSinPat
        Me.btn_ABMSinPat.CustomImages.Parent = Me.btn_ABMSinPat
        Me.btn_ABMSinPat.FillColor = System.Drawing.Color.FromArgb(CType(CType(48, Byte), Integer), CType(CType(48, Byte), Integer), CType(CType(48, Byte), Integer))
        Me.btn_ABMSinPat.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.btn_ABMSinPat.ForeColor = System.Drawing.Color.White
        Me.btn_ABMSinPat.HoverState.Parent = Me.btn_ABMSinPat
        Me.btn_ABMSinPat.Location = New System.Drawing.Point(0, 285)
        Me.btn_ABMSinPat.Name = "btn_ABMSinPat"
        Me.btn_ABMSinPat.ShadowDecoration.Parent = Me.btn_ABMSinPat
        Me.btn_ABMSinPat.Size = New System.Drawing.Size(291, 47)
        Me.btn_ABMSinPat.TabIndex = 37
        Me.btn_ABMSinPat.Text = "ABM Síntoma / Patología"
        '
        'btnMenu_ModUsuario
        '
        Me.btnMenu_ModUsuario.Animated = True
        Me.btnMenu_ModUsuario.CheckedState.Parent = Me.btnMenu_ModUsuario
        Me.btnMenu_ModUsuario.CustomImages.Parent = Me.btnMenu_ModUsuario
        Me.btnMenu_ModUsuario.FillColor = System.Drawing.Color.FromArgb(CType(CType(48, Byte), Integer), CType(CType(48, Byte), Integer), CType(CType(48, Byte), Integer))
        Me.btnMenu_ModUsuario.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.btnMenu_ModUsuario.ForeColor = System.Drawing.Color.White
        Me.btnMenu_ModUsuario.HoverState.Parent = Me.btnMenu_ModUsuario
        Me.btnMenu_ModUsuario.Location = New System.Drawing.Point(0, 392)
        Me.btnMenu_ModUsuario.Name = "btnMenu_ModUsuario"
        Me.btnMenu_ModUsuario.ShadowDecoration.Parent = Me.btnMenu_ModUsuario
        Me.btnMenu_ModUsuario.Size = New System.Drawing.Size(291, 46)
        Me.btnMenu_ModUsuario.TabIndex = 38
        Me.btnMenu_ModUsuario.Text = "Modificar / Eliminar Usuario"
        '
        'panelModificarEliminarMedico
        '
        Me.panelModificarEliminarMedico.Controls.Add(Me.btnAceptarModificar)
        Me.panelModificarEliminarMedico.Controls.Add(Me.btnEliminarMedico)
        Me.panelModificarEliminarMedico.Controls.Add(Me.cbxModDel_Especializacion)
        Me.panelModificarEliminarMedico.Controls.Add(Me.txtModDel_CI)
        Me.panelModificarEliminarMedico.Controls.Add(Me.txtModDel_Segundoapellido)
        Me.panelModificarEliminarMedico.Controls.Add(Me.Label32)
        Me.panelModificarEliminarMedico.Controls.Add(Me.Label31)
        Me.panelModificarEliminarMedico.Controls.Add(Me.cbxModDel_Sexo)
        Me.panelModificarEliminarMedico.Controls.Add(Me.Label30)
        Me.panelModificarEliminarMedico.Controls.Add(Me.lstModDel_Medicos)
        Me.panelModificarEliminarMedico.Controls.Add(Me.Label17)
        Me.panelModificarEliminarMedico.Controls.Add(Me.dateModDel_FechaNacimiento)
        Me.panelModificarEliminarMedico.Controls.Add(Me.Label16)
        Me.panelModificarEliminarMedico.Controls.Add(Me.txtModDel_Telefono)
        Me.panelModificarEliminarMedico.Controls.Add(Me.Label15)
        Me.panelModificarEliminarMedico.Controls.Add(Me.Label14)
        Me.panelModificarEliminarMedico.Controls.Add(Me.txtModDel_ConfContraseña)
        Me.panelModificarEliminarMedico.Controls.Add(Me.txtModDel_Contraseña)
        Me.panelModificarEliminarMedico.Controls.Add(Me.txtModDel_SegundoNombre)
        Me.panelModificarEliminarMedico.Controls.Add(Me.Label1)
        Me.panelModificarEliminarMedico.Controls.Add(Me.txtModDel_Empresa)
        Me.panelModificarEliminarMedico.Controls.Add(Me.Label10)
        Me.panelModificarEliminarMedico.Controls.Add(Me.txtModDel_Email)
        Me.panelModificarEliminarMedico.Controls.Add(Me.txtModDel_Direccion)
        Me.panelModificarEliminarMedico.Controls.Add(Me.txtModDel_Apellido)
        Me.panelModificarEliminarMedico.Controls.Add(Me.txtModDel_PrimerNombre)
        Me.panelModificarEliminarMedico.Controls.Add(Me.Label9)
        Me.panelModificarEliminarMedico.Controls.Add(Me.Label8)
        Me.panelModificarEliminarMedico.Controls.Add(Me.Label7)
        Me.panelModificarEliminarMedico.Controls.Add(Me.Label6)
        Me.panelModificarEliminarMedico.Controls.Add(Me.Label5)
        Me.panelModificarEliminarMedico.Controls.Add(Me.Label4)
        Me.panelModificarEliminarMedico.Location = New System.Drawing.Point(290, 24)
        Me.panelModificarEliminarMedico.Name = "panelModificarEliminarMedico"
        Me.panelModificarEliminarMedico.Size = New System.Drawing.Size(685, 617)
        Me.panelModificarEliminarMedico.TabIndex = 7
        '
        'btnAceptarModificar
        '
        Me.btnAceptarModificar.Animated = True
        Me.btnAceptarModificar.AutoRoundedCorners = True
        Me.btnAceptarModificar.BorderRadius = 13
        Me.btnAceptarModificar.CheckedState.Parent = Me.btnAceptarModificar
        Me.btnAceptarModificar.CustomImages.Parent = Me.btnAceptarModificar
        Me.btnAceptarModificar.FillColor = System.Drawing.Color.FromArgb(CType(CType(36, Byte), Integer), CType(CType(36, Byte), Integer), CType(CType(36, Byte), Integer))
        Me.btnAceptarModificar.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.btnAceptarModificar.ForeColor = System.Drawing.Color.White
        Me.btnAceptarModificar.HoverState.Parent = Me.btnAceptarModificar
        Me.btnAceptarModificar.Location = New System.Drawing.Point(558, 573)
        Me.btnAceptarModificar.Name = "btnAceptarModificar"
        Me.btnAceptarModificar.PressedColor = System.Drawing.Color.Gray
        Me.btnAceptarModificar.ShadowDecoration.Parent = Me.btnAceptarModificar
        Me.btnAceptarModificar.Size = New System.Drawing.Size(106, 28)
        Me.btnAceptarModificar.TabIndex = 59
        Me.btnAceptarModificar.Text = "Aceptar"
        '
        'btnEliminarMedico
        '
        Me.btnEliminarMedico.Animated = True
        Me.btnEliminarMedico.AutoRoundedCorners = True
        Me.btnEliminarMedico.BorderRadius = 13
        Me.btnEliminarMedico.CheckedState.Parent = Me.btnEliminarMedico
        Me.btnEliminarMedico.CustomImages.Parent = Me.btnEliminarMedico
        Me.btnEliminarMedico.FillColor = System.Drawing.Color.FromArgb(CType(CType(36, Byte), Integer), CType(CType(36, Byte), Integer), CType(CType(36, Byte), Integer))
        Me.btnEliminarMedico.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.btnEliminarMedico.ForeColor = System.Drawing.Color.White
        Me.btnEliminarMedico.HoverState.Parent = Me.btnEliminarMedico
        Me.btnEliminarMedico.Location = New System.Drawing.Point(558, 517)
        Me.btnEliminarMedico.Name = "btnEliminarMedico"
        Me.btnEliminarMedico.PressedColor = System.Drawing.Color.Gray
        Me.btnEliminarMedico.ShadowDecoration.Parent = Me.btnEliminarMedico
        Me.btnEliminarMedico.Size = New System.Drawing.Size(106, 28)
        Me.btnEliminarMedico.TabIndex = 58
        Me.btnEliminarMedico.Text = "Eliminar"
        '
        'cbxModDel_Especializacion
        '
        Me.cbxModDel_Especializacion.FormattingEnabled = True
        Me.cbxModDel_Especializacion.Location = New System.Drawing.Point(206, 400)
        Me.cbxModDel_Especializacion.Name = "cbxModDel_Especializacion"
        Me.cbxModDel_Especializacion.Size = New System.Drawing.Size(198, 21)
        Me.cbxModDel_Especializacion.TabIndex = 57
        '
        'txtModDel_CI
        '
        Me.txtModDel_CI.Location = New System.Drawing.Point(207, 230)
        Me.txtModDel_CI.Name = "txtModDel_CI"
        Me.txtModDel_CI.Size = New System.Drawing.Size(197, 20)
        Me.txtModDel_CI.TabIndex = 45
        '
        'txtModDel_Segundoapellido
        '
        Me.txtModDel_Segundoapellido.Location = New System.Drawing.Point(206, 144)
        Me.txtModDel_Segundoapellido.Name = "txtModDel_Segundoapellido"
        Me.txtModDel_Segundoapellido.Size = New System.Drawing.Size(198, 20)
        Me.txtModDel_Segundoapellido.TabIndex = 43
        '
        'Label32
        '
        Me.Label32.AutoSize = True
        Me.Label32.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label32.Location = New System.Drawing.Point(44, 142)
        Me.Label32.Name = "Label32"
        Me.Label32.Size = New System.Drawing.Size(156, 22)
        Me.Label32.TabIndex = 48
        Me.Label32.Text = "Segundo Apellido:"
        '
        'Label31
        '
        Me.Label31.AutoSize = True
        Me.Label31.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label31.Location = New System.Drawing.Point(144, 185)
        Me.Label31.Name = "Label31"
        Me.Label31.Size = New System.Drawing.Size(56, 22)
        Me.Label31.TabIndex = 47
        Me.Label31.Text = "Sexo:"
        '
        'cbxModDel_Sexo
        '
        Me.cbxModDel_Sexo.FormattingEnabled = True
        Me.cbxModDel_Sexo.Items.AddRange(New Object() {"H", "M"})
        Me.cbxModDel_Sexo.Location = New System.Drawing.Point(206, 186)
        Me.cbxModDel_Sexo.Name = "cbxModDel_Sexo"
        Me.cbxModDel_Sexo.Size = New System.Drawing.Size(49, 21)
        Me.cbxModDel_Sexo.TabIndex = 44
        '
        'Label30
        '
        Me.Label30.AutoSize = True
        Me.Label30.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label30.Location = New System.Drawing.Point(449, 122)
        Me.Label30.Name = "Label30"
        Me.Label30.Size = New System.Drawing.Size(151, 20)
        Me.Label30.TabIndex = 45
        Me.Label30.Text = "Lista de usuarios:"
        '
        'lstModDel_Medicos
        '
        Me.lstModDel_Medicos.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lstModDel_Medicos.HideSelection = False
        Me.lstModDel_Medicos.Location = New System.Drawing.Point(453, 156)
        Me.lstModDel_Medicos.MultiSelect = False
        Me.lstModDel_Medicos.Name = "lstModDel_Medicos"
        Me.lstModDel_Medicos.Size = New System.Drawing.Size(225, 340)
        Me.lstModDel_Medicos.TabIndex = 56
        Me.lstModDel_Medicos.UseCompatibleStateImageBehavior = False
        Me.lstModDel_Medicos.View = System.Windows.Forms.View.Tile
        '
        'Label17
        '
        Me.Label17.AutoSize = True
        Me.Label17.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label17.Location = New System.Drawing.Point(16, 313)
        Me.Label17.Name = "Label17"
        Me.Label17.Size = New System.Drawing.Size(184, 22)
        Me.Label17.TabIndex = 42
        Me.Label17.Text = "Fecha de Nacimiento:"
        '
        'dateModDel_FechaNacimiento
        '
        Me.dateModDel_FechaNacimiento.Location = New System.Drawing.Point(206, 315)
        Me.dateModDel_FechaNacimiento.Name = "dateModDel_FechaNacimiento"
        Me.dateModDel_FechaNacimiento.Size = New System.Drawing.Size(198, 20)
        Me.dateModDel_FechaNacimiento.TabIndex = 47
        '
        'Label16
        '
        Me.Label16.AutoSize = True
        Me.Label16.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label16.Location = New System.Drawing.Point(114, 355)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(86, 22)
        Me.Label16.TabIndex = 40
        Me.Label16.Text = "Teléfono:"
        '
        'txtModDel_Telefono
        '
        Me.txtModDel_Telefono.Location = New System.Drawing.Point(206, 359)
        Me.txtModDel_Telefono.Name = "txtModDel_Telefono"
        Me.txtModDel_Telefono.Size = New System.Drawing.Size(198, 20)
        Me.txtModDel_Telefono.TabIndex = 48
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label15.Location = New System.Drawing.Point(9, 573)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(191, 22)
        Me.Label15.TabIndex = 38
        Me.Label15.Text = "Confirmar Contraseña:"
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label14.Location = New System.Drawing.Point(92, 530)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(108, 22)
        Me.Label14.TabIndex = 37
        Me.Label14.Text = "Contraseña:"
        '
        'txtModDel_ConfContraseña
        '
        Me.txtModDel_ConfContraseña.Location = New System.Drawing.Point(206, 575)
        Me.txtModDel_ConfContraseña.Name = "txtModDel_ConfContraseña"
        Me.txtModDel_ConfContraseña.Size = New System.Drawing.Size(198, 20)
        Me.txtModDel_ConfContraseña.TabIndex = 53
        '
        'txtModDel_Contraseña
        '
        Me.txtModDel_Contraseña.Location = New System.Drawing.Point(206, 532)
        Me.txtModDel_Contraseña.Name = "txtModDel_Contraseña"
        Me.txtModDel_Contraseña.Size = New System.Drawing.Size(198, 20)
        Me.txtModDel_Contraseña.TabIndex = 52
        '
        'txtModDel_SegundoNombre
        '
        Me.txtModDel_SegundoNombre.Location = New System.Drawing.Point(206, 57)
        Me.txtModDel_SegundoNombre.Name = "txtModDel_SegundoNombre"
        Me.txtModDel_SegundoNombre.Size = New System.Drawing.Size(198, 20)
        Me.txtModDel_SegundoNombre.TabIndex = 41
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(45, 55)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(155, 22)
        Me.Label1.TabIndex = 33
        Me.Label1.Text = "Segundo Nombre:"
        '
        'txtModDel_Empresa
        '
        Me.txtModDel_Empresa.Location = New System.Drawing.Point(206, 487)
        Me.txtModDel_Empresa.Name = "txtModDel_Empresa"
        Me.txtModDel_Empresa.Size = New System.Drawing.Size(198, 20)
        Me.txtModDel_Empresa.TabIndex = 51
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.Location = New System.Drawing.Point(29, 485)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(171, 22)
        Me.Label10.TabIndex = 31
        Me.Label10.Text = "Empresa de trabajo:"
        '
        'txtModDel_Email
        '
        Me.txtModDel_Email.Location = New System.Drawing.Point(206, 445)
        Me.txtModDel_Email.Name = "txtModDel_Email"
        Me.txtModDel_Email.Size = New System.Drawing.Size(198, 20)
        Me.txtModDel_Email.TabIndex = 50
        '
        'txtModDel_Direccion
        '
        Me.txtModDel_Direccion.Location = New System.Drawing.Point(206, 272)
        Me.txtModDel_Direccion.Name = "txtModDel_Direccion"
        Me.txtModDel_Direccion.Size = New System.Drawing.Size(198, 20)
        Me.txtModDel_Direccion.TabIndex = 46
        '
        'txtModDel_Apellido
        '
        Me.txtModDel_Apellido.Location = New System.Drawing.Point(206, 101)
        Me.txtModDel_Apellido.Name = "txtModDel_Apellido"
        Me.txtModDel_Apellido.Size = New System.Drawing.Size(198, 20)
        Me.txtModDel_Apellido.TabIndex = 42
        '
        'txtModDel_PrimerNombre
        '
        Me.txtModDel_PrimerNombre.Location = New System.Drawing.Point(206, 16)
        Me.txtModDel_PrimerNombre.Name = "txtModDel_PrimerNombre"
        Me.txtModDel_PrimerNombre.Size = New System.Drawing.Size(198, 20)
        Me.txtModDel_PrimerNombre.TabIndex = 40
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.Location = New System.Drawing.Point(135, 443)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(65, 22)
        Me.Label9.TabIndex = 20
        Me.Label9.Text = "E-mail:"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(62, 398)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(138, 22)
        Me.Label8.TabIndex = 17
        Me.Label8.Text = "Especialización:"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(168, 230)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(32, 22)
        Me.Label7.TabIndex = 14
        Me.Label7.Text = "CI:"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(110, 268)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(90, 22)
        Me.Label6.TabIndex = 11
        Me.Label6.Text = "Dirección:"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(121, 99)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(79, 22)
        Me.Label5.TabIndex = 8
        Me.Label5.Text = "Apellido:"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(122, 16)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(78, 22)
        Me.Label4.TabIndex = 5
        Me.Label4.Text = "Nombre:"
        '
        'panelABMSintoma
        '
        Me.panelABMSintoma.Controls.Add(Me.btnEliminarPatologia)
        Me.panelABMSintoma.Controls.Add(Me.btnEliminarSintoma)
        Me.panelABMSintoma.Controls.Add(Me.btnModPatologia)
        Me.panelABMSintoma.Controls.Add(Me.btnModSintoma)
        Me.panelABMSintoma.Controls.Add(Me.Label13)
        Me.panelABMSintoma.Controls.Add(Me.Label12)
        Me.panelABMSintoma.Controls.Add(Me.Label11)
        Me.panelABMSintoma.Controls.Add(Me.Label3)
        Me.panelABMSintoma.Controls.Add(Me.lstPatologia)
        Me.panelABMSintoma.Controls.Add(Me.lstSintomas)
        Me.panelABMSintoma.Controls.Add(Me.txtBuscarSintoma)
        Me.panelABMSintoma.Controls.Add(Me.txtBuscarPatologia)
        Me.panelABMSintoma.Controls.Add(Me.btnAgregarSintoma)
        Me.panelABMSintoma.Controls.Add(Me.btnAgregarPatologia)
        Me.panelABMSintoma.Location = New System.Drawing.Point(288, 22)
        Me.panelABMSintoma.Name = "panelABMSintoma"
        Me.panelABMSintoma.Size = New System.Drawing.Size(689, 618)
        Me.panelABMSintoma.TabIndex = 8
        '
        'btnEliminarPatologia
        '
        Me.btnEliminarPatologia.BackgroundImage = CType(resources.GetObject("btnEliminarPatologia.BackgroundImage"), System.Drawing.Image)
        Me.btnEliminarPatologia.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.btnEliminarPatologia.FlatAppearance.BorderSize = 0
        Me.btnEliminarPatologia.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnEliminarPatologia.Location = New System.Drawing.Point(368, 569)
        Me.btnEliminarPatologia.Name = "btnEliminarPatologia"
        Me.btnEliminarPatologia.Size = New System.Drawing.Size(25, 21)
        Me.btnEliminarPatologia.TabIndex = 23
        Me.btnEliminarPatologia.UseVisualStyleBackColor = True
        '
        'btnEliminarSintoma
        '
        Me.btnEliminarSintoma.BackgroundImage = CType(resources.GetObject("btnEliminarSintoma.BackgroundImage"), System.Drawing.Image)
        Me.btnEliminarSintoma.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.btnEliminarSintoma.FlatAppearance.BorderSize = 0
        Me.btnEliminarSintoma.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnEliminarSintoma.Location = New System.Drawing.Point(9, 569)
        Me.btnEliminarSintoma.Name = "btnEliminarSintoma"
        Me.btnEliminarSintoma.Size = New System.Drawing.Size(25, 21)
        Me.btnEliminarSintoma.TabIndex = 21
        Me.btnEliminarSintoma.UseVisualStyleBackColor = True
        '
        'btnModPatologia
        '
        Me.btnModPatologia.BackColor = System.Drawing.Color.White
        Me.btnModPatologia.BackgroundImage = CType(resources.GetObject("btnModPatologia.BackgroundImage"), System.Drawing.Image)
        Me.btnModPatologia.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnModPatologia.Cursor = System.Windows.Forms.Cursors.Default
        Me.btnModPatologia.FlatAppearance.BorderSize = 0
        Me.btnModPatologia.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnModPatologia.Location = New System.Drawing.Point(658, 570)
        Me.btnModPatologia.Name = "btnModPatologia"
        Me.btnModPatologia.Size = New System.Drawing.Size(22, 20)
        Me.btnModPatologia.TabIndex = 24
        Me.btnModPatologia.UseVisualStyleBackColor = False
        '
        'btnModSintoma
        '
        Me.btnModSintoma.BackColor = System.Drawing.Color.White
        Me.btnModSintoma.BackgroundImage = CType(resources.GetObject("btnModSintoma.BackgroundImage"), System.Drawing.Image)
        Me.btnModSintoma.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnModSintoma.Cursor = System.Windows.Forms.Cursors.Default
        Me.btnModSintoma.FlatAppearance.BorderSize = 0
        Me.btnModSintoma.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnModSintoma.Location = New System.Drawing.Point(299, 570)
        Me.btnModSintoma.Name = "btnModSintoma"
        Me.btnModSintoma.Size = New System.Drawing.Size(22, 20)
        Me.btnModSintoma.TabIndex = 22
        Me.btnModSintoma.UseVisualStyleBackColor = False
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Font = New System.Drawing.Font("Yu Gothic UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label13.Location = New System.Drawing.Point(365, 98)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(138, 17)
        Me.Label13.TabIndex = 5
        Me.Label13.Text = "Nombre de Patología:"
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Font = New System.Drawing.Font("Yu Gothic UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label12.Location = New System.Drawing.Point(19, 98)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(130, 17)
        Me.Label12.TabIndex = 4
        Me.Label12.Text = "Nombre de Síntoma:"
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Font = New System.Drawing.Font("Yu Gothic UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.Location = New System.Drawing.Point(365, 194)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(235, 17)
        Me.Label11.TabIndex = 3
        Me.Label11.Text = "Lista de patologías a la que pertenece:" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10)
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Yu Gothic UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(9, 192)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(112, 17)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "Lista de síntomas:"
        '
        'lstPatologia
        '
        Me.lstPatologia.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lstPatologia.HideSelection = False
        Me.lstPatologia.Location = New System.Drawing.Point(368, 212)
        Me.lstPatologia.MultiSelect = False
        Me.lstPatologia.Name = "lstPatologia"
        Me.lstPatologia.Size = New System.Drawing.Size(312, 352)
        Me.lstPatologia.TabIndex = 1
        Me.lstPatologia.UseCompatibleStateImageBehavior = False
        Me.lstPatologia.View = System.Windows.Forms.View.Tile
        '
        'lstSintomas
        '
        Me.lstSintomas.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lstSintomas.HideSelection = False
        Me.lstSintomas.Location = New System.Drawing.Point(9, 212)
        Me.lstSintomas.MultiSelect = False
        Me.lstSintomas.Name = "lstSintomas"
        Me.lstSintomas.Size = New System.Drawing.Size(312, 352)
        Me.lstSintomas.TabIndex = 0
        Me.lstSintomas.UseCompatibleStateImageBehavior = False
        Me.lstSintomas.View = System.Windows.Forms.View.Tile
        '
        'txtBuscarSintoma
        '
        Me.txtBuscarSintoma.AutoRoundedCorners = True
        Me.txtBuscarSintoma.BorderColor = System.Drawing.Color.Black
        Me.txtBuscarSintoma.BorderRadius = 9
        Me.txtBuscarSintoma.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtBuscarSintoma.DefaultText = ""
        Me.txtBuscarSintoma.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.txtBuscarSintoma.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.txtBuscarSintoma.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txtBuscarSintoma.DisabledState.Parent = Me.txtBuscarSintoma
        Me.txtBuscarSintoma.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txtBuscarSintoma.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txtBuscarSintoma.FocusedState.Parent = Me.txtBuscarSintoma
        Me.txtBuscarSintoma.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.txtBuscarSintoma.ForeColor = System.Drawing.Color.Black
        Me.txtBuscarSintoma.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txtBuscarSintoma.HoverState.Parent = Me.txtBuscarSintoma
        Me.txtBuscarSintoma.Location = New System.Drawing.Point(155, 98)
        Me.txtBuscarSintoma.Name = "txtBuscarSintoma"
        Me.txtBuscarSintoma.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtBuscarSintoma.PlaceholderForeColor = System.Drawing.Color.Silver
        Me.txtBuscarSintoma.PlaceholderText = "Busca síntomas..."
        Me.txtBuscarSintoma.SelectedText = ""
        Me.txtBuscarSintoma.ShadowDecoration.Parent = Me.txtBuscarSintoma
        Me.txtBuscarSintoma.Size = New System.Drawing.Size(167, 20)
        Me.txtBuscarSintoma.TabIndex = 17
        '
        'txtBuscarPatologia
        '
        Me.txtBuscarPatologia.AutoRoundedCorners = True
        Me.txtBuscarPatologia.BorderColor = System.Drawing.Color.Black
        Me.txtBuscarPatologia.BorderRadius = 9
        Me.txtBuscarPatologia.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtBuscarPatologia.DefaultText = ""
        Me.txtBuscarPatologia.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.txtBuscarPatologia.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.txtBuscarPatologia.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txtBuscarPatologia.DisabledState.Parent = Me.txtBuscarPatologia
        Me.txtBuscarPatologia.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txtBuscarPatologia.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txtBuscarPatologia.FocusedState.Parent = Me.txtBuscarPatologia
        Me.txtBuscarPatologia.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.txtBuscarPatologia.ForeColor = System.Drawing.Color.Black
        Me.txtBuscarPatologia.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txtBuscarPatologia.HoverState.Parent = Me.txtBuscarPatologia
        Me.txtBuscarPatologia.Location = New System.Drawing.Point(510, 98)
        Me.txtBuscarPatologia.Name = "txtBuscarPatologia"
        Me.txtBuscarPatologia.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtBuscarPatologia.PlaceholderForeColor = System.Drawing.Color.Gray
        Me.txtBuscarPatologia.PlaceholderText = "Buscar patología..."
        Me.txtBuscarPatologia.SelectedText = ""
        Me.txtBuscarPatologia.ShadowDecoration.Parent = Me.txtBuscarPatologia
        Me.txtBuscarPatologia.Size = New System.Drawing.Size(170, 20)
        Me.txtBuscarPatologia.TabIndex = 18
        '
        'btnAgregarSintoma
        '
        Me.btnAgregarSintoma.Animated = True
        Me.btnAgregarSintoma.AutoRoundedCorners = True
        Me.btnAgregarSintoma.BorderRadius = 13
        Me.btnAgregarSintoma.CheckedState.Parent = Me.btnAgregarSintoma
        Me.btnAgregarSintoma.CustomImages.Parent = Me.btnAgregarSintoma
        Me.btnAgregarSintoma.FillColor = System.Drawing.Color.FromArgb(CType(CType(48, Byte), Integer), CType(CType(48, Byte), Integer), CType(CType(48, Byte), Integer))
        Me.btnAgregarSintoma.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.btnAgregarSintoma.ForeColor = System.Drawing.Color.White
        Me.btnAgregarSintoma.HoverState.Parent = Me.btnAgregarSintoma
        Me.btnAgregarSintoma.Location = New System.Drawing.Point(116, 569)
        Me.btnAgregarSintoma.Name = "btnAgregarSintoma"
        Me.btnAgregarSintoma.ShadowDecoration.Parent = Me.btnAgregarSintoma
        Me.btnAgregarSintoma.Size = New System.Drawing.Size(106, 29)
        Me.btnAgregarSintoma.TabIndex = 19
        Me.btnAgregarSintoma.Text = "Agregar síntoma"
        '
        'btnAgregarPatologia
        '
        Me.btnAgregarPatologia.Animated = True
        Me.btnAgregarPatologia.AutoRoundedCorners = True
        Me.btnAgregarPatologia.BorderRadius = 13
        Me.btnAgregarPatologia.CheckedState.Parent = Me.btnAgregarPatologia
        Me.btnAgregarPatologia.CustomImages.Parent = Me.btnAgregarPatologia
        Me.btnAgregarPatologia.FillColor = System.Drawing.Color.FromArgb(CType(CType(48, Byte), Integer), CType(CType(48, Byte), Integer), CType(CType(48, Byte), Integer))
        Me.btnAgregarPatologia.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.btnAgregarPatologia.ForeColor = System.Drawing.Color.White
        Me.btnAgregarPatologia.HoverState.Parent = Me.btnAgregarPatologia
        Me.btnAgregarPatologia.Location = New System.Drawing.Point(473, 570)
        Me.btnAgregarPatologia.Name = "btnAgregarPatologia"
        Me.btnAgregarPatologia.ShadowDecoration.Parent = Me.btnAgregarPatologia
        Me.btnAgregarPatologia.Size = New System.Drawing.Size(116, 29)
        Me.btnAgregarPatologia.TabIndex = 20
        Me.btnAgregarPatologia.Text = "Agregar patología"
        '
        'panelAgregarUsuario
        '
        Me.panelAgregarUsuario.Controls.Add(Me.btnAgregarMedico)
        Me.panelAgregarUsuario.Controls.Add(Me.cbxEspecializacion)
        Me.panelAgregarUsuario.Controls.Add(Me.txtCI)
        Me.panelAgregarUsuario.Controls.Add(Me.Label34)
        Me.panelAgregarUsuario.Controls.Add(Me.cbxSexo)
        Me.panelAgregarUsuario.Controls.Add(Me.txtSegundoApellido)
        Me.panelAgregarUsuario.Controls.Add(Me.Label33)
        Me.panelAgregarUsuario.Controls.Add(Me.Label18)
        Me.panelAgregarUsuario.Controls.Add(Me.dateFechaNacimiento)
        Me.panelAgregarUsuario.Controls.Add(Me.Label19)
        Me.panelAgregarUsuario.Controls.Add(Me.txtTelefono)
        Me.panelAgregarUsuario.Controls.Add(Me.Label20)
        Me.panelAgregarUsuario.Controls.Add(Me.Label21)
        Me.panelAgregarUsuario.Controls.Add(Me.txtConfContraseña)
        Me.panelAgregarUsuario.Controls.Add(Me.txtContraseña)
        Me.panelAgregarUsuario.Controls.Add(Me.txtSegundoNombre)
        Me.panelAgregarUsuario.Controls.Add(Me.Label22)
        Me.panelAgregarUsuario.Controls.Add(Me.txtEmpresa)
        Me.panelAgregarUsuario.Controls.Add(Me.Label23)
        Me.panelAgregarUsuario.Controls.Add(Me.txtEmail)
        Me.panelAgregarUsuario.Controls.Add(Me.txtDireccion)
        Me.panelAgregarUsuario.Controls.Add(Me.txtApellido)
        Me.panelAgregarUsuario.Controls.Add(Me.txtPrimerNombre)
        Me.panelAgregarUsuario.Controls.Add(Me.Label24)
        Me.panelAgregarUsuario.Controls.Add(Me.Label25)
        Me.panelAgregarUsuario.Controls.Add(Me.Label26)
        Me.panelAgregarUsuario.Controls.Add(Me.Label27)
        Me.panelAgregarUsuario.Controls.Add(Me.Label28)
        Me.panelAgregarUsuario.Controls.Add(Me.Label29)
        Me.panelAgregarUsuario.Location = New System.Drawing.Point(290, 24)
        Me.panelAgregarUsuario.Name = "panelAgregarUsuario"
        Me.panelAgregarUsuario.Size = New System.Drawing.Size(685, 617)
        Me.panelAgregarUsuario.TabIndex = 43
        '
        'btnAgregarMedico
        '
        Me.btnAgregarMedico.Animated = True
        Me.btnAgregarMedico.AutoRoundedCorners = True
        Me.btnAgregarMedico.BorderRadius = 13
        Me.btnAgregarMedico.CheckedState.Parent = Me.btnAgregarMedico
        Me.btnAgregarMedico.CustomImages.Parent = Me.btnAgregarMedico
        Me.btnAgregarMedico.FillColor = System.Drawing.Color.FromArgb(CType(CType(36, Byte), Integer), CType(CType(36, Byte), Integer), CType(CType(36, Byte), Integer))
        Me.btnAgregarMedico.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.btnAgregarMedico.ForeColor = System.Drawing.Color.White
        Me.btnAgregarMedico.HoverState.Parent = Me.btnAgregarMedico
        Me.btnAgregarMedico.Location = New System.Drawing.Point(558, 567)
        Me.btnAgregarMedico.Name = "btnAgregarMedico"
        Me.btnAgregarMedico.ShadowDecoration.Parent = Me.btnAgregarMedico
        Me.btnAgregarMedico.Size = New System.Drawing.Size(106, 28)
        Me.btnAgregarMedico.TabIndex = 48
        Me.btnAgregarMedico.Text = "Aceptar"
        '
        'cbxEspecializacion
        '
        Me.cbxEspecializacion.FormattingEnabled = True
        Me.cbxEspecializacion.Location = New System.Drawing.Point(206, 385)
        Me.cbxEspecializacion.Name = "cbxEspecializacion"
        Me.cbxEspecializacion.Size = New System.Drawing.Size(241, 21)
        Me.cbxEspecializacion.TabIndex = 47
        '
        'txtCI
        '
        Me.txtCI.Location = New System.Drawing.Point(207, 174)
        Me.txtCI.Name = "txtCI"
        Me.txtCI.Size = New System.Drawing.Size(240, 20)
        Me.txtCI.TabIndex = 27
        '
        'Label34
        '
        Me.Label34.AutoSize = True
        Me.Label34.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label34.Location = New System.Drawing.Point(144, 214)
        Me.Label34.Name = "Label34"
        Me.Label34.Size = New System.Drawing.Size(56, 22)
        Me.Label34.TabIndex = 46
        Me.Label34.Text = "Sexo:"
        '
        'cbxSexo
        '
        Me.cbxSexo.FormattingEnabled = True
        Me.cbxSexo.Items.AddRange(New Object() {"H", "M"})
        Me.cbxSexo.Location = New System.Drawing.Point(206, 214)
        Me.cbxSexo.Name = "cbxSexo"
        Me.cbxSexo.Size = New System.Drawing.Size(49, 21)
        Me.cbxSexo.TabIndex = 28
        '
        'txtSegundoApellido
        '
        Me.txtSegundoApellido.Location = New System.Drawing.Point(206, 131)
        Me.txtSegundoApellido.Name = "txtSegundoApellido"
        Me.txtSegundoApellido.Size = New System.Drawing.Size(241, 20)
        Me.txtSegundoApellido.TabIndex = 26
        '
        'Label33
        '
        Me.Label33.AutoSize = True
        Me.Label33.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label33.Location = New System.Drawing.Point(44, 129)
        Me.Label33.Name = "Label33"
        Me.Label33.Size = New System.Drawing.Size(156, 22)
        Me.Label33.TabIndex = 43
        Me.Label33.Text = "Segundo Apellido:"
        '
        'Label18
        '
        Me.Label18.AutoSize = True
        Me.Label18.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label18.Location = New System.Drawing.Point(16, 298)
        Me.Label18.Name = "Label18"
        Me.Label18.Size = New System.Drawing.Size(184, 22)
        Me.Label18.TabIndex = 42
        Me.Label18.Text = "Fecha de Nacimiento:"
        '
        'dateFechaNacimiento
        '
        Me.dateFechaNacimiento.Location = New System.Drawing.Point(206, 300)
        Me.dateFechaNacimiento.Name = "dateFechaNacimiento"
        Me.dateFechaNacimiento.Size = New System.Drawing.Size(241, 20)
        Me.dateFechaNacimiento.TabIndex = 30
        '
        'Label19
        '
        Me.Label19.AutoSize = True
        Me.Label19.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label19.Location = New System.Drawing.Point(114, 340)
        Me.Label19.Name = "Label19"
        Me.Label19.Size = New System.Drawing.Size(86, 22)
        Me.Label19.TabIndex = 40
        Me.Label19.Text = "Teléfono:"
        '
        'txtTelefono
        '
        Me.txtTelefono.Location = New System.Drawing.Point(206, 344)
        Me.txtTelefono.Name = "txtTelefono"
        Me.txtTelefono.Size = New System.Drawing.Size(241, 20)
        Me.txtTelefono.TabIndex = 31
        '
        'Label20
        '
        Me.Label20.AutoSize = True
        Me.Label20.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label20.Location = New System.Drawing.Point(9, 560)
        Me.Label20.Name = "Label20"
        Me.Label20.Size = New System.Drawing.Size(191, 22)
        Me.Label20.TabIndex = 38
        Me.Label20.Text = "Confirmar Contraseña:"
        '
        'Label21
        '
        Me.Label21.AutoSize = True
        Me.Label21.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label21.Location = New System.Drawing.Point(92, 515)
        Me.Label21.Name = "Label21"
        Me.Label21.Size = New System.Drawing.Size(108, 22)
        Me.Label21.TabIndex = 37
        Me.Label21.Text = "Contraseña:"
        '
        'txtConfContraseña
        '
        Me.txtConfContraseña.Location = New System.Drawing.Point(206, 562)
        Me.txtConfContraseña.Name = "txtConfContraseña"
        Me.txtConfContraseña.Size = New System.Drawing.Size(241, 20)
        Me.txtConfContraseña.TabIndex = 36
        '
        'txtContraseña
        '
        Me.txtContraseña.Location = New System.Drawing.Point(206, 517)
        Me.txtContraseña.Name = "txtContraseña"
        Me.txtContraseña.Size = New System.Drawing.Size(241, 20)
        Me.txtContraseña.TabIndex = 35
        '
        'txtSegundoNombre
        '
        Me.txtSegundoNombre.Location = New System.Drawing.Point(206, 53)
        Me.txtSegundoNombre.Name = "txtSegundoNombre"
        Me.txtSegundoNombre.Size = New System.Drawing.Size(241, 20)
        Me.txtSegundoNombre.TabIndex = 24
        '
        'Label22
        '
        Me.Label22.AutoSize = True
        Me.Label22.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label22.Location = New System.Drawing.Point(45, 51)
        Me.Label22.Name = "Label22"
        Me.Label22.Size = New System.Drawing.Size(155, 22)
        Me.Label22.TabIndex = 33
        Me.Label22.Text = "Segundo Nombre:"
        '
        'txtEmpresa
        '
        Me.txtEmpresa.Location = New System.Drawing.Point(206, 472)
        Me.txtEmpresa.Name = "txtEmpresa"
        Me.txtEmpresa.Size = New System.Drawing.Size(241, 20)
        Me.txtEmpresa.TabIndex = 34
        '
        'Label23
        '
        Me.Label23.AutoSize = True
        Me.Label23.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label23.Location = New System.Drawing.Point(29, 470)
        Me.Label23.Name = "Label23"
        Me.Label23.Size = New System.Drawing.Size(171, 22)
        Me.Label23.TabIndex = 31
        Me.Label23.Text = "Empresa de trabajo:"
        '
        'txtEmail
        '
        Me.txtEmail.Location = New System.Drawing.Point(206, 430)
        Me.txtEmail.Name = "txtEmail"
        Me.txtEmail.Size = New System.Drawing.Size(241, 20)
        Me.txtEmail.TabIndex = 33
        '
        'txtDireccion
        '
        Me.txtDireccion.Location = New System.Drawing.Point(206, 257)
        Me.txtDireccion.Name = "txtDireccion"
        Me.txtDireccion.Size = New System.Drawing.Size(241, 20)
        Me.txtDireccion.TabIndex = 29
        '
        'txtApellido
        '
        Me.txtApellido.Location = New System.Drawing.Point(206, 93)
        Me.txtApellido.Name = "txtApellido"
        Me.txtApellido.Size = New System.Drawing.Size(241, 20)
        Me.txtApellido.TabIndex = 25
        '
        'txtPrimerNombre
        '
        Me.txtPrimerNombre.Location = New System.Drawing.Point(206, 12)
        Me.txtPrimerNombre.Name = "txtPrimerNombre"
        Me.txtPrimerNombre.Size = New System.Drawing.Size(241, 20)
        Me.txtPrimerNombre.TabIndex = 23
        '
        'Label24
        '
        Me.Label24.AutoSize = True
        Me.Label24.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label24.Location = New System.Drawing.Point(135, 428)
        Me.Label24.Name = "Label24"
        Me.Label24.Size = New System.Drawing.Size(65, 22)
        Me.Label24.TabIndex = 20
        Me.Label24.Text = "E-mail:"
        '
        'Label25
        '
        Me.Label25.AutoSize = True
        Me.Label25.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label25.Location = New System.Drawing.Point(62, 383)
        Me.Label25.Name = "Label25"
        Me.Label25.Size = New System.Drawing.Size(138, 22)
        Me.Label25.TabIndex = 17
        Me.Label25.Text = "Especialización:"
        '
        'Label26
        '
        Me.Label26.AutoSize = True
        Me.Label26.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label26.Location = New System.Drawing.Point(168, 173)
        Me.Label26.Name = "Label26"
        Me.Label26.Size = New System.Drawing.Size(32, 22)
        Me.Label26.TabIndex = 14
        Me.Label26.Text = "CI:"
        '
        'Label27
        '
        Me.Label27.AutoSize = True
        Me.Label27.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label27.Location = New System.Drawing.Point(110, 253)
        Me.Label27.Name = "Label27"
        Me.Label27.Size = New System.Drawing.Size(90, 22)
        Me.Label27.TabIndex = 11
        Me.Label27.Text = "Dirección:"
        '
        'Label28
        '
        Me.Label28.AutoSize = True
        Me.Label28.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label28.Location = New System.Drawing.Point(121, 91)
        Me.Label28.Name = "Label28"
        Me.Label28.Size = New System.Drawing.Size(79, 22)
        Me.Label28.TabIndex = 8
        Me.Label28.Text = "Apellido:"
        '
        'Label29
        '
        Me.Label29.AutoSize = True
        Me.Label29.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label29.Location = New System.Drawing.Point(122, 12)
        Me.Label29.Name = "Label29"
        Me.Label29.Size = New System.Drawing.Size(78, 22)
        Me.Label29.TabIndex = 5
        Me.Label29.Text = "Nombre:"
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
        Me.btnMinimizar.Location = New System.Drawing.Point(913, 0)
        Me.btnMinimizar.Name = "btnMinimizar"
        Me.btnMinimizar.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle
        Me.btnMinimizar.ShadowDecoration.Parent = Me.btnMinimizar
        Me.btnMinimizar.Size = New System.Drawing.Size(29, 30)
        Me.btnMinimizar.TabIndex = 49
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
        Me.btnCerrar.Location = New System.Drawing.Point(945, 0)
        Me.btnCerrar.Name = "btnCerrar"
        Me.btnCerrar.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle
        Me.btnCerrar.ShadowDecoration.Parent = Me.btnCerrar
        Me.btnCerrar.Size = New System.Drawing.Size(29, 30)
        Me.btnCerrar.TabIndex = 48
        Me.btnCerrar.Text = "X"
        Me.btnCerrar.UseTransparentBackground = True
        '
        'MenuGestor
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(980, 645)
        Me.ControlBox = False
        Me.Controls.Add(Me.btnCerrar)
        Me.Controls.Add(Me.btnMinimizar)
        Me.Controls.Add(Me.panelMenuInicio)
        Me.Controls.Add(Me.panelAgregarUsuario)
        Me.Controls.Add(Me.panelABMSintoma)
        Me.Controls.Add(Me.panelModificarEliminarMedico)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.MaximumSize = New System.Drawing.Size(980, 645)
        Me.MinimumSize = New System.Drawing.Size(964, 606)
        Me.Name = "MenuGestor"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "MenuPacienteNew"
        Me.panelMenuInicio.ResumeLayout(False)
        Me.panelMenuInicio.PerformLayout()
        Me.panelModificarEliminarMedico.ResumeLayout(False)
        Me.panelModificarEliminarMedico.PerformLayout()
        Me.panelABMSintoma.ResumeLayout(False)
        Me.panelABMSintoma.PerformLayout()
        Me.panelAgregarUsuario.ResumeLayout(False)
        Me.panelAgregarUsuario.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents panelMenuInicio As Panel
    Friend WithEvents labIniciales As Label
    Friend WithEvents labNombre As Label
    Friend WithEvents panelModificarEliminarMedico As Panel
    Friend WithEvents Label9 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents txtModDel_Direccion As TextBox
    Friend WithEvents txtModDel_Apellido As TextBox
    Friend WithEvents txtModDel_PrimerNombre As TextBox
    Friend WithEvents txtModDel_Email As TextBox
    Friend WithEvents txtModDel_Empresa As TextBox
    Friend WithEvents Label10 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents panelABMSintoma As Panel
    Friend WithEvents Label13 As Label
    Friend WithEvents Label12 As Label
    Friend WithEvents Label11 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents lstPatologia As ListView
    Friend WithEvents lstSintomas As ListView
    Friend WithEvents btnModSintoma As Button
    Friend WithEvents btnModPatologia As Button
    Friend WithEvents txtModDel_SegundoNombre As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Label15 As Label
    Friend WithEvents Label14 As Label
    Friend WithEvents txtModDel_ConfContraseña As TextBox
    Friend WithEvents txtModDel_Contraseña As TextBox
    Friend WithEvents Label16 As Label
    Friend WithEvents txtModDel_Telefono As TextBox
    Friend WithEvents dateModDel_FechaNacimiento As DateTimePicker
    Friend WithEvents Label17 As Label
    Friend WithEvents panelAgregarUsuario As Panel
    Friend WithEvents Label18 As Label
    Friend WithEvents dateFechaNacimiento As DateTimePicker
    Friend WithEvents Label19 As Label
    Friend WithEvents txtTelefono As TextBox
    Friend WithEvents Label20 As Label
    Friend WithEvents Label21 As Label
    Friend WithEvents txtConfContraseña As TextBox
    Friend WithEvents txtContraseña As TextBox
    Friend WithEvents txtSegundoNombre As TextBox
    Friend WithEvents Label22 As Label
    Friend WithEvents txtEmpresa As TextBox
    Friend WithEvents Label23 As Label
    Friend WithEvents txtEmail As TextBox
    Friend WithEvents txtDireccion As TextBox
    Friend WithEvents txtApellido As TextBox
    Friend WithEvents txtPrimerNombre As TextBox
    Friend WithEvents Label24 As Label
    Friend WithEvents Label25 As Label
    Friend WithEvents Label26 As Label
    Friend WithEvents Label27 As Label
    Friend WithEvents Label28 As Label
    Friend WithEvents Label29 As Label
    Friend WithEvents Label30 As Label
    Friend WithEvents lstModDel_Medicos As ListView
    Friend WithEvents Label31 As Label
    Friend WithEvents cbxModDel_Sexo As ComboBox
    Friend WithEvents txtModDel_Segundoapellido As TextBox
    Friend WithEvents Label32 As Label
    Friend WithEvents txtSegundoApellido As TextBox
    Friend WithEvents Label33 As Label
    Friend WithEvents btnEliminarPatologia As Button
    Friend WithEvents btnEliminarSintoma As Button
    Friend WithEvents cbxSexo As ComboBox
    Friend WithEvents txtCI As TextBox
    Friend WithEvents Label34 As Label
    Friend WithEvents txtModDel_CI As TextBox
    Friend WithEvents btnMenu_AgregarMedico As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents btn_ABMSinPat As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents btnMenu_ModUsuario As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents txtBuscarSintoma As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents txtBuscarPatologia As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents btnAgregarSintoma As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents btnAgregarPatologia As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents cbxModDel_Especializacion As ComboBox
    Friend WithEvents cbxEspecializacion As ComboBox
    Friend WithEvents btnAceptarModificar As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents btnEliminarMedico As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents btnAgregarMedico As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents btnMinimizar As Guna.UI2.WinForms.Guna2CircleButton
    Friend WithEvents btnCerrar As Guna.UI2.WinForms.Guna2CircleButton
End Class
