
Imports System.ComponentModel

Public Class CerrarVenta

    Dim Frm As Ventas = FormMenu.fm
    Dim cambio As Decimal = 0

    Private Sub CerrarVenta_Load(sender As Object, e As EventArgs) Handles Me.Load
        LblTotal.Text = "$ " & Frm.Total & " MXN"
        LblCliente.Text = Frm.TxtCliente.Text
        TxtEfectivo.Text = Frm.Total
    End Sub

    Private Sub TxtEfectivo_TextChanged(sender As Object, e As EventArgs) Handles TxtEfectivo.TextChanged
        cambio = Val(TxtEfectivo.Text) - Frm.Total
        LblCambio.Text = "$ " & cambio & " MXN"
        If cambio < 0 Then
            LblCambio.ForeColor = Color.Red
        ElseIf cambio >= 0 Then
            LblCambio.ForeColor = Color.ForestGreen
        End If
    End Sub

    Private Sub BtnGuardar_Click(sender As Object, e As EventArgs) Handles BtnGuardar.Click
        If cambio < 0 Then
            MessageBox.Show("El cambio no puede ser negativo", "MONTO INCOMPLETO", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Else
            Me.Close()
        End If
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Me.Dispose()
    End Sub

    Private Sub CerrarVenta_Closing(sender As Object, e As CancelEventArgs) Handles Me.Closing
        Frm.Cerrar(TxtComentario.Text)
        Me.Dispose()
    End Sub
End Class