<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class mantenedor_trabajadores
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
        Me.Label3 = New System.Windows.Forms.Label()
        Me.btn_eliminar = New System.Windows.Forms.Button()
        Me.btn_salir = New System.Windows.Forms.Button()
        Me.btn_modificar = New System.Windows.Forms.Button()
        Me.btn_agregar = New System.Windows.Forms.Button()
        Me.lbl_version = New System.Windows.Forms.Label()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.lbl_accion = New System.Windows.Forms.Label()
        Me.lbl_interplay = New System.Windows.Forms.Label()
        Me.lbl_reingrese_pass = New System.Windows.Forms.Label()
        Me.lbl_pass = New System.Windows.Forms.Label()
        Me.txt_nombre = New System.Windows.Forms.TextBox()
        Me.lbl_apellido = New System.Windows.Forms.Label()
        Me.txt_apellido = New System.Windows.Forms.TextBox()
        Me.lbl_nombre = New System.Windows.Forms.Label()
        Me.txt_pass = New System.Windows.Forms.TextBox()
        Me.txt_reingrese_pass = New System.Windows.Forms.TextBox()
        Me.txt_rut = New System.Windows.Forms.TextBox()
        Me.txt_dv = New System.Windows.Forms.TextBox()
        Me.lbl_rut = New System.Windows.Forms.Label()
        Me.txt_fono = New System.Windows.Forms.TextBox()
        Me.lbl_fono = New System.Windows.Forms.Label()
        Me.lbl_estado = New System.Windows.Forms.Label()
        Me.btn_cancelar = New System.Windows.Forms.Button()
        Me.btn_aceptar = New System.Windows.Forms.Button()
        Me.chk_estado = New System.Windows.Forms.CheckBox()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 21.75!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Underline), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(91, 18)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(372, 33)
        Me.Label3.TabIndex = 21
        Me.Label3.Text = "Mantenedor Trabajadores"
        '
        'btn_eliminar
        '
        Me.btn_eliminar.Location = New System.Drawing.Point(453, 181)
        Me.btn_eliminar.Name = "btn_eliminar"
        Me.btn_eliminar.Size = New System.Drawing.Size(65, 27)
        Me.btn_eliminar.TabIndex = 22
        Me.btn_eliminar.Text = "Eliminar"
        Me.btn_eliminar.UseVisualStyleBackColor = True
        '
        'btn_salir
        '
        Me.btn_salir.Location = New System.Drawing.Point(463, 415)
        Me.btn_salir.Name = "btn_salir"
        Me.btn_salir.Size = New System.Drawing.Size(75, 36)
        Me.btn_salir.TabIndex = 70
        Me.btn_salir.Text = "Salir"
        Me.btn_salir.UseVisualStyleBackColor = True
        '
        'btn_modificar
        '
        Me.btn_modificar.Location = New System.Drawing.Point(453, 128)
        Me.btn_modificar.Name = "btn_modificar"
        Me.btn_modificar.Size = New System.Drawing.Size(65, 29)
        Me.btn_modificar.TabIndex = 21
        Me.btn_modificar.Text = "Modificar"
        Me.btn_modificar.UseVisualStyleBackColor = True
        '
        'btn_agregar
        '
        Me.btn_agregar.Location = New System.Drawing.Point(453, 81)
        Me.btn_agregar.Name = "btn_agregar"
        Me.btn_agregar.Size = New System.Drawing.Size(65, 28)
        Me.btn_agregar.TabIndex = 20
        Me.btn_agregar.Text = "Agregar"
        Me.btn_agregar.UseVisualStyleBackColor = True
        '
        'lbl_version
        '
        Me.lbl_version.AutoSize = True
        Me.lbl_version.Location = New System.Drawing.Point(487, 9)
        Me.lbl_version.Name = "lbl_version"
        Me.lbl_version.Size = New System.Drawing.Size(62, 13)
        Me.lbl_version.TabIndex = 55
        Me.lbl_version.Text = "V20140921"
        '
        'DataGridView1
        '
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Location = New System.Drawing.Point(45, 81)
        Me.DataGridView1.MultiSelect = False
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.Size = New System.Drawing.Size(309, 127)
        Me.DataGridView1.StandardTab = True
        Me.DataGridView1.TabIndex = 100
        '
        'lbl_accion
        '
        Me.lbl_accion.AutoSize = True
        Me.lbl_accion.Font = New System.Drawing.Font("Modern No. 20", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_accion.Location = New System.Drawing.Point(375, 81)
        Me.lbl_accion.Name = "lbl_accion"
        Me.lbl_accion.Size = New System.Drawing.Size(72, 24)
        Me.lbl_accion.TabIndex = 67
        Me.lbl_accion.Text = "Acción:"
        '
        'lbl_interplay
        '
        Me.lbl_interplay.AutoSize = True
        Me.lbl_interplay.Font = New System.Drawing.Font("Mistral", 48.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_interplay.Location = New System.Drawing.Point(84, 274)
        Me.lbl_interplay.Name = "lbl_interplay"
        Me.lbl_interplay.Size = New System.Drawing.Size(424, 76)
        Me.lbl_interplay.TabIndex = 68
        Me.lbl_interplay.Text = "Cibercafe InterPlay"
        '
        'lbl_reingrese_pass
        '
        Me.lbl_reingrese_pass.AutoSize = True
        Me.lbl_reingrese_pass.Location = New System.Drawing.Point(6, 120)
        Me.lbl_reingrese_pass.Name = "lbl_reingrese_pass"
        Me.lbl_reingrese_pass.Size = New System.Drawing.Size(104, 13)
        Me.lbl_reingrese_pass.TabIndex = 40
        Me.lbl_reingrese_pass.Text = "Reingrese Password"
        '
        'lbl_pass
        '
        Me.lbl_pass.AutoSize = True
        Me.lbl_pass.Location = New System.Drawing.Point(6, 94)
        Me.lbl_pass.Name = "lbl_pass"
        Me.lbl_pass.Size = New System.Drawing.Size(53, 13)
        Me.lbl_pass.TabIndex = 39
        Me.lbl_pass.Text = "Password"
        '
        'txt_nombre
        '
        Me.txt_nombre.Location = New System.Drawing.Point(127, 38)
        Me.txt_nombre.MaxLength = 30
        Me.txt_nombre.Name = "txt_nombre"
        Me.txt_nombre.Size = New System.Drawing.Size(116, 20)
        Me.txt_nombre.TabIndex = 42
        '
        'lbl_apellido
        '
        Me.lbl_apellido.AutoSize = True
        Me.lbl_apellido.Location = New System.Drawing.Point(6, 68)
        Me.lbl_apellido.Name = "lbl_apellido"
        Me.lbl_apellido.Size = New System.Drawing.Size(44, 13)
        Me.lbl_apellido.TabIndex = 38
        Me.lbl_apellido.Text = "Apellido"
        '
        'txt_apellido
        '
        Me.txt_apellido.Location = New System.Drawing.Point(127, 64)
        Me.txt_apellido.MaxLength = 30
        Me.txt_apellido.Name = "txt_apellido"
        Me.txt_apellido.Size = New System.Drawing.Size(116, 20)
        Me.txt_apellido.TabIndex = 43
        '
        'lbl_nombre
        '
        Me.lbl_nombre.AutoSize = True
        Me.lbl_nombre.Location = New System.Drawing.Point(6, 42)
        Me.lbl_nombre.Name = "lbl_nombre"
        Me.lbl_nombre.Size = New System.Drawing.Size(44, 13)
        Me.lbl_nombre.TabIndex = 37
        Me.lbl_nombre.Text = "Nombre"
        '
        'txt_pass
        '
        Me.txt_pass.Location = New System.Drawing.Point(127, 90)
        Me.txt_pass.MaxLength = 15
        Me.txt_pass.Name = "txt_pass"
        Me.txt_pass.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.txt_pass.Size = New System.Drawing.Size(116, 20)
        Me.txt_pass.TabIndex = 44
        '
        'txt_reingrese_pass
        '
        Me.txt_reingrese_pass.Location = New System.Drawing.Point(127, 116)
        Me.txt_reingrese_pass.MaxLength = 15
        Me.txt_reingrese_pass.Name = "txt_reingrese_pass"
        Me.txt_reingrese_pass.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.txt_reingrese_pass.Size = New System.Drawing.Size(116, 20)
        Me.txt_reingrese_pass.TabIndex = 45
        '
        'txt_rut
        '
        Me.txt_rut.Location = New System.Drawing.Point(127, 12)
        Me.txt_rut.MaxLength = 8
        Me.txt_rut.Name = "txt_rut"
        Me.txt_rut.Size = New System.Drawing.Size(80, 20)
        Me.txt_rut.TabIndex = 38
        '
        'txt_dv
        '
        Me.txt_dv.Location = New System.Drawing.Point(213, 12)
        Me.txt_dv.MaxLength = 1
        Me.txt_dv.Name = "txt_dv"
        Me.txt_dv.Size = New System.Drawing.Size(30, 20)
        Me.txt_dv.TabIndex = 39
        '
        'lbl_rut
        '
        Me.lbl_rut.AutoSize = True
        Me.lbl_rut.Location = New System.Drawing.Point(6, 16)
        Me.lbl_rut.Name = "lbl_rut"
        Me.lbl_rut.Size = New System.Drawing.Size(30, 13)
        Me.lbl_rut.TabIndex = 48
        Me.lbl_rut.Text = "RUT"
        '
        'txt_fono
        '
        Me.txt_fono.Location = New System.Drawing.Point(127, 143)
        Me.txt_fono.Name = "txt_fono"
        Me.txt_fono.Size = New System.Drawing.Size(116, 20)
        Me.txt_fono.TabIndex = 50
        '
        'lbl_fono
        '
        Me.lbl_fono.AutoSize = True
        Me.lbl_fono.Location = New System.Drawing.Point(6, 147)
        Me.lbl_fono.Name = "lbl_fono"
        Me.lbl_fono.Size = New System.Drawing.Size(31, 13)
        Me.lbl_fono.TabIndex = 49
        Me.lbl_fono.Text = "Fono"
        '
        'lbl_estado
        '
        Me.lbl_estado.AutoSize = True
        Me.lbl_estado.Location = New System.Drawing.Point(6, 171)
        Me.lbl_estado.Name = "lbl_estado"
        Me.lbl_estado.Size = New System.Drawing.Size(40, 13)
        Me.lbl_estado.TabIndex = 51
        Me.lbl_estado.Text = "Estado"
        '
        'btn_cancelar
        '
        Me.btn_cancelar.Location = New System.Drawing.Point(286, 23)
        Me.btn_cancelar.Name = "btn_cancelar"
        Me.btn_cancelar.Size = New System.Drawing.Size(75, 32)
        Me.btn_cancelar.TabIndex = 37
        Me.btn_cancelar.Text = "Cancelar"
        Me.btn_cancelar.UseVisualStyleBackColor = True
        '
        'btn_aceptar
        '
        Me.btn_aceptar.Location = New System.Drawing.Point(286, 87)
        Me.btn_aceptar.Name = "btn_aceptar"
        Me.btn_aceptar.Size = New System.Drawing.Size(75, 32)
        Me.btn_aceptar.TabIndex = 36
        Me.btn_aceptar.Text = "Aceptar"
        Me.btn_aceptar.UseVisualStyleBackColor = True
        '
        'chk_estado
        '
        Me.chk_estado.AutoSize = True
        Me.chk_estado.Location = New System.Drawing.Point(127, 173)
        Me.chk_estado.Name = "chk_estado"
        Me.chk_estado.Size = New System.Drawing.Size(56, 17)
        Me.chk_estado.TabIndex = 67
        Me.chk_estado.Text = "Activo"
        Me.chk_estado.UseVisualStyleBackColor = True
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.chk_estado)
        Me.GroupBox1.Controls.Add(Me.btn_aceptar)
        Me.GroupBox1.Controls.Add(Me.btn_cancelar)
        Me.GroupBox1.Controls.Add(Me.lbl_estado)
        Me.GroupBox1.Controls.Add(Me.lbl_fono)
        Me.GroupBox1.Controls.Add(Me.txt_fono)
        Me.GroupBox1.Controls.Add(Me.lbl_rut)
        Me.GroupBox1.Controls.Add(Me.txt_dv)
        Me.GroupBox1.Controls.Add(Me.txt_rut)
        Me.GroupBox1.Controls.Add(Me.txt_reingrese_pass)
        Me.GroupBox1.Controls.Add(Me.txt_pass)
        Me.GroupBox1.Controls.Add(Me.lbl_nombre)
        Me.GroupBox1.Controls.Add(Me.txt_apellido)
        Me.GroupBox1.Controls.Add(Me.lbl_apellido)
        Me.GroupBox1.Controls.Add(Me.txt_nombre)
        Me.GroupBox1.Controls.Add(Me.lbl_pass)
        Me.GroupBox1.Controls.Add(Me.lbl_reingrese_pass)
        Me.GroupBox1.Location = New System.Drawing.Point(45, 240)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(378, 200)
        Me.GroupBox1.TabIndex = 35
        Me.GroupBox1.TabStop = False
        '
        'mantenedor_trabajadores
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(561, 477)
        Me.Controls.Add(Me.lbl_accion)
        Me.Controls.Add(Me.DataGridView1)
        Me.Controls.Add(Me.btn_eliminar)
        Me.Controls.Add(Me.btn_salir)
        Me.Controls.Add(Me.lbl_version)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.btn_modificar)
        Me.Controls.Add(Me.btn_agregar)
        Me.Controls.Add(Me.lbl_interplay)
        Me.Name = "mantenedor_trabajadores"
        Me.Text = "mantenedor_trabajadores"
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents btn_salir As System.Windows.Forms.Button
    Friend WithEvents lbl_version As System.Windows.Forms.Label
    Friend WithEvents btn_eliminar As System.Windows.Forms.Button
    Friend WithEvents btn_modificar As System.Windows.Forms.Button
    Friend WithEvents btn_agregar As System.Windows.Forms.Button
    Friend WithEvents DataGridView1 As System.Windows.Forms.DataGridView
    Friend WithEvents lbl_accion As System.Windows.Forms.Label
    Friend WithEvents lbl_interplay As System.Windows.Forms.Label
    Friend WithEvents lbl_reingrese_pass As System.Windows.Forms.Label
    Friend WithEvents lbl_pass As System.Windows.Forms.Label
    Friend WithEvents txt_nombre As System.Windows.Forms.TextBox
    Friend WithEvents lbl_apellido As System.Windows.Forms.Label
    Friend WithEvents txt_apellido As System.Windows.Forms.TextBox
    Friend WithEvents lbl_nombre As System.Windows.Forms.Label
    Friend WithEvents txt_pass As System.Windows.Forms.TextBox
    Friend WithEvents txt_reingrese_pass As System.Windows.Forms.TextBox
    Friend WithEvents txt_rut As System.Windows.Forms.TextBox
    Friend WithEvents txt_dv As System.Windows.Forms.TextBox
    Friend WithEvents lbl_rut As System.Windows.Forms.Label
    Friend WithEvents txt_fono As System.Windows.Forms.TextBox
    Friend WithEvents lbl_fono As System.Windows.Forms.Label
    Friend WithEvents lbl_estado As System.Windows.Forms.Label
    Friend WithEvents btn_cancelar As System.Windows.Forms.Button
    Friend WithEvents btn_aceptar As System.Windows.Forms.Button
    Friend WithEvents chk_estado As System.Windows.Forms.CheckBox
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
End Class
