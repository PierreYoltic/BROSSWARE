Imports System.ComponentModel

Public Class ReporteExistenciaArticulos
    Private Sub ReporteExistenciaArticulos_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        Me.ReportViewer1.RefreshReport()
        'Me.ReportViewer1

    End Sub

    Private Sub ReporteExistenciaArticulos_Closing(sender As Object, e As CancelEventArgs) Handles Me.Closing

        Me.Dispose()
    End Sub
End Class