<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Articulos
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.BtnEliminar = New System.Windows.Forms.Button()
        Me.BtnEditar = New System.Windows.Forms.Button()
        Me.BtnAgregar = New System.Windows.Forms.Button()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.DataGridViewArticulos = New System.Windows.Forms.DataGridView()
        Me.ArtidDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ClaveDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ClaveAlternaDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DescripcionDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ServicioDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.InvMinDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.InvMaxDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.PrecioCompraDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.PrecioCompraPromDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Precio1DataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ExistenciaDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.CaracteristicasDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.StatusDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ArticuloBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Taller_refaccionariaDataSet = New MotoBox.taller_refaccionariaDataSet()
        Me.SqlConnection1 = New System.Data.SqlClient.SqlConnection()
        Me.ArticuloTableAdapter = New MotoBox.taller_refaccionariaDataSetTableAdapters.articuloTableAdapter()
        Me.Panel1.SuspendLayout()
        Me.Panel2.SuspendLayout()
        CType(Me.DataGridViewArticulos, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ArticuloBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Taller_refaccionariaDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.FromArgb(CType(CType(32, Byte), Integer), CType(CType(43, Byte), Integer), CType(CType(76, Byte), Integer))
        Me.Panel1.Controls.Add(Me.BtnEliminar)
        Me.Panel1.Controls.Add(Me.BtnEditar)
        Me.Panel1.Controls.Add(Me.BtnAgregar)
        Me.Panel1.Controls.Add(Me.Label4)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(1032, 50)
        Me.Panel1.TabIndex = 0
        '
        'BtnEliminar
        '
        Me.BtnEliminar.BackColor = System.Drawing.Color.FromArgb(CType(CType(32, Byte), Integer), CType(CType(43, Byte), Integer), CType(CType(76, Byte), Integer))
        Me.BtnEliminar.FlatAppearance.BorderSize = 0
        Me.BtnEliminar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnEliminar.Font = New System.Drawing.Font("Century Gothic", 12.0!)
        Me.BtnEliminar.ForeColor = System.Drawing.Color.White
        Me.BtnEliminar.Image = Global.MotoBox.My.Resources.Resources._276_trash
        Me.BtnEliminar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.BtnEliminar.Location = New System.Drawing.Point(308, 0)
        Me.BtnEliminar.Name = "BtnEliminar"
        Me.BtnEliminar.Padding = New System.Windows.Forms.Padding(5, 0, 0, 0)
        Me.BtnEliminar.Size = New System.Drawing.Size(158, 50)
        Me.BtnEliminar.TabIndex = 9
        Me.BtnEliminar.Text = "       Eliminar"
        Me.BtnEliminar.UseVisualStyleBackColor = False
        '
        'BtnEditar
        '
        Me.BtnEditar.BackColor = System.Drawing.Color.FromArgb(CType(CType(32, Byte), Integer), CType(CType(43, Byte), Integer), CType(CType(76, Byte), Integer))
        Me.BtnEditar.FlatAppearance.BorderSize = 0
        Me.BtnEditar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnEditar.Font = New System.Drawing.Font("Century Gothic", 12.0!)
        Me.BtnEditar.ForeColor = System.Drawing.Color.White
        Me.BtnEditar.Image = Global.MotoBox.My.Resources.Resources._279_edit
        Me.BtnEditar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.BtnEditar.Location = New System.Drawing.Point(154, 0)
        Me.BtnEditar.Name = "BtnEditar"
        Me.BtnEditar.Padding = New System.Windows.Forms.Padding(5, 0, 0, 0)
        Me.BtnEditar.Size = New System.Drawing.Size(158, 50)
        Me.BtnEditar.TabIndex = 8
        Me.BtnEditar.Text = "    Editar"
        Me.BtnEditar.UseVisualStyleBackColor = False
        '
        'BtnAgregar
        '
        Me.BtnAgregar.BackColor = System.Drawing.Color.FromArgb(CType(CType(32, Byte), Integer), CType(CType(43, Byte), Integer), CType(CType(76, Byte), Integer))
        Me.BtnAgregar.FlatAppearance.BorderSize = 0
        Me.BtnAgregar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnAgregar.Font = New System.Drawing.Font("Century Gothic", 12.0!)
        Me.BtnAgregar.ForeColor = System.Drawing.Color.White
        Me.BtnAgregar.Image = Global.MotoBox.My.Resources.Resources._323_add
        Me.BtnAgregar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.BtnAgregar.Location = New System.Drawing.Point(0, 0)
        Me.BtnAgregar.Name = "BtnAgregar"
        Me.BtnAgregar.Padding = New System.Windows.Forms.Padding(5, 0, 0, 0)
        Me.BtnAgregar.Size = New System.Drawing.Size(158, 50)
        Me.BtnAgregar.TabIndex = 7
        Me.BtnAgregar.Text = "       Agregar"
        Me.BtnAgregar.UseVisualStyleBackColor = False
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.BackColor = System.Drawing.Color.FromArgb(CType(CType(32, Byte), Integer), CType(CType(43, Byte), Integer), CType(CType(76, Byte), Integer))
        Me.Label4.Font = New System.Drawing.Font("Century Gothic", 18.0!)
        Me.Label4.ForeColor = System.Drawing.Color.White
        Me.Label4.Location = New System.Drawing.Point(844, 9)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(176, 37)
        Me.Label4.TabIndex = 6
        Me.Label4.Text = "ARTICULOS"
        '
        'Panel2
        '
        Me.Panel2.Controls.Add(Me.DataGridViewArticulos)
        Me.Panel2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel2.Location = New System.Drawing.Point(0, 50)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(1032, 503)
        Me.Panel2.TabIndex = 1
        '
        'DataGridViewArticulos
        '
        Me.DataGridViewArticulos.AllowUserToAddRows = False
        Me.DataGridViewArticulos.AllowUserToDeleteRows = False
        Me.DataGridViewArticulos.AutoGenerateColumns = False
        Me.DataGridViewArticulos.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.DataGridViewArticulos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridViewArticulos.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.ArtidDataGridViewTextBoxColumn, Me.ClaveDataGridViewTextBoxColumn, Me.ClaveAlternaDataGridViewTextBoxColumn, Me.DescripcionDataGridViewTextBoxColumn, Me.ServicioDataGridViewTextBoxColumn, Me.InvMinDataGridViewTextBoxColumn, Me.InvMaxDataGridViewTextBoxColumn, Me.PrecioCompraDataGridViewTextBoxColumn, Me.PrecioCompraPromDataGridViewTextBoxColumn, Me.Precio1DataGridViewTextBoxColumn, Me.ExistenciaDataGridViewTextBoxColumn, Me.CaracteristicasDataGridViewTextBoxColumn, Me.StatusDataGridViewTextBoxColumn})
        Me.DataGridViewArticulos.DataSource = Me.ArticuloBindingSource
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle1.BackColor = System.Drawing.Color.White
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.DataGridViewArticulos.DefaultCellStyle = DataGridViewCellStyle1
        Me.DataGridViewArticulos.Dock = System.Windows.Forms.DockStyle.Fill
        Me.DataGridViewArticulos.GridColor = System.Drawing.Color.White
        Me.DataGridViewArticulos.Location = New System.Drawing.Point(0, 0)
        Me.DataGridViewArticulos.Name = "DataGridViewArticulos"
        Me.DataGridViewArticulos.RowHeadersWidth = 51
        Me.DataGridViewArticulos.RowTemplate.Height = 24
        Me.DataGridViewArticulos.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.DataGridViewArticulos.Size = New System.Drawing.Size(1032, 503)
        Me.DataGridViewArticulos.TabIndex = 0
        '
        'ArtidDataGridViewTextBoxColumn
        '
        Me.ArtidDataGridViewTextBoxColumn.DataPropertyName = "art_id"
        Me.ArtidDataGridViewTextBoxColumn.HeaderText = "art_id"
        Me.ArtidDataGridViewTextBoxColumn.MinimumWidth = 6
        Me.ArtidDataGridViewTextBoxColumn.Name = "ArtidDataGridViewTextBoxColumn"
        '
        'ClaveDataGridViewTextBoxColumn
        '
        Me.ClaveDataGridViewTextBoxColumn.DataPropertyName = "clave"
        Me.ClaveDataGridViewTextBoxColumn.HeaderText = "clave"
        Me.ClaveDataGridViewTextBoxColumn.MinimumWidth = 6
        Me.ClaveDataGridViewTextBoxColumn.Name = "ClaveDataGridViewTextBoxColumn"
        '
        'ClaveAlternaDataGridViewTextBoxColumn
        '
        Me.ClaveAlternaDataGridViewTextBoxColumn.DataPropertyName = "claveAlterna"
        Me.ClaveAlternaDataGridViewTextBoxColumn.HeaderText = "claveAlterna"
        Me.ClaveAlternaDataGridViewTextBoxColumn.MinimumWidth = 6
        Me.ClaveAlternaDataGridViewTextBoxColumn.Name = "ClaveAlternaDataGridViewTextBoxColumn"
        '
        'DescripcionDataGridViewTextBoxColumn
        '
        Me.DescripcionDataGridViewTextBoxColumn.DataPropertyName = "descripcion"
        Me.DescripcionDataGridViewTextBoxColumn.HeaderText = "descripcion"
        Me.DescripcionDataGridViewTextBoxColumn.MinimumWidth = 6
        Me.DescripcionDataGridViewTextBoxColumn.Name = "DescripcionDataGridViewTextBoxColumn"
        '
        'ServicioDataGridViewTextBoxColumn
        '
        Me.ServicioDataGridViewTextBoxColumn.DataPropertyName = "servicio"
        Me.ServicioDataGridViewTextBoxColumn.HeaderText = "servicio"
        Me.ServicioDataGridViewTextBoxColumn.MinimumWidth = 6
        Me.ServicioDataGridViewTextBoxColumn.Name = "ServicioDataGridViewTextBoxColumn"
        '
        'InvMinDataGridViewTextBoxColumn
        '
        Me.InvMinDataGridViewTextBoxColumn.DataPropertyName = "invMin"
        Me.InvMinDataGridViewTextBoxColumn.HeaderText = "invMin"
        Me.InvMinDataGridViewTextBoxColumn.MinimumWidth = 6
        Me.InvMinDataGridViewTextBoxColumn.Name = "InvMinDataGridViewTextBoxColumn"
        '
        'InvMaxDataGridViewTextBoxColumn
        '
        Me.InvMaxDataGridViewTextBoxColumn.DataPropertyName = "invMax"
        Me.InvMaxDataGridViewTextBoxColumn.HeaderText = "invMax"
        Me.InvMaxDataGridViewTextBoxColumn.MinimumWidth = 6
        Me.InvMaxDataGridViewTextBoxColumn.Name = "InvMaxDataGridViewTextBoxColumn"
        '
        'PrecioCompraDataGridViewTextBoxColumn
        '
        Me.PrecioCompraDataGridViewTextBoxColumn.DataPropertyName = "precioCompra"
        Me.PrecioCompraDataGridViewTextBoxColumn.HeaderText = "precioCompra"
        Me.PrecioCompraDataGridViewTextBoxColumn.MinimumWidth = 6
        Me.PrecioCompraDataGridViewTextBoxColumn.Name = "PrecioCompraDataGridViewTextBoxColumn"
        '
        'PrecioCompraPromDataGridViewTextBoxColumn
        '
        Me.PrecioCompraPromDataGridViewTextBoxColumn.DataPropertyName = "precioCompraProm"
        Me.PrecioCompraPromDataGridViewTextBoxColumn.HeaderText = "precioCompraProm"
        Me.PrecioCompraPromDataGridViewTextBoxColumn.MinimumWidth = 6
        Me.PrecioCompraPromDataGridViewTextBoxColumn.Name = "PrecioCompraPromDataGridViewTextBoxColumn"
        '
        'Precio1DataGridViewTextBoxColumn
        '
        Me.Precio1DataGridViewTextBoxColumn.DataPropertyName = "precio1"
        Me.Precio1DataGridViewTextBoxColumn.HeaderText = "precio1"
        Me.Precio1DataGridViewTextBoxColumn.MinimumWidth = 6
        Me.Precio1DataGridViewTextBoxColumn.Name = "Precio1DataGridViewTextBoxColumn"
        '
        'ExistenciaDataGridViewTextBoxColumn
        '
        Me.ExistenciaDataGridViewTextBoxColumn.DataPropertyName = "existencia"
        Me.ExistenciaDataGridViewTextBoxColumn.HeaderText = "existencia"
        Me.ExistenciaDataGridViewTextBoxColumn.MinimumWidth = 6
        Me.ExistenciaDataGridViewTextBoxColumn.Name = "ExistenciaDataGridViewTextBoxColumn"
        '
        'CaracteristicasDataGridViewTextBoxColumn
        '
        Me.CaracteristicasDataGridViewTextBoxColumn.DataPropertyName = "caracteristicas"
        Me.CaracteristicasDataGridViewTextBoxColumn.HeaderText = "caracteristicas"
        Me.CaracteristicasDataGridViewTextBoxColumn.MinimumWidth = 6
        Me.CaracteristicasDataGridViewTextBoxColumn.Name = "CaracteristicasDataGridViewTextBoxColumn"
        '
        'StatusDataGridViewTextBoxColumn
        '
        Me.StatusDataGridViewTextBoxColumn.DataPropertyName = "status"
        Me.StatusDataGridViewTextBoxColumn.HeaderText = "status"
        Me.StatusDataGridViewTextBoxColumn.MinimumWidth = 6
        Me.StatusDataGridViewTextBoxColumn.Name = "StatusDataGridViewTextBoxColumn"
        '
        'ArticuloBindingSource
        '
        Me.ArticuloBindingSource.DataMember = "articulo"
        Me.ArticuloBindingSource.DataSource = Me.Taller_refaccionariaDataSet
        '
        'Taller_refaccionariaDataSet
        '
        Me.Taller_refaccionariaDataSet.DataSetName = "taller_refaccionariaDataSet"
        Me.Taller_refaccionariaDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'SqlConnection1
        '
        Me.SqlConnection1.ConnectionString = "Data Source=PIER18;Initial Catalog=taller_refaccionaria;Integrated Security=True"
        Me.SqlConnection1.FireInfoMessageEventOnUserErrors = False
        '
        'ArticuloTableAdapter
        '
        Me.ArticuloTableAdapter.ClearBeforeFill = True
        '
        'Articulos
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1032, 553)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.Panel1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "Articulos"
        Me.Text = "Articulos"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.Panel2.ResumeLayout(False)
        CType(Me.DataGridViewArticulos, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ArticuloBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Taller_refaccionariaDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Panel1 As Panel
    Friend WithEvents Label4 As Label
    Friend WithEvents Panel2 As Panel
    Friend WithEvents DataGridViewArticulos As DataGridView
    Friend WithEvents Taller_refaccionariaDataSet As taller_refaccionariaDataSet
    Friend WithEvents ArticuloBindingSource As BindingSource
    Friend WithEvents ArticuloTableAdapter As taller_refaccionariaDataSetTableAdapters.articuloTableAdapter
    Friend WithEvents BtnAgregar As Button
    Friend WithEvents BtnEditar As Button
    Friend WithEvents BtnEliminar As Button
    Friend WithEvents SqlConnection1 As SqlClient.SqlConnection
    Friend WithEvents ArtidDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents ClaveDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents ClaveAlternaDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents DescripcionDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents ServicioDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents InvMinDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents InvMaxDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents PrecioCompraDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents PrecioCompraPromDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents Precio1DataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents ExistenciaDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents CaracteristicasDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents StatusDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
End Class
