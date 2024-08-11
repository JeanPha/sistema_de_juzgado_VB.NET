Public Class frmExpedientes
    Private Sub frmExpedientes_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        llenarExpedientes()
    End Sub
    Private Sub llenarExpedientes()
        Dim sql As String = "select EXPEDIENTES.Codigo_Expediente as CODIGO, 
                    EXPEDIENTES.Fecha_Incicio AS FECHA_INICIO, 
                    EXPEDIENTES.Caratula AS CARATULA, 
                    ESTADOS.Descripcion AS ESTADO,
                    JUICIOS.Descripcion_Juicio AS JUICIO,
                    JUZGADOS.Nombre_Juez AS JUEZ,
                    CLIENTES.Nombre_Apellido AS CLIENTE 
                    from EXPEDIENTES
                    INNER JOIN ESTADOS ON EXPEDIENTES.Codigo_Estado = ESTADOS.Codigo_Estado
                    INNER JOIN JUICIOS ON EXPEDIENTES.Codigo_Juicio = JUICIOS.Codigo_Juicio
                    INNER JOIN JUZGADOS ON EXPEDIENTES.Codigo_Juzgado= JUZGADOS.Codigo_Juzgado
                    INNER JOIN CLIENTES ON EXPEDIENTES.Codigo_Cliente = CLIENTES.Codigo_Cliente;"
        Dim ds As New DataSet
        Dim adp As New SqlClient.SqlDataAdapter(sql, Conexion.conexion)

        ds.Tables.Add("Epedientes")
        adp.Fill(ds.Tables("Epedientes"))
        Me.dgvExpedientes.DataSource = ds.Tables("Epedientes")
    End Sub
    'Private Sub btnSelectLoc_Click(sender As Object, e As EventArgs) Handles btnSelectLoc.Click
    '    flag_where = 2
    '    Dim frm As New frmLocalidades
    '    AddOwnedForm(frm)
    '    frm.ShowDialog()
    'End Sub

    Private Sub btnNuevo_Click(sender As Object, e As EventArgs) Handles btnNuevo.Click
        flag_abm = 1 'ALTA
        'Me.Height = 610
        limpiar()
        Me.txtCodigo.Enabled = True
        Me.txtEstado.Enabled = True
        Me.txtJuicio.Enabled = True
        Me.txtCliente.Enabled = True
        Me.txtJuzgado.Enabled = True
        Me.txtFecha.Enabled = True
        Me.txtCaratula.Enabled = True
        Me.DateTimePicker1.Enabled = True
        Me.txtCaratula.Focus()

        generarIdExpediente()
    End Sub
    'NUEVA Marca
    Private Sub nuevoExpediente()
        cmd.Connection = Conexion.conexion
        cmd.CommandType = CommandType.Text
        Dim sql As String = "INSERT INTO Clientes (Codigo_Expediente, Fecha_Incicio, Caratula, Codigo_Estado, Codigo_Juicio, Codigo_Juzgado, Codigo_Cliente) " &
                   "VALUES ('" & Me.txtCodigo.Text & "','" & Me.txtFecha.Text & "','" & Me.txtCaratula.Text & "', 
                                                                                    (select codigo_estado from ESTADOS where Descripcion= " & Me.txtEstado.Text & "),
                                                                                    (select Codigo_Juicio from JUICIOS where Descripcion_Juicio= " & Me.txtJuicio.Text & "),
                                                                                    (select Codigo_Juzgado from JUZGADOS where Nombre_Juez= " & Me.txtJuzgado.Text & ")
                                                                                    (select Codigo_Cliente from clientes where Nombre_Apellido= " & Me.txtCliente.Text & ")
                                                                                    )"

        cmd.CommandText = sql

        'validacion
        If Me.txtCodigo.Text <> "" Then
            If Me.txtFecha.Text <> "" Then
                If Me.txtCaratula.Text <> "" Then
                    If Me.txtEstado.Text <> "" Then
                        If Me.txtJuicio.Text <> "" Then
                            If Me.txtJuzgado.Text <> "" Then
                                If Me.txtCliente.Text <> "" Then
                                    Try
                                        cmd.ExecuteNonQuery()
                                        Console.Beep()
                                        llenarExpedientes()
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
                                    Me.txtCliente.Focus()
                                End If
                                MsgBox("El campo LOCALIDAD no puede estar vacio.", MsgBoxStyle.Critical, "Error")
                                Me.txtJuzgado.Focus()
                            End If
                        Else
                            MsgBox("El campo FECHA no puede estar vacio.", MsgBoxStyle.Critical, "Error")
                            Me.txtJuicio.Focus()
                        End If
                    Else
                        MsgBox("El campo TELEFONO no puede estar vacio.", MsgBoxStyle.Critical, "Error")
                        Me.txtEstado.Focus()
                    End If
                Else
                    MsgBox("El campo NOMBRE no puede estar vacio.", MsgBoxStyle.Critical, "Error")
                    Me.txtCaratula.Focus()
                End If
            Else
                MsgBox("El campo NRO.DOC no puede estar vacio.", MsgBoxStyle.Critical, "Error")
                Me.txtFecha.Focus()
            End If

        Else
            MsgBox("El campo CCODIGO no puede estar vacio.", MsgBoxStyle.Critical, "Error")
            Me.txtCodigo.Focus()
        End If
    End Sub

    Private Sub btnModificar_Click(sender As Object, e As EventArgs) Handles btnModificar.Click
        flag_abm = 2 'UPDATE
        'Me.Height = 610
        wcp = Me.dgvExpedientes.CurrentRow.Cells(0).Value
        Me.txtCodigo.Text = wcp

        Me.txtFecha.Text = Me.dgvExpedientes.CurrentRow.Cells(1).Value.ToString
        Me.txtFecha.Enabled = True
        Me.txtFecha.Focus()

        Me.txtCaratula.Text = Me.dgvExpedientes.CurrentRow.Cells(2).Value.ToString
        Me.txtCaratula.Enabled = True
        Me.txtCaratula.Focus()


        Me.txtEstado.Text = Me.dgvExpedientes.CurrentRow.Cells(3).Value.ToString
        Me.txtEstado.Enabled = True
        Me.txtEstado.Focus()

        Me.txtJuicio.Text = Me.dgvExpedientes.CurrentRow.Cells(4).Value.ToString
        Me.txtJuicio.Enabled = True
        Me.txtJuicio.Focus()

        Me.txtJuzgado.Text = Me.dgvExpedientes.CurrentRow.Cells(5).Value.ToString
        Me.txtJuzgado.Enabled = True
        Me.txtJuzgado.Focus()

        Me.txtCliente.Text = Me.dgvExpedientes.CurrentRow.Cells(6).Value.ToString
        Me.txtCliente.Enabled = True
        Me.txtCliente.Focus()
    End Sub
    'UPDATE  expedientes 
    'falta completar
    Private Sub updateExpedientes()
        cmd.Connection = Conexion.conexion
        cmd.CommandType = CommandType.Text
        Dim sql As String = "update Expedientes set Codigo_Expediente = @Codigo, Fecha_Incicio = @Fecha, Caratula = @Caratula, codigo_estado = (select codigo_estado from ESTADOS where Descripcion= @Estado), Codigo_Juicio= (select Codigo_Juicio from ESTADOS where Descripcion_juicio = @Juicio), Codigo_Juzgado= (select Codigo_Juzgado from ESTADOS where Nombre_Juez = @Juzgado), Codigo_cliente= (select Codigo_cliente from ESTADOS where Nombre_Apellido = @Cliente) where Codigo_Expediente = @WCP"

        cmd.CommandText = sql

        ' Agregar parámetros
        cmd.Parameters.AddWithValue("@Codigo", Me.txtCodigo.Text)
        cmd.Parameters.AddWithValue("@Fecha", Me.txtFecha.Text)
        cmd.Parameters.AddWithValue("@Caratula", Me.txtCaratula.Text)
        cmd.Parameters.AddWithValue("@Estado", Me.txtEstado.Text)
        cmd.Parameters.AddWithValue("@Juicio", Me.txtJuicio.Text)
        cmd.Parameters.AddWithValue("@Juzgado", Me.txtJuzgado.Text)
        cmd.Parameters.AddWithValue("@Cliente", Me.txtCliente.Text)
        cmd.Parameters.AddWithValue("@WCP", wcp)

        'validacion
        If Me.txtEstado.Text <> "" Then
            Try
                cmd.ExecuteNonQuery()
                Console.Beep()
                llenarExpedientes()
                limpiar()
                Me.btnListo.Visible = False
            Catch ex As Exception
                MsgBox(ex.ToString)
            End Try
        Else
            MsgBox("El campo CODIGO ESTADO no puede estar vacio.", MsgBoxStyle.Critical, "Error")
            Me.txtEstado.Focus()
        End If
    End Sub

    Private Sub btnListo_Click(sender As Object, e As EventArgs) Handles btnListo.Click
        If flag_abm = 1 Then 'ALTA
            nuevoExpediente()
        ElseIf flag_abm = 2 Then 'UPDATE
            updateExpedientes()
        ElseIf flag_abm = 3 Then 'DELETE
            MsgBox("Eliminar Cliente")
            deleteExpediente()
        End If
        Me.txtCodigo.Enabled = False
        Me.txtEstado.Enabled = False
        Me.txtJuicio.Enabled = False
        Me.txtCliente.Enabled = False
        Me.txtJuzgado.Enabled = False
        Me.txtFecha.Enabled = False
        Me.txtCaratula.Enabled = False
        Me.DateTimePicker1.Enabled = False
    End Sub

    Private Sub btnEliminar_Click(sender As Object, e As EventArgs) Handles btnEliminar.Click
        flag_abm = 3 'DELETE
        'Me.Height = 610
        wcp = Me.dgvExpedientes.CurrentRow.Cells(0).Value
        Me.txtCodigo.Text = wcp

        Me.txtFecha.Text = Me.dgvExpedientes.CurrentRow.Cells(1).Value.ToString
        'MsgBox("Eliminar Juez")
        Me.txtFecha.Enabled = True

        Me.txtCaratula.Text = Me.dgvExpedientes.CurrentRow.Cells(2).Value.ToString
        ' MsgBox("Eliminar Secretario")
        Me.txtCaratula.Enabled = True

        Me.txtEstado.Text = Me.dgvExpedientes.CurrentRow.Cells(3).Value.ToString
        ' MsgBox("Eliminar Secretario")
        Me.txtEstado.Enabled = True

        Me.txtJuicio.Text = Me.dgvExpedientes.CurrentRow.Cells(4).Value.ToString
        'MsgBox("Eliminar Telefono")
        Me.txtJuicio.Enabled = True

        Me.txtJuzgado.Text = Me.dgvExpedientes.CurrentRow.Cells(5).Value.ToString
        'MsgBox("Eliminar Fecha de Alta")
        Me.txtJuzgado.Enabled = True

        Me.txtCliente.Text = Me.dgvExpedientes.CurrentRow.Cells(6).Value.ToString
        'MsgBox("Eliminar Juzgado")
        Me.txtCliente.Enabled = True
    End Sub
    'DELETE Localidades
    Private Sub deleteExpediente()
        cmd.Connection = Conexion.conexion
        cmd.CommandType = CommandType.Text
        Dim sql As String = "delete from Expedientes where Codigo_Expediente = '" & wcp & "'"

        cmd.CommandText = sql
        Try
            cmd.ExecuteNonQuery()
            Console.Beep()
            llenarExpedientes()
            Me.txtCodigo.Clear()
            Me.btnListo.Visible = False
        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try
    End Sub

    Private Sub generarIdExpediente() ' funcion para numero autoincrementar al agregar un juzgado nuevo
        cmd.Connection = Conexion.conexion
        cmd.CommandType = CommandType.Text
        Dim sql As String = "select max(Codigo_Expediente) from Expedientes"
        cmd.CommandText = sql
        dr = cmd.ExecuteReader()
        Try
            If dr.HasRows Then
                While dr.Read
                    If IsDBNull(dr(0)) Then
                        wid_juzgado = 401
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
        Me.txtFecha.Clear()
        Me.txtCaratula.Clear()
        Me.txtEstado.Clear()
        Me.txtJuicio.Clear()
        Me.txtJuzgado.Clear()
        Me.txtCliente.Clear()
    End Sub



    Private Sub txtFecha_Click(sender As Object, e As EventArgs) Handles txtFecha.Click
        DateTimePicker1.Location = New Point(txtFecha.Location.X, txtFecha.Location.Y + txtFecha.Height)
        DateTimePicker1.Visible = True
        DateTimePicker1.BringToFront()
    End Sub

    Private Sub DateTimePicker1_ValueChanged(sender As Object, e As EventArgs) Handles DateTimePicker1.ValueChanged
        txtFecha.Text = DateTimePicker1.Value.Date
        DateTimePicker1.Visible = False
    End Sub

    Private Sub btnEstado_Click(sender As Object, e As EventArgs) Handles btnEstado.Click
        flag_where = 3
        Dim frm As New frmEstados
        frm.ShowDialog()
    End Sub

    Private Sub btnJuicio_Click(sender As Object, e As EventArgs) Handles btnJuicio.Click
        flag_where = 4
        Dim frm As New frmJuicios
        frm.ShowDialog()
    End Sub

    Private Sub btnJuzgado_Click(sender As Object, e As EventArgs) Handles btnJuzgado.Click
        Dim frm As New frmJuzgados
        frm.ShowDialog()
    End Sub

    Private Sub btnCliente_Click(sender As Object, e As EventArgs) Handles btnCliente.Click
        Dim frm As New frmClientes
        frm.ShowDialog()
    End Sub
End Class