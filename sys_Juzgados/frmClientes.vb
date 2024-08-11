Public Class frmClientes
    Private Sub frmclientes_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        llenarClientes()
    End Sub
    Private Sub llenarClientes()
        Dim sql As String = "SELECT 
    CLIENTES.Codigo_Cliente AS CODIGO,
    CLIENTES.Tipo_Nro_Doc AS DNI,
    CLIENTES.Nombre_Apellido AS NOMBRE,
    CLIENTES.Domicilio AS DOMICILIO,
    CLIENTES.Tel_TelCel AS TELEFONO,
    CLIENTES.Fecha_Nacimiento AS FECHA_NACIMIENTO,
    LOCALIDADES.LOCALIDAD AS LOCALIDAD
FROM CLIENTES
INNER JOIN LOCALIDADES ON CLIENTES.CP = LOCALIDADES.CP;"
        Dim ds As New DataSet
        Dim adp As New SqlClient.SqlDataAdapter(sql, Conexion.conexion)

        ds.Tables.Add("clientes")
        adp.Fill(ds.Tables("clientes"))
        Me.dgvClientes.DataSource = ds.Tables("clientes")
    End Sub
    Private Sub btnSelectLoc_Click(sender As Object, e As EventArgs) Handles btnSelectLoc.Click
        flag_where = 2
        Dim frm As New frmLocalidades
        AddOwnedForm(frm)
        frm.ShowDialog()
    End Sub

    Private Sub btnNuevo_Click(sender As Object, e As EventArgs) Handles btnNuevo.Click

    End Sub
    'NUEVA Marca
    Private Sub nuevoCliente()
        cmd.Connection = Conexion.conexion
        cmd.CommandType = CommandType.Text
        Dim sql As String = "INSERT INTO Clientes (Codigo_Cliente, Tipo_Nro_Doc, Nombre_Apellido, Domicilio, Tel_TelCel, Fecha_Nacimiento, CP) " &
                   "VALUES ('" & Me.txtCodigo.Text & "','" & Me.txtNroDoc.Text & "','" & Me.txtNombre.Text & "', '" & Me.txtDomicilio.Text & "'," &
                   "'" & Me.txtTelefono.Text & "','" & Me.txtFecha.Text & "', (SELECT cp FROM localidades WHERE localidad = '" & Me.txtLocalidad.Text & "'))"

        cmd.CommandText = sql

        'validacion
        If Me.txtCodigo.Text <> "" Then
            If Me.txtNroDoc.Text <> "" Then
                If Me.txtNombre.Text <> "" Then
                    If Me.txtTelefono.Text <> "" Then
                        If Me.txtFecha.Text <> "" Then
                            If Me.txtLocalidad.Text <> "" Then
                                If Me.txtDomicilio.Text <> "" Then
                                    Try
                                        cmd.ExecuteNonQuery()
                                        Console.Beep()
                                        llenarClientes()
                                        limpiar()

                                        'Me.txtCodigo.Clear()
                                        'Me.txtJuez.Clear()
                                        'Me.txtSecretario.Clear()
                                        'Me.txtTelefono.Clear()
                                        'Me.txtFecha.Clear()
                                        'Me.txtLocalidad.Clear()
                                        'Me.btnListo.Visible = False
                                    Catch ex As Exception
                                        MsgBox(ex.ToString)
                                    End Try
                                Else
                                    MsgBox("El campo DOMICILIO no puede estar vacio.", MsgBoxStyle.Critical, "Error")
                                    Me.txtDomicilio.Focus()
                                End If
                                MsgBox("El campo LOCALIDAD no puede estar vacio.", MsgBoxStyle.Critical, "Error")
                                Me.txtLocalidad.Focus()
                            End If
                        Else
                            MsgBox("El campo FECHA no puede estar vacio.", MsgBoxStyle.Critical, "Error")
                            Me.txtFecha.Focus()
                        End If
                    Else
                        MsgBox("El campo TELEFONO no puede estar vacio.", MsgBoxStyle.Critical, "Error")
                        Me.txtTelefono.Focus()
                    End If
                Else
                    MsgBox("El campo NOMBRE no puede estar vacio.", MsgBoxStyle.Critical, "Error")
                    Me.txtNombre.Focus()
                End If
            Else
                MsgBox("El campo NRO.DOC no puede estar vacio.", MsgBoxStyle.Critical, "Error")
                Me.txtNroDoc.Focus()
            End If

        Else
            MsgBox("El campo CCODIGO no puede estar vacio.", MsgBoxStyle.Critical, "Error")
            Me.txtCodigo.Focus()
        End If
    End Sub

    Private Sub btnModificar_Click(sender As Object, e As EventArgs) Handles btnModificar.Click

    End Sub
    'UPDATE  Localidades
    Private Sub updateClientes()
        cmd.Connection = Conexion.conexion
        cmd.CommandType = CommandType.Text
        Dim sql As String = "update Clientes set Codigo_Cliente = " & Me.txtCodigo.Text & ",
                                                 Tipo_Nro_Doc = '" & Me.txtNroDoc.Text & "',
                                                 Nombre_Apellido = '" & Me.txtNombre.Text & "',
                                                 Domicilio='" & Me.txtDomicilio.Text & "',
                                                 Tel_TelCel = " & Me.txtTelefono.Text & ",
                                                 Fecha_Nacimiento = '" & Me.txtFecha.Text & "',                                                                                  
                                                cp = (SELECT cp FROM localidades WHERE localidad = '" & Me.txtLocalidad.Text & "')
                             where Codigo_Cliente = " & wcp & ""

        cmd.CommandText = sql
        'validacion
        If Me.txtLocalidad.Text <> "" Then
            Try
                cmd.ExecuteNonQuery()
                Console.Beep()
                llenarClientes()
                limpiar()
                Me.btnListo.Visible = False
            Catch ex As Exception
                MsgBox(ex.ToString)
            End Try
        Else
            MsgBox("El campo LOCALIDAD no puede estar vacio.", MsgBoxStyle.Critical, "Error")
            Me.txtLocalidad.Focus()
        End If
    End Sub

    Private Sub btnListo_Click(sender As Object, e As EventArgs) Handles btnListo.Click

    End Sub

    Private Sub btnEliminar_Click(sender As Object, e As EventArgs) Handles btnEliminar.Click

    End Sub
    'DELETE Localidades
    Private Sub deletecliente()
        cmd.Connection = Conexion.conexion
        cmd.CommandType = CommandType.Text
        Dim sql As String = "delete from Clientes where Codigo_Cliente = '" & wcp & "'"

        cmd.CommandText = sql
        Try
            cmd.ExecuteNonQuery()
            Console.Beep()
            llenarClientes()
            Me.txtCodigo.Clear()
            Me.btnListo.Visible = False
        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try
    End Sub

    Private Sub generarIdCliente() ' funcion para numero autoincrementar al agregar un juzgado nuevo
        cmd.Connection = Conexion.conexion
        cmd.CommandType = CommandType.Text
        Dim sql As String = "select max(Codigo_Cliente) from Clientes"
        cmd.CommandText = sql
        dr = cmd.ExecuteReader()
        Try
            If dr.HasRows Then
                While dr.Read
                    If IsDBNull(dr(0)) Then
                        wid_juzgado = 301
                    Else
                        wid_juzgado = dr(0) + 1
                    End If
                End While
            Else
                MsgBox("hola")
            End If
            dr.Close()
        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try
        Me.txtCodigo.Text = wid_juzgado
    End Sub

    Private Sub limpiar()
        Me.txtCodigo.Clear()
        Me.txtNroDoc.Clear()
        Me.txtNombre.Clear()
        Me.txtDomicilio.Clear()
        Me.txtTelefono.Clear()
        Me.txtFecha.Clear()
        Me.txtLocalidad.Clear()
    End Sub



    Private Sub txtFecha_Click(sender As Object, e As EventArgs) Handles txtFecha.Click

    End Sub

    Private Sub DateTimePicker1_ValueChanged(sender As Object, e As EventArgs) Handles DateTimePicker1.ValueChanged

    End Sub


End Class