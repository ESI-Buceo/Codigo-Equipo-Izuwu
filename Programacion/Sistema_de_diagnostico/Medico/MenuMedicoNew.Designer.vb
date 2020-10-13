<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class MenuMedicoNew
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(MenuMedicoNew))
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.btnHistorialdeConsultas = New System.Windows.Forms.Button()
        Me.labIniciales = New System.Windows.Forms.Label()
        Me.labNombre = New System.Windows.Forms.Label()
        Me.btnChats = New System.Windows.Forms.Button()
        Me.btnConsPendientes = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.panelConsultaPendiente = New System.Windows.Forms.Panel()
        Me.ListView1 = New System.Windows.Forms.ListView()
        Me.panelHistorialConsulta = New System.Windows.Forms.Panel()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.ListView2 = New System.Windows.Forms.ListView()
        Me.panelPerfilPaciente = New System.Windows.Forms.Panel()
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
        Me.Button3 = New System.Windows.Forms.Button()
        Me.label4 = New System.Windows.Forms.Label()
        Me.label3 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.labPerfilFechaDeNacimiento = New System.Windows.Forms.Label()
        Me.labPerfilLugarDeTrabajo = New System.Windows.Forms.Label()
        Me.labPerfilEspecialidad = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.labPerfilDireccion = New System.Windows.Forms.Label()
        Me.labPerfilTelefono = New System.Windows.Forms.Label()
        Me.Panel1.SuspendLayout()
        Me.panelConsultaPendiente.SuspendLayout()
        Me.panelHistorialConsulta.SuspendLayout()
        Me.panelPerfilPaciente.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.paneldatosPaciente.SuspendLayout()
        Me.panelDatosMedicos.SuspendLayout()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.FromArgb(CType(CType(50, Byte), Integer), CType(CType(174, Byte), Integer), CType(CType(144, Byte), Integer))
        Me.Panel1.Controls.Add(Me.btnHistorialdeConsultas)
        Me.Panel1.Controls.Add(Me.labIniciales)
        Me.Panel1.Controls.Add(Me.labNombre)
        Me.Panel1.Controls.Add(Me.btnChats)
        Me.Panel1.Controls.Add(Me.btnConsPendientes)
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(284, 648)
        Me.Panel1.TabIndex = 1
        '
        'btnHistorialdeConsultas
        '
        Me.btnHistorialdeConsultas.BackColor = System.Drawing.Color.Transparent
        Me.btnHistorialdeConsultas.FlatAppearance.BorderSize = 0
        Me.btnHistorialdeConsultas.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnHistorialdeConsultas.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnHistorialdeConsultas.ForeColor = System.Drawing.Color.White
        Me.btnHistorialdeConsultas.Location = New System.Drawing.Point(0, 392)
        Me.btnHistorialdeConsultas.Name = "btnHistorialdeConsultas"
        Me.btnHistorialdeConsultas.Size = New System.Drawing.Size(291, 47)
        Me.btnHistorialdeConsultas.TabIndex = 11
        Me.btnHistorialdeConsultas.Text = "Historial de Consulta"
        Me.btnHistorialdeConsultas.UseVisualStyleBackColor = False
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
        'btnConsPendientes
        '
        Me.btnConsPendientes.BackColor = System.Drawing.Color.Transparent
        Me.btnConsPendientes.FlatAppearance.BorderSize = 0
        Me.btnConsPendientes.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnConsPendientes.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnConsPendientes.ForeColor = System.Drawing.Color.White
        Me.btnConsPendientes.Location = New System.Drawing.Point(0, 180)
        Me.btnConsPendientes.Name = "btnConsPendientes"
        Me.btnConsPendientes.Size = New System.Drawing.Size(291, 47)
        Me.btnConsPendientes.TabIndex = 0
        Me.btnConsPendientes.Text = "Consultas Pendientes"
        Me.btnConsPendientes.UseVisualStyleBackColor = False
        '
        'Button2
        '
        Me.Button2.BackColor = System.Drawing.Color.White
        Me.Button2.FlatAppearance.BorderSize = 0
        Me.Button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button2.Font = New System.Drawing.Font("Consolas", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button2.ForeColor = System.Drawing.Color.Black
        Me.Button2.Location = New System.Drawing.Point(890, 0)
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
        Me.Button1.Location = New System.Drawing.Point(937, 0)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(41, 26)
        Me.Button1.TabIndex = 5
        Me.Button1.Text = "X"
        Me.Button1.UseVisualStyleBackColor = False
        '
        'panelConsultaPendiente
        '
        Me.panelConsultaPendiente.Controls.Add(Me.ListView1)
        Me.panelConsultaPendiente.Location = New System.Drawing.Point(297, 32)
        Me.panelConsultaPendiente.Name = "panelConsultaPendiente"
        Me.panelConsultaPendiente.Size = New System.Drawing.Size(671, 601)
        Me.panelConsultaPendiente.TabIndex = 7
        '
        'ListView1
        '
        Me.ListView1.HideSelection = False
        Me.ListView1.Location = New System.Drawing.Point(3, 3)
        Me.ListView1.Name = "ListView1"
        Me.ListView1.Size = New System.Drawing.Size(261, 595)
        Me.ListView1.TabIndex = 0
        Me.ListView1.UseCompatibleStateImageBehavior = False
        '
        'panelHistorialConsulta
        '
        Me.panelHistorialConsulta.Controls.Add(Me.TextBox1)
        Me.panelHistorialConsulta.Controls.Add(Me.ListView2)
        Me.panelHistorialConsulta.Location = New System.Drawing.Point(294, 35)
        Me.panelHistorialConsulta.Name = "panelHistorialConsulta"
        Me.panelHistorialConsulta.Size = New System.Drawing.Size(671, 601)
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
        'panelPerfilPaciente
        '
        Me.panelPerfilPaciente.BackColor = System.Drawing.Color.White
        Me.panelPerfilPaciente.Controls.Add(Me.labPerfilID)
        Me.panelPerfilPaciente.Controls.Add(Me.labPerfilNombre)
        Me.panelPerfilPaciente.Controls.Add(Me.Label5)
        Me.panelPerfilPaciente.Controls.Add(Me.PictureBox1)
        Me.panelPerfilPaciente.Controls.Add(Me.panelDatosMedicos)
        Me.panelPerfilPaciente.Controls.Add(Me.paneldatosPaciente)
        Me.panelPerfilPaciente.Location = New System.Drawing.Point(286, 29)
        Me.panelPerfilPaciente.Name = "panelPerfilPaciente"
        Me.panelPerfilPaciente.Size = New System.Drawing.Size(691, 607)
        Me.panelPerfilPaciente.TabIndex = 12
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
        Me.Label5.Location = New System.Drawing.Point(4, -4)
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
        Me.paneldatosPaciente.Controls.Add(Me.Button3)
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
        Me.panelDatosMedicos.Controls.Add(Me.labPerfilTelefono)
        Me.panelDatosMedicos.Controls.Add(Me.labPerfilDireccion)
        Me.panelDatosMedicos.Controls.Add(Me.Label6)
        Me.panelDatosMedicos.Controls.Add(Me.Label2)
        Me.panelDatosMedicos.Controls.Add(Me.labPerfilEspecialidad)
        Me.panelDatosMedicos.Controls.Add(Me.labPerfilLugarDeTrabajo)
        Me.panelDatosMedicos.Controls.Add(Me.labPerfilFechaDeNacimiento)
        Me.panelDatosMedicos.Controls.Add(Me.Label1)
        Me.panelDatosMedicos.Controls.Add(Me.label4)
        Me.panelDatosMedicos.Controls.Add(Me.label3)
        Me.panelDatosMedicos.Location = New System.Drawing.Point(9, 301)
        Me.panelDatosMedicos.Name = "panelDatosMedicos"
        Me.panelDatosMedicos.Size = New System.Drawing.Size(670, 282)
        Me.panelDatosMedicos.TabIndex = 26
        '
        'Button3
        '
        Me.Button3.BackColor = System.Drawing.Color.LightGray
        Me.Button3.FlatAppearance.BorderSize = 0
        Me.Button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button3.Location = New System.Drawing.Point(629, 245)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(111, 22)
        Me.Button3.TabIndex = 17
        Me.Button3.Text = "! Reportar usuario"
        Me.Button3.UseVisualStyleBackColor = False
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
        'labPerfilFechaDeNacimiento
        '
        Me.labPerfilFechaDeNacimiento.AutoSize = True
        Me.labPerfilFechaDeNacimiento.Font = New System.Drawing.Font("Yu Gothic UI Semilight", 13.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.labPerfilFechaDeNacimiento.ForeColor = System.Drawing.Color.Black
        Me.labPerfilFechaDeNacimiento.Location = New System.Drawing.Point(200, 72)
        Me.labPerfilFechaDeNacimiento.Name = "labPerfilFechaDeNacimiento"
        Me.labPerfilFechaDeNacimiento.Size = New System.Drawing.Size(102, 25)
        Me.labPerfilFechaDeNacimiento.TabIndex = 18
        Me.labPerfilFechaDeNacimiento.Text = "No cargado"
        '
        'labPerfilLugarDeTrabajo
        '
        Me.labPerfilLugarDeTrabajo.AutoSize = True
        Me.labPerfilLugarDeTrabajo.Font = New System.Drawing.Font("Yu Gothic UI Semilight", 13.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.labPerfilLugarDeTrabajo.ForeColor = System.Drawing.Color.Black
        Me.labPerfilLugarDeTrabajo.Location = New System.Drawing.Point(200, 132)
        Me.labPerfilLugarDeTrabajo.Name = "labPerfilLugarDeTrabajo"
        Me.labPerfilLugarDeTrabajo.Size = New System.Drawing.Size(102, 25)
        Me.labPerfilLugarDeTrabajo.TabIndex = 19
        Me.labPerfilLugarDeTrabajo.Text = "No cargado"
        '
        'labPerfilEspecialidad
        '
        Me.labPerfilEspecialidad.AutoSize = True
        Me.labPerfilEspecialidad.Font = New System.Drawing.Font("Yu Gothic UI Semilight", 13.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.labPerfilEspecialidad.ForeColor = System.Drawing.Color.Black
        Me.labPerfilEspecialidad.Location = New System.Drawing.Point(200, 194)
        Me.labPerfilEspecialidad.Name = "labPerfilEspecialidad"
        Me.labPerfilEspecialidad.Size = New System.Drawing.Size(102, 25)
        Me.labPerfilEspecialidad.TabIndex = 20
        Me.labPerfilEspecialidad.Text = "No cargado"
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
        Me.Label2.Text = "Direccion:"
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
        Me.Label6.Text = "Telefono:"
        '
        'labPerfilDireccion
        '
        Me.labPerfilDireccion.AutoSize = True
        Me.labPerfilDireccion.Font = New System.Drawing.Font("Yu Gothic UI Semilight", 13.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.labPerfilDireccion.ForeColor = System.Drawing.Color.Black
        Me.labPerfilDireccion.Location = New System.Drawing.Point(465, 72)
        Me.labPerfilDireccion.Name = "labPerfilDireccion"
        Me.labPerfilDireccion.Size = New System.Drawing.Size(102, 25)
        Me.labPerfilDireccion.TabIndex = 23
        Me.labPerfilDireccion.Text = "No cargado"
        '
        'labPerfilTelefono
        '
        Me.labPerfilTelefono.AutoSize = True
        Me.labPerfilTelefono.Font = New System.Drawing.Font("Yu Gothic UI Semilight", 13.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.labPerfilTelefono.ForeColor = System.Drawing.Color.Black
        Me.labPerfilTelefono.Location = New System.Drawing.Point(465, 132)
        Me.labPerfilTelefono.Name = "labPerfilTelefono"
        Me.labPerfilTelefono.Size = New System.Drawing.Size(102, 25)
        Me.labPerfilTelefono.TabIndex = 24
        Me.labPerfilTelefono.Text = "No cargado"
        '
        'MenuMedicoNew
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(980, 645)
        Me.ControlBox = False
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.panelPerfilPaciente)
        Me.Controls.Add(Me.panelHistorialConsulta)
        Me.Controls.Add(Me.panelConsultaPendiente)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.MaximumSize = New System.Drawing.Size(980, 645)
        Me.MinimumSize = New System.Drawing.Size(964, 606)
        Me.Name = "MenuMedicoNew"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "MenuPacienteNew"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.panelConsultaPendiente.ResumeLayout(False)
        Me.panelHistorialConsulta.ResumeLayout(False)
        Me.panelHistorialConsulta.PerformLayout()
        Me.panelPerfilPaciente.ResumeLayout(False)
        Me.panelPerfilPaciente.PerformLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.paneldatosPaciente.ResumeLayout(False)
        Me.paneldatosPaciente.PerformLayout()
        Me.panelDatosMedicos.ResumeLayout(False)
        Me.panelDatosMedicos.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Panel1 As Panel
    Friend WithEvents labIniciales As Label
    Friend WithEvents labNombre As Label
    Friend WithEvents btnChats As Button
    Friend WithEvents btnConsPendientes As Button
    Friend WithEvents btnHistorialdeConsultas As Button
    Friend WithEvents Button2 As Button
    Friend WithEvents Button1 As Button
    Friend WithEvents panelConsultaPendiente As Panel
    Friend WithEvents ListView1 As ListView
    Friend WithEvents panelHistorialConsulta As Panel
    Friend WithEvents ListView2 As ListView
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents panelPerfilPaciente As Panel
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
    Friend WithEvents Button3 As Button
    Friend WithEvents label4 As Label
    Friend WithEvents label3 As Label
    Friend WithEvents txtPatologiasPreviasPAC As TextBox
    Friend WithEvents labDireccionPAC As Label
    Friend WithEvents labTelefonoPAC As Label
    Friend WithEvents labFechaDeNacimientoPAC As Label
    Friend WithEvents labPerfilEspecialidad As Label
    Friend WithEvents labPerfilLugarDeTrabajo As Label
    Friend WithEvents labPerfilFechaDeNacimiento As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents labPerfilTelefono As Label
    Friend WithEvents labPerfilDireccion As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label2 As Label
End Class
