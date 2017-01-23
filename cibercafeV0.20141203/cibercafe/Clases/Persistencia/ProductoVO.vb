Public Class ProductoVO
    Private cod_producto As Integer
    Private nom_producto As String
    Private precio_unitario As Integer
    Private cod_categoria As Integer
    Private cantidad As Integer
    Private cantidad_minima As Integer

    Public Function getCod_producto() As Integer
        Return Me.cod_producto
    End Function

    Public Function getNom_producto() As String
        Return Me.nom_producto
    End Function

    Public Function getPrecio_unitario() As Integer
        Return Me.precio_unitario
    End Function

    Public Function getCod_categoria() As Integer
        Return Me.cod_categoria
    End Function

    Public Function getCantidad() As Integer
        Return Me.cantidad
    End Function

    Public Function getCantidad_minima() As Integer
        Return Me.cantidad_minima
    End Function

    Public Sub setCod_producto(ByVal value As Integer)
        Me.cod_producto = value
    End Sub
    Public Sub setNom_producto(ByVal value As String)
        Me.nom_producto = value
    End Sub
    Public Sub setPrecio_unitario(ByVal value As Integer)
        Me.precio_unitario = value
    End Sub
    Public Sub setCod_categoria(ByVal value As Integer)
        Me.cod_categoria = value
    End Sub
    Public Sub setCantidad(ByVal value As Integer)
        Me.cantidad = value
    End Sub
    Public Sub setCantidad_minima(ByVal value As Integer)
        Me.cantidad_minima = value
    End Sub
End Class
