Imports MySql.Data
Imports MySql.Data.MySqlClient
Imports MySql.Data.Types
Module mod_consulta
    Private _adaptador As New MySqlDataAdapter
    Public _dtsdatos, _dtscbox As New DataSet 'lo guarda en la memoria interna. dts=dataset
    Public _dtvdatos As New DataView 'lo muestra. dtv = dataview
    Public Sub consulta_datos()
        Try
            conexion_Global()
            '_adaptador.SelectCommand = New MySqlCommand("select * from tablauno", _conexion)
            If mantenedor_equipos.rad_computador.Checked Then 'si tipo de equipo es COMPUTADOR
                _adaptador.SelectCommand = New MySqlCommand("select direcc_MAC 'Direccion MAC',direcc_ip 'Direccion IP',estado 'ESTADO' from computador", _conexion)
                _adaptador.Fill(_dtsdatos)
                '_adaptador.Fill(_dtscbox, "tablauno")
                _adaptador.Fill(_dtscbox, "computador")
            Else 'si tipo de equipo es CONSOLA
                _adaptador.SelectCommand = New MySqlCommand("select numero_consola 'Numero de Consola',estado 'ESTADO' from consola", _conexion)
                _adaptador.Fill(_dtsdatos)
                '_adaptador.Fill(_dtscbox, "tablauno")
                _adaptador.Fill(_dtscbox, "consola")
            End If
            _dtvdatos.Table = _dtsdatos.Tables(0) 'dataview toma el valor del dataset
            _conexion.Open()
            _adaptador.SelectCommand.Connection = _conexion
            _adaptador.SelectCommand.ExecuteNonQuery()

        Catch ex As Exception
            'MessageBox.Show(ex.Message)
            MessageBox.Show("Error en la consulta a las tablas")
        Finally
            cerrar()
        End Try
    End Sub
End Module
