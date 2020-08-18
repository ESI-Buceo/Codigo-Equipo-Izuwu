<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Login
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
        Me.btnIniciar = New System.Windows.Forms.Button()
        Me.txtCI = New System.Windows.Forms.TextBox()
        Me.txtContraseña = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.btnSalir = New System.Windows.Forms.Button()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.btnRegistro = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'btnIniciar
        '
        Me.btnIniciar.Location = New System.Drawing.Point(26, 234)
        Me.btnIniciar.Name = "btnIniciar"
        Me.btnIniciar.Size = New System.Drawing.Size(75, 29)
        Me.btnIniciar.TabIndex = 0
        Me.btnIniciar.Text = "Iniciar"
        Me.btnIniciar.UseVisualStyleBackColor = True
        '
        'txtCI
        '
        Me.txtCI.Location = New System.Drawing.Point(26, 113)
        Me.txtCI.Name = "txtCI"
        Me.txtCI.Size = New System.Drawing.Size(144, 20)
        Me.txtCI.TabIndex = 1
        '
        'txtContraseña
        '
        Me.txtContraseña.Location = New System.Drawing.Point(26, 187)
        Me.txtContraseña.Name = "txtContraseña"
        Me.txtContraseña.PasswordChar = Global.Microsoft.VisualBasic.ChrW(8226)
        Me.txtContraseña.Size = New System.Drawing.Size(144, 20)
        Me.txtContraseña.TabIndex = 2
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(23, 97)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(68, 13)
        Me.Label1.TabIndex = 3
        Me.Label1.Text = "Usuario (C.I.)"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(23, 171)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(61, 13)
        Me.Label2.TabIndex = 4
        Me.Label2.Text = "Contraseña"
        '
        'btnSalir
        '
        Me.btnSalir.Location = New System.Drawing.Point(16, 402)
        Me.btnSalir.Name = "btnSalir"
        Me.btnSalir.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.btnSalir.Size = New System.Drawing.Size(85, 36)
        Me.btnSalir.TabIndex = 5
        Me.btnSalir.Text = "Salir"
        Me.btnSalir.UseVisualStyleBackColor = True
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(23, 22)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(168, 29)
        Me.Label3.TabIndex = 6
        Me.Label3.Text = "DiagnosTICK"
        '
        'btnRegistro
        '
        Me.btnRegistro.Location = New System.Drawing.Point(16, 351)
        Me.btnRegistro.Name = "btnRegistro"
        Me.btnRegistro.Size = New System.Drawing.Size(83, 29)
        Me.btnRegistro.TabIndex = 7
        Me.btnRegistro.Text = "Registrarse"
        Me.btnRegistro.UseVisualStyleBackColor = True
        '
        'Form1Paciente
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.btnRegistro)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.btnSalir)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.txtContraseña)
        Me.Controls.Add(Me.txtCI)
        Me.Controls.Add(Me.btnIniciar)
        Me.Name = "Form1Paciente"
        Me.Text = "Frame1"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents btnIniciar As Button
    Friend WithEvents txtCI As TextBox
    Friend WithEvents txtContraseña As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents btnSalir As Button
    Friend WithEvents Label3 As Label
    Friend WithEvents btnRegistro As Button
End Class
