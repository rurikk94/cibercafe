Imports MySql.Data.Types

Public Class HistorialSesionesTrabVO
    Private rut_trabajador As String
    Private fecha_inicio_Sesion As MySqlDateTime
    Private fecha_termino_Sesion As MySqlDateTime

    Public Function getRut_trabajador() As String
        Return Me.rut_trabajador
    End Function

    Public Function getFecha_inicio_sesion() As MySqlDateTime
        Return Me.fecha_inicio_Sesion
    End Function

    Public Function getFecha_termino_sesion() As MySqlDateTime
        Return Me.fecha_termino_Sesion
    End Function

    Public Sub setRut_trabajador(ByVal value As String)
        Me.rut_trabajador = value
    End Sub

    Public Sub setFecha_inicio_sesion(ByVal value As MySqlDateTime)
        Me.fecha_inicio_Sesion = value
    End Sub

    Public Sub setFecha_termino_sesion(ByVal value As MySqlDateTime)
        Me.fecha_termino_Sesion = value
    End Sub

End Class
