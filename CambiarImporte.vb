Imports System.ComponentModel
Public Class CambiarImporte
    Private Sub BtnGuardar_Click(sender As Object, e As EventArgs) Handles BtnGuardar.Click
        Me.Close()
    End Sub
    Private Sub CambiarImporte_Load(sender As Object, e As EventArgs) Handles Me.Load
        If opcion = 1 Then
            Dim frm As Ventas = FormMenu.fm
            TxtImporte.Text = frm.DataGridViewVenta.Rows(frm.Row).Cells(6).Value
        End If
    End Sub
    Private Sub BtnCancelar_Click(sender As Object, e As EventArgs) Handles BtnCancelar.Click
        Me.Dispose()
    End Sub
    Private Sub CambiarImporte_Closing(sender As Object, e As CancelEventArgs) Handles Me.Closing
        If opcion = 1 Then
            Dim frm As Ventas = FormMenu.fm
            frm.ActualizarImporte(Val(TxtImporte.Text))
        End If
    End Sub
End Class