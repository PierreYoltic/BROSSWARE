Imports System.Data.SqlClient
Public Class ConsultaIndividualCompra
    Dim Frm As ConsultaCompra = FormMenu.fm
    Dim conexion As New SqlConnection("Data Source=PIER18;Initial catalog=taller_refaccionaria; Integrated security = true")
    Dim comando As New SqlCommand
    Dim lector As SqlDataReader

    Private Sub ConsultaIndividualCompra_Load(sender As Object, e As EventArgs) Handles Me.Load
        conexion.Open()
        comando = conexion.CreateCommand

        Dim comid As Integer = Val(claveCompraSeleccionada)
        Dim R As String = "SELECT P.nombre, P.rfc, P.domicilio, P.ciudad, P.estado, P.codigoPostal, COM.fecha, COM.total " &
                          "FROM proveedor AS P INNER JOIN compra AS COM ON COM.pro_id = P.pro_id " &
                          "WHERE COM.com_id = " & comid
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
        LblFolio.Text = comid
        LblTotal.Text = "Total: $" & lector(7) & " MXN"
        lector.Close()

        R = "SELECT DC.codigo, A.descripcion, DC.cantidad, DC.costoCompra FROM detallecompra AS DC " &
            "INNER JOIN articulo AS A ON A.codigo = DC.codigo " &
            "INNER JOIN compra AS C ON C.com_id = DC.com_id " &
            "WHERE DC.com_id = " & comid
        comando.CommandText = R
        lector = comando.ExecuteReader
        While lector.Read
            DataGridViewCompra.Rows.Add(lector(0), lector(1), lector(2), lector(3), lector(3) * lector(2))
        End While
        lector.Close()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Me.Dispose()
    End Sub
End Class