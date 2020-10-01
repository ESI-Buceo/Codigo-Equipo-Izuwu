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
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.pRealizarD = New System.Windows.Forms.Panel()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.btnEliminar = New System.Windows.Forms.Button()
        Me.btnAgregar = New System.Windows.Forms.Button()
        Me.lstSintomas = New System.Windows.Forms.ListView()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.btnCerrarsesion = New System.Windows.Forms.Button()
        Me.labIniciales = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.labNombre = New System.Windows.Forms.Label()
        Me.btnChats = New System.Windows.Forms.Button()
        Me.btnRealizarDiagnostico = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.pChat = New System.Windows.Forms.Panel()
        Me.pRealizaD2 = New System.Windows.Forms.Panel()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Button8 = New System.Windows.Forms.Button()
        Me.cbxListaSintomas = New System.Windows.Forms.ComboBox()
        Me.Panel1.SuspendLayout()
        Me.pRealizarD.SuspendLayout()
        Me.pRealizaD2.SuspendLayout()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.FromArgb(CType(CType(40, Byte), Integer), CType(CType(117, Byte), Integer), CType(CType(207, Byte), Integer))
        Me.Panel1.Controls.Add(Me.pRealizarD)
        Me.Panel1.Controls.Add(Me.btnCerrarsesion)
        Me.Panel1.Controls.Add(Me.labIniciales)
        Me.Panel1.Controls.Add(Me.Label2)
        Me.Panel1.Controls.Add(Me.labNombre)
        Me.Panel1.Controls.Add(Me.btnChats)
        Me.Panel1.Controls.Add(Me.btnRealizarDiagnostico)
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(284, 648)
        Me.Panel1.TabIndex = 1
        '
        'pRealizarD
        '
        Me.pRealizarD.Controls.Add(Me.Label13)
        Me.pRealizarD.Controls.Add(Me.btnEliminar)
        Me.pRealizarD.Controls.Add(Me.btnAgregar)
        Me.pRealizarD.Controls.Add(Me.lstSintomas)
        Me.pRealizarD.Controls.Add(Me.Label4)
        Me.pRealizarD.Location = New System.Drawing.Point(0, 130)
        Me.pRealizarD.Name = "pRealizarD"
        Me.pRealizarD.Size = New System.Drawing.Size(284, 517)
        Me.pRealizarD.TabIndex = 12
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Font = New System.Drawing.Font("Yu Gothic UI", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label13.Location = New System.Drawing.Point(247, 483)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(31, 25)
        Me.Label13.TabIndex = 23
        Me.Label13.Text = "←"
        '
        'btnEliminar
        '
        Me.btnEliminar.BackColor = System.Drawing.Color.FromArgb(CType(CType(241, Byte), Integer), CType(CType(33, Byte), Integer), CType(CType(33, Byte), Integer))
        Me.btnEliminar.FlatAppearance.BorderColor = System.Drawing.Color.White
        Me.btnEliminar.FlatAppearance.BorderSize = 0
        Me.btnEliminar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnEliminar.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.btnEliminar.Location = New System.Drawing.Point(189, 424)
        Me.btnEliminar.Name = "btnEliminar"
        Me.btnEliminar.Size = New System.Drawing.Size(92, 28)
        Me.btnEliminar.TabIndex = 14
        Me.btnEliminar.Text = "Eliminar"
        Me.btnEliminar.UseVisualStyleBackColor = False
        '
        'btnAgregar
        '
        Me.btnAgregar.BackColor = System.Drawing.Color.FromArgb(CType(CType(24, Byte), Integer), CType(CType(69, Byte), Integer), CType(CType(122, Byte), Integer))
        Me.btnAgregar.FlatAppearance.BorderColor = System.Drawing.Color.White
        Me.btnAgregar.FlatAppearance.BorderSize = 0
        Me.btnAgregar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnAgregar.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.btnAgregar.Location = New System.Drawing.Point(3, 424)
        Me.btnAgregar.Name = "btnAgregar"
        Me.btnAgregar.Size = New System.Drawing.Size(92, 28)
        Me.btnAgregar.TabIndex = 13
        Me.btnAgregar.Text = "Agregar"
        Me.btnAgregar.UseVisualStyleBackColor = False
        '
        'lstSintomas
        '
        Me.lstSintomas.BackColor = System.Drawing.Color.FromArgb(CType(CType(221, Byte), Integer), CType(CType(221, Byte), Integer), CType(CType(221, Byte), Integer))
        Me.lstSintomas.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
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
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.ForeColor = System.Drawing.Color.White
        Me.Label2.Location = New System.Drawing.Point(105, 49)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(81, 13)
        Me.Label2.TabIndex = 7
        Me.Label2.Text = "Historial medico"
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
        'pChat
        '
        Me.pChat.BackColor = System.Drawing.Color.FromArgb(CType(CType(24, Byte), Integer), CType(CType(69, Byte), Integer), CType(CType(122, Byte), Integer))
        Me.pChat.Location = New System.Drawing.Point(284, 0)
        Me.pChat.Name = "pChat"
        Me.pChat.Size = New System.Drawing.Size(60, 647)
        Me.pChat.TabIndex = 7
        '
        'pRealizaD2
        '
        Me.pRealizaD2.BackColor = System.Drawing.Color.FromArgb(CType(CType(221, Byte), Integer), CType(CType(221, Byte), Integer), CType(CType(221, Byte), Integer))
        Me.pRealizaD2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.pRealizaD2.Controls.Add(Me.cbxListaSintomas)
        Me.pRealizaD2.Controls.Add(Me.Label1)
        Me.pRealizaD2.Controls.Add(Me.Button8)
        Me.pRealizaD2.Location = New System.Drawing.Point(427, 97)
        Me.pRealizaD2.Name = "pRealizaD2"
        Me.pRealizaD2.Size = New System.Drawing.Size(433, 140)
        Me.pRealizaD2.TabIndex = 8
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.ForeColor = System.Drawing.SystemColors.ControlDarkDark
        Me.Label1.Location = New System.Drawing.Point(154, 17)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(106, 13)
        Me.Label1.TabIndex = 19
        Me.Label1.Text = "Busca tu sintoma . . ."
        '
        'Button8
        '
        Me.Button8.BackColor = System.Drawing.Color.FromArgb(CType(CType(24, Byte), Integer), CType(CType(69, Byte), Integer), CType(CType(122, Byte), Integer))
        Me.Button8.FlatAppearance.BorderColor = System.Drawing.Color.White
        Me.Button8.FlatAppearance.BorderSize = 0
        Me.Button8.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button8.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.Button8.Location = New System.Drawing.Point(157, 82)
        Me.Button8.Name = "Button8"
        Me.Button8.Size = New System.Drawing.Size(92, 28)
        Me.Button8.TabIndex = 18
        Me.Button8.Text = "Buscar"
        Me.Button8.UseVisualStyleBackColor = False
        '
        'cbxListaSintomas
        '
        Me.cbxListaSintomas.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
        Me.cbxListaSintomas.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.cbxListaSintomas.BackColor = System.Drawing.Color.Silver
        Me.cbxListaSintomas.FormattingEnabled = True
        Me.cbxListaSintomas.Location = New System.Drawing.Point(18, 46)
        Me.cbxListaSintomas.Name = "cbxListaSintomas"
        Me.cbxListaSintomas.Size = New System.Drawing.Size(398, 21)
        Me.cbxListaSintomas.TabIndex = 20
        '
        'MenuPacienteNew
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(980, 645)
        Me.ControlBox = False
        Me.Controls.Add(Me.pRealizaD2)
        Me.Controls.Add(Me.pChat)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.Panel1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.MaximumSize = New System.Drawing.Size(980, 645)
        Me.MinimumSize = New System.Drawing.Size(964, 606)
        Me.Name = "MenuPacienteNew"
        Me.Text = "MenuPacienteNew"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.pRealizarD.ResumeLayout(False)
        Me.pRealizarD.PerformLayout()
        Me.pRealizaD2.ResumeLayout(False)
        Me.pRealizaD2.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Panel1 As Panel
    Friend WithEvents Label4 As Label
    Friend WithEvents labIniciales As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents labNombre As Label
    Friend WithEvents btnChats As Button
    Friend WithEvents btnRealizarDiagnostico As Button
    Friend WithEvents btnCerrarsesion As Button
    Friend WithEvents Button2 As Button
    Friend WithEvents Button1 As Button
    Friend WithEvents pChat As Panel
    Friend WithEvents pRealizarD As Panel
    Friend WithEvents lstSintomas As ListView
    Friend WithEvents btnEliminar As Button
    Friend WithEvents btnAgregar As Button
    Friend WithEvents pRealizaD2 As Panel
    Friend WithEvents Button8 As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents Label13 As Label
    Friend WithEvents cbxListaSintomas As ComboBox
End Class
