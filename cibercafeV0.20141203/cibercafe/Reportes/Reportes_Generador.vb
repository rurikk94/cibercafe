Public Class Reportes_Generador

    Private Sub Reportes_Generador_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'TODO: esta línea de código carga datos en la tabla 'cibercafe_DataSet.producto' Puede moverla o quitarla según sea necesario.
        Me.productoTableAdapter.Fill(Me.cibercafe_DataSet.producto)

        Me.ReportViewer1.RefreshReport()
    End Sub

    Private Sub ReportViewer1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ReportViewer1.Load

    End Sub
End Class