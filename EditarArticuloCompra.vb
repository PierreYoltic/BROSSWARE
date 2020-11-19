
Imports System.Data.SqlClient
Public Class EditarArticuloCompra
    Private _codigo, _cantidad, _costo, _precio As String
    Dim conexion As New SqlConnection("Data Source=PIER18;Initial catalog=taller_refaccionaria; Integrated security = true")
    Dim comando As New SqlCommand
    Dim lector As SqlDataReader
    Private Sub BtnMantenerPrecios_Click(sender As Object, e As EventArgs) Handles BtnMantenerPrecios.Click
        TxtCosto.Text = TxtCostoProm.Text
        TxtPrecio.Text = TxtPrecioActual.Text

        CalcularUtilidad()
    End Sub

    Private Sub CalcularUtilidad()
        Dim utilidad As Decimal
        If Val(TxtCosto.Text) = 0 Or Val(TxtPrecio.Text) = 0 Then
            TxtUtilidad.Text = 0
            Exit Sub
        Else
            utilidad = ((Val(TxtPrecio.Text) * 100) / Val(TxtCosto.Text)) - 100
            utilidad = Decimal.Round(utilidad, 2)
            TxtUtilidad.Text = utilidad
        End If

    End Sub

    Private Sub TxtCosto_TextChanged(sender As Object, e As EventArgs) Handles TxtCosto.TextChanged
        CalcularUtilidad()
    End Sub

    Private Sub TxtPrecio_TextChanged(sender As Object, e As EventArgs) Handles TxtPrecio.TextChanged
        CalcularUtilidad()
    End Sub

    Public Function EnviarArticulo() As String()

        Return {
            TxtCodigo.Text,
            TxtExistencia.Text,
            TxtDescripcion.Text,
            TxtCostoProm.Text,
            TxtCantidad.Text,
            TxtCosto.Text,
            TxtPrecio.Text}
    End Function

    Private Sub BtnAceptar_Click(sender As Object, e As EventArgs) Handles BtnAceptar.Click
        Dim Frm As Compras = FormMenu.fm
        Frm.AgregarArticulo(EnviarArticulo())
        Me.Dispose()
    End Sub

    Private Sub EditarArticuloCompra_Load(sender As Object, e As EventArgs) Handles Me.Load
        conexion.Open()
        comando = conexion.CreateCommand

        comando.CommandText = "SELECT existencia, descripcion, costoCompraProm, precio " &
                              " FROM articulo WHERE codigo = '" & _codigo & "'"

        lector = comando.ExecuteReader
        lector.Read()

        TxtCodigo.Text = _codigo
        TxtExistencia.Text = lector(0)
        TxtDescripcion.Text = lector(1)
        TxtCostoProm.Text = lector(2)
        TxtPrecioActual.Text = lector(3)


        TxtCantidad.Text = _cantidad
        If _costo = 0 Then
            TxtCosto.Text = lector(2)
        Else
            TxtCosto.Text = _costo
        End If
        TxtPrecio.Text = _precio
        conexion.Close()

        CalcularUtilidad()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Me.Close()
    End Sub

    Public Sub New(ByVal codigo As String, cantidad As String, costo As String, precio As String)

        ' This call is required by the designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.
        _codigo = codigo
        _cantidad = cantidad
        _costo = costo
        _precio = precio

    End Sub


End Class