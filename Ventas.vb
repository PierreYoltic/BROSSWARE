
'FALTA PROGRMAR FUNCION DE BUSQUEDA DE ARTICULOS


Imports System.Data.SqlClient
Public Class Ventas
    Dim conexion As New SqlConnection("Data Source=PIER18;Initial catalog=taller_refaccionaria; Integrated security = true")
    Dim comando As New SqlCommand
    Dim lector As SqlDataReader
    Dim IdVenta As Integer
    Public Row As Integer = -1
    Public Total As Decimal = 0
    Dim Descuento As Decimal
    Dim Subtotal As Decimal = 0

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
        For i = 0 To DataGridViewVenta.RowCount - 1
            If DataGridViewVenta.Rows(i).Cells(1).Value = art(0) Then
                SetCantidad(Val(DataGridViewVenta.Rows(i).Cells(0).Value) + 1, i)
                CalcularTotal()
                Exit Sub
            End If
        Next
        DataGridViewVenta.Rows.Add("1", art(0), art(1), art(2), art(3), art(4), art(4))
        CalcularTotal()
    End Sub

    Private Sub Ventas_Load(sender As Object, e As EventArgs) Handles Me.Load
        opcion = 1
        conexion.Open()
        comando = conexion.CreateCommand
        comando.CommandText = "SELECT COUNT(*) FROM venta"
        IdVenta = comando.ExecuteScalar + 1
        conexion.Close()

        TxtId.Text = IdVenta
    End Sub

    Private Sub DataGridViewVenta_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridViewVenta.CellClick
        Row = e.RowIndex
    End Sub

    Private Sub BtnCantidad_Click(sender As Object, e As EventArgs) Handles BtnCantidad.Click
        CantidadArticulo.StartPosition = FormStartPosition.CenterParent
        CantidadArticulo.ShowDialog()
    End Sub

    Public Sub SetCantidad(cant As Integer, i As Integer)
        DataGridViewVenta.Rows(i).Cells(0).Value = cant
        DataGridViewVenta.Rows(i).Cells(6).Value = DataGridViewVenta.Rows(i).Cells(5).Value * cant
        CalcularTotal()
    End Sub

    Private Sub BtnRemover_Click(sender As Object, e As EventArgs) Handles BtnRemover.Click
        DataGridViewVenta.Rows.Remove(DataGridViewVenta.Rows(Row))
    End Sub

    Private Sub BtnDesc_Click(sender As Object, e As EventArgs) Handles BtnDesc.Click
        FrmDescuento.StartPosition = FormStartPosition.CenterParent
        FrmDescuento.ShowDialog()
    End Sub

    Public Sub aplicarDescuento(desc As Decimal)
        Descuento = desc
        LblDescuento.Text = "Descuento: $ " & Descuento
        CalcularTotal()
    End Sub

    Private Sub BtnImporte_Click(sender As Object, e As EventArgs) Handles BtnImporte.Click
        CambiarImporte.StartPosition = FormStartPosition.CenterParent
        CambiarImporte.ShowDialog()
    End Sub

    Public Sub ActualizarImporte(imp As Decimal)
        DataGridViewVenta.Rows(Row).Cells(6).Value = imp
        CalcularTotal()
    End Sub

    Private Sub BtnCliente_Click(sender As Object, e As EventArgs) Handles BtnCliente.Click
        'opcion = 1
        BuscarCliente.StartPosition = FormStartPosition.CenterParent
        BuscarCliente.Show()
    End Sub

    Private Sub CalcularTotal()
        Subtotal = 0
        For i = 0 To DataGridViewVenta.RowCount - 1
            Subtotal += DataGridViewVenta.Rows(i).Cells(6).Value
        Next
        Total = Subtotal - Descuento

        LblSubtotal.Text = "Subtotal: $" & Subtotal
        LblTotal.Text = "Total: $" & Total & " MXN"

    End Sub

    Private Sub BtnCerrar_Click(sender As Object, e As EventArgs) Handles BtnCerrar.Click
        CerrarVenta.StartPosition = FormStartPosition.CenterParent
        CerrarVenta.Show()
    End Sub

    Public Sub Cerrar(comentario As String)
        conexion.Open()
        comando = conexion.CreateCommand
        Dim R = "INSERT INTO venta
                VALUES(" & IdVenta & ",'" & DTPFecha.Value & "'," & Subtotal &
                     "," & Descuento & "," & Total & ",'" & comentario &
                     "'," & 1 & "," & Val(TxtIdCliente.Text) & ")"
        comando.CommandText = R
        comando.ExecuteNonQuery()
        For i = 0 To DataGridViewVenta.RowCount - 1
            If DataGridViewVenta.Rows(i).Cells(2).Value = "*" Then
                R = "INSERT INTO detalleservicio
                VALUES(" & IdVenta & "," & DataGridViewVenta.Rows(i).Cells(1).Value &
                                     "," & DataGridViewVenta.Rows(i).Cells(6).Value & ")"
                comando.CommandText = R
                comando.ExecuteNonQuery()
            Else
                R = "INSERT INTO detalleventa
                VALUES(" & IdVenta & ",'" & DataGridViewVenta.Rows(i).Cells(1).Value &
                                    "'," & DataGridViewVenta.Rows(i).Cells(0).Value &
                                     "," & DataGridViewVenta.Rows(i).Cells(6).Value & ")"
                comando.CommandText = R
                comando.ExecuteNonQuery()

                R = "UPDATE articulo
                    SET existencia =" & Val(DataGridViewVenta.Rows(i).Cells(4).Value) - Val(DataGridViewVenta.Rows(i).Cells(0).Value) &
                    "WHERE codigo=" & DataGridViewVenta.Rows(i).Cells(1).Value
                comando.CommandText = R
                comando.ExecuteNonQuery()
            End If

        Next
        conexion.Close()
        FormMenu.AbrirFormInPanel(New Ventas)
        Me.Dispose()
    End Sub


End Class