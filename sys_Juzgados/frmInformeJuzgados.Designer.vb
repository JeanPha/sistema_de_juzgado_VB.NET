﻿<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmInformeJuzgados
    Inherits System.Windows.Forms.Form

    'Form reemplaza a Dispose para limpiar la lista de componentes.
    <System.Diagnostics.DebuggerNonUserCode()> _
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
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim ReportDataSource1 As Microsoft.Reporting.WinForms.ReportDataSource = New Microsoft.Reporting.WinForms.ReportDataSource()
        Me.ReportViewer1 = New Microsoft.Reporting.WinForms.ReportViewer()
        Me.EJER5DataSet = New sys_Juzgados.EJER5DataSet()
        Me.SpjuzgadosBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Sp_juzgadosTableAdapter = New sys_Juzgados.EJER5DataSetTableAdapters.Sp_juzgadosTableAdapter()
        CType(Me.EJER5DataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SpjuzgadosBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'ReportViewer1
        '
        Me.ReportViewer1.Dock = System.Windows.Forms.DockStyle.Fill
        ReportDataSource1.Name = "dsFacturasVencidas"
        ReportDataSource1.Value = Me.SpjuzgadosBindingSource
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
        'SpjuzgadosBindingSource
        '
        Me.SpjuzgadosBindingSource.DataMember = "Sp_juzgados"
        Me.SpjuzgadosBindingSource.DataSource = Me.EJER5DataSet
        '
        'Sp_juzgadosTableAdapter
        '
        Me.Sp_juzgadosTableAdapter.ClearBeforeFill = True
        '
        'frmInformeJuzgados
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.ReportViewer1)
        Me.Name = "frmInformeJuzgados"
        Me.Text = "frmInformeJuzgados"
        CType(Me.EJER5DataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.SpjuzgadosBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents ReportViewer1 As Microsoft.Reporting.WinForms.ReportViewer
    Friend WithEvents EJER5DataSet As EJER5DataSet
    Friend WithEvents SpjuzgadosBindingSource As BindingSource
    Friend WithEvents Sp_juzgadosTableAdapter As EJER5DataSetTableAdapters.Sp_juzgadosTableAdapter
End Class
