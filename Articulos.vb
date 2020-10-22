Imports System.Data.SqlClient
Public Class Articulos
    Dim conexion As New SqlConnection("Data Source=PIER18;Initial catalog=taller_refaccionaria; Integrated security = true")
    Dim comando As New SqlCommand
    Dim lector As SqlDataReader
    Private Sub Articulos_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'Taller_refaccionariaDataSet.articulo' table. You can move, or remove it, as needed.
        Me.ArticuloTableAdapter.Fill(Me.Taller_refaccionariaDataSet.articulo)
    End Sub



    Private Sub BtnEditar_Click(sender As Object, e As EventArgs) Handles BtnEditar.Click
        EditArticulo.StartPosition = FormStartPosition.CenterScreen
        EditArticulo.ShowDialog()

    End Sub


    Private Sub DataGridViewArticulos_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridViewArticulos.CellClick
        claveArticuloSeleccionado = DataGridViewArticulos.CurrentRow.Cells(0).Value.ToString
        ''MsgBox(claveArticuloSeleccionado)
    End Sub

    Private Sub BtnEliminar_Click(sender As Object, e As EventArgs) Handles BtnEliminar.Click
        conexion.Open()
        comando = conexion.CreateCommand
        Dim R As String

        Dim answer As Integer = MessageBox.Show("Estas seguro de eliminar este artículo?", "CONFIRMACIÓN DE ELIMINAÇIÓN", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
        If answer = vbYes Then
            R = "UPDATE articulo
            SET status=" & -1 &
           "WHERE clave='" & claveArticuloSeleccionado & "'"

            comando.CommandText = R
            comando.ExecuteNonQuery()

        End If
    End Sub

    Private Sub BtnAgregar_Click(sender As Object, e As EventArgs) Handles BtnAgregar.Click

        AddArticulos.StartPosition = FormStartPosition.CenterScreen
        AddArticulos.ShowDialog()
    End Sub

    Private Sub SqlDataAdapter1_RowUpdated(sender As Object, e As SqlRowUpdatedEventArgs)
        If e.Status = UpdateStatus.ErrorsOccurred Then
            MessageBox.Show(e.Errors.Message & vbCrLf &
                            e.Row.Item("Nombre", DataRowVersion.Original) & vbCrLf &
                            e.Row.Item("Nombre", DataRowVersion.Current))
            e.Status = UpdateStatus.SkipCurrentRow
        End If
    End Sub


End Class