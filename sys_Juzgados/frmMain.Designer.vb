<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmMain
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
        Me.btnInformeExpedientes = New System.Windows.Forms.Button()
        Me.btnInformeJuzgados = New System.Windows.Forms.Button()
        Me.gbArchivos = New System.Windows.Forms.GroupBox()
        Me.btnExpedientes = New System.Windows.Forms.Button()
        Me.btnJuzgados = New System.Windows.Forms.Button()
        Me.btnEstados = New System.Windows.Forms.Button()
        Me.btnLocalidades = New System.Windows.Forms.Button()
        Me.btnClientes = New System.Windows.Forms.Button()
        Me.btnJuicios = New System.Windows.Forms.Button()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.GroupBox1.SuspendLayout()
        Me.gbArchivos.SuspendLayout()
        Me.Panel3.SuspendLayout()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.Button2)
        Me.GroupBox1.Controls.Add(Me.Button1)
        Me.GroupBox1.Controls.Add(Me.btnInformeExpedientes)
        Me.GroupBox1.Controls.Add(Me.btnInformeJuzgados)
        Me.GroupBox1.Dock = System.Windows.Forms.DockStyle.Top
        Me.GroupBox1.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.ForeColor = System.Drawing.Color.Sienna
        Me.GroupBox1.Location = New System.Drawing.Point(225, 0)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.GroupBox1.Size = New System.Drawing.Size(935, 100)
        Me.GroupBox1.TabIndex = 15
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Informes"
        '
        'btnInformeExpedientes
        '
        Me.btnInformeExpedientes.BackColor = System.Drawing.Color.WhiteSmoke
        Me.btnInformeExpedientes.Dock = System.Windows.Forms.DockStyle.Left
        Me.btnInformeExpedientes.Location = New System.Drawing.Point(221, 28)
        Me.btnInformeExpedientes.Name = "btnInformeExpedientes"
        Me.btnInformeExpedientes.Size = New System.Drawing.Size(218, 69)
        Me.btnInformeExpedientes.TabIndex = 16
        Me.btnInformeExpedientes.Text = "EXPEDIENTES"
        Me.btnInformeExpedientes.UseVisualStyleBackColor = False
        '
        'btnInformeJuzgados
        '
        Me.btnInformeJuzgados.BackColor = System.Drawing.Color.WhiteSmoke
        Me.btnInformeJuzgados.Dock = System.Windows.Forms.DockStyle.Left
        Me.btnInformeJuzgados.Location = New System.Drawing.Point(3, 28)
        Me.btnInformeJuzgados.Name = "btnInformeJuzgados"
        Me.btnInformeJuzgados.Size = New System.Drawing.Size(218, 69)
        Me.btnInformeJuzgados.TabIndex = 15
        Me.btnInformeJuzgados.Text = "JUZGADOS"
        Me.btnInformeJuzgados.UseVisualStyleBackColor = False
        '
        'gbArchivos
        '
        Me.gbArchivos.Controls.Add(Me.btnExpedientes)
        Me.gbArchivos.Controls.Add(Me.btnJuzgados)
        Me.gbArchivos.Controls.Add(Me.btnEstados)
        Me.gbArchivos.Controls.Add(Me.btnLocalidades)
        Me.gbArchivos.Controls.Add(Me.btnClientes)
        Me.gbArchivos.Controls.Add(Me.btnJuicios)
        Me.gbArchivos.Dock = System.Windows.Forms.DockStyle.Left
        Me.gbArchivos.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.gbArchivos.ForeColor = System.Drawing.Color.Navy
        Me.gbArchivos.Location = New System.Drawing.Point(0, 0)
        Me.gbArchivos.Name = "gbArchivos"
        Me.gbArchivos.Size = New System.Drawing.Size(225, 708)
        Me.gbArchivos.TabIndex = 0
        Me.gbArchivos.TabStop = False
        Me.gbArchivos.Text = "Archivos"
        '
        'btnExpedientes
        '
        Me.btnExpedientes.Dock = System.Windows.Forms.DockStyle.Top
        Me.btnExpedientes.FlatAppearance.BorderSize = 10
        Me.btnExpedientes.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.btnExpedientes.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Red
        Me.btnExpedientes.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnExpedientes.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnExpedientes.ForeColor = System.Drawing.Color.Navy
        Me.btnExpedientes.Location = New System.Drawing.Point(3, 393)
        Me.btnExpedientes.Name = "btnExpedientes"
        Me.btnExpedientes.Size = New System.Drawing.Size(219, 73)
        Me.btnExpedientes.TabIndex = 5
        Me.btnExpedientes.Text = "EXPEDIENTES"
        Me.btnExpedientes.UseVisualStyleBackColor = True
        '
        'btnJuzgados
        '
        Me.btnJuzgados.Dock = System.Windows.Forms.DockStyle.Top
        Me.btnJuzgados.FlatAppearance.BorderSize = 10
        Me.btnJuzgados.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.btnJuzgados.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Red
        Me.btnJuzgados.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnJuzgados.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnJuzgados.ForeColor = System.Drawing.Color.Navy
        Me.btnJuzgados.Location = New System.Drawing.Point(3, 320)
        Me.btnJuzgados.Name = "btnJuzgados"
        Me.btnJuzgados.Size = New System.Drawing.Size(219, 73)
        Me.btnJuzgados.TabIndex = 0
        Me.btnJuzgados.Text = "JUZGADOS"
        Me.btnJuzgados.UseVisualStyleBackColor = True
        '
        'btnEstados
        '
        Me.btnEstados.Dock = System.Windows.Forms.DockStyle.Top
        Me.btnEstados.FlatAppearance.BorderSize = 10
        Me.btnEstados.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.btnEstados.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Red
        Me.btnEstados.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnEstados.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnEstados.ForeColor = System.Drawing.Color.Navy
        Me.btnEstados.Location = New System.Drawing.Point(3, 247)
        Me.btnEstados.Name = "btnEstados"
        Me.btnEstados.Size = New System.Drawing.Size(219, 73)
        Me.btnEstados.TabIndex = 2
        Me.btnEstados.Text = "ESTADOS"
        Me.btnEstados.UseVisualStyleBackColor = True
        '
        'btnLocalidades
        '
        Me.btnLocalidades.Dock = System.Windows.Forms.DockStyle.Top
        Me.btnLocalidades.FlatAppearance.BorderSize = 10
        Me.btnLocalidades.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.btnLocalidades.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Red
        Me.btnLocalidades.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnLocalidades.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnLocalidades.ForeColor = System.Drawing.Color.Navy
        Me.btnLocalidades.Location = New System.Drawing.Point(3, 174)
        Me.btnLocalidades.Name = "btnLocalidades"
        Me.btnLocalidades.Size = New System.Drawing.Size(219, 73)
        Me.btnLocalidades.TabIndex = 4
        Me.btnLocalidades.Text = "LOCALIDADES"
        Me.btnLocalidades.UseVisualStyleBackColor = True
        '
        'btnClientes
        '
        Me.btnClientes.Dock = System.Windows.Forms.DockStyle.Top
        Me.btnClientes.FlatAppearance.BorderSize = 10
        Me.btnClientes.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.btnClientes.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Red
        Me.btnClientes.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnClientes.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnClientes.ForeColor = System.Drawing.Color.Navy
        Me.btnClientes.Location = New System.Drawing.Point(3, 101)
        Me.btnClientes.Name = "btnClientes"
        Me.btnClientes.Size = New System.Drawing.Size(219, 73)
        Me.btnClientes.TabIndex = 3
        Me.btnClientes.Text = "CLIENTES"
        Me.btnClientes.UseVisualStyleBackColor = True
        '
        'btnJuicios
        '
        Me.btnJuicios.Dock = System.Windows.Forms.DockStyle.Top
        Me.btnJuicios.FlatAppearance.BorderSize = 10
        Me.btnJuicios.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.btnJuicios.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Red
        Me.btnJuicios.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnJuicios.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnJuicios.ForeColor = System.Drawing.Color.Navy
        Me.btnJuicios.Location = New System.Drawing.Point(3, 28)
        Me.btnJuicios.Name = "btnJuicios"
        Me.btnJuicios.Size = New System.Drawing.Size(219, 73)
        Me.btnJuicios.TabIndex = 1
        Me.btnJuicios.Text = "JUICIOS"
        Me.btnJuicios.UseVisualStyleBackColor = True
        '
        'Panel3
        '
        Me.Panel3.Controls.Add(Me.PictureBox2)
        Me.Panel3.Controls.Add(Me.GroupBox1)
        Me.Panel3.Controls.Add(Me.gbArchivos)
        Me.Panel3.Controls.Add(Me.PictureBox1)
        Me.Panel3.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel3.Location = New System.Drawing.Point(0, 0)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(1160, 708)
        Me.Panel3.TabIndex = 20
        '
        'PictureBox2
        '
        Me.PictureBox2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.PictureBox2.Image = Global.sys_Juzgados.My.Resources.Resources._7VDPUsBGIRIKzCUZsh6n__1__fpcki
        Me.PictureBox2.Location = New System.Drawing.Point(225, 100)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(935, 608)
        Me.PictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox2.TabIndex = 16
        Me.PictureBox2.TabStop = False
        '
        'PictureBox1
        '
        Me.PictureBox1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.PictureBox1.Location = New System.Drawing.Point(0, 0)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(1160, 708)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 0
        Me.PictureBox1.TabStop = False
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(644, 43)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(159, 43)
        Me.Button1.TabIndex = 17
        Me.Button1.Text = "Button1"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Button2
        '
        Me.Button2.Location = New System.Drawing.Point(475, 31)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(128, 63)
        Me.Button2.TabIndex = 18
        Me.Button2.Text = "Button2"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'frmMain
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Silver
        Me.ClientSize = New System.Drawing.Size(1160, 708)
        Me.Controls.Add(Me.Panel3)
        Me.Name = "frmMain"
        Me.Text = "frmMain"
        Me.GroupBox1.ResumeLayout(False)
        Me.gbArchivos.ResumeLayout(False)
        Me.Panel3.ResumeLayout(False)
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents btnInformeExpedientes As Button
    Friend WithEvents btnInformeJuzgados As Button
    Friend WithEvents gbArchivos As GroupBox
    Friend WithEvents btnExpedientes As Button
    Friend WithEvents btnJuzgados As Button
    Friend WithEvents btnEstados As Button
    Friend WithEvents btnLocalidades As Button
    Friend WithEvents btnClientes As Button
    Friend WithEvents btnJuicios As Button
    Friend WithEvents Panel3 As Panel
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents PictureBox2 As PictureBox
    Friend WithEvents Button2 As Button
    Friend WithEvents Button1 As Button
End Class
