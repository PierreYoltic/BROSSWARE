Imports System.ComponentModel

Public Class ReporteClientes
    Private Sub ReporteClientes_Load(sender As Object, e As EventArgs) Handles Me.Load
        Me.ReportViewer1.RefreshReport()
    End Sub

    Private Sub ReporteClientes_Closing(sender As Object, e As CancelEventArgs) Handles Me.Closing
        Me.Dispose()
    End Sub
End Class