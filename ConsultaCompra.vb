Imports System.Data.SqlClient
Public Class ConsultaCompra
    Dim conexion As New SqlConnection("Data Source=PIER18;Initial catalog=taller_refaccionaria; Integrated security = true")
    Dim comando As New SqlCommand
    Dim lector As SqlDataReader

    Public Row As Integer
    Public proid As Integer
    Private Sub ConsultaCompra_Load(sender As Object, e As EventArgs) Handles Me.Load
        comando = conexion.CreateCommand
        ComboBoxEstado.SelectedIndex = 0
    End Sub
    Private Sub showCompras(estado)
        Dim estadoCompra As String = ""
        Dim FechaFinal As DateTime = DTPFechaFinal.Value
        FechaFinal = DateTime.Parse(FechaFinal.Date & " 23:59:59")
        conexion.Open()
        comando.CommandText = "EXEC showCompras @DateFrom = '" & DTPFechaInicial.Text & "'," &
                              " @DateTo = '" & FechaFinal & "'," &
                              " @estado = " & estado
        lector = comando.ExecuteReader
        While lector.Read
            If lector(3) = 1 Then
                estadoCompra = "Vigente"
            ElseIf lector(3) = 0 Then
                estadoCompra = "Cancelado"
            End If
            DataGridViewCompras.Rows.Add(lector(0), lector(1), lector(2), estadoCompra, lector(4))
        End While
        conexion.Close()
    End Sub
    Private Sub ComboBoxEstado_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ComboBoxEstado.SelectedIndexChanged
        DataGridViewCompras.Rows.Clear()

        If ComboBoxEstado.SelectedIndex = 0 Then
            showCompras(1)
            showCompras(0)
        ElseIf ComboBoxEstado.SelectedIndex = 1 Then
            showCompras(1)
        ElseIf ComboBoxEstado.SelectedIndex = 2 Then
            showCompras(0)
        End If
    End Sub
    Private Sub DTPFechaFinal_ValueChanged(sender As Object, e As EventArgs) Handles DTPFechaFinal.ValueChanged
        DataGridViewCompras.Rows.Clear()

        If ComboBoxEstado.SelectedIndex = 0 Then
            showCompras(1)
            showCompras(0)
        ElseIf ComboBoxEstado.SelectedIndex = 1 Then
            showCompras(1)
        ElseIf ComboBoxEstado.SelectedIndex = 2 Then
            showCompras(0)
        End If
    End Sub
    Private Sub DTPFechaInicial_ValueChanged(sender As Object, e As EventArgs) Handles DTPFechaInicial.ValueChanged
        DataGridViewCompras.Rows.Clear()

        If ComboBoxEstado.SelectedIndex = 0 Then
            showCompras(1)
            showCompras(0)
        ElseIf ComboBoxEstado.SelectedIndex = 1 Then
            showCompras(1)
        ElseIf ComboBoxEstado.SelectedIndex = 2 Then
            showCompras(0)
        End If
    End Sub
    Private Sub DataGridViewCompras_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridViewCompras.CellClick
        Row = e.RowIndex
        claveCompraSeleccionada = DataGridViewCompras.Rows(e.RowIndex).Cells(1).Value
    End Sub
    Private Sub BtnMostrar_Click(sender As Object, e As EventArgs) Handles BtnMostrar.Click
        ConsultaIndividualCompra.StartPosition = FormStartPosition.CenterParent
        ConsultaIndividualCompra.Show()
    End Sub
End Class