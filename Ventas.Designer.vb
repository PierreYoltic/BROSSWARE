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
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.BtnCerrar = New System.Windows.Forms.Button()
        Me.BtnCliente = New System.Windows.Forms.Button()
        Me.BtnRemover = New System.Windows.Forms.Button()
        Me.BtnCantidad = New System.Windows.Forms.Button()
        Me.BtnBuscar = New System.Windows.Forms.Button()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.LblTotal = New System.Windows.Forms.Label()
        Me.DataGridViewVenta = New System.Windows.Forms.DataGridView()
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
        Me.Importe = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.PrecioU = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Exist = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Descripcion = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.servicio = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Clave = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Cant = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.BtnImporte = New System.Windows.Forms.Button()
        Me.BtnDesc = New System.Windows.Forms.Button()
        Me.LblDescuento = New System.Windows.Forms.Label()
        Me.Panel4 = New System.Windows.Forms.Panel()
        Me.LblSubtotal = New System.Windows.Forms.Label()
        Me.Panel7 = New System.Windows.Forms.Panel()
        Me.Panel1.SuspendLayout()
        Me.Panel2.SuspendLayout()
        Me.Panel3.SuspendLayout()
        CType(Me.DataGridViewVenta, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel5.SuspendLayout()
        Me.Panel6.SuspendLayout()
        Me.Panel4.SuspendLayout()
        Me.Panel7.SuspendLayout()
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
        Me.Panel1.Margin = New System.Windows.Forms.Padding(2)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(774, 65)
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
        Me.BtnCerrar.Location = New System.Drawing.Point(529, 0)
        Me.BtnCerrar.Margin = New System.Windows.Forms.Padding(2)
        Me.BtnCerrar.Name = "BtnCerrar"
        Me.BtnCerrar.Padding = New System.Windows.Forms.Padding(0, 4, 0, 4)
        Me.BtnCerrar.Size = New System.Drawing.Size(88, 65)
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
        Me.BtnCliente.Location = New System.Drawing.Point(441, 0)
        Me.BtnCliente.Margin = New System.Windows.Forms.Padding(2)
        Me.BtnCliente.Name = "BtnCliente"
        Me.BtnCliente.Padding = New System.Windows.Forms.Padding(0, 4, 0, 4)
        Me.BtnCliente.Size = New System.Drawing.Size(88, 65)
        Me.BtnCliente.TabIndex = 6
        Me.BtnCliente.Text = "Cliente"
        Me.BtnCliente.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.BtnCliente.UseVisualStyleBackColor = True
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
        'BtnCantidad
        '
        Me.BtnCantidad.FlatAppearance.BorderSize = 0
        Me.BtnCantidad.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnCantidad.Font = New System.Drawing.Font("Century Gothic", 7.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnCantidad.ForeColor = System.Drawing.Color.White
        Me.BtnCantidad.Image = Global.MotoBox.My.Resources.Resources._079_calculator
        Me.BtnCantidad.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.BtnCantidad.Location = New System.Drawing.Point(90, 0)
        Me.BtnCantidad.Margin = New System.Windows.Forms.Padding(2)
        Me.BtnCantidad.Name = "BtnCantidad"
        Me.BtnCantidad.Padding = New System.Windows.Forms.Padding(0, 4, 0, 4)
        Me.BtnCantidad.Size = New System.Drawing.Size(88, 65)
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
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.SystemColors.ControlDarkDark
        Me.Panel2.Controls.Add(Me.Panel7)
        Me.Panel2.Controls.Add(Me.Panel4)
        Me.Panel2.Controls.Add(Me.Panel3)
        Me.Panel2.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.Panel2.Location = New System.Drawing.Point(0, 339)
        Me.Panel2.Margin = New System.Windows.Forms.Padding(2)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(774, 110)
        Me.Panel2.TabIndex = 1
        '
        'Panel3
        '
        Me.Panel3.Controls.Add(Me.LblTotal)
        Me.Panel3.Location = New System.Drawing.Point(531, 76)
        Me.Panel3.Margin = New System.Windows.Forms.Padding(2)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(243, 38)
        Me.Panel3.TabIndex = 2
        '
        'LblTotal
        '
        Me.LblTotal.Font = New System.Drawing.Font("Century Gothic", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblTotal.ForeColor = System.Drawing.Color.WhiteSmoke
        Me.LblTotal.Location = New System.Drawing.Point(4, 4)
        Me.LblTotal.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.LblTotal.Name = "LblTotal"
        Me.LblTotal.Size = New System.Drawing.Size(236, 30)
        Me.LblTotal.TabIndex = 0
        Me.LblTotal.Text = "Total: $0.00 MXN"
        Me.LblTotal.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'DataGridViewVenta
        '
        Me.DataGridViewVenta.AllowUserToAddRows = False
        Me.DataGridViewVenta.AllowUserToDeleteRows = False
        Me.DataGridViewVenta.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.DataGridViewVenta.BackgroundColor = System.Drawing.SystemColors.ControlLight
        Me.DataGridViewVenta.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridViewVenta.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Cant, Me.Clave, Me.servicio, Me.Descripcion, Me.Exist, Me.PrecioU, Me.Importe})
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Century Gothic", 10.0!)
        DataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.DataGridViewVenta.DefaultCellStyle = DataGridViewCellStyle1
        Me.DataGridViewVenta.Dock = System.Windows.Forms.DockStyle.Fill
        Me.DataGridViewVenta.Location = New System.Drawing.Point(0, 0)
        Me.DataGridViewVenta.Margin = New System.Windows.Forms.Padding(2)
        Me.DataGridViewVenta.Name = "DataGridViewVenta"
        Me.DataGridViewVenta.ReadOnly = True
        Me.DataGridViewVenta.RowHeadersWidth = 51
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Century Gothic", 12.0!)
        Me.DataGridViewVenta.RowsDefaultCellStyle = DataGridViewCellStyle2
        Me.DataGridViewVenta.RowTemplate.Height = 24
        Me.DataGridViewVenta.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.DataGridViewVenta.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.DataGridViewVenta.Size = New System.Drawing.Size(774, 193)
        Me.DataGridViewVenta.TabIndex = 0
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
        Me.Panel5.Location = New System.Drawing.Point(0, 65)
        Me.Panel5.Margin = New System.Windows.Forms.Padding(2)
        Me.Panel5.Name = "Panel5"
        Me.Panel5.Size = New System.Drawing.Size(774, 81)
        Me.Panel5.TabIndex = 2
        '
        'TxtIdCliente
        '
        Me.TxtIdCliente.Location = New System.Drawing.Point(432, 53)
        Me.TxtIdCliente.Margin = New System.Windows.Forms.Padding(2)
        Me.TxtIdCliente.Name = "TxtIdCliente"
        Me.TxtIdCliente.ReadOnly = True
        Me.TxtIdCliente.Size = New System.Drawing.Size(56, 20)
        Me.TxtIdCliente.TabIndex = 13
        Me.TxtIdCliente.Text = "1"
        '
        'TxtCliente
        '
        Me.TxtCliente.Location = New System.Drawing.Point(109, 54)
        Me.TxtCliente.Margin = New System.Windows.Forms.Padding(2)
        Me.TxtCliente.Name = "TxtCliente"
        Me.TxtCliente.ReadOnly = True
        Me.TxtCliente.Size = New System.Drawing.Size(170, 20)
        Me.TxtCliente.TabIndex = 12
        Me.TxtCliente.Text = "PUBLICO EN GENERAL"
        '
        'Label6
        '
        Me.Label6.Font = New System.Drawing.Font("Century Gothic", 12.0!)
        Me.Label6.Image = Global.MotoBox.My.Resources.Resources._359_users
        Me.Label6.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Label6.Location = New System.Drawing.Point(306, 51)
        Me.Label6.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(122, 19)
        Me.Label6.TabIndex = 9
        Me.Label6.Text = "      ID Cliente:"
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
        Me.TxtId.ReadOnly = True
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
        Me.Label1.Size = New System.Drawing.Size(96, 21)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Cliente:"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Panel6
        '
        Me.Panel6.Controls.Add(Me.DataGridViewVenta)
        Me.Panel6.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel6.Location = New System.Drawing.Point(0, 146)
        Me.Panel6.Margin = New System.Windows.Forms.Padding(2)
        Me.Panel6.Name = "Panel6"
        Me.Panel6.Size = New System.Drawing.Size(774, 193)
        Me.Panel6.TabIndex = 3
        '
        'Importe
        '
        Me.Importe.FillWeight = 86.83296!
        Me.Importe.HeaderText = "Importe"
        Me.Importe.MinimumWidth = 6
        Me.Importe.Name = "Importe"
        Me.Importe.ReadOnly = True
        '
        'PrecioU
        '
        Me.PrecioU.FillWeight = 66.12082!
        Me.PrecioU.HeaderText = "Precio U."
        Me.PrecioU.MinimumWidth = 6
        Me.PrecioU.Name = "PrecioU"
        Me.PrecioU.ReadOnly = True
        '
        'Exist
        '
        Me.Exist.FillWeight = 27.55489!
        Me.Exist.HeaderText = "Exist."
        Me.Exist.MinimumWidth = 6
        Me.Exist.Name = "Exist"
        Me.Exist.ReadOnly = True
        '
        'Descripcion
        '
        Me.Descripcion.FillWeight = 304.4221!
        Me.Descripcion.HeaderText = "Descripción"
        Me.Descripcion.MinimumWidth = 6
        Me.Descripcion.Name = "Descripcion"
        Me.Descripcion.ReadOnly = True
        '
        'servicio
        '
        Me.servicio.HeaderText = "S"
        Me.servicio.Name = "servicio"
        Me.servicio.ReadOnly = True
        '
        'Clave
        '
        Me.Clave.FillWeight = 116.9239!
        Me.Clave.HeaderText = "ID/Código"
        Me.Clave.MinimumWidth = 6
        Me.Clave.Name = "Clave"
        Me.Clave.ReadOnly = True
        '
        'Cant
        '
        Me.Cant.FillWeight = 35.75077!
        Me.Cant.HeaderText = "Cant."
        Me.Cant.MinimumWidth = 6
        Me.Cant.Name = "Cant"
        Me.Cant.ReadOnly = True
        '
        'BtnImporte
        '
        Me.BtnImporte.FlatAppearance.BorderSize = 0
        Me.BtnImporte.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnImporte.Font = New System.Drawing.Font("Century Gothic", 7.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnImporte.ForeColor = System.Drawing.Color.White
        Me.BtnImporte.Image = Global.MotoBox.My.Resources.Resources._020_money_bag
        Me.BtnImporte.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.BtnImporte.Location = New System.Drawing.Point(353, 0)
        Me.BtnImporte.Margin = New System.Windows.Forms.Padding(2)
        Me.BtnImporte.Name = "BtnImporte"
        Me.BtnImporte.Padding = New System.Windows.Forms.Padding(0, 4, 0, 4)
        Me.BtnImporte.Size = New System.Drawing.Size(88, 65)
        Me.BtnImporte.TabIndex = 5
        Me.BtnImporte.Text = "Importe"
        Me.BtnImporte.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.BtnImporte.UseVisualStyleBackColor = True
        '
        'BtnDesc
        '
        Me.BtnDesc.FlatAppearance.BorderSize = 0
        Me.BtnDesc.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnDesc.Font = New System.Drawing.Font("Century Gothic", 7.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnDesc.ForeColor = System.Drawing.Color.White
        Me.BtnDesc.Image = Global.MotoBox.My.Resources.Resources._088_percent
        Me.BtnDesc.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.BtnDesc.Location = New System.Drawing.Point(266, 0)
        Me.BtnDesc.Margin = New System.Windows.Forms.Padding(2)
        Me.BtnDesc.Name = "BtnDesc"
        Me.BtnDesc.Padding = New System.Windows.Forms.Padding(0, 4, 0, 4)
        Me.BtnDesc.Size = New System.Drawing.Size(88, 65)
        Me.BtnDesc.TabIndex = 4
        Me.BtnDesc.Text = "Desc."
        Me.BtnDesc.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.BtnDesc.UseVisualStyleBackColor = True
        '
        'LblDescuento
        '
        Me.LblDescuento.Font = New System.Drawing.Font("Century Gothic", 14.0!, System.Drawing.FontStyle.Bold)
        Me.LblDescuento.ForeColor = System.Drawing.Color.Red
        Me.LblDescuento.Location = New System.Drawing.Point(4, 5)
        Me.LblDescuento.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.LblDescuento.Name = "LblDescuento"
        Me.LblDescuento.Size = New System.Drawing.Size(203, 23)
        Me.LblDescuento.TabIndex = 3
        Me.LblDescuento.Text = "Descuento: $0.00"
        Me.LblDescuento.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Panel4
        '
        Me.Panel4.Controls.Add(Me.LblDescuento)
        Me.Panel4.Location = New System.Drawing.Point(562, 39)
        Me.Panel4.Margin = New System.Windows.Forms.Padding(2)
        Me.Panel4.Name = "Panel4"
        Me.Panel4.Size = New System.Drawing.Size(212, 33)
        Me.Panel4.TabIndex = 5
        '
        'LblSubtotal
        '
        Me.LblSubtotal.Font = New System.Drawing.Font("Century Gothic", 14.0!, System.Drawing.FontStyle.Bold)
        Me.LblSubtotal.ForeColor = System.Drawing.Color.LimeGreen
        Me.LblSubtotal.Location = New System.Drawing.Point(4, 5)
        Me.LblSubtotal.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.LblSubtotal.Name = "LblSubtotal"
        Me.LblSubtotal.Size = New System.Drawing.Size(203, 23)
        Me.LblSubtotal.TabIndex = 3
        Me.LblSubtotal.Text = "Subtotal: $0.00"
        Me.LblSubtotal.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Panel7
        '
        Me.Panel7.Controls.Add(Me.LblSubtotal)
        Me.Panel7.Location = New System.Drawing.Point(562, 2)
        Me.Panel7.Margin = New System.Windows.Forms.Padding(2)
        Me.Panel7.Name = "Panel7"
        Me.Panel7.Size = New System.Drawing.Size(212, 33)
        Me.Panel7.TabIndex = 6
        '
        'Ventas
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(774, 449)
        Me.Controls.Add(Me.Panel6)
        Me.Controls.Add(Me.Panel5)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.Panel1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Margin = New System.Windows.Forms.Padding(2)
        Me.Name = "Ventas"
        Me.Text = "Ventas"
        Me.Panel1.ResumeLayout(False)
        Me.Panel2.ResumeLayout(False)
        Me.Panel3.ResumeLayout(False)
        CType(Me.DataGridViewVenta, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel5.ResumeLayout(False)
        Me.Panel5.PerformLayout()
        Me.Panel6.ResumeLayout(False)
        Me.Panel4.ResumeLayout(False)
        Me.Panel7.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Panel1 As Panel
    Friend WithEvents BtnRemover As Button
    Friend WithEvents BtnCantidad As Button
    Friend WithEvents BtnBuscar As Button
    Friend WithEvents BtnCerrar As Button
    Friend WithEvents BtnCliente As Button
    Friend WithEvents Panel2 As Panel
    Friend WithEvents LblTotal As Label
    Friend WithEvents Panel3 As Panel
    Friend WithEvents DataGridViewVenta As DataGridView
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
    Friend WithEvents Cant As DataGridViewTextBoxColumn
    Friend WithEvents Clave As DataGridViewTextBoxColumn
    Friend WithEvents servicio As DataGridViewTextBoxColumn
    Friend WithEvents Descripcion As DataGridViewTextBoxColumn
    Friend WithEvents Exist As DataGridViewTextBoxColumn
    Friend WithEvents PrecioU As DataGridViewTextBoxColumn
    Friend WithEvents Importe As DataGridViewTextBoxColumn
    Friend WithEvents BtnImporte As Button
    Friend WithEvents BtnDesc As Button
    Friend WithEvents Panel7 As Panel
    Friend WithEvents LblSubtotal As Label
    Friend WithEvents Panel4 As Panel
    Friend WithEvents LblDescuento As Label
End Class
