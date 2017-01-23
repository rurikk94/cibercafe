Imports MySql.Data.MySqlClient

Public Class ProveedoresDAO

    Private controlador As New MySqlDataAdapter
    Private lector As MySqlDataReader
    Private sql As String
    Private ds As New DataSet

    Public Function consultarTodos() As DataSet
        Dim cnx As New Connection
        Try
            cnx.conectar()
            ds.Reset()
            sql = "SELECT rut_proveedor 'Rut', nombre_proveedor 'Nombre', telefono_proveedor 'Telefono', direccion_proveedor 'Direccion', nombre_empresa_proveedor 'Nombre de la empresa', e_mail_proveedor 'Email'  FROM proveedores"
            controlador.SelectCommand = New MySqlCommand(sql, cnx.getConexion)
            controlador.Fill(ds, "proveedor")
            Return ds
        Catch ex As MySqlException
            MsgBox("Error " & ex.Number & ": " & ex.Message.ToString, vbCritical, vbOKOnly)
        Finally
            cnx.desconectar()
        End Try
        Return ds
    End Function


    Public Sub agregar(ByVal vo As ProveedoresVO)
        Dim cnx As New Connection
        Try
            cnx.conectar()
            sql = "insert into proveedores (rut_proveedor, nombre_proveedor, telefono_proveedor, direccion_proveedor, nombre_empresa_proveedor, e_mail_proveedor) " & _
                  " values (@rut_proveedor, @nombre_proveedor, @telefono_proveedor, @direccion_proveedor, @nombre_empresa_proveedor, @e_mail_proveedor)"
            Dim cmd As New MySqlCommand(sql, cnx.getConexion)
            cmd.Parameters.AddWithValue("@rut_proveedor", vo.getRut_proveedor)
            cmd.Parameters.AddWithValue("@nombre_proveedor", vo.getNombre_proveedor)
            cmd.Parameters.AddWithValue("@telefono_proveedor", vo.getTelefono_proveedor)
            cmd.Parameters.AddWithValue("@direccion_proveedor", vo.getDireccion_proveedor)
            cmd.Parameters.AddWithValue("@nombre_empresa_proveedor", vo.getNombre_empresa_proveedor)
            cmd.Parameters.AddWithValue("@e_mail_proveedor", vo.getE_mail_proveedor)
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
            cmd.CommandText = "delete from proveedores where rut_proveedor = @rut_proveedor"
            cmd.Parameters.AddWithValue("@rut_proveedor", value)
            cmd.Prepare()
            cmd.ExecuteNonQuery()
            MsgBox("Eliminacion exitosa", vbOKOnly)
        Catch ex As MySqlException
            MsgBox(ex.Message.ToString)
        Finally
            cnx.desconectar()
        End Try

    End Sub

    Public Sub actualizar(ByVal vo As ProveedoresVO)
        Dim cnx As New Connection
        Try
            cnx.conectar()
            Dim cmd As New MySqlCommand
            cmd.Connection = cnx.getConexion
            cmd.CommandText = "update proveedores " & _
                                    " set nombre_proveedor = @nombre_proveedor, " & _
                                    " telefono_proveedor = @telefono_proveedor, " & _
                                    " direccion_proveedor  = @direccion_proveedor, " & _
                                    " nombre_empresa_proveedor = @nombre_empresa_proveedor, " & _
                                    " e_mail_proveedor = @e_mail_proveedor " & _
                                    " where rut_proveedor = @rut_proveedor"
            cmd.Parameters.AddWithValue("@nombre_proveedor", vo.getNombre_proveedor)
            cmd.Parameters.AddWithValue("@telefono_proveedor", vo.getTelefono_proveedor)
            cmd.Parameters.AddWithValue("@direccion_proveedor", vo.getDireccion_proveedor)
            cmd.Parameters.AddWithValue("@nombre_empresa_proveedor", vo.getNombre_empresa_proveedor)
            cmd.Parameters.AddWithValue("@e_mail_proveedor", vo.getE_mail_proveedor)
            cmd.Parameters.AddWithValue("@rut_proveedor", vo.getRut_proveedor)
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

    Public Function buscarPorNombre(ByVal value As String) As Boolean
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
            MsgBox("Error " & ex.Number & ": " & ex.Message.ToString, vbCritical, vbOKOnly)
        Finally
            cnx.desconectar()
        End Try
        Return True
    End Function




End Class
