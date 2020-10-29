Imports System.ComponentModel

Public Class BuscarArticulo
    Dim Codigo As String
    Dim Descripcion As String
    Dim Existencia As Integer
    Dim Precio As Decimal
    Dim row As Integer

    Private Sub BuscarArticulo_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'Taller_refaccionariaDataSet.showActiveItems' table. You can move, or remove it, as needed.
        Me.ShowActiveItemsTableAdapter.Fill(Me.Taller_refaccionariaDataSet.showActiveItems)
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Me.Dispose()
    End Sub

    Private Sub DataGridViewArticulos_CellMouseDoubleClick(sender As Object, e As DataGridViewCellMouseEventArgs) Handles DataGridViewArticulos.CellMouseDoubleClick
        row = e.RowIndex
        Me.Close()
    End Sub

    Public Function CargarArticulo(i As Integer) As String()

        Return {
            DataGridViewArticulos.Rows(i).Cells(0).Value.ToString,
            DataGridViewArticulos.Rows(i).Cells(1).Value.ToString,
            DataGridViewArticulos.Rows(i).Cells(2).Value.ToString,
            DataGridViewArticulos.Rows(i).Cells(3).Value.ToString}
    End Function

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        AddArticulos.StartPosition = FormStartPosition.CenterScreen
        AddArticulos.ShowDialog()
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        If claveArticuloSeleccionado = vbNullString Then
            MessageBox.Show("Debes seleccionar un artículo de la lista para poder editarlo", "MENSAJE", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
        Else
            EditArticulo.StartPosition = FormStartPosition.CenterScreen
            EditArticulo.ShowDialog()
        End If
    End Sub

    Private Sub BuscarArticulo_Closing(sender As Object, e As CancelEventArgs) Handles Me.Closing
        If opcion = 1 Then
            Dim frm As Ventas = FormMenu.fm
            frm.AgregarArticulo(CargarArticulo(row))

        End If
    End Sub
End Class