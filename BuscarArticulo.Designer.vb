<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class BuscarArticulo
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
        Me.components = New System.ComponentModel.Container()
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle4 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.DataGridViewArticulos = New System.Windows.Forms.DataGridView()
        Me.ClaveDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DescripcionDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ExistDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.PrecioDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ShowActiveItemsBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Taller_refaccionariaDataSet = New MotoBox.taller_refaccionariaDataSet()
        Me.ShowActiveItemsTableAdapter = New MotoBox.taller_refaccionariaDataSetTableAdapters.showActiveItemsTableAdapter()
        Me.Panel1.SuspendLayout()
        Me.Panel2.SuspendLayout()
        CType(Me.DataGridViewArticulos, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ShowActiveItemsBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Taller_refaccionariaDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.FromArgb(CType(CType(32, Byte), Integer), CType(CType(43, Byte), Integer), CType(CType(76, Byte), Integer))
        Me.Panel1.Controls.Add(Me.Button1)
        Me.Panel1.Controls.Add(Me.Label1)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(800, 50)
        Me.Panel1.TabIndex = 0
        '
        'Button1
        '
        Me.Button1.BackgroundImage = Global.MotoBox.My.Resources.Resources._084_multiply
        Me.Button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.Button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button1.Location = New System.Drawing.Point(750, 0)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(50, 50)
        Me.Button1.TabIndex = 1
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Century Gothic", 12.0!)
        Me.Label1.ForeColor = System.Drawing.Color.WhiteSmoke
        Me.Label1.Location = New System.Drawing.Point(322, 14)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(156, 23)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Buscar Artículo"
        '
        'Panel2
        '
        Me.Panel2.Controls.Add(Me.Button3)
        Me.Panel2.Controls.Add(Me.Button2)
        Me.Panel2.Controls.Add(Me.TextBox1)
        Me.Panel2.Controls.Add(Me.Label4)
        Me.Panel2.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel2.Location = New System.Drawing.Point(0, 50)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(800, 70)
        Me.Panel2.TabIndex = 1
        '
        'Button3
        '
        Me.Button3.Font = New System.Drawing.Font("Century Gothic", 11.0!, System.Drawing.FontStyle.Bold)
        Me.Button3.Image = Global.MotoBox.My.Resources.Resources._279_edit
        Me.Button3.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Button3.Location = New System.Drawing.Point(679, 15)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(109, 40)
        Me.Button3.TabIndex = 11
        Me.Button3.Text = "Editar"
        Me.Button3.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.Button3.UseVisualStyleBackColor = True
        '
        'Button2
        '
        Me.Button2.Font = New System.Drawing.Font("Century Gothic", 11.0!, System.Drawing.FontStyle.Bold)
        Me.Button2.Image = Global.MotoBox.My.Resources.Resources._323_add
        Me.Button2.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Button2.Location = New System.Drawing.Point(526, 15)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(147, 40)
        Me.Button2.TabIndex = 10
        Me.Button2.Text = "Agregar"
        Me.Button2.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.Button2.UseVisualStyleBackColor = True
        '
        'TextBox1
        '
        Me.TextBox1.Font = New System.Drawing.Font("Century Gothic", 12.0!)
        Me.TextBox1.Location = New System.Drawing.Point(142, 19)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(378, 32)
        Me.TextBox1.TabIndex = 9
        '
        'Label4
        '
        Me.Label4.Font = New System.Drawing.Font("Century Gothic", 12.0!)
        Me.Label4.Image = Global.MotoBox.My.Resources.Resources._313_search
        Me.Label4.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Label4.Location = New System.Drawing.Point(12, 19)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(148, 33)
        Me.Label4.TabIndex = 8
        Me.Label4.Text = "Buscar:"
        Me.Label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'DataGridViewArticulos
        '
        Me.DataGridViewArticulos.AllowUserToAddRows = False
        Me.DataGridViewArticulos.AllowUserToDeleteRows = False
        Me.DataGridViewArticulos.AutoGenerateColumns = False
        Me.DataGridViewArticulos.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.DataGridViewArticulos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridViewArticulos.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.ClaveDataGridViewTextBoxColumn, Me.DescripcionDataGridViewTextBoxColumn, Me.ExistDataGridViewTextBoxColumn, Me.PrecioDataGridViewTextBoxColumn})
        Me.DataGridViewArticulos.DataSource = Me.ShowActiveItemsBindingSource
        DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle3.Font = New System.Drawing.Font("Century Gothic", 8.0!)
        DataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.DataGridViewArticulos.DefaultCellStyle = DataGridViewCellStyle3
        Me.DataGridViewArticulos.Dock = System.Windows.Forms.DockStyle.Fill
        Me.DataGridViewArticulos.Location = New System.Drawing.Point(0, 120)
        Me.DataGridViewArticulos.Name = "DataGridViewArticulos"
        Me.DataGridViewArticulos.ReadOnly = True
        DataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle4.Font = New System.Drawing.Font("Century Gothic", 10.0!)
        DataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.DataGridViewArticulos.RowHeadersDefaultCellStyle = DataGridViewCellStyle4
        Me.DataGridViewArticulos.RowHeadersWidth = 51
        Me.DataGridViewArticulos.RowTemplate.Height = 24
        Me.DataGridViewArticulos.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.DataGridViewArticulos.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.DataGridViewArticulos.Size = New System.Drawing.Size(800, 330)
        Me.DataGridViewArticulos.TabIndex = 2
        '
        'ClaveDataGridViewTextBoxColumn
        '
        Me.ClaveDataGridViewTextBoxColumn.DataPropertyName = "Clave"
        Me.ClaveDataGridViewTextBoxColumn.HeaderText = "Clave"
        Me.ClaveDataGridViewTextBoxColumn.MinimumWidth = 6
        Me.ClaveDataGridViewTextBoxColumn.Name = "ClaveDataGridViewTextBoxColumn"
        Me.ClaveDataGridViewTextBoxColumn.ReadOnly = True
        '
        'DescripcionDataGridViewTextBoxColumn
        '
        Me.DescripcionDataGridViewTextBoxColumn.DataPropertyName = "Descripcion"
        Me.DescripcionDataGridViewTextBoxColumn.HeaderText = "Descripcion"
        Me.DescripcionDataGridViewTextBoxColumn.MinimumWidth = 6
        Me.DescripcionDataGridViewTextBoxColumn.Name = "DescripcionDataGridViewTextBoxColumn"
        Me.DescripcionDataGridViewTextBoxColumn.ReadOnly = True
        '
        'ExistDataGridViewTextBoxColumn
        '
        Me.ExistDataGridViewTextBoxColumn.DataPropertyName = "Exist"
        Me.ExistDataGridViewTextBoxColumn.HeaderText = "Exist"
        Me.ExistDataGridViewTextBoxColumn.MinimumWidth = 6
        Me.ExistDataGridViewTextBoxColumn.Name = "ExistDataGridViewTextBoxColumn"
        Me.ExistDataGridViewTextBoxColumn.ReadOnly = True
        '
        'PrecioDataGridViewTextBoxColumn
        '
        Me.PrecioDataGridViewTextBoxColumn.DataPropertyName = "Precio"
        Me.PrecioDataGridViewTextBoxColumn.HeaderText = "Precio"
        Me.PrecioDataGridViewTextBoxColumn.MinimumWidth = 6
        Me.PrecioDataGridViewTextBoxColumn.Name = "PrecioDataGridViewTextBoxColumn"
        Me.PrecioDataGridViewTextBoxColumn.ReadOnly = True
        '
        'ShowActiveItemsBindingSource
        '
        Me.ShowActiveItemsBindingSource.DataMember = "showActiveItems"
        Me.ShowActiveItemsBindingSource.DataSource = Me.Taller_refaccionariaDataSet
        '
        'Taller_refaccionariaDataSet
        '
        Me.Taller_refaccionariaDataSet.DataSetName = "taller_refaccionariaDataSet"
        Me.Taller_refaccionariaDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'ShowActiveItemsTableAdapter
        '
        Me.ShowActiveItemsTableAdapter.ClearBeforeFill = True
        '
        'BuscarArticulo
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.DataGridViewArticulos)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.Panel1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "BuscarArticulo"
        Me.Text = "BuscarArticulo"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        CType(Me.DataGridViewArticulos, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ShowActiveItemsBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Taller_refaccionariaDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Panel1 As Panel
    Friend WithEvents Label1 As Label
    Friend WithEvents Panel2 As Panel
    Friend WithEvents Button1 As Button
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents Button3 As Button
    Friend WithEvents Button2 As Button
    Friend WithEvents DataGridViewArticulos As DataGridView
    Friend WithEvents Taller_refaccionariaDataSet As taller_refaccionariaDataSet
    Friend WithEvents ShowActiveItemsBindingSource As BindingSource
    Friend WithEvents ShowActiveItemsTableAdapter As taller_refaccionariaDataSetTableAdapters.showActiveItemsTableAdapter
    Friend WithEvents ClaveDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents DescripcionDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents ExistDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents PrecioDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
End Class
