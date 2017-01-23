Imports MySql.Data.Types

Public Class CajaVO
    Private fechaHora As MySqlDateTime
    Private tipo_transacc As String
    Private monto As Double

    Public Function getFechaHora() As MySqlDateTime
        Return fechaHora
    End Function

    Public Function getTipo_transacc() As String
        Return tipo_transacc
    End Function

    Public Function getMonto() As Double
        Return monto
    End Function

    Public Sub setFechaHora(ByVal value As MySqlDateTime)
        fechaHora = value
    End Sub

    Public Sub setTipo_transacc(ByVal value As String)
        tipo_transacc = value
    End Sub

    Public Sub setMonto(ByVal value As Double)
        monto = value
    End Sub

End Class
