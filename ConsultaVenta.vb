Imports System.Data.SqlClient
Public Class ConsultaVenta
    Dim conexion As New SqlConnection("Data Source=PIER18;Initial catalog=taller_refaccionaria; Integrated security = true")
    Dim comando As New SqlCommand
    Dim lector As SqlDataReader
    Public Row As Integer
    Public cliid As Integer
    Private Sub ConsultaVenta_Load(sender As Object, e As EventArgs) Handles Me.Load
        'conexion.Open()
        comando = conexion.CreateCommand
        ComboBoxEstado.SelectedIndex = 0
        'conexion.Close()

    End Sub

    Private Sub showVentas(estado)
        Dim estadoVenta As String = ""
        Dim FechaFinal As DateTime = DTPFechaFinal.Value
        FechaFinal = DateTime.Parse(FechaFinal.Date & " 23:59:59")
        conexion.Open()
        comando.CommandText = "EXEC showVentas @DateFrom = '" & DTPFechaInicial.Text & "'," &
                              " @DateTo = '" & FechaFinal & "'," &
                              " @estado = " & estado
        lector = comando.ExecuteReader
        While lector.Read
            If lector(3) = 1 Then
                estadoVenta = "Vigente"
            ElseIf lector(3) = 0 Then
                estadoVenta = "Cancelado"
            End If
            DataGridViewVentas.Rows.Add(lector(0), lector(1), lector(2), estadoVenta, lector(4))
        End While
        conexion.Close()
    End Sub

    Private Sub ComboBox1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ComboBoxEstado.SelectedIndexChanged
        DataGridViewVentas.Rows.Clear()

        If ComboBoxEstado.SelectedIndex = 0 Then
            showVentas(1)
            showVentas(0)
        ElseIf ComboBoxEstado.SelectedIndex = 1 Then
            showVentas(1)
        ElseIf ComboBoxEstado.SelectedIndex = 2 Then
            showVentas(0)
        End If
    End Sub

    Private Sub DTPFechaFinal_ValueChanged(sender As Object, e As EventArgs) Handles DTPFechaFinal.ValueChanged
        DataGridViewVentas.Rows.Clear()

        If ComboBoxEstado.SelectedIndex = 0 Then
            showVentas(1)
            showVentas(0)
        ElseIf ComboBoxEstado.SelectedIndex = 1 Then
            showVentas(1)
        ElseIf ComboBoxEstado.SelectedIndex = 2 Then
            showVentas(0)
        End If
    End Sub

    Private Sub DTPFechaInicial_ValueChanged(sender As Object, e As EventArgs) Handles DTPFechaInicial.ValueChanged
        DataGridViewVentas.Rows.Clear()

        If ComboBoxEstado.SelectedIndex = 0 Then
            showVentas(1)
            showVentas(0)
        ElseIf ComboBoxEstado.SelectedIndex = 1 Then
            showVentas(1)
        ElseIf ComboBoxEstado.SelectedIndex = 2 Then
            showVentas(0)
        End If
    End Sub

    Private Sub DataGridViewVentas_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridViewVentas.CellClick
        Row = e.RowIndex
        claveVentaSeleccionada = DataGridViewVentas.Rows(e.RowIndex).Cells(1).Value
    End Sub

    Private Sub BtnMostrar_Click(sender As Object, e As EventArgs) Handles BtnMostrar.Click
        ConsultaIndividualVenta.StartPosition = FormStartPosition.CenterParent
        ConsultaIndividualVenta.Show()
    End Sub
End Class