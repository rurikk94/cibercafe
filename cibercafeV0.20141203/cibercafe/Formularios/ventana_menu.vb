Public Class ventana_menu
    Dim _enabledCerrar As Boolean = False
    <System.ComponentModel.DefaultValue(False), System.ComponentModel.Description("Define si se habilita el botón cerrar en el formulario")> _
    Public Property EnabledCerrar() As Boolean
        Get
            Return _enabledCerrar
        End Get
        Set(ByVal Value As Boolean)
            If _enabledCerrar <> Value Then
                _enabledCerrar = Value
            End If
        End Set
    End Property
    Protected Overrides ReadOnly Property CreateParams() As CreateParams
        Get
            Dim cp As CreateParams = MyBase.CreateParams
            If _enabledCerrar = False Then
                Const CS_NOCLOSE As Integer = &H200
                cp.ClassStyle = cp.ClassStyle Or CS_NOCLOSE
            End If
            Return cp
        End Get
    End Property
    Private Sub ventana_menu_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        lbl_version.Text = "V" + Format(Now, "yyyyMMdd")
    End Sub
    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        apertura_caja.Show()
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        venta.Show()
    End Sub

    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button3.Click
        ajustar_stock.Show()
    End Sub

    Private Sub Button4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button4.Click
        anular_venta.Show()

    End Sub

    Private Sub Button8_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button8.Click
        asignar_categoria_producto.Show()

    End Sub

    Private Sub Button7_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button7.Click
        consultar_stock.Show()

    End Sub

    Private Sub Button6_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button6.Click
        cuadrar_caja.Show()

    End Sub

    Private Sub Button5_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button5.Click
        ingreso_factura.Show()

    End Sub

    Private Sub Button12_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button12.Click
        mantenedor_categoria.Show()

    End Sub

    Private Sub Button11_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button11.Click
        mantenedor_clientes.Show()

    End Sub

    Private Sub Button10_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button10.Click
        mantenedor_productos.Show()

    End Sub

    Private Sub Button9_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button9.Click
        mantenedor_proveedores.Show()

    End Sub

    Private Sub Button13_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button13.Click
        mantenedor_trabajadores.Show()

    End Sub
    Private Sub Button14_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button14.Click
        MessageBox.Show("Se conectará a " & txt_cadena.Text)
        mantenedor_equipos.Show()
    End Sub

    Private Sub Button15_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button15.Click
        cancelar_arriendo.Show()
    End Sub

    Private Sub Button16_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button16.Click
        Reportes_Generador.Show()
    End Sub

    Private Sub VentaToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles VentaToolStripMenuItem.Click
        venta.Show()
    End Sub

    Private Sub MantenedoresToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MantenedoresToolStripMenuItem.Click

    End Sub

    Private Sub MostrarBotonToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MostrarBotonToolStripMenuItem.Click
        Button1.Visible = True
        Button2.Visible = True
        Button3.Visible = True
        Button4.Visible = True
        Button5.Visible = True
        Button6.Visible = True
        Button7.Visible = True
        Button8.Visible = True
        Button9.Visible = True
        Button10.Visible = True
        Button11.Visible = True
        Button12.Visible = True
        Button13.Visible = True
        Button14.Visible = True
        Button15.Visible = True
        Button16.Visible = True
        txt_cadena.Visible = True
    End Sub

    Private Sub SalirToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SalirToolStripMenuItem.Click
        Dim dao As New HistorialSesionesTrabDAO
        If Not dao.cerrarSesion(_cajeroRut, _cajeroFechaInicio) Then
            MsgBox("Ups... Ocurrio un error al guardar el fin de sesión. Porfavor comuniquese con el administrador")
        End If
        End
    End Sub

    Private Sub MantendorDeEquiposToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MantendorDeEquiposToolStripMenuItem.Click
        mantenedor_equipos.MdiParent = Me
        mantenedor_equipos.Show()
    End Sub

    Private Sub Button17_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button17.Click
        consultar_stock.Show()
    End Sub

    Private Sub OcultarBotonesToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles OcultarBotonesToolStripMenuItem.Click
        Button1.Visible = False
        Button2.Visible = False
        Button3.Visible = False
        Button4.Visible = False
        Button5.Visible = False
        Button6.Visible = False
        Button7.Visible = False
        Button8.Visible = False
        Button9.Visible = False
        Button10.Visible = False
        Button11.Visible = False
        Button12.Visible = False
        Button13.Visible = False
        Button14.Visible = False
        Button15.Visible = False
        Button16.Visible = False
        txt_cadena.Visible = False
    End Sub

    Private Sub ArriendoToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ArriendoToolStripMenuItem.Click
        cancelar_arriendo.Show()
    End Sub

    Private Sub MantendorTrabajadoresToolStripMenuItem_Click(sender As System.Object, e As System.EventArgs) Handles MantendorTrabajadoresToolStripMenuItem.Click
        mantenedor_trabajadores.Show()
    End Sub

    Private Sub AperturaCajaToolStripMenuItem1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles AperturaCajaToolStripMenuItem1.Click
        apertura_caja.Show()
    End Sub

    Private Sub CuadrarCajaToolStripMenuItem1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CuadrarCajaToolStripMenuItem1.Click
        cuadrar_caja.Show()
    End Sub

    Private Sub ConsultarStockToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ConsultarStockToolStripMenuItem.Click
        consultar_stock.Show()
    End Sub

    Private Sub MantenedorClientesToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MantenedorClientesToolStripMenuItem.Click
        mantenedor_clientes.Show()
    End Sub

    Private Sub MantenedorProveedoresToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MantenedorProveedoresToolStripMenuItem.Click
        mantenedor_proveedores.Show()
    End Sub
End Class