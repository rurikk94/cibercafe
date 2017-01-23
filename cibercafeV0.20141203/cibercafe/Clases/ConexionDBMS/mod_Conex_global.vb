' importar referencia mysql C:\Program Files (x86)\MySQL\MySQL Connector Net 6.9.4\Assemblies\v4.0\MySql.Data.dll
Imports MySql.Data
Imports MySql.Data.MySqlClient
Imports MySql.Data.Types
Module mod_Conex_global
    Public _cadena As String
    Public _conexion As New MySqlConnection
    Public Function conexion_Global() As Boolean
        Dim estado As Boolean = True
        Try
            _cadena = ("server=localhost;user id=root;password="";database=cibercafe")
            '_cadena = ("server=localhost;user id=root;password=;database=cibercafe")
            '_cadena = ventana_menu.txt_cadena.Text
            _conexion = New MySqlConnection(_cadena)
        Catch ex As Exception
            'MessageBox.Show(ex.Message)
            MessageBox.Show("Error en la Conexion a la Base de datos")
            estado = False
        End Try
        Return estado
    End Function
    Public Sub cerrar()
        _conexion.Close()
    End Sub
End Module
