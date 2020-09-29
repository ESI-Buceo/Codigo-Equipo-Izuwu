<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class RegistroNew
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(RegistroNew))
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        Me.btnRegis = New System.Windows.Forms.Button()
        Me.txtNombreRegis = New System.Windows.Forms.TextBox()
        Me.txtTelRegis = New System.Windows.Forms.TextBox()
        Me.txtContraseñaRegis = New System.Windows.Forms.TextBox()
        Me.txtCCRegis = New System.Windows.Forms.TextBox()
        Me.txtApellidoRegis = New System.Windows.Forms.TextBox()
        Me.txtCIRegis = New System.Windows.Forms.TextBox()
        Me.txtDireccionRegis = New System.Windows.Forms.TextBox()
        Me.txtCorreoRegis = New System.Windows.Forms.TextBox()
        Me.cbSexoRegis = New System.Windows.Forms.ComboBox()
        Me.nudEdadRegis = New System.Windows.Forms.NumericUpDown()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.Panel1.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.nudEdadRegis, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.FromArgb(CType(CType(40, Byte), Integer), CType(CType(117, Byte), Integer), CType(CType(207, Byte), Integer))
        Me.Panel1.Controls.Add(Me.Label13)
        Me.Panel1.Controls.Add(Me.Label12)
        Me.Panel1.Controls.Add(Me.Label11)
        Me.Panel1.Controls.Add(Me.btnRegis)
        Me.Panel1.Controls.Add(Me.PictureBox1)
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(284, 648)
        Me.Panel1.TabIndex = 1
        '
        'Button2
        '
        Me.Button2.BackColor = System.Drawing.Color.White
        Me.Button2.FlatAppearance.BorderSize = 0
        Me.Button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button2.Font = New System.Drawing.Font("Consolas", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button2.ForeColor = System.Drawing.Color.Black
        Me.Button2.Location = New System.Drawing.Point(891, 1)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(41, 26)
        Me.Button2.TabIndex = 8
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
        Me.Button1.Location = New System.Drawing.Point(938, 1)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(41, 26)
        Me.Button1.TabIndex = 7
        Me.Button1.Text = "X"
        Me.Button1.UseVisualStyleBackColor = False
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(0, 177)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(284, 289)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 0
        Me.PictureBox1.TabStop = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(337, 87)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(83, 22)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Nombre: "
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(338, 157)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(56, 22)
        Me.Label2.TabIndex = 9
        Me.Label2.Text = "Sexo:"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(337, 218)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(57, 22)
        Me.Label3.TabIndex = 10
        Me.Label3.Text = "Edad:"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(337, 283)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(86, 22)
        Me.Label4.TabIndex = 11
        Me.Label4.Text = "Telefono:"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(315, 365)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(108, 22)
        Me.Label5.TabIndex = 12
        Me.Label5.Text = "Contraseña:"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(315, 444)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(191, 22)
        Me.Label6.TabIndex = 13
        Me.Label6.Text = "Confirmar Contraseña:"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(652, 87)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(79, 22)
        Me.Label7.TabIndex = 14
        Me.Label7.Text = "Apellido:"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(669, 155)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(37, 22)
        Me.Label8.TabIndex = 15
        Me.Label8.Text = "C.I:"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.Location = New System.Drawing.Point(641, 218)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(90, 22)
        Me.Label9.TabIndex = 16
        Me.Label9.Text = "Direccion:"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.Location = New System.Drawing.Point(661, 283)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(70, 22)
        Me.Label10.TabIndex = 17
        Me.Label10.Text = "Correo:"
        '
        'PictureBox2
        '
        Me.PictureBox2.Image = CType(resources.GetObject("PictureBox2.Image"), System.Drawing.Image)
        Me.PictureBox2.Location = New System.Drawing.Point(645, 339)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(334, 309)
        Me.PictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox2.TabIndex = 18
        Me.PictureBox2.TabStop = False
        '
        'btnRegis
        '
        Me.btnRegis.BackColor = System.Drawing.Color.FromArgb(CType(CType(24, Byte), Integer), CType(CType(69, Byte), Integer), CType(CType(122, Byte), Integer))
        Me.btnRegis.FlatAppearance.BorderColor = System.Drawing.Color.White
        Me.btnRegis.FlatAppearance.BorderSize = 0
        Me.btnRegis.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnRegis.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.btnRegis.Location = New System.Drawing.Point(84, 283)
        Me.btnRegis.Name = "btnRegis"
        Me.btnRegis.Size = New System.Drawing.Size(92, 28)
        Me.btnRegis.TabIndex = 19
        Me.btnRegis.Text = "Registrarse"
        Me.btnRegis.UseVisualStyleBackColor = False
        '
        'txtNombreRegis
        '
        Me.txtNombreRegis.Location = New System.Drawing.Point(426, 89)
        Me.txtNombreRegis.Name = "txtNombreRegis"
        Me.txtNombreRegis.Size = New System.Drawing.Size(130, 20)
        Me.txtNombreRegis.TabIndex = 19
        '
        'txtTelRegis
        '
        Me.txtTelRegis.Location = New System.Drawing.Point(426, 285)
        Me.txtTelRegis.Name = "txtTelRegis"
        Me.txtTelRegis.Size = New System.Drawing.Size(130, 20)
        Me.txtTelRegis.TabIndex = 20
        '
        'txtContraseñaRegis
        '
        Me.txtContraseñaRegis.Location = New System.Drawing.Point(429, 367)
        Me.txtContraseñaRegis.Name = "txtContraseñaRegis"
        Me.txtContraseñaRegis.Size = New System.Drawing.Size(130, 20)
        Me.txtContraseñaRegis.TabIndex = 21
        '
        'txtCCRegis
        '
        Me.txtCCRegis.Location = New System.Drawing.Point(512, 446)
        Me.txtCCRegis.Name = "txtCCRegis"
        Me.txtCCRegis.Size = New System.Drawing.Size(130, 20)
        Me.txtCCRegis.TabIndex = 22
        '
        'txtApellidoRegis
        '
        Me.txtApellidoRegis.Location = New System.Drawing.Point(737, 89)
        Me.txtApellidoRegis.Name = "txtApellidoRegis"
        Me.txtApellidoRegis.Size = New System.Drawing.Size(130, 20)
        Me.txtApellidoRegis.TabIndex = 23
        '
        'txtCIRegis
        '
        Me.txtCIRegis.Location = New System.Drawing.Point(737, 155)
        Me.txtCIRegis.MaxLength = 8
        Me.txtCIRegis.Name = "txtCIRegis"
        Me.txtCIRegis.Size = New System.Drawing.Size(130, 20)
        Me.txtCIRegis.TabIndex = 24
        '
        'txtDireccionRegis
        '
        Me.txtDireccionRegis.Location = New System.Drawing.Point(737, 220)
        Me.txtDireccionRegis.Name = "txtDireccionRegis"
        Me.txtDireccionRegis.Size = New System.Drawing.Size(130, 20)
        Me.txtDireccionRegis.TabIndex = 25
        '
        'txtCorreoRegis
        '
        Me.txtCorreoRegis.Location = New System.Drawing.Point(737, 288)
        Me.txtCorreoRegis.Name = "txtCorreoRegis"
        Me.txtCorreoRegis.Size = New System.Drawing.Size(130, 20)
        Me.txtCorreoRegis.TabIndex = 26
        '
        'cbSexoRegis
        '
        Me.cbSexoRegis.FormattingEnabled = True
        Me.cbSexoRegis.Location = New System.Drawing.Point(426, 157)
        Me.cbSexoRegis.Name = "cbSexoRegis"
        Me.cbSexoRegis.Size = New System.Drawing.Size(121, 21)
        Me.cbSexoRegis.TabIndex = 27
        '
        'nudEdadRegis
        '
        Me.nudEdadRegis.Location = New System.Drawing.Point(429, 221)
        Me.nudEdadRegis.Name = "nudEdadRegis"
        Me.nudEdadRegis.Size = New System.Drawing.Size(65, 20)
        Me.nudEdadRegis.TabIndex = 28
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Font = New System.Drawing.Font("Yu Gothic UI Semibold", 21.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.ForeColor = System.Drawing.Color.White
        Me.Label11.Location = New System.Drawing.Point(43, 69)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(185, 40)
        Me.Label11.TabIndex = 20
        Me.Label11.Text = "DiagnosTICK"
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label12.ForeColor = System.Drawing.Color.White
        Me.Label12.Location = New System.Drawing.Point(12, 614)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(111, 13)
        Me.Label12.TabIndex = 21
        Me.Label12.Text = "Politicas de privacidad"
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Font = New System.Drawing.Font("Yu Gothic UI", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label13.Location = New System.Drawing.Point(3, 2)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(31, 25)
        Me.Label13.TabIndex = 22
        Me.Label13.Text = "←"
        '
        'RegistroNew
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(980, 645)
        Me.Controls.Add(Me.nudEdadRegis)
        Me.Controls.Add(Me.cbSexoRegis)
        Me.Controls.Add(Me.txtCorreoRegis)
        Me.Controls.Add(Me.txtDireccionRegis)
        Me.Controls.Add(Me.txtCIRegis)
        Me.Controls.Add(Me.txtApellidoRegis)
        Me.Controls.Add(Me.txtCCRegis)
        Me.Controls.Add(Me.txtContraseñaRegis)
        Me.Controls.Add(Me.txtTelRegis)
        Me.Controls.Add(Me.txtNombreRegis)
        Me.Controls.Add(Me.PictureBox2)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.Panel1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.MaximumSize = New System.Drawing.Size(980, 645)
        Me.MinimumSize = New System.Drawing.Size(980, 645)
        Me.Name = "RegistroNew"
        Me.Text = "RegistroNew"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.nudEdadRegis, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Panel1 As Panel
    Friend WithEvents Button2 As Button
    Friend WithEvents Button1 As Button
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents Label10 As Label
    Friend WithEvents PictureBox2 As PictureBox
    Friend WithEvents btnRegis As Button
    Friend WithEvents txtNombreRegis As TextBox
    Friend WithEvents txtTelRegis As TextBox
    Friend WithEvents txtContraseñaRegis As TextBox
    Friend WithEvents txtCCRegis As TextBox
    Friend WithEvents txtApellidoRegis As TextBox
    Friend WithEvents txtCIRegis As TextBox
    Friend WithEvents txtDireccionRegis As TextBox
    Friend WithEvents txtCorreoRegis As TextBox
    Friend WithEvents cbSexoRegis As ComboBox
    Friend WithEvents nudEdadRegis As NumericUpDown
    Friend WithEvents Label11 As Label
    Friend WithEvents Label12 As Label
    Friend WithEvents Label13 As Label
End Class
