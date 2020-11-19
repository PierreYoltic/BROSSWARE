Public Class EditarArticuloAjuste
    Private _codigo, _descripcion, _existencia As String

    Private Sub BtnGuardar_Click(sender As Object, e As EventArgs) Handles BtnGuardar.Click
        Dim Frm As AjusteInventario = FormMenu.fm
        Frm.AgregarArticulo({_codigo, _descripcion, TxtCantidad.Text, _existencia})
        Me.Dispose()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Me.Dispose()
    End Sub

    Public Sub New(ByVal codigo As String, descripcion As String, existencia As String)

        ' This call is required by the designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.
        _codigo = codigo
        _descripcion = descripcion
        _existencia = existencia
    End Sub

    Private Sub EditarArticuloAjuste_Load(sender As Object, e As EventArgs) Handles Me.Load
        LblArticulo.Text = _descripcion
        TxtCantidad.Text = _existencia
    End Sub
End Class