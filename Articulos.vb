Imports System.Data.SqlClient
Public Class Articulos
    Dim conexion As New SqlConnection("Data Source=PIER18;Initial catalog=taller_refaccionaria; Integrated security = true")
    Dim comando As New SqlCommand
    Dim lector As SqlDataReader
    Public row
    Private Sub Articulos_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'Taller_refaccionariaDataSet.showActiveItems' table. You can move, or remove it, as needed.
        'Me.ShowActiveItemsTableAdapter.Fill(Me.Taller_refaccionariaDataSet.showActiveItems)
        'TODO: This line of code loads data into the 'Taller_refaccionariaDataSet.showActiveItems' table. You can move, or remove it, as needed.
        'Me.ShowActiveItemsTableAdapter.Fill(Me.Taller_refaccionariaDataSet.showActiveItems)
        SqlDataAdapter1.Fill(Taller_refaccionariaDataSet.showActiveItems)
        opcion = 1


    End Sub

    Private Sub BtnEditar_Click(sender As Object, e As EventArgs) Handles BtnEditar.Click

        If claveArticuloSeleccionado = vbNullString Then
            MessageBox.Show("Debes seleccionar un artículo de la lista para poder editarlo", "MENSAJE", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
        Else
            EditArticulo.StartPosition = FormStartPosition.CenterScreen
            EditArticulo.ShowDialog()
        End If

    End Sub



    Private Sub BtnEliminar_Click(sender As Object, e As EventArgs) Handles BtnEliminar.Click
        conexion.Open()
        comando = conexion.CreateCommand
        Dim R As String

        Dim answer As Integer = MessageBox.Show("Estas seguro de eliminar este artículo?", "CONFIRMACIÓN DE ELIMINAÇIÓN", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
        If answer = vbYes Then
            R = "UPDATE articulo
            SET status=" & -1 &
           "WHERE codigo='" & claveArticuloSeleccionado & "'"

            comando.CommandText = R
            comando.ExecuteNonQuery()


            'ShowActiveItemsTableAdapter.Fill(Taller_refaccionariaDataSet.showActiveItems)
            '
            'DataGridViewArticulos
            UpdateItems()
            conexion.Close()
            claveArticuloSeleccionado = vbNullString
        End If

        conexion.Close()
    End Sub

    Private Sub BtnAgregar_Click(sender As Object, e As EventArgs) Handles BtnAgregar.Click
        AddArticulos.StartPosition = FormStartPosition.CenterScreen
        AddArticulos.ShowDialog()
    End Sub

    Private Sub DataGridViewArticulos_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridViewArticulos.CellClick
        claveArticuloSeleccionado = DataGridViewArticulos.CurrentRow.Cells(0).Value.ToString
    End Sub

    Public Function BuscarClave(ByVal key As String) As Integer
        Dim R As String
        conexion.Open()
        comando = conexion.CreateCommand

        R = "SELECT COUNT(codigo)
             FROM articulo
             WHERE codigo = '" & key & "'"
        comando.CommandText = R
        lector = comando.ExecuteReader
        lector.Read()


        Dim res = Val(lector(0))
        lector.Close()
        conexion.Close()
        Return res
    End Function

    Public Sub ValidarClaveExistente(ByVal key As String, ByRef form As Form)
        conexion.Open()
        comando = conexion.CreateCommand
        Dim R As String = "SELECT status
             FROM articulo
             WHERE codigo = '" & key & "'"

        comando.CommandText = R
        lector = comando.ExecuteReader
        lector.Read()
        Dim res = Val(lector(0))
        lector.Close()

        If res = 1 Then
            MessageBox.Show("Ya existe un artículo con el mismo CÓDIGO, debes cambiarla", "CÓDIGO REPETIDO", MessageBoxButtons.OK, MessageBoxIcon.Error)
            conexion.Close()
            Exit Sub
        ElseIf res = -1 Then
            MessageBox.Show("El artículo que intentas agregar tiene un código de un Artículo eliminado, por lo tanto se recuperará", "CÓDIGO ANTERIORMENTE REGISTRADO", MessageBoxButtons.OK, MessageBoxIcon.Information)
            'lector.Close()
            R = "UPDATE articulo SET status = 1 WHERE codigo='" & key & "'"
            comando.CommandText = R
            comando.ExecuteNonQuery()
            conexion.Close()
            Me.Dispose()
            FormMenu.AbrirFormInPanel(New Articulos())
            form.Dispose()
        End If
    End Sub

    Private Sub SqlDataAdapter1_RowUpdated(sender As Object, e As SqlRowUpdatedEventArgs) Handles SqlDataAdapter1.RowUpdated

        If e.Status = UpdateStatus.ErrorsOccurred Then
            MessageBox.Show(e.Errors.Message & vbCrLf &
                            e.Row.Item("Descripción", DataRowVersion.Original) & vbCrLf &
                            e.Row.Item("Descripción", DataRowVersion.Current))
            e.Status = UpdateStatus.SkipCurrentRow
        End If

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        SqlDataAdapter1.Update(Taller_refaccionariaDataSet.showActiveItems)
        Taller_refaccionariaDataSet.showActiveItems.Clear()
        SqlDataAdapter1.Fill(Taller_refaccionariaDataSet.showActiveItems)
    End Sub

    Public Sub UpdateItems()
        ShowActiveItemsBindingSource.EndEdit()
        SqlDataAdapter1.Update(Taller_refaccionariaDataSet.showActiveItems)
        Taller_refaccionariaDataSet.showActiveItems.Clear()
        SqlDataAdapter1.Fill(Taller_refaccionariaDataSet.showActiveItems)
    End Sub
End Class