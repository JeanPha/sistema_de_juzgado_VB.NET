<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmIdExpediente
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
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.txtExpediente = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.btnImprimirExpediente = New System.Windows.Forms.Button()
        Me.Panel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.txtExpediente)
        Me.Panel1.Controls.Add(Me.Label1)
        Me.Panel1.Controls.Add(Me.btnImprimirExpediente)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(416, 159)
        Me.Panel1.TabIndex = 0
        '
        'txtExpediente
        '
        Me.txtExpediente.Location = New System.Drawing.Point(59, 80)
        Me.txtExpediente.Name = "txtExpediente"
        Me.txtExpediente.Size = New System.Drawing.Size(148, 26)
        Me.txtExpediente.TabIndex = 4
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.Navy
        Me.Label1.Location = New System.Drawing.Point(55, 40)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(265, 22)
        Me.Label1.TabIndex = 5
        Me.Label1.Text = "Ingrese el nro de expediente"
        '
        'btnImprimirExpediente
        '
        Me.btnImprimirExpediente.ForeColor = System.Drawing.Color.Navy
        Me.btnImprimirExpediente.Location = New System.Drawing.Point(213, 72)
        Me.btnImprimirExpediente.Name = "btnImprimirExpediente"
        Me.btnImprimirExpediente.Size = New System.Drawing.Size(107, 43)
        Me.btnImprimirExpediente.TabIndex = 6
        Me.btnImprimirExpediente.Text = "Imprimir"
        Me.btnImprimirExpediente.UseVisualStyleBackColor = True
        '
        'frmIdExpediente
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(416, 159)
        Me.Controls.Add(Me.Panel1)
        Me.Name = "frmIdExpediente"
        Me.Text = "frmIdExpediente"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Panel1 As Panel
    Friend WithEvents txtExpediente As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents btnImprimirExpediente As Button
End Class
