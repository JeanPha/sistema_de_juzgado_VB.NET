Public Class frmImprimirExpedientes
    Private Sub frmImprimirExpedientes_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        'TODO: esta línea de código carga datos en la tabla 'EJER5DataSet.spuExpedientesNumero' Puede moverla o quitarla según sea necesario.

        Me.SpuExpedientesNumeroTableAdapter.Fill(Me.EJER5DataSet.spuExpedientesNumero, id_expediente:=wid_expediente)


        Me.ReportViewer1.RefreshReport()

    End Sub


End Class