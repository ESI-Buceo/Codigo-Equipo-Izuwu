<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class MenuPaciente
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
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(MenuPaciente))
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.panelRealizarDiagnostico = New System.Windows.Forms.Panel()
        Me.paelRealizaDiagnostico2 = New System.Windows.Forms.Panel()
        Me.txtBusquedaSintomas = New Guna.UI2.WinForms.Guna2TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.btnAgregar = New Guna.UI2.WinForms.Guna2Button()
        Me.lstSintomas = New System.Windows.Forms.ListView()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.btnMenu_RealizarDiagnostico = New Guna.UI2.WinForms.Guna2Button()
        Me.btnCerrarSesion = New Guna.UI2.WinForms.Guna2Button()
        Me.labIniciales = New System.Windows.Forms.Label()
        Me.labHistorialMedico = New System.Windows.Forms.Label()
        Me.labNombre = New System.Windows.Forms.Label()
        Me.btnChats1 = New Guna.UI2.WinForms.Guna2Button()
        Me.labVolverDisgnostico = New System.Windows.Forms.Label()
        Me.panelListaChats = New System.Windows.Forms.Panel()
        Me.panelChat = New System.Windows.Forms.Panel()
        Me.txtMensaje = New System.Windows.Forms.TextBox()
        Me.txtChat = New System.Windows.Forms.TextBox()
        Me.btnEnviar = New Guna.UI2.WinForms.Guna2Button()
        Me.panelRealizarDiagnostico2 = New System.Windows.Forms.Panel()
        Me.btnFinalizarConsulta = New Guna.UI2.WinForms.Guna2Button()
        Me.labTituloDiagnostico = New System.Windows.Forms.Label()
        Me.Guna2CustomGradientPanel1 = New Guna.UI2.WinForms.Guna2CustomGradientPanel()
        Me.labDiagnostico1 = New System.Windows.Forms.Label()
        Me.labDiagnostico4 = New System.Windows.Forms.Label()
        Me.labDiagnostico2 = New System.Windows.Forms.Label()
        Me.labDiagnostico3 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.lstSintomasSeleccionados = New System.Windows.Forms.ListView()
        Me.btnRealizardiagnostico = New Guna.UI2.WinForms.Guna2Button()
        Me.btnEliminar = New Guna.UI2.WinForms.Guna2Button()
        Me.panelPerfil = New System.Windows.Forms.Panel()
        Me.btnEditarPerfil = New Guna.UI2.WinForms.Guna2Button()
        Me.labPerfilID = New System.Windows.Forms.Label()
        Me.labPerfilNombre = New System.Windows.Forms.Label()
        Me.labVolverPerfil = New System.Windows.Forms.Label()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.pdatosPaciente = New System.Windows.Forms.Panel()
        Me.labPerfilDireccion = New System.Windows.Forms.Label()
        Me.labPerfilTelefono = New System.Windows.Forms.Label()
        Me.labPerfilFechaDeNacimiento = New System.Windows.Forms.Label()
        Me.txtPerfilPatologias = New System.Windows.Forms.TextBox()
        Me.labPerfilPatologias = New System.Windows.Forms.Label()
        Me.label17 = New System.Windows.Forms.Label()
        Me.label16 = New System.Windows.Forms.Label()
        Me.label15 = New System.Windows.Forms.Label()
        Me.panelDatosMedicos = New System.Windows.Forms.Panel()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.labEspecialidadMED = New System.Windows.Forms.Label()
        Me.labLugardeTrabajoMED = New System.Windows.Forms.Label()
        Me.refrescarChat = New System.Windows.Forms.Timer(Me.components)
        Me.btnMinimizar = New Guna.UI2.WinForms.Guna2CircleButton()
        Me.btnCerrar = New Guna.UI2.WinForms.Guna2CircleButton()
        Me.Panel1.SuspendLayout()
        Me.panelRealizarDiagnostico.SuspendLayout()
        Me.paelRealizaDiagnostico2.SuspendLayout()
        Me.panelChat.SuspendLayout()
        Me.panelRealizarDiagnostico2.SuspendLayout()
        Me.Guna2CustomGradientPanel1.SuspendLayout()
        Me.panelPerfil.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.pdatosPaciente.SuspendLayout()
        Me.panelDatosMedicos.SuspendLayout()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.FromArgb(CType(CType(40, Byte), Integer), CType(CType(117, Byte), Integer), CType(CType(207, Byte), Integer))
        Me.Panel1.Controls.Add(Me.panelRealizarDiagnostico)
        Me.Panel1.Controls.Add(Me.btnCerrarSesion)
        Me.Panel1.Controls.Add(Me.labIniciales)
        Me.Panel1.Controls.Add(Me.labHistorialMedico)
        Me.Panel1.Controls.Add(Me.labNombre)
        Me.Panel1.Controls.Add(Me.btnChats1)
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(284, 648)
        Me.Panel1.TabIndex = 1
        '
        'panelRealizarDiagnostico
        '
        Me.panelRealizarDiagnostico.Controls.Add(Me.paelRealizaDiagnostico2)
        Me.panelRealizarDiagnostico.Controls.Add(Me.btnAgregar)
        Me.panelRealizarDiagnostico.Controls.Add(Me.lstSintomas)
        Me.panelRealizarDiagnostico.Controls.Add(Me.Label4)
        Me.panelRealizarDiagnostico.Controls.Add(Me.btnMenu_RealizarDiagnostico)
        Me.panelRealizarDiagnostico.Location = New System.Drawing.Point(0, 71)
        Me.panelRealizarDiagnostico.Name = "panelRealizarDiagnostico"
        Me.panelRealizarDiagnostico.Size = New System.Drawing.Size(284, 582)
        Me.panelRealizarDiagnostico.TabIndex = 27
        '
        'paelRealizaDiagnostico2
        '
        Me.paelRealizaDiagnostico2.BackColor = System.Drawing.Color.Transparent
        Me.paelRealizaDiagnostico2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.paelRealizaDiagnostico2.Controls.Add(Me.txtBusquedaSintomas)
        Me.paelRealizaDiagnostico2.Controls.Add(Me.Label1)
        Me.paelRealizaDiagnostico2.Location = New System.Drawing.Point(39, 13)
        Me.paelRealizaDiagnostico2.Name = "paelRealizaDiagnostico2"
        Me.paelRealizaDiagnostico2.Size = New System.Drawing.Size(206, 54)
        Me.paelRealizaDiagnostico2.TabIndex = 8
        '
        'txtBusquedaSintomas
        '
        Me.txtBusquedaSintomas.Animated = True
        Me.txtBusquedaSintomas.AutoRoundedCorners = True
        Me.txtBusquedaSintomas.BorderRadius = 9
        Me.txtBusquedaSintomas.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtBusquedaSintomas.DefaultText = ""
        Me.txtBusquedaSintomas.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.txtBusquedaSintomas.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.txtBusquedaSintomas.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txtBusquedaSintomas.DisabledState.Parent = Me.txtBusquedaSintomas
        Me.txtBusquedaSintomas.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txtBusquedaSintomas.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txtBusquedaSintomas.FocusedState.Parent = Me.txtBusquedaSintomas
        Me.txtBusquedaSintomas.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.txtBusquedaSintomas.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.txtBusquedaSintomas.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txtBusquedaSintomas.HoverState.Parent = Me.txtBusquedaSintomas
        Me.txtBusquedaSintomas.Location = New System.Drawing.Point(17, 25)
        Me.txtBusquedaSintomas.Name = "txtBusquedaSintomas"
        Me.txtBusquedaSintomas.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtBusquedaSintomas.PlaceholderText = ""
        Me.txtBusquedaSintomas.SelectedText = ""
        Me.txtBusquedaSintomas.ShadowDecoration.Parent = Me.txtBusquedaSintomas
        Me.txtBusquedaSintomas.Size = New System.Drawing.Size(173, 20)
        Me.txtBusquedaSintomas.TabIndex = 25
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Label1.Location = New System.Drawing.Point(51, 6)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(109, 16)
        Me.Label1.TabIndex = 19
        Me.Label1.Text = "Busca tu síntoma"
        '
        'btnAgregar
        '
        Me.btnAgregar.Animated = True
        Me.btnAgregar.AutoRoundedCorners = True
        Me.btnAgregar.BackColor = System.Drawing.Color.Transparent
        Me.btnAgregar.BorderRadius = 13
        Me.btnAgregar.CheckedState.Parent = Me.btnAgregar
        Me.btnAgregar.CustomImages.Parent = Me.btnAgregar
        Me.btnAgregar.FillColor = System.Drawing.Color.FromArgb(CType(CType(24, Byte), Integer), CType(CType(69, Byte), Integer), CType(CType(122, Byte), Integer))
        Me.btnAgregar.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.btnAgregar.ForeColor = System.Drawing.Color.White
        Me.btnAgregar.HoverState.Parent = Me.btnAgregar
        Me.btnAgregar.Location = New System.Drawing.Point(94, 492)
        Me.btnAgregar.Name = "btnAgregar"
        Me.btnAgregar.ShadowDecoration.Parent = Me.btnAgregar
        Me.btnAgregar.Size = New System.Drawing.Size(92, 28)
        Me.btnAgregar.TabIndex = 14
        Me.btnAgregar.Text = "Agregar"
        '
        'lstSintomas
        '
        Me.lstSintomas.BackColor = System.Drawing.Color.White
        Me.lstSintomas.Font = New System.Drawing.Font("Yu Gothic UI", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lstSintomas.HideSelection = False
        Me.lstSintomas.Location = New System.Drawing.Point(4, 73)
        Me.lstSintomas.MultiSelect = False
        Me.lstSintomas.Name = "lstSintomas"
        Me.lstSintomas.Size = New System.Drawing.Size(278, 390)
        Me.lstSintomas.TabIndex = 10
        Me.lstSintomas.UseCompatibleStateImageBehavior = False
        Me.lstSintomas.View = System.Windows.Forms.View.Tile
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.ForeColor = System.Drawing.Color.White
        Me.Label4.Location = New System.Drawing.Point(13, 542)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(113, 13)
        Me.Label4.TabIndex = 9
        Me.Label4.Text = "Politicas de privacidad"
        '
        'btnMenu_RealizarDiagnostico
        '
        Me.btnMenu_RealizarDiagnostico.Animated = True
        Me.btnMenu_RealizarDiagnostico.BackColor = System.Drawing.Color.Transparent
        Me.btnMenu_RealizarDiagnostico.CheckedState.Parent = Me.btnMenu_RealizarDiagnostico
        Me.btnMenu_RealizarDiagnostico.CustomImages.Parent = Me.btnMenu_RealizarDiagnostico
        Me.btnMenu_RealizarDiagnostico.FillColor = System.Drawing.Color.FromArgb(CType(CType(40, Byte), Integer), CType(CType(117, Byte), Integer), CType(CType(207, Byte), Integer))
        Me.btnMenu_RealizarDiagnostico.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.btnMenu_RealizarDiagnostico.ForeColor = System.Drawing.Color.White
        Me.btnMenu_RealizarDiagnostico.HoverState.Parent = Me.btnMenu_RealizarDiagnostico
        Me.btnMenu_RealizarDiagnostico.Location = New System.Drawing.Point(0, 109)
        Me.btnMenu_RealizarDiagnostico.Name = "btnMenu_RealizarDiagnostico"
        Me.btnMenu_RealizarDiagnostico.ShadowDecoration.Parent = Me.btnMenu_RealizarDiagnostico
        Me.btnMenu_RealizarDiagnostico.Size = New System.Drawing.Size(291, 47)
        Me.btnMenu_RealizarDiagnostico.TabIndex = 28
        Me.btnMenu_RealizarDiagnostico.Text = "Realizar Diagnostico"
        '
        'btnCerrarSesion
        '
        Me.btnCerrarSesion.Animated = True
        Me.btnCerrarSesion.BackColor = System.Drawing.Color.Transparent
        Me.btnCerrarSesion.CheckedState.Parent = Me.btnCerrarSesion
        Me.btnCerrarSesion.CustomImages.Parent = Me.btnCerrarSesion
        Me.btnCerrarSesion.FillColor = System.Drawing.Color.FromArgb(CType(CType(40, Byte), Integer), CType(CType(117, Byte), Integer), CType(CType(207, Byte), Integer))
        Me.btnCerrarSesion.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.btnCerrarSesion.ForeColor = System.Drawing.Color.White
        Me.btnCerrarSesion.HoverState.Parent = Me.btnCerrarSesion
        Me.btnCerrarSesion.Location = New System.Drawing.Point(0, 392)
        Me.btnCerrarSesion.Name = "btnCerrarSesion"
        Me.btnCerrarSesion.ShadowDecoration.Parent = Me.btnCerrarSesion
        Me.btnCerrarSesion.Size = New System.Drawing.Size(291, 47)
        Me.btnCerrarSesion.TabIndex = 24
        Me.btnCerrarSesion.Text = "Cerrar sesión"
        '
        'labIniciales
        '
        Me.labIniciales.AutoSize = True
        Me.labIniciales.BackColor = System.Drawing.Color.FromArgb(CType(CType(40, Byte), Integer), CType(CType(117, Byte), Integer), CType(CType(207, Byte), Integer))
        Me.labIniciales.Font = New System.Drawing.Font("Microsoft Sans Serif", 28.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.labIniciales.ForeColor = System.Drawing.Color.White
        Me.labIniciales.Location = New System.Drawing.Point(12, 16)
        Me.labIniciales.Name = "labIniciales"
        Me.labIniciales.Size = New System.Drawing.Size(84, 44)
        Me.labIniciales.TabIndex = 8
        Me.labIniciales.Text = "N U"
        '
        'labHistorialMedico
        '
        Me.labHistorialMedico.AutoSize = True
        Me.labHistorialMedico.ForeColor = System.Drawing.Color.White
        Me.labHistorialMedico.Location = New System.Drawing.Point(105, 49)
        Me.labHistorialMedico.Name = "labHistorialMedico"
        Me.labHistorialMedico.Size = New System.Drawing.Size(81, 13)
        Me.labHistorialMedico.TabIndex = 7
        Me.labHistorialMedico.Text = "Historial médico"
        '
        'labNombre
        '
        Me.labNombre.AutoSize = True
        Me.labNombre.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.labNombre.ForeColor = System.Drawing.Color.White
        Me.labNombre.Location = New System.Drawing.Point(103, 9)
        Me.labNombre.Name = "labNombre"
        Me.labNombre.Size = New System.Drawing.Size(153, 25)
        Me.labNombre.TabIndex = 5
        Me.labNombre.Text = "Nombre Usuario"
        '
        'btnChats1
        '
        Me.btnChats1.Animated = True
        Me.btnChats1.BackColor = System.Drawing.Color.Transparent
        Me.btnChats1.CheckedState.Parent = Me.btnChats1
        Me.btnChats1.CustomImages.Parent = Me.btnChats1
        Me.btnChats1.FillColor = System.Drawing.Color.FromArgb(CType(CType(40, Byte), Integer), CType(CType(117, Byte), Integer), CType(CType(207, Byte), Integer))
        Me.btnChats1.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.btnChats1.ForeColor = System.Drawing.Color.White
        Me.btnChats1.HoverState.Parent = Me.btnChats1
        Me.btnChats1.Location = New System.Drawing.Point(0, 286)
        Me.btnChats1.Name = "btnChats1"
        Me.btnChats1.ShadowDecoration.Parent = Me.btnChats1
        Me.btnChats1.Size = New System.Drawing.Size(291, 47)
        Me.btnChats1.TabIndex = 25
        Me.btnChats1.Text = "Chats"
        '
        'labVolverDisgnostico
        '
        Me.labVolverDisgnostico.AutoSize = True
        Me.labVolverDisgnostico.Font = New System.Drawing.Font("Yu Gothic UI", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.labVolverDisgnostico.Location = New System.Drawing.Point(1, 2)
        Me.labVolverDisgnostico.Name = "labVolverDisgnostico"
        Me.labVolverDisgnostico.Size = New System.Drawing.Size(39, 32)
        Me.labVolverDisgnostico.TabIndex = 23
        Me.labVolverDisgnostico.Text = "←"
        '
        'panelListaChats
        '
        Me.panelListaChats.AutoScroll = True
        Me.panelListaChats.BackColor = System.Drawing.Color.FromArgb(CType(CType(24, Byte), Integer), CType(CType(69, Byte), Integer), CType(CType(122, Byte), Integer))
        Me.panelListaChats.Location = New System.Drawing.Point(284, 0)
        Me.panelListaChats.Name = "panelListaChats"
        Me.panelListaChats.Size = New System.Drawing.Size(71, 647)
        Me.panelListaChats.TabIndex = 7
        '
        'panelChat
        '
        Me.panelChat.Controls.Add(Me.txtMensaje)
        Me.panelChat.Controls.Add(Me.txtChat)
        Me.panelChat.Controls.Add(Me.btnEnviar)
        Me.panelChat.Location = New System.Drawing.Point(355, 31)
        Me.panelChat.Name = "panelChat"
        Me.panelChat.Size = New System.Drawing.Size(620, 611)
        Me.panelChat.TabIndex = 9
        '
        'txtMensaje
        '
        Me.txtMensaje.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtMensaje.Location = New System.Drawing.Point(21, 546)
        Me.txtMensaje.Name = "txtMensaje"
        Me.txtMensaje.Size = New System.Drawing.Size(468, 22)
        Me.txtMensaje.TabIndex = 1
        '
        'txtChat
        '
        Me.txtChat.BackColor = System.Drawing.Color.White
        Me.txtChat.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtChat.Location = New System.Drawing.Point(21, 17)
        Me.txtChat.Multiline = True
        Me.txtChat.Name = "txtChat"
        Me.txtChat.ReadOnly = True
        Me.txtChat.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.txtChat.Size = New System.Drawing.Size(560, 507)
        Me.txtChat.TabIndex = 0
        '
        'btnEnviar
        '
        Me.btnEnviar.Animated = True
        Me.btnEnviar.AutoRoundedCorners = True
        Me.btnEnviar.BorderRadius = 16
        Me.btnEnviar.CheckedState.Parent = Me.btnEnviar
        Me.btnEnviar.CustomImages.Parent = Me.btnEnviar
        Me.btnEnviar.FillColor = System.Drawing.Color.FromArgb(CType(CType(24, Byte), Integer), CType(CType(69, Byte), Integer), CType(CType(122, Byte), Integer))
        Me.btnEnviar.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.btnEnviar.ForeColor = System.Drawing.Color.White
        Me.btnEnviar.HoverState.Parent = Me.btnEnviar
        Me.btnEnviar.Location = New System.Drawing.Point(508, 540)
        Me.btnEnviar.Name = "btnEnviar"
        Me.btnEnviar.ShadowDecoration.Parent = Me.btnEnviar
        Me.btnEnviar.Size = New System.Drawing.Size(82, 34)
        Me.btnEnviar.TabIndex = 3
        Me.btnEnviar.Text = "Enviar"
        '
        'panelRealizarDiagnostico2
        '
        Me.panelRealizarDiagnostico2.Controls.Add(Me.btnFinalizarConsulta)
        Me.panelRealizarDiagnostico2.Controls.Add(Me.labTituloDiagnostico)
        Me.panelRealizarDiagnostico2.Controls.Add(Me.Guna2CustomGradientPanel1)
        Me.panelRealizarDiagnostico2.Controls.Add(Me.labVolverDisgnostico)
        Me.panelRealizarDiagnostico2.Controls.Add(Me.Label3)
        Me.panelRealizarDiagnostico2.Controls.Add(Me.lstSintomasSeleccionados)
        Me.panelRealizarDiagnostico2.Controls.Add(Me.btnRealizardiagnostico)
        Me.panelRealizarDiagnostico2.Controls.Add(Me.btnEliminar)
        Me.panelRealizarDiagnostico2.Location = New System.Drawing.Point(305, 31)
        Me.panelRealizarDiagnostico2.Name = "panelRealizarDiagnostico2"
        Me.panelRealizarDiagnostico2.Size = New System.Drawing.Size(669, 611)
        Me.panelRealizarDiagnostico2.TabIndex = 10
        '
        'btnFinalizarConsulta
        '
        Me.btnFinalizarConsulta.Animated = True
        Me.btnFinalizarConsulta.AutoRoundedCorners = True
        Me.btnFinalizarConsulta.BackColor = System.Drawing.Color.Transparent
        Me.btnFinalizarConsulta.BorderRadius = 23
        Me.btnFinalizarConsulta.CheckedState.Parent = Me.btnFinalizarConsulta
        Me.btnFinalizarConsulta.CustomImages.Parent = Me.btnFinalizarConsulta
        Me.btnFinalizarConsulta.FillColor = System.Drawing.Color.FromArgb(CType(CType(24, Byte), Integer), CType(CType(69, Byte), Integer), CType(CType(122, Byte), Integer))
        Me.btnFinalizarConsulta.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.btnFinalizarConsulta.ForeColor = System.Drawing.Color.White
        Me.btnFinalizarConsulta.HoverState.Parent = Me.btnFinalizarConsulta
        Me.btnFinalizarConsulta.Location = New System.Drawing.Point(487, 530)
        Me.btnFinalizarConsulta.Name = "btnFinalizarConsulta"
        Me.btnFinalizarConsulta.ShadowDecoration.Parent = Me.btnFinalizarConsulta
        Me.btnFinalizarConsulta.Size = New System.Drawing.Size(92, 49)
        Me.btnFinalizarConsulta.TabIndex = 30
        Me.btnFinalizarConsulta.Text = "Finalizar consulta"
        '
        'labTituloDiagnostico
        '
        Me.labTituloDiagnostico.AutoSize = True
        Me.labTituloDiagnostico.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.labTituloDiagnostico.Location = New System.Drawing.Point(410, 191)
        Me.labTituloDiagnostico.Name = "labTituloDiagnostico"
        Me.labTituloDiagnostico.Size = New System.Drawing.Size(125, 24)
        Me.labTituloDiagnostico.TabIndex = 17
        Me.labTituloDiagnostico.Text = "Diagnóstico:"
        '
        'Guna2CustomGradientPanel1
        '
        Me.Guna2CustomGradientPanel1.BorderColor = System.Drawing.Color.Transparent
        Me.Guna2CustomGradientPanel1.Controls.Add(Me.labDiagnostico1)
        Me.Guna2CustomGradientPanel1.Controls.Add(Me.labDiagnostico4)
        Me.Guna2CustomGradientPanel1.Controls.Add(Me.labDiagnostico2)
        Me.Guna2CustomGradientPanel1.Controls.Add(Me.labDiagnostico3)
        Me.Guna2CustomGradientPanel1.CustomBorderColor = System.Drawing.Color.Black
        Me.Guna2CustomGradientPanel1.CustomBorderThickness = New System.Windows.Forms.Padding(3)
        Me.Guna2CustomGradientPanel1.Location = New System.Drawing.Point(414, 226)
        Me.Guna2CustomGradientPanel1.Name = "Guna2CustomGradientPanel1"
        Me.Guna2CustomGradientPanel1.ShadowDecoration.Parent = Me.Guna2CustomGradientPanel1
        Me.Guna2CustomGradientPanel1.Size = New System.Drawing.Size(221, 298)
        Me.Guna2CustomGradientPanel1.TabIndex = 29
        '
        'labDiagnostico1
        '
        Me.labDiagnostico1.AutoSize = True
        Me.labDiagnostico1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.labDiagnostico1.Location = New System.Drawing.Point(44, 43)
        Me.labDiagnostico1.Name = "labDiagnostico1"
        Me.labDiagnostico1.Size = New System.Drawing.Size(109, 20)
        Me.labDiagnostico1.TabIndex = 18
        Me.labDiagnostico1.Text = "labResutado1"
        '
        'labDiagnostico4
        '
        Me.labDiagnostico4.AutoSize = True
        Me.labDiagnostico4.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.labDiagnostico4.Location = New System.Drawing.Point(44, 222)
        Me.labDiagnostico4.Name = "labDiagnostico4"
        Me.labDiagnostico4.Size = New System.Drawing.Size(57, 20)
        Me.labDiagnostico4.TabIndex = 27
        Me.labDiagnostico4.Text = "Label2"
        '
        'labDiagnostico2
        '
        Me.labDiagnostico2.AutoSize = True
        Me.labDiagnostico2.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.labDiagnostico2.Location = New System.Drawing.Point(44, 102)
        Me.labDiagnostico2.Name = "labDiagnostico2"
        Me.labDiagnostico2.Size = New System.Drawing.Size(57, 20)
        Me.labDiagnostico2.TabIndex = 25
        Me.labDiagnostico2.Text = "Label2"
        '
        'labDiagnostico3
        '
        Me.labDiagnostico3.AutoSize = True
        Me.labDiagnostico3.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.labDiagnostico3.Location = New System.Drawing.Point(44, 162)
        Me.labDiagnostico3.Name = "labDiagnostico3"
        Me.labDiagnostico3.Size = New System.Drawing.Size(57, 20)
        Me.labDiagnostico3.TabIndex = 26
        Me.labDiagnostico3.Text = "Label2"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(28, 191)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(245, 24)
        Me.Label3.TabIndex = 16
        Me.Label3.Text = "Síntomas Seleccionados:"
        '
        'lstSintomasSeleccionados
        '
        Me.lstSintomasSeleccionados.Font = New System.Drawing.Font("Yu Gothic UI", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lstSintomasSeleccionados.HideSelection = False
        Me.lstSintomasSeleccionados.Location = New System.Drawing.Point(32, 226)
        Me.lstSintomasSeleccionados.MultiSelect = False
        Me.lstSintomasSeleccionados.Name = "lstSintomasSeleccionados"
        Me.lstSintomasSeleccionados.Size = New System.Drawing.Size(263, 298)
        Me.lstSintomasSeleccionados.TabIndex = 15
        Me.lstSintomasSeleccionados.UseCompatibleStateImageBehavior = False
        Me.lstSintomasSeleccionados.View = System.Windows.Forms.View.Tile
        '
        'btnRealizardiagnostico
        '
        Me.btnRealizardiagnostico.Animated = True
        Me.btnRealizardiagnostico.AutoRoundedCorners = True
        Me.btnRealizardiagnostico.BackColor = System.Drawing.Color.Transparent
        Me.btnRealizardiagnostico.BorderRadius = 23
        Me.btnRealizardiagnostico.CheckedState.Parent = Me.btnRealizardiagnostico
        Me.btnRealizardiagnostico.CustomImages.Parent = Me.btnRealizardiagnostico
        Me.btnRealizardiagnostico.FillColor = System.Drawing.Color.FromArgb(CType(CType(24, Byte), Integer), CType(CType(69, Byte), Integer), CType(CType(122, Byte), Integer))
        Me.btnRealizardiagnostico.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.btnRealizardiagnostico.ForeColor = System.Drawing.Color.White
        Me.btnRealizardiagnostico.HoverState.Parent = Me.btnRealizardiagnostico
        Me.btnRealizardiagnostico.Location = New System.Drawing.Point(311, 328)
        Me.btnRealizardiagnostico.Name = "btnRealizardiagnostico"
        Me.btnRealizardiagnostico.ShadowDecoration.Parent = Me.btnRealizardiagnostico
        Me.btnRealizardiagnostico.Size = New System.Drawing.Size(92, 49)
        Me.btnRealizardiagnostico.TabIndex = 15
        Me.btnRealizardiagnostico.Text = "Relizar Diagnóstico"
        '
        'btnEliminar
        '
        Me.btnEliminar.Animated = True
        Me.btnEliminar.AutoRoundedCorners = True
        Me.btnEliminar.BackColor = System.Drawing.Color.Transparent
        Me.btnEliminar.BorderRadius = 13
        Me.btnEliminar.CheckedState.Parent = Me.btnEliminar
        Me.btnEliminar.CustomImages.Parent = Me.btnEliminar
        Me.btnEliminar.FillColor = System.Drawing.Color.FromArgb(CType(CType(241, Byte), Integer), CType(CType(33, Byte), Integer), CType(CType(33, Byte), Integer))
        Me.btnEliminar.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.btnEliminar.ForeColor = System.Drawing.Color.White
        Me.btnEliminar.HoverState.Parent = Me.btnEliminar
        Me.btnEliminar.Location = New System.Drawing.Point(32, 540)
        Me.btnEliminar.Name = "btnEliminar"
        Me.btnEliminar.ShadowDecoration.Parent = Me.btnEliminar
        Me.btnEliminar.Size = New System.Drawing.Size(92, 28)
        Me.btnEliminar.TabIndex = 24
        Me.btnEliminar.Text = "Eliminar"
        '
        'panelPerfil
        '
        Me.panelPerfil.BackColor = System.Drawing.Color.White
        Me.panelPerfil.Controls.Add(Me.btnEditarPerfil)
        Me.panelPerfil.Controls.Add(Me.labPerfilID)
        Me.panelPerfil.Controls.Add(Me.labPerfilNombre)
        Me.panelPerfil.Controls.Add(Me.labVolverPerfil)
        Me.panelPerfil.Controls.Add(Me.PictureBox1)
        Me.panelPerfil.Controls.Add(Me.pdatosPaciente)
        Me.panelPerfil.Controls.Add(Me.panelDatosMedicos)
        Me.panelPerfil.Location = New System.Drawing.Point(297, 31)
        Me.panelPerfil.Name = "panelPerfil"
        Me.panelPerfil.Size = New System.Drawing.Size(682, 608)
        Me.panelPerfil.TabIndex = 11
        '
        'btnEditarPerfil
        '
        Me.btnEditarPerfil.Animated = True
        Me.btnEditarPerfil.AutoRoundedCorners = True
        Me.btnEditarPerfil.BorderRadius = 22
        Me.btnEditarPerfil.BorderThickness = 1
        Me.btnEditarPerfil.CheckedState.Parent = Me.btnEditarPerfil
        Me.btnEditarPerfil.CustomImages.Parent = Me.btnEditarPerfil
        Me.btnEditarPerfil.FillColor = System.Drawing.Color.White
        Me.btnEditarPerfil.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.btnEditarPerfil.ForeColor = System.Drawing.Color.Black
        Me.btnEditarPerfil.HoverState.Parent = Me.btnEditarPerfil
        Me.btnEditarPerfil.Location = New System.Drawing.Point(615, 17)
        Me.btnEditarPerfil.Name = "btnEditarPerfil"
        Me.btnEditarPerfil.ShadowDecoration.Parent = Me.btnEditarPerfil
        Me.btnEditarPerfil.Size = New System.Drawing.Size(52, 46)
        Me.btnEditarPerfil.TabIndex = 27
        Me.btnEditarPerfil.Text = "Editar perfil"
        '
        'labPerfilID
        '
        Me.labPerfilID.Font = New System.Drawing.Font("Yu Gothic UI Semilight", 13.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.labPerfilID.ForeColor = System.Drawing.Color.Black
        Me.labPerfilID.Location = New System.Drawing.Point(53, 226)
        Me.labPerfilID.Name = "labPerfilID"
        Me.labPerfilID.Size = New System.Drawing.Size(590, 25)
        Me.labPerfilID.TabIndex = 13
        Me.labPerfilID.Text = "ID Paciente O MED"
        Me.labPerfilID.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'labPerfilNombre
        '
        Me.labPerfilNombre.Font = New System.Drawing.Font("Yu Gothic UI", 24.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.labPerfilNombre.ForeColor = System.Drawing.Color.Black
        Me.labPerfilNombre.Location = New System.Drawing.Point(45, 179)
        Me.labPerfilNombre.Name = "labPerfilNombre"
        Me.labPerfilNombre.Size = New System.Drawing.Size(615, 45)
        Me.labPerfilNombre.TabIndex = 13
        Me.labPerfilNombre.Text = "Nombre Usuario"
        Me.labPerfilNombre.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'labVolverPerfil
        '
        Me.labVolverPerfil.AutoSize = True
        Me.labVolverPerfil.Font = New System.Drawing.Font("Yu Gothic UI", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.labVolverPerfil.Location = New System.Drawing.Point(3, 7)
        Me.labVolverPerfil.Name = "labVolverPerfil"
        Me.labVolverPerfil.Size = New System.Drawing.Size(31, 25)
        Me.labVolverPerfil.TabIndex = 24
        Me.labVolverPerfil.Text = "←"
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(270, 29)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(159, 147)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox1.TabIndex = 0
        Me.PictureBox1.TabStop = False
        '
        'pdatosPaciente
        '
        Me.pdatosPaciente.Controls.Add(Me.labPerfilDireccion)
        Me.pdatosPaciente.Controls.Add(Me.labPerfilTelefono)
        Me.pdatosPaciente.Controls.Add(Me.labPerfilFechaDeNacimiento)
        Me.pdatosPaciente.Controls.Add(Me.txtPerfilPatologias)
        Me.pdatosPaciente.Controls.Add(Me.labPerfilPatologias)
        Me.pdatosPaciente.Controls.Add(Me.label17)
        Me.pdatosPaciente.Controls.Add(Me.label16)
        Me.pdatosPaciente.Controls.Add(Me.label15)
        Me.pdatosPaciente.Location = New System.Drawing.Point(7, 350)
        Me.pdatosPaciente.Name = "pdatosPaciente"
        Me.pdatosPaciente.Size = New System.Drawing.Size(668, 245)
        Me.pdatosPaciente.TabIndex = 25
        '
        'labPerfilDireccion
        '
        Me.labPerfilDireccion.AutoSize = True
        Me.labPerfilDireccion.Font = New System.Drawing.Font("Yu Gothic UI Semilight", 13.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.labPerfilDireccion.ForeColor = System.Drawing.Color.Black
        Me.labPerfilDireccion.Location = New System.Drawing.Point(183, 163)
        Me.labPerfilDireccion.Name = "labPerfilDireccion"
        Me.labPerfilDireccion.Size = New System.Drawing.Size(102, 25)
        Me.labPerfilDireccion.TabIndex = 21
        Me.labPerfilDireccion.Text = "No cargado"
        '
        'labPerfilTelefono
        '
        Me.labPerfilTelefono.AutoSize = True
        Me.labPerfilTelefono.Font = New System.Drawing.Font("Yu Gothic UI Semilight", 13.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.labPerfilTelefono.ForeColor = System.Drawing.Color.Black
        Me.labPerfilTelefono.Location = New System.Drawing.Point(183, 109)
        Me.labPerfilTelefono.Name = "labPerfilTelefono"
        Me.labPerfilTelefono.Size = New System.Drawing.Size(102, 25)
        Me.labPerfilTelefono.TabIndex = 20
        Me.labPerfilTelefono.Text = "No cargado"
        '
        'labPerfilFechaDeNacimiento
        '
        Me.labPerfilFechaDeNacimiento.AutoSize = True
        Me.labPerfilFechaDeNacimiento.Font = New System.Drawing.Font("Yu Gothic UI Semilight", 13.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.labPerfilFechaDeNacimiento.ForeColor = System.Drawing.Color.Black
        Me.labPerfilFechaDeNacimiento.Location = New System.Drawing.Point(183, 57)
        Me.labPerfilFechaDeNacimiento.Name = "labPerfilFechaDeNacimiento"
        Me.labPerfilFechaDeNacimiento.Size = New System.Drawing.Size(102, 25)
        Me.labPerfilFechaDeNacimiento.TabIndex = 19
        Me.labPerfilFechaDeNacimiento.Text = "No cargado"
        '
        'txtPerfilPatologias
        '
        Me.txtPerfilPatologias.BackColor = System.Drawing.Color.White
        Me.txtPerfilPatologias.Font = New System.Drawing.Font("Yu Gothic UI Semilight", 10.0!)
        Me.txtPerfilPatologias.Location = New System.Drawing.Point(358, 85)
        Me.txtPerfilPatologias.Multiline = True
        Me.txtPerfilPatologias.Name = "txtPerfilPatologias"
        Me.txtPerfilPatologias.ReadOnly = True
        Me.txtPerfilPatologias.Size = New System.Drawing.Size(305, 106)
        Me.txtPerfilPatologias.TabIndex = 18
        '
        'labPerfilPatologias
        '
        Me.labPerfilPatologias.AutoSize = True
        Me.labPerfilPatologias.Font = New System.Drawing.Font("Yu Gothic UI Semilight", 13.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.labPerfilPatologias.ForeColor = System.Drawing.Color.Black
        Me.labPerfilPatologias.Location = New System.Drawing.Point(353, 57)
        Me.labPerfilPatologias.Name = "labPerfilPatologias"
        Me.labPerfilPatologias.Size = New System.Drawing.Size(153, 25)
        Me.labPerfilPatologias.TabIndex = 17
        Me.labPerfilPatologias.Text = "Patologías Previas:"
        '
        'label17
        '
        Me.label17.AutoSize = True
        Me.label17.Font = New System.Drawing.Font("Yu Gothic UI Semilight", 13.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.label17.ForeColor = System.Drawing.Color.Black
        Me.label17.Location = New System.Drawing.Point(90, 163)
        Me.label17.Name = "label17"
        Me.label17.Size = New System.Drawing.Size(87, 25)
        Me.label17.TabIndex = 16
        Me.label17.Text = "Dirección:"
        '
        'label16
        '
        Me.label16.AutoSize = True
        Me.label16.Font = New System.Drawing.Font("Yu Gothic UI Semilight", 13.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.label16.ForeColor = System.Drawing.Color.Black
        Me.label16.Location = New System.Drawing.Point(97, 109)
        Me.label16.Name = "label16"
        Me.label16.Size = New System.Drawing.Size(80, 25)
        Me.label16.TabIndex = 15
        Me.label16.Text = "Teléfono:"
        '
        'label15
        '
        Me.label15.AutoSize = True
        Me.label15.Font = New System.Drawing.Font("Yu Gothic UI Semilight", 13.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.label15.ForeColor = System.Drawing.Color.Black
        Me.label15.Location = New System.Drawing.Point(3, 57)
        Me.label15.Name = "label15"
        Me.label15.Size = New System.Drawing.Size(174, 25)
        Me.label15.TabIndex = 14
        Me.label15.Text = "Fecha de nacimiento:"
        '
        'panelDatosMedicos
        '
        Me.panelDatosMedicos.Controls.Add(Me.Button3)
        Me.panelDatosMedicos.Controls.Add(Me.labEspecialidadMED)
        Me.panelDatosMedicos.Controls.Add(Me.labLugardeTrabajoMED)
        Me.panelDatosMedicos.Location = New System.Drawing.Point(74, 348)
        Me.panelDatosMedicos.Name = "panelDatosMedicos"
        Me.panelDatosMedicos.Size = New System.Drawing.Size(551, 245)
        Me.panelDatosMedicos.TabIndex = 26
        '
        'Button3
        '
        Me.Button3.BackColor = System.Drawing.Color.LightGray
        Me.Button3.FlatAppearance.BorderSize = 0
        Me.Button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button3.Location = New System.Drawing.Point(507, 252)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(111, 22)
        Me.Button3.TabIndex = 17
        Me.Button3.Text = "! Reportar usuario"
        Me.Button3.UseVisualStyleBackColor = False
        '
        'labEspecialidadMED
        '
        Me.labEspecialidadMED.AutoSize = True
        Me.labEspecialidadMED.Font = New System.Drawing.Font("Yu Gothic UI Semilight", 13.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.labEspecialidadMED.ForeColor = System.Drawing.Color.Black
        Me.labEspecialidadMED.Location = New System.Drawing.Point(26, 181)
        Me.labEspecialidadMED.Name = "labEspecialidadMED"
        Me.labEspecialidadMED.Size = New System.Drawing.Size(109, 25)
        Me.labEspecialidadMED.TabIndex = 16
        Me.labEspecialidadMED.Text = "Especialidad:"
        '
        'labLugardeTrabajoMED
        '
        Me.labLugardeTrabajoMED.AutoSize = True
        Me.labLugardeTrabajoMED.Font = New System.Drawing.Font("Yu Gothic UI Semilight", 13.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.labLugardeTrabajoMED.ForeColor = System.Drawing.Color.Black
        Me.labLugardeTrabajoMED.Location = New System.Drawing.Point(26, 64)
        Me.labLugardeTrabajoMED.Name = "labLugardeTrabajoMED"
        Me.labLugardeTrabajoMED.Size = New System.Drawing.Size(143, 25)
        Me.labLugardeTrabajoMED.TabIndex = 15
        Me.labLugardeTrabajoMED.Text = "Lugar de Trabajo:"
        '
        'refrescarChat
        '
        Me.refrescarChat.Interval = 3000
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
        Me.btnMinimizar.Location = New System.Drawing.Point(914, 1)
        Me.btnMinimizar.Name = "btnMinimizar"
        Me.btnMinimizar.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle
        Me.btnMinimizar.ShadowDecoration.Parent = Me.btnMinimizar
        Me.btnMinimizar.Size = New System.Drawing.Size(29, 30)
        Me.btnMinimizar.TabIndex = 50
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
        Me.btnCerrar.Location = New System.Drawing.Point(949, 1)
        Me.btnCerrar.Name = "btnCerrar"
        Me.btnCerrar.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle
        Me.btnCerrar.ShadowDecoration.Parent = Me.btnCerrar
        Me.btnCerrar.Size = New System.Drawing.Size(29, 30)
        Me.btnCerrar.TabIndex = 49
        Me.btnCerrar.Text = "X"
        Me.btnCerrar.UseTransparentBackground = True
        '
        'MenuPaciente
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(980, 645)
        Me.ControlBox = False
        Me.Controls.Add(Me.btnMinimizar)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.btnCerrar)
        Me.Controls.Add(Me.panelListaChats)
        Me.Controls.Add(Me.panelPerfil)
        Me.Controls.Add(Me.panelRealizarDiagnostico2)
        Me.Controls.Add(Me.panelChat)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.MaximumSize = New System.Drawing.Size(980, 645)
        Me.MinimumSize = New System.Drawing.Size(964, 606)
        Me.Name = "MenuPaciente"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "MenuPacienteNew"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.panelRealizarDiagnostico.ResumeLayout(False)
        Me.panelRealizarDiagnostico.PerformLayout()
        Me.paelRealizaDiagnostico2.ResumeLayout(False)
        Me.paelRealizaDiagnostico2.PerformLayout()
        Me.panelChat.ResumeLayout(False)
        Me.panelChat.PerformLayout()
        Me.panelRealizarDiagnostico2.ResumeLayout(False)
        Me.panelRealizarDiagnostico2.PerformLayout()
        Me.Guna2CustomGradientPanel1.ResumeLayout(False)
        Me.Guna2CustomGradientPanel1.PerformLayout()
        Me.panelPerfil.ResumeLayout(False)
        Me.panelPerfil.PerformLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.pdatosPaciente.ResumeLayout(False)
        Me.pdatosPaciente.PerformLayout()
        Me.panelDatosMedicos.ResumeLayout(False)
        Me.panelDatosMedicos.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Panel1 As Panel
    Friend WithEvents labIniciales As Label
    Friend WithEvents labHistorialMedico As Label
    Friend WithEvents labNombre As Label
    Friend WithEvents panelListaChats As Panel
    Friend WithEvents labVolverDisgnostico As Label
    Friend WithEvents panelChat As Panel
    Friend WithEvents txtMensaje As TextBox
    Friend WithEvents txtChat As TextBox
    Friend WithEvents panelRealizarDiagnostico2 As Panel
    Friend WithEvents Label3 As Label
    Friend WithEvents lstSintomasSeleccionados As ListView
    Friend WithEvents panelPerfil As Panel
    Friend WithEvents labPerfilID As Label
    Friend WithEvents labPerfilNombre As Label
    Friend WithEvents labVolverPerfil As Label
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents panelDatosMedicos As Panel
    Friend WithEvents Button3 As Button
    Friend WithEvents labEspecialidadMED As Label
    Friend WithEvents labLugardeTrabajoMED As Label
    Friend WithEvents pdatosPaciente As Panel
    Friend WithEvents labPerfilPatologias As Label
    Friend WithEvents label17 As Label
    Friend WithEvents label16 As Label
    Friend WithEvents label15 As Label
    Friend WithEvents txtPerfilPatologias As TextBox
    Friend WithEvents labDiagnostico1 As Label
    Friend WithEvents labTituloDiagnostico As Label
    Friend WithEvents labPerfilDireccion As Label
    Friend WithEvents labPerfilTelefono As Label
    Friend WithEvents labPerfilFechaDeNacimiento As Label
    Friend WithEvents btnRealizardiagnostico As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents btnEliminar As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents btnCerrarSesion As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents btnChats1 As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents panelRealizarDiagnostico As Panel
    Friend WithEvents paelRealizaDiagnostico2 As Panel
    Friend WithEvents txtBusquedaSintomas As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents btnAgregar As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents lstSintomas As ListView
    Friend WithEvents Label4 As Label
    Friend WithEvents btnEnviar As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents labDiagnostico4 As Label
    Friend WithEvents labDiagnostico3 As Label
    Friend WithEvents labDiagnostico2 As Label
    Friend WithEvents Guna2CustomGradientPanel1 As Guna.UI2.WinForms.Guna2CustomGradientPanel
    Friend WithEvents btnFinalizarConsulta As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents btnEditarPerfil As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents refrescarChat As Timer
    Friend WithEvents btnMinimizar As Guna.UI2.WinForms.Guna2CircleButton
    Friend WithEvents btnCerrar As Guna.UI2.WinForms.Guna2CircleButton
    Friend WithEvents btnMenu_RealizarDiagnostico As Guna.UI2.WinForms.Guna2Button
End Class
