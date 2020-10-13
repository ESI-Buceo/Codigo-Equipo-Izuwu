<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class MenuPacienteNew
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(MenuPacienteNew))
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.panelRealizarDiagnostico = New System.Windows.Forms.Panel()
        Me.labVolverDisgnostico = New System.Windows.Forms.Label()
        Me.btnAgregar = New System.Windows.Forms.Button()
        Me.lstSintomas = New System.Windows.Forms.ListView()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.btnCerrarsesion = New System.Windows.Forms.Button()
        Me.labIniciales = New System.Windows.Forms.Label()
        Me.labHistorialMedico = New System.Windows.Forms.Label()
        Me.labNombre = New System.Windows.Forms.Label()
        Me.btnChats = New System.Windows.Forms.Button()
        Me.btnRealizarDiagnostico = New System.Windows.Forms.Button()
        Me.btnEliminar = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.panelMenu_Chat = New System.Windows.Forms.Panel()
        Me.paelRealizaDiagnostico2 = New System.Windows.Forms.Panel()
        Me.txtBusquedaSintomas = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.panelChat = New System.Windows.Forms.Panel()
        Me.btnEnviar = New System.Windows.Forms.Button()
        Me.txtMensaje = New System.Windows.Forms.TextBox()
        Me.txtChat = New System.Windows.Forms.TextBox()
        Me.panelRealizarDiagnostico2 = New System.Windows.Forms.Panel()
        Me.Button4 = New System.Windows.Forms.Button()
        Me.labDiagnostico = New System.Windows.Forms.Label()
        Me.labTituloDiagnostico = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.lstSintomasSeleccionados = New System.Windows.Forms.ListView()
        Me.panelPerfil = New System.Windows.Forms.Panel()
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
        Me.Panel1.SuspendLayout()
        Me.panelRealizarDiagnostico.SuspendLayout()
        Me.paelRealizaDiagnostico2.SuspendLayout()
        Me.panelChat.SuspendLayout()
        Me.panelRealizarDiagnostico2.SuspendLayout()
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
        Me.Panel1.Controls.Add(Me.btnCerrarsesion)
        Me.Panel1.Controls.Add(Me.labIniciales)
        Me.Panel1.Controls.Add(Me.labHistorialMedico)
        Me.Panel1.Controls.Add(Me.labNombre)
        Me.Panel1.Controls.Add(Me.btnChats)
        Me.Panel1.Controls.Add(Me.btnRealizarDiagnostico)
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(284, 648)
        Me.Panel1.TabIndex = 1
        '
        'panelRealizarDiagnostico
        '
        Me.panelRealizarDiagnostico.Controls.Add(Me.labVolverDisgnostico)
        Me.panelRealizarDiagnostico.Controls.Add(Me.btnAgregar)
        Me.panelRealizarDiagnostico.Controls.Add(Me.lstSintomas)
        Me.panelRealizarDiagnostico.Controls.Add(Me.Label4)
        Me.panelRealizarDiagnostico.Location = New System.Drawing.Point(0, 130)
        Me.panelRealizarDiagnostico.Name = "panelRealizarDiagnostico"
        Me.panelRealizarDiagnostico.Size = New System.Drawing.Size(284, 517)
        Me.panelRealizarDiagnostico.TabIndex = 12
        '
        'labVolverDisgnostico
        '
        Me.labVolverDisgnostico.AutoSize = True
        Me.labVolverDisgnostico.Font = New System.Drawing.Font("Yu Gothic UI", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.labVolverDisgnostico.Location = New System.Drawing.Point(247, 483)
        Me.labVolverDisgnostico.Name = "labVolverDisgnostico"
        Me.labVolverDisgnostico.Size = New System.Drawing.Size(31, 25)
        Me.labVolverDisgnostico.TabIndex = 23
        Me.labVolverDisgnostico.Text = "←"
        '
        'btnAgregar
        '
        Me.btnAgregar.BackColor = System.Drawing.Color.FromArgb(CType(CType(24, Byte), Integer), CType(CType(69, Byte), Integer), CType(CType(122, Byte), Integer))
        Me.btnAgregar.FlatAppearance.BorderColor = System.Drawing.Color.White
        Me.btnAgregar.FlatAppearance.BorderSize = 0
        Me.btnAgregar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnAgregar.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.btnAgregar.Location = New System.Drawing.Point(94, 425)
        Me.btnAgregar.Name = "btnAgregar"
        Me.btnAgregar.Size = New System.Drawing.Size(92, 28)
        Me.btnAgregar.TabIndex = 13
        Me.btnAgregar.Text = "Agregar"
        Me.btnAgregar.UseVisualStyleBackColor = False
        '
        'lstSintomas
        '
        Me.lstSintomas.BackColor = System.Drawing.Color.White
        Me.lstSintomas.Font = New System.Drawing.Font("Yu Gothic UI", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lstSintomas.HideSelection = False
        Me.lstSintomas.Location = New System.Drawing.Point(4, 14)
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
        Me.Label4.Location = New System.Drawing.Point(13, 483)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(113, 13)
        Me.Label4.TabIndex = 9
        Me.Label4.Text = "Politicas de privacidad"
        '
        'btnCerrarsesion
        '
        Me.btnCerrarsesion.BackColor = System.Drawing.Color.Transparent
        Me.btnCerrarsesion.FlatAppearance.BorderSize = 0
        Me.btnCerrarsesion.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnCerrarsesion.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnCerrarsesion.ForeColor = System.Drawing.Color.White
        Me.btnCerrarsesion.Location = New System.Drawing.Point(0, 392)
        Me.btnCerrarsesion.Name = "btnCerrarsesion"
        Me.btnCerrarsesion.Size = New System.Drawing.Size(291, 47)
        Me.btnCerrarsesion.TabIndex = 11
        Me.btnCerrarsesion.Text = "Cerrar sesion"
        Me.btnCerrarsesion.UseVisualStyleBackColor = False
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
        Me.labHistorialMedico.Text = "Historial medico"
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
        'btnChats
        '
        Me.btnChats.BackColor = System.Drawing.Color.Transparent
        Me.btnChats.FlatAppearance.BorderSize = 0
        Me.btnChats.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnChats.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnChats.ForeColor = System.Drawing.Color.White
        Me.btnChats.Location = New System.Drawing.Point(0, 286)
        Me.btnChats.Name = "btnChats"
        Me.btnChats.Size = New System.Drawing.Size(291, 47)
        Me.btnChats.TabIndex = 2
        Me.btnChats.Text = "Chats"
        Me.btnChats.UseVisualStyleBackColor = False
        '
        'btnRealizarDiagnostico
        '
        Me.btnRealizarDiagnostico.BackColor = System.Drawing.Color.Transparent
        Me.btnRealizarDiagnostico.FlatAppearance.BorderSize = 0
        Me.btnRealizarDiagnostico.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnRealizarDiagnostico.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnRealizarDiagnostico.ForeColor = System.Drawing.Color.White
        Me.btnRealizarDiagnostico.Location = New System.Drawing.Point(0, 180)
        Me.btnRealizarDiagnostico.Name = "btnRealizarDiagnostico"
        Me.btnRealizarDiagnostico.Size = New System.Drawing.Size(291, 47)
        Me.btnRealizarDiagnostico.TabIndex = 0
        Me.btnRealizarDiagnostico.Text = "Realizar diagnostico"
        Me.btnRealizarDiagnostico.UseVisualStyleBackColor = False
        '
        'btnEliminar
        '
        Me.btnEliminar.BackColor = System.Drawing.Color.FromArgb(CType(CType(241, Byte), Integer), CType(CType(33, Byte), Integer), CType(CType(33, Byte), Integer))
        Me.btnEliminar.FlatAppearance.BorderColor = System.Drawing.Color.White
        Me.btnEliminar.FlatAppearance.BorderSize = 0
        Me.btnEliminar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnEliminar.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.btnEliminar.Location = New System.Drawing.Point(33, 548)
        Me.btnEliminar.Name = "btnEliminar"
        Me.btnEliminar.Size = New System.Drawing.Size(92, 28)
        Me.btnEliminar.TabIndex = 14
        Me.btnEliminar.Text = "Eliminar"
        Me.btnEliminar.UseVisualStyleBackColor = False
        '
        'Button2
        '
        Me.Button2.BackColor = System.Drawing.Color.White
        Me.Button2.FlatAppearance.BorderSize = 0
        Me.Button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button2.Font = New System.Drawing.Font("Consolas", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button2.ForeColor = System.Drawing.Color.Black
        Me.Button2.Location = New System.Drawing.Point(891, 0)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(41, 26)
        Me.Button2.TabIndex = 6
        Me.Button2.Text = "-"
        Me.Button2.UseVisualStyleBackColor = False
        '
        'Button1
        '
        Me.Button1.BackColor = System.Drawing.Color.White
        Me.Button1.FlatAppearance.BorderSize = 0
        Me.Button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button1.Font = New System.Drawing.Font("Consolas", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button1.ForeColor = System.Drawing.Color.Black
        Me.Button1.Location = New System.Drawing.Point(938, 0)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(41, 26)
        Me.Button1.TabIndex = 5
        Me.Button1.Text = "X"
        Me.Button1.UseVisualStyleBackColor = False
        '
        'panelMenu_Chat
        '
        Me.panelMenu_Chat.AutoScroll = True
        Me.panelMenu_Chat.BackColor = System.Drawing.Color.FromArgb(CType(CType(24, Byte), Integer), CType(CType(69, Byte), Integer), CType(CType(122, Byte), Integer))
        Me.panelMenu_Chat.Location = New System.Drawing.Point(284, 0)
        Me.panelMenu_Chat.Name = "panelMenu_Chat"
        Me.panelMenu_Chat.Size = New System.Drawing.Size(71, 647)
        Me.panelMenu_Chat.TabIndex = 7
        '
        'paelRealizaDiagnostico2
        '
        Me.paelRealizaDiagnostico2.BackColor = System.Drawing.Color.FromArgb(CType(CType(221, Byte), Integer), CType(CType(221, Byte), Integer), CType(CType(221, Byte), Integer))
        Me.paelRealizaDiagnostico2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.paelRealizaDiagnostico2.Controls.Add(Me.txtBusquedaSintomas)
        Me.paelRealizaDiagnostico2.Controls.Add(Me.Label1)
        Me.paelRealizaDiagnostico2.Location = New System.Drawing.Point(87, 51)
        Me.paelRealizaDiagnostico2.Name = "paelRealizaDiagnostico2"
        Me.paelRealizaDiagnostico2.Size = New System.Drawing.Size(450, 96)
        Me.paelRealizaDiagnostico2.TabIndex = 8
        '
        'txtBusquedaSintomas
        '
        Me.txtBusquedaSintomas.BackColor = System.Drawing.Color.Silver
        Me.txtBusquedaSintomas.Location = New System.Drawing.Point(23, 47)
        Me.txtBusquedaSintomas.Name = "txtBusquedaSintomas"
        Me.txtBusquedaSintomas.Size = New System.Drawing.Size(394, 20)
        Me.txtBusquedaSintomas.TabIndex = 9
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.SystemColors.ControlDarkDark
        Me.Label1.Location = New System.Drawing.Point(162, 13)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(109, 16)
        Me.Label1.TabIndex = 19
        Me.Label1.Text = "Busca tu sintoma"
        '
        'panelChat
        '
        Me.panelChat.Controls.Add(Me.btnEnviar)
        Me.panelChat.Controls.Add(Me.txtMensaje)
        Me.panelChat.Controls.Add(Me.txtChat)
        Me.panelChat.Location = New System.Drawing.Point(350, 31)
        Me.panelChat.Name = "panelChat"
        Me.panelChat.Size = New System.Drawing.Size(625, 611)
        Me.panelChat.TabIndex = 9
        '
        'btnEnviar
        '
        Me.btnEnviar.BackColor = System.Drawing.Color.FromArgb(CType(CType(24, Byte), Integer), CType(CType(69, Byte), Integer), CType(CType(122, Byte), Integer))
        Me.btnEnviar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnEnviar.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.btnEnviar.Location = New System.Drawing.Point(508, 540)
        Me.btnEnviar.Name = "btnEnviar"
        Me.btnEnviar.Size = New System.Drawing.Size(82, 34)
        Me.btnEnviar.TabIndex = 2
        Me.btnEnviar.Text = "Enviar"
        Me.btnEnviar.UseVisualStyleBackColor = False
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
        Me.txtChat.Location = New System.Drawing.Point(21, 17)
        Me.txtChat.Multiline = True
        Me.txtChat.Name = "txtChat"
        Me.txtChat.ReadOnly = True
        Me.txtChat.ScrollBars = System.Windows.Forms.ScrollBars.Horizontal
        Me.txtChat.Size = New System.Drawing.Size(560, 507)
        Me.txtChat.TabIndex = 0
        '
        'panelRealizarDiagnostico2
        '
        Me.panelRealizarDiagnostico2.Controls.Add(Me.Button4)
        Me.panelRealizarDiagnostico2.Controls.Add(Me.labDiagnostico)
        Me.panelRealizarDiagnostico2.Controls.Add(Me.labTituloDiagnostico)
        Me.panelRealizarDiagnostico2.Controls.Add(Me.btnEliminar)
        Me.panelRealizarDiagnostico2.Controls.Add(Me.Label3)
        Me.panelRealizarDiagnostico2.Controls.Add(Me.lstSintomasSeleccionados)
        Me.panelRealizarDiagnostico2.Controls.Add(Me.paelRealizaDiagnostico2)
        Me.panelRealizarDiagnostico2.Location = New System.Drawing.Point(305, 31)
        Me.panelRealizarDiagnostico2.Name = "panelRealizarDiagnostico2"
        Me.panelRealizarDiagnostico2.Size = New System.Drawing.Size(669, 611)
        Me.panelRealizarDiagnostico2.TabIndex = 10
        '
        'Button4
        '
        Me.Button4.BackColor = System.Drawing.Color.FromArgb(CType(CType(24, Byte), Integer), CType(CType(69, Byte), Integer), CType(CType(122, Byte), Integer))
        Me.Button4.FlatAppearance.BorderColor = System.Drawing.Color.White
        Me.Button4.FlatAppearance.BorderSize = 0
        Me.Button4.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button4.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.Button4.Location = New System.Drawing.Point(311, 348)
        Me.Button4.Name = "Button4"
        Me.Button4.Size = New System.Drawing.Size(92, 49)
        Me.Button4.TabIndex = 19
        Me.Button4.Text = "Realizar Diagnostico"
        Me.Button4.UseVisualStyleBackColor = False
        '
        'labDiagnostico
        '
        Me.labDiagnostico.AutoSize = True
        Me.labDiagnostico.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.labDiagnostico.Location = New System.Drawing.Point(432, 254)
        Me.labDiagnostico.Name = "labDiagnostico"
        Me.labDiagnostico.Size = New System.Drawing.Size(57, 20)
        Me.labDiagnostico.TabIndex = 18
        Me.labDiagnostico.Text = "Label2"
        '
        'labTituloDiagnostico
        '
        Me.labTituloDiagnostico.AutoSize = True
        Me.labTituloDiagnostico.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.labTituloDiagnostico.Location = New System.Drawing.Point(432, 211)
        Me.labTituloDiagnostico.Name = "labTituloDiagnostico"
        Me.labTituloDiagnostico.Size = New System.Drawing.Size(125, 24)
        Me.labTituloDiagnostico.TabIndex = 17
        Me.labTituloDiagnostico.Text = "Diagnostico:"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(31, 211)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(245, 24)
        Me.Label3.TabIndex = 16
        Me.Label3.Text = "Sintomas Seleccionados:"
        '
        'lstSintomasSeleccionados
        '
        Me.lstSintomasSeleccionados.Font = New System.Drawing.Font("Yu Gothic UI", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lstSintomasSeleccionados.HideSelection = False
        Me.lstSintomasSeleccionados.Location = New System.Drawing.Point(35, 254)
        Me.lstSintomasSeleccionados.Name = "lstSintomasSeleccionados"
        Me.lstSintomasSeleccionados.Size = New System.Drawing.Size(241, 283)
        Me.lstSintomasSeleccionados.TabIndex = 15
        Me.lstSintomasSeleccionados.UseCompatibleStateImageBehavior = False
        Me.lstSintomasSeleccionados.View = System.Windows.Forms.View.Tile
        '
        'panelPerfil
        '
        Me.panelPerfil.BackColor = System.Drawing.Color.White
        Me.panelPerfil.Controls.Add(Me.panelDatosMedicos)
        Me.panelPerfil.Controls.Add(Me.labPerfilID)
        Me.panelPerfil.Controls.Add(Me.labPerfilNombre)
        Me.panelPerfil.Controls.Add(Me.labVolverPerfil)
        Me.panelPerfil.Controls.Add(Me.PictureBox1)
        Me.panelPerfil.Controls.Add(Me.pdatosPaciente)
        Me.panelPerfil.Location = New System.Drawing.Point(297, 31)
        Me.panelPerfil.Name = "panelPerfil"
        Me.panelPerfil.Size = New System.Drawing.Size(682, 608)
        Me.panelPerfil.TabIndex = 11
        '
        'labPerfilID
        '
        Me.labPerfilID.Font = New System.Drawing.Font("Yu Gothic UI Semilight", 13.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.labPerfilID.ForeColor = System.Drawing.Color.Black
        Me.labPerfilID.Location = New System.Drawing.Point(15, 226)
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
        Me.labPerfilNombre.Location = New System.Drawing.Point(7, 179)
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
        Me.PictureBox1.Location = New System.Drawing.Point(232, 29)
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
        Me.labPerfilPatologias.Text = "Patologias Previas:"
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
        Me.label17.Text = "Direccion:"
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
        Me.label16.Text = "Telefono:"
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
        'MenuPacienteNew
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(980, 645)
        Me.ControlBox = False
        Me.Controls.Add(Me.panelRealizarDiagnostico2)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.panelChat)
        Me.Controls.Add(Me.panelMenu_Chat)
        Me.Controls.Add(Me.panelPerfil)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.MaximumSize = New System.Drawing.Size(980, 645)
        Me.MinimumSize = New System.Drawing.Size(964, 606)
        Me.Name = "MenuPacienteNew"
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
    Friend WithEvents Label4 As Label
    Friend WithEvents labIniciales As Label
    Friend WithEvents labHistorialMedico As Label
    Friend WithEvents labNombre As Label
    Friend WithEvents btnChats As Button
    Friend WithEvents btnRealizarDiagnostico As Button
    Friend WithEvents btnCerrarsesion As Button
    Friend WithEvents Button2 As Button
    Friend WithEvents Button1 As Button
    Friend WithEvents panelMenu_Chat As Panel
    Friend WithEvents panelRealizarDiagnostico As Panel
    Friend WithEvents lstSintomas As ListView
    Friend WithEvents btnEliminar As Button
    Friend WithEvents btnAgregar As Button
    Friend WithEvents paelRealizaDiagnostico2 As Panel
    Friend WithEvents Label1 As Label
    Friend WithEvents labVolverDisgnostico As Label
    Friend WithEvents txtBusquedaSintomas As TextBox
    Friend WithEvents panelChat As Panel
    Friend WithEvents btnEnviar As Button
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
    Friend WithEvents labDiagnostico As Label
    Friend WithEvents labTituloDiagnostico As Label
    Friend WithEvents Button4 As Button
    Friend WithEvents labPerfilDireccion As Label
    Friend WithEvents labPerfilTelefono As Label
    Friend WithEvents labPerfilFechaDeNacimiento As Label
End Class
