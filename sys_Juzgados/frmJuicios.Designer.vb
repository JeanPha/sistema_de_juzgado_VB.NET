<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmJuicios
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
        Me.lbCodigo = New System.Windows.Forms.Label()
        Me.lbDescripcion = New System.Windows.Forms.Label()
        Me.btnListo = New System.Windows.Forms.Button()
        Me.txtCodigo = New System.Windows.Forms.TextBox()
        Me.txtDescripcion = New System.Windows.Forms.TextBox()
        Me.dgvJuicios = New System.Windows.Forms.DataGridView()
        Me.Panel5 = New System.Windows.Forms.Panel()
        Me.Panel4 = New System.Windows.Forms.Panel()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.btnNuevo = New System.Windows.Forms.PictureBox()
        Me.btnModificar = New System.Windows.Forms.PictureBox()
        Me.btnEliminar = New System.Windows.Forms.PictureBox()
        CType(Me.dgvJuicios, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel5.SuspendLayout()
        Me.Panel4.SuspendLayout()
        Me.Panel3.SuspendLayout()
        CType(Me.btnNuevo, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.btnModificar, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.btnEliminar, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'lbCodigo
        '
        Me.lbCodigo.AutoSize = True
        Me.lbCodigo.ForeColor = System.Drawing.Color.Navy
        Me.lbCodigo.Location = New System.Drawing.Point(35, 23)
        Me.lbCodigo.Name = "lbCodigo"
        Me.lbCodigo.Size = New System.Drawing.Size(74, 20)
        Me.lbCodigo.TabIndex = 22
        Me.lbCodigo.Text = "CODIGO"
        '
        'lbDescripcion
        '
        Me.lbDescripcion.AutoSize = True
        Me.lbDescripcion.ForeColor = System.Drawing.Color.Navy
        Me.lbDescripcion.Location = New System.Drawing.Point(35, 66)
        Me.lbDescripcion.Name = "lbDescripcion"
        Me.lbDescripcion.Size = New System.Drawing.Size(120, 20)
        Me.lbDescripcion.TabIndex = 23
        Me.lbDescripcion.Text = "DESCRIPCION"
        '
        'btnListo
        '
        Me.btnListo.ForeColor = System.Drawing.Color.Navy
        Me.btnListo.Location = New System.Drawing.Point(7, 269)
        Me.btnListo.Name = "btnListo"
        Me.btnListo.Size = New System.Drawing.Size(108, 62)
        Me.btnListo.TabIndex = 21
        Me.btnListo.Text = "LISTO"
        Me.btnListo.UseVisualStyleBackColor = True
        '
        'txtCodigo
        '
        Me.txtCodigo.Enabled = False
        Me.txtCodigo.Location = New System.Drawing.Point(187, 17)
        Me.txtCodigo.Name = "txtCodigo"
        Me.txtCodigo.Size = New System.Drawing.Size(171, 26)
        Me.txtCodigo.TabIndex = 19
        '
        'txtDescripcion
        '
        Me.txtDescripcion.Enabled = False
        Me.txtDescripcion.Location = New System.Drawing.Point(187, 63)
        Me.txtDescripcion.Name = "txtDescripcion"
        Me.txtDescripcion.Size = New System.Drawing.Size(475, 26)
        Me.txtDescripcion.TabIndex = 20
        '
        'dgvJuicios
        '
        Me.dgvJuicios.AllowUserToAddRows = False
        Me.dgvJuicios.AllowUserToDeleteRows = False
        Me.dgvJuicios.AllowUserToResizeColumns = False
        Me.dgvJuicios.AllowUserToResizeRows = False
        Me.dgvJuicios.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.dgvJuicios.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvJuicios.Dock = System.Windows.Forms.DockStyle.Fill
        Me.dgvJuicios.Location = New System.Drawing.Point(0, 0)
        Me.dgvJuicios.Name = "dgvJuicios"
        Me.dgvJuicios.ReadOnly = True
        Me.dgvJuicios.RowHeadersWidth = 62
        Me.dgvJuicios.RowTemplate.Height = 28
        Me.dgvJuicios.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgvJuicios.Size = New System.Drawing.Size(865, 379)
        Me.dgvJuicios.TabIndex = 37
        '
        'Panel5
        '
        Me.Panel5.Controls.Add(Me.dgvJuicios)
        Me.Panel5.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel5.Location = New System.Drawing.Point(39, 44)
        Me.Panel5.Name = "Panel5"
        Me.Panel5.Size = New System.Drawing.Size(865, 379)
        Me.Panel5.TabIndex = 47
        '
        'Panel4
        '
        Me.Panel4.Controls.Add(Me.btnNuevo)
        Me.Panel4.Controls.Add(Me.btnModificar)
        Me.Panel4.Controls.Add(Me.btnEliminar)
        Me.Panel4.Controls.Add(Me.btnListo)
        Me.Panel4.Dock = System.Windows.Forms.DockStyle.Right
        Me.Panel4.Location = New System.Drawing.Point(904, 44)
        Me.Panel4.Name = "Panel4"
        Me.Panel4.Size = New System.Drawing.Size(127, 379)
        Me.Panel4.TabIndex = 46
        '
        'Panel3
        '
        Me.Panel3.Controls.Add(Me.lbCodigo)
        Me.Panel3.Controls.Add(Me.txtCodigo)
        Me.Panel3.Controls.Add(Me.lbDescripcion)
        Me.Panel3.Controls.Add(Me.txtDescripcion)
        Me.Panel3.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.Panel3.Location = New System.Drawing.Point(39, 423)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(992, 119)
        Me.Panel3.TabIndex = 45
        '
        'Panel2
        '
        Me.Panel2.Dock = System.Windows.Forms.DockStyle.Left
        Me.Panel2.Location = New System.Drawing.Point(0, 44)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(39, 498)
        Me.Panel2.TabIndex = 44
        '
        'Panel1
        '
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(1031, 44)
        Me.Panel1.TabIndex = 43
        '
        'btnNuevo
        '
        Me.btnNuevo.Image = Global.sys_Juzgados.My.Resources.Resources.plus
        Me.btnNuevo.Location = New System.Drawing.Point(16, 6)
        Me.btnNuevo.Name = "btnNuevo"
        Me.btnNuevo.Size = New System.Drawing.Size(95, 81)
        Me.btnNuevo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.btnNuevo.TabIndex = 24
        Me.btnNuevo.TabStop = False
        '
        'btnModificar
        '
        Me.btnModificar.Image = Global.sys_Juzgados.My.Resources.Resources.actualize_arrows_couple_in_circle
        Me.btnModificar.Location = New System.Drawing.Point(16, 93)
        Me.btnModificar.Name = "btnModificar"
        Me.btnModificar.Size = New System.Drawing.Size(95, 81)
        Me.btnModificar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.btnModificar.TabIndex = 26
        Me.btnModificar.TabStop = False
        '
        'btnEliminar
        '
        Me.btnEliminar.Image = Global.sys_Juzgados.My.Resources.Resources.rounded_remove_button
        Me.btnEliminar.Location = New System.Drawing.Point(16, 182)
        Me.btnEliminar.Name = "btnEliminar"
        Me.btnEliminar.Size = New System.Drawing.Size(95, 81)
        Me.btnEliminar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.btnEliminar.TabIndex = 25
        Me.btnEliminar.TabStop = False
        '
        'frmJuicios
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1031, 542)
        Me.Controls.Add(Me.Panel5)
        Me.Controls.Add(Me.Panel4)
        Me.Controls.Add(Me.Panel3)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.Panel1)
        Me.Name = "frmJuicios"
        Me.Text = "frmJuicios"
        CType(Me.dgvJuicios, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel5.ResumeLayout(False)
        Me.Panel4.ResumeLayout(False)
        Me.Panel3.ResumeLayout(False)
        Me.Panel3.PerformLayout()
        CType(Me.btnNuevo, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.btnModificar, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.btnEliminar, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents lbCodigo As Label
    Friend WithEvents lbDescripcion As Label
    Friend WithEvents btnListo As Button
    Friend WithEvents txtCodigo As TextBox
    Friend WithEvents txtDescripcion As TextBox
    Friend WithEvents btnNuevo As PictureBox
    Friend WithEvents btnModificar As PictureBox
    Friend WithEvents btnEliminar As PictureBox
    Friend WithEvents dgvJuicios As DataGridView
    Friend WithEvents Panel5 As Panel
    Friend WithEvents Panel4 As Panel
    Friend WithEvents Panel3 As Panel
    Friend WithEvents Panel2 As Panel
    Friend WithEvents Panel1 As Panel
End Class
