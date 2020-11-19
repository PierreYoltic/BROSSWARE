<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ReporteComprasArticulos
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
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

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.BtnMostrar = New System.Windows.Forms.Button()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.ComboBoxEstado = New System.Windows.Forms.ComboBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.DTPFechaFinal = New System.Windows.Forms.DateTimePicker()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.DTPFechaInicial = New System.Windows.Forms.DateTimePicker()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.TxtIdProveedor = New System.Windows.Forms.TextBox()
        Me.TxtProveedor = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.CheckBoxProveedor = New System.Windows.Forms.CheckBox()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.CheckBoxCategoria = New System.Windows.Forms.CheckBox()
        Me.CboCategoria = New System.Windows.Forms.ComboBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.CheckBoxArticulo = New System.Windows.Forms.CheckBox()
        Me.TxtDescripcion = New System.Windows.Forms.TextBox()
        Me.TxtCodigo = New System.Windows.Forms.TextBox()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.CboAscDesc = New System.Windows.Forms.ComboBox()
        Me.CboOrden = New System.Windows.Forms.ComboBox()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.Panel1.SuspendLayout()
        Me.Panel2.SuspendLayout()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.FromArgb(CType(CType(27, Byte), Integer), CType(CType(38, Byte), Integer), CType(CType(69, Byte), Integer))
        Me.Panel1.Controls.Add(Me.Label4)
        Me.Panel1.Controls.Add(Me.Button2)
        Me.Panel1.Controls.Add(Me.BtnMostrar)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Margin = New System.Windows.Forms.Padding(2)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(774, 65)
        Me.Panel1.TabIndex = 6
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.BackColor = System.Drawing.Color.FromArgb(CType(CType(32, Byte), Integer), CType(CType(43, Byte), Integer), CType(CType(76, Byte), Integer))
        Me.Label4.Font = New System.Drawing.Font("Century Gothic", 18.0!)
        Me.Label4.ForeColor = System.Drawing.Color.White
        Me.Label4.Location = New System.Drawing.Point(357, 17)
        Me.Label4.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(406, 30)
        Me.Label4.TabIndex = 8
        Me.Label4.Text = "Reporte de Compras por Artículo"
        '
        'Button2
        '
        Me.Button2.Enabled = False
        Me.Button2.FlatAppearance.BorderSize = 0
        Me.Button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button2.Font = New System.Drawing.Font("Century Gothic", 7.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button2.ForeColor = System.Drawing.Color.White
        Me.Button2.Image = Global.MotoBox.My.Resources.Resources._222_print
        Me.Button2.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.Button2.Location = New System.Drawing.Point(94, 0)
        Me.Button2.Margin = New System.Windows.Forms.Padding(2)
        Me.Button2.Name = "Button2"
        Me.Button2.Padding = New System.Windows.Forms.Padding(0, 4, 0, 4)
        Me.Button2.Size = New System.Drawing.Size(88, 65)
        Me.Button2.TabIndex = 2
        Me.Button2.Text = "Imprimir"
        Me.Button2.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.Button2.UseVisualStyleBackColor = True
        '
        'BtnMostrar
        '
        Me.BtnMostrar.FlatAppearance.BorderSize = 0
        Me.BtnMostrar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnMostrar.Font = New System.Drawing.Font("Century Gothic", 7.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnMostrar.ForeColor = System.Drawing.Color.White
        Me.BtnMostrar.Image = Global.MotoBox.My.Resources.Resources._021_view
        Me.BtnMostrar.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.BtnMostrar.Location = New System.Drawing.Point(2, 0)
        Me.BtnMostrar.Margin = New System.Windows.Forms.Padding(2)
        Me.BtnMostrar.Name = "BtnMostrar"
        Me.BtnMostrar.Padding = New System.Windows.Forms.Padding(0, 4, 0, 4)
        Me.BtnMostrar.Size = New System.Drawing.Size(88, 65)
        Me.BtnMostrar.TabIndex = 0
        Me.BtnMostrar.Text = "Mostrar"
        Me.BtnMostrar.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.BtnMostrar.UseVisualStyleBackColor = True
        '
        'Panel2
        '
        Me.Panel2.Controls.Add(Me.ComboBoxEstado)
        Me.Panel2.Controls.Add(Me.Label3)
        Me.Panel2.Controls.Add(Me.DTPFechaFinal)
        Me.Panel2.Controls.Add(Me.Label1)
        Me.Panel2.Controls.Add(Me.DTPFechaInicial)
        Me.Panel2.Controls.Add(Me.Label2)
        Me.Panel2.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel2.Location = New System.Drawing.Point(0, 65)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(774, 50)
        Me.Panel2.TabIndex = 7
        '
        'ComboBoxEstado
        '
        Me.ComboBoxEstado.Font = New System.Drawing.Font("Century Gothic", 12.0!)
        Me.ComboBoxEstado.FormattingEnabled = True
        Me.ComboBoxEstado.Items.AddRange(New Object() {"Todos", "Vigente", "Cancelado"})
        Me.ComboBoxEstado.Location = New System.Drawing.Point(594, 11)
        Me.ComboBoxEstado.Name = "ComboBoxEstado"
        Me.ComboBoxEstado.Size = New System.Drawing.Size(152, 29)
        Me.ComboBoxEstado.TabIndex = 9
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Century Gothic", 12.0!)
        Me.Label3.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Label3.Location = New System.Drawing.Point(521, 18)
        Me.Label3.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(68, 21)
        Me.Label3.TabIndex = 8
        Me.Label3.Text = "Estado:"
        Me.Label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'DTPFechaFinal
        '
        Me.DTPFechaFinal.Font = New System.Drawing.Font("Century Gothic", 12.0!)
        Me.DTPFechaFinal.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.DTPFechaFinal.Location = New System.Drawing.Point(377, 13)
        Me.DTPFechaFinal.Margin = New System.Windows.Forms.Padding(2)
        Me.DTPFechaFinal.Name = "DTPFechaFinal"
        Me.DTPFechaFinal.Size = New System.Drawing.Size(140, 27)
        Me.DTPFechaFinal.TabIndex = 7
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Century Gothic", 12.0!)
        Me.Label1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Label1.Location = New System.Drawing.Point(271, 18)
        Me.Label1.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(102, 21)
        Me.Label1.TabIndex = 6
        Me.Label1.Text = "Fecha Final:"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'DTPFechaInicial
        '
        Me.DTPFechaInicial.Font = New System.Drawing.Font("Century Gothic", 12.0!)
        Me.DTPFechaInicial.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.DTPFechaInicial.Location = New System.Drawing.Point(127, 13)
        Me.DTPFechaInicial.Margin = New System.Windows.Forms.Padding(2)
        Me.DTPFechaInicial.Name = "DTPFechaInicial"
        Me.DTPFechaInicial.Size = New System.Drawing.Size(140, 27)
        Me.DTPFechaInicial.TabIndex = 5
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Century Gothic", 12.0!)
        Me.Label2.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Label2.Location = New System.Drawing.Point(11, 18)
        Me.Label2.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(112, 21)
        Me.Label2.TabIndex = 4
        Me.Label2.Text = "Fecha Inicial:"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'TxtIdProveedor
        '
        Me.TxtIdProveedor.Location = New System.Drawing.Point(687, 148)
        Me.TxtIdProveedor.Margin = New System.Windows.Forms.Padding(2)
        Me.TxtIdProveedor.Name = "TxtIdProveedor"
        Me.TxtIdProveedor.ReadOnly = True
        Me.TxtIdProveedor.Size = New System.Drawing.Size(59, 20)
        Me.TxtIdProveedor.TabIndex = 26
        Me.TxtIdProveedor.Text = "-"
        '
        'TxtProveedor
        '
        Me.TxtProveedor.Location = New System.Drawing.Point(372, 146)
        Me.TxtProveedor.Margin = New System.Windows.Forms.Padding(2)
        Me.TxtProveedor.Name = "TxtProveedor"
        Me.TxtProveedor.ReadOnly = True
        Me.TxtProveedor.Size = New System.Drawing.Size(170, 20)
        Me.TxtProveedor.TabIndex = 25
        '
        'Label6
        '
        Me.Label6.Font = New System.Drawing.Font("Century Gothic", 12.0!)
        Me.Label6.Image = Global.MotoBox.My.Resources.Resources._359_users
        Me.Label6.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Label6.Location = New System.Drawing.Point(543, 147)
        Me.Label6.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(140, 19)
        Me.Label6.TabIndex = 24
        Me.Label6.Text = "      ID Proveedor:"
        Me.Label6.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label8
        '
        Me.Label8.Font = New System.Drawing.Font("Century Gothic", 12.0!)
        Me.Label8.Image = Global.MotoBox.My.Resources.Resources._359_users
        Me.Label8.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Label8.Location = New System.Drawing.Point(246, 145)
        Me.Label8.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(122, 21)
        Me.Label8.TabIndex = 23
        Me.Label8.Text = "Proveedor:"
        Me.Label8.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.ForeColor = System.Drawing.Color.FromArgb(CType(CType(189, Byte), Integer), CType(CType(189, Byte), Integer), CType(CType(189, Byte), Integer))
        Me.Label7.Location = New System.Drawing.Point(9, 117)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(745, 13)
        Me.Label7.TabIndex = 22
        Me.Label7.Text = "_________________________________________________________________________________" &
    "__________________________________________"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.ForeColor = System.Drawing.Color.FromArgb(CType(CType(189, Byte), Integer), CType(CType(189, Byte), Integer), CType(CType(189, Byte), Integer))
        Me.Label5.Location = New System.Drawing.Point(10, 169)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(745, 13)
        Me.Label5.TabIndex = 21
        Me.Label5.Text = "_________________________________________________________________________________" &
    "__________________________________________"
        '
        'CheckBoxProveedor
        '
        Me.CheckBoxProveedor.AutoSize = True
        Me.CheckBoxProveedor.Checked = True
        Me.CheckBoxProveedor.CheckState = System.Windows.Forms.CheckState.Checked
        Me.CheckBoxProveedor.FlatAppearance.CheckedBackColor = System.Drawing.Color.Blue
        Me.CheckBoxProveedor.Font = New System.Drawing.Font("Century Gothic", 12.0!)
        Me.CheckBoxProveedor.ForeColor = System.Drawing.Color.Black
        Me.CheckBoxProveedor.Location = New System.Drawing.Point(12, 145)
        Me.CheckBoxProveedor.Name = "CheckBoxProveedor"
        Me.CheckBoxProveedor.Size = New System.Drawing.Size(199, 25)
        Me.CheckBoxProveedor.TabIndex = 20
        Me.CheckBoxProveedor.Text = "Todos los proveedores"
        Me.CheckBoxProveedor.UseVisualStyleBackColor = True
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.ForeColor = System.Drawing.Color.FromArgb(CType(CType(189, Byte), Integer), CType(CType(189, Byte), Integer), CType(CType(189, Byte), Integer))
        Me.Label10.Location = New System.Drawing.Point(13, 223)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(745, 13)
        Me.Label10.TabIndex = 28
        Me.Label10.Text = "_________________________________________________________________________________" &
    "__________________________________________"
        '
        'CheckBoxCategoria
        '
        Me.CheckBoxCategoria.AutoSize = True
        Me.CheckBoxCategoria.Checked = True
        Me.CheckBoxCategoria.CheckState = System.Windows.Forms.CheckState.Checked
        Me.CheckBoxCategoria.FlatAppearance.CheckedBackColor = System.Drawing.Color.Blue
        Me.CheckBoxCategoria.Font = New System.Drawing.Font("Century Gothic", 12.0!)
        Me.CheckBoxCategoria.ForeColor = System.Drawing.Color.Black
        Me.CheckBoxCategoria.Location = New System.Drawing.Point(15, 199)
        Me.CheckBoxCategoria.Name = "CheckBoxCategoria"
        Me.CheckBoxCategoria.Size = New System.Drawing.Size(187, 25)
        Me.CheckBoxCategoria.TabIndex = 27
        Me.CheckBoxCategoria.Text = "Todas las categorías"
        Me.CheckBoxCategoria.UseVisualStyleBackColor = True
        '
        'CboCategoria
        '
        Me.CboCategoria.Enabled = False
        Me.CboCategoria.Font = New System.Drawing.Font("Century Gothic", 12.0!)
        Me.CboCategoria.FormattingEnabled = True
        Me.CboCategoria.Location = New System.Drawing.Point(347, 197)
        Me.CboCategoria.Name = "CboCategoria"
        Me.CboCategoria.Size = New System.Drawing.Size(195, 29)
        Me.CboCategoria.TabIndex = 30
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Century Gothic", 12.0!)
        Me.Label9.ForeColor = System.Drawing.Color.Black
        Me.Label9.Location = New System.Drawing.Point(246, 200)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(95, 21)
        Me.Label9.TabIndex = 29
        Me.Label9.Text = "Categoría:"
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Font = New System.Drawing.Font("Century Gothic", 12.0!)
        Me.Label11.ForeColor = System.Drawing.Color.Black
        Me.Label11.Location = New System.Drawing.Point(247, 255)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(75, 21)
        Me.Label11.TabIndex = 33
        Me.Label11.Text = "Artículo:"
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.ForeColor = System.Drawing.Color.FromArgb(CType(CType(189, Byte), Integer), CType(CType(189, Byte), Integer), CType(CType(189, Byte), Integer))
        Me.Label12.Location = New System.Drawing.Point(14, 278)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(745, 13)
        Me.Label12.TabIndex = 32
        Me.Label12.Text = "_________________________________________________________________________________" &
    "__________________________________________"
        '
        'CheckBoxArticulo
        '
        Me.CheckBoxArticulo.AutoSize = True
        Me.CheckBoxArticulo.Checked = True
        Me.CheckBoxArticulo.CheckState = System.Windows.Forms.CheckState.Checked
        Me.CheckBoxArticulo.FlatAppearance.CheckedBackColor = System.Drawing.Color.Blue
        Me.CheckBoxArticulo.Font = New System.Drawing.Font("Century Gothic", 12.0!)
        Me.CheckBoxArticulo.ForeColor = System.Drawing.Color.Black
        Me.CheckBoxArticulo.Location = New System.Drawing.Point(16, 254)
        Me.CheckBoxArticulo.Name = "CheckBoxArticulo"
        Me.CheckBoxArticulo.Size = New System.Drawing.Size(166, 25)
        Me.CheckBoxArticulo.TabIndex = 31
        Me.CheckBoxArticulo.Text = "Todos los artículos"
        Me.CheckBoxArticulo.UseVisualStyleBackColor = True
        '
        'TxtDescripcion
        '
        Me.TxtDescripcion.Location = New System.Drawing.Point(327, 256)
        Me.TxtDescripcion.Margin = New System.Windows.Forms.Padding(2)
        Me.TxtDescripcion.Name = "TxtDescripcion"
        Me.TxtDescripcion.ReadOnly = True
        Me.TxtDescripcion.Size = New System.Drawing.Size(215, 20)
        Me.TxtDescripcion.TabIndex = 34
        '
        'TxtCodigo
        '
        Me.TxtCodigo.Location = New System.Drawing.Point(627, 255)
        Me.TxtCodigo.Margin = New System.Windows.Forms.Padding(2)
        Me.TxtCodigo.Name = "TxtCodigo"
        Me.TxtCodigo.ReadOnly = True
        Me.TxtCodigo.Size = New System.Drawing.Size(119, 20)
        Me.TxtCodigo.TabIndex = 36
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Font = New System.Drawing.Font("Century Gothic", 12.0!)
        Me.Label13.ForeColor = System.Drawing.Color.Black
        Me.Label13.Location = New System.Drawing.Point(547, 253)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(75, 21)
        Me.Label13.TabIndex = 35
        Me.Label13.Text = "Artículo:"
        '
        'CboAscDesc
        '
        Me.CboAscDesc.Font = New System.Drawing.Font("Century Gothic", 12.0!)
        Me.CboAscDesc.ForeColor = System.Drawing.Color.Black
        Me.CboAscDesc.FormattingEnabled = True
        Me.CboAscDesc.Items.AddRange(New Object() {"Ascendente", "Descendente"})
        Me.CboAscDesc.Location = New System.Drawing.Point(348, 310)
        Me.CboAscDesc.Name = "CboAscDesc"
        Me.CboAscDesc.Size = New System.Drawing.Size(194, 29)
        Me.CboAscDesc.TabIndex = 39
        '
        'CboOrden
        '
        Me.CboOrden.Font = New System.Drawing.Font("Century Gothic", 12.0!)
        Me.CboOrden.ForeColor = System.Drawing.Color.Black
        Me.CboOrden.FormattingEnabled = True
        Me.CboOrden.Items.AddRange(New Object() {"Descripción", "Clave", "Categoría", "Cantidad"})
        Me.CboOrden.Location = New System.Drawing.Point(129, 310)
        Me.CboOrden.Name = "CboOrden"
        Me.CboOrden.Size = New System.Drawing.Size(193, 29)
        Me.CboOrden.TabIndex = 38
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Font = New System.Drawing.Font("Century Gothic", 12.0!)
        Me.Label14.ForeColor = System.Drawing.Color.Black
        Me.Label14.Location = New System.Drawing.Point(13, 313)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(110, 21)
        Me.Label14.TabIndex = 37
        Me.Label14.Text = "Ordenar por:"
        '
        'ReporteComprasArticulos
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(774, 449)
        Me.Controls.Add(Me.CboAscDesc)
        Me.Controls.Add(Me.CboOrden)
        Me.Controls.Add(Me.Label14)
        Me.Controls.Add(Me.TxtCodigo)
        Me.Controls.Add(Me.Label13)
        Me.Controls.Add(Me.TxtDescripcion)
        Me.Controls.Add(Me.Label11)
        Me.Controls.Add(Me.Label12)
        Me.Controls.Add(Me.CheckBoxArticulo)
        Me.Controls.Add(Me.CboCategoria)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.CheckBoxCategoria)
        Me.Controls.Add(Me.TxtIdProveedor)
        Me.Controls.Add(Me.TxtProveedor)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.CheckBoxProveedor)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.Panel1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "ReporteComprasArticulos"
        Me.Text = "ReporteComprasArticulos"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Panel1 As Panel
    Friend WithEvents Label4 As Label
    Friend WithEvents Button2 As Button
    Friend WithEvents BtnMostrar As Button
    Friend WithEvents Panel2 As Panel
    Friend WithEvents ComboBoxEstado As ComboBox
    Friend WithEvents Label3 As Label
    Friend WithEvents DTPFechaFinal As DateTimePicker
    Friend WithEvents Label1 As Label
    Friend WithEvents DTPFechaInicial As DateTimePicker
    Friend WithEvents Label2 As Label
    Friend WithEvents TxtIdProveedor As TextBox
    Friend WithEvents TxtProveedor As TextBox
    Friend WithEvents Label6 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents CheckBoxProveedor As CheckBox
    Friend WithEvents Label10 As Label
    Friend WithEvents CheckBoxCategoria As CheckBox
    Friend WithEvents CboCategoria As ComboBox
    Friend WithEvents Label9 As Label
    Friend WithEvents Label11 As Label
    Friend WithEvents Label12 As Label
    Friend WithEvents CheckBoxArticulo As CheckBox
    Friend WithEvents TxtDescripcion As TextBox
    Friend WithEvents TxtCodigo As TextBox
    Friend WithEvents Label13 As Label
    Friend WithEvents CboAscDesc As ComboBox
    Friend WithEvents CboOrden As ComboBox
    Friend WithEvents Label14 As Label
End Class
