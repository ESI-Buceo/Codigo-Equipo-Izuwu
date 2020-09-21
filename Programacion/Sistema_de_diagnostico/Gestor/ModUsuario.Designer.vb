<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ModUsuario
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
        Me.txtEmpresa = New System.Windows.Forms.TextBox()
        Me.rbtnGestor = New System.Windows.Forms.RadioButton()
        Me.rbtnMedico = New System.Windows.Forms.RadioButton()
        Me.txtConfContraseña = New System.Windows.Forms.TextBox()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.mthFecha = New System.Windows.Forms.MonthCalendar()
        Me.txtContraseña = New System.Windows.Forms.TextBox()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.btnAceptar = New System.Windows.Forms.Button()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.lblInfo = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txtEMail = New System.Windows.Forms.TextBox()
        Me.txtEspecializacion = New System.Windows.Forms.TextBox()
        Me.txtDireccion = New System.Windows.Forms.TextBox()
        Me.txtTelefono = New System.Windows.Forms.TextBox()
        Me.txtCI = New System.Windows.Forms.TextBox()
        Me.txtApellido = New System.Windows.Forms.TextBox()
        Me.txtNombre = New System.Windows.Forms.TextBox()
        Me.txtID = New System.Windows.Forms.TextBox()
        Me.SuspendLayout()
        '
        'txtEmpresa
        '
        Me.txtEmpresa.Location = New System.Drawing.Point(32, 344)
        Me.txtEmpresa.Name = "txtEmpresa"
        Me.txtEmpresa.Size = New System.Drawing.Size(218, 20)
        Me.txtEmpresa.TabIndex = 56
        '
        'rbtnGestor
        '
        Me.rbtnGestor.AutoSize = True
        Me.rbtnGestor.Location = New System.Drawing.Point(367, 392)
        Me.rbtnGestor.Name = "rbtnGestor"
        Me.rbtnGestor.Size = New System.Drawing.Size(56, 17)
        Me.rbtnGestor.TabIndex = 55
        Me.rbtnGestor.TabStop = True
        Me.rbtnGestor.Text = "Gestor"
        Me.rbtnGestor.UseVisualStyleBackColor = True
        '
        'rbtnMedico
        '
        Me.rbtnMedico.AutoSize = True
        Me.rbtnMedico.Location = New System.Drawing.Point(367, 368)
        Me.rbtnMedico.Name = "rbtnMedico"
        Me.rbtnMedico.Size = New System.Drawing.Size(60, 17)
        Me.rbtnMedico.TabIndex = 54
        Me.rbtnMedico.TabStop = True
        Me.rbtnMedico.Text = "Medico"
        Me.rbtnMedico.UseVisualStyleBackColor = True
        '
        'txtConfContraseña
        '
        Me.txtConfContraseña.Location = New System.Drawing.Point(367, 321)
        Me.txtConfContraseña.Name = "txtConfContraseña"
        Me.txtConfContraseña.Size = New System.Drawing.Size(192, 20)
        Me.txtConfContraseña.TabIndex = 53
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Location = New System.Drawing.Point(364, 305)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(110, 13)
        Me.Label12.TabIndex = 52
        Me.Label12.Text = "Confirmar contraseña:"
        '
        'mthFecha
        '
        Me.mthFecha.Location = New System.Drawing.Point(367, 75)
        Me.mthFecha.Name = "mthFecha"
        Me.mthFecha.ShowToday = False
        Me.mthFecha.ShowTodayCircle = False
        Me.mthFecha.TabIndex = 51
        '
        'txtContraseña
        '
        Me.txtContraseña.Location = New System.Drawing.Point(367, 277)
        Me.txtContraseña.Name = "txtContraseña"
        Me.txtContraseña.Size = New System.Drawing.Size(192, 20)
        Me.txtContraseña.TabIndex = 50
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Location = New System.Drawing.Point(364, 258)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(64, 13)
        Me.Label11.TabIndex = 49
        Me.Label11.Text = "Contraseña:"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(364, 59)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(109, 13)
        Me.Label10.TabIndex = 48
        Me.Label10.Text = "Fecha de nacimiento:"
        '
        'btnAceptar
        '
        Me.btnAceptar.Location = New System.Drawing.Point(607, 414)
        Me.btnAceptar.Name = "btnAceptar"
        Me.btnAceptar.Size = New System.Drawing.Size(101, 24)
        Me.btnAceptar.TabIndex = 47
        Me.btnAceptar.Text = "Aceptar"
        Me.btnAceptar.UseVisualStyleBackColor = True
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.Location = New System.Drawing.Point(26, 13)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(100, 25)
        Me.Label9.TabIndex = 46
        Me.Label9.Text = "Registro"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(29, 373)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(36, 13)
        Me.Label8.TabIndex = 45
        Me.Label8.Text = "E-Mail"
        '
        'lblInfo
        '
        Me.lblInfo.AutoSize = True
        Me.lblInfo.Location = New System.Drawing.Point(29, 328)
        Me.lblInfo.Name = "lblInfo"
        Me.lblInfo.Size = New System.Drawing.Size(83, 13)
        Me.lblInfo.TabIndex = 44
        Me.lblInfo.Text = "Especializacion:"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(29, 193)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(23, 13)
        Me.Label6.TabIndex = 43
        Me.Label6.Text = "C.I."
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(29, 235)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(49, 13)
        Me.Label5.TabIndex = 42
        Me.Label5.Text = "Telefono"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(29, 280)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(52, 13)
        Me.Label4.TabIndex = 41
        Me.Label4.Text = "Direccion"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(29, 150)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(44, 13)
        Me.Label3.TabIndex = 40
        Me.Label3.Text = "Apellido"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(29, 105)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(44, 13)
        Me.Label2.TabIndex = 39
        Me.Label2.Text = "Nombre"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(29, 59)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(18, 13)
        Me.Label1.TabIndex = 38
        Me.Label1.Text = "ID"
        '
        'txtEMail
        '
        Me.txtEMail.Location = New System.Drawing.Point(32, 389)
        Me.txtEMail.Name = "txtEMail"
        Me.txtEMail.Size = New System.Drawing.Size(218, 20)
        Me.txtEMail.TabIndex = 37
        '
        'txtEspecializacion
        '
        Me.txtEspecializacion.Location = New System.Drawing.Point(32, 344)
        Me.txtEspecializacion.Name = "txtEspecializacion"
        Me.txtEspecializacion.Size = New System.Drawing.Size(218, 20)
        Me.txtEspecializacion.TabIndex = 36
        '
        'txtDireccion
        '
        Me.txtDireccion.Location = New System.Drawing.Point(32, 296)
        Me.txtDireccion.Name = "txtDireccion"
        Me.txtDireccion.Size = New System.Drawing.Size(218, 20)
        Me.txtDireccion.TabIndex = 35
        '
        'txtTelefono
        '
        Me.txtTelefono.Location = New System.Drawing.Point(32, 251)
        Me.txtTelefono.Name = "txtTelefono"
        Me.txtTelefono.Size = New System.Drawing.Size(218, 20)
        Me.txtTelefono.TabIndex = 34
        '
        'txtCI
        '
        Me.txtCI.Location = New System.Drawing.Point(32, 209)
        Me.txtCI.MaxLength = 8
        Me.txtCI.Name = "txtCI"
        Me.txtCI.Size = New System.Drawing.Size(218, 20)
        Me.txtCI.TabIndex = 33
        '
        'txtApellido
        '
        Me.txtApellido.Location = New System.Drawing.Point(32, 166)
        Me.txtApellido.Name = "txtApellido"
        Me.txtApellido.Size = New System.Drawing.Size(218, 20)
        Me.txtApellido.TabIndex = 32
        '
        'txtNombre
        '
        Me.txtNombre.Location = New System.Drawing.Point(32, 121)
        Me.txtNombre.Name = "txtNombre"
        Me.txtNombre.Size = New System.Drawing.Size(218, 20)
        Me.txtNombre.TabIndex = 31
        '
        'txtID
        '
        Me.txtID.Enabled = False
        Me.txtID.Location = New System.Drawing.Point(32, 75)
        Me.txtID.Name = "txtID"
        Me.txtID.Size = New System.Drawing.Size(218, 20)
        Me.txtID.TabIndex = 30
        '
        'ModUsuario
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(734, 450)
        Me.Controls.Add(Me.txtEmpresa)
        Me.Controls.Add(Me.rbtnGestor)
        Me.Controls.Add(Me.rbtnMedico)
        Me.Controls.Add(Me.txtConfContraseña)
        Me.Controls.Add(Me.Label12)
        Me.Controls.Add(Me.mthFecha)
        Me.Controls.Add(Me.txtContraseña)
        Me.Controls.Add(Me.Label11)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.btnAceptar)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.lblInfo)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.txtEMail)
        Me.Controls.Add(Me.txtEspecializacion)
        Me.Controls.Add(Me.txtDireccion)
        Me.Controls.Add(Me.txtTelefono)
        Me.Controls.Add(Me.txtCI)
        Me.Controls.Add(Me.txtApellido)
        Me.Controls.Add(Me.txtNombre)
        Me.Controls.Add(Me.txtID)
        Me.Name = "ModUsuario"
        Me.Text = "ModUsuario"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents txtEmpresa As TextBox
    Friend WithEvents rbtnGestor As RadioButton
    Friend WithEvents rbtnMedico As RadioButton
    Friend WithEvents txtConfContraseña As TextBox
    Friend WithEvents Label12 As Label
    Friend WithEvents mthFecha As MonthCalendar
    Friend WithEvents txtContraseña As TextBox
    Friend WithEvents Label11 As Label
    Friend WithEvents Label10 As Label
    Friend WithEvents btnAceptar As Button
    Friend WithEvents Label9 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents lblInfo As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents txtEMail As TextBox
    Friend WithEvents txtEspecializacion As TextBox
    Friend WithEvents txtDireccion As TextBox
    Friend WithEvents txtTelefono As TextBox
    Friend WithEvents txtCI As TextBox
    Friend WithEvents txtApellido As TextBox
    Friend WithEvents txtNombre As TextBox
    Friend WithEvents txtID As TextBox
End Class
