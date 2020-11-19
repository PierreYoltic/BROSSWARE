Imports System.Data.SqlClient
Public Class ConsultaAjuste
    Dim conexion As New SqlConnection("Data Source=PIER18;Initial catalog=taller_refaccionaria; Integrated security = true")
    Dim comando As New SqlCommand
    Dim lector As SqlDataReader

    Public Row As Integer
    Private Sub showAjuste()
        Dim FechaFinal As DateTime = DTPFechaFinal.Value
        FechaFinal = DateTime.Parse(FechaFinal.Date & " 23:59:59")
        conexion.Open()
        comando = conexion.CreateCommand
        comando.CommandText = "EXEC showAjustes @DateFrom = '" & DTPFechaInicial.Text & "'," &
                              " @DateTo = '" & FechaFinal & "'"
        lector = comando.ExecuteReader
        While lector.Read
            DataGridViewAjuste.Rows.Add(lector(0), lector(1), lector(2), lector(3))
        End While
        conexion.Close()
    End Sub

    Private Sub DTPFechaInicial_ValueChanged(sender As Object, e As EventArgs) Handles DTPFechaInicial.ValueChanged
        DataGridViewAjuste.Rows.Clear()
        showAjuste()
    End Sub

    Private Sub DTPFechaFinal_ValueChanged(sender As Object, e As EventArgs) Handles DTPFechaFinal.ValueChanged
        DataGridViewAjuste.Rows.Clear()
        showAjuste()
    End Sub

    Private Sub DataGridViewAjuste_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridViewAjuste.CellClick
        Row = e.RowIndex
        claveAjusteSeleccionado = DataGridViewAjuste.Rows(e.RowIndex).Cells(0).Value
    End Sub

    Private Sub BtnMostrar_Click(sender As Object, e As EventArgs) Handles BtnMostrar.Click
        ConsultaIndividualAjuste.StartPosition = FormStartPosition.CenterParent
        ConsultaIndividualAjuste.Show()
    End Sub

    Private Sub ConsultaAjuste_Load(sender As Object, e As EventArgs) Handles Me.Load
        showAjuste()
    End Sub
End Class