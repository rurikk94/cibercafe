Imports MySql.Data.MySqlClient

Public Class TrabajadorDAO
    Private controlador, _ap As New MySqlDataAdapter
    Private sql As String
    Private Const TIPO_USUARIO As Integer = 2   '<--- para los trabajadores(cajeros)
    Private ds As New DataSet 'lo guarda en la memoria interna. dts=dataset
    Private dataview As New DataView
    Private lector As MySqlDataReader

    Private Function generarSQL(ByVal tipo As Integer) 'parametrizado
        Dim sql As String = ""
        If tipo = 1 Then   ' consulta 
            sql = "SELECT rut as 'Rut', nombre as 'Nombre', apellidos as 'Apellidos', fono as 'Fono', password as 'Password', tipo_usuario as 'Tipo', estado as 'Estado' " & _
                                "FROM usuario " & _
                                "WHERE tipo_usuario = @tipo_usuario ORDER BY rut"

        ElseIf tipo = 2 Then  'insercion
            sql = "INSERT INTO usuario " & _
                       "VALUES (@rut,@nombre,@apellidos,@fono,@password,@tipo_usuario,@estado)"

        ElseIf tipo = 3 Then 'actualizacion
            sql = "UPDATE usuario " & _
                    "SET nombre = @nombre, " & _
                        "apellidos = @apellidos, " & _
                        "fono = @fono, " & _
                        "password = @password, " & _
                        "estado = @estado " & _
                    "WHERE rut = @rut"
        ElseIf tipo = 10 Then
            sql = "insert into usuario values(1,1,1,1,1,1,1,1)"
        ElseIf tipo = 4 Then 'Eliminacion
            sql = "DELETE FROM usuario WHERE rut = @rut"

        End If
        Return sql
    End Function

    Public Function consultarTodos() As DataSet
        Dim cnx As New Connection
        Try
            cnx.conectar()
            ds.Reset()
            controlador.SelectCommand = New MySqlCommand(generarSQL(1), cnx.getConexion)
            controlador.SelectCommand.Parameters.Add("@tipo_usuario", MySqlDbType.Int32, 1).Value = TIPO_USUARIO
            controlador.Fill(ds, "usuario")
        Catch ex As MySqlException
            MsgBox(vbCritical, "Error " & ex.Number & ": " & ex.Message, vbOKOnly)
        Finally
            cnx.desconectar()
        End Try
        Return ds
    End Function


    Public Sub agregar(ByVal vo As TrabajadorVO)
        Dim cnx As New Connection
        Try
            cnx.conectar()
            controlador.InsertCommand = New MySqlCommand(generarSQL(2), cnx.getConexion)
            Dim nombre As String = vo.getUsuario
            controlador.InsertCommand.Parameters.Add("@rut", MySqlDbType.VarChar, 9).Value = vo.getRut
            controlador.InsertCommand.Parameters.Add("@nombre", MySqlDbType.VarChar, 30).Value = vo.getNombre
            controlador.InsertCommand.Parameters.Add("@apellidos", MySqlDbType.VarChar, 30).Value = vo.getApellido
            controlador.InsertCommand.Parameters.Add("@fono", MySqlDbType.VarChar, 20).Value = vo.getFono
            controlador.InsertCommand.Parameters.Add("@password", MySqlDbType.VarChar, 15).Value = vo.getPassword
            controlador.InsertCommand.Parameters.Add("@tipo_usuario", MySqlDbType.Int32, 1).Value = TIPO_USUARIO
            controlador.InsertCommand.Parameters.Add("@estado", MySqlDbType.Int32, 1).Value = vo.getEstado
            Dim resultado As Integer = controlador.InsertCommand.ExecuteNonQuery()
        Catch ex As MySqlException
            Throw ex
            MessageBox.Show("Ocurrio un error al agregar.")
        Finally
            cnx.desconectar()
        End Try


    End Sub

    Public Sub eliminar(ByVal value As String)
        Dim cnx As New Connection
        Try
            cnx.conectar()
            Dim cmd As New MySqlCommand
            cmd.Connection = cnx.getConexion
            cmd.CommandText = generarSQL(4)
            cmd.Parameters.AddWithValue("@rut", value)
            cmd.Prepare()
            cmd.ExecuteNonQuery()
            MsgBox("Eliminacion exitosa", vbOKOnly)
        Catch ex As MySqlException
            MsgBox(ex.Message.ToString)
        Finally
            cnx.desconectar()
        End Try

    End Sub

    Public Sub actualizar(ByVal vo As TrabajadorVO)
        Dim cnx As New Connection
        Try
            cnx.conectar()
            Dim cmd As New MySqlCommand
            cmd.Connection = cnx.getConexion
            cmd.CommandText = generarSQL(3)
            cmd.Parameters.AddWithValue("@rut", vo.getRut)
            cmd.Parameters.AddWithValue("@nombre", vo.getNombre)
            cmd.Parameters.AddWithValue("@apellidos", vo.getApellido)
            cmd.Parameters.AddWithValue("@fono", vo.getFono)
            cmd.Parameters.AddWithValue("@password", vo.getPassword)
            cmd.Parameters.AddWithValue("@estado", vo.getEstado)
            cmd.Prepare()
            Dim result As Integer = cmd.ExecuteNonQuery()
            If result > 0 Then
                MsgBox("Actualizacion exitosa", vbOKOnly)
            Else
                MsgBox("Ocurrio un error.")
            End If
        Catch ex As MySqlException
            MsgBox(ex.Message.ToString)
        Finally
            cnx.desconectar()
        End Try
    End Sub


    Public Function buscarPorRut(ByVal value As String) As Boolean
        Dim cnx As New Connection
        Try
            cnx.conectar()
            ds.Reset()
            sql = "SELECT * from usuario where rut = @rut"
            Dim cmd As New MySqlCommand(sql, cnx.getConexion)
            cmd.Parameters.AddWithValue("@rut", value)
            cmd.Prepare()
            lector = cmd.ExecuteReader
            If lector.HasRows Then
                Return True
            End If
            Return False
        Catch ex As MySqlException
            MsgBox("error")
            MsgBox("Error " & ex.Number & ": " & ex.Message.ToString, vbCritical, vbOKOnly)
        Finally
            cnx.desconectar()
        End Try
        Return True
    End Function


End Class
