<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class mantenedor_equipos
    Inherits System.Windows.Forms.Form

    'Form reemplaza a Dispose para limpiar la lista de componentes.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Requerido por el Diseñador de Windows Forms
    Private components As System.ComponentModel.IContainer

    'NOTA: el Diseñador de Windows Forms necesita el siguiente procedimiento
    'Se puede modificar usando el Diseñador de Windows Forms.  
    'No lo modifique con el editor de código.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle4 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.lbl_titulo = New System.Windows.Forms.Label()
        Me.btn_salir = New System.Windows.Forms.Button()
        Me.lbl_estado = New System.Windows.Forms.Label()
        Me.txt_direcc_ip = New System.Windows.Forms.TextBox()
        Me.lbl_direcc_ip = New System.Windows.Forms.Label()
        Me.cmb_estado = New System.Windows.Forms.ComboBox()
        Me.lbl_nro_consola = New System.Windows.Forms.Label()
        Me.txt_direcc_mac = New System.Windows.Forms.TextBox()
        Me.rad_computador = New System.Windows.Forms.RadioButton()
        Me.rad_consola = New System.Windows.Forms.RadioButton()
        Me.btn_limpiar = New System.Windows.Forms.Button()
        Me.btn_eliminar = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.num_consola = New System.Windows.Forms.NumericUpDown()
        Me.lbl_version = New System.Windows.Forms.Label()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.rad_agregar = New System.Windows.Forms.RadioButton()
        Me.rad_modificar = New System.Windows.Forms.RadioButton()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.ToolTip1 = New System.Windows.Forms.ToolTip(Me.components)
        Me.TextBox11 = New System.Windows.Forms.TextBox()
        Me.TextBox12 = New System.Windows.Forms.TextBox()
        Me.TextBox13 = New System.Windows.Forms.TextBox()
        Me.TextBox14 = New System.Windows.Forms.TextBox()
        Me.TextBox15 = New System.Windows.Forms.TextBox()
        Me.TextBox16 = New System.Windows.Forms.TextBox()
        Me.gb_MAC = New System.Windows.Forms.GroupBox()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.TextBox2 = New System.Windows.Forms.TextBox()
        Me.TextBox3 = New System.Windows.Forms.TextBox()
        Me.TextBox4 = New System.Windows.Forms.TextBox()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.Button2 = New System.Windows.Forms.Button()
        CType(Me.num_consola, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.gb_MAC.SuspendLayout()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'lbl_titulo
        '
        Me.lbl_titulo.AutoSize = True
        Me.lbl_titulo.Font = New System.Drawing.Font("Microsoft Sans Serif", 21.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_titulo.Location = New System.Drawing.Point(70, 9)
        Me.lbl_titulo.Name = "lbl_titulo"
        Me.lbl_titulo.Size = New System.Drawing.Size(343, 33)
        Me.lbl_titulo.TabIndex = 27
        Me.lbl_titulo.Text = "Mantenedor de Equipos"
        Me.lbl_titulo.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'btn_salir
        '
        Me.btn_salir.Location = New System.Drawing.Point(298, 414)
        Me.btn_salir.Name = "btn_salir"
        Me.btn_salir.Size = New System.Drawing.Size(52, 30)
        Me.btn_salir.TabIndex = 40
        Me.btn_salir.Text = "&Salir"
        Me.btn_salir.UseVisualStyleBackColor = True
        '
        'lbl_estado
        '
        Me.lbl_estado.AutoSize = True
        Me.lbl_estado.Location = New System.Drawing.Point(401, 148)
        Me.lbl_estado.Name = "lbl_estado"
        Me.lbl_estado.Size = New System.Drawing.Size(43, 13)
        Me.lbl_estado.TabIndex = 37
        Me.lbl_estado.Text = "Estado:"
        '
        'txt_direcc_ip
        '
        Me.txt_direcc_ip.Location = New System.Drawing.Point(248, 168)
        Me.txt_direcc_ip.MaxLength = 12
        Me.txt_direcc_ip.Name = "txt_direcc_ip"
        Me.txt_direcc_ip.Size = New System.Drawing.Size(121, 20)
        Me.txt_direcc_ip.TabIndex = 31
        '
        'lbl_direcc_ip
        '
        Me.lbl_direcc_ip.AutoSize = True
        Me.lbl_direcc_ip.Location = New System.Drawing.Point(256, 148)
        Me.lbl_direcc_ip.Name = "lbl_direcc_ip"
        Me.lbl_direcc_ip.Size = New System.Drawing.Size(71, 13)
        Me.lbl_direcc_ip.TabIndex = 30
        Me.lbl_direcc_ip.Text = "Direccion IP: "
        '
        'cmb_estado
        '
        Me.cmb_estado.FormattingEnabled = True
        Me.cmb_estado.Items.AddRange(New Object() {"1", "2", "3"})
        Me.cmb_estado.Location = New System.Drawing.Point(403, 168)
        Me.cmb_estado.MaxLength = 1
        Me.cmb_estado.Name = "cmb_estado"
        Me.cmb_estado.Size = New System.Drawing.Size(33, 21)
        Me.cmb_estado.Sorted = True
        Me.cmb_estado.TabIndex = 38
        Me.cmb_estado.Text = "1"
        '
        'lbl_nro_consola
        '
        Me.lbl_nro_consola.AutoSize = True
        Me.lbl_nro_consola.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_nro_consola.Location = New System.Drawing.Point(213, 93)
        Me.lbl_nro_consola.Name = "lbl_nro_consola"
        Me.lbl_nro_consola.Size = New System.Drawing.Size(103, 13)
        Me.lbl_nro_consola.TabIndex = 32
        Me.lbl_nro_consola.Text = "Numero de Consola:"
        '
        'txt_direcc_mac
        '
        Me.txt_direcc_mac.Location = New System.Drawing.Point(58, 362)
        Me.txt_direcc_mac.MaxLength = 12
        Me.txt_direcc_mac.Name = "txt_direcc_mac"
        Me.txt_direcc_mac.Size = New System.Drawing.Size(121, 20)
        Me.txt_direcc_mac.TabIndex = 29
        Me.txt_direcc_mac.Visible = False
        '
        'rad_computador
        '
        Me.rad_computador.AutoSize = True
        Me.rad_computador.Location = New System.Drawing.Point(6, 19)
        Me.rad_computador.Name = "rad_computador"
        Me.rad_computador.Size = New System.Drawing.Size(82, 17)
        Me.rad_computador.TabIndex = 41
        Me.rad_computador.TabStop = True
        Me.rad_computador.Text = "Computador"
        Me.rad_computador.UseVisualStyleBackColor = True
        '
        'rad_consola
        '
        Me.rad_consola.AutoSize = True
        Me.rad_consola.Location = New System.Drawing.Point(6, 41)
        Me.rad_consola.Name = "rad_consola"
        Me.rad_consola.Size = New System.Drawing.Size(63, 17)
        Me.rad_consola.TabIndex = 42
        Me.rad_consola.TabStop = True
        Me.rad_consola.Text = "Consola"
        Me.rad_consola.UseVisualStyleBackColor = True
        '
        'btn_limpiar
        '
        Me.btn_limpiar.Location = New System.Drawing.Point(334, 111)
        Me.btn_limpiar.Name = "btn_limpiar"
        Me.btn_limpiar.Size = New System.Drawing.Size(94, 26)
        Me.btn_limpiar.TabIndex = 44
        Me.btn_limpiar.Text = "&Limpiar campos"
        Me.btn_limpiar.UseVisualStyleBackColor = True
        '
        'btn_eliminar
        '
        Me.btn_eliminar.Location = New System.Drawing.Point(98, 22)
        Me.btn_eliminar.Name = "btn_eliminar"
        Me.btn_eliminar.Size = New System.Drawing.Size(94, 26)
        Me.btn_eliminar.TabIndex = 45
        Me.btn_eliminar.Text = "&Eliminar"
        Me.btn_eliminar.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(106, 42)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(263, 25)
        Me.Label1.TabIndex = 47
        Me.Label1.Text = "Computador y Consolas"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'num_consola
        '
        Me.num_consola.Location = New System.Drawing.Point(233, 110)
        Me.num_consola.Maximum = New Decimal(New Integer() {4, 0, 0, 0})
        Me.num_consola.Name = "num_consola"
        Me.num_consola.Size = New System.Drawing.Size(61, 20)
        Me.num_consola.TabIndex = 48
        '
        'lbl_version
        '
        Me.lbl_version.BackColor = System.Drawing.SystemColors.Control
        Me.lbl_version.Location = New System.Drawing.Point(388, 433)
        Me.lbl_version.Name = "lbl_version"
        Me.lbl_version.Size = New System.Drawing.Size(56, 20)
        Me.lbl_version.TabIndex = 49
        Me.lbl_version.Text = "[version]"
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(259, 379)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(130, 26)
        Me.Button1.TabIndex = 51
        Me.Button1.Text = "&Guardar Cambios"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'rad_agregar
        '
        Me.rad_agregar.AutoSize = True
        Me.rad_agregar.Location = New System.Drawing.Point(14, 18)
        Me.rad_agregar.Name = "rad_agregar"
        Me.rad_agregar.Size = New System.Drawing.Size(62, 17)
        Me.rad_agregar.TabIndex = 52
        Me.rad_agregar.TabStop = True
        Me.rad_agregar.Text = "Agregar"
        Me.rad_agregar.UseVisualStyleBackColor = True
        '
        'rad_modificar
        '
        Me.rad_modificar.AutoSize = True
        Me.rad_modificar.Location = New System.Drawing.Point(14, 44)
        Me.rad_modificar.Name = "rad_modificar"
        Me.rad_modificar.Size = New System.Drawing.Size(68, 17)
        Me.rad_modificar.TabIndex = 53
        Me.rad_modificar.TabStop = True
        Me.rad_modificar.Text = "Modificar"
        Me.rad_modificar.UseVisualStyleBackColor = True
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.rad_modificar)
        Me.GroupBox1.Controls.Add(Me.rad_agregar)
        Me.GroupBox1.Controls.Add(Me.btn_eliminar)
        Me.GroupBox1.Location = New System.Drawing.Point(34, 370)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(209, 66)
        Me.GroupBox1.TabIndex = 54
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Opciones"
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.rad_computador)
        Me.GroupBox2.Controls.Add(Me.rad_consola)
        Me.GroupBox2.Location = New System.Drawing.Point(76, 75)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(99, 62)
        Me.GroupBox2.TabIndex = 55
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Tipo de Equipo"
        '
        'TextBox11
        '
        Me.TextBox11.Location = New System.Drawing.Point(6, 19)
        Me.TextBox11.MaxLength = 2
        Me.TextBox11.Name = "TextBox11"
        Me.TextBox11.Size = New System.Drawing.Size(21, 20)
        Me.TextBox11.TabIndex = 56
        '
        'TextBox12
        '
        Me.TextBox12.Location = New System.Drawing.Point(33, 19)
        Me.TextBox12.MaxLength = 2
        Me.TextBox12.Name = "TextBox12"
        Me.TextBox12.Size = New System.Drawing.Size(21, 20)
        Me.TextBox12.TabIndex = 57
        '
        'TextBox13
        '
        Me.TextBox13.Location = New System.Drawing.Point(58, 19)
        Me.TextBox13.MaxLength = 2
        Me.TextBox13.Name = "TextBox13"
        Me.TextBox13.Size = New System.Drawing.Size(21, 20)
        Me.TextBox13.TabIndex = 58
        '
        'TextBox14
        '
        Me.TextBox14.Location = New System.Drawing.Point(85, 19)
        Me.TextBox14.MaxLength = 2
        Me.TextBox14.Name = "TextBox14"
        Me.TextBox14.Size = New System.Drawing.Size(21, 20)
        Me.TextBox14.TabIndex = 59
        '
        'TextBox15
        '
        Me.TextBox15.Location = New System.Drawing.Point(112, 19)
        Me.TextBox15.MaxLength = 2
        Me.TextBox15.Name = "TextBox15"
        Me.TextBox15.Size = New System.Drawing.Size(21, 20)
        Me.TextBox15.TabIndex = 60
        '
        'TextBox16
        '
        Me.TextBox16.Location = New System.Drawing.Point(136, 19)
        Me.TextBox16.MaxLength = 2
        Me.TextBox16.Name = "TextBox16"
        Me.TextBox16.Size = New System.Drawing.Size(21, 20)
        Me.TextBox16.TabIndex = 61
        '
        'gb_MAC
        '
        Me.gb_MAC.Controls.Add(Me.TextBox11)
        Me.gb_MAC.Controls.Add(Me.TextBox12)
        Me.gb_MAC.Controls.Add(Me.TextBox16)
        Me.gb_MAC.Controls.Add(Me.TextBox13)
        Me.gb_MAC.Controls.Add(Me.TextBox15)
        Me.gb_MAC.Controls.Add(Me.TextBox14)
        Me.gb_MAC.Location = New System.Drawing.Point(46, 148)
        Me.gb_MAC.Name = "gb_MAC"
        Me.gb_MAC.Size = New System.Drawing.Size(164, 49)
        Me.gb_MAC.TabIndex = 56
        Me.gb_MAC.TabStop = False
        Me.gb_MAC.Text = "Direccion MAC: "
        '
        'TextBox1
        '
        Me.TextBox1.Location = New System.Drawing.Point(295, 362)
        Me.TextBox1.MaxLength = 3
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.TextBox1.Size = New System.Drawing.Size(35, 20)
        Me.TextBox1.TabIndex = 62
        Me.TextBox1.Visible = False
        '
        'TextBox2
        '
        Me.TextBox2.Location = New System.Drawing.Point(336, 362)
        Me.TextBox2.MaxLength = 3
        Me.TextBox2.Name = "TextBox2"
        Me.TextBox2.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.TextBox2.Size = New System.Drawing.Size(35, 20)
        Me.TextBox2.TabIndex = 63
        Me.TextBox2.Visible = False
        '
        'TextBox3
        '
        Me.TextBox3.Location = New System.Drawing.Point(377, 362)
        Me.TextBox3.MaxLength = 3
        Me.TextBox3.Name = "TextBox3"
        Me.TextBox3.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.TextBox3.Size = New System.Drawing.Size(35, 20)
        Me.TextBox3.TabIndex = 64
        Me.TextBox3.Visible = False
        '
        'TextBox4
        '
        Me.TextBox4.Location = New System.Drawing.Point(418, 362)
        Me.TextBox4.MaxLength = 3
        Me.TextBox4.Name = "TextBox4"
        Me.TextBox4.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.TextBox4.Size = New System.Drawing.Size(35, 20)
        Me.TextBox4.TabIndex = 65
        Me.TextBox4.Visible = False
        '
        'DataGridView1
        '
        DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle3.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.DataGridView1.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle3
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        DataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle4.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.DataGridView1.DefaultCellStyle = DataGridViewCellStyle4
        Me.DataGridView1.Location = New System.Drawing.Point(34, 203)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.Size = New System.Drawing.Size(409, 161)
        Me.DataGridView1.TabIndex = 50
        '
        'Button2
        '
        Me.Button2.Location = New System.Drawing.Point(391, 63)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(75, 23)
        Me.Button2.TabIndex = 66
        Me.Button2.Text = "Button2"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'mantenedor_equipos
        '
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None
        Me.ClientSize = New System.Drawing.Size(484, 462)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.TextBox4)
        Me.Controls.Add(Me.TextBox3)
        Me.Controls.Add(Me.TextBox2)
        Me.Controls.Add(Me.TextBox1)
        Me.Controls.Add(Me.txt_direcc_mac)
        Me.Controls.Add(Me.gb_MAC)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.lbl_version)
        Me.Controls.Add(Me.num_consola)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.btn_limpiar)
        Me.Controls.Add(Me.btn_salir)
        Me.Controls.Add(Me.cmb_estado)
        Me.Controls.Add(Me.lbl_estado)
        Me.Controls.Add(Me.lbl_nro_consola)
        Me.Controls.Add(Me.txt_direcc_ip)
        Me.Controls.Add(Me.lbl_direcc_ip)
        Me.Controls.Add(Me.lbl_titulo)
        Me.Controls.Add(Me.DataGridView1)
        Me.MaximumSize = New System.Drawing.Size(500, 500)
        Me.MinimumSize = New System.Drawing.Size(500, 500)
        Me.Name = "mantenedor_equipos"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Mantener equipos del cibercafe"
        CType(Me.num_consola, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.gb_MAC.ResumeLayout(False)
        Me.gb_MAC.PerformLayout()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents lbl_titulo As System.Windows.Forms.Label
    Friend WithEvents btn_salir As System.Windows.Forms.Button
    Friend WithEvents lbl_estado As System.Windows.Forms.Label
    Friend WithEvents txt_direcc_ip As System.Windows.Forms.TextBox
    Friend WithEvents lbl_direcc_ip As System.Windows.Forms.Label
    Friend WithEvents cmb_estado As System.Windows.Forms.ComboBox
    Friend WithEvents lbl_nro_consola As System.Windows.Forms.Label
    Friend WithEvents txt_direcc_mac As System.Windows.Forms.TextBox
    Friend WithEvents rad_computador As System.Windows.Forms.RadioButton
    Friend WithEvents rad_consola As System.Windows.Forms.RadioButton
    Friend WithEvents btn_limpiar As System.Windows.Forms.Button
    Friend WithEvents btn_eliminar As System.Windows.Forms.Button
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents num_consola As System.Windows.Forms.NumericUpDown
    Friend WithEvents lbl_version As System.Windows.Forms.Label
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents rad_agregar As System.Windows.Forms.RadioButton
    Friend WithEvents rad_modificar As System.Windows.Forms.RadioButton
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents ToolTip1 As System.Windows.Forms.ToolTip
    Friend WithEvents TextBox11 As System.Windows.Forms.TextBox
    Friend WithEvents TextBox12 As System.Windows.Forms.TextBox
    Friend WithEvents TextBox13 As System.Windows.Forms.TextBox
    Friend WithEvents TextBox14 As System.Windows.Forms.TextBox
    Friend WithEvents TextBox15 As System.Windows.Forms.TextBox
    Friend WithEvents TextBox16 As System.Windows.Forms.TextBox
    Friend WithEvents gb_MAC As System.Windows.Forms.GroupBox
    Friend WithEvents TextBox1 As System.Windows.Forms.TextBox
    Friend WithEvents TextBox2 As System.Windows.Forms.TextBox
    Friend WithEvents TextBox3 As System.Windows.Forms.TextBox
    Friend WithEvents TextBox4 As System.Windows.Forms.TextBox
    Friend WithEvents DataGridView1 As System.Windows.Forms.DataGridView
    Friend WithEvents Button2 As System.Windows.Forms.Button
End Class
