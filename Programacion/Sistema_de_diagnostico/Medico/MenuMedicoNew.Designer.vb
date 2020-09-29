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
        Me.ListView2 = New System.Windows.Forms.ListView()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.Panel1.SuspendLayout()
        Me.pConsultaPend.SuspendLayout()
        Me.PHistCons.SuspendLayout()
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
        'ListView2
        '
        Me.ListView2.HideSelection = False
        Me.ListView2.Location = New System.Drawing.Point(3, 56)
        Me.ListView2.Name = "ListView2"
        Me.ListView2.Size = New System.Drawing.Size(307, 528)
        Me.ListView2.TabIndex = 0
        Me.ListView2.UseCompatibleStateImageBehavior = False
        '
        'TextBox1
        '
        Me.TextBox1.BackColor = System.Drawing.Color.FromArgb(CType(CType(196, Byte), Integer), CType(CType(196, Byte), Integer), CType(CType(196, Byte), Integer))
        Me.TextBox1.Location = New System.Drawing.Point(17, 17)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(273, 20)
        Me.TextBox1.TabIndex = 20
        '
        'MenuMedicoNew
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(980, 645)
        Me.ControlBox = False
        Me.Controls.Add(Me.pConsultaPend)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.PHistCons)
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
End Class
