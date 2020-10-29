Imports System.Data.SqlClient
Public Class Clientes
    Dim conexion As New SqlConnection("Data Source=PIER18;Initial catalog=taller_refaccionaria; Integrated security = true")
    Dim comando As New SqlCommand
    Dim lector As SqlDataReader
    Dim idCliente As Integer
    Private Sub Clientes_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'Taller_refaccionariaDataSet.showActiveClients' table. You can move, or remove it, as needed.
        Me.ShowActiveClientsTableAdapter.Fill(Me.Taller_refaccionariaDataSet.showActiveClients)

        conexion.Open()
        comando = conexion.CreateCommand

    End Sub

    Private Sub DataGridViewClientes_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridViewClientes.CellClick
        claveClienteSeleccionado = DataGridViewClientes.CurrentRow.Cells(0).Value.ToString
    End Sub

    Private Sub BtnAgregar_Click_1(sender As Object, e As EventArgs) Handles BtnAgregar.Click
        AddCliente.StartPosition = FormStartPosition.CenterScreen
        AddCliente.ShowDialog()
    End Sub

    Private Sub BtnEditar_Click_1(sender As Object, e As EventArgs) Handles BtnEditar.Click
        comando.CommandText = "SELECT C.cli_id FROM cliente AS C WHERE C.clave='" & claveClienteSeleccionado & "'"
        lector = comando.ExecuteReader
        lector.Read()
        idCliente = lector(0)
        lector.Close()

        EditCliente.StartPosition = FormStartPosition.CenterScreen
        EditCliente.ShowDialog()
    End Sub

    Private Sub BtnEliminar_Click_1(sender As Object, e As EventArgs) Handles BtnEliminar.Click
        Dim R As String

        Dim answer As Integer = MessageBox.Show("Estas seguro de eliminar este cliente?", "CONFIRMACIÓN DE ELIMINAÇIÓN", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
        If answer = vbYes Then
            R = "UPDATE cliente
            SET status=" & -1 &
           "WHERE cli_id='" & idCliente & "'"

            comando.CommandText = R
            comando.ExecuteNonQuery()

        End If
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click

    End Sub
End Class