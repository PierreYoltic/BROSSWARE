<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Ventas
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
        Dim DataGridViewCellStyle7 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle8 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.BtnCerrar = New System.Windows.Forms.Button()
        Me.BtnCliente = New System.Windows.Forms.Button()
        Me.BtnImporte = New System.Windows.Forms.Button()
        Me.BtnDesc = New System.Windows.Forms.Button()
        Me.BtnRemover = New System.Windows.Forms.Button()
        Me.BtnCantidad = New System.Windows.Forms.Button()
        Me.BtnBuscar = New System.Windows.Forms.Button()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.Panel4 = New System.Windows.Forms.Panel()
        Me.LblDescuento = New System.Windows.Forms.Label()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.LblTotal = New System.Windows.Forms.Label()
        Me.DataGridViewVenta = New System.Windows.Forms.DataGridView()
        Me.Cant = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Clave = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Descripcion = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Exist = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Desc = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.PrecioU = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Importe = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Panel5 = New System.Windows.Forms.Panel()
        Me.TxtIdCliente = New System.Windows.Forms.TextBox()
        Me.TxtCliente = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.TxtCodigoBarras = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.TxtId = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.DTPFecha = New System.Windows.Forms.DateTimePicker()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Panel6 = New System.Windows.Forms.Panel()
        Me.Panel1.SuspendLayout()
        Me.Panel2.SuspendLayout()
        Me.Panel4.SuspendLayout()
        Me.Panel3.SuspendLayout()
        CType(Me.DataGridViewVenta, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel5.SuspendLayout()
        Me.Panel6.SuspendLayout()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.FromArgb(CType(CType(27, Byte), Integer), CType(CType(38, Byte), Integer), CType(CType(69, Byte), Integer))
        Me.Panel1.Controls.Add(Me.BtnCerrar)
        Me.Panel1.Controls.Add(Me.BtnCliente)
        Me.Panel1.Controls.Add(Me.BtnImporte)
        Me.Panel1.Controls.Add(Me.BtnDesc)
        Me.Panel1.Controls.Add(Me.BtnRemover)
        Me.Panel1.Controls.Add(Me.BtnCantidad)
        Me.Panel1.Controls.Add(Me.BtnBuscar)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(1032, 80)
        Me.Panel1.TabIndex = 0
        '
        'BtnCerrar
        '
        Me.BtnCerrar.FlatAppearance.BorderSize = 0
        Me.BtnCerrar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnCerrar.Font = New System.Drawing.Font("Century Gothic", 7.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnCerrar.ForeColor = System.Drawing.Color.White
        Me.BtnCerrar.Image = Global.MotoBox.My.Resources.Resources._033_handshake
        Me.BtnCerrar.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.BtnCerrar.Location = New System.Drawing.Point(705, 0)
        Me.BtnCerrar.Name = "BtnCerrar"
        Me.BtnCerrar.Padding = New System.Windows.Forms.Padding(0, 5, 0, 5)
        Me.BtnCerrar.Size = New System.Drawing.Size(117, 80)
        Me.BtnCerrar.TabIndex = 7
        Me.BtnCerrar.Text = "Cerrar"
        Me.BtnCerrar.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.BtnCerrar.UseVisualStyleBackColor = True
        '
        'BtnCliente
        '
        Me.BtnCliente.FlatAppearance.BorderSize = 0
        Me.BtnCliente.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnCliente.Font = New System.Drawing.Font("Century Gothic", 7.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnCliente.ForeColor = System.Drawing.Color.White
        Me.BtnCliente.Image = Global.MotoBox.My.Resources.Resources._359_users
        Me.BtnCliente.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.BtnCliente.Location = New System.Drawing.Point(588, 0)
        Me.BtnCliente.Name = "BtnCliente"
        Me.BtnCliente.Padding = New System.Windows.Forms.Padding(0, 5, 0, 5)
        Me.BtnCliente.Size = New System.Drawing.Size(117, 80)
        Me.BtnCliente.TabIndex = 6
        Me.BtnCliente.Text = "Cliente"
        Me.BtnCliente.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.BtnCliente.UseVisualStyleBackColor = True
        '
        'BtnImporte
        '
        Me.BtnImporte.FlatAppearance.BorderSize = 0
        Me.BtnImporte.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnImporte.Font = New System.Drawing.Font("Century Gothic", 7.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnImporte.ForeColor = System.Drawing.Color.White
        Me.BtnImporte.Image = Global.MotoBox.My.Resources.Resources._020_money_bag
        Me.BtnImporte.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.BtnImporte.Location = New System.Drawing.Point(471, 0)
        Me.BtnImporte.Name = "BtnImporte"
        Me.BtnImporte.Padding = New System.Windows.Forms.Padding(0, 5, 0, 5)
        Me.BtnImporte.Size = New System.Drawing.Size(117, 80)
        Me.BtnImporte.TabIndex = 5
        Me.BtnImporte.Text = "Importe"
        Me.BtnImporte.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.BtnImporte.UseVisualStyleBackColor = True
        '
        'BtnDesc
        '
        Me.BtnDesc.Enabled = False
        Me.BtnDesc.FlatAppearance.BorderSize = 0
        Me.BtnDesc.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnDesc.Font = New System.Drawing.Font("Century Gothic", 7.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnDesc.ForeColor = System.Drawing.Color.White
        Me.BtnDesc.Image = Global.MotoBox.My.Resources.Resources._088_percent
        Me.BtnDesc.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.BtnDesc.Location = New System.Drawing.Point(354, 0)
        Me.BtnDesc.Name = "BtnDesc"
        Me.BtnDesc.Padding = New System.Windows.Forms.Padding(0, 5, 0, 5)
        Me.BtnDesc.Size = New System.Drawing.Size(117, 80)
        Me.BtnDesc.TabIndex = 4
        Me.BtnDesc.Text = "Desc."
        Me.BtnDesc.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.BtnDesc.UseVisualStyleBackColor = True
        '
        'BtnRemover
        '
        Me.BtnRemover.FlatAppearance.BorderSize = 0
        Me.BtnRemover.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnRemover.Font = New System.Drawing.Font("Century Gothic", 7.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnRemover.ForeColor = System.Drawing.Color.White
        Me.BtnRemover.Image = Global.MotoBox.My.Resources.Resources._058_error
        Me.BtnRemover.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.BtnRemover.Location = New System.Drawing.Point(237, 0)
        Me.BtnRemover.Name = "BtnRemover"
        Me.BtnRemover.Padding = New System.Windows.Forms.Padding(0, 5, 0, 5)
        Me.BtnRemover.Size = New System.Drawing.Size(117, 80)
        Me.BtnRemover.TabIndex = 3
        Me.BtnRemover.Text = "Remover"
        Me.BtnRemover.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.BtnRemover.UseVisualStyleBackColor = True
        '
        'BtnCantidad
        '
        Me.BtnCantidad.FlatAppearance.BorderSize = 0
        Me.BtnCantidad.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnCantidad.Font = New System.Drawing.Font("Century Gothic", 7.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnCantidad.ForeColor = System.Drawing.Color.White
        Me.BtnCantidad.Image = Global.MotoBox.My.Resources.Resources._079_calculator
        Me.BtnCantidad.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.BtnCantidad.Location = New System.Drawing.Point(120, 0)
        Me.BtnCantidad.Name = "BtnCantidad"
        Me.BtnCantidad.Padding = New System.Windows.Forms.Padding(0, 5, 0, 5)
        Me.BtnCantidad.Size = New System.Drawing.Size(117, 80)
        Me.BtnCantidad.TabIndex = 2
        Me.BtnCantidad.Text = "Cantidad"
        Me.BtnCantidad.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.BtnCantidad.UseVisualStyleBackColor = True
        '
        'BtnBuscar
        '
        Me.BtnBuscar.FlatAppearance.BorderSize = 0
        Me.BtnBuscar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnBuscar.Font = New System.Drawing.Font("Century Gothic", 7.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnBuscar.ForeColor = System.Drawing.Color.White
        Me.BtnBuscar.Image = Global.MotoBox.My.Resources.Resources._313_search
        Me.BtnBuscar.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.BtnBuscar.Location = New System.Drawing.Point(3, 0)
        Me.BtnBuscar.Name = "BtnBuscar"
        Me.BtnBuscar.Padding = New System.Windows.Forms.Padding(0, 5, 0, 5)
        Me.BtnBuscar.Size = New System.Drawing.Size(117, 80)
        Me.BtnBuscar.TabIndex = 0
        Me.BtnBuscar.Text = "Buscar"
        Me.BtnBuscar.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.BtnBuscar.UseVisualStyleBackColor = True
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.SystemColors.ControlDarkDark
        Me.Panel2.Controls.Add(Me.Panel4)
        Me.Panel2.Controls.Add(Me.Panel3)
        Me.Panel2.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.Panel2.Location = New System.Drawing.Point(0, 453)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(1032, 100)
        Me.Panel2.TabIndex = 1
        '
        'Panel4
        '
        Me.Panel4.Controls.Add(Me.LblDescuento)
        Me.Panel4.Location = New System.Drawing.Point(746, 9)
        Me.Panel4.Name = "Panel4"
        Me.Panel4.Size = New System.Drawing.Size(283, 41)
        Me.Panel4.TabIndex = 5
        '
        'LblDescuento
        '
        Me.LblDescuento.Font = New System.Drawing.Font("Century Gothic", 14.0!, System.Drawing.FontStyle.Bold)
        Me.LblDescuento.ForeColor = System.Drawing.Color.Red
        Me.LblDescuento.Location = New System.Drawing.Point(6, 6)
        Me.LblDescuento.Name = "LblDescuento"
        Me.LblDescuento.Size = New System.Drawing.Size(271, 28)
        Me.LblDescuento.TabIndex = 3
        Me.LblDescuento.Text = "Descuento: $0.00"
        '
        'Panel3
        '
        Me.Panel3.Controls.Add(Me.LblTotal)
        Me.Panel3.Location = New System.Drawing.Point(705, 50)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(324, 47)
        Me.Panel3.TabIndex = 2
        '
        'LblTotal
        '
        Me.LblTotal.Font = New System.Drawing.Font("Century Gothic", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblTotal.ForeColor = System.Drawing.Color.WhiteSmoke
        Me.LblTotal.Location = New System.Drawing.Point(5, 5)
        Me.LblTotal.Name = "LblTotal"
        Me.LblTotal.Size = New System.Drawing.Size(314, 37)
        Me.LblTotal.TabIndex = 0
        Me.LblTotal.Text = "Total: $0.00 MXN"
        '
        'DataGridViewVenta
        '
        Me.DataGridViewVenta.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.DataGridViewVenta.BackgroundColor = System.Drawing.SystemColors.ControlLight
        Me.DataGridViewVenta.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridViewVenta.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Cant, Me.Clave, Me.Descripcion, Me.Exist, Me.Desc, Me.PrecioU, Me.Importe})
        DataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle7.BackColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle7.Font = New System.Drawing.Font("Century Gothic", 10.0!)
        DataGridViewCellStyle7.ForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle7.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle7.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle7.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.DataGridViewVenta.DefaultCellStyle = DataGridViewCellStyle7
        Me.DataGridViewVenta.Dock = System.Windows.Forms.DockStyle.Fill
        Me.DataGridViewVenta.Location = New System.Drawing.Point(0, 0)
        Me.DataGridViewVenta.Name = "DataGridViewVenta"
        Me.DataGridViewVenta.RowHeadersWidth = 51
        DataGridViewCellStyle8.Font = New System.Drawing.Font("Century Gothic", 12.0!)
        Me.DataGridViewVenta.RowsDefaultCellStyle = DataGridViewCellStyle8
        Me.DataGridViewVenta.RowTemplate.Height = 24
        Me.DataGridViewVenta.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.DataGridViewVenta.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.DataGridViewVenta.Size = New System.Drawing.Size(1032, 273)
        Me.DataGridViewVenta.TabIndex = 0
        '
        'Cant
        '
        Me.Cant.FillWeight = 35.75077!
        Me.Cant.HeaderText = "Cant."
        Me.Cant.MinimumWidth = 6
        Me.Cant.Name = "Cant"
        Me.Cant.ReadOnly = True
        '
        'Clave
        '
        Me.Clave.FillWeight = 116.9239!
        Me.Clave.HeaderText = "Clave"
        Me.Clave.MinimumWidth = 6
        Me.Clave.Name = "Clave"
        Me.Clave.ReadOnly = True
        '
        'Descripcion
        '
        Me.Descripcion.FillWeight = 304.4221!
        Me.Descripcion.HeaderText = "Descripción"
        Me.Descripcion.MinimumWidth = 6
        Me.Descripcion.Name = "Descripcion"
        Me.Descripcion.ReadOnly = True
        '
        'Exist
        '
        Me.Exist.FillWeight = 27.55489!
        Me.Exist.HeaderText = "Exist."
        Me.Exist.MinimumWidth = 6
        Me.Exist.Name = "Exist"
        Me.Exist.ReadOnly = True
        '
        'Desc
        '
        Me.Desc.FillWeight = 62.39466!
        Me.Desc.HeaderText = "Desc."
        Me.Desc.MinimumWidth = 6
        Me.Desc.Name = "Desc"
        Me.Desc.ReadOnly = True
        '
        'PrecioU
        '
        Me.PrecioU.FillWeight = 66.12082!
        Me.PrecioU.HeaderText = "Precio U."
        Me.PrecioU.MinimumWidth = 6
        Me.PrecioU.Name = "PrecioU"
        Me.PrecioU.ReadOnly = True
        '
        'Importe
        '
        Me.Importe.FillWeight = 86.83296!
        Me.Importe.HeaderText = "Importe"
        Me.Importe.MinimumWidth = 6
        Me.Importe.Name = "Importe"
        Me.Importe.ReadOnly = True
        '
        'Panel5
        '
        Me.Panel5.Controls.Add(Me.TxtIdCliente)
        Me.Panel5.Controls.Add(Me.TxtCliente)
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
        Me.Panel5.Location = New System.Drawing.Point(0, 80)
        Me.Panel5.Name = "Panel5"
        Me.Panel5.Size = New System.Drawing.Size(1032, 100)
        Me.Panel5.TabIndex = 2
        '
        'TxtIdCliente
        '
        Me.TxtIdCliente.Location = New System.Drawing.Point(551, 66)
        Me.TxtIdCliente.Name = "TxtIdCliente"
        Me.TxtIdCliente.ReadOnly = True
        Me.TxtIdCliente.Size = New System.Drawing.Size(73, 22)
        Me.TxtIdCliente.TabIndex = 13
        Me.TxtIdCliente.Text = "1"
        '
        'TxtCliente
        '
        Me.TxtCliente.Location = New System.Drawing.Point(163, 64)
        Me.TxtCliente.Name = "TxtCliente"
        Me.TxtCliente.ReadOnly = True
        Me.TxtCliente.Size = New System.Drawing.Size(226, 22)
        Me.TxtCliente.TabIndex = 12
        Me.TxtCliente.Text = "PUBLICO EN GENERAL"
        '
        'Label6
        '
        Me.Label6.Font = New System.Drawing.Font("Century Gothic", 12.0!)
        Me.Label6.Image = Global.MotoBox.My.Resources.Resources._359_users
        Me.Label6.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Label6.Location = New System.Drawing.Point(411, 63)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(163, 23)
        Me.Label6.TabIndex = 9
        Me.Label6.Text = "ID Cliente:"
        Me.Label6.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Button1
        '
        Me.Button1.FlatAppearance.BorderSize = 0
        Me.Button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button1.Font = New System.Drawing.Font("Century Gothic", 7.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button1.ForeColor = System.Drawing.Color.White
        Me.Button1.Image = Global.MotoBox.My.Resources.Resources._313_search
        Me.Button1.Location = New System.Drawing.Point(580, 11)
        Me.Button1.Name = "Button1"
        Me.Button1.Padding = New System.Windows.Forms.Padding(0, 5, 0, 5)
        Me.Button1.Size = New System.Drawing.Size(32, 32)
        Me.Button1.TabIndex = 8
        Me.Button1.UseVisualStyleBackColor = True
        '
        'TxtCodigoBarras
        '
        Me.TxtCodigoBarras.Font = New System.Drawing.Font("Century Gothic", 12.0!)
        Me.TxtCodigoBarras.Location = New System.Drawing.Point(235, 11)
        Me.TxtCodigoBarras.Name = "TxtCodigoBarras"
        Me.TxtCodigoBarras.Size = New System.Drawing.Size(335, 32)
        Me.TxtCodigoBarras.TabIndex = 7
        '
        'Label4
        '
        Me.Label4.Font = New System.Drawing.Font("Century Gothic", 12.0!)
        Me.Label4.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Label4.Location = New System.Drawing.Point(12, 14)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(225, 23)
        Me.Label4.TabIndex = 6
        Me.Label4.Text = "Codigo de Barras:"
        Me.Label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'TxtId
        '
        Me.TxtId.Font = New System.Drawing.Font("Century Gothic", 12.0!)
        Me.TxtId.Location = New System.Drawing.Point(938, 10)
        Me.TxtId.Name = "TxtId"
        Me.TxtId.ReadOnly = True
        Me.TxtId.Size = New System.Drawing.Size(86, 32)
        Me.TxtId.TabIndex = 5
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Century Gothic", 12.0!)
        Me.Label3.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Label3.Location = New System.Drawing.Point(873, 15)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(59, 23)
        Me.Label3.TabIndex = 4
        Me.Label3.Text = "Folio:"
        Me.Label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'DTPFecha
        '
        Me.DTPFecha.Font = New System.Drawing.Font("Century Gothic", 12.0!)
        Me.DTPFecha.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.DTPFecha.Location = New System.Drawing.Point(838, 58)
        Me.DTPFecha.Name = "DTPFecha"
        Me.DTPFecha.Size = New System.Drawing.Size(186, 32)
        Me.DTPFecha.TabIndex = 3
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Century Gothic", 12.0!)
        Me.Label2.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Label2.Location = New System.Drawing.Point(753, 63)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(77, 23)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "Fecha:"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label1
        '
        Me.Label1.Font = New System.Drawing.Font("Century Gothic", 12.0!)
        Me.Label1.Image = Global.MotoBox.My.Resources.Resources._359_users
        Me.Label1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Label1.Location = New System.Drawing.Point(12, 63)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(163, 23)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Cliente:"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Panel6
        '
        Me.Panel6.Controls.Add(Me.DataGridViewVenta)
        Me.Panel6.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel6.Location = New System.Drawing.Point(0, 180)
        Me.Panel6.Name = "Panel6"
        Me.Panel6.Size = New System.Drawing.Size(1032, 273)
        Me.Panel6.TabIndex = 3
        '
        'Ventas
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1032, 553)
        Me.Controls.Add(Me.Panel6)
        Me.Controls.Add(Me.Panel5)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.Panel1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "Ventas"
        Me.Text = "Ventas"
        Me.Panel1.ResumeLayout(False)
        Me.Panel2.ResumeLayout(False)
        Me.Panel4.ResumeLayout(False)
        Me.Panel3.ResumeLayout(False)
        CType(Me.DataGridViewVenta, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel5.ResumeLayout(False)
        Me.Panel5.PerformLayout()
        Me.Panel6.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Panel1 As Panel
    Friend WithEvents BtnRemover As Button
    Friend WithEvents BtnCantidad As Button
    Friend WithEvents BtnBuscar As Button
    Friend WithEvents BtnImporte As Button
    Friend WithEvents BtnDesc As Button
    Friend WithEvents BtnCerrar As Button
    Friend WithEvents BtnCliente As Button
    Friend WithEvents Panel2 As Panel
    Friend WithEvents LblTotal As Label
    Friend WithEvents LblDescuento As Label
    Friend WithEvents Panel4 As Panel
    Friend WithEvents Panel3 As Panel
    Friend WithEvents DataGridViewVenta As DataGridView
    Friend WithEvents Cant As DataGridViewTextBoxColumn
    Friend WithEvents Clave As DataGridViewTextBoxColumn
    Friend WithEvents Descripcion As DataGridViewTextBoxColumn
    Friend WithEvents Exist As DataGridViewTextBoxColumn
    Friend WithEvents Desc As DataGridViewTextBoxColumn
    Friend WithEvents PrecioU As DataGridViewTextBoxColumn
    Friend WithEvents Importe As DataGridViewTextBoxColumn
    Friend WithEvents Panel5 As Panel
    Friend WithEvents Panel6 As Panel
    Friend WithEvents Label1 As Label
    Friend WithEvents DTPFecha As DateTimePicker
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents TxtId As TextBox
    Friend WithEvents Button1 As Button
    Friend WithEvents TxtCodigoBarras As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents TxtIdCliente As TextBox
    Friend WithEvents TxtCliente As TextBox
End Class
