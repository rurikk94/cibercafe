Public Class mantenedor_proveedores

    Private agrega As Boolean = False
    Private valido As Boolean = True
    Private retornar As Boolean = False
    Dim dao As New ProveedoresDAO

    '------------------------------------------------------------------------------------------------------------------

    Private Sub poblarDataGridView1()
        DataGridView1.DataSource = dao.consultarTodos.Tables("proveedor")
    End Sub

    Private Sub formLoad(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Try
            poblarDataGridView1()
            GroupBox1.Hide()
            btn_agregar.Focus()
            lbl_interplay.Show()
        Catch ex As Exception
            MsgBox("Ocurrio un error al conectar con la base de datos.")
            MsgBox(ex.StackTrace)
            Me.Close()
        End Try
    End Sub
    Private Sub btn_salir_click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_salir.Click
        Me.Close()
    End Sub

    Private Sub DataGridView1_CellSingleClick(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles DataGridView1.CellClick
        If e.RowIndex >= 0 Then
            Dim fila As DataGridViewRow
            fila = Me.DataGridView1.Rows(e.RowIndex)
            Dim rut As String = fila.Cells("Rut").Value.ToString
            txt_rut.Text = rut.Substring(0, rut.Length - 1)
            txt_dv.Text = rut.Substring(rut.Length - 1, 1)
            txt_nombre.Text = fila.Cells("Nombre").Value.ToString
            txt_fono.Text = fila.Cells("Telefono").Value.ToString
            txt_direccion.Text = fila.Cells("Direccion").Value.ToString
            txt_nombre_empresa.Text = fila.Cells("Nombre de la empresa").Value.ToString
            txt_email.Text = fila.Cells("Email").Value.ToString
            txt_fono.Text = fila.Cells("Telefono").Value.ToString
        End If
    End Sub

    Private Sub btn_modificar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_modificar.Click
        lbl_interplay.Hide()
        GroupBox1.Show()
        agrega = False
        txt_rut.ReadOnly = True
        txt_dv.ReadOnly = True
        btn_eliminar.Hide()
        btn_agregar.Hide()
    End Sub

    Private Sub btn_agregar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_agregar.Click
        lbl_interplay.Hide()
        GroupBox1.Show()
        agrega = True
        btn_eliminar.Hide()
        btn_modificar.Hide()
    End Sub

    Private Sub btn_eliminar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_eliminar.Click
        If txt_rut.Text = Nothing Then
            MsgBox("Debe seleccionar un proveedor")
        Else
            MsgBox("¿Esta seguro que desea eliminar al proveedor <" & txt_nombre.Text & ">?", vbYesNo)
            If vbYes Then
                Dim rut As String = txt_rut.Text.ToString & txt_dv.Text.ToString 'rut sin formato
                dao.eliminar(rut)
            End If
        End If
        poblarDataGridView1()
    End Sub

    Private Sub btn_cancelar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_cancelar.Click
        If Not agrega Then
            txt_rut.ReadOnly = False
            txt_dv.ReadOnly = False
        End If
        GroupBox1.Hide()
        lbl_interplay.Show()
        btn_eliminar.Show()
        btn_agregar.Show()
        btn_modificar.Show()
    End Sub

    Private Sub btn_aceptar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_aceptar.Click
        retornar = False
        If Me.validarCampos Then
            If agrega Then
                Dim vo As New ProveedoresVO
                vo.setRut_proveedor(txt_rut.Text.ToString & txt_dv.Text.ToString)
                vo.setNombre_proveedor(txt_nombre.Text.ToString)
                vo.setTelefono_proveedor(txt_fono.Text)
                vo.setDireccion_proveedor(txt_direccion.Text)
                vo.setNombre_empresa_proveedor(txt_nombre_empresa.Text)
                vo.setE_mail_proveedor(txt_email.Text)
                dao.agregar(vo)
            ElseIf Not agrega Then
                Dim vo As New ProveedoresVO
                vo.setRut_proveedor(txt_rut.Text.ToString & txt_dv.Text.ToString)
                vo.setNombre_proveedor(txt_nombre.Text.ToString)
                vo.setTelefono_proveedor(txt_fono.Text)
                vo.setDireccion_proveedor(txt_direccion.Text)
                vo.setNombre_empresa_proveedor(txt_nombre_empresa.Text)
                vo.setE_mail_proveedor(txt_email.Text)
                dao.actualizar(vo)
            End If
            poblarDataGridView1()
            GroupBox1.Hide()
            lbl_interplay.Show()
            btn_eliminar.Show()
            btn_agregar.Show()
            btn_modificar.Show()
        End If

    End Sub

    Private Function validarCampos() As Boolean
        Dim r As New Rut(txt_rut.Text & "-" & txt_dv.Text)
        Dim f As New Fono(txt_fono.Text)
        If txt_rut.Text = Nothing Or txt_dv.Text = Nothing Then
            MsgBox("Debe ingresar su rut")
        ElseIf Not r.rutValido() Then
            MsgBox("El rut ingresado no es valido.")
        ElseIf txt_nombre.Text = Nothing Then
            MsgBox("Debe ingresar su nombre.")
        ElseIf txt_direccion.Text = Nothing Then
            MsgBox("Debe ingresar su direccion.")
        ElseIf txt_nombre_empresa.Text = Nothing Then
            MsgBox("Debe ingresar su direccion.")
        ElseIf txt_email.Text = Nothing Then
            MsgBox("Debe ingresar su direccion.")
        ElseIf Not f.validarFono() Then
            MsgBox("El telefono ingresado contiene caracteres invalidos.")
        Else
            Return True
        End If
        Return False
    End Function
End Class