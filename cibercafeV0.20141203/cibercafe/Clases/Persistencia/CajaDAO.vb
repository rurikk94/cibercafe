Imports MySql.Data.MySqlClient



Public Class CajaDAO
    Private controlador As New MySqlDataAdapter
    Private ds As New DataSet
    Private sql As String
    Private Const cod_apertura As Integer = 1
    Private Const cod_cierre As Integer = 2

    Private Function generarSQL(ByVal tipo As Integer) 'parametrizado
        Dim sql As String = ""
        If tipo = 1 Then   '
            sql = "SELECT *" & _
                    " FROM caja " & _
                    " WHERE fechaHora LIKE @fecha AND tipo_transacc = @tipo_transacc "

        ElseIf tipo = 2 Then  'insercion
            sql = "INSERT INTO caja ( tipo_transacc, monto) " & _
                        " VALUES (@tipo_transacc, @monto)  "
        ElseIf tipo = 3 Then 'actualizacion
            'sql = "UPDATE usuario " & _
            '        "SET nombre = @nombre, " & _
            '            "apellidos = @apellidos, " & _
            '            "fono = @fono, " & _
            '            "password = @password, " & _
            '            "estado = @estado " & _
            '        "WHERE rut = @rut"
        ElseIf tipo = 10 Then
            'sql = "insert into usuario values(1,1,1,1,1,1,1,1)"
        ElseIf tipo = 4 Then 'Eliminacion
            'sql = "DELETE FROM usuario WHERE rut = @rut"

        End If
        Return sql
    End Function

    Public Function abrirCaja(ByVal monto As Double) As Integer
        Dim cnx As New Connection
        Try
            cnx.conectar()
            Dim cmd As New MySqlCommand
            cmd.Connection = cnx.getConexion()
            cmd.CommandText = generarSQL(2)
            'agrearmos la hora local o en UTC?
            cmd.Parameters.AddWithValue("@monto", monto)
            cmd.Parameters.AddWithValue("@tipo_transacc", 1)
            cmd.Prepare()
            Return cmd.ExecuteNonQuery()
        Catch ex As MySqlException
            MsgBox(ex.Message.ToString)
        Finally
            cnx.desconectar()
        End Try
        Return 0
    End Function

    Public Function cajaEstaAbierta() As Boolean
        Dim cnx As New Connection
        Try
            cnx.conectar()
            ds.Reset()
            controlador.SelectCommand = New MySqlCommand(generarSQL(1), cnx.getConexion)
            Dim busqueda As String = "%" & DateTime.Now.ToString("yyyy-MM-dd") & "%"
            'MsgBox(busqueda)
            controlador.SelectCommand.Parameters.AddWithValue("@fecha", busqueda)
            controlador.SelectCommand.Parameters.AddWithValue("@tipo_transacc", cod_apertura)
            controlador.Fill(ds, "caja")
            If (ds.Tables("caja").Rows.Count() <> 0) Then 'Ya está abierta
                Return True
            Else
                Return False
            End If
        Catch ex As MySqlException

        Finally
            cnx.desconectar()
        End Try
        Return True
    End Function


End Class
