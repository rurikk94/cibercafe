Imports System.Text.RegularExpressions

Public Class Fono
    Private fono As String
    Public Sub New(ByVal value As String)
        Me.fono = value
    End Sub

    Public Function validarFono() As Boolean
        Dim patron As String = "^[0-9\+\)\(]{7,}$"
        Dim coincidencia As Match = Regex.Match(fono, patron)
        If coincidencia.Success Then
            Return True
        Else : Return False
        End If
        Return False
    End Function
End Class
