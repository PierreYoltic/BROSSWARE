Imports System.Data.SqlClient
Imports Microsoft.Reporting.WinForms
Imports System.Configuration
Imports System.ComponentModel
Public Class FrmReporteComprasGeneral
    Dim conexion As New SqlConnection("Data Source=PIER18;Initial catalog=taller_refaccionaria; Integrated security = true")
    Dim comando As New SqlCommand
    Dim lector As SqlDataReader

    Dim estado As Integer

    Dim fechaInicial As String
    Dim fechaFin As String
    Dim status As String
    Dim proveedor As String

    Dim Frm As New ReporteComprasGeneral
    Private Sub FrmReporteComprasGeneral_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ComboBoxEstado.SelectedIndex = 0
        proveedor = "Todos"
        status = ComboBoxEstado.Text
        fechaInicial = DTPFechaInicial.Text
        fechaFin = DTPFechaFinal.Text

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
        Dim R As String = "SELECT * FROM compras WHERE Fecha BETWEEN '" & DTPFechaInicial.Value.Date & "' AND '" & FechaFinal & "' "

        If CheckBoxProveedor.Checked = False Then
            R += "AND pro_id = " & TxtIdProveedor.Text & " "
        End If

        If ComboBoxEstado.SelectedIndex <> 0 Then
            R = "AND estado = " & estado
        End If

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
        Dim p3 As New ReportParameter("estado", status)
        Dim p4 As New ReportParameter("proveedor", proveedor)
        Dim p5 As New ReportParameter("fecha", DateAndTime.Now.ToString)

        Frm.ReportViewer1.LocalReport.ReportPath = "C:\Users\Pierre Yoltic\Documents\MotoBox\ReporteComprasGeneral.rdlc"

        Frm.ReportViewer1.LocalReport.DataSources.Clear()
        'ReporteExistenciaArticulos.ReportViewer1.LocalReport.DataSources.RemoveAt(0)
        Frm.ReportViewer1.LocalReport.DataSources.Add(DataSource)
        'ReporteExistenciaArticulos.ReportViewer1.LocalReport.ReportPath = Application.StartupPath & "\ReporteAsistenciaMenores.rdlc"
        Frm.ReportViewer1.LocalReport.SetParameters(New ReportParameter() {p2, p1, p3, p4, p5})
        Frm.ReportViewer1.RefreshReport()
        Frm.WindowState = FormWindowState.Maximized
        FormMenu.AbrirFormInPanel(New FrmReporteComprasGeneral)
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
End Class