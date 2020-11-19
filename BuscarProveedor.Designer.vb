<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class BuscarProveedor
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
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.DataGridViewProveedores = New System.Windows.Forms.DataGridView()
        Me.IDDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.NombreDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.AliasDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.TelDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.CelDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ShowActiveProvidersBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Taller_refaccionariaDataSet = New MotoBox.taller_refaccionariaDataSet()
        Me.ShowActiveProvidersTableAdapter = New MotoBox.taller_refaccionariaDataSetTableAdapters.showActiveProvidersTableAdapter()
        Me.Panel1.SuspendLayout()
        Me.Panel2.SuspendLayout()
        CType(Me.DataGridViewProveedores, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ShowActiveProvidersBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
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
        Me.Panel1.Margin = New System.Windows.Forms.Padding(2)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(600, 41)
        Me.Panel1.TabIndex = 2
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
        Me.Label1.Location = New System.Drawing.Point(208, 11)
        Me.Label1.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(184, 21)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Seleccionar Proveedor"
        '
        'Panel2
        '
        Me.Panel2.Controls.Add(Me.Button2)
        Me.Panel2.Controls.Add(Me.TextBox1)
        Me.Panel2.Controls.Add(Me.Label4)
        Me.Panel2.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel2.Location = New System.Drawing.Point(0, 41)
        Me.Panel2.Margin = New System.Windows.Forms.Padding(2)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(600, 57)
        Me.Panel2.TabIndex = 3
        '
        'Button2
        '
        Me.Button2.Enabled = False
        Me.Button2.Font = New System.Drawing.Font("Century Gothic", 11.0!, System.Drawing.FontStyle.Bold)
        Me.Button2.Image = Global.MotoBox.My.Resources.Resources._323_add
        Me.Button2.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Button2.Location = New System.Drawing.Point(479, 13)
        Me.Button2.Margin = New System.Windows.Forms.Padding(2)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(110, 32)
        Me.Button2.TabIndex = 10
        Me.Button2.Text = "Agregar"
        Me.Button2.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.Button2.UseVisualStyleBackColor = True
        '
        'TextBox1
        '
        Me.TextBox1.Font = New System.Drawing.Font("Century Gothic", 12.0!)
        Me.TextBox1.Location = New System.Drawing.Point(106, 15)
        Me.TextBox1.Margin = New System.Windows.Forms.Padding(2)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(369, 27)
        Me.TextBox1.TabIndex = 9
        '
        'Label4
        '
        Me.Label4.Font = New System.Drawing.Font("Century Gothic", 12.0!)
        Me.Label4.Image = Global.MotoBox.My.Resources.Resources._313_search
        Me.Label4.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Label4.Location = New System.Drawing.Point(9, 15)
        Me.Label4.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(111, 27)
        Me.Label4.TabIndex = 8
        Me.Label4.Text = "Buscar:"
        Me.Label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'DataGridViewProveedores
        '
        Me.DataGridViewProveedores.AllowUserToAddRows = False
        Me.DataGridViewProveedores.AllowUserToDeleteRows = False
        Me.DataGridViewProveedores.AutoGenerateColumns = False
        Me.DataGridViewProveedores.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.DataGridViewProveedores.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridViewProveedores.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.IDDataGridViewTextBoxColumn, Me.NombreDataGridViewTextBoxColumn, Me.AliasDataGridViewTextBoxColumn, Me.TelDataGridViewTextBoxColumn, Me.CelDataGridViewTextBoxColumn})
        Me.DataGridViewProveedores.DataSource = Me.ShowActiveProvidersBindingSource
        Me.DataGridViewProveedores.Dock = System.Windows.Forms.DockStyle.Fill
        Me.DataGridViewProveedores.Location = New System.Drawing.Point(0, 98)
        Me.DataGridViewProveedores.Name = "DataGridViewProveedores"
        Me.DataGridViewProveedores.ReadOnly = True
        Me.DataGridViewProveedores.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.DataGridViewProveedores.Size = New System.Drawing.Size(600, 268)
        Me.DataGridViewProveedores.TabIndex = 4
        '
        'IDDataGridViewTextBoxColumn
        '
        Me.IDDataGridViewTextBoxColumn.DataPropertyName = "ID"
        Me.IDDataGridViewTextBoxColumn.HeaderText = "No. Prov"
        Me.IDDataGridViewTextBoxColumn.Name = "IDDataGridViewTextBoxColumn"
        Me.IDDataGridViewTextBoxColumn.ReadOnly = True
        '
        'NombreDataGridViewTextBoxColumn
        '
        Me.NombreDataGridViewTextBoxColumn.DataPropertyName = "Nombre"
        Me.NombreDataGridViewTextBoxColumn.HeaderText = "Nombre"
        Me.NombreDataGridViewTextBoxColumn.Name = "NombreDataGridViewTextBoxColumn"
        Me.NombreDataGridViewTextBoxColumn.ReadOnly = True
        '
        'AliasDataGridViewTextBoxColumn
        '
        Me.AliasDataGridViewTextBoxColumn.DataPropertyName = "Alias"
        Me.AliasDataGridViewTextBoxColumn.HeaderText = "Alias"
        Me.AliasDataGridViewTextBoxColumn.Name = "AliasDataGridViewTextBoxColumn"
        Me.AliasDataGridViewTextBoxColumn.ReadOnly = True
        '
        'TelDataGridViewTextBoxColumn
        '
        Me.TelDataGridViewTextBoxColumn.DataPropertyName = "Tel"
        Me.TelDataGridViewTextBoxColumn.HeaderText = "Teléfono"
        Me.TelDataGridViewTextBoxColumn.Name = "TelDataGridViewTextBoxColumn"
        Me.TelDataGridViewTextBoxColumn.ReadOnly = True
        '
        'CelDataGridViewTextBoxColumn
        '
        Me.CelDataGridViewTextBoxColumn.DataPropertyName = "Cel"
        Me.CelDataGridViewTextBoxColumn.HeaderText = "Celular"
        Me.CelDataGridViewTextBoxColumn.Name = "CelDataGridViewTextBoxColumn"
        Me.CelDataGridViewTextBoxColumn.ReadOnly = True
        '
        'ShowActiveProvidersBindingSource
        '
        Me.ShowActiveProvidersBindingSource.DataMember = "showActiveProviders"
        Me.ShowActiveProvidersBindingSource.DataSource = Me.Taller_refaccionariaDataSet
        '
        'Taller_refaccionariaDataSet
        '
        Me.Taller_refaccionariaDataSet.DataSetName = "taller_refaccionariaDataSet"
        Me.Taller_refaccionariaDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'ShowActiveProvidersTableAdapter
        '
        Me.ShowActiveProvidersTableAdapter.ClearBeforeFill = True
        '
        'BuscarProveedor
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(600, 366)
        Me.Controls.Add(Me.DataGridViewProveedores)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.Panel1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "BuscarProveedor"
        Me.Text = "BuscarProveedor"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        CType(Me.DataGridViewProveedores, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ShowActiveProvidersBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Taller_refaccionariaDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Panel1 As Panel
    Friend WithEvents Button1 As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents Panel2 As Panel
    Friend WithEvents Button2 As Button
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents DataGridViewProveedores As DataGridView
    Friend WithEvents Taller_refaccionariaDataSet As taller_refaccionariaDataSet
    Friend WithEvents ShowActiveProvidersBindingSource As BindingSource
    Friend WithEvents ShowActiveProvidersTableAdapter As taller_refaccionariaDataSetTableAdapters.showActiveProvidersTableAdapter
    Friend WithEvents IDDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents NombreDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents AliasDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents TelDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents CelDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
End Class
