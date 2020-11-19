Imports System.Data.SqlClient
Imports Microsoft.Reporting.WinForms
Imports System.Configuration
Imports System.ComponentModel
Public Class ReporteComprasArticulos
    Dim conexion As New SqlConnection("Data Source=PIER18;Initial catalog=taller_refaccionaria; Integrated security = true")
    Dim comando As New SqlCommand
    Dim lector As SqlDataReader

    Dim estado As Integer

    Dim fechaInicial As String
    Dim fechaFin As String
    Dim status As String
    Dim proveedor As String
    Dim cat As Integer = -1
    Dim categoria As String = "Todas"
    Dim ordr As String = "descripcion "
    Dim orden As String = "Descripción"
    Dim ordenamiento As String = "ASC"

    Dim Frm As New ReporteComprasGeneral
    Private Sub ReporteComprasArticulos_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ComboBoxEstado.SelectedIndex = 0
        proveedor = "Todos"
        status = ComboBoxEstado.Text
        fechaInicial = DTPFechaInicial.Text
        fechaFin = DTPFechaFinal.Text

        conexion.Open()
        comando = conexion.CreateCommand
        comando.CommandText = "SELECT nombre FROM categoria WHERE status = 1"
        lector = comando.ExecuteReader
        While lector.Read()
            CboCategoria.Items.Add(lector(0))
        End While
        lector.Close()
        conexion.Close()
    End Sub

    Private Sub CheckBoxProveedor_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBoxProveedor.CheckedChanged
        If CheckBoxProveedor.Checked Then
            proveedor = "Todos"
            TxtProveedor.Enabled = False
        Else
            TxtProveedor.Enabled = True
            proveedor = TxtProveedor.Text
        End If
    End Sub

    Private Sub BtnMostrar_Click(sender As Object, e As EventArgs) Handles BtnMostrar.Click
        conexion.Open()

        Dim FechaFinal As DateTime = DTPFechaFinal.Value
        FechaFinal = DateTime.Parse(FechaFinal.Date & " 23:59:59")
        Dim R As String = "SELECT * FROM comprasArticulos WHERE fecha BETWEEN '" & DTPFechaInicial.Value.Date & "' AND '" & FechaFinal & "' "

        If CheckBoxProveedor.Checked = False Then
            R += "AND pro_id = " & TxtIdProveedor.Text & " "
        End If
        If CheckBoxCategoria.Checked = False Then
            R += "AND cat_id = " & cat & " "
        End If
        If CheckBoxArticulo.Checked = False Then
            R += "AND codigo = '" & TxtCodigo.Text & "' "
        End If
        If ComboBoxEstado.SelectedIndex <> 0 Then
            R = "AND estado = " & estado
        End If

        R += "ORDER BY " & ordr & ordenamiento
        MsgBox(R)

        Dim Data As New DataSet("Data1")

        Dim command As New SqlCommand(R, conexion)
        Dim Adaptador As New SqlDataAdapter(command)
        Adaptador.Fill(Data)

        'MsgBox(Adaptador.ToString)
        'Data.DataSetName = "Data1"


        Dim DataSource As New ReportDataSource("DataSet1", Data.Tables(0))
        DataSource.Name = "DataSet1"
        DataSource.Value = Data.Tables(0)

        Dim p1 As New ReportParameter("fechaIni", fechaInicial)
        Dim p2 As New ReportParameter("fechaFinal", fechaFin)
        Dim p3 As New ReportParameter("proveedor", proveedor)
        Dim p4 As New ReportParameter("categoria", categoria)
        Dim p5 As New ReportParameter("estado", status)
        Dim p6 As New ReportParameter("orden", orden)
        Dim p7 As New ReportParameter("fecha", DateAndTime.Now.ToString)

        Frm.ReportViewer1.LocalReport.ReportPath = "C:\Users\Pierre Yoltic\Documents\MotoBox\ReporteComprasArticulos.rdlc"

        Frm.ReportViewer1.LocalReport.DataSources.Clear()
        'ReporteExistenciaArticulos.ReportViewer1.LocalReport.DataSources.RemoveAt(0)
        Frm.ReportViewer1.LocalReport.DataSources.Add(DataSource)
        'ReporteExistenciaArticulos.ReportViewer1.LocalReport.ReportPath = Application.StartupPath & "\ReporteAsistenciaMenores.rdlc"
        Frm.ReportViewer1.LocalReport.SetParameters(New ReportParameter() {p1, p2, p3, p4, p5, p6, p7})
        Frm.ReportViewer1.RefreshReport()
        Frm.WindowState = FormWindowState.Maximized
        FormMenu.AbrirFormInPanel(New ReporteComprasArticulos)
        Frm.Show()
        conexion.Close()

        Me.Dispose()
    End Sub

    Private Sub ComboBoxEstado_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ComboBoxEstado.SelectedIndexChanged
        If ComboBoxEstado.SelectedIndex = 1 Then
            estado = 1
        ElseIf ComboBoxEstado.SelectedIndex = 2 Then
            estado = 0
        End If
        status = ComboBoxEstado.Text
    End Sub

    Private Sub DTPFechaInicial_ValueChanged(sender As Object, e As EventArgs) Handles DTPFechaInicial.ValueChanged
        fechaInicial = DTPFechaInicial.Value.Date
    End Sub

    Private Sub DTPFechaFinal_ValueChanged(sender As Object, e As EventArgs) Handles DTPFechaFinal.ValueChanged
        Dim FechaFinal As DateTime = DTPFechaFinal.Value
        fechaFin = FechaFinal.Date
    End Sub

    Private Sub CboCategoria_SelectedIndexChanged(sender As Object, e As EventArgs) Handles CboCategoria.SelectedIndexChanged
        cat = CboCategoria.SelectedIndex + 1
        categoria = CboCategoria.Text
    End Sub

    Private Sub CheckBox1_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBoxCategoria.CheckedChanged
        If CheckBoxCategoria.Checked Then
            cat = -1
            categoria = "Todas"
            CboCategoria.Enabled = False
        Else
            CboCategoria.Enabled = True
            cat = CboCategoria.SelectedIndex + 1
            categoria = CboCategoria.Text
        End If
    End Sub

    Private Sub CboOrden_SelectedIndexChanged(sender As Object, e As EventArgs) Handles CboOrden.SelectedIndexChanged
        If CboOrden.SelectedIndex = 0 Then
            ordr = "descripcion "
            orden = "Descripción"
        ElseIf CboOrden.SelectedIndex = 1 Then
            ordr = "codigo "
            orden = "Código"
        ElseIf CboOrden.SelectedIndex = 1 Then
            ordr = "cat_id "
            orden = "Categoría"
        Else
            ordr = "cantidad "
            orden = "Cantidad"
        End If
    End Sub

    Private Sub CboAscDesc_SelectedIndexChanged(sender As Object, e As EventArgs) Handles CboAscDesc.SelectedIndexChanged
        If CboAscDesc.SelectedIndex = 0 Then
            ordenamiento = "ASC"
        Else
            ordenamiento = "DESC"
        End If
    End Sub
End Class