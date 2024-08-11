Public Class frmJuzgados
    Private Sub frmLocalidades_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        llenarJuzgados()
    End Sub
    Private Sub llenarJuzgados()
        Dim sql As String = "SELECT Codigo_Juzgado AS CODIGO, 
	                                Nombre_Juez AS JUEZ, 
	                                Secretario AS SECRETARIO, TELEFONO AS TELEFONO, 
	                                Fecha_Alta AS FECHA_ALTA, LOCALIDAD AS LOCALIDAD 
                                FROM JUZGADOS
                                INNER JOIN LOCALIDADES ON JUZGADOS.CP=LOCALIDADES.CP"
        Dim ds As New DataSet
        Dim adp As New SqlClient.SqlDataAdapter(sql, Conexion.conexion)

        ds.Tables.Add("Juzgados")
        adp.Fill(ds.Tables("Juzgados"))
        Me.dgvJuzgados.DataSource = ds.Tables("Juzgados")
    End Sub

    Private Sub btnSelectLoc_Click(sender As Object, e As EventArgs) Handles btnSelectLoc.Click
        flag_where = 1
        Dim frm As New frmLocalidades
        AddOwnedForm(frm)
        frm.ShowDialog()
    End Sub

    Private Sub btnNuevo_Click(sender As Object, e As EventArgs) Handles btnNuevo.Click
        flag_abm = 1 'ALTA
        'Me.Height = 610
        limpiar()
        Me.txtCodigo.Enabled = True
        Me.txtJuez.Enabled = True
        Me.txtSecretario.Enabled = True
        Me.txtTelefono.Enabled = True
        Me.txtFecha.Enabled = True
        Me.txtLocalidad.Enabled = True
        Me.txtJuez.Focus()

        generarIdJuzgado()
    End Sub
    'NUEVA Marca
    Private Sub nuevoJuzgado()
        cmd.Connection = Conexion.conexion
        cmd.CommandType = CommandType.Text
        Dim sql As String = "INSERT INTO Juzgados (codigo_Juzgado, nombre_Juez, Secretario, Telefono, Fecha_alta, cp) " &
                   "VALUES ('" & Me.txtCodigo.Text & "','" & Me.txtJuez.Text & "','" & Me.txtSecretario.Text & "'," &
                   "'" & Me.txtTelefono.Text & "','" & Me.txtFecha.Text & "', (SELECT cp FROM localidades WHERE localidad = '" & Me.txtLocalidad.Text & "'))"

        cmd.CommandText = sql

        'validacion
        If Me.txtCodigo.Text <> "" Then
            If Me.txtJuez.Text <> "" Then
                If Me.txtSecretario.Text <> "" Then
                    If Me.txtTelefono.Text <> "" Then
                        If Me.txtFecha.Text <> "" Then
                            If Me.txtLocalidad.Text <> "" Then
                                Try
                                    cmd.ExecuteNonQuery()
                                    Console.Beep()
                                    llenarJuzgados()
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
                    MsgBox("El campo SECRETARIO no puede estar vacio.", MsgBoxStyle.Critical, "Error")
                    Me.txtSecretario.Focus()
                End If
            Else
                MsgBox("El campo JUEZ no puede estar vacio.", MsgBoxStyle.Critical, "Error")
                Me.txtJuez.Focus()
            End If

        Else
            MsgBox("El campo CCODIGO no puede estar vacio.", MsgBoxStyle.Critical, "Error")
            Me.txtCodigo.Focus()
        End If
    End Sub

    Private Sub btnModificar_Click(sender As Object, e As EventArgs) Handles btnModificar.Click
        'flag_abm = 2 'UPDATE
        ''Me.Height = 610
        'wcp = Me.dgvJuzgados.CurrentRow.Cells(0).Value
        'Me.txtCodigo.Text = wcp

        'Me.txtJuez.Text = Me.dgvJuzgados.CurrentRow.Cells(1).Value.ToString
        'Me.txtJuez.Enabled = True
        'Me.txtJuez.Focus()

        'Me.txtSecretario.Text = Me.dgvJuzgados.CurrentRow.Cells(2).Value.ToString
        'Me.txtSecretario.Enabled = True
        'Me.txtSecretario.Focus()

        'Me.txtTelefono.Text = Me.dgvJuzgados.CurrentRow.Cells(3).Value.ToString
        'Me.txtTelefono.Enabled = True
        'Me.txtTelefono.Focus()

        'Me.txtFecha.Text = Me.dgvJuzgados.CurrentRow.Cells(4).Value.ToString
        'Me.txtFecha.Enabled = True
        'Me.txtFecha.Focus()

        'Me.txtLocalidad.Text = Me.dgvJuzgados.CurrentRow.Cells(5).Value.ToString
        'Me.txtLocalidad.Enabled = True
        'Me.txtLocalidad.Focus()
    End Sub
    'UPDATE  Localidades
    Private Sub updateJuzgados()
        cmd.Connection = Conexion.conexion
        cmd.CommandType = CommandType.Text
        Dim sql As String = "update juzgados set codigo_Juzgado = " & Me.txtCodigo.Text & ",
                                                 nombre_Juez = '" & Me.txtJuez.Text & "',
                                                 secretario = '" & Me.txtSecretario.Text & "',
                                                 telefono = " & Me.txtTelefono.Text & ",
                                                 fecha_alta = '" & Me.txtFecha.Text & "',                                                                                  
                                                cp = (SELECT cp FROM localidades WHERE localidad = '" & Me.txtLocalidad.Text & "')
                             where codigo_Juzgado = " & wcp & ""

        cmd.CommandText = sql
        'validacion
        If Me.txtLocalidad.Text <> "" Then
            Try
                cmd.ExecuteNonQuery()
                Console.Beep()
                llenarJuzgados()
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
        If flag_abm = 1 Then 'ALTA
            nuevoJuzgado()
        ElseIf flag_abm = 2 Then 'UPDATE
            updateJuzgados()
        ElseIf flag_abm = 3 Then 'DELETE
            MsgBox("Eliminar Juzgado")
            deleteJuzgados()
        End If
        Me.txtCodigo.Enabled = False
        Me.txtJuez.Enabled = False
        Me.txtSecretario.Enabled = False
        Me.txtTelefono.Enabled = False
        Me.txtFecha.Enabled = False
        Me.txtLocalidad.Enabled = False
    End Sub

    Private Sub btnEliminar_Click(sender As Object, e As EventArgs) Handles btnEliminar.Click
        flag_abm = 3 'DELETE
        'Me.Height = 610
        wcp = Me.dgvJuzgados.CurrentRow.Cells(0).Value
        Me.txtCodigo.Text = wcp

        Me.txtJuez.Text = Me.dgvJuzgados.CurrentRow.Cells(1).Value.ToString
        'MsgBox("Eliminar Juez")
        Me.txtJuez.Enabled = True

        Me.txtSecretario.Text = Me.dgvJuzgados.CurrentRow.Cells(2).Value.ToString
        ' MsgBox("Eliminar Secretario")
        Me.txtSecretario.Enabled = True

        Me.txtTelefono.Text = Me.dgvJuzgados.CurrentRow.Cells(3).Value.ToString
        'MsgBox("Eliminar Telefono")
        Me.txtTelefono.Enabled = True

        Me.txtFecha.Text = Me.dgvJuzgados.CurrentRow.Cells(4).Value.ToString
        'MsgBox("Eliminar Fecha de Alta")
        Me.txtFecha.Enabled = True

        Me.txtLocalidad.Text = Me.dgvJuzgados.CurrentRow.Cells(5).Value.ToString
        'MsgBox("Eliminar Juzgado")
        Me.txtLocalidad.Enabled = True
    End Sub
    'DELETE Localidades
    Private Sub deleteJuzgados()
        cmd.Connection = Conexion.conexion
        cmd.CommandType = CommandType.Text
        Dim sql As String = "delete from Juzgados where Codigo_Juzgado = '" & wcp & "'"

        cmd.CommandText = sql
        Try
            cmd.ExecuteNonQuery()
            Console.Beep()
            llenarJuzgados()
            Me.txtCodigo.Clear()
            Me.btnListo.Visible = False
        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try
    End Sub

    Private Sub generarIdJuzgado() ' funcion para numero autoincrementar al agregar un juzgado nuevo
        cmd.Connection = Conexion.conexion
        cmd.CommandType = CommandType.Text
        Dim sql As String = "select max(codigo_juzgado) from juzgados"
        cmd.CommandText = sql
        dr = cmd.ExecuteReader()
        Try
            If dr.HasRows Then
                While dr.Read
                    If IsDBNull(dr(0)) Then
                        wid_juzgado = 1
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
        Me.txtJuez.Clear()
        Me.txtSecretario.Clear()
        Me.txtTelefono.Clear()
        Me.txtFecha.Clear()
        Me.txtLocalidad.Clear()
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


End Class