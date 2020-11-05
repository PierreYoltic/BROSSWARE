<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class BuscarArticulo
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
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.TxtCodigo = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.DataGridViewArticulos = New System.Windows.Forms.DataGridView()
        Me.id = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.servicio = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.desc = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.exist = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.price = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Panel1.SuspendLayout()
        Me.Panel2.SuspendLayout()
        CType(Me.DataGridViewArticulos, System.ComponentModel.ISupportInitialize).BeginInit()
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
        Me.Panel1.TabIndex = 0
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
        Me.Label1.Location = New System.Drawing.Point(242, 11)
        Me.Label1.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(126, 21)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Buscar Artículo"
        '
        'Panel2
        '
        Me.Panel2.Controls.Add(Me.Button3)
        Me.Panel2.Controls.Add(Me.Button2)
        Me.Panel2.Controls.Add(Me.TxtCodigo)
        Me.Panel2.Controls.Add(Me.Label4)
        Me.Panel2.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel2.Location = New System.Drawing.Point(0, 41)
        Me.Panel2.Margin = New System.Windows.Forms.Padding(2)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(600, 57)
        Me.Panel2.TabIndex = 1
        '
        'Button3
        '
        Me.Button3.Font = New System.Drawing.Font("Century Gothic", 11.0!, System.Drawing.FontStyle.Bold)
        Me.Button3.Image = Global.MotoBox.My.Resources.Resources._279_edit
        Me.Button3.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Button3.Location = New System.Drawing.Point(509, 12)
        Me.Button3.Margin = New System.Windows.Forms.Padding(2)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(82, 32)
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
        Me.Button2.Location = New System.Drawing.Point(394, 12)
        Me.Button2.Margin = New System.Windows.Forms.Padding(2)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(110, 32)
        Me.Button2.TabIndex = 10
        Me.Button2.Text = "Agregar"
        Me.Button2.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.Button2.UseVisualStyleBackColor = True
        '
        'TxtCodigo
        '
        Me.TxtCodigo.Font = New System.Drawing.Font("Century Gothic", 12.0!)
        Me.TxtCodigo.Location = New System.Drawing.Point(106, 15)
        Me.TxtCodigo.Margin = New System.Windows.Forms.Padding(2)
        Me.TxtCodigo.Name = "TxtCodigo"
        Me.TxtCodigo.Size = New System.Drawing.Size(284, 27)
        Me.TxtCodigo.TabIndex = 9
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
        'DataGridViewArticulos
        '
        Me.DataGridViewArticulos.AllowUserToAddRows = False
        Me.DataGridViewArticulos.AllowUserToDeleteRows = False
        Me.DataGridViewArticulos.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.DataGridViewArticulos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridViewArticulos.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.id, Me.servicio, Me.desc, Me.exist, Me.price})
        Me.DataGridViewArticulos.Dock = System.Windows.Forms.DockStyle.Fill
        Me.DataGridViewArticulos.Location = New System.Drawing.Point(0, 98)
        Me.DataGridViewArticulos.Name = "DataGridViewArticulos"
        Me.DataGridViewArticulos.ReadOnly = True
        Me.DataGridViewArticulos.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.DataGridViewArticulos.Size = New System.Drawing.Size(600, 268)
        Me.DataGridViewArticulos.TabIndex = 2
        '
        'id
        '
        Me.id.HeaderText = "ID/Código"
        Me.id.Name = "id"
        Me.id.ReadOnly = True
        '
        'servicio
        '
        Me.servicio.HeaderText = "S"
        Me.servicio.Name = "servicio"
        Me.servicio.ReadOnly = True
        '
        'desc
        '
        Me.desc.HeaderText = "Descripción"
        Me.desc.Name = "desc"
        Me.desc.ReadOnly = True
        '
        'exist
        '
        Me.exist.HeaderText = "Existencia"
        Me.exist.Name = "exist"
        Me.exist.ReadOnly = True
        '
        'price
        '
        Me.price.HeaderText = "Precio"
        Me.price.Name = "price"
        Me.price.ReadOnly = True
        '
        'BuscarArticulo
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(600, 366)
        Me.Controls.Add(Me.DataGridViewArticulos)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.Panel1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Margin = New System.Windows.Forms.Padding(2)
        Me.Name = "BuscarArticulo"
        Me.Text = "BuscarArticulo"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        CType(Me.DataGridViewArticulos, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Panel1 As Panel
    Friend WithEvents Label1 As Label
    Friend WithEvents Panel2 As Panel
    Friend WithEvents Button1 As Button
    Friend WithEvents TxtCodigo As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents Button3 As Button
    Friend WithEvents Button2 As Button
    Friend WithEvents ClaveDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents DescripcionDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewArticulos As DataGridView
    Friend WithEvents id As DataGridViewTextBoxColumn
    Friend WithEvents servicio As DataGridViewTextBoxColumn
    Friend WithEvents desc As DataGridViewTextBoxColumn
    Friend WithEvents exist As DataGridViewTextBoxColumn
    Friend WithEvents price As DataGridViewTextBoxColumn
End Class
