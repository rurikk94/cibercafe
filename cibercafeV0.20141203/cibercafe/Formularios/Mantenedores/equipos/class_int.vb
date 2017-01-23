Imports MySql.Data
Imports MySql.Data.MySqlClient
Imports MySql.Data.Types
Public Class class_int
    Private _adpatador As New MySqlDataAdapter
    Public Function insertarDatos(ByVal datos As class_datos) As Boolean
        Dim estado_funcion As Boolean = True
        Try
            conexion_Global()
            _adpatador.InsertCommand = New MySqlCommand("insert into computador (direcc_MAC,direcc_IP,estado) values(@direcc_MAC,@direcc_IP,@estado)", _conexion)
            _adpatador.InsertCommand.Parameters.Add("@direcc_MAC", MySqlDbType.VarChar, 12).Value = datos.direcc_MAC
            _adpatador.InsertCommand.Parameters.Add("@direcc_IP", MySqlDbType.VarChar, 20).Value = datos.direcc_IP
            _adpatador.InsertCommand.Parameters.Add("@estado", MySqlDbType.Int32, 4).Value = datos.estado
            _conexion.Open()
            _adpatador.InsertCommand.Connection = _conexion
            _adpatador.InsertCommand.ExecuteNonQuery()
        Catch ex As MySqlException
            'MessageBox.Show(ex.Message)
            estado_funcion = False
        Finally
            cerrar()
        End Try
        Return estado_funcion
    End Function
    Public Function actualizarDatos(ByVal datos As class_datos) As Boolean
        Dim estado As Boolean = True
        Try
            conexion_Global()
            '_adpatador.UpdateCommand = New MySqlCommand("update tablauno set col_dos=@col_dos, col_tres=@col_tres where col_uno=@col_uno", _conexion)
            _adpatador.UpdateCommand = New MySqlCommand("update computador set direcc_MAC=@direcc_MAC,direcc_IP=@direcc_IP,estado=@estado where direcc_MAC=@direcc_MAC", _conexion)
            _adpatador.UpdateCommand.Parameters.Add("@direcc_MAC", MySqlDbType.VarChar, 12).Value = datos.direcc_MAC
            _adpatador.UpdateCommand.Parameters.Add("@direcc_IP", MySqlDbType.VarChar, 20).Value = datos.direcc_IP
            _adpatador.UpdateCommand.Parameters.Add("@estado", MySqlDbType.Int32, 4).Value = datos.estado
            _conexion.Open()
            _adpatador.UpdateCommand.Connection = _conexion
            _adpatador.UpdateCommand.ExecuteNonQuery()
        Catch ex As Exception
            'MessageBox.Show(ex.Message)
            estado = False
        Finally
            cerrar()
        End Try
        Return estado
    End Function
    Public Function eliminarDatos(ByVal datos As class_datos) As Boolean
        Dim estado As Boolean = True
        Try
            conexion_Global()
            _adpatador.DeleteCommand = New MySqlCommand("delete from computador where direcc_MAC=@direcc_MAC", _conexion)
            _adpatador.DeleteCommand.Parameters.Add("@direcc_MAC", MySqlDbType.VarChar, 12).Value = datos.direcc_MAC
            _conexion.Open()
            _adpatador.DeleteCommand.Connection = _conexion
            _adpatador.DeleteCommand.ExecuteNonQuery()
        Catch ex As Exception
            'MessageBox.Show(ex.Message)
            estado = False
        Finally
            cerrar()
        End Try
        Return estado
    End Function
End Class
