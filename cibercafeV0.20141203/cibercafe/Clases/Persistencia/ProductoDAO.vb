Imports MySql.Data.MySqlClient


Public Class ProductoDAO
    Private controlador As New MySqlDataAdapter
    Private ds As New DataSet
    Private sql As String


    Public Function buscarPorNombre(ByVal value As String) As DataSet
        Dim cnx As New Connection
        Try
            cnx.conectar()
            ds.Reset()

            'Busqueda difusa
            sql = "SELECT cod_producto 'Codigo', nom_producto 'Producto', cantidad 'Cantidad', precio_unitario 'Precio unitario' FROM producto WHERE nom_producto LIKE @nom_producto"
            Dim busqueda As String = "%" & value & "%"

            controlador.SelectCommand = New MySqlCommand(sql, cnx.getConexion)
            controlador.SelectCommand.Parameters.AddWithValue("@nom_producto", busqueda)
            controlador.Fill(ds, "producto")
            Return ds
        Catch ex As MySqlException
            MsgBox("Error " & ex.Number & ": " & ex.Message.ToString, vbCritical, vbOKOnly)
        Finally
            cnx.desconectar()
        End Try
        Return ds
    End Function

    Public Function buscarPorCodigo(ByVal value As String) As DataSet
        Dim cnx As New Connection
        Try
            cnx.conectar()
            ds.Reset()

            sql = "SELECT nom_producto, cantidad, precio_unitario FROM producto WHERE cod_producto = @cod_producto"
            controlador.SelectCommand = New MySqlCommand(sql, cnx.getConexion)
            controlador.SelectCommand.Parameters.AddWithValue("@cod_producto", value)
            controlador.Fill(ds, "codigos")
            Return ds
        Catch ex As MySqlException
            MsgBox("Error " & ex.Number & ": " & ex.Message.ToString, vbCritical, vbOKOnly)
        Finally
            cnx.desconectar()
        End Try
        Return ds
    End Function

    Public Function recuperarCodigos() As ArrayList
        Dim cnx As New Connection
        Try
            cnx.conectar()
            Dim lector As MySqlDataReader
            Dim lista As ArrayList = New ArrayList
            sql = "SELECT cod_producto, nom_producto FROM producto"
            Dim command As New MySqlCommand(sql, cnx.getConexion)
            lector = command.ExecuteReader
            If lector.HasRows Then
                While lector.Read
                    Dim vo As New ProductoVO
                    vo.setCod_producto(lector.GetUInt32("cod_producto"))
                    vo.setNom_producto(lector.GetString("nom_producto"))
                    lista.Add(vo)
                End While
            End If
            Return lista
        Catch ex As MySqlException
            MsgBox("Error " & ex.Number & ": " & ex.Message.ToString, vbCritical, vbOKOnly)
        Finally
            cnx.desconectar()
            cnx.getConexion.Dispose()

        End Try
        Return Nothing
    End Function

End Class
