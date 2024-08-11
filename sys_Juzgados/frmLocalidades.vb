Imports System.Diagnostics.Eventing.Reader
Public Class frmLocalidades
    Private Sub frmLocalidades_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        llenarLocalidades()
        If flag_where = 1 Then
            Esconder()
            Me.Height = 400
            Me.Width = 510
        ElseIf flag_where = 2 Then
            Esconder()
            Me.Height = 400
            Me.Width = 510
        End If
    End Sub

    Private Sub llenarLocalidades()
        Dim sql As String = "select cp as CODICGO_POSTAL ,localidad as LOCALIDAD from localidades"
        Dim ds As New DataSet
        Dim adp As New SqlClient.SqlDataAdapter(sql, Conexion.conexion)

        ds.Tables.Add("localidades")
        adp.Fill(ds.Tables("localidades"))
        Me.dgvLocalidades.DataSource = ds.Tables("localidades")
    End Sub

    Private Sub btnNuevo_Click(sender As Object, e As EventArgs) Handles btnNuevo.Click
        flag_abm = 1 'ALTA
        Me.txtCp.Enabled = True
        Me.txtLocalidad.Enabled = True
        Me.txtCp.Focus()
    End Sub
    'NUEVA Marca
    Private Sub nuevaLocalidad()
        cmd.Connection = Conexion.conexion
        cmd.CommandType = CommandType.Text
        Dim sql As String = "insert into localidades values ('" & Me.txtCp.Text & "','" & Me.txtLocalidad.Text & "')"
        cmd.CommandText = sql

        'validacion
        If Me.txtCp.Text <> "" Then
            If Me.txtLocalidad.Text <> "" Then
                Try
                    cmd.ExecuteNonQuery()
                    Console.Beep()
                    llenarLocalidades()
                    Me.txtCp.Clear()
                    Me.txtLocalidad.Clear()
                    Me.btnListo.Visible = False
                Catch ex As Exception
                    MsgBox(ex.ToString)
                End Try
            Else
                MsgBox("El campo LOCALIDAD no puede estar vacio.", MsgBoxStyle.Critical, "Error")
                Me.txtLocalidad.Focus()
            End If
        Else
            MsgBox("El campo CP no puede estar vacio.", MsgBoxStyle.Critical, "Error")
            Me.txtCp.Focus()
        End If
    End Sub

    Private Sub btnListo_Click(sender As Object, e As EventArgs) Handles btnListo.Click
        If flag_abm = 1 Then 'ALTA
            nuevaLocalidad()
        ElseIf flag_abm = 2 Then 'UPDATE
            updateLocalidades()
        ElseIf flag_abm = 3 Then 'DELETE
            MsgBox("Eliminar Localidad")
            deleteLocalidades()
        End If
        Me.txtCp.Enabled = False
        Me.txtLocalidad.Enabled = False
    End Sub

    Private Sub btnModificar_Click(sender As Object, e As EventArgs) Handles btnModificar.Click
        flag_abm = 2 'UPDATE
        wcp = Me.dgvLocalidades.CurrentRow.Cells(0).Value
        Me.txtCp.Text = wcp
        Me.txtLocalidad.Text = Me.dgvLocalidades.CurrentRow.Cells(1).Value.ToString
        Me.txtLocalidad.Enabled = True
        Me.txtLocalidad.Focus()
    End Sub
    'UPDATE  Localidades
    Private Sub updateLocalidades()
        cmd.Connection = Conexion.conexion
        cmd.CommandType = CommandType.Text
        Dim sql As String = "update localidades set localidad = '" & Me.txtLocalidad.Text & "' where cp = '" & wcp & "'"

        cmd.CommandText = sql
        'validacion
        If Me.txtLocalidad.Text <> "" Then
            Try
                cmd.ExecuteNonQuery()
                Console.Beep()
                llenarLocalidades()
                Me.txtCp.Clear()
                Me.txtLocalidad.Clear()
                Me.btnListo.Visible = False
            Catch ex As Exception
                MsgBox(ex.ToString)
            End Try
        Else
            MsgBox("El campo LOCALIDAD no puede estar vacio.", MsgBoxStyle.Critical, "Error")
            Me.txtLocalidad.Focus()
        End If
    End Sub

    Private Sub btnEliminar_Click(sender As Object, e As EventArgs) Handles btnEliminar.Click
        flag_abm = 3 'DELETE
        wcp = Me.dgvLocalidades.CurrentRow.Cells(0).Value
        Me.txtCp.Text = wcp
        Me.txtLocalidad.Text = Me.dgvLocalidades.CurrentRow.Cells(1).Value.ToString
        Me.txtLocalidad.Enabled = True
    End Sub
    'DELETE Localidades
    Private Sub deleteLocalidades()
        cmd.Connection = Conexion.conexion
        cmd.CommandType = CommandType.Text
        Dim sql As String = "delete from localidades where cp = '" & wcp & "'"

        cmd.CommandText = sql
        Try
            cmd.ExecuteNonQuery()
            Console.Beep()
            llenarLocalidades()
            Me.txtCp.Clear()
            Me.btnListo.Visible = False
        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try
    End Sub



    'Private Sub dgvLocalidades_KeyDown(sender As Object, e As KeyEventArgs)
    '    If flag_where = 1 Then
    '        If e.KeyData = Keys.Enter Then 'ENVIAR EL VALOR AL FORMULARIO JUZGADOS
    '            Dim frm As frmJuzgados = CType(Owner, frmJuzgados)
    '            frm.txtLocalidad.Text = Me.dgvLocalidades.CurrentRow.Cells(1).Value.ToString()
    '            flag_where = 0 'RESET 
    '            Me.Close()
    '        End If
    '    End If

    '    If flag_where = 2 Then
    '        If e.KeyData = Keys.Enter Then 'ENVIAR EL VALOR AL FORMULARIO JUZGADOS
    '            Dim frm As frmClientes = CType(Owner, frmClientes)
    '            frm.txtLocalidad.Text = Me.dgvLocalidades.CurrentRow.Cells(1).Value.ToString()
    '            flag_where = 0 'RESET 
    '            Me.Close()
    '        End If
    '    End If
    'End Sub

    Private Sub dgvLocalidades_Keydown(sender As Object, e As KeyEventArgs) Handles dgvLocalidades.KeyDown
        If flag_where = 1 Then
            If e.KeyCode = Keys.Enter Then
                Dim selectedRow = dgvLocalidades.CurrentRow
                If selectedRow IsNot Nothing Then
                    Dim localidad As String = selectedRow.Cells(1).Value.ToString()
                    Dim formJuzgados As frmJuzgados = Application.OpenForms("frmJuzgados")
                    If formJuzgados IsNot Nothing Then
                        Dim textBoxLocalidad As TextBox = formJuzgados.Controls.Find("txtLocalidad", True).FirstOrDefault()
                        If textBoxLocalidad IsNot Nothing Then
                            textBoxLocalidad.Text = localidad
                            Dim formLocalidades As frmLocalidades = Application.OpenForms("frmLocalidades")
                            If formLocalidades IsNot Nothing Then
                                formLocalidades.Close()
                            End If
                        End If
                    End If
                End If
            End If
        End If

        If flag_where = 2 Then
            If e.KeyCode = Keys.Enter Then
                Dim selectedRow = dgvLocalidades.CurrentRow
                If selectedRow IsNot Nothing Then
                    Dim localidad As String = selectedRow.Cells(1).Value.ToString()
                    Dim formclientes As frmClientes = Application.OpenForms("frmClientes")
                    If formclientes IsNot Nothing Then
                        Dim textBoxLocalidad As TextBox = formclientes.Controls.Find("txtLocalidad", True).FirstOrDefault()
                        If textBoxLocalidad IsNot Nothing Then
                            textBoxLocalidad.Text = localidad
                            Dim formLocalidades As frmLocalidades = Application.OpenForms("frmLocalidades")
                            If formLocalidades IsNot Nothing Then
                                formLocalidades.Close()
                            End If
                        End If
                    End If
                End If
            End If
        End If
    End Sub

    Private Sub Esconder()
        Me.btnEliminar.Visible = False
        Me.btnModificar.Visible = False
        Me.btnNuevo.Visible = False
        Me.btnListo.Visible = False
        Me.txtCp.Visible = False
        Me.lbCp.Visible = False
        Me.lbLocalidades.Visible = False
        Me.txtLocalidad.Visible = False


    End Sub


End Class