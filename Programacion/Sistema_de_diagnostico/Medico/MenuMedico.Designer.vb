<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class MenuMedico
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(MenuMedico))
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.labVerPerfil = New System.Windows.Forms.Label()
        Me.labIniciales = New System.Windows.Forms.Label()
        Me.labNombre = New System.Windows.Forms.Label()
        Me.btnConsPendientes = New Guna.UI2.WinForms.Guna2Button()
        Me.btnChats = New Guna.UI2.WinForms.Guna2Button()
        Me.btnHistorialdeConsultas = New Guna.UI2.WinForms.Guna2Button()
        Me.panelConsultaPendiente = New System.Windows.Forms.Panel()
        Me.btnAceptarSolicitud = New Guna.UI2.WinForms.Guna2Button()
        Me.lstConsultasPendientes = New System.Windows.Forms.ListView()
        Me.panelHistorialConsulta = New System.Windows.Forms.Panel()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.ListView2 = New System.Windows.Forms.ListView()
        Me.panelPerfil = New System.Windows.Forms.Panel()
        Me.labPerfilID = New System.Windows.Forms.Label()
        Me.labPerfilNombre = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.paneldatosPaciente = New System.Windows.Forms.Panel()
        Me.txtPatologiasPreviasPAC = New System.Windows.Forms.TextBox()
        Me.labDireccionPAC = New System.Windows.Forms.Label()
        Me.labTelefonoPAC = New System.Windows.Forms.Label()
        Me.labFechaDeNacimientoPAC = New System.Windows.Forms.Label()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.label16 = New System.Windows.Forms.Label()
        Me.label15 = New System.Windows.Forms.Label()
        Me.label13 = New System.Windows.Forms.Label()
        Me.panelDatosMedicos = New System.Windows.Forms.Panel()
        Me.labTelefonoMED = New System.Windows.Forms.Label()
        Me.labDireccionMED = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.labEspecialidadMED = New System.Windows.Forms.Label()
        Me.labLugarDeTrabajoMED = New System.Windows.Forms.Label()
        Me.labFechaDeNacimientoMED = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.label4 = New System.Windows.Forms.Label()
        Me.label3 = New System.Windows.Forms.Label()
        Me.panelChat = New System.Windows.Forms.Panel()
        Me.btnVerPerfilPaciente = New Guna.UI2.WinForms.Guna2Button()
        Me.btnFinalizarConsulta = New Guna.UI2.WinForms.Guna2Button()
        Me.btnEnviar = New Guna.UI2.WinForms.Guna2Button()
        Me.txtMensaje = New System.Windows.Forms.TextBox()
        Me.txtChat = New System.Windows.Forms.TextBox()
        Me.panelListaChats = New System.Windows.Forms.Panel()
        Me.refrescarChat = New System.Windows.Forms.Timer(Me.components)
        Me.btnMinimizar = New Guna.UI2.WinForms.Guna2CircleButton()
        Me.btnCerrar = New Guna.UI2.WinForms.Guna2CircleButton()
        Me.Panel1.SuspendLayout()
        Me.panelConsultaPendiente.SuspendLayout()
        Me.panelHistorialConsulta.SuspendLayout()
        Me.panelPerfil.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.paneldatosPaciente.SuspendLayout()
        Me.panelDatosMedicos.SuspendLayout()
        Me.panelChat.SuspendLayout()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.FromArgb(CType(CType(50, Byte), Integer), CType(CType(174, Byte), Integer), CType(CType(144, Byte), Integer))
        Me.Panel1.Controls.Add(Me.labVerPerfil)
        Me.Panel1.Controls.Add(Me.labIniciales)
        Me.Panel1.Controls.Add(Me.labNombre)
        Me.Panel1.Controls.Add(Me.btnConsPendientes)
        Me.Panel1.Controls.Add(Me.btnChats)
        Me.Panel1.Controls.Add(Me.btnHistorialdeConsultas)
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(284, 648)
        Me.Panel1.TabIndex = 1
        '
        'labVerPerfil
        '
        Me.labVerPerfil.AutoSize = True
        Me.labVerPerfil.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.labVerPerfil.ForeColor = System.Drawing.Color.White
        Me.labVerPerfil.Location = New System.Drawing.Point(105, 44)
        Me.labVerPerfil.Name = "labVerPerfil"
        Me.labVerPerfil.Size = New System.Drawing.Size(61, 16)
        Me.labVerPerfil.TabIndex = 12
        Me.labVerPerfil.Text = "Ver perfil"
        '
        'labIniciales
        '
        Me.labIniciales.AutoSize = True
        Me.labIniciales.Font = New System.Drawing.Font("Microsoft Sans Serif", 28.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.labIniciales.ForeColor = System.Drawing.Color.White
        Me.labIniciales.Location = New System.Drawing.Point(12, 16)
        Me.labIniciales.Name = "labIniciales"
        Me.labIniciales.Size = New System.Drawing.Size(72, 44)
        Me.labIniciales.TabIndex = 8
        Me.labIniciales.Text = "NP"
        '
        'labNombre
        '
        Me.labNombre.AutoSize = True
        Me.labNombre.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.labNombre.ForeColor = System.Drawing.Color.White
        Me.labNombre.Location = New System.Drawing.Point(103, 9)
        Me.labNombre.Name = "labNombre"
        Me.labNombre.Size = New System.Drawing.Size(132, 25)
        Me.labNombre.TabIndex = 5
        Me.labNombre.Text = "Nicolas Perez"
        '
        'btnConsPendientes
        '
        Me.btnConsPendientes.Animated = True
        Me.btnConsPendientes.CheckedState.Parent = Me.btnConsPendientes
        Me.btnConsPendientes.CustomImages.Parent = Me.btnConsPendientes
        Me.btnConsPendientes.FillColor = System.Drawing.Color.FromArgb(CType(CType(50, Byte), Integer), CType(CType(174, Byte), Integer), CType(CType(144, Byte), Integer))
        Me.btnConsPendientes.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!)
        Me.btnConsPendientes.ForeColor = System.Drawing.Color.White
        Me.btnConsPendientes.HoverState.Parent = Me.btnConsPendientes
        Me.btnConsPendientes.Location = New System.Drawing.Point(0, 180)
        Me.btnConsPendientes.Name = "btnConsPendientes"
        Me.btnConsPendientes.ShadowDecoration.Parent = Me.btnConsPendientes
        Me.btnConsPendientes.Size = New System.Drawing.Size(280, 47)
        Me.btnConsPendientes.TabIndex = 13
        Me.btnConsPendientes.Text = "Consultas Pendientes"
        '
        'btnChats
        '
        Me.btnChats.Animated = True
        Me.btnChats.CheckedState.Parent = Me.btnChats
        Me.btnChats.CustomImages.Parent = Me.btnChats
        Me.btnChats.FillColor = System.Drawing.Color.FromArgb(CType(CType(50, Byte), Integer), CType(CType(174, Byte), Integer), CType(CType(144, Byte), Integer))
        Me.btnChats.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!)
        Me.btnChats.ForeColor = System.Drawing.Color.White
        Me.btnChats.HoverState.Parent = Me.btnChats
        Me.btnChats.Location = New System.Drawing.Point(0, 286)
        Me.btnChats.Name = "btnChats"
        Me.btnChats.ShadowDecoration.Parent = Me.btnChats
        Me.btnChats.Size = New System.Drawing.Size(280, 47)
        Me.btnChats.TabIndex = 14
        Me.btnChats.Text = "Chats"
        '
        'btnHistorialdeConsultas
        '
        Me.btnHistorialdeConsultas.Animated = True
        Me.btnHistorialdeConsultas.CheckedState.Parent = Me.btnHistorialdeConsultas
        Me.btnHistorialdeConsultas.CustomImages.Parent = Me.btnHistorialdeConsultas
        Me.btnHistorialdeConsultas.FillColor = System.Drawing.Color.FromArgb(CType(CType(50, Byte), Integer), CType(CType(174, Byte), Integer), CType(CType(144, Byte), Integer))
        Me.btnHistorialdeConsultas.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!)
        Me.btnHistorialdeConsultas.ForeColor = System.Drawing.Color.White
        Me.btnHistorialdeConsultas.HoverState.Parent = Me.btnHistorialdeConsultas
        Me.btnHistorialdeConsultas.Location = New System.Drawing.Point(0, 392)
        Me.btnHistorialdeConsultas.Name = "btnHistorialdeConsultas"
        Me.btnHistorialdeConsultas.ShadowDecoration.Parent = Me.btnHistorialdeConsultas
        Me.btnHistorialdeConsultas.Size = New System.Drawing.Size(280, 47)
        Me.btnHistorialdeConsultas.TabIndex = 15
        Me.btnHistorialdeConsultas.Text = "Historial de Consultas"
        '
        'panelConsultaPendiente
        '
        Me.panelConsultaPendiente.Controls.Add(Me.btnAceptarSolicitud)
        Me.panelConsultaPendiente.Controls.Add(Me.lstConsultasPendientes)
        Me.panelConsultaPendiente.Location = New System.Drawing.Point(297, 32)
        Me.panelConsultaPendiente.Name = "panelConsultaPendiente"
        Me.panelConsultaPendiente.Size = New System.Drawing.Size(671, 601)
        Me.panelConsultaPendiente.TabIndex = 7
        '
        'btnAceptarSolicitud
        '
        Me.btnAceptarSolicitud.Animated = True
        Me.btnAceptarSolicitud.AutoRoundedCorners = True
        Me.btnAceptarSolicitud.BorderRadius = 22
        Me.btnAceptarSolicitud.CheckedState.Parent = Me.btnAceptarSolicitud
        Me.btnAceptarSolicitud.CustomImages.Parent = Me.btnAceptarSolicitud
        Me.btnAceptarSolicitud.FillColor = System.Drawing.Color.FromArgb(CType(CType(38, Byte), Integer), CType(CType(131, Byte), Integer), CType(CType(108, Byte), Integer))
        Me.btnAceptarSolicitud.Font = New System.Drawing.Font("Segoe UI", 11.25!)
        Me.btnAceptarSolicitud.ForeColor = System.Drawing.Color.White
        Me.btnAceptarSolicitud.HoverState.Parent = Me.btnAceptarSolicitud
        Me.btnAceptarSolicitud.Location = New System.Drawing.Point(453, 492)
        Me.btnAceptarSolicitud.Name = "btnAceptarSolicitud"
        Me.btnAceptarSolicitud.ShadowDecoration.Parent = Me.btnAceptarSolicitud
        Me.btnAceptarSolicitud.Size = New System.Drawing.Size(112, 47)
        Me.btnAceptarSolicitud.TabIndex = 1
        Me.btnAceptarSolicitud.Text = "Aceptar Solicitud"
        '
        'lstConsultasPendientes
        '
        Me.lstConsultasPendientes.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lstConsultasPendientes.HideSelection = False
        Me.lstConsultasPendientes.Location = New System.Drawing.Point(3, 3)
        Me.lstConsultasPendientes.Name = "lstConsultasPendientes"
        Me.lstConsultasPendientes.Size = New System.Drawing.Size(368, 595)
        Me.lstConsultasPendientes.TabIndex = 0
        Me.lstConsultasPendientes.UseCompatibleStateImageBehavior = False
        Me.lstConsultasPendientes.View = System.Windows.Forms.View.Tile
        '
        'panelHistorialConsulta
        '
        Me.panelHistorialConsulta.Controls.Add(Me.TextBox1)
        Me.panelHistorialConsulta.Controls.Add(Me.ListView2)
        Me.panelHistorialConsulta.Location = New System.Drawing.Point(353, 35)
        Me.panelHistorialConsulta.Name = "panelHistorialConsulta"
        Me.panelHistorialConsulta.Size = New System.Drawing.Size(612, 601)
        Me.panelHistorialConsulta.TabIndex = 8
        '
        'TextBox1
        '
        Me.TextBox1.BackColor = System.Drawing.Color.FromArgb(CType(CType(196, Byte), Integer), CType(CType(196, Byte), Integer), CType(CType(196, Byte), Integer))
        Me.TextBox1.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.TextBox1.Location = New System.Drawing.Point(17, 17)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(273, 13)
        Me.TextBox1.TabIndex = 20
        '
        'ListView2
        '
        Me.ListView2.HideSelection = False
        Me.ListView2.Location = New System.Drawing.Point(3, 56)
        Me.ListView2.Name = "ListView2"
        Me.ListView2.Size = New System.Drawing.Size(307, 528)
        Me.ListView2.TabIndex = 0
        Me.ListView2.UseCompatibleStateImageBehavior = False
        '
        'panelPerfil
        '
        Me.panelPerfil.BackColor = System.Drawing.Color.White
        Me.panelPerfil.Controls.Add(Me.labPerfilID)
        Me.panelPerfil.Controls.Add(Me.labPerfilNombre)
        Me.panelPerfil.Controls.Add(Me.Label5)
        Me.panelPerfil.Controls.Add(Me.PictureBox1)
        Me.panelPerfil.Controls.Add(Me.paneldatosPaciente)
        Me.panelPerfil.Controls.Add(Me.panelDatosMedicos)
        Me.panelPerfil.Location = New System.Drawing.Point(286, 29)
        Me.panelPerfil.Name = "panelPerfil"
        Me.panelPerfil.Size = New System.Drawing.Size(691, 607)
        Me.panelPerfil.TabIndex = 12
        '
        'labPerfilID
        '
        Me.labPerfilID.Font = New System.Drawing.Font("Yu Gothic UI Semilight", 13.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.labPerfilID.ForeColor = System.Drawing.Color.Black
        Me.labPerfilID.Location = New System.Drawing.Point(30, 224)
        Me.labPerfilID.Name = "labPerfilID"
        Me.labPerfilID.Size = New System.Drawing.Size(633, 25)
        Me.labPerfilID.TabIndex = 13
        Me.labPerfilID.Text = "ID Paciente O MED"
        Me.labPerfilID.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'labPerfilNombre
        '
        Me.labPerfilNombre.Font = New System.Drawing.Font("Yu Gothic UI", 24.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.labPerfilNombre.ForeColor = System.Drawing.Color.Black
        Me.labPerfilNombre.Location = New System.Drawing.Point(11, 179)
        Me.labPerfilNombre.Name = "labPerfilNombre"
        Me.labPerfilNombre.Size = New System.Drawing.Size(671, 45)
        Me.labPerfilNombre.TabIndex = 13
        Me.labPerfilNombre.Text = "Nombre Usuario"
        Me.labPerfilNombre.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Yu Gothic UI", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(3, 3)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(31, 25)
        Me.Label5.TabIndex = 24
        Me.Label5.Text = "←"
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(267, 29)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(159, 147)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox1.TabIndex = 0
        Me.PictureBox1.TabStop = False
        '
        'paneldatosPaciente
        '
        Me.paneldatosPaciente.Controls.Add(Me.txtPatologiasPreviasPAC)
        Me.paneldatosPaciente.Controls.Add(Me.labDireccionPAC)
        Me.paneldatosPaciente.Controls.Add(Me.labTelefonoPAC)
        Me.paneldatosPaciente.Controls.Add(Me.labFechaDeNacimientoPAC)
        Me.paneldatosPaciente.Controls.Add(Me.Label11)
        Me.paneldatosPaciente.Controls.Add(Me.label16)
        Me.paneldatosPaciente.Controls.Add(Me.label15)
        Me.paneldatosPaciente.Controls.Add(Me.label13)
        Me.paneldatosPaciente.Location = New System.Drawing.Point(9, 301)
        Me.paneldatosPaciente.Name = "paneldatosPaciente"
        Me.paneldatosPaciente.Size = New System.Drawing.Size(670, 280)
        Me.paneldatosPaciente.TabIndex = 25
        '
        'txtPatologiasPreviasPAC
        '
        Me.txtPatologiasPreviasPAC.Location = New System.Drawing.Point(377, 88)
        Me.txtPatologiasPreviasPAC.Multiline = True
        Me.txtPatologiasPreviasPAC.Name = "txtPatologiasPreviasPAC"
        Me.txtPatologiasPreviasPAC.Size = New System.Drawing.Size(277, 131)
        Me.txtPatologiasPreviasPAC.TabIndex = 21
        '
        'labDireccionPAC
        '
        Me.labDireccionPAC.AutoSize = True
        Me.labDireccionPAC.Font = New System.Drawing.Font("Yu Gothic UI Semilight", 13.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.labDireccionPAC.ForeColor = System.Drawing.Color.Black
        Me.labDireccionPAC.Location = New System.Drawing.Point(191, 182)
        Me.labDireccionPAC.Name = "labDireccionPAC"
        Me.labDireccionPAC.Size = New System.Drawing.Size(102, 25)
        Me.labDireccionPAC.TabIndex = 20
        Me.labDireccionPAC.Text = "No cargado"
        '
        'labTelefonoPAC
        '
        Me.labTelefonoPAC.AutoSize = True
        Me.labTelefonoPAC.Font = New System.Drawing.Font("Yu Gothic UI Semilight", 13.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.labTelefonoPAC.ForeColor = System.Drawing.Color.Black
        Me.labTelefonoPAC.Location = New System.Drawing.Point(191, 120)
        Me.labTelefonoPAC.Name = "labTelefonoPAC"
        Me.labTelefonoPAC.Size = New System.Drawing.Size(102, 25)
        Me.labTelefonoPAC.TabIndex = 19
        Me.labTelefonoPAC.Text = "No cargado"
        '
        'labFechaDeNacimientoPAC
        '
        Me.labFechaDeNacimientoPAC.AutoSize = True
        Me.labFechaDeNacimientoPAC.Font = New System.Drawing.Font("Yu Gothic UI Semilight", 13.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.labFechaDeNacimientoPAC.ForeColor = System.Drawing.Color.Black
        Me.labFechaDeNacimientoPAC.Location = New System.Drawing.Point(191, 57)
        Me.labFechaDeNacimientoPAC.Name = "labFechaDeNacimientoPAC"
        Me.labFechaDeNacimientoPAC.Size = New System.Drawing.Size(102, 25)
        Me.labFechaDeNacimientoPAC.TabIndex = 18
        Me.labFechaDeNacimientoPAC.Text = "No cargado"
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Font = New System.Drawing.Font("Yu Gothic UI Semilight", 13.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.ForeColor = System.Drawing.Color.Black
        Me.Label11.Location = New System.Drawing.Point(372, 57)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(153, 25)
        Me.Label11.TabIndex = 17
        Me.Label11.Text = "Patologias Previas:"
        '
        'label16
        '
        Me.label16.AutoSize = True
        Me.label16.Font = New System.Drawing.Font("Yu Gothic UI Semilight", 13.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.label16.ForeColor = System.Drawing.Color.Black
        Me.label16.Location = New System.Drawing.Point(98, 182)
        Me.label16.Name = "label16"
        Me.label16.Size = New System.Drawing.Size(87, 25)
        Me.label16.TabIndex = 16
        Me.label16.Text = "Direccion:"
        '
        'label15
        '
        Me.label15.AutoSize = True
        Me.label15.Font = New System.Drawing.Font("Yu Gothic UI Semilight", 13.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.label15.ForeColor = System.Drawing.Color.Black
        Me.label15.Location = New System.Drawing.Point(105, 120)
        Me.label15.Name = "label15"
        Me.label15.Size = New System.Drawing.Size(80, 25)
        Me.label15.TabIndex = 15
        Me.label15.Text = "Telefono:"
        '
        'label13
        '
        Me.label13.AutoSize = True
        Me.label13.Font = New System.Drawing.Font("Yu Gothic UI Semilight", 13.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.label13.ForeColor = System.Drawing.Color.Black
        Me.label13.Location = New System.Drawing.Point(11, 57)
        Me.label13.Name = "label13"
        Me.label13.Size = New System.Drawing.Size(174, 25)
        Me.label13.TabIndex = 14
        Me.label13.Text = "Fecha de nacimiento:"
        '
        'panelDatosMedicos
        '
        Me.panelDatosMedicos.Controls.Add(Me.labTelefonoMED)
        Me.panelDatosMedicos.Controls.Add(Me.labDireccionMED)
        Me.panelDatosMedicos.Controls.Add(Me.Label6)
        Me.panelDatosMedicos.Controls.Add(Me.Label2)
        Me.panelDatosMedicos.Controls.Add(Me.labEspecialidadMED)
        Me.panelDatosMedicos.Controls.Add(Me.labLugarDeTrabajoMED)
        Me.panelDatosMedicos.Controls.Add(Me.labFechaDeNacimientoMED)
        Me.panelDatosMedicos.Controls.Add(Me.Label1)
        Me.panelDatosMedicos.Controls.Add(Me.label4)
        Me.panelDatosMedicos.Controls.Add(Me.label3)
        Me.panelDatosMedicos.Location = New System.Drawing.Point(9, 301)
        Me.panelDatosMedicos.Name = "panelDatosMedicos"
        Me.panelDatosMedicos.Size = New System.Drawing.Size(670, 282)
        Me.panelDatosMedicos.TabIndex = 26
        '
        'labTelefonoMED
        '
        Me.labTelefonoMED.AutoSize = True
        Me.labTelefonoMED.Font = New System.Drawing.Font("Yu Gothic UI Semilight", 13.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.labTelefonoMED.ForeColor = System.Drawing.Color.Black
        Me.labTelefonoMED.Location = New System.Drawing.Point(465, 132)
        Me.labTelefonoMED.Name = "labTelefonoMED"
        Me.labTelefonoMED.Size = New System.Drawing.Size(102, 25)
        Me.labTelefonoMED.TabIndex = 24
        Me.labTelefonoMED.Text = "No cargado"
        '
        'labDireccionMED
        '
        Me.labDireccionMED.AutoSize = True
        Me.labDireccionMED.Font = New System.Drawing.Font("Yu Gothic UI Semilight", 13.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.labDireccionMED.ForeColor = System.Drawing.Color.Black
        Me.labDireccionMED.Location = New System.Drawing.Point(465, 72)
        Me.labDireccionMED.Name = "labDireccionMED"
        Me.labDireccionMED.Size = New System.Drawing.Size(102, 25)
        Me.labDireccionMED.TabIndex = 23
        Me.labDireccionMED.Text = "No cargado"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Yu Gothic UI Semilight", 13.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.ForeColor = System.Drawing.Color.Black
        Me.Label6.Location = New System.Drawing.Point(379, 132)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(80, 25)
        Me.Label6.TabIndex = 22
        Me.Label6.Text = "Teléfono:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Yu Gothic UI Semilight", 13.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.Black
        Me.Label2.Location = New System.Drawing.Point(372, 72)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(87, 25)
        Me.Label2.TabIndex = 21
        Me.Label2.Text = "Dirección:"
        '
        'labEspecialidadMED
        '
        Me.labEspecialidadMED.AutoSize = True
        Me.labEspecialidadMED.Font = New System.Drawing.Font("Yu Gothic UI Semilight", 13.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.labEspecialidadMED.ForeColor = System.Drawing.Color.Black
        Me.labEspecialidadMED.Location = New System.Drawing.Point(200, 194)
        Me.labEspecialidadMED.Name = "labEspecialidadMED"
        Me.labEspecialidadMED.Size = New System.Drawing.Size(102, 25)
        Me.labEspecialidadMED.TabIndex = 20
        Me.labEspecialidadMED.Text = "No cargado"
        '
        'labLugarDeTrabajoMED
        '
        Me.labLugarDeTrabajoMED.AutoSize = True
        Me.labLugarDeTrabajoMED.Font = New System.Drawing.Font("Yu Gothic UI Semilight", 13.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.labLugarDeTrabajoMED.ForeColor = System.Drawing.Color.Black
        Me.labLugarDeTrabajoMED.Location = New System.Drawing.Point(200, 132)
        Me.labLugarDeTrabajoMED.Name = "labLugarDeTrabajoMED"
        Me.labLugarDeTrabajoMED.Size = New System.Drawing.Size(102, 25)
        Me.labLugarDeTrabajoMED.TabIndex = 19
        Me.labLugarDeTrabajoMED.Text = "No cargado"
        '
        'labFechaDeNacimientoMED
        '
        Me.labFechaDeNacimientoMED.AutoSize = True
        Me.labFechaDeNacimientoMED.Font = New System.Drawing.Font("Yu Gothic UI Semilight", 13.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.labFechaDeNacimientoMED.ForeColor = System.Drawing.Color.Black
        Me.labFechaDeNacimientoMED.Location = New System.Drawing.Point(200, 72)
        Me.labFechaDeNacimientoMED.Name = "labFechaDeNacimientoMED"
        Me.labFechaDeNacimientoMED.Size = New System.Drawing.Size(102, 25)
        Me.labFechaDeNacimientoMED.TabIndex = 18
        Me.labFechaDeNacimientoMED.Text = "No cargado"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Yu Gothic UI Semilight", 13.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.Black
        Me.Label1.Location = New System.Drawing.Point(11, 72)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(174, 25)
        Me.Label1.TabIndex = 17
        Me.Label1.Text = "Fecha de nacimiento:"
        '
        'label4
        '
        Me.label4.AutoSize = True
        Me.label4.Font = New System.Drawing.Font("Yu Gothic UI Semilight", 13.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.label4.ForeColor = System.Drawing.Color.Black
        Me.label4.Location = New System.Drawing.Point(76, 194)
        Me.label4.Name = "label4"
        Me.label4.Size = New System.Drawing.Size(109, 25)
        Me.label4.TabIndex = 16
        Me.label4.Text = "Especialidad:"
        '
        'label3
        '
        Me.label3.AutoSize = True
        Me.label3.Font = New System.Drawing.Font("Yu Gothic UI Semilight", 13.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.label3.ForeColor = System.Drawing.Color.Black
        Me.label3.Location = New System.Drawing.Point(42, 132)
        Me.label3.Name = "label3"
        Me.label3.Size = New System.Drawing.Size(143, 25)
        Me.label3.TabIndex = 15
        Me.label3.Text = "Lugar de Trabajo:"
        '
        'panelChat
        '
        Me.panelChat.Controls.Add(Me.btnVerPerfilPaciente)
        Me.panelChat.Controls.Add(Me.btnFinalizarConsulta)
        Me.panelChat.Controls.Add(Me.btnEnviar)
        Me.panelChat.Controls.Add(Me.txtMensaje)
        Me.panelChat.Controls.Add(Me.txtChat)
        Me.panelChat.Location = New System.Drawing.Point(353, 29)
        Me.panelChat.Name = "panelChat"
        Me.panelChat.Size = New System.Drawing.Size(624, 604)
        Me.panelChat.TabIndex = 13
        '
        'btnVerPerfilPaciente
        '
        Me.btnVerPerfilPaciente.Animated = True
        Me.btnVerPerfilPaciente.AutoRoundedCorners = True
        Me.btnVerPerfilPaciente.BorderRadius = 9
        Me.btnVerPerfilPaciente.CheckedState.Parent = Me.btnVerPerfilPaciente
        Me.btnVerPerfilPaciente.CustomImages.Parent = Me.btnVerPerfilPaciente
        Me.btnVerPerfilPaciente.FillColor = System.Drawing.Color.FromArgb(CType(CType(38, Byte), Integer), CType(CType(131, Byte), Integer), CType(CType(108, Byte), Integer))
        Me.btnVerPerfilPaciente.Font = New System.Drawing.Font("Segoe UI", 8.25!)
        Me.btnVerPerfilPaciente.ForeColor = System.Drawing.Color.White
        Me.btnVerPerfilPaciente.HoverState.Parent = Me.btnVerPerfilPaciente
        Me.btnVerPerfilPaciente.Location = New System.Drawing.Point(15, 7)
        Me.btnVerPerfilPaciente.Name = "btnVerPerfilPaciente"
        Me.btnVerPerfilPaciente.ShadowDecoration.Parent = Me.btnVerPerfilPaciente
        Me.btnVerPerfilPaciente.Size = New System.Drawing.Size(103, 21)
        Me.btnVerPerfilPaciente.TabIndex = 4
        Me.btnVerPerfilPaciente.Text = "Ver Perfil Paciente"
        '
        'btnFinalizarConsulta
        '
        Me.btnFinalizarConsulta.Animated = True
        Me.btnFinalizarConsulta.AutoRoundedCorners = True
        Me.btnFinalizarConsulta.BorderRadius = 9
        Me.btnFinalizarConsulta.CheckedState.Parent = Me.btnFinalizarConsulta
        Me.btnFinalizarConsulta.CustomImages.Parent = Me.btnFinalizarConsulta
        Me.btnFinalizarConsulta.FillColor = System.Drawing.Color.FromArgb(CType(CType(38, Byte), Integer), CType(CType(131, Byte), Integer), CType(CType(108, Byte), Integer))
        Me.btnFinalizarConsulta.Font = New System.Drawing.Font("Segoe UI", 8.25!)
        Me.btnFinalizarConsulta.ForeColor = System.Drawing.Color.White
        Me.btnFinalizarConsulta.HoverState.Parent = Me.btnFinalizarConsulta
        Me.btnFinalizarConsulta.Location = New System.Drawing.Point(187, 7)
        Me.btnFinalizarConsulta.Name = "btnFinalizarConsulta"
        Me.btnFinalizarConsulta.ShadowDecoration.Parent = Me.btnFinalizarConsulta
        Me.btnFinalizarConsulta.Size = New System.Drawing.Size(103, 21)
        Me.btnFinalizarConsulta.TabIndex = 3
        Me.btnFinalizarConsulta.Text = "Finalizar Consulta"
        '
        'btnEnviar
        '
        Me.btnEnviar.AutoRoundedCorners = True
        Me.btnEnviar.BorderRadius = 11
        Me.btnEnviar.CheckedState.Parent = Me.btnEnviar
        Me.btnEnviar.CustomImages.Parent = Me.btnEnviar
        Me.btnEnviar.FillColor = System.Drawing.Color.FromArgb(CType(CType(38, Byte), Integer), CType(CType(131, Byte), Integer), CType(CType(108, Byte), Integer))
        Me.btnEnviar.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.btnEnviar.ForeColor = System.Drawing.Color.White
        Me.btnEnviar.HoverState.Parent = Me.btnEnviar
        Me.btnEnviar.Location = New System.Drawing.Point(531, 566)
        Me.btnEnviar.Name = "btnEnviar"
        Me.btnEnviar.ShadowDecoration.Parent = Me.btnEnviar
        Me.btnEnviar.Size = New System.Drawing.Size(84, 24)
        Me.btnEnviar.TabIndex = 2
        Me.btnEnviar.Text = "Enviar"
        '
        'txtMensaje
        '
        Me.txtMensaje.Location = New System.Drawing.Point(15, 569)
        Me.txtMensaje.Name = "txtMensaje"
        Me.txtMensaje.Size = New System.Drawing.Size(506, 20)
        Me.txtMensaje.TabIndex = 1
        '
        'txtChat
        '
        Me.txtChat.BackColor = System.Drawing.Color.White
        Me.txtChat.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtChat.Location = New System.Drawing.Point(15, 32)
        Me.txtChat.Multiline = True
        Me.txtChat.Name = "txtChat"
        Me.txtChat.ReadOnly = True
        Me.txtChat.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.txtChat.Size = New System.Drawing.Size(581, 517)
        Me.txtChat.TabIndex = 0
        '
        'panelListaChats
        '
        Me.panelListaChats.BackColor = System.Drawing.Color.FromArgb(CType(CType(38, Byte), Integer), CType(CType(131, Byte), Integer), CType(CType(108, Byte), Integer))
        Me.panelListaChats.ForeColor = System.Drawing.Color.Black
        Me.panelListaChats.Location = New System.Drawing.Point(278, 0)
        Me.panelListaChats.Name = "panelListaChats"
        Me.panelListaChats.Size = New System.Drawing.Size(77, 647)
        Me.panelListaChats.TabIndex = 14
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
        Me.btnMinimizar.Location = New System.Drawing.Point(915, 0)
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
        Me.btnCerrar.Location = New System.Drawing.Point(950, 0)
        Me.btnCerrar.Name = "btnCerrar"
        Me.btnCerrar.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle
        Me.btnCerrar.ShadowDecoration.Parent = Me.btnCerrar
        Me.btnCerrar.Size = New System.Drawing.Size(29, 30)
        Me.btnCerrar.TabIndex = 49
        Me.btnCerrar.Text = "X"
        Me.btnCerrar.UseTransparentBackground = True
        '
        'MenuMedico
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(980, 645)
        Me.ControlBox = False
        Me.Controls.Add(Me.btnMinimizar)
        Me.Controls.Add(Me.btnCerrar)
        Me.Controls.Add(Me.panelListaChats)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.panelHistorialConsulta)
        Me.Controls.Add(Me.panelChat)
        Me.Controls.Add(Me.panelConsultaPendiente)
        Me.Controls.Add(Me.panelPerfil)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.MaximumSize = New System.Drawing.Size(980, 645)
        Me.MinimumSize = New System.Drawing.Size(964, 606)
        Me.Name = "MenuMedico"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "MenuPacienteNew"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.panelConsultaPendiente.ResumeLayout(False)
        Me.panelHistorialConsulta.ResumeLayout(False)
        Me.panelHistorialConsulta.PerformLayout()
        Me.panelPerfil.ResumeLayout(False)
        Me.panelPerfil.PerformLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.paneldatosPaciente.ResumeLayout(False)
        Me.paneldatosPaciente.PerformLayout()
        Me.panelDatosMedicos.ResumeLayout(False)
        Me.panelDatosMedicos.PerformLayout()
        Me.panelChat.ResumeLayout(False)
        Me.panelChat.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Panel1 As Panel
    Friend WithEvents labIniciales As Label
    Friend WithEvents labNombre As Label
    Friend WithEvents panelConsultaPendiente As Panel
    Friend WithEvents lstConsultasPendientes As ListView
    Friend WithEvents panelHistorialConsulta As Panel
    Friend WithEvents ListView2 As ListView
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents panelPerfil As Panel
    Friend WithEvents labPerfilID As Label
    Friend WithEvents labPerfilNombre As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents paneldatosPaciente As Panel
    Friend WithEvents Label11 As Label
    Friend WithEvents label16 As Label
    Friend WithEvents label15 As Label
    Friend WithEvents label13 As Label
    Friend WithEvents panelDatosMedicos As Panel
    Friend WithEvents label4 As Label
    Friend WithEvents label3 As Label
    Friend WithEvents txtPatologiasPreviasPAC As TextBox
    Friend WithEvents labDireccionPAC As Label
    Friend WithEvents labTelefonoPAC As Label
    Friend WithEvents labFechaDeNacimientoPAC As Label
    Friend WithEvents labEspecialidadMED As Label
    Friend WithEvents labLugarDeTrabajoMED As Label
    Friend WithEvents labFechaDeNacimientoMED As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents labTelefonoMED As Label
    Friend WithEvents labDireccionMED As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents btnAceptarSolicitud As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents panelChat As Panel
    Friend WithEvents btnEnviar As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents txtMensaje As TextBox
    Friend WithEvents txtChat As TextBox
    Friend WithEvents panelListaChats As Panel
    Friend WithEvents refrescarChat As Timer
    Friend WithEvents labVerPerfil As Label
    Friend WithEvents btnVerPerfilPaciente As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents btnFinalizarConsulta As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents btnMinimizar As Guna.UI2.WinForms.Guna2CircleButton
    Friend WithEvents btnCerrar As Guna.UI2.WinForms.Guna2CircleButton
    Friend WithEvents btnConsPendientes As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents btnChats As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents btnHistorialdeConsultas As Guna.UI2.WinForms.Guna2Button
End Class
