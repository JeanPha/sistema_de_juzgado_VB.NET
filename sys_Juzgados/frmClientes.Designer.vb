<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmClientes
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
        Me.btnListo = New System.Windows.Forms.Button()
        Me.btnModificar = New System.Windows.Forms.PictureBox()
        Me.btnNuevo = New System.Windows.Forms.PictureBox()
        Me.Panel4 = New System.Windows.Forms.Panel()
        Me.btnEliminar = New System.Windows.Forms.PictureBox()
        Me.Panel5 = New System.Windows.Forms.Panel()
        Me.lbSecretario = New System.Windows.Forms.Label()
        Me.txtTelefono = New System.Windows.Forms.TextBox()
        Me.txtNroDoc = New System.Windows.Forms.TextBox()
        Me.txtNombre = New System.Windows.Forms.TextBox()
        Me.lbLocalidad = New System.Windows.Forms.Label()
        Me.txtDomicilio = New System.Windows.Forms.TextBox()
        Me.txtLocalidad = New System.Windows.Forms.TextBox()
        Me.DateTimePicker1 = New System.Windows.Forms.DateTimePicker()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.lbJuez = New System.Windows.Forms.Label()
        Me.btnSelectLoc = New System.Windows.Forms.Button()
        Me.lbTelefono = New System.Windows.Forms.Label()
        Me.txtCodigo = New System.Windows.Forms.TextBox()
        Me.lbFecha = New System.Windows.Forms.Label()
        Me.txtFecha = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.Panel6 = New System.Windows.Forms.Panel()
        Me.dgvClientes = New System.Windows.Forms.DataGridView()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.Panel1 = New System.Windows.Forms.Panel()
        CType(Me.btnModificar, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.btnNuevo, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel4.SuspendLayout()
        CType(Me.btnEliminar, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        Me.Panel6.SuspendLayout()
        CType(Me.dgvClientes, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel2.SuspendLayout()
        Me.SuspendLayout()
        '
        'btnListo
        '
        Me.btnListo.Location = New System.Drawing.Point(12, 306)
        Me.btnListo.Name = "btnListo"
        Me.btnListo.Size = New System.Drawing.Size(102, 56)
        Me.btnListo.TabIndex = 25
        Me.btnListo.Text = "LISTO"
        Me.btnListo.UseVisualStyleBackColor = True
        '
        'btnModificar
        '
        Me.btnModificar.Image = Global.sys_Juzgados.My.Resources.Resources.actualize_arrows_couple_in_circle
        Me.btnModificar.Location = New System.Drawing.Point(18, 107)
        Me.btnModificar.Name = "btnModificar"
        Me.btnModificar.Size = New System.Drawing.Size(94, 89)
        Me.btnModificar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.btnModificar.TabIndex = 24
        Me.btnModificar.TabStop = False
        '
        'btnNuevo
        '
        Me.btnNuevo.Image = Global.sys_Juzgados.My.Resources.Resources.plus
        Me.btnNuevo.Location = New System.Drawing.Point(18, 6)
        Me.btnNuevo.Name = "btnNuevo"
        Me.btnNuevo.Size = New System.Drawing.Size(94, 95)
        Me.btnNuevo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.btnNuevo.TabIndex = 22
        Me.btnNuevo.TabStop = False
        '
        'Panel4
        '
        Me.Panel4.Controls.Add(Me.btnListo)
        Me.Panel4.Controls.Add(Me.btnModificar)
        Me.Panel4.Controls.Add(Me.btnEliminar)
        Me.Panel4.Controls.Add(Me.btnNuevo)
        Me.Panel4.Dock = System.Windows.Forms.DockStyle.Right
        Me.Panel4.Location = New System.Drawing.Point(1185, 47)
        Me.Panel4.Name = "Panel4"
        Me.Panel4.Size = New System.Drawing.Size(144, 584)
        Me.Panel4.TabIndex = 6
        '
        'btnEliminar
        '
        Me.btnEliminar.Image = Global.sys_Juzgados.My.Resources.Resources.rounded_remove_button
        Me.btnEliminar.Location = New System.Drawing.Point(18, 202)
        Me.btnEliminar.Name = "btnEliminar"
        Me.btnEliminar.Size = New System.Drawing.Size(94, 89)
        Me.btnEliminar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.btnEliminar.TabIndex = 23
        Me.btnEliminar.TabStop = False
        '
        'Panel5
        '
        Me.Panel5.Dock = System.Windows.Forms.DockStyle.Left
        Me.Panel5.Location = New System.Drawing.Point(0, 0)
        Me.Panel5.Name = "Panel5"
        Me.Panel5.Size = New System.Drawing.Size(27, 584)
        Me.Panel5.TabIndex = 1
        '
        'lbSecretario
        '
        Me.lbSecretario.AutoSize = True
        Me.lbSecretario.Location = New System.Drawing.Point(313, 58)
        Me.lbSecretario.Name = "lbSecretario"
        Me.lbSecretario.Size = New System.Drawing.Size(112, 13)
        Me.lbSecretario.TabIndex = 32
        Me.lbSecretario.Text = "NOMBRE_APELLIDO"
        '
        'txtTelefono
        '
        Me.txtTelefono.Location = New System.Drawing.Point(108, 186)
        Me.txtTelefono.Name = "txtTelefono"
        Me.txtTelefono.Size = New System.Drawing.Size(175, 20)
        Me.txtTelefono.TabIndex = 27
        '
        'txtNroDoc
        '
        Me.txtNroDoc.Location = New System.Drawing.Point(108, 125)
        Me.txtNroDoc.Name = "txtNroDoc"
        Me.txtNroDoc.Size = New System.Drawing.Size(175, 20)
        Me.txtNroDoc.TabIndex = 29
        '
        'txtNombre
        '
        Me.txtNombre.Location = New System.Drawing.Point(486, 55)
        Me.txtNombre.Name = "txtNombre"
        Me.txtNombre.Size = New System.Drawing.Size(200, 20)
        Me.txtNombre.TabIndex = 28
        '
        'lbLocalidad
        '
        Me.lbLocalidad.AutoSize = True
        Me.lbLocalidad.Location = New System.Drawing.Point(745, 172)
        Me.lbLocalidad.Name = "lbLocalidad"
        Me.lbLocalidad.Size = New System.Drawing.Size(67, 13)
        Me.lbLocalidad.TabIndex = 35
        Me.lbLocalidad.Text = "LOCALIDAD"
        '
        'txtDomicilio
        '
        Me.txtDomicilio.Location = New System.Drawing.Point(861, 58)
        Me.txtDomicilio.Name = "txtDomicilio"
        Me.txtDomicilio.Size = New System.Drawing.Size(200, 20)
        Me.txtDomicilio.TabIndex = 38
        '
        'txtLocalidad
        '
        Me.txtLocalidad.Location = New System.Drawing.Point(861, 166)
        Me.txtLocalidad.Name = "txtLocalidad"
        Me.txtLocalidad.ReadOnly = True
        Me.txtLocalidad.Size = New System.Drawing.Size(200, 20)
        Me.txtLocalidad.TabIndex = 23
        '
        'DateTimePicker1
        '
        Me.DateTimePicker1.Location = New System.Drawing.Point(486, 157)
        Me.DateTimePicker1.Name = "DateTimePicker1"
        Me.DateTimePicker1.Size = New System.Drawing.Size(200, 20)
        Me.DateTimePicker1.TabIndex = 36
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(28, 55)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(49, 13)
        Me.Label1.TabIndex = 30
        Me.Label1.Text = "CODIGO"
        '
        'lbJuez
        '
        Me.lbJuez.AutoSize = True
        Me.lbJuez.Location = New System.Drawing.Point(19, 125)
        Me.lbJuez.Name = "lbJuez"
        Me.lbJuez.Size = New System.Drawing.Size(57, 13)
        Me.lbJuez.TabIndex = 31
        Me.lbJuez.Text = "NRO DOC"
        '
        'btnSelectLoc
        '
        Me.btnSelectLoc.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnSelectLoc.Location = New System.Drawing.Point(1067, 145)
        Me.btnSelectLoc.Name = "btnSelectLoc"
        Me.btnSelectLoc.Size = New System.Drawing.Size(58, 53)
        Me.btnSelectLoc.TabIndex = 24
        Me.btnSelectLoc.Text = "..."
        Me.btnSelectLoc.UseVisualStyleBackColor = True
        '
        'lbTelefono
        '
        Me.lbTelefono.AutoSize = True
        Me.lbTelefono.Location = New System.Drawing.Point(8, 189)
        Me.lbTelefono.Name = "lbTelefono"
        Me.lbTelefono.Size = New System.Drawing.Size(64, 13)
        Me.lbTelefono.TabIndex = 33
        Me.lbTelefono.Text = "TELEFONO"
        '
        'txtCodigo
        '
        Me.txtCodigo.Location = New System.Drawing.Point(108, 49)
        Me.txtCodigo.Name = "txtCodigo"
        Me.txtCodigo.ReadOnly = True
        Me.txtCodigo.Size = New System.Drawing.Size(175, 20)
        Me.txtCodigo.TabIndex = 25
        '
        'lbFecha
        '
        Me.lbFecha.AutoSize = True
        Me.lbFecha.Location = New System.Drawing.Point(296, 128)
        Me.lbFecha.Name = "lbFecha"
        Me.lbFecha.Size = New System.Drawing.Size(115, 13)
        Me.lbFecha.TabIndex = 34
        Me.lbFecha.Text = "FECHA_NACIMIENTO"
        '
        'txtFecha
        '
        Me.txtFecha.Location = New System.Drawing.Point(486, 125)
        Me.txtFecha.Name = "txtFecha"
        Me.txtFecha.Size = New System.Drawing.Size(200, 20)
        Me.txtFecha.TabIndex = 26
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(750, 61)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(62, 13)
        Me.Label2.TabIndex = 37
        Me.Label2.Text = "DOMICILIO"
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.lbSecretario)
        Me.GroupBox1.Controls.Add(Me.txtTelefono)
        Me.GroupBox1.Controls.Add(Me.txtNroDoc)
        Me.GroupBox1.Controls.Add(Me.txtNombre)
        Me.GroupBox1.Controls.Add(Me.lbLocalidad)
        Me.GroupBox1.Controls.Add(Me.txtDomicilio)
        Me.GroupBox1.Controls.Add(Me.txtLocalidad)
        Me.GroupBox1.Controls.Add(Me.DateTimePicker1)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Controls.Add(Me.lbJuez)
        Me.GroupBox1.Controls.Add(Me.btnSelectLoc)
        Me.GroupBox1.Controls.Add(Me.lbTelefono)
        Me.GroupBox1.Controls.Add(Me.txtCodigo)
        Me.GroupBox1.Controls.Add(Me.lbFecha)
        Me.GroupBox1.Controls.Add(Me.txtFecha)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.GroupBox1.ForeColor = System.Drawing.Color.Navy
        Me.GroupBox1.Location = New System.Drawing.Point(0, 346)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(1302, 238)
        Me.GroupBox1.TabIndex = 39
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Ingrese datos"
        '
        'Panel6
        '
        Me.Panel6.Controls.Add(Me.dgvClientes)
        Me.Panel6.Controls.Add(Me.GroupBox1)
        Me.Panel6.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel6.Location = New System.Drawing.Point(27, 0)
        Me.Panel6.Name = "Panel6"
        Me.Panel6.Size = New System.Drawing.Size(1302, 584)
        Me.Panel6.TabIndex = 40
        '
        'dgvClientes
        '
        Me.dgvClientes.AllowUserToAddRows = False
        Me.dgvClientes.AllowUserToDeleteRows = False
        Me.dgvClientes.AllowUserToResizeColumns = False
        Me.dgvClientes.AllowUserToResizeRows = False
        Me.dgvClientes.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.dgvClientes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvClientes.Dock = System.Windows.Forms.DockStyle.Fill
        Me.dgvClientes.Location = New System.Drawing.Point(0, 0)
        Me.dgvClientes.Name = "dgvClientes"
        Me.dgvClientes.ReadOnly = True
        Me.dgvClientes.RowHeadersWidth = 62
        Me.dgvClientes.RowTemplate.Height = 28
        Me.dgvClientes.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgvClientes.Size = New System.Drawing.Size(1302, 346)
        Me.dgvClientes.TabIndex = 0
        '
        'Panel2
        '
        Me.Panel2.Controls.Add(Me.Panel6)
        Me.Panel2.Controls.Add(Me.Panel5)
        Me.Panel2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel2.Location = New System.Drawing.Point(0, 47)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(1329, 584)
        Me.Panel2.TabIndex = 5
        '
        'Panel1
        '
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(1329, 47)
        Me.Panel1.TabIndex = 4
        '
        'frmClientes
        '
        Me.ClientSize = New System.Drawing.Size(1329, 631)
        Me.Controls.Add(Me.Panel4)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.Panel1)
        Me.Name = "frmClientes"
        CType(Me.btnModificar, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.btnNuevo, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel4.ResumeLayout(False)
        CType(Me.btnEliminar, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.Panel6.ResumeLayout(False)
        CType(Me.dgvClientes, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel2.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents btnListo As Button
    Friend WithEvents btnModificar As PictureBox
    Friend WithEvents btnNuevo As PictureBox
    Friend WithEvents Panel4 As Panel
    Friend WithEvents btnEliminar As PictureBox
    Friend WithEvents Panel5 As Panel
    Friend WithEvents lbSecretario As Label
    Friend WithEvents txtTelefono As TextBox
    Friend WithEvents txtNroDoc As TextBox
    Friend WithEvents txtNombre As TextBox
    Friend WithEvents lbLocalidad As Label
    Friend WithEvents txtDomicilio As TextBox
    Friend WithEvents txtLocalidad As TextBox
    Friend WithEvents DateTimePicker1 As DateTimePicker
    Friend WithEvents Label1 As Label
    Friend WithEvents lbJuez As Label
    Friend WithEvents btnSelectLoc As Button
    Friend WithEvents lbTelefono As Label
    Friend WithEvents txtCodigo As TextBox
    Friend WithEvents lbFecha As Label
    Friend WithEvents txtFecha As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents Panel6 As Panel
    Friend WithEvents dgvClientes As DataGridView
    Friend WithEvents Panel2 As Panel
    Friend WithEvents Panel1 As Panel
End Class
