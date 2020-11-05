Imports System.ComponentModel

Public Class CantidadArticulo
    Private Sub BtnCancelar_Click(sender As Object, e As EventArgs) Handles BtnCancelar.Click
        Me.Dispose()
    End Sub

    Private Sub BtnGuardar_Click(sender As Object, e As EventArgs) Handles BtnGuardar.Click
        'Ventas.SetCantidad(Val(TxtCantidad.Text))
        Me.Close()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        TxtCantidad.Text = Val(TxtCantidad.Text) + 1
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        TxtCantidad.Text = Val(TxtCantidad.Text) - 1
    End Sub

    Private Sub CantidadArticulo_Closing(sender As Object, e As CancelEventArgs) Handles Me.Closing
        If opcion = 1 Then
            Dim frm As Ventas = FormMenu.fm
            frm.SetCantidad(Val(TxtCantidad.Text), frm.Row)

        End If
    End Sub

    Private Sub CantidadArticulo_Load(sender As Object, e As EventArgs) Handles Me.Load
        If opcion = 1 Then
            Dim frm As Ventas = FormMenu.fm
            TxtCantidad.Text = frm.DataGridViewVenta.Rows(frm.Row).Cells(0).Value
        End If
    End Sub
End Class