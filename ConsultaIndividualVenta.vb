Imports System.Data.SqlClient
Public Class ConsultaIndividualVenta
    Dim Frm As ConsultaVenta = FormMenu.fm
    Dim conexion As New SqlConnection("Data Source=PIER18;Initial catalog=taller_refaccionaria; Integrated security = true")
    Dim comando As New SqlCommand
    Dim lector As SqlDataReader
    Private Sub ConsultaIndividualVenta_Load(sender As Object, e As EventArgs) Handles Me.Load
        conexion.Open()
        comando = conexion.CreateCommand

        Dim venid As Integer = Val(claveVentaSeleccionada)
        Dim R As String = "SELECT C.nombre, C.rfc, C.domicilio, C.ciudad, C.estado, C.codigoPostal, V.fecha ,V.comentario, V.total " &
                          "FROM cliente AS C INNER JOIN venta AS V ON V.cli_id = C.cli_id " &
                          "WHERE V.ven_id = " & venid
        comando.CommandText = R
        lector = comando.ExecuteReader
        lector.Read()
        LblNombre.Text = lector(0)
        LblRFC.Text = lector(1)
        LblDomicilio.Text = lector(2)
        LblCiudad.Text = lector(3)
        LblEstado.Text = lector(4)
        LblCP.Text = lector(5)
        LblDate.Text = lector(6)
        LblFolio.Text = venid
        LblComentario.Text = lector(7)
        LblTotal.Text = "Total: $" & lector(8) & " MXN"
        lector.Close()

        R = "SELECT DS.serv_id, S.descripcion, DS.precio FROM detalleservicio AS DS " &
            "INNER JOIN servicio AS S ON S.serv_id = DS.serv_id " &
            "INNER JOIN venta AS V ON V.ven_id = DS.ven_id " &
            "Where DS.ven_id = " & venid
        comando.CommandText = R
        lector = comando.ExecuteReader
        While lector.Read
            DataGridViewVenta.Rows.Add("N/A", lector(0), "*", lector(1), lector(2))
        End While
        lector.Close()

        R = "SELECT DV.cantidad, DV.codigo, A.descripcion, Dv.precio FROM detalleventa AS DV " &
            "INNER JOIN articulo AS A ON A.codigo = DV.codigo " &
            "INNER JOIN venta AS V ON V.ven_id = DV.ven_id " &
            "WHERE DV.ven_id = " & venid
        comando.CommandText = R
        lector = comando.ExecuteReader
        While lector.Read
            DataGridViewVenta.Rows.Add(lector(0), lector(1), "", lector(2), lector(3))
        End While
        lector.Close()


    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Me.Dispose()
    End Sub
End Class