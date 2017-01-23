Imports System.Text.RegularExpressions

Public Class mantenedor_equipos
    Public version_programa As String = "V20141011.08"
    Dim nuevo As Boolean
    Private Sub mantenedor_equipos_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        lbl_version.Text = version_programa
        lbl_version.BackColor = Color.Empty
        rad_computador.Checked = True
        rad_agregar.Checked = True

        llamarDatos()
        tip()
        TextBox11.Focus()

    End Sub
    Private Sub btn_salir_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_salir.Click
        Me.Close()
    End Sub
    Public Sub llamarDatos()
        _dtsdatos.Reset()
        _dtscbox.Reset()

        consulta_datos()
        DataGridView1.DataSource = _dtvdatos 'el datagrid toma el valor del dataview        
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        If rad_computador.Checked Then 'si tipo de equipo es COMPUTADOR
            Dim datos As New class_datos
            Dim conexion As New class_int
            If validarMAC() Then 'si mac es valida, en largo, al apretar guardar cambios
                txt_direcc_mac.Text = TextBox11.Text & TextBox12.Text & TextBox13.Text & TextBox14.Text & TextBox15.Text & TextBox16.Text
                'txt_direcc_ip.Text = TextBox1.Text & TextBox2.Text & TextBox3.Text & TextBox4.Text
                If txt_direcc_ip.TextLength < 4 Then
                    MessageBox.Show("Direccion IP muy corta. Debe ser mayor de 4 digitos, máximo 16")
                    txt_direcc_ip.Focus()
                    txt_direcc_ip.SelectAll()
                Else
                    datos.direcc_IP = txt_direcc_ip.Text

                    datos.direcc_MAC = txt_direcc_mac.Text

                    datos.estado = cmb_estado.Text
                    If nuevo Then 'si es nuevo, osea Agregando
                        If conexion.insertarDatos(datos) Then
                            llamarDatos()
                            MessageBox.Show("Datos Agregados")

                        Else
                            MessageBox.Show("Datos no Agregados")
                        End If
                    Else 'si no es nuevo, osea editando
                        If conexion.actualizarDatos(datos) Then
                            llamarDatos()
                            MessageBox.Show("Datos Actualizados")

                        Else
                            MessageBox.Show("Datos no Actualizados")
                        End If
                    End If
                End If
            End If
        End If
        If rad_consola.Checked Then 'si tipo de equipo es CONSOLA
            Dim datos As New class_datos_consola
            Dim conexion As New class_int_consola
            datos.numero_consola = num_consola.Text
            datos.estado = cmb_estado.Text
            If nuevo Then 'si no es nuevo, osea Agregando
                If conexion.insertarDatos(datos) Then
                    llamarDatos()
                    MessageBox.Show("Datos Agregados")
                    limpiar()
                Else
                    MessageBox.Show("Datos no Agregados")
                End If
            Else 'si no es nuevo, osea editando
                If conexion.actualizarDatos(datos) Then
                    llamarDatos()
                    MessageBox.Show("Datos Actualizados")
                    limpiar()
                Else
                    MessageBox.Show("Datos no Actualizados")
                End If
            End If
        End If


    End Sub

    Private Sub btn_eliminar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_eliminar.Click
        If rad_computador.Checked Then 'si tipo de equipo es COMPUTADOR 
            If validarMAC() Then
                Dim conexion As New class_int
                Dim datos As New class_datos
                _dtsdatos.Reset()
                datos.direcc_MAC = txt_direcc_mac.Text
                If conexion.eliminarDatos(datos) Then
                    consulta_datos()
                    DataGridView1.DataSource = _dtvdatos
                    MessageBox.Show("Datos eliminados")
                    limpiar()
                Else
                    MessageBox.Show("Datos no eliminados")
                End If
            End If
        Else 'si tipo de equipo es CONSOLA 
            Dim conexion As New class_int_consola
            Dim datos As New class_datos_consola
            _dtsdatos.Reset()
            datos.numero_consola = num_consola.Text
            If conexion.eliminarDatos(datos) Then
                consulta_datos()
                DataGridView1.DataSource = _dtvdatos
                MessageBox.Show("Datos eliminados")
                limpiar()
            Else
                MessageBox.Show("Datos no eliminados")
            End If
        End If
    End Sub
    Private Sub DataGridView1_DoubleClick(ByVal sender As Object, ByVal e As System.EventArgs) Handles DataGridView1.DoubleClick
        Try
            If rad_computador.Checked Then 'por si seleciona filas vacias
                If Not (DataGridView1.Rows(DataGridView1.CurrentRow.Index).Cells(0).Value Is DBNull.Value) Then _
                    txt_direcc_mac.Text = DataGridView1.Rows(DataGridView1.CurrentRow.Index).Cells(0).Value
                TextBox11.Text = txt_direcc_mac.Text.Substring(0, 2)
                TextBox12.Text = txt_direcc_mac.Text.Substring(2, 2)
                TextBox13.Text = txt_direcc_mac.Text.Substring(4, 2)
                TextBox14.Text = txt_direcc_mac.Text.Substring(6, 2)
                TextBox15.Text = txt_direcc_mac.Text.Substring(8, 2)
                TextBox16.Text = txt_direcc_mac.Text.Substring(10, 2)
                If Not (DataGridView1.Rows(DataGridView1.CurrentRow.Index).Cells(1).Value Is DBNull.Value) Then _
                    txt_direcc_ip.Text = DataGridView1.Rows(DataGridView1.CurrentRow.Index).Cells(1).Value

                If Not (DataGridView1.Rows(DataGridView1.CurrentRow.Index).Cells(2).Value Is DBNull.Value) Then _
                    cmb_estado.Text = DataGridView1.Rows(DataGridView1.CurrentRow.Index).Cells(2).Value
            Else
                If Not (DataGridView1.Rows(DataGridView1.CurrentRow.Index).Cells(0).Value Is DBNull.Value) Then _
                    num_consola.Text = DataGridView1.Rows(DataGridView1.CurrentRow.Index).Cells(0).Value
                If Not (DataGridView1.Rows(DataGridView1.CurrentRow.Index).Cells(1).Value Is DBNull.Value) Then _
                    cmb_estado.Text = DataGridView1.Rows(DataGridView1.CurrentRow.Index).Cells(1).Value
            End If

        Catch ex As NullReferenceException
            MessageBox.Show(ex.Message)
            MessageBox.Show("No hay Filas")
        End Try
    End Sub
    Private Function validarMAC() As Boolean
        Dim valido As Boolean = False
        If validar_no_vacios() Then
            valido = True
            TextBox11.BackColor = Color.White
            TextBox12.BackColor = Color.White
            TextBox13.BackColor = Color.White
            TextBox14.BackColor = Color.White
            TextBox15.BackColor = Color.White
            TextBox16.BackColor = Color.White
        Else    'si no es valido
            TextBox11.BackColor = Color.Red
            TextBox12.BackColor = Color.Red
            TextBox13.BackColor = Color.Red
            TextBox14.BackColor = Color.Red
            TextBox15.BackColor = Color.Red
            TextBox16.BackColor = Color.Red
        End If
        Return valido
    End Function
    Function validar_no_vacios()
        Dim valido As Boolean = False
        If validar_hex(UCase(TextBox11.Text)) Then
            If validar_hex(UCase(TextBox12.Text)) Then
                If validar_hex(UCase(TextBox13.Text)) Then
                    If validar_hex(UCase(TextBox14.Text)) Then
                        If validar_hex(UCase(TextBox15.Text)) Then
                            If validar_hex(UCase(TextBox16.Text)) Then
                                valido = True
                            End If
                        End If
                    End If
                End If
            End If
        End If
        If Not valido Then
            MessageBox.Show("Ingrese Una MAC valida")
            TextBox11.Focus()
            TextBox11.SelectAll()
        End If
        Return valido
    End Function
    Private Function macValida(ByVal mac As String) As Boolean
        Dim patron As String = "^[0-9a-fA-F]{12}$"
        Dim coincidencia As Match = Regex.Match(mac, patron)
        If coincidencia.Success Then
            Return True
        End If
        Return False
    End Function

    Function validar_hex(ByVal text_ingresado As String)
        Dim validado As Boolean = False
        If Len(text_ingresado) = 2 Then
            If text_ingresado = "00" Then
                validado = True
            ElseIf text_ingresado = "01" Then
                validado = True
            ElseIf text_ingresado = "02" Then
                validado = True
            ElseIf text_ingresado = "03" Then
                validado = True
            ElseIf text_ingresado = "04" Then
                validado = True
            ElseIf text_ingresado = "05" Then
                validado = True
            ElseIf text_ingresado = "06" Then
                validado = True
            ElseIf text_ingresado = "07" Then
                validado = True
            ElseIf text_ingresado = "08" Then
                validado = True
            ElseIf text_ingresado = "09" Then
                validado = True
            ElseIf text_ingresado = "0A" Then
                validado = True
            ElseIf text_ingresado = "0B" Then
                validado = True
            ElseIf text_ingresado = "0C" Then
                validado = True
            ElseIf text_ingresado = "0D" Then
                validado = True
            ElseIf text_ingresado = "0E" Then
                validado = True
            ElseIf text_ingresado = "0F" Then
                validado = True
            ElseIf text_ingresado = "10" Then
                validado = True
            ElseIf text_ingresado = "11" Then
                validado = True
            ElseIf text_ingresado = "12" Then
                validado = True
            ElseIf text_ingresado = "13" Then
                validado = True
            ElseIf text_ingresado = "14" Then
                validado = True
            ElseIf text_ingresado = "15" Then
                validado = True
            ElseIf text_ingresado = "16" Then
                validado = True
            ElseIf text_ingresado = "17" Then
                validado = True
            ElseIf text_ingresado = "18" Then
                validado = True
            ElseIf text_ingresado = "19" Then
                validado = True
            ElseIf text_ingresado = "1A" Then
                validado = True
            ElseIf text_ingresado = "1B" Then
                validado = True
            ElseIf text_ingresado = "1C" Then
                validado = True
            ElseIf text_ingresado = "1D" Then
                validado = True
            ElseIf text_ingresado = "1E" Then
                validado = True
            ElseIf text_ingresado = "1F" Then
                validado = True
            ElseIf text_ingresado = "20" Then
                validado = True
            ElseIf text_ingresado = "21" Then
                validado = True
            ElseIf text_ingresado = "22" Then
                validado = True
            ElseIf text_ingresado = "23" Then
                validado = True
            ElseIf text_ingresado = "24" Then
                validado = True
            ElseIf text_ingresado = "25" Then
                validado = True
            ElseIf text_ingresado = "26" Then
                validado = True
            ElseIf text_ingresado = "27" Then
                validado = True
            ElseIf text_ingresado = "28" Then
                validado = True
            ElseIf text_ingresado = "29" Then
                validado = True
            ElseIf text_ingresado = "2A" Then
                validado = True
            ElseIf text_ingresado = "2B" Then
                validado = True
            ElseIf text_ingresado = "2C" Then
                validado = True
            ElseIf text_ingresado = "2D" Then
                validado = True
            ElseIf text_ingresado = "2E" Then
                validado = True
            ElseIf text_ingresado = "2F" Then
                validado = True
            ElseIf text_ingresado = "30" Then
                validado = True
            ElseIf text_ingresado = "31" Then
                validado = True
            ElseIf text_ingresado = "32" Then
                validado = True
            ElseIf text_ingresado = "33" Then
                validado = True
            ElseIf text_ingresado = "34" Then
                validado = True
            ElseIf text_ingresado = "35" Then
                validado = True
            ElseIf text_ingresado = "36" Then
                validado = True
            ElseIf text_ingresado = "37" Then
                validado = True
            ElseIf text_ingresado = "38" Then
                validado = True
            ElseIf text_ingresado = "39" Then
                validado = True
            ElseIf text_ingresado = "3A" Then
                validado = True
            ElseIf text_ingresado = "3B" Then
                validado = True
            ElseIf text_ingresado = "3C" Then
                validado = True
            ElseIf text_ingresado = "3D" Then
                validado = True
            ElseIf text_ingresado = "3E" Then
                validado = True
            ElseIf text_ingresado = "3F" Then
                validado = True
            ElseIf text_ingresado = "40" Then
                validado = True
            ElseIf text_ingresado = "41" Then
                validado = True
            ElseIf text_ingresado = "42" Then
                validado = True
            ElseIf text_ingresado = "43" Then
                validado = True
            ElseIf text_ingresado = "44" Then
                validado = True
            ElseIf text_ingresado = "45" Then
                validado = True
            ElseIf text_ingresado = "46" Then
                validado = True
            ElseIf text_ingresado = "47" Then
                validado = True
            ElseIf text_ingresado = "48" Then
                validado = True
            ElseIf text_ingresado = "49" Then
                validado = True
            ElseIf text_ingresado = "4A" Then
                validado = True
            ElseIf text_ingresado = "4B" Then
                validado = True
            ElseIf text_ingresado = "4C" Then
                validado = True
            ElseIf text_ingresado = "4D" Then
                validado = True
            ElseIf text_ingresado = "4E" Then
                validado = True
            ElseIf text_ingresado = "4F" Then
                validado = True
            ElseIf text_ingresado = "50" Then
                validado = True
            ElseIf text_ingresado = "51" Then
                validado = True
            ElseIf text_ingresado = "52" Then
                validado = True
            ElseIf text_ingresado = "53" Then
                validado = True
            ElseIf text_ingresado = "54" Then
                validado = True
            ElseIf text_ingresado = "55" Then
                validado = True
            ElseIf text_ingresado = "56" Then
                validado = True
            ElseIf text_ingresado = "57" Then
                validado = True
            ElseIf text_ingresado = "58" Then
                validado = True
            ElseIf text_ingresado = "59" Then
                validado = True
            ElseIf text_ingresado = "5A" Then
                validado = True
            ElseIf text_ingresado = "5B" Then
                validado = True
            ElseIf text_ingresado = "5C" Then
                validado = True
            ElseIf text_ingresado = "5D" Then
                validado = True
            ElseIf text_ingresado = "5E" Then
                validado = True
            ElseIf text_ingresado = "5F" Then
                validado = True
            ElseIf text_ingresado = "60" Then
                validado = True
            ElseIf text_ingresado = "61" Then
                validado = True
            ElseIf text_ingresado = "62" Then
                validado = True
            ElseIf text_ingresado = "63" Then
                validado = True
            ElseIf text_ingresado = "64" Then
                validado = True
            ElseIf text_ingresado = "65" Then
                validado = True
            ElseIf text_ingresado = "66" Then
                validado = True
            ElseIf text_ingresado = "67" Then
                validado = True
            ElseIf text_ingresado = "68" Then
                validado = True
            ElseIf text_ingresado = "69" Then
                validado = True
            ElseIf text_ingresado = "6A" Then
                validado = True
            ElseIf text_ingresado = "6B" Then
                validado = True
            ElseIf text_ingresado = "6C" Then
                validado = True
            ElseIf text_ingresado = "6D" Then
                validado = True
            ElseIf text_ingresado = "6E" Then
                validado = True
            ElseIf text_ingresado = "6F" Then
                validado = True
            ElseIf text_ingresado = "70" Then
                validado = True
            ElseIf text_ingresado = "71" Then
                validado = True
            ElseIf text_ingresado = "72" Then
                validado = True
            ElseIf text_ingresado = "73" Then
                validado = True
            ElseIf text_ingresado = "74" Then
                validado = True
            ElseIf text_ingresado = "75" Then
                validado = True
            ElseIf text_ingresado = "76" Then
                validado = True
            ElseIf text_ingresado = "77" Then
                validado = True
            ElseIf text_ingresado = "78" Then
                validado = True
            ElseIf text_ingresado = "79" Then
                validado = True
            ElseIf text_ingresado = "7A" Then
                validado = True
            ElseIf text_ingresado = "7B" Then
                validado = True
            ElseIf text_ingresado = "7C" Then
                validado = True
            ElseIf text_ingresado = "7D" Then
                validado = True
            ElseIf text_ingresado = "7E" Then
                validado = True
            ElseIf text_ingresado = "7F" Then
                validado = True
            ElseIf text_ingresado = "80" Then
                validado = True
            ElseIf text_ingresado = "81" Then
                validado = True
            ElseIf text_ingresado = "82" Then
                validado = True
            ElseIf text_ingresado = "83" Then
                validado = True
            ElseIf text_ingresado = "84" Then
                validado = True
            ElseIf text_ingresado = "85" Then
                validado = True
            ElseIf text_ingresado = "86" Then
                validado = True
            ElseIf text_ingresado = "87" Then
                validado = True
            ElseIf text_ingresado = "88" Then
                validado = True
            ElseIf text_ingresado = "89" Then
                validado = True
            ElseIf text_ingresado = "8A" Then
                validado = True
            ElseIf text_ingresado = "8B" Then
                validado = True
            ElseIf text_ingresado = "8C" Then
                validado = True
            ElseIf text_ingresado = "8D" Then
                validado = True
            ElseIf text_ingresado = "8E" Then
                validado = True
            ElseIf text_ingresado = "8F" Then
                validado = True
            ElseIf text_ingresado = "90" Then
                validado = True
            ElseIf text_ingresado = "91" Then
                validado = True
            ElseIf text_ingresado = "92" Then
                validado = True
            ElseIf text_ingresado = "93" Then
                validado = True
            ElseIf text_ingresado = "94" Then
                validado = True
            ElseIf text_ingresado = "95" Then
                validado = True
            ElseIf text_ingresado = "96" Then
                validado = True
            ElseIf text_ingresado = "97" Then
                validado = True
            ElseIf text_ingresado = "98" Then
                validado = True
            ElseIf text_ingresado = "99" Then
                validado = True
            ElseIf text_ingresado = "9A" Then
                validado = True
            ElseIf text_ingresado = "9B" Then
                validado = True
            ElseIf text_ingresado = "9C" Then
                validado = True
            ElseIf text_ingresado = "9D" Then
                validado = True
            ElseIf text_ingresado = "9E" Then
                validado = True
            ElseIf text_ingresado = "9F" Then
                validado = True
            ElseIf text_ingresado = "A0" Then
                validado = True
            ElseIf text_ingresado = "A1" Then
                validado = True
            ElseIf text_ingresado = "A2" Then
                validado = True
            ElseIf text_ingresado = "A3" Then
                validado = True
            ElseIf text_ingresado = "A4" Then
                validado = True
            ElseIf text_ingresado = "A5" Then
                validado = True
            ElseIf text_ingresado = "A6" Then
                validado = True
            ElseIf text_ingresado = "A7" Then
                validado = True
            ElseIf text_ingresado = "A8" Then
                validado = True
            ElseIf text_ingresado = "A9" Then
                validado = True
            ElseIf text_ingresado = "AA" Then
                validado = True
            ElseIf text_ingresado = "AB" Then
                validado = True
            ElseIf text_ingresado = "AC" Then
                validado = True
            ElseIf text_ingresado = "AD" Then
                validado = True
            ElseIf text_ingresado = "AE" Then
                validado = True
            ElseIf text_ingresado = "AF" Then
                validado = True
            ElseIf text_ingresado = "B0" Then
                validado = True
            ElseIf text_ingresado = "B1" Then
                validado = True
            ElseIf text_ingresado = "B2" Then
                validado = True
            ElseIf text_ingresado = "B3" Then
                validado = True
            ElseIf text_ingresado = "B4" Then
                validado = True
            ElseIf text_ingresado = "B5" Then
                validado = True
            ElseIf text_ingresado = "B6" Then
                validado = True
            ElseIf text_ingresado = "B7" Then
                validado = True
            ElseIf text_ingresado = "B8" Then
                validado = True
            ElseIf text_ingresado = "B9" Then
                validado = True
            ElseIf text_ingresado = "BA" Then
                validado = True
            ElseIf text_ingresado = "BB" Then
                validado = True
            ElseIf text_ingresado = "BC" Then
                validado = True
            ElseIf text_ingresado = "BD" Then
                validado = True
            ElseIf text_ingresado = "BE" Then
                validado = True
            ElseIf text_ingresado = "BF" Then
                validado = True
            ElseIf text_ingresado = "C0" Then
                validado = True
            ElseIf text_ingresado = "C1" Then
                validado = True
            ElseIf text_ingresado = "C2" Then
                validado = True
            ElseIf text_ingresado = "C3" Then
                validado = True
            ElseIf text_ingresado = "C4" Then
                validado = True
            ElseIf text_ingresado = "C5" Then
                validado = True
            ElseIf text_ingresado = "C6" Then
                validado = True
            ElseIf text_ingresado = "C7" Then
                validado = True
            ElseIf text_ingresado = "C8" Then
                validado = True
            ElseIf text_ingresado = "C9" Then
                validado = True
            ElseIf text_ingresado = "CA" Then
                validado = True
            ElseIf text_ingresado = "CB" Then
                validado = True
            ElseIf text_ingresado = "CC" Then
                validado = True
            ElseIf text_ingresado = "CD" Then
                validado = True
            ElseIf text_ingresado = "CE" Then
                validado = True
            ElseIf text_ingresado = "CF" Then
                validado = True
            ElseIf text_ingresado = "D0" Then
                validado = True
            ElseIf text_ingresado = "D1" Then
                validado = True
            ElseIf text_ingresado = "D2" Then
                validado = True
            ElseIf text_ingresado = "D3" Then
                validado = True
            ElseIf text_ingresado = "D4" Then
                validado = True
            ElseIf text_ingresado = "D5" Then
                validado = True
            ElseIf text_ingresado = "D6" Then
                validado = True
            ElseIf text_ingresado = "D7" Then
                validado = True
            ElseIf text_ingresado = "D8" Then
                validado = True
            ElseIf text_ingresado = "D9" Then
                validado = True
            ElseIf text_ingresado = "DA" Then
                validado = True
            ElseIf text_ingresado = "DB" Then
                validado = True
            ElseIf text_ingresado = "DC" Then
                validado = True
            ElseIf text_ingresado = "DD" Then
                validado = True
            ElseIf text_ingresado = "DE" Then
                validado = True
            ElseIf text_ingresado = "DF" Then
                validado = True
            ElseIf text_ingresado = "E0" Then
                validado = True
            ElseIf text_ingresado = "E1" Then
                validado = True
            ElseIf text_ingresado = "E2" Then
                validado = True
            ElseIf text_ingresado = "E3" Then
                validado = True
            ElseIf text_ingresado = "E4" Then
                validado = True
            ElseIf text_ingresado = "E5" Then
                validado = True
            ElseIf text_ingresado = "E6" Then
                validado = True
            ElseIf text_ingresado = "E7" Then
                validado = True
            ElseIf text_ingresado = "E8" Then
                validado = True
            ElseIf text_ingresado = "E9" Then
                validado = True
            ElseIf text_ingresado = "EA" Then
                validado = True
            ElseIf text_ingresado = "EB" Then
                validado = True
            ElseIf text_ingresado = "EC" Then
                validado = True
            ElseIf text_ingresado = "ED" Then
                validado = True
            ElseIf text_ingresado = "EE" Then
                validado = True
            ElseIf text_ingresado = "EF" Then
                validado = True
            ElseIf text_ingresado = "F0" Then
                validado = True
            ElseIf text_ingresado = "F1" Then
                validado = True
            ElseIf text_ingresado = "F2" Then
                validado = True
            ElseIf text_ingresado = "F3" Then
                validado = True
            ElseIf text_ingresado = "F4" Then
                validado = True
            ElseIf text_ingresado = "F5" Then
                validado = True
            ElseIf text_ingresado = "F6" Then
                validado = True
            ElseIf text_ingresado = "F7" Then
                validado = True
            ElseIf text_ingresado = "F8" Then
                validado = True
            ElseIf text_ingresado = "F9" Then
                validado = True
            ElseIf text_ingresado = "FA" Then
                validado = True
            ElseIf text_ingresado = "FB" Then
                validado = True
            ElseIf text_ingresado = "FC" Then
                validado = True
            ElseIf text_ingresado = "FD" Then
                validado = True
            ElseIf text_ingresado = "FE" Then
                validado = True
            ElseIf text_ingresado = "FF" Then
                validado = True
            End If
        End If
        Return validado
    End Function
    Private Sub txt_direcc_ip_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txt_direcc_ip.KeyPress
        If Char.IsDigit(e.KeyChar) Then
