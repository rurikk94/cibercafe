Public Class TrabajadorVO

    Private usuario As String
    Private rut As String
    Private nombre As String
    Private apellido As String
    Private password As String
    Private fono As Integer
    Private tipo_usuario As Integer
    Private estado As Integer

    Public Sub setUsuario(ByVal value As String)
        Me.usuario = value
    End Sub

    Public Sub setRut(ByVal value As String)
        Me.rut = value
    End Sub

    Public Sub setNombre(ByVal value As String)
        Me.nombre = value
    End Sub

    Public Sub setApellido(ByVal value As String)
        Me.apellido = value
    End Sub

    Public Sub setPassword(ByVal value As String)
        Me.password = value
    End Sub

    Public Sub setFono(ByVal value As Integer)
        Me.fono = value
    End Sub

    Public Sub setEstado(ByVal value As Integer)
        Me.estado = value
    End Sub

    '------------------------------------------------------------------

    Public Sub setTipoUsuario(ByVal value As Integer)
        Me.tipo_usuario = value
    End Sub

    Public Function getUsuario() As String
        Return usuario
    End Function

    Public Function getRut() As String
        Return rut
    End Function
    Public Function getNombre() As String
        Return nombre
    End Function

    Public Function getApellido() As String
        Return apellido
    End Function

    Public Function getPassword() As String
        Return password
    End Function

    Public Function getFono() As Integer
        Return fono
    End Function

    Public Function getTipoUsuario() As Integer
        Return tipo_usuario
    End Function

    Public Function getEstado() As Integer
        Return estado
    End Function
End Class
