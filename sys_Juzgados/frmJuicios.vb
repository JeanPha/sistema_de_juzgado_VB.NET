Public Class frmJuicios
    Private Sub frmJuicios_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        llenarJuicios()
    End Sub
    Private Sub llenarJuicios()
        Dim sql As String = "select codigo_juicio as CODICGO_JUICIO ,descripcion_juicio as DESCRIPCION from juicios"
        Dim ds As New DataSet
        Dim adp As New SqlClient.SqlDataAdapter(sql, Conexion.conexion)

        ds.Tables.Add("Juicios")
        adp.Fill(ds.Tables("Juicios"))
        Me.dgvJuicios.DataSource = ds.Tables("Juicios")
    End Sub

    Private Sub btnNuevo_Click(sender As Object, e As EventArgs) Handles btnNuevo.Click
        generarIdJuicio()

        flag_abm = 1 'ALTA
        Me.txtCodigo.Enabled = True
        Me.txtDescripcion.Enabled = True
        Me.txtCodigo.Focus()
    End Sub
    'NUEVA Marca
    Private Sub nuevoJuicio()
        cmd.Connection = Conexion.conexion
        cmd.CommandType = CommandType.Text
        Dim sql As String = "insert into localidades values ('" & Me.txtCodigo.Text & "','" & Me.txtDescripcion.Text & "')"
        cmd.CommandText = sql

        'validacion
        If Me.txtCodigo.Text <> "" Then
            If Me.txtDescripcion.Text <> "" Then
                Try
                    cmd.ExecuteNonQuery()
                    Console.Beep()
                    llenarJuicios()
                    Me.txtCodigo.Clear()
                    Me.txtDescripcion.Clear()
                    Me.btnListo.Visible = False
                Catch ex As Exception
                    MsgBox(ex.ToString)
                End Try
            Else
                MsgBox("El campo DESCRIPCION no puede estar vacio.", MsgBoxStyle.Critical, "Error")
                Me.txtDescripcion.Focus()
            End If
        Else
            MsgBox("El campo CODIGO no puede estar vacio.", MsgBoxStyle.Critical, "Error")
            Me.txtCodigo.Focus()
        End If
    End Sub

    Private Sub btnListo_Click(sender As Object, e As EventArgs) Handles btnListo.Click
        If flag_abm = 1 Then 'ALTA
            nuevoJuicio()
        ElseIf flag_abm = 2 Then 'UPDATE
            updateJuicios()
        ElseIf flag_abm = 3 Then 'DELETE
            MsgBox("DESEAS ELIMINAR EL JUICIO ")
            deleteJuicios()
        End If
        Me.txtCodigo.Enabled = False
        Me.txtDescripcion.Enabled = False
    End Sub

    Private Sub btnModificar_Click(sender As Object, e As EventArgs) Handles btnModificar.Click
        flag_abm = 2 'UPDATE
        wcp = Me.dgvJuicios.CurrentRow.Cells(0).Value
        Me.txtCodigo.Text = wcp
        Me.txtDescripcion.Text = Me.dgvJuicios.CurrentRow.Cells(1).Value.ToString
        Me.txtDescripcion.Enabled = True
        Me.txtDescripcion.Focus()
    End Sub
    'UPDATE  Localidades
    Private Sub updateJuicios()
        cmd.Connection = Conexion.conexion
        cmd.CommandType = CommandType.Text
        Dim sql As String = "update juicios set descripcion_juicio = '" & Me.txtDescripcion.Text & "' where codigo_juicio = '" & wcp & "'"

        cmd.CommandText = sql
        'validacion
        If Me.txtDescripcion.Text <> "" Then
            Try
                cmd.ExecuteNonQuery()
                Console.Beep()
                llenarJuicios()
                Me.txtCodigo.Clear()
                Me.txtDescripcion.Clear()
                Me.btnListo.Visible = False
            Catch ex As Exception
                MsgBox(ex.ToString)
            End Try
        Else
            MsgBox("El campo DESCRIPCION no puede estar vacio.", MsgBoxStyle.Critical, "Error")
            Me.txtDescripcion.Focus()
        End If
    End Sub

    Private Sub btnEliminar_Click(sender As Object, e As EventArgs) Handles btnEliminar.Click
        flag_abm = 3 'DELETE
        wcp = Me.dgvJuicios.CurrentRow.Cells(0).Value
        Me.txtCodigo.Text = wcp
        Me.txtDescripcion.Text = Me.dgvJuicios.CurrentRow.Cells(1).Value.ToString
        Me.txtDescripcion.Enabled = True
    End Sub
    'DELETE Localidades
    Private Sub deleteJuicios()
        cmd.Connection = Conexion.conexion
        cmd.CommandType = CommandType.Text
        Dim sql As String = "delete from juicios where codigo_juicio = '" & wcp & "'"

        cmd.CommandText = sql
        Try
            cmd.ExecuteNonQuery()
            Console.Beep()
            llenarJuicios()
            Me.txtCodigo.Clear()
            Me.btnListo.Visible = False
        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try
    End Sub
    Private Sub dgvJuicios_Keydown(sender As Object, e As KeyEventArgs) Handles dgvJuicios.KeyDown
        If flag_where = 4 Then
            If e.KeyCode = Keys.Enter Then
                Dim selectedRow = dgvJuicios.CurrentRow
                If selectedRow IsNot Nothing Then
                    Dim Juicio As String = selectedRow.Cells(1).Value.ToString()
                    Dim formExpedientes As frmExpedientes = Application.OpenForms("frmExpedientes")
                    If formExpedientes IsNot Nothing Then
                        Dim textBoxJuicio As TextBox = formExpedientes.Controls.Find("textBoxJuicio", True).FirstOrDefault()
                        If textBoxJuicio IsNot Nothing Then
                            textBoxJuicio.Text = Juicio
                            Dim formJuicios As frmJuicios = Application.OpenForms("frmJuicios")
                            If formJuicios IsNot Nothing Then
                                formJuicios.Close()
                            End If
                        End If
                    End If
                End If
            End If
        End If



    End Sub
    Private Sub generarIdJuicio() ' funcion para numero autoincrementar al agregar un juicio nuevo
        cmd.Connection = Conexion.conexion
        cmd.CommandType = CommandType.Text
        Dim sql As String = "select max(Codigo_Juicio) from JUICIOS"
        cmd.CommandText = sql
        dr = cmd.ExecuteReader()
        Try
            If dr.HasRows Then
                While dr.Read
                    If IsDBNull(dr(0)) Then
                        wid_juicio = 1
                    Else
                        wid_juicio = dr(0) + 1
                    End If
                End While
            Else
                MsgBox("hola")
            End If
            dr.Close()
        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try
        Me.txtCodigo.Text = wid_juicio
    End Sub

End Class