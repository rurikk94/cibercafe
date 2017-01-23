Public Class consultar_stock

    Private Sub formLoad(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Me.llenarComboboxCodigos()
        Me.DataGridView1.Hide()
        Me.btn_atras.Hide()
    End Sub

    Private Sub btn_salir_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_salir.Click
        Me.Close()
    End Sub

    Private Sub btn_consultar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_consultar.Click
        Dim dao As New ProductoDAO
        Dim dataset As DataSet = dao.buscarPorNombre(TextBox1.Text)
        Try
            DataGridView1.Show()
            Me.btn_atras.Show()
            DataGridView1.DataSource = dataset.Tables("producto")
        Catch
        End Try
    End Sub

    Public Sub llenarComboboxCodigos()
        Me.ComboBox1.Items.Clear()  'para no tener datos repetidos al recargar
        Dim dao As New ProductoDAO
        Dim lista As ArrayList = dao.recuperarCodigos()
        For Each vo As ProductoVO In lista
            ComboBox1.Items.Add(vo.getCod_producto)
        Next
    End Sub
    Public Sub ComboBox1_SelectedValueChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles ComboBox1.SelectedValueChanged
        Dim dao As New ProductoDAO
        Dim dataset As DataSet = dao.buscarPorCodigo(ComboBox1.SelectedItem)
        Label5.Text = dataset.Tables("codigos").Rows(0)(1) & " unidades"
        Label7.Text = dataset.Tables("codigos").Rows(0)(2)
        Label8.Text = dataset.Tables("codigos").Rows(0)(0)
    End Sub

    Private Sub btn_atras_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_atras.Click
        DataGridView1.Hide()
        Me.btn_atras.Hide()
        Label8.Text = "<nombre>"
        Label5.Text = "<stock>"
        Label7.Text = "<precio>"
    End Sub

End Class