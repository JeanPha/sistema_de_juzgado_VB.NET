<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmJuzgados
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
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.txtFecha = New System.Windows.Forms.TextBox()
        Me.lbLocalidad = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txtLocalidad = New System.Windows.Forms.TextBox()
        Me.DateTimePicker1 = New System.Windows.Forms.DateTimePicker()
        Me.txtJuez = New System.Windows.Forms.TextBox()
        Me.lbFecha = New System.Windows.Forms.Label()
        Me.btnSelectLoc = New System.Windows.Forms.Button()
        Me.txtSecretario = New System.Windows.Forms.TextBox()
        Me.lbSecretario = New System.Windows.Forms.Label()
        Me.lbJuez = New System.Windows.Forms.Label()
        Me.txtCodigo = New System.Windows.Forms.TextBox()
        Me.txtTelefono = New System.Windows.Forms.TextBox()
        Me.lbTelefono = New System.Windows.Forms.Label()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.btnEliminar = New System.Windows.Forms.PictureBox()
        Me.btnNuevo = New System.Windows.Forms.PictureBox()
        Me.btnModificar = New System.Windows.Forms.PictureBox()
        Me.btnListo = New System.Windows.Forms.Button()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.dgvJuzgados = New System.Windows.Forms.DataGridView()
        Me.Panel5 = New System.Windows.Forms.Panel()
        Me.GroupBox1.SuspendLayout()
        Me.Panel3.SuspendLayout()
        CType(Me.btnEliminar, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.btnNuevo, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.btnModificar, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dgvJuzgados, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel5.SuspendLayout()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.txtFecha)
        Me.GroupBox1.Controls.Add(Me.lbLocalidad)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Controls.Add(Me.txtLocalidad)
        Me.GroupBox1.Controls.Add(Me.DateTimePicker1)
        Me.GroupBox1.Controls.Add(Me.txtJuez)
        Me.GroupBox1.Controls.Add(Me.lbFecha)
        Me.GroupBox1.Controls.Add(Me.btnSelectLoc)
        Me.GroupBox1.Controls.Add(Me.txtSecretario)
        Me.GroupBox1.Controls.Add(Me.lbSecretario)
        Me.GroupBox1.Controls.Add(Me.lbJuez)
        Me.GroupBox1.Controls.Add(Me.txtCodigo)
        Me.GroupBox1.Controls.Add(Me.txtTelefono)
        Me.GroupBox1.Controls.Add(Me.lbTelefono)
        Me.GroupBox1.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.GroupBox1.ForeColor = System.Drawing.Color.Navy
        Me.GroupBox1.Location = New System.Drawing.Point(0, 356)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(1441, 203)
        Me.GroupBox1.TabIndex = 38
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Ingrese datos"
        '
        'txtFecha
        '
        Me.txtFecha.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtFecha.Location = New System.Drawing.Point(510, 123)
        Me.txtFecha.Name = "txtFecha"
        Me.txtFecha.Size = New System.Drawing.Size(200, 26)
        Me.txtFecha.TabIndex = 4
        '
        'lbLocalidad
        '
        Me.lbLocalidad.AutoSize = True
        Me.lbLocalidad.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbLocalidad.Location = New System.Drawing.Point(786, 126)
        Me.lbLocalidad.Name = "lbLocalidad"
        Me.lbLocalidad.Size = New System.Drawing.Size(101, 20)
        Me.lbLocalidad.TabIndex = 13
        Me.lbLocalidad.Text = "LOCALIDAD"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(62, 62)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(74, 20)
        Me.Label1.TabIndex = 8
        Me.Label1.Text = "CODIGO"
        '
        'txtLocalidad
        '
        Me.txtLocalidad.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtLocalidad.Location = New System.Drawing.Point(893, 123)
        Me.txtLocalidad.Name = "txtLocalidad"
        Me.txtLocalidad.ReadOnly = True
        Me.txtLocalidad.Size = New System.Drawing.Size(155, 26)
        Me.txtLocalidad.TabIndex = 1
        '
        'DateTimePicker1
        '
        Me.DateTimePicker1.CalendarForeColor = System.Drawing.Color.Navy
        Me.DateTimePicker1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DateTimePicker1.Location = New System.Drawing.Point(510, 155)
        Me.DateTimePicker1.Name = "DateTimePicker1"
        Me.DateTimePicker1.Size = New System.Drawing.Size(200, 26)
        Me.DateTimePicker1.TabIndex = 22
        '
        'txtJuez
        '
        Me.txtJuez.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtJuez.Location = New System.Drawing.Point(510, 56)
        Me.txtJuez.Name = "txtJuez"
        Me.txtJuez.Size = New System.Drawing.Size(200, 26)
        Me.txtJuez.TabIndex = 7
        '
        'lbFecha
        '
        Me.lbFecha.AutoSize = True
        Me.lbFecha.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbFecha.Location = New System.Drawing.Point(391, 129)
        Me.lbFecha.Name = "lbFecha"
        Me.lbFecha.Size = New System.Drawing.Size(113, 20)
        Me.lbFecha.TabIndex = 12
        Me.lbFecha.Text = "FECHA_ALTA"
        '
        'btnSelectLoc
        '
        Me.btnSelectLoc.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSelectLoc.Location = New System.Drawing.Point(1067, 121)
        Me.btnSelectLoc.Name = "btnSelectLoc"
        Me.btnSelectLoc.Size = New System.Drawing.Size(59, 31)
        Me.btnSelectLoc.TabIndex = 2
        Me.btnSelectLoc.Text = "..."
        Me.btnSelectLoc.UseVisualStyleBackColor = True
        '
        'txtSecretario
        '
        Me.txtSecretario.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtSecretario.Location = New System.Drawing.Point(893, 56)
        Me.txtSecretario.Name = "txtSecretario"
        Me.txtSecretario.Size = New System.Drawing.Size(155, 26)
        Me.txtSecretario.TabIndex = 6
        '
        'lbSecretario
        '
        Me.lbSecretario.AutoSize = True
        Me.lbSecretario.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbSecretario.Location = New System.Drawing.Point(773, 62)
        Me.lbSecretario.Name = "lbSecretario"
        Me.lbSecretario.Size = New System.Drawing.Size(114, 20)
        Me.lbSecretario.TabIndex = 10
        Me.lbSecretario.Text = "SECRETARIO"
        '
        'lbJuez
        '
        Me.lbJuez.AutoSize = True
        Me.lbJuez.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbJuez.Location = New System.Drawing.Point(454, 62)
        Me.lbJuez.Name = "lbJuez"
        Me.lbJuez.Size = New System.Drawing.Size(50, 20)
        Me.lbJuez.TabIndex = 9
        Me.lbJuez.Text = "JUEZ"
        '
        'txtCodigo
        '
        Me.txtCodigo.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtCodigo.Location = New System.Drawing.Point(142, 56)
        Me.txtCodigo.Name = "txtCodigo"
        Me.txtCodigo.ReadOnly = True
        Me.txtCodigo.Size = New System.Drawing.Size(175, 26)
        Me.txtCodigo.TabIndex = 3
        '
        'txtTelefono
        '
        Me.txtTelefono.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtTelefono.Location = New System.Drawing.Point(142, 123)
        Me.txtTelefono.Name = "txtTelefono"
        Me.txtTelefono.Size = New System.Drawing.Size(175, 26)
        Me.txtTelefono.TabIndex = 5
        '
        'lbTelefono
        '
        Me.lbTelefono.AutoSize = True
        Me.lbTelefono.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbTelefono.Location = New System.Drawing.Point(42, 126)
        Me.lbTelefono.Name = "lbTelefono"
        Me.lbTelefono.Size = New System.Drawing.Size(94, 20)
        Me.lbTelefono.TabIndex = 11
        Me.lbTelefono.Text = "TELEFONO"
        '
        'Panel3
        '
        Me.Panel3.Controls.Add(Me.btnEliminar)
        Me.Panel3.Controls.Add(Me.btnNuevo)
        Me.Panel3.Controls.Add(Me.btnModificar)
        Me.Panel3.Controls.Add(Me.btnListo)
        Me.Panel3.Dock = System.Windows.Forms.DockStyle.Right
        Me.Panel3.Location = New System.Drawing.Point(1317, 38)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(124, 521)
        Me.Panel3.TabIndex = 45
        '
        'btnEliminar
        '
        Me.btnEliminar.Location = New System.Drawing.Point(20, 186)
        Me.btnEliminar.Name = "btnEliminar"
        Me.btnEliminar.Size = New System.Drawing.Size(92, 83)
        Me.btnEliminar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.btnEliminar.TabIndex = 19
        Me.btnEliminar.TabStop = False
        '
        'btnNuevo
        '
        Me.btnNuevo.Location = New System.Drawing.Point(20, 6)
        Me.btnNuevo.Name = "btnNuevo"
        Me.btnNuevo.Size = New System.Drawing.Size(92, 89)
        Me.btnNuevo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.btnNuevo.TabIndex = 18
        Me.btnNuevo.TabStop = False
        '
        'btnModificar
        '
        Me.btnModificar.Location = New System.Drawing.Point(20, 97)
        Me.btnModificar.Name = "btnModificar"
        Me.btnModificar.Size = New System.Drawing.Size(92, 83)
        Me.btnModificar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.btnModificar.TabIndex = 20
        Me.btnModificar.TabStop = False
        '
        'btnListo
        '
        Me.btnListo.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnListo.ForeColor = System.Drawing.Color.Navy
        Me.btnListo.Location = New System.Drawing.Point(20, 292)
        Me.btnListo.Name = "btnListo"
        Me.btnListo.Size = New System.Drawing.Size(92, 62)
        Me.btnListo.TabIndex = 21
        Me.btnListo.Text = "LISTO"
        Me.btnListo.UseVisualStyleBackColor = True
        '
        'Panel2
        '
        Me.Panel2.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel2.Location = New System.Drawing.Point(10, 0)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(1431, 38)
        Me.Panel2.TabIndex = 44
        '
        'Panel1
        '
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Left
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(10, 559)
        Me.Panel1.TabIndex = 43
        '
        'dgvJuzgados
        '
        Me.dgvJuzgados.AllowUserToAddRows = False
        Me.dgvJuzgados.AllowUserToDeleteRows = False
        Me.dgvJuzgados.AllowUserToResizeColumns = False
        Me.dgvJuzgados.AllowUserToResizeRows = False
        Me.dgvJuzgados.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.dgvJuzgados.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvJuzgados.Dock = System.Windows.Forms.DockStyle.Fill
        Me.dgvJuzgados.Location = New System.Drawing.Point(0, 0)
        Me.dgvJuzgados.Name = "dgvJuzgados"
        Me.dgvJuzgados.ReadOnly = True
        Me.dgvJuzgados.RowHeadersWidth = 62
        Me.dgvJuzgados.RowTemplate.Height = 28
        Me.dgvJuzgados.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgvJuzgados.Size = New System.Drawing.Size(1441, 559)
        Me.dgvJuzgados.TabIndex = 37
        '
        'Panel5
        '
        Me.Panel5.Controls.Add(Me.GroupBox1)
        Me.Panel5.Controls.Add(Me.dgvJuzgados)
        Me.Panel5.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel5.Location = New System.Drawing.Point(0, 0)
        Me.Panel5.Name = "Panel5"
        Me.Panel5.Size = New System.Drawing.Size(1441, 559)
        Me.Panel5.TabIndex = 46
        '
        'frmJuzgados
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1441, 559)
        Me.Controls.Add(Me.Panel3)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.Panel5)
        Me.Name = "frmJuzgados"
        Me.Text = "frmJuzgados"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.Panel3.ResumeLayout(False)
        CType(Me.btnEliminar, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.btnNuevo, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.btnModificar, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dgvJuzgados, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel5.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents txtFecha As TextBox
    Friend WithEvents lbLocalidad As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents txtLocalidad As TextBox
    Friend WithEvents DateTimePicker1 As DateTimePicker
    Friend WithEvents txtJuez As TextBox
    Friend WithEvents lbFecha As Label
    Friend WithEvents btnSelectLoc As Button
    Friend WithEvents txtSecretario As TextBox
    Friend WithEvents lbSecretario As Label
    Friend WithEvents lbJuez As Label
    Friend WithEvents txtCodigo As TextBox
    Friend WithEvents txtTelefono As TextBox
    Friend WithEvents lbTelefono As Label
    Friend WithEvents Panel3 As Panel
    Friend WithEvents btnEliminar As PictureBox
    Friend WithEvents btnNuevo As PictureBox
    Friend WithEvents btnModificar As PictureBox
    Friend WithEvents btnListo As Button
    Friend WithEvents Panel2 As Panel
    Friend WithEvents Panel1 As Panel
    Friend WithEvents dgvJuzgados As DataGridView
    Friend WithEvents Panel5 As Panel
End Class
