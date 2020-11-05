Imports System.Data.SqlClient
Public Class EditArticulo
    Dim conexion As New SqlConnection("Data Source=PIER18;Initial catalog=taller_refaccionaria; Integrated security = true")
    Dim comando As New SqlCommand
    Dim lector As SqlDataReader
    Dim idArticulo As Integer
    Private Sub BtnGuardar_Click(sender As Object, e As EventArgs) Handles BtnGuardar.Click
        Dim R As String
        Dim res = Articulos.BuscarClave(TxtClave.Text)

        If res <> 0 And TxtClave.Text <> claveArticuloSeleccionado Then
            'If TxtClave.Text <> claveArticuloSeleccionado Then
            Articulos.ValidarClaveExistente(TxtClave.Text, Me)
            'End If
        Else
            'comando = conexion.CreateCommand

            'R = "UPDATE articulo
            'SET codigo='" & TxtClave.Text &
            '    "', descripcion='" & TxtDescripcion.Text &
            '   "', invMin=" & Val(NumMin.Value) &
            '  ", invMax=" & Val(NumMax.Value) &
            ' ", costoCompraProm=" & Val(TxtPrecioC.Text) &
            '", precio=" & Val(TxtPrecioV.Text) &
            '", existencia=" & Val(NumExist.Value) &
            '", caracteristicas='" & TxtCaracteristicas.Text &
            '"', cat_id=" & ComboBoxCategoria.SelectedIndex + 1 &
            '"WHERE codigo=" & claveArticuloSeleccionado

            'comando.CommandText = R
            'comando.ExecuteNonQuery()
            'conexion.Close()

            'Articulos.updateData()
            If opcion = 1 Then
                Dim Frm As Articulos = FormMenu.fm
                Frm.DataGridViewArticulos.Rows(Frm.row).Cells(0).Value = TxtClave.Text
                Frm.DataGridViewArticulos.Rows(Frm.row).Cells(1).Value = TxtDescripcion.Text
                Frm.DataGridViewArticulos.Rows(Frm.row).Cells(2).Value = Val(NumExist.Value)
                Frm.DataGridViewArticulos.Rows(Frm.row).Cells(3).Value = Val(TxtPrecioV.Text)
                Frm.UpdateItems()
                Me.Dispose()
            End If

        End If


    End Sub

    Private Sub BtnCancelar_Click(sender As Object, e As EventArgs) Handles BtnCancelar.Click
        Me.Dispose()
    End Sub

    Private Sub EditArticulo_Load(sender As Object, e As EventArgs) Handles Me.Load

        'SqlDataAdapter1.Fill(Taller_refaccionariaDataSet.showActiveItems)
        conexion.Open()
        comando = conexion.CreateCommand

        comando.CommandText = "SELECT nombre FROM categoria"
        lector = comando.ExecuteReader
        While lector.Read()
            ComboBoxCategoria.Items.Add(lector(0))
        End While
        lector.Close()

        Dim R As String = "Select A.codigo, A.descripcion, A.invMin, A.invMax, A.costoCompraProm, A.precio, A.existencia, A.caracteristicas, A.cat_id " &
                            "FROM articulo AS A " &
                            "WHERE A.codigo = " & claveArticuloSeleccionado

        comando.CommandText = R
        lector = comando.ExecuteReader
        lector.Read()

        TxtClave.Text = lector(0)
        TxtDescripcion.Text = lector(1)

        NumMin.Text = lector(2)
        NumMax.Text = lector(3)
        TxtPrecioC.Text = lector(4)
        TxtPrecioV.Text = lector(5)
        NumExist.Text = lector(6)
        TxtCaracteristicas.Text = lector(7)
        ComboBoxCategoria.SelectedIndex = lector(8) - 1

        lector.Close()

    End Sub
End Class