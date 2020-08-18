<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Diagnostico
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
        Me.btnAgregar = New System.Windows.Forms.Button()
        Me.listSintoma = New System.Windows.Forms.ListBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.btnQuitar = New System.Windows.Forms.Button()
        Me.btnAceptar = New System.Windows.Forms.Button()
        Me.cbxSintoma = New System.Windows.Forms.ComboBox()
        Me.pnlListaSintoma = New System.Windows.Forms.Panel()
        Me.pnlDiagnostico = New System.Windows.Forms.Panel()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.labDiagnostico = New System.Windows.Forms.Label()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.pnlListaSintoma.SuspendLayout()
        Me.pnlDiagnostico.SuspendLayout()
        Me.SuspendLayout()
        '
        'btnAgregar
        '
        Me.btnAgregar.Location = New System.Drawing.Point(226, 184)
        Me.btnAgregar.Name = "btnAgregar"
        Me.btnAgregar.Size = New System.Drawing.Size(75, 23)
        Me.btnAgregar.TabIndex = 1
        Me.btnAgregar.Text = "Agregar"
        Me.btnAgregar.UseVisualStyleBackColor = True
        '
        'listSintoma
        '
        Me.listSintoma.FormattingEnabled = True
        Me.listSintoma.Location = New System.Drawing.Point(21, 22)
        Me.listSintoma.Name = "listSintoma"
        Me.listSintoma.Size = New System.Drawing.Size(215, 303)
        Me.listSintoma.TabIndex = 2
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(27, 166)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(129, 15)
        Me.Label2.TabIndex = 4
        Me.Label2.Text = "¿Cual es su malestar?"
        '
        'btnQuitar
        '
        Me.btnQuitar.Location = New System.Drawing.Point(52, 343)
        Me.btnQuitar.Name = "btnQuitar"
        Me.btnQuitar.Size = New System.Drawing.Size(75, 23)
        Me.btnQuitar.TabIndex = 5
        Me.btnQuitar.Text = "Quitar"
        Me.btnQuitar.UseVisualStyleBackColor = True
        '
        'btnAceptar
        '
        Me.btnAceptar.Font = New System.Drawing.Font("Arial Narrow", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnAceptar.Location = New System.Drawing.Point(76, 264)
        Me.btnAceptar.Name = "btnAceptar"
        Me.btnAceptar.Size = New System.Drawing.Size(120, 37)
        Me.btnAceptar.TabIndex = 6
        Me.btnAceptar.Text = "Aceptar"
        Me.btnAceptar.UseVisualStyleBackColor = True
        '
        'cbxSintoma
        '
        Me.cbxSintoma.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
        Me.cbxSintoma.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.cbxSintoma.FormattingEnabled = True
        Me.cbxSintoma.Location = New System.Drawing.Point(30, 184)
        Me.cbxSintoma.Name = "cbxSintoma"
        Me.cbxSintoma.Size = New System.Drawing.Size(190, 21)
        Me.cbxSintoma.TabIndex = 7
        '
        'pnlListaSintoma
        '
        Me.pnlListaSintoma.Controls.Add(Me.listSintoma)
        Me.pnlListaSintoma.Controls.Add(Me.btnQuitar)
        Me.pnlListaSintoma.Location = New System.Drawing.Point(326, 36)
        Me.pnlListaSintoma.Name = "pnlListaSintoma"
        Me.pnlListaSintoma.Size = New System.Drawing.Size(259, 380)
        Me.pnlListaSintoma.TabIndex = 8
        '
        'pnlDiagnostico
        '
        Me.pnlDiagnostico.Controls.Add(Me.Label1)
        Me.pnlDiagnostico.Controls.Add(Me.labDiagnostico)
        Me.pnlDiagnostico.Controls.Add(Me.Button2)
        Me.pnlDiagnostico.Controls.Add(Me.Button1)
        Me.pnlDiagnostico.Location = New System.Drawing.Point(326, 36)
        Me.pnlDiagnostico.Name = "pnlDiagnostico"
        Me.pnlDiagnostico.Size = New System.Drawing.Size(259, 277)
        Me.pnlDiagnostico.TabIndex = 9
        Me.pnlDiagnostico.Visible = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Underline), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(16, 22)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(207, 25)
        Me.Label1.TabIndex = 3
        Me.Label1.Text = "Su diagnostico es:"
        '
        'labDiagnostico
        '
        Me.labDiagnostico.AutoSize = True
        Me.labDiagnostico.BackColor = System.Drawing.SystemColors.Control
        Me.labDiagnostico.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.labDiagnostico.Location = New System.Drawing.Point(18, 69)
        Me.labDiagnostico.Name = "labDiagnostico"
        Me.labDiagnostico.Size = New System.Drawing.Size(0, 16)
        Me.labDiagnostico.TabIndex = 2
        '
        'Button2
        '
        Me.Button2.Location = New System.Drawing.Point(159, 205)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(77, 36)
        Me.Button2.TabIndex = 1
        Me.Button2.Text = "Aceptar Diagnostico"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(21, 205)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(80, 36)
        Me.Button1.TabIndex = 0
        Me.Button1.Text = "Consultar Medico"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Diagnostico
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(597, 450)
        Me.Controls.Add(Me.pnlDiagnostico)
        Me.Controls.Add(Me.pnlListaSintoma)
        Me.Controls.Add(Me.cbxSintoma)
        Me.Controls.Add(Me.btnAceptar)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.btnAgregar)
        Me.Name = "Diagnostico"
        Me.Text = "Diagnostico"
        Me.pnlListaSintoma.ResumeLayout(False)
        Me.pnlDiagnostico.ResumeLayout(False)
        Me.pnlDiagnostico.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents btnAgregar As Button
    Friend WithEvents listSintoma As ListBox
    Friend WithEvents Label2 As Label
    Friend WithEvents btnQuitar As Button
    Friend WithEvents btnAceptar As Button
    Friend WithEvents cbxSintoma As ComboBox
    Friend WithEvents pnlListaSintoma As Panel
    Friend WithEvents pnlDiagnostico As Panel
    Friend WithEvents labDiagnostico As Label
    Friend WithEvents Button2 As Button
    Friend WithEvents Button1 As Button
    Friend WithEvents Label1 As Label
End Class
