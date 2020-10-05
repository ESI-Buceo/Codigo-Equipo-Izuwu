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
        Me.lbIniciales = New System.Windows.Forms.Label()
        Me.lbNombre = New System.Windows.Forms.Label()
        Me.btnChats = New System.Windows.Forms.Button()
        Me.btnConsPendientes = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.pConsultaPend = New System.Windows.Forms.Panel()
        Me.ListView1 = New System.Windows.Forms.ListView()
        Me.PHistCons = New System.Windows.Forms.Panel()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.ListView2 = New System.Windows.Forms.ListView()
        Me.pPerfilPaciente = New System.Windows.Forms.Panel()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.pdatosPaciente = New System.Windows.Forms.Panel()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.pDatosMedicos = New System.Windows.Forms.Panel()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.Panel1.SuspendLayout()
        Me.pConsultaPend.SuspendLayout()
        Me.PHistCons.SuspendLayout()
        Me.pPerfilPaciente.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.pdatosPaciente.SuspendLayout()
        Me.pDatosMedicos.SuspendLayout()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.FromArgb(CType(CType(50, Byte), Integer), CType(CType(174, Byte), Integer), CType(CType(144, Byte), Integer))
        Me.Panel1.Controls.Add(Me.btnHistorialdeConsultas)
        Me.Panel1.Controls.Add(Me.lbIniciales)
        Me.Panel1.Controls.Add(Me.lbNombre)
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
        'lbIniciales
        '
        Me.lbIniciales.AutoSize = True
        Me.lbIniciales.Font = New System.Drawing.Font("Microsoft Sans Serif", 28.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbIniciales.ForeColor = System.Drawing.Color.White
        Me.lbIniciales.Location = New System.Drawing.Point(12, 16)
        Me.lbIniciales.Name = "lbIniciales"
        Me.lbIniciales.Size = New System.Drawing.Size(72, 44)
        Me.lbIniciales.TabIndex = 8
        Me.lbIniciales.Text = "NP"
        '
        'lbNombre
        '
        Me.lbNombre.AutoSize = True
        Me.lbNombre.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbNombre.ForeColor = System.Drawing.Color.White
        Me.lbNombre.Location = New System.Drawing.Point(103, 9)
        Me.lbNombre.Name = "lbNombre"
        Me.lbNombre.Size = New System.Drawing.Size(132, 25)
        Me.lbNombre.TabIndex = 5
        Me.lbNombre.Text = "Nicolas Perez"
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
        'pConsultaPend
        '
        Me.pConsultaPend.Controls.Add(Me.ListView1)
        Me.pConsultaPend.Location = New System.Drawing.Point(297, 32)
        Me.pConsultaPend.Name = "pConsultaPend"
        Me.pConsultaPend.Size = New System.Drawing.Size(671, 601)
        Me.pConsultaPend.TabIndex = 7
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
        'PHistCons
        '
        Me.PHistCons.Controls.Add(Me.TextBox1)
        Me.PHistCons.Controls.Add(Me.ListView2)
        Me.PHistCons.Location = New System.Drawing.Point(294, 35)
        Me.PHistCons.Name = "PHistCons"
        Me.PHistCons.Size = New System.Drawing.Size(671, 601)
        Me.PHistCons.TabIndex = 8
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
        'pPerfilPaciente
        '
        Me.pPerfilPaciente.BackColor = System.Drawing.Color.White
        Me.pPerfilPaciente.Controls.Add(Me.Label7)
        Me.pPerfilPaciente.Controls.Add(Me.Label6)
        Me.pPerfilPaciente.Controls.Add(Me.Label5)
        Me.pPerfilPaciente.Controls.Add(Me.PictureBox1)
        Me.pPerfilPaciente.Controls.Add(Me.pDatosMedicos)
        Me.pPerfilPaciente.Controls.Add(Me.pdatosPaciente)
        Me.pPerfilPaciente.Location = New System.Drawing.Point(287, 7)
        Me.pPerfilPaciente.Name = "pPerfilPaciente"
        Me.pPerfilPaciente.Size = New System.Drawing.Size(691, 641)
        Me.pPerfilPaciente.TabIndex = 12
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Yu Gothic UI Semilight", 13.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.ForeColor = System.Drawing.Color.Black
        Me.Label7.Location = New System.Drawing.Point(232, 227)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(159, 25)
        Me.Label7.TabIndex = 13
        Me.Label7.Text = "ID Paciente O MED"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Yu Gothic UI", 24.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.ForeColor = System.Drawing.Color.Black
        Me.Label6.Location = New System.Drawing.Point(187, 179)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(259, 45)
        Me.Label6.TabIndex = 13
        Me.Label6.Text = "Nombre Usuario"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Yu Gothic UI", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(4, 5)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(31, 25)
        Me.Label5.TabIndex = 24
        Me.Label5.Text = "←"
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
        Me.pdatosPaciente.Controls.Add(Me.Label11)
        Me.pdatosPaciente.Controls.Add(Me.Label10)
        Me.pdatosPaciente.Controls.Add(Me.Label9)
        Me.pdatosPaciente.Controls.Add(Me.Label8)
        Me.pdatosPaciente.Location = New System.Drawing.Point(3, 358)
        Me.pdatosPaciente.Name = "pdatosPaciente"
        Me.pdatosPaciente.Size = New System.Drawing.Size(619, 270)
        Me.pdatosPaciente.TabIndex = 25
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Font = New System.Drawing.Font("Yu Gothic UI Semilight", 13.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.ForeColor = System.Drawing.Color.Black
        Me.Label11.Location = New System.Drawing.Point(434, 57)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(153, 25)
        Me.Label11.TabIndex = 17
        Me.Label11.Text = "Patologias Previas:"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Yu Gothic UI Semilight", 13.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.ForeColor = System.Drawing.Color.Black
        Me.Label10.Location = New System.Drawing.Point(35, 163)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(87, 25)
        Me.Label10.TabIndex = 16
        Me.Label10.Text = "Direccion:"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Yu Gothic UI Semilight", 13.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.ForeColor = System.Drawing.Color.Black
        Me.Label9.Location = New System.Drawing.Point(35, 109)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(80, 25)
        Me.Label9.TabIndex = 15
        Me.Label9.Text = "Telefono:"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Yu Gothic UI Semilight", 13.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.ForeColor = System.Drawing.Color.Black
        Me.Label8.Location = New System.Drawing.Point(35, 57)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(54, 25)
        Me.Label8.TabIndex = 14
        Me.Label8.Text = "Edad:"
        '
        'pDatosMedicos
        '
        Me.pDatosMedicos.Controls.Add(Me.Button3)
        Me.pDatosMedicos.Controls.Add(Me.Label14)
        Me.pDatosMedicos.Controls.Add(Me.Label12)
        Me.pDatosMedicos.Location = New System.Drawing.Point(4, 351)
        Me.pDatosMedicos.Name = "pDatosMedicos"
        Me.pDatosMedicos.Size = New System.Drawing.Size(624, 281)
        Me.pDatosMedicos.TabIndex = 26
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
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Font = New System.Drawing.Font("Yu Gothic UI Semilight", 13.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label14.ForeColor = System.Drawing.Color.Black
        Me.Label14.Location = New System.Drawing.Point(26, 181)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(109, 25)
        Me.Label14.TabIndex = 16
        Me.Label14.Text = "Especialidad:"
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Font = New System.Drawing.Font("Yu Gothic UI Semilight", 13.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label12.ForeColor = System.Drawing.Color.Black
        Me.Label12.Location = New System.Drawing.Point(26, 64)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(143, 25)
        Me.Label12.TabIndex = 15
        Me.Label12.Text = "Lugar de Trabajo:"
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
        Me.Controls.Add(Me.pPerfilPaciente)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.PHistCons)
        Me.Controls.Add(Me.pConsultaPend)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.MaximumSize = New System.Drawing.Size(980, 645)
        Me.MinimumSize = New System.Drawing.Size(964, 606)
        Me.Name = "MenuMedicoNew"
        Me.Text = "MenuPacienteNew"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.pConsultaPend.ResumeLayout(False)
        Me.PHistCons.ResumeLayout(False)
        Me.PHistCons.PerformLayout()
        Me.pPerfilPaciente.ResumeLayout(False)
        Me.pPerfilPaciente.PerformLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.pdatosPaciente.ResumeLayout(False)
        Me.pdatosPaciente.PerformLayout()
        Me.pDatosMedicos.ResumeLayout(False)
        Me.pDatosMedicos.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Panel1 As Panel
    Friend WithEvents lbIniciales As Label
    Friend WithEvents lbNombre As Label
    Friend WithEvents btnChats As Button
    Friend WithEvents btnConsPendientes As Button
    Friend WithEvents btnHistorialdeConsultas As Button
    Friend WithEvents Button2 As Button
    Friend WithEvents Button1 As Button
    Friend WithEvents pConsultaPend As Panel
    Friend WithEvents ListView1 As ListView
    Friend WithEvents PHistCons As Panel
    Friend WithEvents ListView2 As ListView
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents pPerfilPaciente As Panel
    Friend WithEvents Label7 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents pdatosPaciente As Panel
    Friend WithEvents Label11 As Label
    Friend WithEvents Label10 As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents pDatosMedicos As Panel
    Friend WithEvents Button3 As Button
    Friend WithEvents Label14 As Label
    Friend WithEvents Label12 As Label
End Class
