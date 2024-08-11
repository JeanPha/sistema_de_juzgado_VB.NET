Imports System.Runtime.InteropServices

Public Class frmIdExpediente
    Private Sub btnImprimirExpediente_Click(sender As Object, e As EventArgs) Handles btnImprimirExpediente.Click

        If Me.txtExpediente.Text = "" OrElse Not IsNumeric(Me.txtExpediente.Text) Then
            MsgBox("INGRESE UN NUMERO DE EXPEDIENTE VALIDO")
            Me.txtExpediente.Text = ""
            Me.txtExpediente.Focus()
        Else
            wid_expediente = Me.txtExpediente.Text
            Dim frm As New frmImprimirExpedientes
            frm.ShowDialog()
            Me.txtExpediente.Text = ""
            Me.Close()
        End If

    End Sub

    Private Sub txtExpediente_KeyDown(sender As Object, e As KeyEventArgs) Handles txtExpediente.KeyDown
        If e.KeyData = Keys.Enter Then
            If Not Integer.TryParse(Me.txtExpediente.Text, wid_expediente) Then
                MessageBox.Show("Por favor, ingrese un número de expediente válido.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                Me.txtExpediente.Clear()
            Else
                wid_expediente = Me.txtExpediente.Text
                Dim frm As New frmImprimirExpedientes
                frm.ShowDialog()
                Me.txtExpediente.Text = ""
                Me.Close()
            End If
        End If

    End Sub

    Private Sub frmIdExpediente_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class

