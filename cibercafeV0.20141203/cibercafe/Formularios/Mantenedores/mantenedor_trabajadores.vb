Imports System.Text.RegularExpressions

Public Class mantenedor_trabajadores
    Private agrega As Boolean = False
    Private valido As Boolean = True
    Private usuarioAnt As String
    Private retornar As Boolean = False
    Dim dao As New TrabajadorDAO

    '------------------------------------------------------------------------------------------------------------------

    Private Sub poblarDataGridView1()
        Dim dao As New TrabajadorDAO
        DataGridView1.DataSource = dao.consultarTodos.Tables("usuario")
    End Sub

    Private Sub formLoad(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Try
            poblarDataGridView1()
            GroupBox1.Hide()
            lbl_interplay.Show()
            btn_agregar.Focus()
        Catch ex As Exception
        	MsgBox("Ocurrio un error al conectar con la base de datos.")
        	MsgBox(ex.StackTrace)
            Me.Close()
        End Try
    End Sub
    Private Sub btn_salir_click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_salir.Click
        Me.Close()
    End Sub

    Private Sub DataGridView1_CellSingleClick(sender As Object, e As System.Windows.Forms.DataGridViewCellEventArgs) Handles DataGridView1.CellClick
        If e.RowIndex >= 0 Then
            Dim fila As DataGridViewRow
            fila = Me.DataGridView1.Rows(e.RowIndex)
            Dim rut As String = fila.Cells("Rut").Value.ToString
            txt_rut.Text = rut.Substring(0, rut.Length - 1)
            txt_dv.Text = rut.Substring(Len(rut) - 1, 1)
            txt_nombre.Text = fila.Cells("Nombre").Value.ToString
            txt_apellido.Text = fila.Cells("Apellidos").Value.ToString
            txt_pass.Text = fila.Cells("Password").Value.ToString
            txt_reingrese_pass.Text = txt_pass.Text
            txt_fono.Text = fila.Cells("Fono").Value.ToString
            If fila.Cells("Estado").Value = 0 Then 'está activo
                chk_estado.Checked = True
            Else
                chk_estado.Checked = False
            End If
        End If
    End Sub

    Private Sub btn_modificar_Click(sender As System.Object, e As System.EventArgs) Handles btn_modificar.Click
        lbl_interplay.Hide()
        GroupBox1.Show()
        agrega = False
        txt_rut.ReadOnly = True
        txt_dv.ReadOnly = true
        btn_eliminar.Hide()
        btn_agregar.Hide()
    End Sub

    Private Sub btn_agregar_Click(sender As System.Object, e As System.EventArgs) Handles btn_agregar.Click
        lbl_interplay.Hide()
        GroupBox1.Show()
        agrega = True
        btn_eliminar.Hide()
        btn_modificar.Hide()
        lbl_estado.Hide()
        chk_estado.Hide()
    End Sub

    Private Sub btn_eliminar_Click(sender As System.Object, e As System.EventArgs) Handles btn_eliminar.Click
        If txt_rut.Text = Nothing Then
            MsgBox("Debe seleccionar un trabajador")
        Else
            MsgBox("¿Esta seguro que desea eliminar al trabajador <" & txt_nombre.Text & " " & txt_apellido.Text & ">?", vbYesNo)
            If vbYes Then
                Dim rut As String = txt_rut.Text.ToString & txt_dv.Text.ToString 'rut sin formato
                dao.eliminar(rut)
            End If
        End If
        poblarDataGridView1()
    End Sub

    Private Sub btn_cancelar_Click(sender As System.Object, e As System.EventArgs) Handles btn_cancelar.Click
        If Not agrega Then
            txt_rut.ReadOnly = False
            txt_dv.ReadOnly = False
        End If
        GroupBox1.Hide()
        lbl_interplay.Show()
        btn_eliminar.Show()
        btn_agregar.Show()
        btn_modificar.Show()
        lbl_estado.Show()
        chk_estado.Show()
    End Sub

    Private Sub btn_aceptar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_aceptar.Click
        retornar = False
        If Me.validarCampos Then
            If agrega Then
                If Not dao.buscarPorRut(txt_rut.Text & txt_dv.Text) Then
                    Dim estado As Integer = 0
                    Dim vo As New TrabajadorVO
                    vo.setRut(txt_rut.Text.ToString & txt_dv.Text.ToString)
                    vo.setNombre(txt_nombre.Text.ToString)
                    vo.setApellido(txt_apellido.Text.ToString)
                    vo.setPassword(txt_pass.Text)
                    vo.setFono(Val(txt_fono.Text))
                    vo.setEstado(estado)
                    dao.agregar(vo)
                    retornar = True
                Else : MsgBox("El rut que ingreso ya existe en el sistema.")
                End If
            ElseIf Not agrega Then 'Modifica;
                Dim estado As Integer
                If chk_estado.Checked Then
                    estado = 0
                Else : estado = 1
                End If
                Dim vo As New TrabajadorVO
                vo.setRut(txt_rut.Text.ToString & txt_dv.Text.ToString)
                vo.setNombre(txt_nombre.Text.ToString)
                vo.setApellido(txt_apellido.Text.ToString)
                vo.setPassword(txt_pass.Text)
                vo.setFono(Val(txt_fono.Text))
                vo.setEstado(estado)
                dao.actualizar(vo)
                retornar = True
            End If
            If retornar Then 'Solo si el usuario logro insertar/act. existosamente cambio la visual
                poblarDataGridView1()
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
        Dim r As New Rut(txt_rut.Text & "-" & txt_dv.Text)
        Dim fono As New Fono(txt_fono.Text)
        If txt_rut.Text = Nothing Or txt_dv.Text = Nothing Then
            MsgBox("Debe ingresar su rut")
        ElseIf Not r.rutValido() Then
            MsgBox("El rut ingresado no es valido.")
        ElseIf txt_nombre.Text = Nothing Then
            MsgBox("Debe ingresar su nombre.")
        ElseIf txt_apellido.Text = Nothing Then
            MsgBox("Debe ingresar su apellido.")
        ElseIf Not txt_pass.Text.Equals(txt_reingrese_pass.Text) Then
            MsgBox("Las contraseñas ingresadas no coinciden.")
        ElseIf Not fono.validarFono() Then
            MsgBox("El telefono ingresado contiene caracteres invalidos.")
        Else
            Return True
        End If
        Return False
    End Function
End Class