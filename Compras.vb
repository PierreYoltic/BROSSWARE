Imports System.Data.SqlClient
Public Class Compras
    Dim conexion As New SqlConnection("Data Source=PIER18;Initial catalog=taller_refaccionaria; Integrated security = true")
    Dim comando As New SqlCommand
    Dim lector As SqlDataReader

    Dim IdCompra As Integer
    Public RowCompra As Integer = -1
    Public TotalCompra As Decimal = 0

    Private Sub BtnBuscar_Click(sender As Object, e As EventArgs) Handles BtnBuscar.Click
        BuscarArticulo.StartPosition = FormStartPosition.CenterScreen
        BuscarArticulo.ShowDialog()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        BuscarArticulo.StartPosition = FormStartPosition.CenterScreen
        BuscarArticulo.ShowDialog()
    End Sub
    Public Sub AgregarArticulo(ByVal art As String())
        MsgBox(art(0) & art(1) & art(2) & art(3))
        'Dim Frm As Ventas = FormMenu.fm
        For i = 0 To DataGridViewCompra.RowCount - 1
            If DataGridViewCompra.Rows(i).Cells(1).Value = art(0) Then
                SetCantidad(Val(DataGridViewCompra.Rows(i).Cells(0).Value) + 1, i)
                CalcularTotal()
                Exit Sub
            End If
        Next
        DataGridViewCompra.Rows.Add("1", art(0), art(1), art(2), art(3), art(4), art(4))
        CalcularTotal()
    End Sub

    Private Sub Compras_Load(sender As Object, e As EventArgs) Handles Me.Load
        opcion = 2
        conexion.Open()
        comando = conexion.CreateCommand
        comando.CommandText = "SELECT COUNT(*) FROM compra"
        IdCompra = comando.ExecuteScalar + 1
        conexion.Close()

        TxtId.Text = IdCompra
    End Sub

    Private Sub DataGridViewCompra_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridViewCompra.CellClick
        RowCompra = e.RowIndex
    End Sub
    Public Sub SetCantidad(cant As Integer, i As Integer)
        DataGridViewCompra.Rows(i).Cells(0).Value = cant
        DataGridViewCompra.Rows(i).Cells(6).Value = DataGridViewCompra.Rows(i).Cells(5).Value * cant
        CalcularTotal()
    End Sub

    Private Sub BtnRemover_Click(sender As Object, e As EventArgs) Handles BtnRemover.Click
        DataGridViewCompra.Rows.Remove(DataGridViewCompra.Rows(RowCompra))
    End Sub

    Private Sub BtnProveedor_Click(sender As Object, e As EventArgs) Handles BtnProveedor.Click
        'BuscarProveedor
    End Sub
    Private Sub CalcularTotal()
        Dim t = 0
        For i = 0 To DataGridViewCompra.RowCount - 1
            t += DataGridViewCompra.Rows(i).Cells(5).Value
        Next
        TotalCompra = t
        LblTotal.Text = "Total: $" & TotalCompra & " MXN"

    End Sub

    Private Sub BtnCerrar_Click(sender As Object, e As EventArgs) Handles BtnCerrar.Click
        'CerrarCompra
    End Sub
    Public Sub Cerrar(comentario As String)
        conexion.Open()
        comando = conexion.CreateCommand
        Dim R = "INSERT INTO compra
                VALUES(" & IdCompra & ",'" & DTPFecha.Value & "'," & TotalCompra &
                     "," & 1 & "," & Val(TxtIdProveedor.Text) & ")"
        comando.CommandText = R
        comando.ExecuteNonQuery()

        For i = 0 To DataGridViewCompra.RowCount - 1
            R = "INSERT INTO detallecompra
                VALUES(" & IdCompra & ",'" & DataGridViewCompra.Rows(i).Cells(1).Value &
                                "'," & DataGridViewCompra.Rows(i).Cells(3).Value &
                                 "," & DataGridViewCompra.Rows(i).Cells(0).Value &
                                 "," & DataGridViewCompra.Rows(i).Cells(4).Value & ")"
            comando.CommandText = R
            comando.ExecuteNonQuery()

            R = "UPDATE articulo
                 SET existencia =" & Val(DataGridViewCompra.Rows(i).Cells(3).Value) + Val(DataGridViewCompra.Rows(i).Cells(0).Value) & "," &
                 "costoCompraProm = " & 'falta completar este query
                "WHERE codigo=" & DataGridViewCompra.Rows(i).Cells(1).Value
            comando.CommandText = R
            comando.ExecuteNonQuery()
        Next
        conexion.Close()
        FormMenu.AbrirFormInPanel(New Ventas)
        Me.Dispose()
    End Sub
End Class