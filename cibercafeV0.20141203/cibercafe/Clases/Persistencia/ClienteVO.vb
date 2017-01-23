Public Class ClienteVO
    Private nombre_usuario As String
    Private nombre As String
    Private apellidos As String
    Private password As String
    Private estado As Integer

    Public Function getNombre_usuario() As String
        Return Me.nombre_usuario
    End Function

    Public Function getNombre() As String
        Return Me.nombre
    End Function

    Public Function getApellidos() As String
        Return Me.apellidos
    End Function

    Public Function getPassword() As String
        Return Me.password
    End Function

    Public Function getEstado() As String
        Return Me.estado
    End Function


    Public Sub setNombre_usuario(ByVal value As String)
        Me.nombre_usuario = value
    End Sub

    Public Sub setNombre(ByVal value As String)
        Me.nombre = value
    End Sub

    Public Sub setApellidos(ByVal value As String)
        Me.apellidos = value
    End Sub

    Public Sub setPassword(ByVal value As String)
        Me.password = value
    End Sub

    Public Sub setEstado(ByVal value As Integer)
        Me.estado = value
    End Sub
End Class
