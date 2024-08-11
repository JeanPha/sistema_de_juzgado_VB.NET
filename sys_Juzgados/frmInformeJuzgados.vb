Public Class frmInformeJuzgados
    Private Sub frmInformeJuzgados_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: esta línea de código carga datos en la tabla 'EJER5DataSet.Sp_juzgados' Puede moverla o quitarla según sea necesario.
        Me.Sp_juzgadosTableAdapter.Fill(Me.EJER5DataSet.Sp_juzgados)

        Me.ReportViewer1.RefreshReport()
    End Sub
End Class