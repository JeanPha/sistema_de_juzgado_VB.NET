<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmLogin
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
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.btnSalir = New System.Windows.Forms.Button()
        Me.txtPsw = New System.Windows.Forms.TextBox()
        Me.btnIngresar = New System.Windows.Forms.Button()
        Me.txtUsuario = New System.Windows.Forms.TextBox()
        Me.txtIdcaja = New System.Windows.Forms.TextBox()
        Me.lbEnterPsw = New System.Windows.Forms.Label()
        Me.lbEnterUsuario = New System.Windows.Forms.Label()
        Me.lbcontrasena = New System.Windows.Forms.Label()
        Me.lbUsuario = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.lbPsw = New System.Windows.Forms.Label()
        Me.lbApellidoNombre = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Panel1.SuspendLayout()
        Me.Panel2.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.Label2)
        Me.Panel1.Controls.Add(Me.btnSalir)
        Me.Panel1.Controls.Add(Me.txtPsw)
        Me.Panel1.Controls.Add(Me.btnIngresar)
        Me.Panel1.Controls.Add(Me.txtUsuario)
        Me.Panel1.Controls.Add(Me.txtIdcaja)
        Me.Panel1.Controls.Add(Me.lbEnterPsw)
        Me.Panel1.Controls.Add(Me.lbEnterUsuario)
        Me.Panel1.Controls.Add(Me.lbcontrasena)
        Me.Panel1.Controls.Add(Me.lbUsuario)
        Me.Panel1.Controls.Add(Me.Label4)
        Me.Panel1.Controls.Add(Me.lbPsw)
        Me.Panel1.Controls.Add(Me.lbApellidoNombre)
        Me.Panel1.Controls.Add(Me.Label1)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(953, 397)
        Me.Panel1.TabIndex = 28
        '
        'Panel2
        '
        Me.Panel2.Controls.Add(Me.PictureBox1)
        Me.Panel2.Dock = System.Windows.Forms.DockStyle.Left
        Me.Panel2.Location = New System.Drawing.Point(0, 0)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(363, 397)
        Me.Panel2.TabIndex = 29
        '
        'PictureBox1
        '
        Me.PictureBox1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.PictureBox1.Image = Global.sys_Juzgados.My.Resources.Resources.Lock_512
        Me.PictureBox1.Location = New System.Drawing.Point(0, 0)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(363, 397)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 0
        Me.PictureBox1.TabStop = False
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.Navy
        Me.Label2.Location = New System.Drawing.Point(527, 125)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(58, 20)
        Me.Label2.TabIndex = 27
        Me.Label2.Text = "*enter"
        '
        'btnSalir
        '
        Me.btnSalir.BackColor = System.Drawing.Color.Salmon
        Me.btnSalir.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSalir.ForeColor = System.Drawing.Color.Navy
        Me.btnSalir.Location = New System.Drawing.Point(401, 312)
        Me.btnSalir.Name = "btnSalir"
        Me.btnSalir.Size = New System.Drawing.Size(230, 57)
        Me.btnSalir.TabIndex = 26
        Me.btnSalir.Text = "salir"
        Me.btnSalir.UseVisualStyleBackColor = False
        '
        'txtPsw
        '
        Me.txtPsw.Location = New System.Drawing.Point(531, 241)
        Me.txtPsw.Name = "txtPsw"
        Me.txtPsw.Size = New System.Drawing.Size(210, 26)
        Me.txtPsw.TabIndex = 25
        Me.txtPsw.Visible = False
        '
        'btnIngresar
        '
        Me.btnIngresar.BackColor = System.Drawing.Color.LightGreen
        Me.btnIngresar.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnIngresar.ForeColor = System.Drawing.Color.Navy
        Me.btnIngresar.Location = New System.Drawing.Point(687, 312)
        Me.btnIngresar.Name = "btnIngresar"
        Me.btnIngresar.Size = New System.Drawing.Size(230, 57)
        Me.btnIngresar.TabIndex = 24
        Me.btnIngresar.Text = "Ingresar"
        Me.btnIngresar.UseVisualStyleBackColor = False
        Me.btnIngresar.Visible = False
        '
        'txtUsuario
        '
        Me.txtUsuario.Location = New System.Drawing.Point(531, 163)
        Me.txtUsuario.Name = "txtUsuario"
        Me.txtUsuario.Size = New System.Drawing.Size(210, 26)
        Me.txtUsuario.TabIndex = 23
        Me.txtUsuario.Visible = False
        '
        'txtIdcaja
        '
        Me.txtIdcaja.Location = New System.Drawing.Point(531, 96)
        Me.txtIdcaja.Name = "txtIdcaja"
        Me.txtIdcaja.Size = New System.Drawing.Size(60, 26)
        Me.txtIdcaja.TabIndex = 22
        '
        'lbEnterPsw
        '
        Me.lbEnterPsw.AutoSize = True
        Me.lbEnterPsw.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbEnterPsw.ForeColor = System.Drawing.Color.Navy
        Me.lbEnterPsw.Location = New System.Drawing.Point(527, 270)
        Me.lbEnterPsw.Name = "lbEnterPsw"
        Me.lbEnterPsw.Size = New System.Drawing.Size(58, 20)
        Me.lbEnterPsw.TabIndex = 21
        Me.lbEnterPsw.Text = "*enter"
        Me.lbEnterPsw.Visible = False
        '
        'lbEnterUsuario
        '
        Me.lbEnterUsuario.AutoSize = True
        Me.lbEnterUsuario.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbEnterUsuario.ForeColor = System.Drawing.Color.Navy
        Me.lbEnterUsuario.Location = New System.Drawing.Point(527, 192)
        Me.lbEnterUsuario.Name = "lbEnterUsuario"
        Me.lbEnterUsuario.Size = New System.Drawing.Size(58, 20)
        Me.lbEnterUsuario.TabIndex = 20
        Me.lbEnterUsuario.Text = "*enter"
        Me.lbEnterUsuario.Visible = False
        '
        'lbcontrasena
        '
        Me.lbcontrasena.AutoSize = True
        Me.lbcontrasena.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbcontrasena.ForeColor = System.Drawing.Color.Navy
        Me.lbcontrasena.Location = New System.Drawing.Point(408, 247)
        Me.lbcontrasena.Name = "lbcontrasena"
        Me.lbcontrasena.Size = New System.Drawing.Size(102, 20)
        Me.lbcontrasena.TabIndex = 19
        Me.lbcontrasena.Text = "Contraseña"
        Me.lbcontrasena.Visible = False
        '
        'lbUsuario
        '
        Me.lbUsuario.AutoSize = True
        Me.lbUsuario.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbUsuario.ForeColor = System.Drawing.Color.Navy
        Me.lbUsuario.Location = New System.Drawing.Point(439, 169)
        Me.lbUsuario.Name = "lbUsuario"
        Me.lbUsuario.Size = New System.Drawing.Size(71, 20)
        Me.lbUsuario.TabIndex = 18
        Me.lbUsuario.Text = "Usuario"
        Me.lbUsuario.Visible = False
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.Navy
        Me.Label4.Location = New System.Drawing.Point(418, 102)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(92, 20)
        Me.Label4.TabIndex = 17
        Me.Label4.Text = "DISTRITO"
        '
        'lbPsw
        '
        Me.lbPsw.AutoSize = True
        Me.lbPsw.ForeColor = System.Drawing.Color.Navy
        Me.lbPsw.Location = New System.Drawing.Point(747, 247)
        Me.lbPsw.Name = "lbPsw"
        Me.lbPsw.Size = New System.Drawing.Size(38, 20)
        Me.lbPsw.TabIndex = 16
        Me.lbPsw.Text = "Psw"
        Me.lbPsw.Visible = False
        '
        'lbApellidoNombre
        '
        Me.lbApellidoNombre.AutoSize = True
        Me.lbApellidoNombre.ForeColor = System.Drawing.Color.Navy
        Me.lbApellidoNombre.Location = New System.Drawing.Point(747, 169)
        Me.lbApellidoNombre.Name = "lbApellidoNombre"
        Me.lbApellidoNombre.Size = New System.Drawing.Size(145, 20)
        Me.lbApellidoNombre.TabIndex = 15
        Me.lbApellidoNombre.Text = "Apellido y nNombre"
        Me.lbApellidoNombre.Visible = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.Navy
        Me.Label1.Location = New System.Drawing.Point(478, 26)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(399, 29)
        Me.Label1.TabIndex = 14
        Me.Label1.Text = "IDENTIFICACION DE USUARIOS"
        '
        'frmLogin
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Silver
        Me.ClientSize = New System.Drawing.Size(953, 397)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.Panel1)
        Me.Name = "frmLogin"
        Me.Text = "frmLogin"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.Panel2.ResumeLayout(False)
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Panel1 As Panel
    Friend WithEvents Panel2 As Panel
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents Label2 As Label
    Friend WithEvents btnSalir As Button
    Friend WithEvents txtPsw As TextBox
    Friend WithEvents btnIngresar As Button
    Friend WithEvents txtUsuario As TextBox
    Friend WithEvents txtIdcaja As TextBox
    Friend WithEvents lbEnterPsw As Label
    Friend WithEvents lbEnterUsuario As Label
    Friend WithEvents lbcontrasena As Label
    Friend WithEvents lbUsuario As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents lbPsw As Label
    Friend WithEvents lbApellidoNombre As Label
    Friend WithEvents Label1 As Label
End Class
