Imports MySql.Data.MySqlClient
Imports MySql.Data.Types

Public Class HistorialSesionesTrabDAO
    Private controlador As New MySqlDataAdapter
    Private ds As New DataSet
    Private sql As String

    Public Function iniciarSesion(ByVal rut As String) As Boolean 'INSERT
        Dim cnx As New Connection
        Try
            cnx.conectar()
            sql = "INSERT INTO historial_sesiones_trabajador (fecha_inicio_sesion, rut_trabajador) " & _
            " VALUES(@fecha_inicio_sesion, @rut_trabajador )"
            Dim cmd As New MySqlCommand(sql, cnx.getConexion)
            Dim fechaHora As String = String.Format("{0:yyyy-MM-dd HH:mm:ss}", DateTime.Now())
            _cajeroFechaInicio = fechaHora
            cmd.Parameters.AddWithValue("@fecha_inicio_sesion", fechaHora)
            cmd.Parameters.AddWithValue("@rut_trabajador", rut)
            cmd.Prepare()
            If cmd.ExecuteNonQuery = 1 Then
                Return True
            Else : Return False
            End If
        Catch ex As MySqlException
            MsgBox(vbCritical, "Error " & ex.Number & ": " & ex.Message, vbOKOnly)
        Finally
            cnx.desconectar()
        End Try
        Return False
    End Function

    Public Function buscarSesionDeTrabajador() As DataSet
        Dim cnx As New Connection
        Try
            cnx.conectar()
            ds.Reset()
            controlador.SelectCommand = New MySqlCommand("SELECT * FROM historial_sesiones_trabajador WHERE rut_trabajador = @rut_trabajador", cnx.getConexion)
            'controlador.SelectCommand.Parameters.AddWithValue("@rut_trabajador", rut)
            controlador.Fill(ds, "trabajador")
            Return ds
        Catch ex As Exception


        Finally
            cnx.desconectar()

        End Try



        Return Nothing
    End Function

    Public Function cerrarSesion(ByVal rut As String, ByVal fecha As String) As Boolean
        Dim cnx As New Connection
        Try
            cnx.conectar()
            sql = "UPDATE historial_sesiones_trabajador " & _
            "  SET fecha_termino_sesion = @fecha_termino_sesion " & _
              " WHERE rut_trabajador = @rut_trabajador AND " & _
              " fecha_inicio_sesion = @fecha_inicio_sesion "
            Dim cmd As New MySqlCommand(sql, cnx.getConexion)
            cmd.Parameters.AddWithValue("@fecha_termino_sesion", String.Format("{0:yyyy-MM-dd HH:mm:ss}", DateTime.Now()))
            cmd.Parameters.AddWithValue("@rut_trabajador", rut)
            cmd.Parameters.AddWithValue("@fecha_inicio_sesion", fecha)
            cmd.Prepare()
            If cmd.ExecuteNonQuery = 1 Then
                Return True
            Else : Return False
            End If
        Catch ex As MySqlException
            MsgBox("error!!!!")
            MsgBox(vbCritical, "Error " & ex.Number & ": " & ex.Message, vbOKOnly)
        Finally
            cnx.desconectar()
        End Try
        Return False
    End Function
End Class
