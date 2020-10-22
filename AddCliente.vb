Imports System.Data.SqlClient
Public Class AddCliente
    Dim conexion As New SqlConnection("Data Source=PIER18;Initial catalog=taller_refaccionaria; Integrated security = true")
    Dim comando As New SqlCommand
    Dim lector As SqlDataReader
    Dim id As Integer
    Private Sub BtnGuardar_Click(sender As Object, e As EventArgs) Handles BtnGuardar.Click
        BtnGuardar.Enabled = False
        Dim R As String

        R = "INSERT INTO cliente VALUES(" & id &
            ",'" & TxtNombre.Text &
            "','" & TxtCalle.Text &
            "','" & TxtNumExt.Text &
            "','" & TxtNumInt.Text &
            "','" & TxtLocalidad.Text &
            "','" & TxtCiudad.Text &
            "','" & ComboBoxEstado.Text &
            "','" & TxtPais.Text &
            "','" & TxtCP.Text &
            "','" & TxtColonia.Text &
            "','" & TxtCURP.Text &
            "','" & TxtTelefono.Text &
            "','" & TxtCelular.Text &
            "','" & TxtEmail.Text &
            "','" & TxtComentario.Text &
            "','" & TxtClave.Text & "')"

        comando.CommandText = R
        comando.ExecuteNonQuery()
        Me.Dispose()

    End Sub

    Private Sub BtnCancelar_Click(sender As Object, e As EventArgs) Handles BtnCancelar.Click
        Me.Dispose()
    End Sub

    Private Sub AddCliente_Load(sender As Object, e As EventArgs) Handles Me.Load
        conexion.Open()
        comando = conexion.CreateCommand
        comando.CommandText = "SELECT COUNT(*) FROM cliente"
        id = comando.ExecuteScalar + 1
    End Sub
End Class