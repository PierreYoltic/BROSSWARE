Imports System.Data.SqlClient
Public Class EditCliente
    Dim conexion As New SqlConnection("Data Source=PIER18;Initial catalog=taller_refaccionaria; Integrated security = true")
    Dim comando As New SqlCommand
    Dim lector As SqlDataReader
    Dim idCliente As Integer
    Private Sub BtnGuardar_Click(sender As Object, e As EventArgs) Handles BtnGuardar.Click
        BtnGuardar.Enabled = False
        Dim R As String

        R = "UPDATE articulo 
            SET nombre='" & TxtNombre.Text &
            "',domicilio='" & TxtCalle.Text &
            "',noExt'" & TxtNumExt.Text &
            "',noInt'" & TxtNumInt.Text &
            "',localidad='" & TxtLocalidad.Text &
            "',ciudad='" & TxtCiudad.Text &
            "',estado='" & ComboBoxEstado.Text &
            "',pais='" & TxtPais.Text &
            "',codigoPostal'" & TxtCP.Text &
            "',colonia'" & TxtColonia.Text &
            "',curp'" & TxtCURP.Text &
            "',telefono'" & TxtTelefono.Text &
            "',celular'" & TxtCelular.Text &
            "',mail'" & TxtEmail.Text &
            "',comentario'" & TxtComentario.Text &
            "',clave'" & TxtClave.Text &
            "' WHERE cli_id=" & idCliente

        comando.CommandText = R
        comando.ExecuteNonQuery()
        Me.Dispose()
    End Sub

    Private Sub BtnCancelar_Click(sender As Object, e As EventArgs) Handles BtnCancelar.Click
        Me.Dispose()
    End Sub

    Private Sub EditCliente_Load(sender As Object, e As EventArgs) Handles Me.Load
        conexion.Open()
        comando = conexion.CreateCommand

        comando.CommandText = "SELECT C.cli_id FROM cliente AS C WHERE C.clave='" & claveClienteSeleccionado & "'"
        lector = comando.ExecuteReader
        lector.Read()
        idCliente = lector(0)
        lector.Close()

        Dim R As String = "Select C.clave, C.nombre, C.domicilio, C.numExt, C.numInt, 
                            C.localidad, C.ciudad, C.estado, C.pais, C.codigoPostal, 
                            C.colonia, C.curp, C.telefono, C.celular, C.mail, C.comentario" &
                            "FROM cliente AS C " &
                            "WHERE C.cli_id = " & idCliente
        ''MsgBox(R)

        comando.CommandText = R
        lector = comando.ExecuteReader
        lector.Read()

        TxtClave.Text = lector(0)
        TxtNombre.Text = lector(1)
        TxtCalle.Text = lector(2)
        TxtNumExt.Text = lector(3)
        TxtNumInt.Text = lector(4)
        TxtLocalidad.Text = lector(5)
        TxtCiudad.Text = lector(6)
        ComboBoxEstado.Text = lector(7)
        TxtPais.Text = lector(8)
        TxtCP.Text = lector(9)
        TxtColonia.Text = lector(10)
        TxtCURP.Text = lector(11)
        TxtTelefono.Text = lector(12)
        TxtCelular.Text = lector(13)
        TxtEmail.Text = lector(14)
        TxtComentario.Text = lector(15)


        lector.Close()
    End Sub
End Class