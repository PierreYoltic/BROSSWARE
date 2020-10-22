Public Class Proveedores
    Private Sub Proveedores_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'Taller_refaccionariaDataSet.proveedor' table. You can move, or remove it, as needed.
        Me.ProveedorTableAdapter.Fill(Me.Taller_refaccionariaDataSet.proveedor)

    End Sub

    Private Sub BtnAgregar_Click(sender As Object, e As EventArgs) Handles BtnAgregar.Click
        AddProveedor.StartPosition = FormStartPosition.CenterScreen
        AddProveedor.ShowDialog()
    End Sub

    Private Sub BtnEditar_Click(sender As Object, e As EventArgs) Handles BtnEditar.Click
        EditProveedor.StartPosition = FormStartPosition.CenterScreen
        EditProveedor.ShowDialog()
    End Sub

    Private Sub BtnEliminar_Click(sender As Object, e As EventArgs) Handles BtnEliminar.Click

    End Sub
End Class