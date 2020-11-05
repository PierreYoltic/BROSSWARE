Imports System.ComponentModel
Imports System.Data.SqlClient

Public Class BuscarArticulo
    Dim conexion As New SqlConnection("Data Source=PIER18;Initial catalog=taller_refaccionaria; Integrated security = true")
    Dim comando As New SqlCommand
    Dim lector As SqlDataReader

    Dim Codigo As String
    Dim Descripcion As String
    Dim Existencia As Integer
    Dim Precio As Decimal
    Dim row As Integer


    Private Sub BuscarArticulo_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        conexion.Open()
        comando = conexion.CreateCommand

        If opcion = 1 Then
            comando.CommandText = "SELECT * FROM showActiveServices ORDER BY Descripción"
            lector = comando.ExecuteReader
            While lector.Read
                DataGridViewArticulos.Rows.Add(lector(0), "*", lector(1), "N/A", lector(2))
            End While
            lector.Close()
        End If

        comando.CommandText = "SELECT * FROM showActiveItems ORDER BY Descripción"
        lector = comando.ExecuteReader
        While lector.Read
            DataGridViewArticulos.Rows.Add(lector(0), "", lector(1), lector(2), lector(3))
        End While
        lector.Close()
        conexion.Close()

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Me.Dispose()
    End Sub

    Public Function CargarArticulo(i As Integer) As String()

        Return {
            DataGridViewArticulos.Rows(i).Cells(0).Value.ToString,
            DataGridViewArticulos.Rows(i).Cells(1).Value.ToString,
            DataGridViewArticulos.Rows(i).Cells(2).Value.ToString,
            DataGridViewArticulos.Rows(i).Cells(3).Value.ToString,
            DataGridViewArticulos.Rows(i).Cells(4).Value.ToString}
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
            Dim Frm As Ventas = FormMenu.fm
            Try
                frm.AgregarArticulo(CargarArticulo(row))
                Me.Dispose()
            Catch ex As Exception
                Exit Sub
                Me.Dispose()
            End Try

        End If
        Me.Dispose()
    End Sub

    Private Sub DataGridViewArticulos_CellMouseDoubleClick(sender As Object, e As DataGridViewCellMouseEventArgs) Handles DataGridViewArticulos.CellMouseDoubleClick
        row = e.RowIndex
        Me.Close()
    End Sub

    Private Sub TxtCodigo_TextChanged(sender As Object, e As EventArgs) Handles TxtCodigo.TextChanged
        DataGridViewArticulos.Rows.Clear()

        conexion.Open()
        comando = conexion.CreateCommand
        comando.CommandText = "SELECT * FROM showActiveServices WHERE Descripción LIKE '%" & TxtCodigo.Text & "%' ORDER BY Descripción"
        lector = comando.ExecuteReader
        While lector.Read
            DataGridViewArticulos.Rows.Add(lector(0), "*", lector(1), "N/A", lector(2))
        End While
        lector.Close()
        comando.CommandText = "SELECT * FROM showActiveItems WHERE Descripción LIKE '%" & TxtCodigo.Text & "%' ORDER BY Descripción"
        lector = comando.ExecuteReader
        While lector.Read
            DataGridViewArticulos.Rows.Add(lector(0), "", lector(1), lector(2), lector(3))
        End While
        lector.Close()
        conexion.Close()
    End Sub
End Class