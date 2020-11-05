<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FinalizarConsulta
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
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.cbxPatologiaFinal = New Guna.UI2.WinForms.Guna2ComboBox()
        Me.dateFechaDiagnostico = New System.Windows.Forms.DateTimePicker()
        Me.labCedulaPaciente = New Guna.UI2.WinForms.Guna2HtmlLabel()
        Me.labNombrePaciente = New Guna.UI2.WinForms.Guna2HtmlLabel()
        Me.btnFinalizarConsulta = New Guna.UI2.WinForms.Guna2Button()
        Me.Guna2HtmlLabel6 = New Guna.UI2.WinForms.Guna2HtmlLabel()
        Me.Guna2HtmlLabel5 = New Guna.UI2.WinForms.Guna2HtmlLabel()
        Me.Guna2HtmlLabel4 = New Guna.UI2.WinForms.Guna2HtmlLabel()
        Me.Guna2HtmlLabel3 = New Guna.UI2.WinForms.Guna2HtmlLabel()
        Me.Guna2HtmlLabel2 = New Guna.UI2.WinForms.Guna2HtmlLabel()
        Me.txtContenido = New Guna.UI2.WinForms.Guna2TextBox()
        Me.btnCerrar = New Guna.UI2.WinForms.Guna2CircleButton()
        Me.Panel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.White
        Me.Panel1.Controls.Add(Me.cbxPatologiaFinal)
        Me.Panel1.Controls.Add(Me.dateFechaDiagnostico)
        Me.Panel1.Controls.Add(Me.labCedulaPaciente)
        Me.Panel1.Controls.Add(Me.labNombrePaciente)
        Me.Panel1.Controls.Add(Me.btnFinalizarConsulta)
        Me.Panel1.Controls.Add(Me.Guna2HtmlLabel6)
        Me.Panel1.Controls.Add(Me.Guna2HtmlLabel5)
        Me.Panel1.Controls.Add(Me.Guna2HtmlLabel4)
        Me.Panel1.Controls.Add(Me.Guna2HtmlLabel3)
        Me.Panel1.Controls.Add(Me.Guna2HtmlLabel2)
        Me.Panel1.Controls.Add(Me.txtContenido)
        Me.Panel1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.Panel1.Location = New System.Drawing.Point(-1, 33)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(558, 542)
        Me.Panel1.TabIndex = 0
        '
        'cbxPatologiaFinal
        '
        Me.cbxPatologiaFinal.BackColor = System.Drawing.Color.Transparent
        Me.cbxPatologiaFinal.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed
        Me.cbxPatologiaFinal.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbxPatologiaFinal.FocusedColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.cbxPatologiaFinal.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.cbxPatologiaFinal.FocusedState.Parent = Me.cbxPatologiaFinal
        Me.cbxPatologiaFinal.Font = New System.Drawing.Font("Segoe UI", 10.0!)
        Me.cbxPatologiaFinal.ForeColor = System.Drawing.Color.Black
        Me.cbxPatologiaFinal.HoverState.Parent = Me.cbxPatologiaFinal
        Me.cbxPatologiaFinal.ItemHeight = 30
        Me.cbxPatologiaFinal.ItemsAppearance.Parent = Me.cbxPatologiaFinal
        Me.cbxPatologiaFinal.Location = New System.Drawing.Point(164, 107)
        Me.cbxPatologiaFinal.Name = "cbxPatologiaFinal"
        Me.cbxPatologiaFinal.ShadowDecoration.Parent = Me.cbxPatologiaFinal
        Me.cbxPatologiaFinal.Size = New System.Drawing.Size(144, 36)
        Me.cbxPatologiaFinal.TabIndex = 15
        '
        'dateFechaDiagnostico
        '
        Me.dateFechaDiagnostico.Location = New System.Drawing.Point(197, 167)
        Me.dateFechaDiagnostico.Name = "dateFechaDiagnostico"
        Me.dateFechaDiagnostico.Size = New System.Drawing.Size(200, 20)
        Me.dateFechaDiagnostico.TabIndex = 14
        '
        'labCedulaPaciente
        '
        Me.labCedulaPaciente.BackColor = System.Drawing.Color.Transparent
        Me.labCedulaPaciente.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.labCedulaPaciente.Location = New System.Drawing.Point(60, 61)
        Me.labCedulaPaciente.Name = "labCedulaPaciente"
        Me.labCedulaPaciente.Size = New System.Drawing.Size(101, 22)
        Me.labCedulaPaciente.TabIndex = 12
        Me.labCedulaPaciente.Text = "Texto ejemplo"
        '
        'labNombrePaciente
        '
        Me.labNombrePaciente.BackColor = System.Drawing.Color.Transparent
        Me.labNombrePaciente.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.labNombrePaciente.Location = New System.Drawing.Point(197, 19)
        Me.labNombrePaciente.Name = "labNombrePaciente"
        Me.labNombrePaciente.Size = New System.Drawing.Size(101, 22)
        Me.labNombrePaciente.TabIndex = 11
        Me.labNombrePaciente.Text = "Texto ejemplo"
        '
        'btnFinalizarConsulta
        '
        Me.btnFinalizarConsulta.AutoRoundedCorners = True
        Me.btnFinalizarConsulta.BorderRadius = 19
        Me.btnFinalizarConsulta.CheckedState.Parent = Me.btnFinalizarConsulta
        Me.btnFinalizarConsulta.CustomImages.Parent = Me.btnFinalizarConsulta
        Me.btnFinalizarConsulta.FillColor = System.Drawing.Color.FromArgb(CType(CType(38, Byte), Integer), CType(CType(131, Byte), Integer), CType(CType(108, Byte), Integer))
        Me.btnFinalizarConsulta.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.btnFinalizarConsulta.ForeColor = System.Drawing.Color.White
        Me.btnFinalizarConsulta.HoverState.Parent = Me.btnFinalizarConsulta
        Me.btnFinalizarConsulta.Location = New System.Drawing.Point(403, 487)
        Me.btnFinalizarConsulta.Name = "btnFinalizarConsulta"
        Me.btnFinalizarConsulta.ShadowDecoration.Parent = Me.btnFinalizarConsulta
        Me.btnFinalizarConsulta.Size = New System.Drawing.Size(132, 41)
        Me.btnFinalizarConsulta.TabIndex = 10
        Me.btnFinalizarConsulta.Text = "Finalizar consulta"
        '
        'Guna2HtmlLabel6
        '
        Me.Guna2HtmlLabel6.BackColor = System.Drawing.Color.Transparent
        Me.Guna2HtmlLabel6.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Guna2HtmlLabel6.Location = New System.Drawing.Point(35, 261)
        Me.Guna2HtmlLabel6.Name = "Guna2HtmlLabel6"
        Me.Guna2HtmlLabel6.Size = New System.Drawing.Size(162, 22)
        Me.Guna2HtmlLabel6.TabIndex = 9
        Me.Guna2HtmlLabel6.Text = "Observaciones finales:"
        '
        'Guna2HtmlLabel5
        '
        Me.Guna2HtmlLabel5.BackColor = System.Drawing.Color.Transparent
        Me.Guna2HtmlLabel5.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Guna2HtmlLabel5.Location = New System.Drawing.Point(18, 165)
        Me.Guna2HtmlLabel5.Name = "Guna2HtmlLabel5"
        Me.Guna2HtmlLabel5.Size = New System.Drawing.Size(162, 22)
        Me.Guna2HtmlLabel5.TabIndex = 8
        Me.Guna2HtmlLabel5.Text = "Fecha del diagnostico:"
        '
        'Guna2HtmlLabel4
        '
        Me.Guna2HtmlLabel4.BackColor = System.Drawing.Color.Transparent
        Me.Guna2HtmlLabel4.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Guna2HtmlLabel4.Location = New System.Drawing.Point(18, 107)
        Me.Guna2HtmlLabel4.Name = "Guna2HtmlLabel4"
        Me.Guna2HtmlLabel4.Size = New System.Drawing.Size(124, 22)
        Me.Guna2HtmlLabel4.TabIndex = 7
        Me.Guna2HtmlLabel4.Text = "Diagnostico final:"
        '
        'Guna2HtmlLabel3
        '
        Me.Guna2HtmlLabel3.BackColor = System.Drawing.Color.Transparent
        Me.Guna2HtmlLabel3.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Guna2HtmlLabel3.Location = New System.Drawing.Point(18, 61)
        Me.Guna2HtmlLabel3.Name = "Guna2HtmlLabel3"
        Me.Guna2HtmlLabel3.Size = New System.Drawing.Size(23, 22)
        Me.Guna2HtmlLabel3.TabIndex = 6
        Me.Guna2HtmlLabel3.Text = "CI:"
        '
        'Guna2HtmlLabel2
        '
        Me.Guna2HtmlLabel2.BackColor = System.Drawing.Color.Transparent
        Me.Guna2HtmlLabel2.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Guna2HtmlLabel2.Location = New System.Drawing.Point(18, 19)
        Me.Guna2HtmlLabel2.Name = "Guna2HtmlLabel2"
        Me.Guna2HtmlLabel2.Size = New System.Drawing.Size(153, 22)
        Me.Guna2HtmlLabel2.TabIndex = 5
        Me.Guna2HtmlLabel2.Text = "Nombre del paciente:"
        '
        'txtContenido
        '
        Me.txtContenido.Animated = True
        Me.txtContenido.BorderColor = System.Drawing.Color.Black
        Me.txtContenido.BorderRadius = 20
        Me.txtContenido.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtContenido.DefaultText = ""
        Me.txtContenido.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.txtContenido.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.txtContenido.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txtContenido.DisabledState.Parent = Me.txtContenido
        Me.txtContenido.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txtContenido.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txtContenido.FocusedState.Parent = Me.txtContenido
        Me.txtContenido.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.txtContenido.ForeColor = System.Drawing.Color.Black
        Me.txtContenido.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txtContenido.HoverState.Parent = Me.txtContenido
        Me.txtContenido.Location = New System.Drawing.Point(18, 289)
        Me.txtContenido.Multiline = True
        Me.txtContenido.Name = "txtContenido"
        Me.txtContenido.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtContenido.PlaceholderText = ""
        Me.txtContenido.SelectedText = ""
        Me.txtContenido.ShadowDecoration.Parent = Me.txtContenido
        Me.txtContenido.Size = New System.Drawing.Size(517, 174)
        Me.txtContenido.TabIndex = 0
        Me.txtContenido.WordWrap = False
        '
        'btnCerrar
        '
        Me.btnCerrar.CheckedState.Parent = Me.btnCerrar
        Me.btnCerrar.CustomImages.Parent = Me.btnCerrar
        Me.btnCerrar.FillColor = System.Drawing.Color.FromArgb(CType(CType(38, Byte), Integer), CType(CType(131, Byte), Integer), CType(CType(108, Byte), Integer))
        Me.btnCerrar.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.btnCerrar.ForeColor = System.Drawing.Color.White
        Me.btnCerrar.HoverState.Parent = Me.btnCerrar
        Me.btnCerrar.Location = New System.Drawing.Point(519, 4)
        Me.btnCerrar.Name = "btnCerrar"
        Me.btnCerrar.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle
        Me.btnCerrar.ShadowDecoration.Parent = Me.btnCerrar
        Me.btnCerrar.Size = New System.Drawing.Size(29, 26)
        Me.btnCerrar.TabIndex = 0
        Me.btnCerrar.Text = "X"
        '
        'FinalizarConsulta
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(50, Byte), Integer), CType(CType(174, Byte), Integer), CType(CType(144, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(558, 573)
        Me.Controls.Add(Me.btnCerrar)
        Me.Controls.Add(Me.Panel1)
        Me.ForeColor = System.Drawing.Color.Black
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "FinalizarConsulta"
        Me.Text = "FinalizarConsulta"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Panel1 As Panel
    Friend WithEvents btnCerrar As Guna.UI2.WinForms.Guna2CircleButton
    Friend WithEvents txtContenido As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents Guna2HtmlLabel6 As Guna.UI2.WinForms.Guna2HtmlLabel
    Friend WithEvents Guna2HtmlLabel5 As Guna.UI2.WinForms.Guna2HtmlLabel
    Friend WithEvents Guna2HtmlLabel4 As Guna.UI2.WinForms.Guna2HtmlLabel
    Friend WithEvents Guna2HtmlLabel3 As Guna.UI2.WinForms.Guna2HtmlLabel
    Friend WithEvents Guna2HtmlLabel2 As Guna.UI2.WinForms.Guna2HtmlLabel
    Friend WithEvents btnFinalizarConsulta As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents cbxPatologiaFinal As Guna.UI2.WinForms.Guna2ComboBox
    Friend WithEvents dateFechaDiagnostico As DateTimePicker
    Friend WithEvents labCedulaPaciente As Guna.UI2.WinForms.Guna2HtmlLabel
    Friend WithEvents labNombrePaciente As Guna.UI2.WinForms.Guna2HtmlLabel
End Class
