﻿<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Clientes
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
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.BtnEliminar = New System.Windows.Forms.Button()
        Me.BtnEditar = New System.Windows.Forms.Button()
        Me.BtnAgregar = New System.Windows.Forms.Button()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.DataGridViewClientes = New System.Windows.Forms.DataGridView()
        Me.ClaveDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.NombreDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.CiudadDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.EstadoDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.PaisDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ColoniaDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.MailDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ClienteBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Taller_refaccionariaDataSet = New MotoBox.taller_refaccionariaDataSet()
        Me.ClienteTableAdapter = New MotoBox.taller_refaccionariaDataSetTableAdapters.clienteTableAdapter()
        Me.Panel1.SuspendLayout()
        Me.Panel2.SuspendLayout()
        CType(Me.DataGridViewClientes, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ClienteBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
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
        Me.Panel1.TabIndex = 1
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
        Me.Label4.Size = New System.Drawing.Size(145, 37)
        Me.Label4.TabIndex = 6
        Me.Label4.Text = "CLIENTES"
        '
        'Panel2
        '
        Me.Panel2.Controls.Add(Me.DataGridViewClientes)
        Me.Panel2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel2.Location = New System.Drawing.Point(0, 50)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(1032, 503)
        Me.Panel2.TabIndex = 2
        '
        'DataGridViewClientes
        '
        Me.DataGridViewClientes.AllowUserToAddRows = False
        Me.DataGridViewClientes.AllowUserToDeleteRows = False
        Me.DataGridViewClientes.AutoGenerateColumns = False
        Me.DataGridViewClientes.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.DataGridViewClientes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridViewClientes.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.ClaveDataGridViewTextBoxColumn, Me.NombreDataGridViewTextBoxColumn, Me.CiudadDataGridViewTextBoxColumn, Me.EstadoDataGridViewTextBoxColumn, Me.PaisDataGridViewTextBoxColumn, Me.ColoniaDataGridViewTextBoxColumn, Me.MailDataGridViewTextBoxColumn})
        Me.DataGridViewClientes.DataSource = Me.ClienteBindingSource
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Century Gothic", 12.0!)
        DataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.DataGridViewClientes.DefaultCellStyle = DataGridViewCellStyle1
        Me.DataGridViewClientes.Dock = System.Windows.Forms.DockStyle.Fill
        Me.DataGridViewClientes.Location = New System.Drawing.Point(0, 0)
        Me.DataGridViewClientes.Name = "DataGridViewClientes"
        Me.DataGridViewClientes.ReadOnly = True
        Me.DataGridViewClientes.RowHeadersWidth = 51
        Me.DataGridViewClientes.RowTemplate.Height = 24
        Me.DataGridViewClientes.Size = New System.Drawing.Size(1032, 503)
        Me.DataGridViewClientes.TabIndex = 0
        '
        'ClaveDataGridViewTextBoxColumn
        '
        Me.ClaveDataGridViewTextBoxColumn.DataPropertyName = "clave"
        Me.ClaveDataGridViewTextBoxColumn.HeaderText = "Clave"
        Me.ClaveDataGridViewTextBoxColumn.MinimumWidth = 6
        Me.ClaveDataGridViewTextBoxColumn.Name = "ClaveDataGridViewTextBoxColumn"
        Me.ClaveDataGridViewTextBoxColumn.ReadOnly = True
        '
        'NombreDataGridViewTextBoxColumn
        '
        Me.NombreDataGridViewTextBoxColumn.DataPropertyName = "nombre"
        Me.NombreDataGridViewTextBoxColumn.HeaderText = "Nombre"
        Me.NombreDataGridViewTextBoxColumn.MinimumWidth = 6
        Me.NombreDataGridViewTextBoxColumn.Name = "NombreDataGridViewTextBoxColumn"
        Me.NombreDataGridViewTextBoxColumn.ReadOnly = True
        '
        'CiudadDataGridViewTextBoxColumn
        '
        Me.CiudadDataGridViewTextBoxColumn.DataPropertyName = "ciudad"
        Me.CiudadDataGridViewTextBoxColumn.HeaderText = "Ciudad"
        Me.CiudadDataGridViewTextBoxColumn.MinimumWidth = 6
        Me.CiudadDataGridViewTextBoxColumn.Name = "CiudadDataGridViewTextBoxColumn"
        Me.CiudadDataGridViewTextBoxColumn.ReadOnly = True
        '
        'EstadoDataGridViewTextBoxColumn
        '
        Me.EstadoDataGridViewTextBoxColumn.DataPropertyName = "estado"
        Me.EstadoDataGridViewTextBoxColumn.HeaderText = "Estado"
        Me.EstadoDataGridViewTextBoxColumn.MinimumWidth = 6
        Me.EstadoDataGridViewTextBoxColumn.Name = "EstadoDataGridViewTextBoxColumn"
        Me.EstadoDataGridViewTextBoxColumn.ReadOnly = True
        '
        'PaisDataGridViewTextBoxColumn
        '
        Me.PaisDataGridViewTextBoxColumn.DataPropertyName = "pais"
        Me.PaisDataGridViewTextBoxColumn.HeaderText = "Pais"
        Me.PaisDataGridViewTextBoxColumn.MinimumWidth = 6
        Me.PaisDataGridViewTextBoxColumn.Name = "PaisDataGridViewTextBoxColumn"
        Me.PaisDataGridViewTextBoxColumn.ReadOnly = True
        '
        'ColoniaDataGridViewTextBoxColumn
        '
        Me.ColoniaDataGridViewTextBoxColumn.DataPropertyName = "colonia"
        Me.ColoniaDataGridViewTextBoxColumn.HeaderText = "Colonia"
        Me.ColoniaDataGridViewTextBoxColumn.MinimumWidth = 6
        Me.ColoniaDataGridViewTextBoxColumn.Name = "ColoniaDataGridViewTextBoxColumn"
        Me.ColoniaDataGridViewTextBoxColumn.ReadOnly = True
        '
        'MailDataGridViewTextBoxColumn
        '
        Me.MailDataGridViewTextBoxColumn.DataPropertyName = "mail"
        Me.MailDataGridViewTextBoxColumn.HeaderText = "Mail"
        Me.MailDataGridViewTextBoxColumn.MinimumWidth = 6
        Me.MailDataGridViewTextBoxColumn.Name = "MailDataGridViewTextBoxColumn"
        Me.MailDataGridViewTextBoxColumn.ReadOnly = True
        '
        'ClienteBindingSource
        '
        Me.ClienteBindingSource.DataMember = "cliente"
        Me.ClienteBindingSource.DataSource = Me.Taller_refaccionariaDataSet
        '
        'Taller_refaccionariaDataSet
        '
        Me.Taller_refaccionariaDataSet.DataSetName = "taller_refaccionariaDataSet"
        Me.Taller_refaccionariaDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'ClienteTableAdapter
        '
        Me.ClienteTableAdapter.ClearBeforeFill = True
        '
        'Clientes
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1032, 553)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.Panel1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "Clientes"
        Me.Text = "Clientes"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.Panel2.ResumeLayout(False)
        CType(Me.DataGridViewClientes, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ClienteBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Taller_refaccionariaDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Panel1 As Panel
    Friend WithEvents BtnEliminar As Button
    Friend WithEvents BtnEditar As Button
    Friend WithEvents BtnAgregar As Button
    Friend WithEvents Label4 As Label
    Friend WithEvents Panel2 As Panel
    Friend WithEvents DataGridViewClientes As DataGridView
    Friend WithEvents Taller_refaccionariaDataSet As taller_refaccionariaDataSet
    Friend WithEvents ClienteBindingSource As BindingSource
    Friend WithEvents ClienteTableAdapter As taller_refaccionariaDataSetTableAdapters.clienteTableAdapter
    Friend WithEvents ClaveDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents NombreDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents CiudadDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents EstadoDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents PaisDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents CodigoPostalDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents ColoniaDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents MailDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
End Class
