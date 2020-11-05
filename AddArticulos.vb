Imports System.Data.SqlClient
Public Class AddArticulos
    Dim conexion As New SqlConnection("Data Source=PIER18;Initial catalog=taller_refaccionaria; Integrated security = true")
    Dim comando As New SqlCommand
    Dim id As Integer
    Dim lector As SqlDataReader
    Dim Frm As Articulos = FormMenu.fm
    Private Sub BtnCancelar_Click(sender As Object, e As EventArgs) Handles BtnCancelar.Click
        conexion.Close()
        Me.Dispose()
    End Sub

    Private Sub BtnGuardar_Click(sender As Object, e As EventArgs) Handles BtnGuardar.Click
        Dim R As String
        Dim res = Articulos.BuscarClave(TxtClave.Text)

        If res <> 0 Then
            Articulos.ValidarClaveExistente(TxtClave.Text, Me)

        Else
            Dim cat = ComboBoxCategoria.SelectedIndex + 1

            comando = conexion.CreateCommand

            R = "INSERT INTO articulo
            VALUES('" & TxtClave.Text & "','" & TxtDescripcion.Text &
                "'," & Val(NumMin.Value) & "," & Val(NumMax.Value) & "," & Val(TxtPrecioC.Text) & "," & Val(TxtPrecioV.Text) &
                "," & Val(NumExist.Value) & ",'" & TxtCaracteristicas.Text & "'," & 1 & "," & cat & ")"

            comando.CommandText = R
            comando.ExecuteNonQuery()

            conexion.Close()
            Frm.UpdateItems()

            Me.Dispose()
        End If

    End Sub

    Private Sub AddArticulos_Load(sender As Object, e As EventArgs) Handles Me.Load
        'TODO: This line of code loads data into the 'Taller_refaccionariaDataSet.articulo' table. You can move, or remove it, as needed.
        Me.ArticuloTableAdapter.Fill(Me.Taller_refaccionariaDataSet.articulo)
        conexion.Open()
        comando = conexion.CreateCommand
        comando.CommandText = "SELECT COUNT(*) FROM articulo"
        id = comando.ExecuteScalar + 1

        comando.CommandText = "SELECT nombre FROM categoria"
        lector = comando.ExecuteReader
        While lector.Read()
            ComboBoxCategoria.Items.Add(lector(0))
        End While
        lector.Close()

        ComboBoxCategoria.SelectedIndex = 0

    End Sub


End Class
