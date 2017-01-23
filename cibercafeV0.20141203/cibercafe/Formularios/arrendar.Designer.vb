<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class arrendar
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
        Me.lbl_titulo = New System.Windows.Forms.Label()
        Me.lbl_tipo_equipo = New System.Windows.Forms.Label()
        Me.cmb_tipo_equipo = New System.Windows.Forms.ComboBox()
        Me.ComboBox1 = New System.Windows.Forms.ComboBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.btn_salir = New System.Windows.Forms.Button()
        Me.btn_arrendar = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'lbl_titulo
        '
        Me.lbl_titulo.AutoSize = True
        Me.lbl_titulo.Font = New System.Drawing.Font("Microsoft Sans Serif", 21.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_titulo.Location = New System.Drawing.Point(77, 9)
        Me.lbl_titulo.Name = "lbl_titulo"
        Me.lbl_titulo.Size = New System.Drawing.Size(278, 33)
        Me.lbl_titulo.TabIndex = 11
        Me.lbl_titulo.Text = "Arriendo de equipo"
        '
        'lbl_tipo_equipo
        '
        Me.lbl_tipo_equipo.AutoSize = True
        Me.lbl_tipo_equipo.Location = New System.Drawing.Point(107, 71)
        Me.lbl_tipo_equipo.Name = "lbl_tipo_equipo"
        Me.lbl_tipo_equipo.Size = New System.Drawing.Size(81, 13)
        Me.lbl_tipo_equipo.TabIndex = 12
        Me.lbl_tipo_equipo.Text = "Tipo de equipo:"
        '
        'cmb_tipo_equipo
        '
        Me.cmb_tipo_equipo.FormattingEnabled = True
        Me.cmb_tipo_equipo.Location = New System.Drawing.Point(194, 70)
        Me.cmb_tipo_equipo.Name = "cmb_tipo_equipo"
        Me.cmb_tipo_equipo.Size = New System.Drawing.Size(121, 21)
        Me.cmb_tipo_equipo.TabIndex = 13
        '
        'ComboBox1
        '
        Me.ComboBox1.FormattingEnabled = True
        Me.ComboBox1.Location = New System.Drawing.Point(194, 108)
        Me.ComboBox1.Name = "ComboBox1"
        Me.ComboBox1.Size = New System.Drawing.Size(121, 21)
        Me.ComboBox1.TabIndex = 15
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(107, 111)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(80, 13)
        Me.Label1.TabIndex = 14
        Me.Label1.Text = "Tiempo de uso:"
        '
        'btn_salir
        '
        Me.btn_salir.Location = New System.Drawing.Point(317, 198)
        Me.btn_salir.Name = "btn_salir"
        Me.btn_salir.Size = New System.Drawing.Size(52, 30)
        Me.btn_salir.TabIndex = 42
        Me.btn_salir.Text = "&Salir"
        Me.btn_salir.UseVisualStyleBackColor = True
        '
        'btn_arrendar
        '
        Me.btn_arrendar.Location = New System.Drawing.Point(161, 198)
        Me.btn_arrendar.Name = "btn_arrendar"
        Me.btn_arrendar.Size = New System.Drawing.Size(110, 30)
        Me.btn_arrendar.TabIndex = 41
        Me.btn_arrendar.Text = "&Arrendar"
        Me.btn_arrendar.UseVisualStyleBackColor = True
        '
        'arrendar
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(416, 247)
        Me.Controls.Add(Me.btn_salir)
        Me.Controls.Add(Me.btn_arrendar)
        Me.Controls.Add(Me.ComboBox1)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.cmb_tipo_equipo)
        Me.Controls.Add(Me.lbl_tipo_equipo)
        Me.Controls.Add(Me.lbl_titulo)
        Me.Name = "arrendar"
        Me.Text = "Form1"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents lbl_titulo As System.Windows.Forms.Label
    Friend WithEvents lbl_tipo_equipo As System.Windows.Forms.Label
    Friend WithEvents cmb_tipo_equipo As System.Windows.Forms.ComboBox
    Friend WithEvents ComboBox1 As System.Windows.Forms.ComboBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents btn_salir As System.Windows.Forms.Button
    Friend WithEvents btn_arrendar As System.Windows.Forms.Button
End Class
