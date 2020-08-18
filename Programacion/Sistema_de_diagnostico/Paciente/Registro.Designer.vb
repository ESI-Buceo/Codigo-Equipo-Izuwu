<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Registro
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
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txtNombre = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txtApellido = New System.Windows.Forms.TextBox()
        Me.txtCI = New System.Windows.Forms.TextBox()
        Me.txtTelefono = New System.Windows.Forms.TextBox()
        Me.txtDireccion = New System.Windows.Forms.TextBox()
        Me.txtCorreo = New System.Windows.Forms.TextBox()
        Me.txtContraseña = New System.Windows.Forms.TextBox()
        Me.txtConfContraseña = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.btnRegistro = New System.Windows.Forms.Button()
        Me.mthFecha = New System.Windows.Forms.MonthCalendar()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(13, 13)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(100, 25)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Registro"
        '
        'txtNombre
        '
        Me.txtNombre.Location = New System.Drawing.Point(60, 75)
        Me.txtNombre.Name = "txtNombre"
        Me.txtNombre.Size = New System.Drawing.Size(136, 20)
        Me.txtNombre.TabIndex = 1
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(15, 75)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(44, 13)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "Nombre"
        '
        'txtApellido
        '
        Me.txtApellido.Location = New System.Drawing.Point(60, 113)
        Me.txtApellido.Name = "txtApellido"
        Me.txtApellido.Size = New System.Drawing.Size(136, 20)
        Me.txtApellido.TabIndex = 3
        '
        'txtCI
        '
        Me.txtCI.Location = New System.Drawing.Point(60, 150)
        Me.txtCI.Name = "txtCI"
        Me.txtCI.Size = New System.Drawing.Size(136, 20)
        Me.txtCI.TabIndex = 5
        '
        'txtTelefono
        '
        Me.txtTelefono.Location = New System.Drawing.Point(60, 192)
        Me.txtTelefono.Name = "txtTelefono"
        Me.txtTelefono.Size = New System.Drawing.Size(136, 20)
        Me.txtTelefono.TabIndex = 7
        '
        'txtDireccion
        '
        Me.txtDireccion.Location = New System.Drawing.Point(60, 232)
        Me.txtDireccion.Name = "txtDireccion"
        Me.txtDireccion.Size = New System.Drawing.Size(136, 20)
        Me.txtDireccion.TabIndex = 8
        '
        'txtCorreo
        '
        Me.txtCorreo.Location = New System.Drawing.Point(8, 285)
        Me.txtCorreo.Name = "txtCorreo"
        Me.txtCorreo.Size = New System.Drawing.Size(199, 20)
        Me.txtCorreo.TabIndex = 9
        '
        'txtContraseña
        '
        Me.txtContraseña.Location = New System.Drawing.Point(344, 268)
        Me.txtContraseña.Name = "txtContraseña"
        Me.txtContraseña.Size = New System.Drawing.Size(166, 20)
        Me.txtContraseña.TabIndex = 10
        '
        'txtConfContraseña
        '
        Me.txtConfContraseña.Location = New System.Drawing.Point(344, 303)
        Me.txtConfContraseña.Name = "txtConfContraseña"
        Me.txtConfContraseña.Size = New System.Drawing.Size(166, 20)
        Me.txtConfContraseña.TabIndex = 11
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(10, 113)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(44, 13)
        Me.Label4.TabIndex = 13
        Me.Label4.Text = "Apellido"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(13, 153)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(26, 13)
        Me.Label6.TabIndex = 15
        Me.Label6.Text = "C. I."
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(5, 192)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(49, 13)
        Me.Label7.TabIndex = 16
        Me.Label7.Text = "Telefono"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(7, 232)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(52, 13)
        Me.Label8.TabIndex = 17
        Me.Label8.Text = "Direccion"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(5, 269)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(76, 13)
        Me.Label9.TabIndex = 18
        Me.Label9.Text = "Correo (E-Mail)"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(277, 271)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(61, 13)
        Me.Label10.TabIndex = 19
        Me.Label10.Text = "Contraseña"
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Location = New System.Drawing.Point(230, 303)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(108, 13)
        Me.Label11.TabIndex = 20
        Me.Label11.Text = "Confirmar Contraseña"
        '
        'btnRegistro
        '
        Me.btnRegistro.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnRegistro.Location = New System.Drawing.Point(497, 341)
        Me.btnRegistro.Name = "btnRegistro"
        Me.btnRegistro.Size = New System.Drawing.Size(110, 33)
        Me.btnRegistro.TabIndex = 21
        Me.btnRegistro.Text = "Registrar"
        Me.btnRegistro.UseVisualStyleBackColor = True
        '
        'mthFecha
        '
        Me.mthFecha.Location = New System.Drawing.Point(291, 62)
        Me.mthFecha.Name = "mthFecha"
        Me.mthFecha.TabIndex = 22
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(288, 40)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(106, 13)
        Me.Label5.TabIndex = 23
        Me.Label5.Text = "Fecha de nacimiento"
        '
        'Registro
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(620, 388)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.mthFecha)
        Me.Controls.Add(Me.btnRegistro)
        Me.Controls.Add(Me.Label11)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.txtConfContraseña)
        Me.Controls.Add(Me.txtContraseña)
        Me.Controls.Add(Me.txtCorreo)
        Me.Controls.Add(Me.txtDireccion)
        Me.Controls.Add(Me.txtTelefono)
        Me.Controls.Add(Me.txtCI)
        Me.Controls.Add(Me.txtApellido)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.txtNombre)
        Me.Controls.Add(Me.Label1)
        Me.Name = "Registro"
        Me.Text = "Form1"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents txtNombre As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents txtApellido As TextBox
    Friend WithEvents txtCI As TextBox
    Friend WithEvents txtTelefono As TextBox
    Friend WithEvents txtDireccion As TextBox
    Friend WithEvents txtCorreo As TextBox
    Friend WithEvents txtContraseña As TextBox
    Friend WithEvents txtConfContraseña As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents Label10 As Label
    Friend WithEvents Label11 As Label
    Friend WithEvents btnRegistro As Button
    Friend WithEvents mthFecha As MonthCalendar
    Friend WithEvents Label5 As Label
End Class
