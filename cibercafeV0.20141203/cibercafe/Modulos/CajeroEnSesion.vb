Imports MySql.Data.Types
Imports MySql.Data

<Serializable()> Public Module CajeroEnSesion
    Public _cajeroNombre As String
    Public _cajeroRut As String
    Public _cajeroFechaInicio As String
    Public _cajeroApellidos As String

    Public Function getNombre() As String
        Return _cajeroNombre
    End Function

    Public Function getApellidos() As String
        Return _cajeroApellidos
    End Function

    Public Function getRut() As String
        Return _cajeroRut
    End Function

    Public Sub setNombre(ByVal value As String)
        _cajeroNombre = value
    End Sub

    Public Sub setApellidos(ByVal value As String)
        _cajeroApellidos = value
    End Sub

    Public Sub setRut(ByVal value As String)
        _cajeroRut = value
    End Sub
End Module
