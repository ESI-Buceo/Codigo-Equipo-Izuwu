<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class ABMPatologiaSintomaGOLD
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
        Me.txtNsintoma = New System.Windows.Forms.TextBox()
        Me.txtNpatologia = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.btnAplicarModificarSintoma = New System.Windows.Forms.Button()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.btnGenerarIDSintoma = New System.Windows.Forms.Button()
        Me.chkListaRefPatologia = New System.Windows.Forms.CheckedListBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txtIDSin = New System.Windows.Forms.TextBox()
        Me.btnAgregarSintoma = New System.Windows.Forms.Button()
        Me.btnBorrarSintoma = New System.Windows.Forms.Button()
        Me.btnModSintoma = New System.Windows.Forms.Button()
        Me.lstSintoma = New System.Windows.Forms.ListBox()
        Me.nmbPrioridadPat = New System.Windows.Forms.NumericUpDown()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.btnAplicarModificarPatologia = New System.Windows.Forms.Button()
        Me.btnGenerarIDPat = New System.Windows.Forms.Button()
        Me.btnBorrarPatologia = New System.Windows.Forms.Button()
        Me.btnModificarPatologia = New System.Windows.Forms.Button()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.btnAgregarPatologia = New System.Windows.Forms.Button()
        Me.txtIDpat = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.lstPatologia = New System.Windows.Forms.ListBox()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.btnAyuda = New System.Windows.Forms.Button()
        Me.Panel1.SuspendLayout()
        CType(Me.nmbPrioridadPat, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel2.SuspendLayout()
        Me.SuspendLayout()
        '
        'txtNsintoma
        '
        Me.txtNsintoma.Location = New System.Drawing.Point(17, 53)
        Me.txtNsintoma.Name = "txtNsintoma"
        Me.txtNsintoma.Size = New System.Drawing.Size(160, 20)
        Me.txtNsintoma.TabIndex = 0
        '
        'txtNpatologia
        '
        Me.txtNpatologia.Location = New System.Drawing.Point(20, 56)
        Me.txtNpatologia.Name = "txtNpatologia"
        Me.txtNpatologia.Size = New System.Drawing.Size(115, 20)
        Me.txtNpatologia.TabIndex = 2
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(14, 37)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(47, 13)
        Me.Label2.TabIndex = 4
        Me.Label2.Text = "Nombre:"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(17, 40)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(47, 13)
        Me.Label3.TabIndex = 5
        Me.Label3.Text = "Nombre:"
        '
        'Panel1
        '
        Me.Panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Panel1.Controls.Add(Me.btnAplicarModificarSintoma)
        Me.Panel1.Controls.Add(Me.Label9)
        Me.Panel1.Controls.Add(Me.Label7)
        Me.Panel1.Controls.Add(Me.btnGenerarIDSintoma)
        Me.Panel1.Controls.Add(Me.chkListaRefPatologia)
        Me.Panel1.Controls.Add(Me.Label6)
        Me.Panel1.Controls.Add(Me.Label1)
        Me.Panel1.Controls.Add(Me.txtIDSin)
        Me.Panel1.Controls.Add(Me.btnAgregarSintoma)
        Me.Panel1.Controls.Add(Me.btnBorrarSintoma)
        Me.Panel1.Controls.Add(Me.btnModSintoma)
        Me.Panel1.Controls.Add(Me.lstSintoma)
        Me.Panel1.Controls.Add(Me.txtNsintoma)
        Me.Panel1.Controls.Add(Me.Label2)
        Me.Panel1.Location = New System.Drawing.Point(12, 12)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(696, 338)
        Me.Panel1.TabIndex = 6
        '
        'btnAplicarModificarSintoma
        '
        Me.btnAplicarModificarSintoma.Location = New System.Drawing.Point(177, 303)
        Me.btnAplicarModificarSintoma.Name = "btnAplicarModificarSintoma"
        Me.btnAplicarModificarSintoma.Size = New System.Drawing.Size(75, 23)
        Me.btnAplicarModificarSintoma.TabIndex = 21
        Me.btnAplicarModificarSintoma.Text = "Aplicar"
        Me.btnAplicarModificarSintoma.UseVisualStyleBackColor = True
        Me.btnAplicarModificarSintoma.Visible = False
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.Location = New System.Drawing.Point(451, 8)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(111, 13)
        Me.Label9.TabIndex = 20
        Me.Label9.Text = "Lista de Sintomas:"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(-2, 0)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(95, 24)
        Me.Label7.TabIndex = 19
        Me.Label7.Text = "Sintomas"
        '
        'btnGenerarIDSintoma
        '
        Me.btnGenerarIDSintoma.Location = New System.Drawing.Point(195, 104)
        Me.btnGenerarIDSintoma.Name = "btnGenerarIDSintoma"
        Me.btnGenerarIDSintoma.Size = New System.Drawing.Size(75, 23)
        Me.btnGenerarIDSintoma.TabIndex = 18
        Me.btnGenerarIDSintoma.Text = "Generar"
        Me.btnGenerarIDSintoma.UseVisualStyleBackColor = True
        '
        'chkListaRefPatologia
        '
        Me.chkListaRefPatologia.FormattingEnabled = True
        Me.chkListaRefPatologia.Location = New System.Drawing.Point(20, 162)
        Me.chkListaRefPatologia.Name = "chkListaRefPatologia"
        Me.chkListaRefPatologia.Size = New System.Drawing.Size(125, 169)
        Me.chkListaRefPatologia.TabIndex = 17
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(14, 146)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(128, 13)
        Me.Label6.TabIndex = 16
        Me.Label6.Text = "Perteneciente a patologia"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(14, 90)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(59, 13)
        Me.Label1.TabIndex = 14
        Me.Label1.Text = "ID Sintoma"
        '
        'txtIDSin
        '
        Me.txtIDSin.Location = New System.Drawing.Point(17, 106)
        Me.txtIDSin.Name = "txtIDSin"
        Me.txtIDSin.ReadOnly = True
        Me.txtIDSin.Size = New System.Drawing.Size(160, 20)
        Me.txtIDSin.TabIndex = 13
        '
        'btnAgregarSintoma
        '
        Me.btnAgregarSintoma.Location = New System.Drawing.Point(177, 303)
        Me.btnAgregarSintoma.Name = "btnAgregarSintoma"
        Me.btnAgregarSintoma.Size = New System.Drawing.Size(75, 23)
        Me.btnAgregarSintoma.TabIndex = 12
        Me.btnAgregarSintoma.Text = "Agregar"
        Me.btnAgregarSintoma.UseVisualStyleBackColor = True
        '
        'btnBorrarSintoma
        '
        Me.btnBorrarSintoma.Location = New System.Drawing.Point(362, 295)
        Me.btnBorrarSintoma.Name = "btnBorrarSintoma"
        Me.btnBorrarSintoma.Size = New System.Drawing.Size(75, 23)
        Me.btnBorrarSintoma.TabIndex = 11
        Me.btnBorrarSintoma.Text = "Borrar"
        Me.btnBorrarSintoma.UseVisualStyleBackColor = True
        '
        'btnModSintoma
        '
        Me.btnModSintoma.Location = New System.Drawing.Point(362, 234)
        Me.btnModSintoma.Name = "btnModSintoma"
        Me.btnModSintoma.Size = New System.Drawing.Size(75, 23)
        Me.btnModSintoma.TabIndex = 10
        Me.btnModSintoma.Text = "Modificar"
        Me.btnModSintoma.UseVisualStyleBackColor = True
        '
        'lstSintoma
        '
        Me.lstSintoma.FormattingEnabled = True
        Me.lstSintoma.Location = New System.Drawing.Point(454, 28)
        Me.lstSintoma.Name = "lstSintoma"
        Me.lstSintoma.Size = New System.Drawing.Size(217, 290)
        Me.lstSintoma.TabIndex = 8
        '
        'nmbPrioridadPat
        '
        Me.nmbPrioridadPat.Location = New System.Drawing.Point(177, 56)
        Me.nmbPrioridadPat.Maximum = New Decimal(New Integer() {5, 0, 0, 0})
        Me.nmbPrioridadPat.Name = "nmbPrioridadPat"
        Me.nmbPrioridadPat.Size = New System.Drawing.Size(48, 20)
        Me.nmbPrioridadPat.TabIndex = 7
        Me.nmbPrioridadPat.Value = New Decimal(New Integer() {1, 0, 0, 0})
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(174, 40)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(51, 13)
        Me.Label4.TabIndex = 6
        Me.Label4.Text = "Prioridad:"
        '
        'Panel2
        '
        Me.Panel2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Panel2.Controls.Add(Me.btnAplicarModificarPatologia)
        Me.Panel2.Controls.Add(Me.btnGenerarIDPat)
        Me.Panel2.Controls.Add(Me.btnBorrarPatologia)
        Me.Panel2.Controls.Add(Me.btnModificarPatologia)
        Me.Panel2.Controls.Add(Me.Label10)
        Me.Panel2.Controls.Add(Me.Label8)
        Me.Panel2.Controls.Add(Me.btnAgregarPatologia)
        Me.Panel2.Controls.Add(Me.txtIDpat)
        Me.Panel2.Controls.Add(Me.Label5)
        Me.Panel2.Controls.Add(Me.lstPatologia)
        Me.Panel2.Controls.Add(Me.Label3)
        Me.Panel2.Controls.Add(Me.txtNpatologia)
        Me.Panel2.Controls.Add(Me.nmbPrioridadPat)
        Me.Panel2.Controls.Add(Me.Label4)
        Me.Panel2.Location = New System.Drawing.Point(12, 369)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(696, 238)
        Me.Panel2.TabIndex = 7
        '
        'btnAplicarModificarPatologia
        '
        Me.btnAplicarModificarPatologia.Location = New System.Drawing.Point(23, 180)
        Me.btnAplicarModificarPatologia.Name = "btnAplicarModificarPatologia"
        Me.btnAplicarModificarPatologia.Size = New System.Drawing.Size(74, 23)
        Me.btnAplicarModificarPatologia.TabIndex = 20
        Me.btnAplicarModificarPatologia.Text = "Aplicar"
        Me.btnAplicarModificarPatologia.UseVisualStyleBackColor = True
        Me.btnAplicarModificarPatologia.Visible = False
        '
        'btnGenerarIDPat
        '
        Me.btnGenerarIDPat.Location = New System.Drawing.Point(159, 105)
        Me.btnGenerarIDPat.Name = "btnGenerarIDPat"
        Me.btnGenerarIDPat.Size = New System.Drawing.Size(75, 23)
        Me.btnGenerarIDPat.TabIndex = 19
        Me.btnGenerarIDPat.Text = "Generar"
        Me.btnGenerarIDPat.UseVisualStyleBackColor = True
        '
        'btnBorrarPatologia
        '
        Me.btnBorrarPatologia.Location = New System.Drawing.Point(362, 181)
        Me.btnBorrarPatologia.Name = "btnBorrarPatologia"
        Me.btnBorrarPatologia.Size = New System.Drawing.Size(75, 23)
        Me.btnBorrarPatologia.TabIndex = 15
        Me.btnBorrarPatologia.Text = "Borrar"
        Me.btnBorrarPatologia.UseVisualStyleBackColor = True
        '
        'btnModificarPatologia
        '
        Me.btnModificarPatologia.Location = New System.Drawing.Point(362, 130)
        Me.btnModificarPatologia.Name = "btnModificarPatologia"
        Me.btnModificarPatologia.Size = New System.Drawing.Size(75, 23)
        Me.btnModificarPatologia.TabIndex = 14
        Me.btnModificarPatologia.Text = "Modificar"
        Me.btnModificarPatologia.UseVisualStyleBackColor = True
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.Location = New System.Drawing.Point(451, 6)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(119, 13)
        Me.Label10.TabIndex = 13
        Me.Label10.Text = "Lista de Patologias:"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(-2, -2)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(106, 24)
        Me.Label8.TabIndex = 12
        Me.Label8.Text = "Patologias"
        '
        'btnAgregarPatologia
        '
        Me.btnAgregarPatologia.Location = New System.Drawing.Point(23, 181)
        Me.btnAgregarPatologia.Name = "btnAgregarPatologia"
        Me.btnAgregarPatologia.Size = New System.Drawing.Size(74, 22)
        Me.btnAgregarPatologia.TabIndex = 10
        Me.btnAgregarPatologia.Text = "Agregar"
        Me.btnAgregarPatologia.UseVisualStyleBackColor = True
        '
        'txtIDpat
        '
        Me.txtIDpat.Location = New System.Drawing.Point(20, 108)
        Me.txtIDpat.Name = "txtIDpat"
        Me.txtIDpat.ReadOnly = True
        Me.txtIDpat.Size = New System.Drawing.Size(115, 20)
        Me.txtIDpat.TabIndex = 10
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(17, 92)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(68, 13)
        Me.Label5.TabIndex = 11
        Me.Label5.Text = "ID Patologia:"
        '
        'lstPatologia
        '
        Me.lstPatologia.FormattingEnabled = True
        Me.lstPatologia.Location = New System.Drawing.Point(454, 27)
        Me.lstPatologia.Name = "lstPatologia"
        Me.lstPatologia.Size = New System.Drawing.Size(217, 199)
        Me.lstPatologia.TabIndex = 10
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(719, 584)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(75, 23)
        Me.Button1.TabIndex = 8
        Me.Button1.Text = "Salir"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'btnAyuda
        '
        Me.btnAyuda.Location = New System.Drawing.Point(719, 501)
        Me.btnAyuda.Name = "btnAyuda"
        Me.btnAyuda.Size = New System.Drawing.Size(75, 23)
        Me.btnAyuda.TabIndex = 9
        Me.btnAyuda.Text = "Ayuda"
        Me.btnAyuda.UseVisualStyleBackColor = True
        '
        'ABMPatologiaSintoma
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(806, 619)
        Me.Controls.Add(Me.btnAyuda)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.Panel1)
        Me.Name = "ABMPatologiaSintoma"
        Me.Text = "Form1"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        CType(Me.nmbPrioridadPat, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents txtNsintoma As TextBox
    Friend WithEvents txtNpatologia As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Panel1 As Panel
    Friend WithEvents Panel2 As Panel
    Friend WithEvents Label4 As Label
    Friend WithEvents nmbPrioridadPat As NumericUpDown
    Friend WithEvents lstSintoma As ListBox
    Friend WithEvents btnAgregarPatologia As Button
    Friend WithEvents txtIDpat As TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents lstPatologia As ListBox
    Friend WithEvents btnAgregarSintoma As Button
    Friend WithEvents btnBorrarSintoma As Button
    Friend WithEvents btnModSintoma As Button
    Friend WithEvents chkListaRefPatologia As CheckedListBox
    Friend WithEvents Label6 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents txtIDSin As TextBox
    Friend WithEvents btnGenerarIDSintoma As Button
    Friend WithEvents Label7 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents Button1 As Button
    Friend WithEvents btnAyuda As Button
    Friend WithEvents Label9 As Label
    Friend WithEvents Label10 As Label
    Friend WithEvents btnAplicarModificarSintoma As Button
    Friend WithEvents btnBorrarPatologia As Button
    Friend WithEvents btnModificarPatologia As Button
    Friend WithEvents btnGenerarIDPat As Button
    Friend WithEvents btnAplicarModificarPatologia As Button
End Class
