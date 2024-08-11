<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmExpedientes
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
        Me.btnListo = New System.Windows.Forms.Button()
        Me.btnModificar = New System.Windows.Forms.PictureBox()
        Me.btnEliminar = New System.Windows.Forms.PictureBox()
        Me.btnEstado = New System.Windows.Forms.Button()
        Me.btnJuicio = New System.Windows.Forms.Button()
        Me.btnCliente = New System.Windows.Forms.Button()
        Me.btnJuzgado = New System.Windows.Forms.Button()
        Me.lbJuzgado = New System.Windows.Forms.Label()
        Me.txtJuicio = New System.Windows.Forms.TextBox()
        Me.txtEstado = New System.Windows.Forms.TextBox()
        Me.txtJuzgado = New System.Windows.Forms.TextBox()
        Me.lbCliente = New System.Windows.Forms.Label()
        Me.txtCaratula = New System.Windows.Forms.TextBox()
        Me.Panel4 = New System.Windows.Forms.Panel()
        Me.btnNuevo = New System.Windows.Forms.PictureBox()
        Me.Panel5 = New System.Windows.Forms.Panel()
        Me.txtCliente = New System.Windows.Forms.TextBox()
        Me.DateTimePicker1 = New System.Windows.Forms.DateTimePicker()
        Me.lbEstado = New System.Windows.Forms.Label()
        Me.lbJuicio = New System.Windows.Forms.Label()
        Me.txtCodigo = New System.Windows.Forms.TextBox()
        Me.lbFecha = New System.Windows.Forms.Label()
        Me.txtFecha = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.dgvExpedientes = New System.Windows.Forms.DataGridView()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Panel6 = New System.Windows.Forms.Panel()
        Me.Panel2 = New System.Windows.Forms.Panel()
        CType(Me.btnModificar, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.btnEliminar, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel4.SuspendLayout()
        CType(Me.btnNuevo, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dgvExpedientes, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        Me.Panel6.SuspendLayout()
        Me.Panel2.SuspendLayout()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(1191, 47)
        Me.Panel1.TabIndex = 7
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
        'btnEstado
        '
        Me.btnEstado.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnEstado.Location = New System.Drawing.Point(351, 113)
        Me.btnEstado.Name = "btnEstado"
        Me.btnEstado.Size = New System.Drawing.Size(64, 50)
        Me.btnEstado.TabIndex = 44
        Me.btnEstado.Text = "..."
        Me.btnEstado.UseVisualStyleBackColor = True
        '
        'btnJuicio
        '
        Me.btnJuicio.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnJuicio.Location = New System.Drawing.Point(331, 171)
        Me.btnJuicio.Name = "btnJuicio"
        Me.btnJuicio.Size = New System.Drawing.Size(64, 50)
        Me.btnJuicio.TabIndex = 43
        Me.btnJuicio.Text = "..."
        Me.btnJuicio.UseVisualStyleBackColor = True
        '
        'btnCliente
        '
        Me.btnCliente.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnCliente.Location = New System.Drawing.Point(1064, 110)
        Me.btnCliente.Name = "btnCliente"
        Me.btnCliente.Size = New System.Drawing.Size(64, 50)
        Me.btnCliente.TabIndex = 42
        Me.btnCliente.Text = "..."
        Me.btnCliente.UseVisualStyleBackColor = True
        '
        'btnJuzgado
        '
        Me.btnJuzgado.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnJuzgado.Location = New System.Drawing.Point(832, 171)
        Me.btnJuzgado.Name = "btnJuzgado"
        Me.btnJuzgado.Size = New System.Drawing.Size(64, 50)
        Me.btnJuzgado.TabIndex = 41
        Me.btnJuzgado.Text = "..."
        Me.btnJuzgado.UseVisualStyleBackColor = True
        '
        'lbJuzgado
        '
        Me.lbJuzgado.AutoSize = True
        Me.lbJuzgado.Location = New System.Drawing.Point(443, 192)
        Me.lbJuzgado.Name = "lbJuzgado"
        Me.lbJuzgado.Size = New System.Drawing.Size(87, 20)
        Me.lbJuzgado.TabIndex = 32
        Me.lbJuzgado.Text = "JUZGADO"
        '
        'txtJuicio
        '
        Me.txtJuicio.Location = New System.Drawing.Point(141, 183)
        Me.txtJuicio.Name = "txtJuicio"
        Me.txtJuicio.ReadOnly = True
        Me.txtJuicio.Size = New System.Drawing.Size(175, 26)
        Me.txtJuicio.TabIndex = 27
        '
        'txtEstado
        '
        Me.txtEstado.Location = New System.Drawing.Point(158, 125)
        Me.txtEstado.Name = "txtEstado"
        Me.txtEstado.ReadOnly = True
        Me.txtEstado.Size = New System.Drawing.Size(175, 26)
        Me.txtEstado.TabIndex = 29
        '
        'txtJuzgado
        '
        Me.txtJuzgado.Location = New System.Drawing.Point(616, 189)
        Me.txtJuzgado.Name = "txtJuzgado"
        Me.txtJuzgado.ReadOnly = True
        Me.txtJuzgado.Size = New System.Drawing.Size(200, 26)
        Me.txtJuzgado.TabIndex = 28
        '
        'lbCliente
        '
        Me.lbCliente.AutoSize = True
        Me.lbCliente.Location = New System.Drawing.Point(710, 128)
        Me.lbCliente.Name = "lbCliente"
        Me.lbCliente.Size = New System.Drawing.Size(76, 20)
        Me.lbCliente.TabIndex = 35
        Me.lbCliente.Text = "CLIENTE"
        '
        'txtCaratula
        '
        Me.txtCaratula.Location = New System.Drawing.Point(447, 49)
        Me.txtCaratula.Name = "txtCaratula"
        Me.txtCaratula.Size = New System.Drawing.Size(200, 26)
        Me.txtCaratula.TabIndex = 38
        '
        'Panel4
        '
        Me.Panel4.Controls.Add(Me.btnListo)
        Me.Panel4.Controls.Add(Me.btnModificar)
        Me.Panel4.Controls.Add(Me.btnEliminar)
        Me.Panel4.Controls.Add(Me.btnNuevo)
        Me.Panel4.Dock = System.Windows.Forms.DockStyle.Right
        Me.Panel4.Location = New System.Drawing.Point(1191, 0)
        Me.Panel4.Name = "Panel4"
        Me.Panel4.Size = New System.Drawing.Size(126, 618)
        Me.Panel4.TabIndex = 9
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
        'Panel5
        '
        Me.Panel5.Dock = System.Windows.Forms.DockStyle.Left
        Me.Panel5.Location = New System.Drawing.Point(0, 0)
        Me.Panel5.Name = "Panel5"
        Me.Panel5.Size = New System.Drawing.Size(27, 618)
        Me.Panel5.TabIndex = 1
        '
        'txtCliente
        '
        Me.txtCliente.Location = New System.Drawing.Point(861, 122)
        Me.txtCliente.Name = "txtCliente"
        Me.txtCliente.ReadOnly = True
        Me.txtCliente.Size = New System.Drawing.Size(200, 26)
        Me.txtCliente.TabIndex = 23
        '
        'DateTimePicker1
        '
        Me.DateTimePicker1.Location = New System.Drawing.Point(870, 78)
        Me.DateTimePicker1.Name = "DateTimePicker1"
        Me.DateTimePicker1.Size = New System.Drawing.Size(200, 26)
        Me.DateTimePicker1.TabIndex = 36
        '
        'lbEstado
        '
        Me.lbEstado.AutoSize = True
        Me.lbEstado.Location = New System.Drawing.Point(8, 131)
        Me.lbEstado.Name = "lbEstado"
        Me.lbEstado.Size = New System.Drawing.Size(75, 20)
        Me.lbEstado.TabIndex = 31
        Me.lbEstado.Text = "ESTADO"
        '
        'lbJuicio
        '
        Me.lbJuicio.AutoSize = True
        Me.lbJuicio.Location = New System.Drawing.Point(8, 189)
        Me.lbJuicio.Name = "lbJuicio"
        Me.lbJuicio.Size = New System.Drawing.Size(62, 20)
        Me.lbJuicio.TabIndex = 33
        Me.lbJuicio.Text = "JUICIO"
        '
        'txtCodigo
        '
        Me.txtCodigo.Location = New System.Drawing.Point(108, 49)
        Me.txtCodigo.Name = "txtCodigo"
        Me.txtCodigo.ReadOnly = True
        Me.txtCodigo.Size = New System.Drawing.Size(175, 26)
        Me.txtCodigo.TabIndex = 25
        '
        'lbFecha
        '
        Me.lbFecha.AutoSize = True
        Me.lbFecha.Location = New System.Drawing.Point(680, 49)
        Me.lbFecha.Name = "lbFecha"
        Me.lbFecha.Size = New System.Drawing.Size(122, 20)
        Me.lbFecha.TabIndex = 34
        Me.lbFecha.Text = "FECHA_INICIO"
        '
        'txtFecha
        '
        Me.txtFecha.Location = New System.Drawing.Point(870, 46)
        Me.txtFecha.Name = "txtFecha"
        Me.txtFecha.Size = New System.Drawing.Size(200, 26)
        Me.txtFecha.TabIndex = 26
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(336, 52)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(95, 20)
        Me.Label2.TabIndex = 37
        Me.Label2.Text = "CARATULA"
        '
        'dgvExpedientes
        '
        Me.dgvExpedientes.AllowUserToAddRows = False
        Me.dgvExpedientes.AllowUserToDeleteRows = False
        Me.dgvExpedientes.AllowUserToResizeColumns = False
        Me.dgvExpedientes.AllowUserToResizeRows = False
        Me.dgvExpedientes.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.dgvExpedientes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvExpedientes.Dock = System.Windows.Forms.DockStyle.Fill
        Me.dgvExpedientes.Location = New System.Drawing.Point(0, 0)
        Me.dgvExpedientes.Name = "dgvExpedientes"
        Me.dgvExpedientes.ReadOnly = True
        Me.dgvExpedientes.RowHeadersWidth = 62
        Me.dgvExpedientes.RowTemplate.Height = 28
        Me.dgvExpedientes.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgvExpedientes.Size = New System.Drawing.Size(1290, 380)
        Me.dgvExpedientes.TabIndex = 0
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.btnEstado)
        Me.GroupBox1.Controls.Add(Me.btnJuicio)
        Me.GroupBox1.Controls.Add(Me.btnCliente)
        Me.GroupBox1.Controls.Add(Me.btnJuzgado)
        Me.GroupBox1.Controls.Add(Me.lbJuzgado)
        Me.GroupBox1.Controls.Add(Me.txtJuicio)
        Me.GroupBox1.Controls.Add(Me.txtEstado)
        Me.GroupBox1.Controls.Add(Me.txtJuzgado)
        Me.GroupBox1.Controls.Add(Me.lbCliente)
        Me.GroupBox1.Controls.Add(Me.txtCaratula)
        Me.GroupBox1.Controls.Add(Me.txtCliente)
        Me.GroupBox1.Controls.Add(Me.DateTimePicker1)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Controls.Add(Me.lbEstado)
        Me.GroupBox1.Controls.Add(Me.lbJuicio)
        Me.GroupBox1.Controls.Add(Me.txtCodigo)
        Me.GroupBox1.Controls.Add(Me.lbFecha)
        Me.GroupBox1.Controls.Add(Me.txtFecha)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.GroupBox1.ForeColor = System.Drawing.Color.Navy
        Me.GroupBox1.Location = New System.Drawing.Point(0, 380)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(1290, 238)
        Me.GroupBox1.TabIndex = 39
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Ingrese datos"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(28, 55)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(74, 20)
        Me.Label1.TabIndex = 30
        Me.Label1.Text = "CODIGO"
        '
        'Panel6
        '
        Me.Panel6.Controls.Add(Me.dgvExpedientes)
        Me.Panel6.Controls.Add(Me.GroupBox1)
        Me.Panel6.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel6.Location = New System.Drawing.Point(27, 0)
        Me.Panel6.Name = "Panel6"
        Me.Panel6.Size = New System.Drawing.Size(1290, 618)
        Me.Panel6.TabIndex = 40
        '
        'Panel2
        '
        Me.Panel2.Controls.Add(Me.Panel6)
        Me.Panel2.Controls.Add(Me.Panel5)
        Me.Panel2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel2.Location = New System.Drawing.Point(0, 0)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(1317, 618)
        Me.Panel2.TabIndex = 8
        '
        'frmExpedientes
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1317, 618)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.Panel4)
        Me.Controls.Add(Me.Panel2)
        Me.Name = "frmExpedientes"
        Me.Text = "frmExpedientes"
        CType(Me.btnModificar, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.btnEliminar, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel4.ResumeLayout(False)
        CType(Me.btnNuevo, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dgvExpedientes, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.Panel6.ResumeLayout(False)
        Me.Panel2.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Panel1 As Panel
    Friend WithEvents btnListo As Button
    Friend WithEvents btnModificar As PictureBox
    Friend WithEvents btnEliminar As PictureBox
    Friend WithEvents btnEstado As Button
    Friend WithEvents btnJuicio As Button
    Friend WithEvents btnCliente As Button
    Friend WithEvents btnJuzgado As Button
    Friend WithEvents lbJuzgado As Label
    Friend WithEvents txtJuicio As TextBox
    Friend WithEvents txtEstado As TextBox
    Friend WithEvents txtJuzgado As TextBox
    Friend WithEvents lbCliente As Label
    Friend WithEvents txtCaratula As TextBox
    Friend WithEvents Panel4 As Panel
    Friend WithEvents btnNuevo As PictureBox
    Friend WithEvents Panel5 As Panel
    Friend WithEvents txtCliente As TextBox
    Friend WithEvents DateTimePicker1 As DateTimePicker
    Friend WithEvents lbEstado As Label
    Friend WithEvents lbJuicio As Label
    Friend WithEvents txtCodigo As TextBox
    Friend WithEvents lbFecha As Label
    Friend WithEvents txtFecha As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents dgvExpedientes As DataGridView
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Panel6 As Panel
    Friend WithEvents Panel2 As Panel
End Class
