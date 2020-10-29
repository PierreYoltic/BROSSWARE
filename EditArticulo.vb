Imports System.Data.SqlClient
Public Class EditArticulo
    Dim conexion As New SqlConnection("Data Source=PIER18;Initial catalog=taller_refaccionaria; Integrated security = true")
    Dim comando As New SqlCommand
    Dim lector As SqlDataReader
    Dim idArticulo As Integer
    Private Sub BtnGuardar_Click(sender As Object, e As EventArgs) Handles BtnGuardar.Click
        Dim R As String
        Dim Servicio As Integer
        Dim res = Articulos.BuscarClave(TxtClave.Text)

        If res <> 0 And TxtClave.Text <> claveArticuloSeleccionado Then
            'If TxtClave.Text <> claveArticuloSeleccionado Then
            Articulos.ValidarClaveExistente(TxtClave.Text, Me)
            'End If
        Else
            If CheckBoxServicio.Checked Then
                Servicio = 1
            Else
                Servicio = 0
            End If

            conexion.Open()
            comando = conexion.CreateCommand

            R = "UPDATE articulo
            SET clave='" & TxtClave.Text &
                "', claveAlterna='" & TxtClaveAlterna.Text &
                "', descripcion='" & TxtDescripcion.Text &
                "', servicio=" & Servicio &
                ", invMin=" & Val(NumMin.Value) &
                ", invMax=" & Val(NumMax.Value) &
                ", precioCompra=" & Val(TxtPrecioC.Text) &
                ", precio1=" & Val(TxtPrecioV.Text) &
                ", existencia=" & Val(NumExist.Value) &
                ", caracteristicas='" & TxtCaracteristicas.Text &
                "' WHERE art_id=" & idArticulo

            comando.CommandText = R
            comando.ExecuteNonQuery()
            conexion.Close()

            'Articulos.updateData()

            Articulos.Dispose()
            FormMenu.AbrirFormInPanel(New Articulos())

            Me.Dispose()
        End If


    End Sub

    Private Sub BtnCancelar_Click(sender As Object, e As EventArgs) Handles BtnCancelar.Click
        Me.Dispose()
    End Sub

    Private Sub EditArticulo_Load(sender As Object, e As EventArgs) Handles Me.Load

        conexion.Open()
        comando = conexion.CreateCommand

        comando.CommandText = "SELECT A.art_id FROM articulo AS A WHERE A.clave='" & claveArticuloSeleccionado & "'"
        lector = comando.ExecuteReader
        lector.Read()
        idArticulo = lector(0)
        lector.Close()

        Dim R As String = "Select A.clave, A.claveAlterna, A.descripcion, A.servicio, A.invMin, A.invMax, A.precioCompra, A.precio1, A.existencia, A.caracteristicas " &
                            "FROM articulo AS A " &
                            "WHERE A.art_id = " & idArticulo


        comando.CommandText = R
        lector = comando.ExecuteReader
        lector.Read()

        TxtClave.Text = lector(0)
        TxtClaveAlterna.Text = lector(1)
        TxtDescripcion.Text = lector(2)

        If lector(3) = "1" Then
            CheckBoxServicio.Checked = True
        Else
            CheckBoxServicio.Checked = False
        End If

        NumMin.Text = lector(4)
        NumMax.Text = lector(5)
        TxtPrecioC.Text = lector(6)
        TxtPrecioV.Text = lector(7)
        NumExist.Text = lector(8)
        TxtCaracteristicas.Text = lector(9)

        lector.Close()
        conexion.Close()

    End Sub
End Class