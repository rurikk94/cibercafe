Public Class apertura_caja

    Private Sub btn_cancelar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_cancelar.Click
        Me.Close()
    End Sub


    Private Sub ProgressBar1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)


    End Sub

    Private Sub btn_aceptar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_aceptar.Click

        'validar el texto ingresado
        Dim dao As New CajaDAO
        If Not dao.cajaEstaAbierta Then ' no  esta abierta la caja

            'confirmar el valor
            MsgBox("El monto de apertura es: $" & TextBox1.Text & ". ¿Confirma la apertura con ese monto?", vbYesNo, vbQuestion)
            If (vbYes) Then
                Procesando.Show()
                'Ingresarlo a la base de datos
                Dim resultado As Integer = dao.abrirCaja(TextBox1.Text)
                'Mostrar resultado de la transaccion.
                If resultado = 1 Then
                    MsgBox("La caja fue iniciada exitosamente!", vbOKOnly)
                Else
                    MsgBox("Algo salio mal.", vbOKOnly)
                End If
                Procesando.Close()
                Me.Close()
            End If
        Else : MsgBox("La caja ya fue abierta hoy")
        End If
    End Sub
End Class
