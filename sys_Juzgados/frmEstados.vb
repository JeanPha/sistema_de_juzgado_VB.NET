Imports sys_Juzgados.EJER5DataSetTableAdapters

Public Class frmEstados
    Private Sub frmEstados_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        llenarEstados()
    End Sub
    Private Sub llenarEstados()
        Dim sql As String = "select codigo_estado as CODICGO_ESTADO ,descripcion as DESCRIPCION from Estados"
        Dim ds As New DataSet
        Dim adp As New SqlClient.SqlDataAdapter(sql, Conexion.conexion)

        ds.Tables.Add("Estados")
        adp.Fill(ds.Tables("Estados"))
        Me.dgvEstados.DataSource = ds.Tables("Estados")
    End Sub

    Private Sub btnNuevo_Click(sender As Object, e As EventArgs) Handles btnNuevo.Click
        flag_abm = 1 'ALTA
        Me.txtCodigo.Enabled = True
        Me.txtDescripcion.Enabled = True
        Me.txtCodigo.Focus()
    End Sub
    'NUEVA Marca
    Private Sub nuevoEstado()
        cmd.Connection = Conexion.conexion
        cmd.CommandType = CommandType.Text
        Dim sql As String = "insert into Estados values ('" & Me.txtCodigo.Text & "','" & Me.txtDescripcion.Text & "')"
        cmd.CommandText = sql

        'validacion
        If Me.txtCodigo.Text <> "" Then
            If Me.txtDescripcion.Text <> "" Then
                Try
                    cmd.ExecuteNonQuery()
                    Console.Beep()
                    llenarEstados()
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
            nuevoEstado()
        ElseIf flag_abm = 2 Then 'UPDATE
            updateEstados()
        ElseIf flag_abm = 3 Then 'DELETE
            deleteEstados()
        End If
        Me.txtCodigo.Enabled = False
        Me.txtDescripcion.Enabled = False
    End Sub

    Private Sub btnModificar_Click(sender As Object, e As EventArgs) Handles btnModificar.Click
        flag_abm = 2 'UPDATE
        wcp = Me.dgvEstados.CurrentRow.Cells(0).Value
        Me.txtCodigo.Text = wcp
        Me.txtDescripcion.Text = Me.dgvEstados.CurrentRow.Cells(1).Value.ToString
        Me.txtDescripcion.Enabled = True
        Me.txtDescripcion.Focus()
    End Sub
    'UPDATE  Localidades
    Private Sub updateEstados()
        cmd.Connection = Conexion.conexion
        cmd.CommandType = CommandType.Text
        Dim sql As String = "update Estados set descripcion = '" & Me.txtDescripcion.Text & "' where Codigo_Estado = '" & wcp & "'"

        cmd.CommandText = sql
        'validacion
        If Me.txtDescripcion.Text <> "" Then
            Try
                cmd.ExecuteNonQuery()
                Console.Beep()
                llenarEstados()
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
        wcp = Me.dgvEstados.CurrentRow.Cells(0).Value
        Me.txtCodigo.Text = wcp
        Me.txtDescripcion.Text = Me.dgvEstados.CurrentRow.Cells(1).Value.ToString
        MsgBox("DESEAS ELIMINAR EL ESTADO ")
        Me.txtDescripcion.Enabled = True
    End Sub
    'DELETE Localidades
    Private Sub deleteEstados()
        cmd.Connection = Conexion.conexion
        cmd.CommandType = CommandType.Text
        Dim sql As String = "delete from Estados where codigo_estado = '" & wcp & "'"

        cmd.CommandText = sql
        Try
            cmd.ExecuteNonQuery()
            Console.Beep()
            llenarEstados()
            Me.txtCodigo.Clear()
            Me.btnListo.Visible = False
        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try
    End Sub

    Private Sub dgvEstados_Keydown(sender As Object, e As KeyEventArgs) Handles dgvEstados.KeyDown
        If flag_where = 3 Then
            If e.KeyCode = Keys.Enter Then
                Dim selectedRow = dgvEstados.CurrentRow
                If selectedRow IsNot Nothing Then
                    Dim Estado As String = selectedRow.Cells(1).Value.ToString()
                    Dim formExpedientes As frmExpedientes = Application.OpenForms("frmExpedientes")
                    If formExpedientes IsNot Nothing Then
                        Dim textBoxEstado As TextBox = formExpedientes.Controls.Find("txtcodEstado", True).FirstOrDefault()
                        If textBoxEstado IsNot Nothing Then
                            textBoxEstado.Text = Estado
                            Dim formEstados As frmEstados = Application.OpenForms("frmEstados")
                            If formEstados IsNot Nothing Then
                                formEstados.Close()
                            End If
                        End If
                    End If
                End If
            End If
        End If


    End Sub
End Class