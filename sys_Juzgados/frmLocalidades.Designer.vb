<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmLocalidades
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
        Me.lbCp = New System.Windows.Forms.Label()
        Me.lbLocalidades = New System.Windows.Forms.Label()
        Me.btnListo = New System.Windows.Forms.Button()
        Me.txtLocalidad = New System.Windows.Forms.TextBox()
        Me.txtCp = New System.Windows.Forms.TextBox()
        Me.btnEliminar = New System.Windows.Forms.PictureBox()
        Me.btnModificar = New System.Windows.Forms.PictureBox()
        Me.btnNuevo = New System.Windows.Forms.PictureBox()
        Me.dgvLocalidades = New System.Windows.Forms.DataGridView()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.GroupBoxIngresar = New System.Windows.Forms.GroupBox()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Panel5 = New System.Windows.Forms.Panel()
        Me.Panel4 = New System.Windows.Forms.Panel()
        CType(Me.btnEliminar, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.btnModificar, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.btnNuevo, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dgvLocalidades, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel3.SuspendLayout()
        Me.GroupBoxIngresar.SuspendLayout()
        Me.Panel2.SuspendLayout()
        Me.Panel4.SuspendLayout()
        Me.SuspendLayout()
        '
        'lbCp
        '
        Me.lbCp.AutoSize = True
        Me.lbCp.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbCp.Location = New System.Drawing.Point(35, 55)
        Me.lbCp.Name = "lbCp"
        Me.lbCp.Size = New System.Drawing.Size(172, 22)
        Me.lbCp.TabIndex = 13
        Me.lbCp.Text = "CODIGO POSTAL"
        '
        'lbLocalidades
        '
        Me.lbLocalidades.AutoSize = True
        Me.lbLocalidades.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbLocalidades.Location = New System.Drawing.Point(35, 106)
        Me.lbLocalidades.Name = "lbLocalidades"
        Me.lbLocalidades.Size = New System.Drawing.Size(146, 22)
        Me.lbLocalidades.TabIndex = 14
        Me.lbLocalidades.Text = "LOCALIDADES"
        '
        'btnListo
        '
        Me.btnListo.ForeColor = System.Drawing.Color.Navy
        Me.btnListo.Location = New System.Drawing.Point(3, 331)
        Me.btnListo.Name = "btnListo"
        Me.btnListo.Size = New System.Drawing.Size(126, 62)
        Me.btnListo.TabIndex = 12
        Me.btnListo.Text = "LISTO"
        Me.btnListo.UseVisualStyleBackColor = True
        '
        'txtLocalidad
        '
        Me.txtLocalidad.Enabled = False
        Me.txtLocalidad.Location = New System.Drawing.Point(261, 101)
        Me.txtLocalidad.Name = "txtLocalidad"
        Me.txtLocalidad.Size = New System.Drawing.Size(344, 30)
        Me.txtLocalidad.TabIndex = 11
        '
        'txtCp
        '
        Me.txtCp.Enabled = False
        Me.txtCp.Location = New System.Drawing.Point(261, 50)
        Me.txtCp.Name = "txtCp"
        Me.txtCp.Size = New System.Drawing.Size(344, 30)
        Me.txtCp.TabIndex = 10
        '
        'btnEliminar
        '
        Me.btnEliminar.Image = Global.sys_Juzgados.My.Resources.Resources.rounded_remove_button
        Me.btnEliminar.Location = New System.Drawing.Point(17, 232)
        Me.btnEliminar.Name = "btnEliminar"
        Me.btnEliminar.Size = New System.Drawing.Size(93, 81)
        Me.btnEliminar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.btnEliminar.TabIndex = 16
        Me.btnEliminar.TabStop = False
        '
        'btnModificar
        '
        Me.btnModificar.Image = Global.sys_Juzgados.My.Resources.Resources.actualize_arrows_couple_in_circle
        Me.btnModificar.Location = New System.Drawing.Point(17, 122)
        Me.btnModificar.Name = "btnModificar"
        Me.btnModificar.Size = New System.Drawing.Size(93, 81)
        Me.btnModificar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.btnModificar.TabIndex = 17
        Me.btnModificar.TabStop = False
        '
        'btnNuevo
        '
        Me.btnNuevo.Image = Global.sys_Juzgados.My.Resources.Resources.plus
        Me.btnNuevo.Location = New System.Drawing.Point(17, 15)
        Me.btnNuevo.Name = "btnNuevo"
        Me.btnNuevo.Size = New System.Drawing.Size(93, 81)
        Me.btnNuevo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.btnNuevo.TabIndex = 15
        Me.btnNuevo.TabStop = False
        '
        'dgvLocalidades
        '
        Me.dgvLocalidades.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.dgvLocalidades.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvLocalidades.Dock = System.Windows.Forms.DockStyle.Fill
        Me.dgvLocalidades.Location = New System.Drawing.Point(0, 0)
        Me.dgvLocalidades.Name = "dgvLocalidades"
        Me.dgvLocalidades.RowHeadersWidth = 62
        Me.dgvLocalidades.RowTemplate.Height = 28
        Me.dgvLocalidades.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgvLocalidades.Size = New System.Drawing.Size(924, 521)
        Me.dgvLocalidades.TabIndex = 18
        '
        'Panel3
        '
        Me.Panel3.Controls.Add(Me.GroupBoxIngresar)
        Me.Panel3.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.Panel3.Location = New System.Drawing.Point(31, 349)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(761, 172)
        Me.Panel3.TabIndex = 26
        '
        'GroupBoxIngresar
        '
        Me.GroupBoxIngresar.Controls.Add(Me.txtLocalidad)
        Me.GroupBoxIngresar.Controls.Add(Me.lbCp)
        Me.GroupBoxIngresar.Controls.Add(Me.lbLocalidades)
        Me.GroupBoxIngresar.Controls.Add(Me.txtCp)
        Me.GroupBoxIngresar.Dock = System.Windows.Forms.DockStyle.Fill
        Me.GroupBoxIngresar.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBoxIngresar.ForeColor = System.Drawing.Color.Navy
        Me.GroupBoxIngresar.Location = New System.Drawing.Point(0, 0)
        Me.GroupBoxIngresar.Name = "GroupBoxIngresar"
        Me.GroupBoxIngresar.Size = New System.Drawing.Size(761, 172)
        Me.GroupBoxIngresar.TabIndex = 0
        Me.GroupBoxIngresar.TabStop = False
        Me.GroupBoxIngresar.Text = "Ingresar Datos"
        '
        'Panel2
        '
        Me.Panel2.Controls.Add(Me.btnEliminar)
        Me.Panel2.Controls.Add(Me.btnModificar)
        Me.Panel2.Controls.Add(Me.btnNuevo)
        Me.Panel2.Controls.Add(Me.btnListo)
        Me.Panel2.Dock = System.Windows.Forms.DockStyle.Right
        Me.Panel2.Location = New System.Drawing.Point(792, 47)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(132, 474)
        Me.Panel2.TabIndex = 25
        '
        'Panel1
        '
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel1.Location = New System.Drawing.Point(31, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(893, 47)
        Me.Panel1.TabIndex = 24
        '
        'Panel5
        '
        Me.Panel5.Dock = System.Windows.Forms.DockStyle.Left
        Me.Panel5.Location = New System.Drawing.Point(0, 0)
        Me.Panel5.Name = "Panel5"
        Me.Panel5.Size = New System.Drawing.Size(31, 521)
        Me.Panel5.TabIndex = 28
        '
        'Panel4
        '
        Me.Panel4.Controls.Add(Me.dgvLocalidades)
        Me.Panel4.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel4.Location = New System.Drawing.Point(0, 0)
        Me.Panel4.Name = "Panel4"
        Me.Panel4.Size = New System.Drawing.Size(924, 521)
        Me.Panel4.TabIndex = 27
        '
        'frmLocalidades
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(924, 521)
        Me.Controls.Add(Me.Panel3)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.Panel5)
        Me.Controls.Add(Me.Panel4)
        Me.Name = "frmLocalidades"
        Me.Text = "frmLocalidades"
        CType(Me.btnEliminar, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.btnModificar, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.btnNuevo, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dgvLocalidades, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel3.ResumeLayout(False)
        Me.GroupBoxIngresar.ResumeLayout(False)
        Me.GroupBoxIngresar.PerformLayout()
        Me.Panel2.ResumeLayout(False)
        Me.Panel4.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents lbCp As Label
    Friend WithEvents lbLocalidades As Label
    Friend WithEvents btnListo As Button
    Friend WithEvents txtLocalidad As TextBox
    Friend WithEvents txtCp As TextBox
    Friend WithEvents btnEliminar As PictureBox
    Friend WithEvents btnModificar As PictureBox
    Friend WithEvents btnNuevo As PictureBox
    Friend WithEvents dgvLocalidades As DataGridView
    Friend WithEvents Panel3 As Panel
    Friend WithEvents GroupBoxIngresar As GroupBox
    Friend WithEvents Panel2 As Panel
    Friend WithEvents Panel1 As Panel
    Friend WithEvents Panel5 As Panel
    Friend WithEvents Panel4 As Panel
End Class
