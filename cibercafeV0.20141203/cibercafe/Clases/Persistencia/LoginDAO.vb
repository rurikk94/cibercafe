'
' Created by SharpDevelop.
' User: Ordeal
' Date: 25-11-2014
' Time: 11:20
' 
' To change this template use Tools | Options | Coding | Edit Standard Headers.
'
Imports MySql.Data.MySqlClient

Public Class LoginDAO
	Private controlador As New MySqlDataAdapter
	Private ds As New DataSet
	
	Public Function existeUsuario (ByVal rut As String, ByVal password As String) As boolean
		Dim cnx As New Connection
		Try
			cnx.conectar()
			ds.Reset()
            controlador.SelectCommand = New MySqlCommand("SELECT rut, nombre, apellidos FROM usuario WHERE rut = @rut AND password = @password", cnx.getConexion())
            controlador.SelectCommand.Parameters.Add("@rut", MySqlDbType.Int32).Value = rut
            controlador.SelectCommand.Parameters.Add("@password", MySqlDbType.VarChar, 15).Value = password
            controlador.Fill(ds, "usuario")

            
            If (ds.Tables("usuario").Rows.Count() <> 0) Then 'El usuario NO esta registrado

                Dim dao As New HistorialSesionesTrabDAO
                ' rut de la base de datos = ds.Tables("usuario").Rows(0)(0)
                If Not (dao.iniciarSesion(ds.Tables("usuario").Rows(0)(0))) Then
                    MsgBox("No hemos podido registrar su inicio de sesion en el historial")
                    Return False
                Else
                    _cajeroRut = ds.Tables("usuario").Rows(0)(0)
                    _cajeroNombre = ds.Tables("usuario").Rows(0)(1)
                    _cajeroApellidos = ds.Tables("usuario").Rows(0)(2)
                End If
                Return True
            Else
                Return False
            End If
        Catch ex As MySqlException
            MsgBox("Error " & ex.Number & ": " & ex.Message.ToString, vbCritical, vbOKOnly)
        Finally
            cnx.desconectar()
        End Try
		Return False
    End Function

    Private Function revisarPermisos() As Integer


        Return 0
    End Function
	
End Class
