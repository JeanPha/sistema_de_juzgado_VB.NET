<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmImprimirExpedientes
    Inherits System.Windows.Forms.Form

    'Form reemplaza a Dispose para limpiar la lista de componentes.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Requerido por el Diseñador de Windows Forms
    Private components As System.ComponentModel.IContainer

    'NOTA: el Diseñador de Windows Forms necesita el siguiente procedimiento
    'Se puede modificar usando el Diseñador de Windows Forms.  
    'No lo modifique con el editor de código.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim ReportDataSource1 As Microsoft.Reporting.WinForms.ReportDataSource = New Microsoft.Reporting.WinForms.ReportDataSource()
        Me.ReportViewer1 = New Microsoft.Reporting.WinForms.ReportViewer()
        Me.EJER5DataSet = New sys_Juzgados.EJER5DataSet()
        Me.SpuExpedientesNumeroBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.SpuExpedientesNumeroTableAdapter = New sys_Juzgados.EJER5DataSetTableAdapters.spuExpedientesNumeroTableAdapter()
        CType(Me.EJER5DataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SpuExpedientesNumeroBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'ReportViewer1
        '
        Me.ReportViewer1.Dock = System.Windows.Forms.DockStyle.Fill
        ReportDataSource1.Name = "dsFacturasVencidas"
        ReportDataSource1.Value = Me.SpuExpedientesNumeroBindingSource
        Me.ReportViewer1.LocalReport.DataSources.Add(ReportDataSource1)
        Me.ReportViewer1.LocalReport.ReportEmbeddedResource = "sys_Juzgados.reportFacturasVencidas.rdlc"
        Me.ReportViewer1.Location = New System.Drawing.Point(0, 0)
        Me.ReportViewer1.Name = "ReportViewer1"
        Me.ReportViewer1.ServerReport.BearerToken = Nothing
        Me.ReportViewer1.Size = New System.Drawing.Size(800, 450)
        Me.ReportViewer1.TabIndex = 0
        '
        'EJER5DataSet
        '
        Me.EJER5DataSet.DataSetName = "EJER5DataSet"
        Me.EJER5DataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'SpuExpedientesNumeroBindingSource
        '
        Me.SpuExpedientesNumeroBindingSource.DataMember = "spuExpedientesNumero"
        Me.SpuExpedientesNumeroBindingSource.DataSource = Me.EJER5DataSet
        '
        'SpuExpedientesNumeroTableAdapter
        '
        Me.SpuExpedientesNumeroTableAdapter.ClearBeforeFill = True
        '
        'frmImprimirExpedientes
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.ReportViewer1)
        Me.Name = "frmImprimirExpedientes"
        Me.Text = "frmImprimirExpedientes"
        CType(Me.EJER5DataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.SpuExpedientesNumeroBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents ReportViewer1 As Microsoft.Reporting.WinForms.ReportViewer
    Friend WithEvents SpuExpedientesNumeroBindingSource As BindingSource
    Friend WithEvents EJER5DataSet As EJER5DataSet
    Friend WithEvents SpuExpedientesNumeroTableAdapter As EJER5DataSetTableAdapters.spuExpedientesNumeroTableAdapter
End Class
