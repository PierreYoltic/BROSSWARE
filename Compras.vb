Imports System.Data.SqlClient
Public Class Compras
    Dim conexion As New SqlConnection("Data Source=PIER18;Initial catalog=taller_refaccionaria; Integrated security = true")
    Dim comando As New SqlCommand
    Dim lector As SqlDataReader

    Dim transaction As SqlTransaction
    Dim IdCompra As Integer
    Public RowCompra As Integer = -1
    Public TotalCompra As Decimal = 0

    Dim CCP As ArrayList = New ArrayList

    Private Sub BtnBuscar_Click(sender As Object, e As EventArgs) Handles BtnBuscar.Click
        BuscarArticulo.StartPosition = FormStartPosition.CenterScreen
        BuscarArticulo.ShowDialog()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        BuscarArticulo.StartPosition = FormStartPosition.CenterScreen
        BuscarArticulo.ShowDialog()
    End Sub
    Public Sub AgregarArticulo(ByVal art As String())
        For i = 0 To DataGridViewCompra.RowCount - 1
            If DataGridViewCompra.Rows(i).Cells(0).Value = art(0) Then
                DataGridViewCompra.Rows(i).Cells(2).Value = art(4)
                DataGridViewCompra.Rows(i).Cells(3).Value = art(5)
                DataGridViewCompra.Rows(i).Cells(4).Value = art(6)
                DataGridViewCompra.Rows(i).Cells(5).Value = Val(art(4)) * Val(art(5))
                CalcularTotal()
                Exit Sub
            End If
        Next
        DataGridViewCompra.Rows.Add(art(0), art(2), art(4), art(5), art(6), (Val(art(4)) * Val(art(5))))
        CCP.Add(art(3))
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
        BuscarProveedor.StartPosition = FormStartPosition.CenterParent
        BuscarProveedor.Show()
    End Sub

    Private Sub CalcularTotal()
        Dim t As Decimal = 0
        For i = 0 To DataGridViewCompra.RowCount - 1
            t += DataGridViewCompra.Rows(i).Cells(5).Value
        Next
        TotalCompra = t
        LblTotal.Text = "Total: $" & TotalCompra & " MXN"

    End Sub

    Private Sub BtnCerrar_Click(sender As Object, e As EventArgs) Handles BtnCerrar.Click
        Dim ans As String
        If TxtIdProveedor.Text = "-" Then
            MsgBox("Debe seleccionar un proveedor para continuar")
            Exit Sub
        End If
        ans = MessageBox.Show("Estas seguro cerrar esta compra?", "Cerrar Compra", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
        If ans = vbYes Then
            CerrarCompra()
        End If

    End Sub
    Public Sub CerrarCompra()
        conexion.Open()
        comando = conexion.CreateCommand
        transaction = conexion.BeginTransaction("SampleTransaction")

        comando.Connection = conexion
        comando.Transaction = transaction
        Try
            Dim R = "INSERT INTO compra
                VALUES(" & Val(TxtId.Text) & ",'" & DTPFecha.Value & "'," & TotalCompra &
                    "," & 1 & "," & Val(TxtIdProveedor.Text) & ")"
            comando.CommandText = R

            Try
                comando.ExecuteNonQuery()
            Catch
                transaction.Rollback()
                Dim comando2 As New SqlCommand
                comando2 = conexion.CreateCommand
                comando2.CommandText = "USE MASTER SELECT COUNT(*) FROM bitacoradeerrores"
                Dim idbitacora = comando2.ExecuteScalar + 1
                MsgBox(Err.Description)
                comando2 = conexion.CreateCommand
                Dim C As String = "INSERT INTO bitacoradeerrores VALUES (" & idbitacora & ",'" & Date.Today.ToString & "','Compras','" & Err.Number & "','" & Err.Description.Replace("'", " ") & "')"

                MsgBox(C)
                comando2.CommandText = C
                comando2.ExecuteNonQuery()

            End Try

            For i = 0 To DataGridViewCompra.RowCount - 1
                R = "INSERT INTO detallecompra
                VALUES(" & IdCompra & ",'" & DataGridViewCompra.Rows(i).Cells(0).Value &
                                    "'," & DataGridViewCompra.Rows(i).Cells(2).Value &
                                     "," & DataGridViewCompra.Rows(i).Cells(3).Value & ")"
                comando.CommandText = R
                Try
                    comando.ExecuteNonQuery()
                Catch
                    transaction.Rollback()
                    Dim comando2 As New SqlCommand
                    comando2 = conexion.CreateCommand
                    comando2.CommandText = "USE MASTER SELECT COUNT(*) FROM bitacoradeerrores"
                    Dim idbitacora = comando2.ExecuteScalar + 1

                    MsgBox(idbitacora)
                    MsgBox(Err.Description)
                    comando2 = conexion.CreateCommand
                    Dim C As String = "INSERT INTO bitacoradeerrores VALUES (" & idbitacora & ",'" & Date.Today.ToString & "','Compras','" & Err.Number & "','" & Err.Description & "')"

                    MsgBox(C)
                    comando2.CommandText = C
                    comando2.ExecuteNonQuery()
                End Try

                R = "UPDATE articulo
                 SET existencia = existencia +" & Val(DataGridViewCompra.Rows(i).Cells(2).Value) & ", " &
                     "costoCompraProm = " & (Val(CCP(i)) + DataGridViewCompra.Rows(i).Cells(3).Value) / 2 & ", " &
                     "precio = " & Val(DataGridViewCompra.Rows(i).Cells(4).Value) &
                    " WHERE codigo=" & DataGridViewCompra.Rows(i).Cells(0).Value
                comando.CommandText = R
                Try
                    comando.ExecuteNonQuery()
                Catch
                    transaction.Rollback()
                    Dim comando2 As New SqlCommand
                    comando2 = conexion.CreateCommand
                    comando2.CommandText = "USE MASTER SELECT COUNT(*) FROM bitacoradeerrores"
                    Dim idbitacora = comando2.ExecuteScalar + 1

                    MsgBox(Err.Description)
                    comando2 = conexion.CreateCommand
                    Dim C As String = "INSERT INTO bitacoradeerrores VALUES (" & idbitacora & ",'" & Date.Today.ToString & "','Compras','" & Err.Number & "','" & Err.Description & "')"

                    MsgBox(C)
                    comando2.CommandText = C
                    comando2.ExecuteNonQuery()
                End Try
            Next
            If MsgBox("Desea ejecutar transacción", MsgBoxStyle.YesNo, "Ejecutar") = MsgBoxResult.Yes Then
                transaction.Commit()
                MsgBox("OK")
            Else
                transaction.Rollback()
                MsgBox("Transacción cancelada")
            End If
        Catch ex As Exception
            MsgBox("Commit Exception Type: {0} no se pudo insertar por error")
            Try
                'transaction.Rollback() 
            Catch ex2 As Exception
                MsgBox("Error Rollback")
            End Try
        End Try
        conexion.Close()
        FormMenu.AbrirFormInPanel(New Compras)
        Me.Dispose()
    End Sub

    Private Sub BtnEditar_Click(sender As Object, e As EventArgs) Handles BtnEditar.Click
        Dim FrmArticuloCompra As New EditarArticuloCompra(DataGridViewCompra.Rows(RowCompra).Cells(0).Value,
                                                          DataGridViewCompra.Rows(RowCompra).Cells(2).Value,
                                                          DataGridViewCompra.Rows(RowCompra).Cells(3).Value,
                                                          DataGridViewCompra.Rows(RowCompra).Cells(4).Value)
        FrmArticuloCompra.StartPosition = FormStartPosition.CenterScreen
        FrmArticuloCompra.Show()
    End Sub

    Private Sub DataGridViewCompra_CellMouseClick(sender As Object, e As DataGridViewCellMouseEventArgs) Handles DataGridViewCompra.CellMouseClick
        RowCompra = e.RowIndex
    End Sub
End Class