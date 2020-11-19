Public Class FormMenu
    Public fm As Form
    Private Sub ButtonArticulos_Click(sender As Object, e As EventArgs)

    End Sub

    Public Sub AbrirFormInPanel(FormHijo As Object)
        If PanelContenedor.Controls.Count > 0 Then
            While PanelContenedor.Controls.Count > 0
                PanelContenedor.Controls.RemoveAt(0)
            End While
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

    Private Sub BtnCompras_Click(sender As Object, e As EventArgs) Handles BtnCompras.Click
        AbrirFormInPanel(New Compras())
    End Sub

    Private Sub Button6_Click(sender As Object, e As EventArgs) Handles Button6.Click
        AbrirFormInPanel(New ConsultaCompra())
    End Sub

    Private Sub BtnAjuste_Click(sender As Object, e As EventArgs) Handles BtnAjuste.Click
        AbrirFormInPanel(New AjusteInventario())
    End Sub

    Private Sub BtnConsultaAjuste_Click(sender As Object, e As EventArgs) Handles BtnConsultaAjuste.Click
        AbrirFormInPanel(New ConsultaAjuste())
    End Sub

    Private Sub ReporteExistencia_Click(sender As Object, e As EventArgs) Handles ReporteExistencia.Click
        AbrirFormInPanel(New FrmReporteExistencias)
    End Sub

    Private Sub BtnReporteProveedores_Click(sender As Object, e As EventArgs) Handles BtnReporteProveedores.Click
        AbrirFormInPanel(New FrmReporteProveedores)
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        AbrirFormInPanel(New FrmReporteClientes)
    End Sub

    Private Sub BtnBitacora_Click(sender As Object, e As EventArgs) Handles BtnReporteCompraGeneral.Click
        AbrirFormInPanel(New FrmReporteComprasGeneral())
    End Sub

    Private Sub BtnBitacora_Click_1(sender As Object, e As EventArgs) Handles BtnBitacora.Click
        AbrirFormInPanel(New BitacoraErrores())
    End Sub

    Private Sub BtnComprasArticulo_Click(sender As Object, e As EventArgs) Handles BtnComprasArticulo.Click
        AbrirFormInPanel(New ReporteComprasArticulos())
    End Sub
End Class
