Public Class login
    Private Sub login_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        lbl_version.Text = "V" + Format(Date.Now(), "yyyyMMdd")
    End Sub
    Private Sub Btn_Aceptar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Btn_Aceptar.Click
        Dim dao As New LoginDAO
        Dim r As New Rut(TextBox1.Text)
        If (validarIngreso(r)) Then
            Try

                If Not dao.existeUsuario(r.obtenerParteEntera & r.obtenerDV, TextBox2.Text) Then
                    MsgBox("El rut o contraseña son incorrectos", vbOK)
                Else
                    ventana_menu.Show()
                    Me.Visible = False
                End If
            Catch ex As MySql.Data.MySqlClient.MySqlException
                MessageBox.Show("Error " & ex.Number.ToString & ": " & ex.Message)
            End Try
        End If
    End Sub

    Private Function validarIngreso(ByVal r As Rut) As Boolean
        If TextBox1.Text = Nothing Then
            MsgBox("Debe ingresar su RUT")
            Return False
        ElseIf Not r.rutValido() Then
            MsgBox("El rut ingresado no es valido.")
            Return False
        ElseIf TextBox2.Text = Nothing Then
            MsgBox("Debe ingresar su contraseña")
        Else : Return True
        End If
        Return False
    End Function
    
    Sub Btn_salir_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_salir.Click
        End
    End Sub
End Class