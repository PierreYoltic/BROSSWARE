﻿Public Class FormMenu
    Public fm As Form
    Private Sub ButtonArticulos_Click(sender As Object, e As EventArgs)

    End Sub

    Public Sub AbrirFormInPanel(FormHijo As Object)
        If PanelContenedor.Controls.Count > 0 Then
            PanelContenedor.Controls.RemoveAt(0)
        End If
        fm = FormHijo
        fm.TopLevel = False
        fm.Dock = DockStyle.Fill
        PanelContenedor.Controls.Add(fm)
        fm.Show()
    End Sub

    Private Sub ButtonArticulos_Click_1(sender As Object, e As EventArgs) Handles BtnArticulos.Click
        AbrirFormInPanel(New Articulos())
    End Sub

    Private Sub BtnClientes_Click(sender As Object, e As EventArgs) Handles BtnClientes.Click
        AbrirFormInPanel(New Clientes())
    End Sub

    Private Sub BtnProveedores_Click(sender As Object, e As EventArgs) Handles BtnProveedores.Click
        AbrirFormInPanel(New Proveedores())
    End Sub

    Private Sub Button7_Click(sender As Object, e As EventArgs) Handles Button7.Click
        AbrirFormInPanel(New Ventas())
    End Sub

    Private Sub Button8_Click(sender As Object, e As EventArgs) Handles Button8.Click
        AbrirFormInPanel(New ConsultaVenta())
    End Sub
End Class
