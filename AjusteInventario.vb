Imports System.Data.SqlClient
Public Class AjusteInventario
    Dim conexion As New SqlConnection("Data Source=PIER18;Initial catalog=taller_refaccionaria; Integrated security = true")
    Dim comando As New SqlCommand
    Dim lector As SqlDataReader

    Dim IdAjuste As Integer
    Dim UsuId As Integer = 1
    Dim transaction As SqlTransaction
    Dim RowAjuste As Integer

    Private Sub BtnBuscar_Click(sender As Object, e As EventArgs) Handles BtnBuscar.Click
        BuscarArticulo.StartPosition = FormStartPosition.CenterScreen
        BuscarArticulo.ShowDialog()
    End Sub



    Public Sub AgregarArticulo(ByVal art As String())
        For i = 0 To DataGridViewAjuste.RowCount - 1
            If DataGridViewAjuste.Rows(i).Cells(0).Value = art(0) Then
                DataGridViewAjuste.Rows(i).Cells(2).Value = art(2)
                DataGridViewAjuste.Rows(i).Cells(4).Value = Val(art(2)) - Val(art(3))
                Exit Sub
            End If
        Next
        DataGridViewAjuste.Rows.Add(art(0), art(1), art(2), art(3), Val(art(2)) - Val(art(3)))
    End Sub

    Private Sub AjusteInventario_Load(sender As Object, e As EventArgs) Handles Me.Load
        opcion = 3
        conexion.Open()
        comando = conexion.CreateCommand
        comando.CommandText = "SELECT COUNT(*) FROM ajusteinventario"
        IdAjuste = comando.ExecuteScalar + 1
        conexion.Close()
    End Sub

    Private Sub BtnEditar_Click(sender As Object, e As EventArgs) Handles BtnEditar.Click
        Dim FrmArticuloAjuste As New EditarArticuloAjuste(DataGridViewAjuste.Rows(RowAjuste).Cells(0).Value,
                                                         DataGridViewAjuste.Rows(RowAjuste).Cells(1).Value,
                                                         DataGridViewAjuste.Rows(RowAjuste).Cells(3).Value)
        FrmArticuloAjuste.StartPosition = FormStartPosition.CenterScreen
        FrmArticuloAjuste.Show()
    End Sub

    Private Sub DataGridViewAjuste_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridViewAjuste.CellClick
        RowAjuste = e.RowIndex
    End Sub

    Private Sub BtnRemover_Click(sender As Object, e As EventArgs) Handles BtnRemover.Click
        DataGridViewAjuste.Rows.Remove(DataGridViewAjuste.Rows(RowAjuste))
    End Sub

    Private Sub BtnAjustar_Click(sender As Object, e As EventArgs) Handles BtnAjustar.Click
        Dim ans As String
        ans = MessageBox.Show("Estas seguro cerrar este ajuste?", "Cerrar Ajuste", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
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
            Dim R = "INSERT INTO ajusteinventario
                VALUES(" & IdAjuste & "," & UsuId & ",'" & DateAndTime.Now &
                    "','" & TxtComentario.Text & "')"
            comando.CommandText = R
            comando.ExecuteNonQuery()

            For i = 0 To DataGridViewAjuste.RowCount - 1
                R = "INSERT INTO ajusteinventarioarticulo
                VALUES(" & IdAjuste & ",'" & DataGridViewAjuste.Rows(i).Cells(0).Value &
                                    "'," & Val(DataGridViewAjuste.Rows(i).Cells(2).Value) & ")"
                comando.CommandText = R
                comando.ExecuteNonQuery()

                R = "UPDATE articulo
                    SET existencia = " & Val(DataGridViewAjuste.Rows(i).Cells(2).Value) &
                    " WHERE codigo=" & DataGridViewAjuste.Rows(i).Cells(0).Value
                comando.CommandText = R
                comando.ExecuteNonQuery()
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
                transaction.Rollback()
            Catch ex2 As Exception
                MsgBox("Error Rollback")
            End Try
        End Try
        conexion.Close()
        FormMenu.AbrirFormInPanel(New AjusteInventario)
        Me.Dispose()
    End Sub
End Class