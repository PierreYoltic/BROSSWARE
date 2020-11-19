Imports System.Data.SqlClient
Imports Microsoft.Reporting.WinForms
Imports System.Configuration
Imports System.ComponentModel
Public Class FrmReporteProveedores
    Dim conexion As New SqlConnection("Data Source=PIER18;Initial catalog=taller_refaccionaria; Integrated security = true")
    Dim comando As New SqlCommand
    Dim lector As SqlDataReader

    Dim orden As String = "Nombre"
    Dim ordr As String = "nombre"

    Dim Frm As New ReporteProveedores
    Private Sub FrmReporteProveedores_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        CboOrden.SelectedIndex = 0
    End Sub

    Private Sub CboOrden_SelectedIndexChanged(sender As Object, e As EventArgs) Handles CboOrden.SelectedIndexChanged
        If CboOrden.SelectedIndex = 0 Then
            orden = "Nombre"
            ordr = "nombre"
        Else
            orden = "Representante"
            ordr = "representante"
        End If
    End Sub

    Private Sub BtnMostrar_Click(sender As Object, e As EventArgs) Handles BtnMostrar.Click
        conexion.Open()
        Dim R As String = "SELECT * FROM proveedores ORDER BY " & ordr & " ASC"
        Dim Data As New DataSet("Data1")

        Dim command As New SqlCommand(R, conexion)
        Dim Adaptador As New SqlDataAdapter(command)
        Adaptador.Fill(Data)

        Dim DataSource As New ReportDataSource("DataSet1", Data.Tables(0))
        DataSource.Name = "DataSet1"
        DataSource.Value = Data.Tables(0)

        Dim p1 As New ReportParameter("orden", orden)
        Dim p2 As New ReportParameter("fecha", DateAndTime.Now.ToString)

        Frm.ReportViewer1.LocalReport.ReportPath = "C:\Users\Pierre Yoltic\Documents\MotoBox\ReporteProveedores.rdlc"

        Frm.ReportViewer1.LocalReport.DataSources.Clear()
        'ReporteExistenciaArticulos.ReportViewer1.LocalReport.DataSources.RemoveAt(0)
        Frm.ReportViewer1.LocalReport.DataSources.Add(DataSource)
        'ReporteExistenciaArticulos.ReportViewer1.LocalReport.ReportPath = Application.StartupPath & "\ReporteAsistenciaMenores.rdlc"
        Frm.ReportViewer1.LocalReport.SetParameters(New ReportParameter() {p1, p2})
        Frm.ReportViewer1.RefreshReport()
        Frm.WindowState = FormWindowState.Maximized
        FormMenu.AbrirFormInPanel(New FrmReporteProveedores)
        Frm.Show()
        conexion.Close()

        Me.Dispose()

    End Sub
End Class