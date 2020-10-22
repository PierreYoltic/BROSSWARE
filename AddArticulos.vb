Imports System.Data.SqlClient
Public Class AddArticulos
    Dim conexion As New SqlConnection("Data Source=PIER18;Initial catalog=taller_refaccionaria; Integrated security = true")
    Dim comando As New SqlCommand
    Dim lector As SqlDataReader
    Dim id As Integer
    Private Sub BtnCancelar_Click(sender As Object, e As EventArgs) Handles BtnCancelar.Click
        Me.Dispose()
    End Sub

    Private Sub BtnGuardar_Click(sender As Object, e As EventArgs) Handles BtnGuardar.Click
        BtnGuardar.Enabled = False
        Dim R As String
        Dim Servicio As Integer


        If CheckBoxServicio.Checked Then
            Servicio = 1
        Else
            Servicio = 0
        End If

        R = "INSERT INTO articulo
            VALUES(" & id & ",'" & TxtClave.Text & "','" & TxtClaveAlterna.Text & "','" & TxtDescripcion.Text & "'," & Servicio &
            "," & Val(NumMin.Value) & "," & Val(NumMax.Value) & "," & Val(TxtPrecioC.Text) & "," & Val(TxtPrecioC.Text) & "," & Val(TxtPrecioV.Text) &
            "," & Val(NumExist.Value) & ",'" & TxtCaracteristicas.Text & "'," & 1 & ")"

        comando.CommandText = R
        comando.ExecuteNonQuery()

        Articulos.Dispose()
        FormMenu.AbrirFormInPanel(New Articulos())

        Me.Dispose()
    End Sub

    Private Sub AddArticulos_Load(sender As Object, e As EventArgs) Handles Me.Load
        conexion.Open()
        comando = conexion.CreateCommand
        comando.CommandText = "SELECT COUNT(*) FROM articulo"
        id = comando.ExecuteScalar + 1
    End Sub
End Class
