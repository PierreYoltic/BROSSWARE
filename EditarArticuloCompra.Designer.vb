<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class EditarArticuloCompra
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
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.TxtExistencia = New System.Windows.Forms.TextBox()
        Me.TxtDescripcion = New System.Windows.Forms.TextBox()
        Me.TxtCodigo = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.TxtPrecioActual = New System.Windows.Forms.TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.TxtCostoProm = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.TxtPrecio = New System.Windows.Forms.TextBox()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.TxtUtilidad = New System.Windows.Forms.TextBox()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.TxtCosto = New System.Windows.Forms.TextBox()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.TxtCantidad = New System.Windows.Forms.TextBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.BtnAceptar = New System.Windows.Forms.Button()
        Me.BtnMantenerPrecios = New System.Windows.Forms.Button()
        Me.Panel1.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.GroupBox3.SuspendLayout()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.FromArgb(CType(CType(32, Byte), Integer), CType(CType(43, Byte), Integer), CType(CType(76, Byte), Integer))
        Me.Panel1.Controls.Add(Me.Button2)
        Me.Panel1.Controls.Add(Me.Button1)
        Me.Panel1.Controls.Add(Me.Label1)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Margin = New System.Windows.Forms.Padding(2)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(420, 40)
        Me.Panel1.TabIndex = 3
        '
        'Button2
        '
        Me.Button2.BackgroundImage = Global.MotoBox.My.Resources.Resources._084_multiply
        Me.Button2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.Button2.Dock = System.Windows.Forms.DockStyle.Right
        Me.Button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button2.Location = New System.Drawing.Point(380, 0)
        Me.Button2.Margin = New System.Windows.Forms.Padding(2)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(40, 40)
        Me.Button2.TabIndex = 2
        Me.Button2.UseVisualStyleBackColor = True
        '
        'Button1
        '
        Me.Button1.BackgroundImage = Global.MotoBox.My.Resources.Resources._084_multiply
        Me.Button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.Button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button1.Location = New System.Drawing.Point(562, 0)
        Me.Button1.Margin = New System.Windows.Forms.Padding(2)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(38, 41)
        Me.Button1.TabIndex = 1
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Century Gothic", 12.0!)
        Me.Label1.ForeColor = System.Drawing.Color.WhiteSmoke
        Me.Label1.Location = New System.Drawing.Point(173, 10)
        Me.Label1.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(75, 21)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Compra"
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.TxtExistencia)
        Me.GroupBox1.Controls.Add(Me.TxtDescripcion)
        Me.GroupBox1.Controls.Add(Me.TxtCodigo)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Dock = System.Windows.Forms.DockStyle.Top
        Me.GroupBox1.Font = New System.Drawing.Font("Century Gothic", 10.0!)
        Me.GroupBox1.Location = New System.Drawing.Point(0, 40)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(420, 140)
        Me.GroupBox1.TabIndex = 4
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Información del Artículo"
        '
        'TxtExistencia
        '
        Me.TxtExistencia.Enabled = False
        Me.TxtExistencia.Location = New System.Drawing.Point(213, 51)
        Me.TxtExistencia.Name = "TxtExistencia"
        Me.TxtExistencia.Size = New System.Drawing.Size(194, 24)
        Me.TxtExistencia.TabIndex = 5
        '
        'TxtDescripcion
        '
        Me.TxtDescripcion.Enabled = False
        Me.TxtDescripcion.Location = New System.Drawing.Point(16, 100)
        Me.TxtDescripcion.Name = "TxtDescripcion"
        Me.TxtDescripcion.Size = New System.Drawing.Size(391, 24)
        Me.TxtDescripcion.TabIndex = 4
        '
        'TxtCodigo
        '
        Me.TxtCodigo.Enabled = False
        Me.TxtCodigo.Location = New System.Drawing.Point(16, 51)
        Me.TxtCodigo.Name = "TxtCodigo"
        Me.TxtCodigo.Size = New System.Drawing.Size(194, 24)
        Me.TxtCodigo.TabIndex = 3
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(12, 78)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(93, 19)
        Me.Label3.TabIndex = 1
        Me.Label3.Text = "Descripción:"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(209, 29)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(81, 19)
        Me.Label4.TabIndex = 2
        Me.Label4.Text = "Existencia:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(12, 29)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(64, 19)
        Me.Label2.TabIndex = 0
        Me.Label2.Text = "Código:"
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.Label8)
        Me.GroupBox2.Controls.Add(Me.TxtPrecioActual)
        Me.GroupBox2.Controls.Add(Me.Label7)
        Me.GroupBox2.Controls.Add(Me.Label6)
        Me.GroupBox2.Controls.Add(Me.TxtCostoProm)
        Me.GroupBox2.Controls.Add(Me.Label5)
        Me.GroupBox2.Dock = System.Windows.Forms.DockStyle.Top
        Me.GroupBox2.Font = New System.Drawing.Font("Century Gothic", 10.0!)
        Me.GroupBox2.Location = New System.Drawing.Point(0, 180)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(420, 80)
        Me.GroupBox2.TabIndex = 5
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Precios"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(216, 42)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(17, 19)
        Me.Label8.TabIndex = 12
        Me.Label8.Text = "$"
        '
        'TxtPrecioActual
        '
        Me.TxtPrecioActual.Enabled = False
        Me.TxtPrecioActual.Location = New System.Drawing.Point(236, 39)
        Me.TxtPrecioActual.Name = "TxtPrecioActual"
        Me.TxtPrecioActual.Size = New System.Drawing.Size(104, 24)
        Me.TxtPrecioActual.TabIndex = 11
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(59, 42)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(17, 19)
        Me.Label7.TabIndex = 10
        Me.Label7.Text = "$"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(216, 17)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(120, 19)
        Me.Label6.TabIndex = 8
        Me.Label6.Text = "Precio de Venta"
        '
        'TxtCostoProm
        '
        Me.TxtCostoProm.Enabled = False
        Me.TxtCostoProm.Location = New System.Drawing.Point(82, 39)
        Me.TxtCostoProm.Name = "TxtCostoProm"
        Me.TxtCostoProm.Size = New System.Drawing.Size(128, 24)
        Me.TxtCostoProm.TabIndex = 7
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(59, 17)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(151, 19)
        Me.Label5.TabIndex = 6
        Me.Label5.Text = "Costo Compra Prom."
        '
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(Me.TxtPrecio)
        Me.GroupBox3.Controls.Add(Me.Label11)
        Me.GroupBox3.Controls.Add(Me.TxtUtilidad)
        Me.GroupBox3.Controls.Add(Me.Label12)
        Me.GroupBox3.Controls.Add(Me.TxtCosto)
        Me.GroupBox3.Controls.Add(Me.Label10)
        Me.GroupBox3.Controls.Add(Me.TxtCantidad)
        Me.GroupBox3.Controls.Add(Me.Label9)
        Me.GroupBox3.Dock = System.Windows.Forms.DockStyle.Top
        Me.GroupBox3.Font = New System.Drawing.Font("Century Gothic", 10.0!)
        Me.GroupBox3.Location = New System.Drawing.Point(0, 260)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(420, 100)
        Me.GroupBox3.TabIndex = 6
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "Detalle de la Compra"
        '
        'TxtPrecio
        '
        Me.TxtPrecio.Location = New System.Drawing.Point(346, 53)
        Me.TxtPrecio.Name = "TxtPrecio"
        Me.TxtPrecio.Size = New System.Drawing.Size(61, 24)
        Me.TxtPrecio.TabIndex = 13
        Me.TxtPrecio.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Location = New System.Drawing.Point(216, 56)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(124, 19)
        Me.Label11.TabIndex = 12
        Me.Label11.Text = "Precio de Venta:"
        '
        'TxtUtilidad
        '
        Me.TxtUtilidad.Location = New System.Drawing.Point(303, 23)
        Me.TxtUtilidad.Name = "TxtUtilidad"
        Me.TxtUtilidad.ReadOnly = True
        Me.TxtUtilidad.Size = New System.Drawing.Size(104, 24)
        Me.TxtUtilidad.TabIndex = 11
        Me.TxtUtilidad.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Location = New System.Drawing.Point(216, 26)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(81, 19)
        Me.Label12.TabIndex = 10
        Me.Label12.Text = "% Utilidad:"
        '
        'TxtCosto
        '
        Me.TxtCosto.Location = New System.Drawing.Point(99, 53)
        Me.TxtCosto.Name = "TxtCosto"
        Me.TxtCosto.Size = New System.Drawing.Size(111, 24)
        Me.TxtCosto.TabIndex = 9
        Me.TxtCosto.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(12, 56)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(52, 19)
        Me.Label10.TabIndex = 8
        Me.Label10.Text = "Costo:"
        '
        'TxtCantidad
        '
        Me.TxtCantidad.Location = New System.Drawing.Point(99, 23)
        Me.TxtCantidad.Name = "TxtCantidad"
        Me.TxtCantidad.Size = New System.Drawing.Size(111, 24)
        Me.TxtCantidad.TabIndex = 7
        Me.TxtCantidad.Text = "1"
        Me.TxtCantidad.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(12, 26)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(81, 19)
        Me.Label9.TabIndex = 6
        Me.Label9.Text = "Cantidad:"
        '
        'BtnAceptar
        '
        Me.BtnAceptar.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(80, Byte), Integer), CType(CType(200, Byte), Integer))
        Me.BtnAceptar.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.BtnAceptar.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnAceptar.ForeColor = System.Drawing.Color.White
        Me.BtnAceptar.Image = Global.MotoBox.My.Resources.Resources._008_tick_mark
        Me.BtnAceptar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.BtnAceptar.Location = New System.Drawing.Point(213, 365)
        Me.BtnAceptar.Margin = New System.Windows.Forms.Padding(2)
        Me.BtnAceptar.Name = "BtnAceptar"
        Me.BtnAceptar.Padding = New System.Windows.Forms.Padding(4, 0, 0, 0)
        Me.BtnAceptar.Size = New System.Drawing.Size(194, 40)
        Me.BtnAceptar.TabIndex = 15
        Me.BtnAceptar.Text = "      Aceptar"
        Me.BtnAceptar.UseVisualStyleBackColor = False
        '
        'BtnMantenerPrecios
        '
        Me.BtnMantenerPrecios.BackColor = System.Drawing.SystemColors.ButtonShadow
        Me.BtnMantenerPrecios.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.BtnMantenerPrecios.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnMantenerPrecios.ForeColor = System.Drawing.Color.Black
        Me.BtnMantenerPrecios.Image = Global.MotoBox.My.Resources.Resources._020_money_bag
        Me.BtnMantenerPrecios.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.BtnMantenerPrecios.Location = New System.Drawing.Point(16, 365)
        Me.BtnMantenerPrecios.Margin = New System.Windows.Forms.Padding(2)
        Me.BtnMantenerPrecios.Name = "BtnMantenerPrecios"
        Me.BtnMantenerPrecios.Padding = New System.Windows.Forms.Padding(4, 0, 0, 0)
        Me.BtnMantenerPrecios.Size = New System.Drawing.Size(194, 40)
        Me.BtnMantenerPrecios.TabIndex = 16
        Me.BtnMantenerPrecios.Text = "Precios Anteriores"
        Me.BtnMantenerPrecios.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.BtnMantenerPrecios.UseVisualStyleBackColor = False
        '
        'EditarArticuloCompra
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(420, 415)
        Me.Controls.Add(Me.BtnMantenerPrecios)
        Me.Controls.Add(Me.BtnAceptar)
        Me.Controls.Add(Me.GroupBox3)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.Panel1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "EditarArticuloCompra"
        Me.Text = "EditarArticuloCompra"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox3.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Panel1 As Panel
    Friend WithEvents Button2 As Button
    Friend WithEvents Button1 As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents TxtExistencia As TextBox
    Friend WithEvents TxtDescripcion As TextBox
    Friend WithEvents TxtCodigo As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents Label8 As Label
    Friend WithEvents TxtPrecioActual As TextBox
    Friend WithEvents Label7 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents TxtCostoProm As TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents GroupBox3 As GroupBox
    Friend WithEvents TxtCosto As TextBox
    Friend WithEvents Label10 As Label
    Friend WithEvents TxtCantidad As TextBox
    Friend WithEvents Label9 As Label
    Friend WithEvents TxtPrecio As TextBox
    Friend WithEvents Label11 As Label
    Friend WithEvents TxtUtilidad As TextBox
    Friend WithEvents Label12 As Label
    Friend WithEvents BtnAceptar As Button
    Friend WithEvents BtnMantenerPrecios As Button
End Class
