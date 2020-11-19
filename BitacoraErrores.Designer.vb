<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class BitacoraErrores
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
        Me.DataGridViewCompras = New System.Windows.Forms.DataGridView()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Taller_refaccionariaDataSet = New MotoBox.taller_refaccionariaDataSet()
        Me.BitacoradeerroresBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.BitacoradeerroresTableAdapter = New MotoBox.taller_refaccionariaDataSetTableAdapters.bitacoradeerroresTableAdapter()
        Me.IdbitacoraDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.FechaDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.FormularioDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.NumerrorDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DescripcionDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Panel1.SuspendLayout()
        CType(Me.DataGridViewCompras, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Taller_refaccionariaDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BitacoradeerroresBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.FromArgb(CType(CType(27, Byte), Integer), CType(CType(38, Byte), Integer), CType(CType(69, Byte), Integer))
        Me.Panel1.Controls.Add(Me.Label4)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Margin = New System.Windows.Forms.Padding(2)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(774, 65)
        Me.Panel1.TabIndex = 3
        '
        'DataGridViewCompras
        '
        Me.DataGridViewCompras.AutoGenerateColumns = False
        Me.DataGridViewCompras.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.DataGridViewCompras.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridViewCompras.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.IdbitacoraDataGridViewTextBoxColumn, Me.FechaDataGridViewTextBoxColumn, Me.FormularioDataGridViewTextBoxColumn, Me.NumerrorDataGridViewTextBoxColumn, Me.DescripcionDataGridViewTextBoxColumn})
        Me.DataGridViewCompras.DataSource = Me.BitacoradeerroresBindingSource
        Me.DataGridViewCompras.Dock = System.Windows.Forms.DockStyle.Fill
        Me.DataGridViewCompras.Location = New System.Drawing.Point(0, 65)
        Me.DataGridViewCompras.Name = "DataGridViewCompras"
        Me.DataGridViewCompras.Size = New System.Drawing.Size(774, 384)
        Me.DataGridViewCompras.TabIndex = 5
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.BackColor = System.Drawing.Color.FromArgb(CType(CType(32, Byte), Integer), CType(CType(43, Byte), Integer), CType(CType(76, Byte), Integer))
        Me.Label4.Font = New System.Drawing.Font("Century Gothic", 18.0!)
        Me.Label4.ForeColor = System.Drawing.Color.White
        Me.Label4.Location = New System.Drawing.Point(489, 17)
        Me.Label4.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(283, 30)
        Me.Label4.TabIndex = 7
        Me.Label4.Text = "BITÁCORA DE ERRORES"
        '
        'Taller_refaccionariaDataSet
        '
        Me.Taller_refaccionariaDataSet.DataSetName = "taller_refaccionariaDataSet"
        Me.Taller_refaccionariaDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'BitacoradeerroresBindingSource
        '
        Me.BitacoradeerroresBindingSource.DataMember = "bitacoradeerrores"
        Me.BitacoradeerroresBindingSource.DataSource = Me.Taller_refaccionariaDataSet
        '
        'BitacoradeerroresTableAdapter
        '
        Me.BitacoradeerroresTableAdapter.ClearBeforeFill = True
        '
        'IdbitacoraDataGridViewTextBoxColumn
        '
        Me.IdbitacoraDataGridViewTextBoxColumn.DataPropertyName = "idbitacora"
        Me.IdbitacoraDataGridViewTextBoxColumn.HeaderText = "ID"
        Me.IdbitacoraDataGridViewTextBoxColumn.Name = "IdbitacoraDataGridViewTextBoxColumn"
        '
        'FechaDataGridViewTextBoxColumn
        '
        Me.FechaDataGridViewTextBoxColumn.DataPropertyName = "fecha"
        Me.FechaDataGridViewTextBoxColumn.HeaderText = "Fecha"
        Me.FechaDataGridViewTextBoxColumn.Name = "FechaDataGridViewTextBoxColumn"
        '
        'FormularioDataGridViewTextBoxColumn
        '
        Me.FormularioDataGridViewTextBoxColumn.DataPropertyName = "formulario"
        Me.FormularioDataGridViewTextBoxColumn.HeaderText = "Formulario"
        Me.FormularioDataGridViewTextBoxColumn.Name = "FormularioDataGridViewTextBoxColumn"
        '
        'NumerrorDataGridViewTextBoxColumn
        '
        Me.NumerrorDataGridViewTextBoxColumn.DataPropertyName = "numerror"
        Me.NumerrorDataGridViewTextBoxColumn.HeaderText = "#Error"
        Me.NumerrorDataGridViewTextBoxColumn.Name = "NumerrorDataGridViewTextBoxColumn"
        '
        'DescripcionDataGridViewTextBoxColumn
        '
        Me.DescripcionDataGridViewTextBoxColumn.DataPropertyName = "descripcion"
        Me.DescripcionDataGridViewTextBoxColumn.HeaderText = "Descripción"
        Me.DescripcionDataGridViewTextBoxColumn.Name = "DescripcionDataGridViewTextBoxColumn"
        '
        'BitacoraErrores
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(774, 449)
        Me.Controls.Add(Me.DataGridViewCompras)
        Me.Controls.Add(Me.Panel1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "BitacoraErrores"
        Me.Text = "BitacoraErrores"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        CType(Me.DataGridViewCompras, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Taller_refaccionariaDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BitacoradeerroresBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Panel1 As Panel
    Friend WithEvents DataGridViewCompras As DataGridView
    Friend WithEvents Label4 As Label
    Friend WithEvents Taller_refaccionariaDataSet As taller_refaccionariaDataSet
    Friend WithEvents BitacoradeerroresBindingSource As BindingSource
    Friend WithEvents BitacoradeerroresTableAdapter As taller_refaccionariaDataSetTableAdapters.bitacoradeerroresTableAdapter
    Friend WithEvents IdbitacoraDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents FechaDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents FormularioDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents NumerrorDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents DescripcionDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
End Class
