<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class cancelar_arriendo
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
        Me.btn_salir = New System.Windows.Forms.Button()
        Me.btn_arrendar = New System.Windows.Forms.Button()
        Me.lbl_titulo = New System.Windows.Forms.Label()
        Me.lst_arriendos = New System.Windows.Forms.ListBox()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'btn_salir
        '
        Me.btn_salir.Location = New System.Drawing.Point(375, 210)
        Me.btn_salir.Name = "btn_salir"
        Me.btn_salir.Size = New System.Drawing.Size(52, 30)
        Me.btn_salir.TabIndex = 45
        Me.btn_salir.Text = "&Salir"
        Me.btn_salir.UseVisualStyleBackColor = True
        '
        'btn_arrendar
        '
        Me.btn_arrendar.Location = New System.Drawing.Point(217, 210)
        Me.btn_arrendar.Name = "btn_arrendar"
        Me.btn_arrendar.Size = New System.Drawing.Size(128, 30)
        Me.btn_arrendar.TabIndex = 44
        Me.btn_arrendar.Text = "&Cancelar arriendo"
        Me.btn_arrendar.UseVisualStyleBackColor = True
        '
        'lbl_titulo
        '
        Me.lbl_titulo.AutoSize = True
        Me.lbl_titulo.Font = New System.Drawing.Font("Microsoft Sans Serif", 21.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_titulo.Location = New System.Drawing.Point(100, 9)
        Me.lbl_titulo.Name = "lbl_titulo"
        Me.lbl_titulo.Size = New System.Drawing.Size(294, 33)
        Me.lbl_titulo.TabIndex = 43
        Me.lbl_titulo.Text = "Equipos en arriendo"
        '
        'lst_arriendos
        '
        Me.lst_arriendos.FormattingEnabled = True
        Me.lst_arriendos.HorizontalScrollbar = True
        Me.lst_arriendos.Location = New System.Drawing.Point(35, 60)
        Me.lst_arriendos.Name = "lst_arriendos"
        Me.lst_arriendos.Size = New System.Drawing.Size(427, 134)
        Me.lst_arriendos.TabIndex = 46
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(65, 210)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(128, 30)
        Me.Button1.TabIndex = 47
        Me.Button1.Text = "&Asignar arriendo"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'cancelar_arriendo
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(485, 272)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.lst_arriendos)
        Me.Controls.Add(Me.btn_salir)
        Me.Controls.Add(Me.btn_arrendar)
        Me.Controls.Add(Me.lbl_titulo)
        Me.Name = "cancelar_arriendo"
        Me.Text = "Cancelar arriendos"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents btn_salir As System.Windows.Forms.Button
    Friend WithEvents btn_arrendar As System.Windows.Forms.Button
    Friend WithEvents lbl_titulo As System.Windows.Forms.Label
    Friend WithEvents lst_arriendos As System.Windows.Forms.ListBox
    Friend WithEvents Button1 As System.Windows.Forms.Button
End Class
