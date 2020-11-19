Imports System.Data.SqlClient
Public Class ConsultaIndividualAjuste
    Dim conexion As New SqlConnection("Data Source=PIER18;Initial catalog=taller_refaccionaria; Integrated security = true")
    Dim comando As New SqlCommand
    Dim lector As SqlDataReader

    Private Sub ConsultaIndividualAjuste_Load(sender As Object, e As EventArgs) Handles Me.Load
        conexion.Open()
        comando = conexion.CreateCommand

        Dim ajuid As Integer = Val(claveAjusteSeleccionado)
        Dim R As String = "SELECT U.nombre, A.fecha, A.comentario " &
                          "FROM usuario U INNER JOIN ajusteinventario A ON A.usu_id = U.usu_id " &
                          "WHERE A.ain_id = " & ajuid
        comando.CommandText = R
        lector = comando.ExecuteReader
        lector.Read()
        LblUsuario.Text = lector(0)
        LblDate.Text = lector(1)
        LblComentario.Text = lector(2)
        lector.Close()

        R = "SELECT AIA.codigo, A.descripcion, AIA.cantidad FROM ajusteinventarioarticulo AIA " &
            "INNER JOIN articulo A ON A.codigo = AIA.codigo " &
            "INNER JOIN ajusteinventario AI ON AIA.ain_id = AI.ain_id " &
            "WHERE AI.ain_id = " & ajuid
        comando.CommandText = R
        lector = comando.ExecuteReader
        While lector.Read
            DataGridViewAjuste.Rows.Add(lector(0), lector(1), lector(2))
        End While
        lector.Close()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Me.Dispose()
    End Sub
End Class