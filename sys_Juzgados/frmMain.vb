Imports Microsoft.ReportingServices.Diagnostics.Internal
Imports System.Data.SqlClient

Public Class frmMain

    Private Sub btnInformeJuzgados_Click(sender As Object, e As EventArgs) Handles btnInformeJuzgados.Click
        Dim frm As New frmInformeJuzgados
        frm.ShowDialog()
    End Sub

    Private Sub btnInformeExpedientes_Click(sender As Object, e As EventArgs) Handles btnInformeExpedientes.Click
        Dim frm As New frmIdExpediente
        frm.ShowDialog()
    End Sub

    Private Sub btnJuzgados_Click(sender As Object, e As EventArgs) Handles btnJuzgados.Click
        Dim frm As New frmJuzgados
        frm.ShowDialog()
    End Sub

    Private Sub btnJuicios_Click(sender As Object, e As EventArgs) Handles btnJuicios.Click
        Dim frm As New frmJuicios
        frm.ShowDialog()
    End Sub

    Private Sub btnEstados_Click(sender As Object, e As EventArgs) Handles btnEstados.Click
        Dim frm As New frmEstados
        frm.ShowDialog()
    End Sub

    Private Sub btnClientes_Click(sender As Object, e As EventArgs) Handles btnClientes.Click
        Dim frm As New frmClientes
        frm.ShowDialog()
    End Sub

    Private Sub btnLocalidades_Click(sender As Object, e As EventArgs) Handles btnLocalidades.Click
        Dim frm As New frmLocalidades
        frm.ShowDialog()
    End Sub

    Private Sub btnExpedientes_Click(sender As Object, e As EventArgs) Handles btnExpedientes.Click
        Dim frm As New frmExpedientes
        frm.ShowDialog()
    End Sub

    Private Sub frmMain_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class