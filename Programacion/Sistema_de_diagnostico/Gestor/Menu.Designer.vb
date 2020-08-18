<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Menu
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
        Me.btnAgregarUs = New System.Windows.Forms.Button()
        Me.btnABMPatologia = New System.Windows.Forms.Button()
        Me.btnModificarUs = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'btnAgregarUs
        '
        Me.btnAgregarUs.Location = New System.Drawing.Point(46, 63)
        Me.btnAgregarUs.Name = "btnAgregarUs"
        Me.btnAgregarUs.Size = New System.Drawing.Size(143, 40)
        Me.btnAgregarUs.TabIndex = 0
        Me.btnAgregarUs.Text = "Agregar usuario (medico/gestor)"
        Me.btnAgregarUs.UseVisualStyleBackColor = True
        '
        'btnABMPatologia
        '
        Me.btnABMPatologia.Location = New System.Drawing.Point(46, 160)
        Me.btnABMPatologia.Name = "btnABMPatologia"
        Me.btnABMPatologia.Size = New System.Drawing.Size(143, 45)
        Me.btnABMPatologia.TabIndex = 1
        Me.btnABMPatologia.Text = "Agregar / Modificar (Patologia o Sintoma)"
        Me.btnABMPatologia.UseVisualStyleBackColor = True
        '
        'btnModificarUs
        '
        Me.btnModificarUs.Location = New System.Drawing.Point(46, 262)
        Me.btnModificarUs.Name = "btnModificarUs"
        Me.btnModificarUs.Size = New System.Drawing.Size(143, 23)
        Me.btnModificarUs.TabIndex = 2
        Me.btnModificarUs.Text = "Modificar (Usuario)"
        Me.btnModificarUs.UseVisualStyleBackColor = True
        '
        'Menu
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(242, 374)
        Me.Controls.Add(Me.btnModificarUs)
        Me.Controls.Add(Me.btnABMPatologia)
        Me.Controls.Add(Me.btnAgregarUs)
        Me.Name = "Menu"
        Me.Text = "Form1"
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents btnAgregarUs As Button
    Friend WithEvents btnABMPatologia As Button
    Friend WithEvents btnModificarUs As Button
End Class
