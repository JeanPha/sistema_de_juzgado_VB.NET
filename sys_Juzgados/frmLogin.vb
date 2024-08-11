﻿Imports System.Diagnostics.Eventing.Reader

Public Class frmLogin
    Private Sub frmLogin1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        conectar()

    End Sub

    Private Sub txtCaja_TextChanged(sender As Object, e As EventArgs) Handles txtIdcaja.TextChanged
        If Me.txtIdcaja.Text <> "" Then
            Me.lbUsuario.Visible = True
            Me.txtUsuario.Visible = True
            Me.lbcontrasena.Visible = True
            Me.txtPsw.Visible = True
            Me.lbEnterUsuario.Visible = True
            Me.lbEnterPsw.Visible = True
            Me.btnIngresar.Visible = True
            wid_caja = Me.txtIdcaja.Text
        Else
            Me.lbUsuario.Visible = False
            Me.txtUsuario.Visible = False
            Me.lbcontrasena.Visible = False
            Me.txtPsw.Visible = False
            Me.btnIngresar.Visible = False
        End If
    End Sub
    Private Sub txtusuario_keydown(sender As Object, e As KeyEventArgs) Handles txtUsuario.KeyDown
        If e.KeyData = Keys.Enter Then
            login_us()

        End If
    End Sub

    Private Sub txtPsw_KeyDown(sender As Object, e As KeyEventArgs) Handles txtPsw.KeyDown
        If e.KeyData = Keys.Enter Then
            login_psw()
        End If
    End Sub

    Private Sub btnIngresar_Click(sender As Object, e As EventArgs) Handles btnIngresar.Click
        login_psw()
    End Sub
    Private Sub login_us()
        cmd.Connection = Conexion.conexion
        cmd.CommandType = CommandType.Text
        Dim sql As String = "select id, usuario, contrasena from usuarios
                            where usuario = '" & Me.txtUsuario.Text & "'"
        cmd.CommandText = sql
        dr = cmd.ExecuteReader()

        Try
            If dr.HasRows Then
                While dr.Read
                    Me.lbApellidoNombre.Visible = True
                    wid_usuario = dr(0).ToString
                    wusuario = dr(1).ToString
                    Me.lbApellidoNombre.Visible = True
                    Me.lbApellidoNombre.Text = dr(1).ToString
                    Me.lbPsw.Text = dr(2).ToString
                    Me.txtPsw.Focus()
                    Me.btnIngresar.Visible = True
                End While
            Else
                MsgBox("Usuario Inexistente", Title:="Super")
                Me.txtUsuario.Clear()
            End If
            dr.Close()
        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try
    End Sub
    Private Sub login_psw()
        If (Me.txtPsw.Text = Me.lbPsw.Text) Then
            ' MsgBox("Hola")
            frmMain.Show()
            Me.Close()
        Else
            MsgBox("Los datos ingresados no son correctos.", MsgBoxStyle.Critical, "Error de acceso")
            Me.txtUsuario.Clear()
            Me.txtUsuario.Focus()
            Me.txtPsw.Clear()
            Me.btnIngresar.Visible = False
            Me.lbApellidoNombre.Visible = False

        End If


    End Sub

    Private Sub btnSalir_Click(sender As Object, e As EventArgs) Handles btnSalir.Click
        Me.Close()

    End Sub

    Private Sub txtIdcaja_KeyDown(sender As Object, e As KeyEventArgs) Handles txtIdcaja.KeyDown
        If e.KeyData = Keys.Enter Then
            txtUsuario.Focus()


        End If
    End Sub

  End Class