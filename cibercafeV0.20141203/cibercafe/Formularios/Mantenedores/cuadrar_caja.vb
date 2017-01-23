Public Class cuadrar_caja

    Private Sub formLoad(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Me.Load
        lbl_muestra_fecha.Text = Format(Now, "short Date")
        Dim dao As New HistorialSesionesTrabDAO
        Label11.Text = _cajeroNombre & " " & _cajeroApellidos
        Label12.Text = _cajeroFechaInicio
        dao.buscarSesionDeTrabajador()
        Dim fechaActual As System.DateTime = String.Format("{0: HH:mm:ss}", System.DateTime.Now)
    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        Me.Close()
    End Sub

    Private Sub Label11_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label11.Click

    End Sub
End Class