Imports System.ComponentModel

Public Class FrmDescuento
    Private Sub BtnGuardar_Click(sender As Object, e As EventArgs) Handles BtnGuardar.Click
        Me.Close()
    End Sub

    Private Sub BtnCancelar_Click(sender As Object, e As EventArgs) Handles BtnCancelar.Click
        Me.Dispose()
    End Sub

    Private Sub Descuento_Closing(sender As Object, e As CancelEventArgs) Handles Me.Closing
        If opcion = 1 Then
            Dim frm As Ventas = FormMenu.fm
            frm.aplicarDescuento(Val(TxtDescuento.Text))
        End If
    End Sub
End Class