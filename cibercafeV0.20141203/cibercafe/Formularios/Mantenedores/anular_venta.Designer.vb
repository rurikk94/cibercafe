<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class anular_venta
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
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.tbox_numero_boleta = New System.Windows.Forms.TextBox()
        Me.tbox_descripcion = New System.Windows.Forms.TextBox()
        Me.lst_boleta = New System.Windows.Forms.ListView()
        Me.btn_anular = New System.Windows.Forms.Button()
        Me.btn_cancelar = New System.Windows.Forms.Button()
        Me.lbl_version = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'lbl_titulo
        '
        Me.lbl_titulo.AutoSize = True
        Me.lbl_titulo.Font = New System.Drawing.Font("Arial Narrow", 27.75!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Underline), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_titulo.Location = New System.Drawing.Point(21, 9)
        Me.lbl_titulo.Name = "lbl_titulo"
        Me.lbl_titulo.Size = New System.Drawing.Size(207, 43)
        Me.lbl_titulo.TabIndex = 2
        Me.lbl_titulo.Text = "Anular Venta"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(29, 68)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(92, 13)
        Me.Label1.TabIndex = 3
        Me.Label1.Text = "Numero de Boleta"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(26, 197)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(128, 13)
        Me.Label2.TabIndex = 4
        Me.Label2.Text = "Descripcion de Anulación"
        '
        'tbox_numero_boleta
        '
        Me.tbox_numero_boleta.Location = New System.Drawing.Point(163, 68)
        Me.tbox_numero_boleta.Name = "tbox_numero_boleta"
        Me.tbox_numero_boleta.Size = New System.Drawing.Size(128, 20)
        Me.tbox_numero_boleta.TabIndex = 5
        '
        'tbox_descripcion
        '
        Me.tbox_descripcion.Location = New System.Drawing.Point(32, 213)
        Me.tbox_descripcion.Multiline = True
        Me.tbox_descripcion.Name = "tbox_descripcion"
        Me.tbox_descripcion.Size = New System.Drawing.Size(367, 73)
        Me.tbox_descripcion.TabIndex = 6
        '
        'lst_boleta
        '
        Me.lst_boleta.Location = New System.Drawing.Point(29, 97)
        Me.lst_boleta.Name = "lst_boleta"
        Me.lst_boleta.Size = New System.Drawing.Size(370, 97)
        Me.lst_boleta.TabIndex = 7
        Me.lst_boleta.UseCompatibleStateImageBehavior = False
        '
        'btn_anular
        '
        Me.btn_anular.Location = New System.Drawing.Point(241, 293)
        Me.btn_anular.Name = "btn_anular"
        Me.btn_anular.Size = New System.Drawing.Size(75, 23)
        Me.btn_anular.TabIndex = 8
        Me.btn_anular.Text = "&Anular"
        Me.btn_anular.UseVisualStyleBackColor = True
        '
        'btn_cancelar
        '
        Me.btn_cancelar.Location = New System.Drawing.Point(324, 293)
        Me.btn_cancelar.Name = "btn_cancelar"
        Me.btn_cancelar.Size = New System.Drawing.Size(75, 23)
        Me.btn_cancelar.TabIndex = 9
        Me.btn_cancelar.Text = "&Cancelar"
        Me.btn_cancelar.UseVisualStyleBackColor = True
        '
        'lbl_version
        '
        Me.lbl_version.AutoSize = True
        Me.lbl_version.Location = New System.Drawing.Point(324, 323)
        Me.lbl_version.Name = "lbl_version"
        Me.lbl_version.Size = New System.Drawing.Size(74, 13)
        Me.lbl_version.TabIndex = 10
        Me.lbl_version.Text = "V2014092014"
        '
        'anular_venta
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(428, 339)
        Me.Controls.Add(Me.lbl_version)
        Me.Controls.Add(Me.btn_cancelar)
        Me.Controls.Add(Me.btn_anular)
        Me.Controls.Add(Me.lst_boleta)
        Me.Controls.Add(Me.tbox_descripcion)
        Me.Controls.Add(Me.tbox_numero_boleta)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.lbl_titulo)
        Me.Name = "anular_venta"
        Me.Text = "Anular Venta"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents lbl_titulo As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents tbox_numero_boleta As System.Windows.Forms.TextBox
    Friend WithEvents tbox_descripcion As System.Windows.Forms.TextBox
    Friend WithEvents lst_boleta As System.Windows.Forms.ListView
    Friend WithEvents btn_anular As System.Windows.Forms.Button
    Friend WithEvents btn_cancelar As System.Windows.Forms.Button
    Friend WithEvents lbl_version As System.Windows.Forms.Label
End Class
