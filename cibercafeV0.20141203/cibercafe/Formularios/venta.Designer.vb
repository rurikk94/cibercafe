<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class venta
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
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.lbl_codigo = New System.Windows.Forms.Label()
        Me.btn_borrarLista = New System.Windows.Forms.Button()
        Me.lbl_total = New System.Windows.Forms.Label()
        Me.tbox_total = New System.Windows.Forms.TextBox()
        Me.lbl_subtotal = New System.Windows.Forms.Label()
        Me.tbox_subtotal = New System.Windows.Forms.TextBox()
        Me.btn_cancelar = New System.Windows.Forms.Button()
        Me.lbl_precio = New System.Windows.Forms.Label()
        Me.tbox_precio = New System.Windows.Forms.TextBox()
        Me.cbox_productos = New System.Windows.Forms.ComboBox()
        Me.lbl_cantidad = New System.Windows.Forms.Label()
        Me.lbl_producto = New System.Windows.Forms.Label()
        Me.tbox_cantidad = New System.Windows.Forms.TextBox()
        Me.btn_vender = New System.Windows.Forms.Button()
        Me.lst_carrito = New System.Windows.Forms.ListBox()
        Me.txt_producto = New System.Windows.Forms.TextBox()
        Me.lbl_titulo = New System.Windows.Forms.Label()
        Me.lbl_version = New System.Windows.Forms.Label()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.Button2)
        Me.GroupBox1.Controls.Add(Me.Button1)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Controls.Add(Me.lbl_codigo)
        Me.GroupBox1.Controls.Add(Me.btn_borrarLista)
        Me.GroupBox1.Controls.Add(Me.lbl_total)
        Me.GroupBox1.Controls.Add(Me.tbox_total)
        Me.GroupBox1.Controls.Add(Me.lbl_subtotal)
        Me.GroupBox1.Controls.Add(Me.tbox_subtotal)
        Me.GroupBox1.Controls.Add(Me.btn_cancelar)
        Me.GroupBox1.Controls.Add(Me.lbl_precio)
        Me.GroupBox1.Controls.Add(Me.tbox_precio)
        Me.GroupBox1.Controls.Add(Me.cbox_productos)
        Me.GroupBox1.Controls.Add(Me.lbl_cantidad)
        Me.GroupBox1.Controls.Add(Me.lbl_producto)
        Me.GroupBox1.Controls.Add(Me.tbox_cantidad)
        Me.GroupBox1.Controls.Add(Me.btn_vender)
        Me.GroupBox1.Controls.Add(Me.lst_carrito)
        Me.GroupBox1.Controls.Add(Me.txt_producto)
        Me.GroupBox1.Location = New System.Drawing.Point(12, 116)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(742, 381)
        Me.GroupBox1.TabIndex = 0
        Me.GroupBox1.TabStop = False
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(610, 87)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(46, 13)
        Me.Label4.TabIndex = 19
        Me.Label4.Text = "Subtotal"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(443, 87)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(37, 13)
        Me.Label3.TabIndex = 18
        Me.Label3.Text = "Precio"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(314, 87)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(49, 13)
        Me.Label2.TabIndex = 17
        Me.Label2.Text = "Cantidad"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(131, 90)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(50, 13)
        Me.Label1.TabIndex = 16
        Me.Label1.Text = "Producto"
        '
        'lbl_codigo
        '
        Me.lbl_codigo.AutoSize = True
        Me.lbl_codigo.Location = New System.Drawing.Point(6, 87)
        Me.lbl_codigo.Name = "lbl_codigo"
        Me.lbl_codigo.Size = New System.Drawing.Size(40, 13)
        Me.lbl_codigo.TabIndex = 15
        Me.lbl_codigo.Text = "Codigo"
        '
        'btn_borrarLista
        '
        Me.btn_borrarLista.Location = New System.Drawing.Point(6, 268)
        Me.btn_borrarLista.Name = "btn_borrarLista"
        Me.btn_borrarLista.Size = New System.Drawing.Size(92, 23)
        Me.btn_borrarLista.TabIndex = 14
        Me.btn_borrarLista.Text = "&Borrar Lista"
        Me.btn_borrarLista.UseVisualStyleBackColor = True
        '
        'lbl_total
        '
        Me.lbl_total.AutoSize = True
        Me.lbl_total.Location = New System.Drawing.Point(569, 317)
        Me.lbl_total.Name = "lbl_total"
        Me.lbl_total.Size = New System.Drawing.Size(31, 13)
        Me.lbl_total.TabIndex = 13
        Me.lbl_total.Text = "Total"
        '
        'tbox_total
        '
        Me.tbox_total.Location = New System.Drawing.Point(631, 310)
        Me.tbox_total.Name = "tbox_total"
        Me.tbox_total.Size = New System.Drawing.Size(100, 20)
        Me.tbox_total.TabIndex = 12
        '
        'lbl_subtotal
        '
        Me.lbl_subtotal.AutoSize = True
        Me.lbl_subtotal.Location = New System.Drawing.Point(569, 279)
        Me.lbl_subtotal.Name = "lbl_subtotal"
        Me.lbl_subtotal.Size = New System.Drawing.Size(46, 13)
        Me.lbl_subtotal.TabIndex = 11
        Me.lbl_subtotal.Text = "Subtotal"
        '
        'tbox_subtotal
        '
        Me.tbox_subtotal.Location = New System.Drawing.Point(631, 272)
        Me.tbox_subtotal.Name = "tbox_subtotal"
        Me.tbox_subtotal.Size = New System.Drawing.Size(100, 20)
        Me.tbox_subtotal.TabIndex = 10
        '
        'btn_cancelar
        '
        Me.btn_cancelar.Location = New System.Drawing.Point(656, 347)
        Me.btn_cancelar.Name = "btn_cancelar"
        Me.btn_cancelar.Size = New System.Drawing.Size(75, 23)
        Me.btn_cancelar.TabIndex = 9
        Me.btn_cancelar.Text = "&Cancelar"
        Me.btn_cancelar.UseVisualStyleBackColor = True
        '
        'lbl_precio
        '
        Me.lbl_precio.AutoSize = True
        Me.lbl_precio.Location = New System.Drawing.Point(443, 15)
        Me.lbl_precio.Name = "lbl_precio"
        Me.lbl_precio.Size = New System.Drawing.Size(74, 13)
        Me.lbl_precio.TabIndex = 8
        Me.lbl_precio.Text = "Precio Unidad"
        '
        'tbox_precio
        '
        Me.tbox_precio.Location = New System.Drawing.Point(437, 31)
        Me.tbox_precio.Name = "tbox_precio"
        Me.tbox_precio.Size = New System.Drawing.Size(100, 20)
        Me.tbox_precio.TabIndex = 7
        '
        'cbox_productos
        '
        Me.cbox_productos.FormattingEnabled = True
        Me.cbox_productos.Location = New System.Drawing.Point(6, 31)
        Me.cbox_productos.Name = "cbox_productos"
        Me.cbox_productos.Size = New System.Drawing.Size(165, 21)
        Me.cbox_productos.TabIndex = 6
        '
        'lbl_cantidad
        '
        Me.lbl_cantidad.AutoSize = True
        Me.lbl_cantidad.Location = New System.Drawing.Point(340, 15)
        Me.lbl_cantidad.Name = "lbl_cantidad"
        Me.lbl_cantidad.Size = New System.Drawing.Size(49, 13)
        Me.lbl_cantidad.TabIndex = 5
        Me.lbl_cantidad.Text = "Cantidad"
        '
        'lbl_producto
        '
        Me.lbl_producto.AutoSize = True
        Me.lbl_producto.Location = New System.Drawing.Point(48, 9)
        Me.lbl_producto.Name = "lbl_producto"
        Me.lbl_producto.Size = New System.Drawing.Size(50, 13)
        Me.lbl_producto.TabIndex = 4
        Me.lbl_producto.Text = "Producto"
        '
        'tbox_cantidad
        '
        Me.tbox_cantidad.Location = New System.Drawing.Point(317, 31)
        Me.tbox_cantidad.Name = "tbox_cantidad"
        Me.tbox_cantidad.Size = New System.Drawing.Size(100, 20)
        Me.tbox_cantidad.TabIndex = 3
        '
        'btn_vender
        '
        Me.btn_vender.Location = New System.Drawing.Point(558, 347)
        Me.btn_vender.Name = "btn_vender"
        Me.btn_vender.Size = New System.Drawing.Size(75, 23)
        Me.btn_vender.TabIndex = 2
        Me.btn_vender.Text = "&Vender"
        Me.btn_vender.UseVisualStyleBackColor = True
        '
        'lst_carrito
        '
        Me.lst_carrito.FormattingEnabled = True
        Me.lst_carrito.Location = New System.Drawing.Point(6, 106)
        Me.lst_carrito.Name = "lst_carrito"
        Me.lst_carrito.Size = New System.Drawing.Size(725, 160)
        Me.lst_carrito.TabIndex = 1
        '
        'txt_producto
        '
        Me.txt_producto.Location = New System.Drawing.Point(187, 31)
        Me.txt_producto.Name = "txt_producto"
        Me.txt_producto.Size = New System.Drawing.Size(100, 20)
        Me.txt_producto.TabIndex = 0
        '
        'lbl_titulo
        '
        Me.lbl_titulo.AutoSize = True
        Me.lbl_titulo.Font = New System.Drawing.Font("Arial Narrow", 27.75!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Underline), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_titulo.Location = New System.Drawing.Point(243, 37)
        Me.lbl_titulo.Name = "lbl_titulo"
        Me.lbl_titulo.Size = New System.Drawing.Size(306, 43)
        Me.lbl_titulo.TabIndex = 1
        Me.lbl_titulo.Text = "Venta de Productos"
        '
        'lbl_version
        '
        Me.lbl_version.AutoSize = True
        Me.lbl_version.Location = New System.Drawing.Point(692, 504)
        Me.lbl_version.Name = "lbl_version"
        Me.lbl_version.Size = New System.Drawing.Size(62, 13)
        Me.lbl_version.TabIndex = 2
        Me.lbl_version.Text = "V20140921"
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(572, 28)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(75, 23)
        Me.Button1.TabIndex = 20
        Me.Button1.Text = "&Agregar"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Button2
        '
        Me.Button2.Location = New System.Drawing.Point(572, 57)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(75, 23)
        Me.Button2.TabIndex = 21
        Me.Button2.Text = "&Eliminar"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'venta
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(767, 526)
        Me.Controls.Add(Me.lbl_version)
        Me.Controls.Add(Me.lbl_titulo)
        Me.Controls.Add(Me.GroupBox1)
        Me.Name = "venta"
        Me.Text = "Venta"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents lbl_precio As System.Windows.Forms.Label
    Friend WithEvents tbox_precio As System.Windows.Forms.TextBox
    Friend WithEvents cbox_productos As System.Windows.Forms.ComboBox
    Friend WithEvents lbl_cantidad As System.Windows.Forms.Label
    Friend WithEvents lbl_producto As System.Windows.Forms.Label
    Friend WithEvents tbox_cantidad As System.Windows.Forms.TextBox
    Friend WithEvents btn_vender As System.Windows.Forms.Button
    Friend WithEvents lst_carrito As System.Windows.Forms.ListBox
    Friend WithEvents txt_producto As System.Windows.Forms.TextBox
    Friend WithEvents lbl_subtotal As System.Windows.Forms.Label
    Friend WithEvents tbox_subtotal As System.Windows.Forms.TextBox
    Friend WithEvents btn_cancelar As System.Windows.Forms.Button
    Friend WithEvents btn_borrarLista As System.Windows.Forms.Button
    Friend WithEvents lbl_total As System.Windows.Forms.Label
    Friend WithEvents tbox_total As System.Windows.Forms.TextBox
    Friend WithEvents lbl_titulo As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents lbl_codigo As System.Windows.Forms.Label
    Friend WithEvents lbl_version As System.Windows.Forms.Label
    Friend WithEvents Button2 As System.Windows.Forms.Button
    Friend WithEvents Button1 As System.Windows.Forms.Button
End Class
