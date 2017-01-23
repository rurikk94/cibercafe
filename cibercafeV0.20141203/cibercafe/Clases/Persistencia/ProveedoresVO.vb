Public Class ProveedoresVO
    Private rut_proveedor As Integer
    Private nombre_proveedor As String
    Private telefono_proveedor As String
    Private direccion_proveedor As String
    Private nombre_empresa_proveedor As String
    Private e_mail_proveedor As String

    Public Function getRut_proveedor() As Integer
        Return Me.rut_proveedor
    End Function

    Public Function getNombre_proveedor() As String
        Return Me.nombre_proveedor
    End Function

    Public Function getTelefono_proveedor() As String
        Return Me.telefono_proveedor
    End Function

    Public Function getDireccion_proveedor() As String
        Return Me.direccion_proveedor
    End Function

    Public Function getNombre_empresa_proveedor() As String
        Return Me.nombre_empresa_proveedor
    End Function

    Public Function getE_mail_proveedor() As String
        Return Me.e_mail_proveedor
    End Function

    Public Sub setRut_proveedor(ByVal value As String)
        Me.rut_proveedor = value
    End Sub

    Public Sub setNombre_proveedor(ByVal value As String)
        Me.nombre_proveedor = value
    End Sub

    Public Sub setTelefono_proveedor(ByVal value As String)
        Me.telefono_proveedor = value
    End Sub

    Public Sub setDireccion_proveedor(ByVal value As String)
        Me.direccion_proveedor = value
    End Sub

    Public Sub setNombre_empresa_proveedor(ByVal value As String)
        Me.nombre_empresa_proveedor = value
    End Sub

    Public Sub setE_mail_proveedor(ByVal value As String)
        Me.e_mail_proveedor = value
    End Sub
End Class
