Public Class class_datos
    Private _direcc_MAC As String
    Private _direcc_IP As String
    Private _estado As Integer
    Public Property direcc_MAC() As String
        Get
            Return _direcc_MAC
        End Get
        Set(ByVal value As String)
            _direcc_MAC = value
        End Set
    End Property
    Public Property direcc_IP() As String
        Get
            Return _direcc_IP
        End Get
        Set(ByVal value As String)
            _direcc_IP = value
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
