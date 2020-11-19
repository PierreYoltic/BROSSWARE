Imports System.ComponentModel

Public Class BuscarProveedor
    Dim nombre As String
    Dim idProv As Integer
    Private Sub BuscarProveedor_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'Taller_refaccionariaDataSet.showActiveProviders' table. You can move, or remove it, as needed.
        Me.ShowActiveProvidersTableAdapter.Fill(Me.Taller_refaccionariaDataSet.showActiveProviders)

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Me.Dispose()
    End Sub
    Private Sub DataGridViewProveedores_CellMouseDoubleClick(sender As Object, e As DataGridViewCellMouseEventArgs) Handles DataGridViewProveedores.CellMouseDoubleClick
        nombre = DataGridViewProveedores.Rows(e.RowIndex).Cells(1).Value.ToString
        idProv = DataGridViewProveedores.Rows(e.RowIndex).Cells(0).Value
        Me.Close()
    End Sub

    Private Sub BuscarProveedor_Closing(sender As Object, e As CancelEventArgs) Handles Me.Closing
        If opcion = 2 Then
            Dim frm As Compras = FormMenu.fm
            frm.TxtProveedor.Text = nombre
            frm.TxtIdProveedor.Text = idProv
        End If
        Me.Dispose()
    End Sub
End Class