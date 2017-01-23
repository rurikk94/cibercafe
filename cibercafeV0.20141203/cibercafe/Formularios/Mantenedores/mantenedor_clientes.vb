Public Class mantenedor_clientes

    Private agrega As Boolean = False
    Private retornar As Boolean = False
    Dim dao As New ClienteDAO

    Private Sub formLoad(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Me.poblarDGV()
        GroupBox1.Hide()
        lbl_interplay.Show()
        btn_agregar.Focus()

    End Sub

    Private Sub DataGridView1_CellSingleClick(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles DataGridView1.CellClick
        If e.RowIndex >= 0 Then
            Dim fila As DataGridViewRow
            fila = Me.DataGridView1.Rows(e.RowIndex)
            txt_usuario.Text = fila.Cells("Usuario").Value.ToString
            txt_nombre.Text = fila.Cells("Nombre").Value.ToString
            txt_apellido.Text = fila.Cells("Apellidos").Value.ToString
            txt_password.Text = fila.Cells("Password").Value.ToString
            txt_reingrese_pass.Text = txt_password.Text
            If fila.Cells("Estado").Value = 0 Then 'está activo
                chk_estado.Checked = True
            Else
                chk_estado.Checked = False
            End If
        End If
    End Sub

    Private Sub poblarDGV()
        Dim dao As New ClienteDAO
        DataGridView1.DataSource = dao.buscarTodos.Tables("cliente")
    End Sub

    Private Sub btn_salir_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_salir.Click
        Me.Close()
    End Sub

    Private Sub btn_modificar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_modificar.Click
        lbl_interplay.Hide()
        GroupBox1.Show()
        agrega = False
        txt_usuario.ReadOnly = True
        btn_eliminar.Hide()
        btn_agregar.Hide()
    End Sub

    Private Sub DataGridView1_CellContentClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles DataGridView1.CellContentClick

    End Sub

    Private Sub btn_agregar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_agregar.Click
        lbl_interplay.Hide()
        GroupBox1.Show()
        agrega = True
        txt_usuario.ReadOnly = False
        btn_eliminar.Hide()
        btn_modificar.Hide()
        lbl_estado.Hide()
        chk_estado.Hide()
    End Sub

    Private Sub btn_eliminar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_eliminar.Click
        If txt_usuario.Text = Nothing Then
            MsgBox("Debe seleccionar un cliente")
        Else
            MsgBox("¿Esta seguro que desea eliminar al cliente <" & txt_usuario.Text & "> (" & txt_nombre.Text & " " & txt_apellido.Text & ")?", vbYesNo)
            If vbYes Then
                Dim usuario As String = txt_usuario.Text.ToString
                dao.eliminar(usuario)
            End If
        End If
        poblarDGV()
    End Sub

    Private Sub btn_cancelar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_cancelar.Click
        If Not agrega Then
            txt_usuario.ReadOnly = False
        End If
        GroupBox1.Hide()
        lbl_interplay.Show()
        btn_eliminar.Show()
        btn_agregar.Show()
        btn_modificar.Show()
        lbl_estado.Show()
        chk_estado.Show()
    End Sub

    Private Sub btn_guardar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_aceptar.Click
        retornar = False
        If Me.validarCampos Then
            If agrega Then
                If Not dao.buscarPorNombreUsuario(txt_usuario.Text) Then 'puede agregarlo
                    Dim estado As Integer = 0
                    Dim vo As New ClienteVO
                    vo.setNombre_usuario(txt_usuario.Text)
                    vo.setNombre(txt_nombre.Text.ToString)
                    vo.setApellidos(txt_apellido.Text.ToString)
                    vo.setPassword(txt_password.Text)
                    vo.setEstado(estado)
                    dao.agregar(vo)
                    retornar = True
                Else : MsgBox("El nombre de usuario ingresado ya existe.")
                End If
            ElseIf Not agrega Then
                Dim estado As Integer
                If chk_estado.Checked Then
                    estado = 0
                Else : estado = 1
                End If
                Dim vo As New ClienteVO
                vo.setNombre_usuario(txt_usuario.Text)
                vo.setNombre(txt_nombre.Text.ToString)
                vo.setApellidos(txt_apellido.Text.ToString)
                vo.setPassword(txt_apellido.Text.ToString)
                vo.setEstado(estado)
                dao.actualizar(vo)
                retornar = True
            End If
            If retornar Then  'Solo si el usuario logro insertar/act. existosamente cambio la visual
                poblarDGV()
                GroupBox1.Hide()
                lbl_interplay.Show()
                btn_eliminar.Show()
                btn_agregar.Show()
                btn_modificar.Show()
                lbl_estado.Show()
                chk_estado.Show()
            End If
        End If
    End Sub

    Private Function validarCampos() As Boolean
        If txt_usuario.Text = Nothing Then
            MsgBox("Debe ingresar un nombre de usuario")
        ElseIf txt_nombre.Text = Nothing Then
            MsgBox("Debe ingresar su nombre.")
        ElseIf txt_apellido.Text = Nothing Then
            MsgBox("Debe ingresar su apellido.")
        ElseIf Not txt_password.Text.Equals(txt_reingrese_pass.Text) Then
            MsgBox("Las contraseñas ingresadas no coinciden.")
        Else
            Return True
        End If
        Return False
    End Function
End Class