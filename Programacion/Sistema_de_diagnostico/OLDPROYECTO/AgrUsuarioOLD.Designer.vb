<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class AgrUsuarioOLD
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
        Me.txtID = New System.Windows.Forms.TextBox()
        Me.txtNombre = New System.Windows.Forms.TextBox()
        Me.txtApellido = New System.Windows.Forms.TextBox()
        Me.txtCI = New System.Windows.Forms.TextBox()
        Me.txtTelefono = New System.Windows.Forms.TextBox()
        Me.txtDireccion = New System.Windows.Forms.TextBox()
        Me.txtEspecializacion = New System.Windows.Forms.TextBox()
        Me.txtEMail = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.lblInfo = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.btnAceptar = New System.Windows.Forms.Button()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.txtContraseña = New System.Windows.Forms.TextBox()
        Me.mthFecha = New System.Windows.Forms.MonthCalendar()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.txtConfContraseña = New System.Windows.Forms.TextBox()
        Me.rbtnMedico = New System.Windows.Forms.RadioButton()
        Me.rbtnGestor = New System.Windows.Forms.RadioButton()
        Me.txtEmpresa = New System.Windows.Forms.TextBox()
        Me.SuspendLayout()
        '
        'txtID
        '
        Me.txtID.Enabled = False
        Me.txtID.Location = New System.Drawing.Point(18, 75)
        Me.txtID.Name = "txtID"
        Me.txtID.Size = New System.Drawing.Size(218, 20)
        Me.txtID.TabIndex = 0
        '
        'txtNombre
        '
        Me.txtNombre.Location = New System.Drawing.Point(18, 121)
        Me.txtNombre.Name = "txtNombre"
        Me.txtNombre.Size = New System.Drawing.Size(218, 20)
        Me.txtNombre.TabIndex = 1
        '
        'txtApellido
        '
        Me.txtApellido.Location = New System.Drawing.Point(18, 166)
        Me.txtApellido.Name = "txtApellido"
        Me.txtApellido.Size = New System.Drawing.Size(218, 20)
        Me.txtApellido.TabIndex = 2
        '
        'txtCI
        '
        Me.txtCI.Location = New System.Drawing.Point(18, 209)
        Me.txtCI.MaxLength = 8
        Me.txtCI.Name = "txtCI"
        Me.txtCI.Size = New System.Drawing.Size(218, 20)
        Me.txtCI.TabIndex = 3
        '
        'txtTelefono
        '
        Me.txtTelefono.Location = New System.Drawing.Point(18, 251)
        Me.txtTelefono.Name = "txtTelefono"
        Me.txtTelefono.Size = New System.Drawing.Size(218, 20)
        Me.txtTelefono.TabIndex = 4
        '
        'txtDireccion
        '
        Me.txtDireccion.Location = New System.Drawing.Point(18, 296)
        Me.txtDireccion.Name = "txtDireccion"
        Me.txtDireccion.Size = New System.Drawing.Size(218, 20)
        Me.txtDireccion.TabIndex = 5
        '
        'txtEspecializacion
        '
        Me.txtEspecializacion.Location = New System.Drawing.Point(18, 344)
        Me.txtEspecializacion.Name = "txtEspecializacion"
        Me.txtEspecializacion.Size = New System.Drawing.Size(218, 20)
        Me.txtEspecializacion.TabIndex = 6
        '
        'txtEMail
        '
        Me.txtEMail.Location = New System.Drawing.Point(18, 389)
        Me.txtEMail.Name = "txtEMail"
        Me.txtEMail.Size = New System.Drawing.Size(218, 20)
        Me.txtEMail.TabIndex = 7
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(15, 59)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(18, 13)
        Me.Label1.TabIndex = 8
        Me.Label1.Text = "ID"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(15, 105)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(44, 13)
        Me.Label2.TabIndex = 9
        Me.Label2.Text = "Nombre"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(15, 150)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(44, 13)
        Me.Label3.TabIndex = 10
        Me.Label3.Text = "Apellido"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(15, 280)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(52, 13)
        Me.Label4.TabIndex = 11
        Me.Label4.Text = "Direccion"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(15, 235)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(49, 13)
        Me.Label5.TabIndex = 12
        Me.Label5.Text = "Telefono"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(15, 193)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(23, 13)
        Me.Label6.TabIndex = 13
        Me.Label6.Text = "C.I."
        '
        'lblInfo
        '
        Me.lblInfo.AutoSize = True
        Me.lblInfo.Location = New System.Drawing.Point(15, 328)
        Me.lblInfo.Name = "lblInfo"
        Me.lblInfo.Size = New System.Drawing.Size(83, 13)
        Me.lblInfo.TabIndex = 14
        Me.lblInfo.Text = "Especializacion:"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(15, 373)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(36, 13)
        Me.Label8.TabIndex = 15
        Me.Label8.Text = "E-Mail"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.Location = New System.Drawing.Point(12, 13)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(100, 25)
        Me.Label9.TabIndex = 16
        Me.Label9.Text = "Registro"
        '
        'btnAceptar
        '
        Me.btnAceptar.Location = New System.Drawing.Point(593, 414)
        Me.btnAceptar.Name = "btnAceptar"
        Me.btnAceptar.Size = New System.Drawing.Size(101, 24)
        Me.btnAceptar.TabIndex = 17
        Me.btnAceptar.Text = "Aceptar"
        Me.btnAceptar.UseVisualStyleBackColor = True
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(350, 59)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(109, 13)
        Me.Label10.TabIndex = 18
        Me.Label10.Text = "Fecha de nacimiento:"
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Location = New System.Drawing.Point(350, 258)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(64, 13)
        Me.Label11.TabIndex = 19
        Me.Label11.Text = "Contraseña:"
        '
        'txtContraseña
        '
        Me.txtContraseña.Location = New System.Drawing.Point(353, 277)
        Me.txtContraseña.Name = "txtContraseña"
        Me.txtContraseña.Size = New System.Drawing.Size(192, 20)
        Me.txtContraseña.TabIndex = 21
        '
        'mthFecha
        '
        Me.mthFecha.Location = New System.Drawing.Point(353, 75)
        Me.mthFecha.Name = "mthFecha"
        Me.mthFecha.ShowToday = False
        Me.mthFecha.ShowTodayCircle = False
        Me.mthFecha.TabIndex = 23
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Location = New System.Drawing.Point(350, 305)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(110, 13)
        Me.Label12.TabIndex = 24
        Me.Label12.Text = "Confirmar contraseña:"
        '
        'txtConfContraseña
        '
        Me.txtConfContraseña.Location = New System.Drawing.Point(353, 321)
        Me.txtConfContraseña.Name = "txtConfContraseña"
        Me.txtConfContraseña.Size = New System.Drawing.Size(192, 20)
        Me.txtConfContraseña.TabIndex = 25
        '
        'rbtnMedico
        '
        Me.rbtnMedico.AutoSize = True
        Me.rbtnMedico.Location = New System.Drawing.Point(353, 368)
        Me.rbtnMedico.Name = "rbtnMedico"
        Me.rbtnMedico.Size = New System.Drawing.Size(60, 17)
        Me.rbtnMedico.TabIndex = 26
        Me.rbtnMedico.TabStop = True
        Me.rbtnMedico.Text = "Medico"
        Me.rbtnMedico.UseVisualStyleBackColor = True
        '
        'rbtnGestor
        '
        Me.rbtnGestor.AutoSize = True
        Me.rbtnGestor.Location = New System.Drawing.Point(353, 392)
        Me.rbtnGestor.Name = "rbtnGestor"
        Me.rbtnGestor.Size = New System.Drawing.Size(56, 17)
        Me.rbtnGestor.TabIndex = 27
        Me.rbtnGestor.TabStop = True
        Me.rbtnGestor.Text = "Gestor"
        Me.rbtnGestor.UseVisualStyleBackColor = True
        '
        'txtEmpresa
        '
        Me.txtEmpresa.Location = New System.Drawing.Point(18, 344)
        Me.txtEmpresa.Name = "txtEmpresa"
        Me.txtEmpresa.Size = New System.Drawing.Size(218, 20)
        Me.txtEmpresa.TabIndex = 29
        '
        'AgrUsuario
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
        Me.Name = "AgrUsuario"
        Me.Text = "Registro"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents txtID As TextBox
    Friend WithEvents txtNombre As TextBox
    Friend WithEvents txtApellido As TextBox
    Friend WithEvents txtCI As TextBox
    Friend WithEvents txtTelefono As TextBox
    Friend WithEvents txtDireccion As TextBox
    Friend WithEvents txtEspecializacion As TextBox
    Friend WithEvents txtEMail As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents lblInfo As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents btnAceptar As Button
    Friend WithEvents Label10 As Label
    Friend WithEvents Label11 As Label
    Friend WithEvents txtContraseña As TextBox
    Friend WithEvents mthFecha As MonthCalendar
    Friend WithEvents Label12 As Label
    Friend WithEvents txtConfContraseña As TextBox
    Friend WithEvents rbtnMedico As RadioButton
    Friend WithEvents rbtnGestor As RadioButton
    Friend WithEvents txtEmpresa As TextBox
End Class
