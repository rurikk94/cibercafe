Imports MySql.Data.MySqlClient
Imports System.Configuration

Public Class Connection
'    importar referencia mysql C:\Program Files (x86)\MySQL\MySQL Connector Net 6.9.4\Assemblies\v4.0\MySql.Data.dll
'    Private myConnectionString As String = ("server=localhost;uid=root;pwd=;database=cibercafe;port=3306;IgnorePrepare=false;Charset=latin1")
    Private myConnectionString As String = ("server=localhost;uid=root;pwd=;database=cibercafe;port=3306;IgnorePrepare=false;Charset=latin1")
    ' Private myConnectionString As String = ("server=bookshexo.no-ip.info;uid=root;pwd=;database=cibercafe;port=3306;IgnorePrepare=false;Charset=latin1")
    Private conn As New MySqlConnection(myConnectionString)
    Public Sub conectar()
        Try
            conn.Open()
        Catch ex As MySqlException
            Select Case ex.Number
                Case 0
                    MessageBox.Show("La aplicacion no pudo conectarse. Contacte al administrador.")
                Case 1045
                	MessageBox.Show("Usuario o contraseña incorrecto(s). Porfavor, vuelva a intentarlo.")
            End Select
            Me.desconectar()
        End Try
    End Sub
    Public Sub desconectar()
        conn.Close()
    End Sub

    Public Function getConexion() As MySqlConnection
    	Return conn
    End Function
    
End Class
