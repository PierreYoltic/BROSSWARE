<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Compras
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
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.BtnCerrar = New System.Windows.Forms.Button()
        Me.BtnProveedor = New System.Windows.Forms.Button()
        Me.BtnRemover = New System.Windows.Forms.Button()
        Me.BtnEditar = New System.Windows.Forms.Button()
        Me.BtnBuscar = New System.Windows.Forms.Button()
        Me.Panel5 = New System.Windows.Forms.Panel()
        Me.TxtIdProveedor = New System.Windows.Forms.TextBox()
        Me.TxtProveedor = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.TxtCodigoBarras = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.TxtId = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.DTPFecha = New System.Windows.Forms.DateTimePicker()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.LblTotal = New System.Windows.Forms.Label()
        Me.DataGridViewCompra = New System.Windows.Forms.DataGridView()
        Me.Clave = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Descripcion = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Cant = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.CostoU = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Precio = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Importe = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Panel1.SuspendLayout()
        Me.Panel5.SuspendLayout()
        Me.Panel2.SuspendLayout()
        Me.Panel3.SuspendLayout()
        CType(Me.DataGridViewCompra, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.FromArgb(CType(CType(27, Byte), Integer), CType(CType(38, Byte), Integer), CType(CType(69, Byte), Integer))
        Me.Panel1.Controls.Add(Me.BtnCerrar)
        Me.Panel1.Controls.Add(Me.BtnProveedor)
        Me.Panel1.Controls.Add(Me.BtnRemover)
        Me.Panel1.Controls.Add(Me.BtnEditar)
        Me.Panel1.Controls.Add(Me.BtnBuscar)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Margin = New System.Windows.Forms.Padding(2)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(774, 65)
        Me.Panel1.TabIndex = 1
        '
        'BtnCerrar
        '
        Me.BtnCerrar.FlatAppearance.BorderSize = 0
        Me.BtnCerrar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnCerrar.Font = New System.Drawing.Font("Century Gothic", 7.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnCerrar.ForeColor = System.Drawing.Color.White
        Me.BtnCerrar.Image = Global.MotoBox.My.Resources.Resources._033_handshake
        Me.BtnCerrar.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.BtnCerrar.Location = New System.Drawing.Point(358, 0)
        Me.BtnCerrar.Margin = New System.Windows.Forms.Padding(2)
        Me.BtnCerrar.Name = "BtnCerrar"
        Me.BtnCerrar.Padding = New System.Windows.Forms.Padding(0, 4, 0, 4)
        Me.BtnCerrar.Size = New System.Drawing.Size(88, 65)
        Me.BtnCerrar.TabIndex = 7
        Me.BtnCerrar.Text = "Cerrar"
        Me.BtnCerrar.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.BtnCerrar.UseVisualStyleBackColor = True
        '
        'BtnProveedor
        '
        Me.BtnProveedor.FlatAppearance.BorderSize = 0
        Me.BtnProveedor.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnProveedor.Font = New System.Drawing.Font("Century Gothic", 7.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnProveedor.ForeColor = System.Drawing.Color.White
        Me.BtnProveedor.Image = Global.MotoBox.My.Resources.Resources._359_users
        Me.BtnProveedor.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.BtnProveedor.Location = New System.Drawing.Point(270, 0)
        Me.BtnProveedor.Margin = New System.Windows.Forms.Padding(2)
        Me.BtnProveedor.Name = "BtnProveedor"
        Me.BtnProveedor.Padding = New System.Windows.Forms.Padding(0, 4, 0, 4)
        Me.BtnProveedor.Size = New System.Drawing.Size(88, 65)
        Me.BtnProveedor.TabIndex = 6
        Me.BtnProveedor.Text = "Proveedor"
        Me.BtnProveedor.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.BtnProveedor.UseVisualStyleBackColor = True
        '
        'BtnRemover
        '
        Me.BtnRemover.FlatAppearance.BorderSize = 0
        Me.BtnRemover.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnRemover.Font = New System.Drawing.Font("Century Gothic", 7.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnRemover.ForeColor = System.Drawing.Color.White
        Me.BtnRemover.Image = Global.MotoBox.My.Resources.Resources._058_error
        Me.BtnRemover.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.BtnRemover.Location = New System.Drawing.Point(178, 0)
        Me.BtnRemover.Margin = New System.Windows.Forms.Padding(2)
        Me.BtnRemover.Name = "BtnRemover"
        Me.BtnRemover.Padding = New System.Windows.Forms.Padding(0, 4, 0, 4)
        Me.BtnRemover.Size = New System.Drawing.Size(88, 65)
        Me.BtnRemover.TabIndex = 3
        Me.BtnRemover.Text = "Remover"
        Me.BtnRemover.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.BtnRemover.UseVisualStyleBackColor = True
        '
        'BtnEditar
        '
        Me.BtnEditar.FlatAppearance.BorderSize = 0
        Me.BtnEditar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnEditar.Font = New System.Drawing.Font("Century Gothic", 7.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnEditar.ForeColor = System.Drawing.Color.White
        Me.BtnEditar.Image = Global.MotoBox.My.Resources.Resources._279_edit
        Me.BtnEditar.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.BtnEditar.Location = New System.Drawing.Point(90, 0)
        Me.BtnEditar.Margin = New System.Windows.Forms.Padding(2)
        Me.BtnEditar.Name = "BtnEditar"
        Me.BtnEditar.Padding = New System.Windows.Forms.Padding(0, 4, 0, 4)
        Me.BtnEditar.Size = New System.Drawing.Size(88, 65)
        Me.BtnEditar.TabIndex = 2
        Me.BtnEditar.Text = "Editar"
        Me.BtnEditar.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.BtnEditar.UseVisualStyleBackColor = True
        '
        'BtnBuscar
        '
        Me.BtnBuscar.FlatAppearance.BorderSize = 0
        Me.BtnBuscar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnBuscar.Font = New System.Drawing.Font("Century Gothic", 7.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnBuscar.ForeColor = System.Drawing.Color.White
        Me.BtnBuscar.Image = Global.MotoBox.My.Resources.Resources._313_search
        Me.BtnBuscar.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.BtnBuscar.Location = New System.Drawing.Point(2, 0)
        Me.BtnBuscar.Margin = New System.Windows.Forms.Padding(2)
        Me.BtnBuscar.Name = "BtnBuscar"
        Me.BtnBuscar.Padding = New System.Windows.Forms.Padding(0, 4, 0, 4)
        Me.BtnBuscar.Size = New System.Drawing.Size(88, 65)
        Me.BtnBuscar.TabIndex = 0
        Me.BtnBuscar.Text = "Buscar"
        Me.BtnBuscar.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.BtnBuscar.UseVisualStyleBackColor = True
        '
        'Panel5
        '
        Me.Panel5.Controls.Add(Me.TxtIdProveedor)
        Me.Panel5.Controls.Add(Me.TxtProveedor)
        Me.Panel5.Controls.Add(Me.Label6)
        Me.Panel5.Controls.Add(Me.Button1)
        Me.Panel5.Controls.Add(Me.TxtCodigoBarras)
        Me.Panel5.Controls.Add(Me.Label4)
        Me.Panel5.Controls.Add(Me.TxtId)
        Me.Panel5.Controls.Add(Me.Label3)
        Me.Panel5.Controls.Add(Me.DTPFecha)
        Me.Panel5.Controls.Add(Me.Label2)
        Me.Panel5.Controls.Add(Me.Label1)
        Me.Panel5.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel5.Location = New System.Drawing.Point(0, 65)
        Me.Panel5.Margin = New System.Windows.Forms.Padding(2)
        Me.Panel5.Name = "Panel5"
        Me.Panel5.Size = New System.Drawing.Size(774, 81)
        Me.Panel5.TabIndex = 3
        '
        'TxtIdProveedor
        '
        Me.TxtIdProveedor.Location = New System.Drawing.Point(450, 53)
        Me.TxtIdProveedor.Margin = New System.Windows.Forms.Padding(2)
        Me.TxtIdProveedor.Name = "TxtIdProveedor"
        Me.TxtIdProveedor.ReadOnly = True
        Me.TxtIdProveedor.Size = New System.Drawing.Size(56, 20)
        Me.TxtIdProveedor.TabIndex = 13
        Me.TxtIdProveedor.Text = "-"
        '
        'TxtProveedor
        '
        Me.TxtProveedor.Location = New System.Drawing.Point(135, 53)
        Me.TxtProveedor.Margin = New System.Windows.Forms.Padding(2)
        Me.TxtProveedor.Name = "TxtProveedor"
        Me.TxtProveedor.ReadOnly = True
        Me.TxtProveedor.Size = New System.Drawing.Size(170, 20)
        Me.TxtProveedor.TabIndex = 12
        Me.TxtProveedor.Text = "-"
        '
        'Label6
        '
        Me.Label6.Font = New System.Drawing.Font("Century Gothic", 12.0!)
        Me.Label6.Image = Global.MotoBox.My.Resources.Resources._359_users
        Me.Label6.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Label6.Location = New System.Drawing.Point(306, 51)
        Me.Label6.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(140, 19)
        Me.Label6.TabIndex = 9
        Me.Label6.Text = "      ID Proveedor:"
        Me.Label6.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Button1
        '
        Me.Button1.FlatAppearance.BorderSize = 0
        Me.Button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button1.Font = New System.Drawing.Font("Century Gothic", 7.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button1.ForeColor = System.Drawing.Color.White
        Me.Button1.Image = Global.MotoBox.My.Resources.Resources._313_search
        Me.Button1.Location = New System.Drawing.Point(435, 9)
        Me.Button1.Margin = New System.Windows.Forms.Padding(2)
        Me.Button1.Name = "Button1"
        Me.Button1.Padding = New System.Windows.Forms.Padding(0, 4, 0, 4)
        Me.Button1.Size = New System.Drawing.Size(24, 26)
        Me.Button1.TabIndex = 8
        Me.Button1.UseVisualStyleBackColor = True
        '
        'TxtCodigoBarras
        '
        Me.TxtCodigoBarras.Font = New System.Drawing.Font("Century Gothic", 12.0!)
        Me.TxtCodigoBarras.Location = New System.Drawing.Point(176, 9)
        Me.TxtCodigoBarras.Margin = New System.Windows.Forms.Padding(2)
        Me.TxtCodigoBarras.Name = "TxtCodigoBarras"
        Me.TxtCodigoBarras.Size = New System.Drawing.Size(252, 27)
        Me.TxtCodigoBarras.TabIndex = 7
        '
        'Label4
        '
        Me.Label4.Font = New System.Drawing.Font("Century Gothic", 12.0!)
        Me.Label4.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Label4.Location = New System.Drawing.Point(9, 11)
        Me.Label4.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(169, 19)
        Me.Label4.TabIndex = 6
        Me.Label4.Text = "Codigo de Barras:"
        Me.Label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'TxtId
        '
        Me.TxtId.Font = New System.Drawing.Font("Century Gothic", 12.0!)
        Me.TxtId.Location = New System.Drawing.Point(704, 8)
        Me.TxtId.Margin = New System.Windows.Forms.Padding(2)
        Me.TxtId.Name = "TxtId"
        Me.TxtId.Size = New System.Drawing.Size(66, 27)
        Me.TxtId.TabIndex = 5
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Century Gothic", 12.0!)
        Me.Label3.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Label3.Location = New System.Drawing.Point(655, 12)
        Me.Label3.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(48, 21)
        Me.Label3.TabIndex = 4
        Me.Label3.Text = "Folio:"
        Me.Label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'DTPFecha
        '
        Me.DTPFecha.Font = New System.Drawing.Font("Century Gothic", 12.0!)
        Me.DTPFecha.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.DTPFecha.Location = New System.Drawing.Point(628, 47)
        Me.DTPFecha.Margin = New System.Windows.Forms.Padding(2)
        Me.DTPFecha.Name = "DTPFecha"
        Me.DTPFecha.Size = New System.Drawing.Size(140, 27)
        Me.DTPFecha.TabIndex = 3
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Century Gothic", 12.0!)
        Me.Label2.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Label2.Location = New System.Drawing.Point(565, 51)
        Me.Label2.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(63, 21)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "Fecha:"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label1
        '
        Me.Label1.Font = New System.Drawing.Font("Century Gothic", 12.0!)
        Me.Label1.Image = Global.MotoBox.My.Resources.Resources._359_users
        Me.Label1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Label1.Location = New System.Drawing.Point(9, 51)
        Me.Label1.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(122, 21)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Proveedor:"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.SystemColors.ControlDarkDark
        Me.Panel2.Controls.Add(Me.Panel3)
        Me.Panel2.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.Panel2.Location = New System.Drawing.Point(0, 409)
        Me.Panel2.Margin = New System.Windows.Forms.Padding(2)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(774, 40)
        Me.Panel2.TabIndex = 4
        '
        'Panel3
        '
        Me.Panel3.Controls.Add(Me.LblTotal)
        Me.Panel3.Location = New System.Drawing.Point(450, 4)
        Me.Panel3.Margin = New System.Windows.Forms.Padding(2)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(322, 38)
        Me.Panel3.TabIndex = 2
        '
        'LblTotal
        '
        Me.LblTotal.Dock = System.Windows.Forms.DockStyle.Right
        Me.LblTotal.Font = New System.Drawing.Font("Century Gothic", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblTotal.ForeColor = System.Drawing.Color.WhiteSmoke
        Me.LblTotal.Location = New System.Drawing.Point(2, 0)
        Me.LblTotal.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.LblTotal.Name = "LblTotal"
        Me.LblTotal.Size = New System.Drawing.Size(320, 38)
        Me.LblTotal.TabIndex = 0
        Me.LblTotal.Text = "Total: $0.00 MXN"
        Me.LblTotal.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'DataGridViewCompra
        '
        Me.DataGridViewCompra.AllowUserToAddRows = False
        Me.DataGridViewCompra.AllowUserToDeleteRows = False
        Me.DataGridViewCompra.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.DataGridViewCompra.BackgroundColor = System.Drawing.SystemColors.ControlLight
        Me.DataGridViewCompra.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridViewCompra.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Clave, Me.Descripcion, Me.Cant, Me.CostoU, Me.Precio, Me.Importe})
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Century Gothic", 10.0!)
        DataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.DataGridViewCompra.DefaultCellStyle = DataGridViewCellStyle1
        Me.DataGridViewCompra.Dock = System.Windows.Forms.DockStyle.Fill
        Me.DataGridViewCompra.Location = New System.Drawing.Point(0, 146)
        Me.DataGridViewCompra.Margin = New System.Windows.Forms.Padding(2)
        Me.DataGridViewCompra.Name = "DataGridViewCompra"
        Me.DataGridViewCompra.ReadOnly = True
        Me.DataGridViewCompra.RowHeadersWidth = 51
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Century Gothic", 12.0!)
        Me.DataGridViewCompra.RowsDefaultCellStyle = DataGridViewCellStyle2
        Me.DataGridViewCompra.RowTemplate.Height = 24
        Me.DataGridViewCompra.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.DataGridViewCompra.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.DataGridViewCompra.Size = New System.Drawing.Size(774, 263)
        Me.DataGridViewCompra.TabIndex = 5
        '
        'Clave
        '
        Me.Clave.FillWeight = 113.7482!
        Me.Clave.HeaderText = "Código"
        Me.Clave.MinimumWidth = 6
        Me.Clave.Name = "Clave"
        Me.Clave.ReadOnly = True
        '
        'Descripcion
        '
        Me.Descripcion.FillWeight = 296.154!
        Me.Descripcion.HeaderText = "Descripción"
        Me.Descripcion.MinimumWidth = 6
        Me.Descripcion.Name = "Descripcion"
        Me.Descripcion.ReadOnly = True
        '
        'Cant
        '
        Me.Cant.FillWeight = 54.06476!
        Me.Cant.HeaderText = "Cantidad"
        Me.Cant.MinimumWidth = 6
        Me.Cant.Name = "Cant"
        Me.Cant.ReadOnly = True
        '
        'CostoU
        '
        Me.CostoU.FillWeight = 64.32497!
        Me.CostoU.HeaderText = "Costo Unitario"
        Me.CostoU.MinimumWidth = 6
        Me.CostoU.Name = "CostoU"
        Me.CostoU.ReadOnly = True
        '
        'Precio
        '
        Me.Precio.FillWeight = 97.284!
        Me.Precio.HeaderText = "Precio Venta"
        Me.Precio.Name = "Precio"
        Me.Precio.ReadOnly = True
        '
        'Importe
        '
        Me.Importe.FillWeight = 84.47457!
        Me.Importe.HeaderText = "Importe"
        Me.Importe.MinimumWidth = 6
        Me.Importe.Name = "Importe"
        Me.Importe.ReadOnly = True
        '
        'Compras
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(774, 449)
        Me.Controls.Add(Me.DataGridViewCompra)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.Panel5)
        Me.Controls.Add(Me.Panel1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "Compras"
        Me.Text = "Compras"
        Me.Panel1.ResumeLayout(False)
        Me.Panel5.ResumeLayout(False)
        Me.Panel5.PerformLayout()
        Me.Panel2.ResumeLayout(False)
        Me.Panel3.ResumeLayout(False)
        CType(Me.DataGridViewCompra, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Panel1 As Panel
    Friend WithEvents BtnCerrar As Button
    Friend WithEvents BtnProveedor As Button
    Friend WithEvents BtnRemover As Button
    Friend WithEvents BtnEditar As Button
    Friend WithEvents BtnBuscar As Button
    Friend WithEvents Panel5 As Panel
    Friend WithEvents TxtIdProveedor As TextBox
    Friend WithEvents TxtProveedor As TextBox
    Friend WithEvents Label6 As Label
    Friend WithEvents Button1 As Button
    Friend WithEvents TxtCodigoBarras As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents TxtId As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents DTPFecha As DateTimePicker
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents Panel2 As Panel
    Friend WithEvents Panel3 As Panel
    Friend WithEvents LblTotal As Label
    Friend WithEvents DataGridViewCompra As DataGridView
    Friend WithEvents Clave As DataGridViewTextBoxColumn
    Friend WithEvents Descripcion As DataGridViewTextBoxColumn
    Friend WithEvents Cant As DataGridViewTextBoxColumn
    Friend WithEvents CostoU As DataGridViewTextBoxColumn
    Friend WithEvents Precio As DataGridViewTextBoxColumn
    Friend WithEvents Importe As DataGridViewTextBoxColumn
End Class
