Imports System.ComponentModel

Public Class BuscarCliente
    Dim nombre As String
    Dim idCliente As Integer

    Private Sub BuscarCliente_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'Taller_refaccionariaDataSet.showActiveClients' table. You can move, or remove it, as needed.
        Me.ShowActiveClientsTableAdapter.Fill(Me.Taller_refaccionariaDataSet.showActiveClients)

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Me.Dispose()
    End Sub

    Private Sub DataGridViewClientes_CellMouseDoubleClick(sender As Object, e As DataGridViewCellMouseEventArgs) Handles DataGridViewClientes.CellMouseDoubleClick
        nombre = DataGridViewClientes.Rows(e.RowIndex).Cells(2).Value.ToString
        idCliente = DataGridViewClientes.Rows(e.RowIndex).Cells(0).Value


        Me.Close()
    End Sub

    Private Sub BuscarCliente_Closing(sender As Object, e As CancelEventArgs) Handles Me.Closing

        If opcion = 1 Then
            Dim frm As Ventas = FormMenu.fm
            frm.TxtCliente.Text = nombre
            frm.TxtIdCliente.Text = idCliente
        End If
        Me.Dispose()
    End Sub


End Class