6:          e.Handled = False
7:      ElseIf Char.IsControl(e.KeyChar) Then
8:          e.Handled = False
9:      ElseIf Char.IsSeparator(e.KeyChar) Then
10:         e.Handled = False
11:     Else
12:         e.Handled = True
13:     End If
    End Sub
    Private Sub rad_agregar_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles rad_agregar.CheckedChanged
        nuevo = True
    End Sub
    Private Sub rad_modificar_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles rad_modificar.CheckedChanged
        nuevo = False
    End Sub
    Private Sub tip()
        ToolTip1.SetToolTip(cmb_estado, "1 = En Arriendo" & Chr(13) & "2 = Desocupado" & Chr(13) & "3 = En Mantención")
    End Sub
    Private Sub rad_consola_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles rad_consola.CheckedChanged
        mostrar_opciones()
        llamarDatos()
    End Sub
    Private Sub rad_computador_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles rad_computador.CheckedChanged
        mostrar_opciones()
        llamarDatos()
    End Sub
    Private Sub mostrar_opciones()
        If rad_consola.Checked Then 'si Consola
            txt_direcc_ip.Enabled = False
            TextBox11.Enabled = False
            TextBox12.Enabled = False
            TextBox13.Enabled = False
            TextBox14.Enabled = False
            TextBox15.Enabled = False
            TextBox16.Enabled = False

            num_consola.Enabled = True
            num_consola.Focus()
        Else    'si Computador
            txt_direcc_ip.Enabled = True
            TextBox11.Enabled = True
            TextBox12.Enabled = True
            TextBox13.Enabled = True
            TextBox14.Enabled = True
            TextBox15.Enabled = True
            TextBox16.Enabled = True
            num_consola.Enabled = False
            TextBox11.Focus()
        End If
    End Sub
    Private Sub TextBox11_GotFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles TextBox11.GotFocus
        TextBox11.SelectAll()
    End Sub
    Private Sub TextBox12_GotFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles TextBox11.GotFocus
        TextBox12.SelectAll()
    End Sub
    Private Sub TextBox13_GotFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles TextBox11.GotFocus
        TextBox13.SelectAll()
    End Sub
    Private Sub TextBox14_GotFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles TextBox11.GotFocus
        TextBox14.SelectAll()
    End Sub
    Private Sub TextBox15_GotFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles TextBox11.GotFocus
        TextBox15.SelectAll()
    End Sub
    Private Sub TextBox16_GotFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles TextBox11.GotFocus
        TextBox16.SelectAll()
    End Sub


    Private Sub TextBox1_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles TextBox1.KeyPress
        If Char.IsDigit(e.KeyChar) Then
