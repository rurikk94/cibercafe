Imports System.Text.RegularExpressions

Public Class Rut
    Private rut As String  ' Este rut esta sin formato, ej: 123456785, 222222222
    Private parteEntera As String
    Private dv As String

    Public Sub New(ByVal value As String)
        If Me.sacarFormato(value) = -1 Then
            dv = -1
            Exit Sub
        Else : rut = Me.sacarFormato(value)
        End If
        parteEntera = rut.Substring(0, rut.Length() - 1)
        dv = rut.Substring(rut.Length() - 1)
    End Sub

    Public Function sacarFormato(ByVal rut As String) As Integer
        rut = rut.ToUpper()
        rut = rut.Replace(".", "")
        rut = rut.Replace("-", "")
        Try
            Return rut
        Catch ex As InvalidCastException
            Return -1
        End Try
        Return -1
    End Function

    Public Function obtenerParteEntera() As Integer
        Return Convert.ToInt32(parteEntera)
    End Function

    Public Function obtenerDV() As String
        Return dv
    End Function

    Public Function rutValido() As Boolean
        Dim patronParteEntera As String = "^\d{7,8}$"
        Dim patronDV As String = "[0-9,K,k]"
        Dim coincidenciaPEnt As Match = Regex.Match(Me.obtenerParteEntera.ToString, patronParteEntera)
        Dim coincidenciaDV As Match = Regex.Match(Me.obtenerDV, patronDV)
        If Not (coincidenciaPEnt.Success And coincidenciaDV.Success) Then
            Return False
        End If

        Dim factor As Integer = 2
        Dim suma As Integer = 0
        For j As Integer = parteEntera.Length - 1 To 0 Step -1
            If factor = 8 Then
                factor = 2
            End If
            Dim nro As Integer = Val(parteEntera.Substring(j, 1))
            Dim sumando As Integer = nro * factor
            suma = suma + sumando
            factor = factor + 1
        Next
        Dim resto As Integer = suma Mod 11
        Dim digito As Integer = 11 - resto
        If digito = Val(dv) And dv <> 10 Then
            Return True
        ElseIf digito = 10 Then
            If dv.ToUpper = "K" Then
                Return True
            End If
        ElseIf digito = 11 And Val(dv) = 0 Then 'digito 0
            Return True
        End If
        Return False
    End Function
End Class
