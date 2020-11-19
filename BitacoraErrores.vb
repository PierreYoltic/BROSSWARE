Public Class BitacoraErrores
    Private Sub BitacoraErrores_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'Taller_refaccionariaDataSet.bitacoradeerrores' table. You can move, or remove it, as needed.
        Me.BitacoradeerroresTableAdapter.Fill(Me.Taller_refaccionariaDataSet.bitacoradeerrores)

    End Sub
End Class