6:          e.Handled = False
7:      ElseIf Char.IsControl(e.KeyChar) Then
8:          e.Handled = False
9:      ElseIf Char.IsSeparator(e.KeyChar) Then
10:         e.Handled = False
11:     Else
12:         e.Handled = True
13:     End If
    End Sub

    Private Sub TextBox2_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles TextBox2.KeyPress
        If Char.IsDigit(e.KeyChar) Then
6:          e.Handled = False
7:      ElseIf Char.IsControl(e.KeyChar) Then
8:          e.Handled = False
9:      ElseIf Char.IsSeparator(e.KeyChar) Then
10:         e.Handled = False
11:     Else
12:         e.Handled = True
13:     End If
    End Sub

    Private Sub TextBox3_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles TextBox3.KeyPress
        If Char.IsDigit(e.KeyChar) Then
6:          e.Handled = False
7:      ElseIf Char.IsControl(e.KeyChar) Then
8:          e.Handled = False
9:      ElseIf Char.IsSeparator(e.KeyChar) Then
10:         e.Handled = False
11:     Else
12:         e.Handled = True
13:     End If
    End Sub

    Private Sub TextBox4_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles TextBox4.KeyPress
        If Char.IsDigit(e.KeyChar) Then
6:          e.Handled = False
7:      ElseIf Char.IsControl(e.KeyChar) Then
8:          e.Handled = False
9:      ElseIf Char.IsSeparator(e.KeyChar) Then
10:         e.Handled = False
11:     Else
12:         e.Handled = True
13:     End If
    End Sub
    Private Sub limpiar()
        txt_direcc_ip.Text = ""
        TextBox11.Text = ""
        TextBox12.Text = ""
        TextBox13.Text = ""
        TextBox14.Text = ""
        TextBox15.Text = ""
        TextBox16.Text = ""
        num_consola.Value = 0
    End Sub

    Private Sub btn_limpiar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_limpiar.Click
        limpiar()
    End Sub

    Private Sub DataGridView1_CellContentClick(sender As System.Object, e As System.Windows.Forms.DataGridViewCellEventArgs) Handles DataGridView1.CellContentClick

    End Sub

    Private Sub gb_MAC_Enter(sender As System.Object, e As System.EventArgs) Handles gb_MAC.Enter

    End Sub

    Private Sub TextBox11_TextChanged(sender As System.Object, e As System.EventArgs) Handles TextBox11.TextChanged

    End Sub

    Private Sub Button2_Click(sender As System.Object, e As System.EventArgs) Handles Button2.Click
        txt_direcc_mac.Text = TextBox11.Text & TextBox12.Text & TextBox13.Text & TextBox14.Text & TextBox15.Text & TextBox16.Text
        If macValida(txt_direcc_mac.Text) Then
            MsgBox("valida")
        Else
            MsgBox("invalida")
        End If
    End Sub

End Class