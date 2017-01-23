Public Class class_datos_consola
    Private _numero_consola As String
    Private _estado As Integer
    Public Property numero_consola() As String
        Get
            Return _numero_consola
        End Get
        Set(ByVal value As String)
            _numero_consola = value
        End Set
    End Property
    Public Property estado() As Integer
        Get
            Return _estado
        End Get
        Set(ByVal value As Integer)
            _estado = value
        End Set
    End Property
End Class
