Imports System.Data.SqlClient
Imports Microsoft.Reporting.WinForms
Imports System.Configuration
Imports System.ComponentModel
Public Class FrmReporteExistencias
    Dim conexion As New SqlConnection("Data Source=PIER18;Initial catalog=taller_refaccionaria; Integrated security = true")
    Dim comando As New SqlCommand
    Dim lector As SqlDataReader

    Dim cat As Integer = -1
    Dim categoria As String = "Todas"
    Dim ordr As String = "descripcion"
    Dim orden As String = "Descripción"
    Dim ordenamiento As String = "ASC"
    Dim filtro As String = "Todos los artículos"

    Dim Frm As New ReporteExistenciaArticulos
    Private Sub FrmReporteExistencias_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        conexion.Open()
        comando = conexion.CreateCommand
        comando.CommandText = "SELECT nombre FROM categoria WHERE status = 1"
        lector = comando.ExecuteReader
        While lector.Read()
            CboCategoria.Items.Add(lector(0))
        End While
        lector.Close()
        conexion.Close()

        CboOrden.SelectedIndex = 0
        CboAscDesc.SelectedIndex = 0
    End Sub

    Private Sub CheckBoxCategoria_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBoxCategoria.CheckedChanged
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

    Private Sub CboCategoria_SelectedIndexChanged(sender As Object, e As EventArgs) Handles CboCategoria.SelectedIndexChanged
        cat = CboCategoria.SelectedIndex + 1
        categoria = CboCategoria.Text
    End Sub

    Private Sub ComboBox1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles CboOrden.SelectedIndexChanged
        If CboOrden.SelectedIndex = 0 Then
            ordr = "descripcion "
            orden = "Descripción"
        ElseIf CboOrden.SelectedIndex = 1 Then
            ordr = "cat_id "
            orden = "Categoría"
        Else
            ordr = "existencia "
            orden = "Existencia"
        End If
    End Sub

    Private Sub CboAscDesc_SelectedIndexChanged(sender As Object, e As EventArgs) Handles CboAscDesc.SelectedIndexChanged
        If CboAscDesc.SelectedIndex = 0 Then
            ordenamiento = "ASC"
        Else
            ordenamiento = "DESC"
        End If
    End Sub

    Private Sub BtnMostrar_Click(sender As Object, e As EventArgs) Handles BtnMostrar.Click
        conexion.Open()

        Dim R As String = "SELECT * FROM existencias "

        If CheckBoxCategoria.Checked = False Then
            R += "WHERE cat_id = " & cat & " "
            If RBConExist.Checked Then
                R += "AND existencia > 0 "
            ElseIf RBSinExist.Checked Then
                R += "AND existencia <= 0 "
            ElseIf RBMax.Checked Then
                R += "AND existencia > invMax "
            ElseIf RBMin.Checked Then
                R += "AND existencia < invMin "
            End If
        Else
            If RBConExist.Checked Then
                R += "WHERE existencia > 0 "
            ElseIf RBSinExist.Checked Then
                R += "WHERE existencia <= 0 "
            ElseIf RBMax.Checked Then
                R += "WHERE existencia > invMax "
            ElseIf RBMin.Checked Then
                R += "WHERE existencia < invMin "
            End If
        End If

        If CheckBoxCategoria.Checked And RBTodos.Checked Then
            R = "SELECT * FROM existencias "
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

        Dim p1 As New ReportParameter("categoria", categoria)
        Dim p2 As New ReportParameter("filtro", filtro)
        Dim p3 As New ReportParameter("orden", orden)
        Dim p4 As New ReportParameter("fecha", DateAndTime.Now.ToString)

        Frm.ReportViewer1.LocalReport.ReportPath = "C:\Users\Pierre Yoltic\Documents\MotoBox\ReporteExistenciaArticulos.rdlc"

        Frm.ReportViewer1.LocalReport.DataSources.Clear()
        'ReporteExistenciaArticulos.ReportViewer1.LocalReport.DataSources.RemoveAt(0)
        Frm.ReportViewer1.LocalReport.DataSources.Add(DataSource)
        'ReporteExistenciaArticulos.ReportViewer1.LocalReport.ReportPath = Application.StartupPath & "\ReporteAsistenciaMenores.rdlc"
        Frm.ReportViewer1.LocalReport.SetParameters(New ReportParameter() {p2, p1, p3, p4})
        Frm.ReportViewer1.RefreshReport()
        Frm.WindowState = FormWindowState.Maximized
        FormMenu.AbrirFormInPanel(New FrmReporteExistencias)
        Frm.Show()
        conexion.Close()

        Me.Dispose()


    End Sub

    Private Sub RBTodos_CheckedChanged(sender As Object, e As EventArgs) Handles RBTodos.CheckedChanged
        filtro = "Todos los artículos"
    End Sub

    Private Sub RBConExist_CheckedChanged(sender As Object, e As EventArgs) Handles RBConExist.CheckedChanged
        filtro = "Solo artículos con existencia"
    End Sub

    Private Sub RBSinExist_CheckedChanged(sender As Object, e As EventArgs) Handles RBSinExist.CheckedChanged
        filtro = "Solo artículos sin existencia"
    End Sub

    Private Sub RBMax_CheckedChanged(sender As Object, e As EventArgs) Handles RBMax.CheckedChanged
        filtro = "Solo artículos que sobrepasan el máximo"
    End Sub

    Private Sub RBMin_CheckedChanged(sender As Object, e As EventArgs) Handles RBMin.CheckedChanged
        filtro = "Artículos con existencia menor al mínimo"
    End Sub
End Class