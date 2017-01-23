Imports MySql.Data.MySqlClient

Public Class ClienteDAO
    Private controlador As New MySqlDataAdapter
    Private lector As MySqlDataReader
    Private sql As String
    Private ds As New DataSet

    Public Function buscarTodos() As DataSet
        Dim cnx As New Connection
        Try
            cnx.conectar()
            ds.Reset()
            sql = "SELECT nombre_usuario 'Usuario', nombre 'Nombre', apellidos 'Apellidos', estado 'Estado', password 'Password'  FROM cliente"
            controlador.SelectCommand = New MySqlCommand(sql, cnx.getConexion)
            controlador.Fill(ds, "cliente")
            Return ds
        Catch ex As MySqlException
            MsgBox("error")
            MsgBox("Error " & ex.Number & ": " & ex.Message.ToString, vbCritical, vbOKOnly)
        Finally
            cnx.desconectar()
        End Try
        Return ds
    End Function


    Public Sub agregar(ByVal vo As ClienteVO)
        Dim cnx As New Connection
        Try
            cnx.conectar()
            sql = "insert into cliente (nombre_usuario, nombre, apellidos, password, estado) values (@nombre_usuario, @nombre, @apellidos, @password, @estado)"
            Dim cmd As New MySqlCommand(sql, cnx.getConexion)
            cmd.Parameters.AddWithValue("@nombre_usuario", vo.getNombre_usuario)
            cmd.Parameters.AddWithValue("@nombre", vo.getNombre)
            cmd.Parameters.AddWithValue("@apellidos", vo.getApellidos)
            cmd.Parameters.AddWithValue("@password", vo.getPassword)
            cmd.Parameters.AddWithValue("@estado", vo.getEstado)
            Dim resultado As Integer = cmd.ExecuteNonQuery()
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
            cmd.CommandText = "delete from cliente where nombre_usuario = @nombre_usuario"
            cmd.Parameters.AddWithValue("@nombre_usuario", value)
            cmd.Prepare()
            cmd.ExecuteNonQuery()
            MsgBox("Eliminacion exitosa", vbOKOnly)
        Catch ex As MySqlException
            MsgBox(ex.Message.ToString)
        Finally
            cnx.desconectar()
        End Try

    End Sub

    Public Sub actualizar(ByVal vo As ClienteVO)
        Dim cnx As New Connection
        Try
            cnx.conectar()
            Dim cmd As New MySqlCommand
            cmd.Connection = cnx.getConexion
            cmd.CommandText = "update cliente " & _
                                    " set nombre = @nombre," & _
                                    " apellidos = @apellidos, " & _
                                    " password  = @password, " & _
                                    " estado = @estado " & _
                                    " where nombre_usuario = @nombre_usuario"
            cmd.Parameters.AddWithValue("@nombre_usuario", vo.getNombre_usuario)
            cmd.Parameters.AddWithValue("@nombre", vo.getNombre)
            cmd.Parameters.AddWithValue("@apellidos", vo.getApellidos)
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

    Public Function buscarPorNombreUsuario(ByVal value As String) As Boolean
        Dim cnx As New Connection
        Try
            cnx.conectar()
            ds.Reset()
            sql = "SELECT * from cliente where nombre_usuario = @nombre_usuario"
            Dim cmd As New MySqlCommand(sql, cnx.getConexion)
            cmd.Parameters.AddWithValue("@nombre_usuario", value)
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


