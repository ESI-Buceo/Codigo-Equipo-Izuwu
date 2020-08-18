<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class MenuPaciente
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
        Me.btnDiagnostico = New System.Windows.Forms.Button()
        Me.Historial = New System.Windows.Forms.Button()
        Me.Chat = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'btnDiagnostico
        '
        Me.btnDiagnostico.Location = New System.Drawing.Point(56, 61)
        Me.btnDiagnostico.Name = "btnDiagnostico"
        Me.btnDiagnostico.Size = New System.Drawing.Size(75, 23)
        Me.btnDiagnostico.TabIndex = 0
        Me.btnDiagnostico.Text = "Diagnóstico"
        Me.btnDiagnostico.UseVisualStyleBackColor = True
        '
        'Historial
        '
        Me.Historial.Location = New System.Drawing.Point(56, 159)
        Me.Historial.Name = "Historial"
        Me.Historial.Size = New System.Drawing.Size(75, 23)
        Me.Historial.TabIndex = 1
        Me.Historial.Text = "Historial"
        Me.Historial.UseVisualStyleBackColor = True
        '
        'Chat
        '
        Me.Chat.Location = New System.Drawing.Point(56, 262)
        Me.Chat.Name = "Chat"
        Me.Chat.Size = New System.Drawing.Size(75, 23)
        Me.Chat.TabIndex = 2
        Me.Chat.Text = "Chat"
        Me.Chat.UseVisualStyleBackColor = True
        '
        'MenuPaciente
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(200, 342)
        Me.Controls.Add(Me.Chat)
        Me.Controls.Add(Me.Historial)
        Me.Controls.Add(Me.btnDiagnostico)
        Me.Name = "MenuPaciente"
        Me.Text = "Frame2"
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents btnDiagnostico As Button
    Friend WithEvents Historial As Button
    Friend WithEvents Chat As Button
End Class
