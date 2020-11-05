<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ABMSintoma
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
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txtNombre = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.chkListaPatologias = New System.Windows.Forms.CheckedListBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txtIDSintoma = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.btnCerrar = New Guna.UI2.WinForms.Guna2CircleButton()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.btnAceptar = New Guna.UI2.WinForms.Guna2Button()
        Me.Panel1.SuspendLayout()
        Me.Panel2.SuspendLayout()
        Me.SuspendLayout()
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Yu Gothic UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(1, 102)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(132, 17)
        Me.Label3.TabIndex = 3
        Me.Label3.Text = "Nombre del síntoma:"
        '
        'txtNombre
        '
        Me.txtNombre.Location = New System.Drawing.Point(139, 99)
        Me.txtNombre.Name = "txtNombre"
        Me.txtNombre.Size = New System.Drawing.Size(134, 20)
        Me.txtNombre.TabIndex = 4
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Yu Gothic UI", 19.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(64, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(171, 36)
        Me.Label1.TabIndex = 5
        Me.Label1.Text = "ABM Síntoma"
        '
        'chkListaPatologias
        '
        Me.chkListaPatologias.FormattingEnabled = True
        Me.chkListaPatologias.Location = New System.Drawing.Point(38, 173)
        Me.chkListaPatologias.Name = "chkListaPatologias"
        Me.chkListaPatologias.Size = New System.Drawing.Size(226, 199)
        Me.chkListaPatologias.TabIndex = 12
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Yu Gothic UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(5, 152)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(149, 17)
        Me.Label2.TabIndex = 13
        Me.Label2.Text = "Patología perteneciente:"
        '
        'txtIDSintoma
        '
        Me.txtIDSintoma.BackColor = System.Drawing.Color.White
        Me.txtIDSintoma.Location = New System.Drawing.Point(139, 61)
        Me.txtIDSintoma.Name = "txtIDSintoma"
        Me.txtIDSintoma.ReadOnly = True
        Me.txtIDSintoma.Size = New System.Drawing.Size(92, 20)
        Me.txtIDSintoma.TabIndex = 14
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Yu Gothic UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(110, 61)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(23, 17)
        Me.Label4.TabIndex = 15
        Me.Label4.Text = "ID:"
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.Black
        Me.Panel1.Controls.Add(Me.btnCerrar)
        Me.Panel1.Location = New System.Drawing.Point(0, 1)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(326, 30)
        Me.Panel1.TabIndex = 16
        '
        'btnCerrar
        '
        Me.btnCerrar.CheckedState.Parent = Me.btnCerrar
        Me.btnCerrar.CustomImages.Parent = Me.btnCerrar
        Me.btnCerrar.FillColor = System.Drawing.Color.White
        Me.btnCerrar.Font = New System.Drawing.Font("Segoe UI", 11.0!)
        Me.btnCerrar.ForeColor = System.Drawing.Color.Black
        Me.btnCerrar.HoverState.Parent = Me.btnCerrar
        Me.btnCerrar.Location = New System.Drawing.Point(291, 6)
        Me.btnCerrar.Name = "btnCerrar"
        Me.btnCerrar.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle
        Me.btnCerrar.ShadowDecoration.Parent = Me.btnCerrar
        Me.btnCerrar.Size = New System.Drawing.Size(23, 23)
        Me.btnCerrar.TabIndex = 17
        Me.btnCerrar.Text = "X"
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.Color.White
        Me.Panel2.Controls.Add(Me.btnAceptar)
        Me.Panel2.Controls.Add(Me.Label1)
        Me.Panel2.Controls.Add(Me.Label4)
        Me.Panel2.Controls.Add(Me.Label3)
        Me.Panel2.Controls.Add(Me.txtIDSintoma)
        Me.Panel2.Controls.Add(Me.txtNombre)
        Me.Panel2.Controls.Add(Me.Label2)
        Me.Panel2.Controls.Add(Me.chkListaPatologias)
        Me.Panel2.Location = New System.Drawing.Point(4, 32)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(319, 442)
        Me.Panel2.TabIndex = 17
        '
        'btnAceptar
        '
        Me.btnAceptar.Animated = True
        Me.btnAceptar.AutoRoundedCorners = True
        Me.btnAceptar.BorderRadius = 13
        Me.btnAceptar.CheckedState.Parent = Me.btnAceptar
        Me.btnAceptar.CustomImages.Parent = Me.btnAceptar
        Me.btnAceptar.FillColor = System.Drawing.Color.FromArgb(CType(CType(36, Byte), Integer), CType(CType(36, Byte), Integer), CType(CType(36, Byte), Integer))
        Me.btnAceptar.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.btnAceptar.ForeColor = System.Drawing.Color.White
        Me.btnAceptar.HoverState.Parent = Me.btnAceptar
        Me.btnAceptar.Location = New System.Drawing.Point(113, 394)
        Me.btnAceptar.Name = "btnAceptar"
        Me.btnAceptar.ShadowDecoration.Parent = Me.btnAceptar
        Me.btnAceptar.Size = New System.Drawing.Size(106, 28)
        Me.btnAceptar.TabIndex = 16
        Me.btnAceptar.Text = "Aceptar"
        '
        'ABMSintoma
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Black
        Me.ClientSize = New System.Drawing.Size(326, 478)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.Panel1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Location = New System.Drawing.Point(9, 212)
        Me.Name = "ABMSintoma"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "ABMSintoma"
        Me.Panel1.ResumeLayout(False)
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Label3 As Label
    Friend WithEvents txtNombre As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents chkListaPatologias As CheckedListBox
    Friend WithEvents Label2 As Label
    Friend WithEvents txtIDSintoma As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents Panel1 As Panel
    Friend WithEvents Panel2 As Panel
    Friend WithEvents btnAceptar As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents btnCerrar As Guna.UI2.WinForms.Guna2CircleButton
End Class
