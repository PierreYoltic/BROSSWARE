<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ConsultaVenta
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
        Me.BtnMostrar = New System.Windows.Forms.Button()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.ComboBoxEstado = New System.Windows.Forms.ComboBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.DTPFechaFinal = New System.Windows.Forms.DateTimePicker()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.DTPFechaInicial = New System.Windows.Forms.DateTimePicker()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.DataGridViewVentas = New System.Windows.Forms.DataGridView()
        Me.fecha = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Folio = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.cliente = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.est = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.total = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Panel1.SuspendLayout()
        Me.Panel2.SuspendLayout()
        CType(Me.DataGridViewVentas, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.FromArgb(CType(CType(27, Byte), Integer), CType(CType(38, Byte), Integer), CType(CType(69, Byte), Integer))
        Me.Panel1.Controls.Add(Me.Button2)
        Me.Panel1.Controls.Add(Me.Button1)
        Me.Panel1.Controls.Add(Me.BtnMostrar)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Margin = New System.Windows.Forms.Padding(2)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(758, 65)
        Me.Panel1.TabIndex = 1
        '
        'Button2
        '
        Me.Button2.Enabled = False
        Me.Button2.FlatAppearance.BorderSize = 0
        Me.Button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button2.Font = New System.Drawing.Font("Century Gothic", 7.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button2.ForeColor = System.Drawing.Color.White
        Me.Button2.Image = Global.MotoBox.My.Resources.Resources._222_print
        Me.Button2.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.Button2.Location = New System.Drawing.Point(186, 0)
        Me.Button2.Margin = New System.Windows.Forms.Padding(2)
        Me.Button2.Name = "Button2"
        Me.Button2.Padding = New System.Windows.Forms.Padding(0, 4, 0, 4)
        Me.Button2.Size = New System.Drawing.Size(88, 65)
        Me.Button2.TabIndex = 2
        Me.Button2.Text = "Imprimir"
        Me.Button2.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.Button2.UseVisualStyleBackColor = True
        '
        'Button1
        '
        Me.Button1.Enabled = False
        Me.Button1.FlatAppearance.BorderSize = 0
        Me.Button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button1.Font = New System.Drawing.Font("Century Gothic", 7.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button1.ForeColor = System.Drawing.Color.White
        Me.Button1.Image = Global.MotoBox.My.Resources.Resources._058_error
        Me.Button1.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.Button1.Location = New System.Drawing.Point(94, 0)
        Me.Button1.Margin = New System.Windows.Forms.Padding(2)
        Me.Button1.Name = "Button1"
        Me.Button1.Padding = New System.Windows.Forms.Padding(0, 4, 0, 4)
        Me.Button1.Size = New System.Drawing.Size(88, 65)
        Me.Button1.TabIndex = 1
        Me.Button1.Text = "Cancelar"
        Me.Button1.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.Button1.UseVisualStyleBackColor = True
        '
        'BtnMostrar
        '
        Me.BtnMostrar.FlatAppearance.BorderSize = 0
        Me.BtnMostrar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnMostrar.Font = New System.Drawing.Font("Century Gothic", 7.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnMostrar.ForeColor = System.Drawing.Color.White
        Me.BtnMostrar.Image = Global.MotoBox.My.Resources.Resources._021_view
        Me.BtnMostrar.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.BtnMostrar.Location = New System.Drawing.Point(2, 0)
        Me.BtnMostrar.Margin = New System.Windows.Forms.Padding(2)
        Me.BtnMostrar.Name = "BtnMostrar"
        Me.BtnMostrar.Padding = New System.Windows.Forms.Padding(0, 4, 0, 4)
        Me.BtnMostrar.Size = New System.Drawing.Size(88, 65)
        Me.BtnMostrar.TabIndex = 0
        Me.BtnMostrar.Text = "Buscar"
        Me.BtnMostrar.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.BtnMostrar.UseVisualStyleBackColor = True
        '
        'Panel2
        '
        Me.Panel2.Controls.Add(Me.ComboBoxEstado)
        Me.Panel2.Controls.Add(Me.Label3)
        Me.Panel2.Controls.Add(Me.DTPFechaFinal)
        Me.Panel2.Controls.Add(Me.Label1)
        Me.Panel2.Controls.Add(Me.DTPFechaInicial)
        Me.Panel2.Controls.Add(Me.Label2)
        Me.Panel2.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel2.Location = New System.Drawing.Point(0, 65)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(758, 50)
        Me.Panel2.TabIndex = 2
        '
        'ComboBoxEstado
        '
        Me.ComboBoxEstado.Font = New System.Drawing.Font("Century Gothic", 12.0!)
        Me.ComboBoxEstado.FormattingEnabled = True
        Me.ComboBoxEstado.Items.AddRange(New Object() {"Todos", "Vigente", "Cancelado"})
        Me.ComboBoxEstado.Location = New System.Drawing.Point(594, 11)
        Me.ComboBoxEstado.Name = "ComboBoxEstado"
        Me.ComboBoxEstado.Size = New System.Drawing.Size(152, 29)
        Me.ComboBoxEstado.TabIndex = 9
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Century Gothic", 12.0!)
        Me.Label3.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Label3.Location = New System.Drawing.Point(521, 18)
        Me.Label3.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(68, 21)
        Me.Label3.TabIndex = 8
        Me.Label3.Text = "Estado:"
        Me.Label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'DTPFechaFinal
        '
        Me.DTPFechaFinal.Font = New System.Drawing.Font("Century Gothic", 12.0!)
        Me.DTPFechaFinal.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.DTPFechaFinal.Location = New System.Drawing.Point(377, 13)
        Me.DTPFechaFinal.Margin = New System.Windows.Forms.Padding(2)
        Me.DTPFechaFinal.Name = "DTPFechaFinal"
        Me.DTPFechaFinal.Size = New System.Drawing.Size(140, 27)
        Me.DTPFechaFinal.TabIndex = 7
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Century Gothic", 12.0!)
        Me.Label1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Label1.Location = New System.Drawing.Point(271, 18)
        Me.Label1.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(102, 21)
        Me.Label1.TabIndex = 6
        Me.Label1.Text = "Fecha Final:"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'DTPFechaInicial
        '
        Me.DTPFechaInicial.Font = New System.Drawing.Font("Century Gothic", 12.0!)
        Me.DTPFechaInicial.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.DTPFechaInicial.Location = New System.Drawing.Point(127, 13)
        Me.DTPFechaInicial.Margin = New System.Windows.Forms.Padding(2)
        Me.DTPFechaInicial.Name = "DTPFechaInicial"
        Me.DTPFechaInicial.Size = New System.Drawing.Size(140, 27)
        Me.DTPFechaInicial.TabIndex = 5
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Century Gothic", 12.0!)
        Me.Label2.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Label2.Location = New System.Drawing.Point(11, 18)
        Me.Label2.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(112, 21)
        Me.Label2.TabIndex = 4
        Me.Label2.Text = "Fecha Inicial:"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'DataGridViewVentas
        '
        Me.DataGridViewVentas.AllowUserToAddRows = False
        Me.DataGridViewVentas.AllowUserToDeleteRows = False
        Me.DataGridViewVentas.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.DataGridViewVentas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridViewVentas.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.fecha, Me.Folio, Me.cliente, Me.est, Me.total})
        Me.DataGridViewVentas.Dock = System.Windows.Forms.DockStyle.Fill
        Me.DataGridViewVentas.Location = New System.Drawing.Point(0, 115)
        Me.DataGridViewVentas.Name = "DataGridViewVentas"
        Me.DataGridViewVentas.ReadOnly = True
        Me.DataGridViewVentas.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.DataGridViewVentas.Size = New System.Drawing.Size(758, 295)
        Me.DataGridViewVentas.TabIndex = 3
        '
        'fecha
        '
        Me.fecha.HeaderText = "Fecha"
        Me.fecha.Name = "fecha"
        Me.fecha.ReadOnly = True
        '
        'Folio
        '
        Me.Folio.HeaderText = "Folio"
        Me.Folio.Name = "Folio"
        Me.Folio.ReadOnly = True
        '
        'cliente
        '
        Me.cliente.HeaderText = "Cliente"
        Me.cliente.Name = "cliente"
        Me.cliente.ReadOnly = True
        '
        'est
        '
        Me.est.HeaderText = "Estado"
        Me.est.Name = "est"
        Me.est.ReadOnly = True
        '
        'total
        '
        Me.total.HeaderText = "Total"
        Me.total.Name = "total"
        Me.total.ReadOnly = True
        '
        'ConsultaVenta
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(758, 410)
        Me.Controls.Add(Me.DataGridViewVentas)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.Panel1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "ConsultaVenta"
        Me.Text = "ConsultaVenta"
        Me.Panel1.ResumeLayout(False)
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        CType(Me.DataGridViewVentas, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Panel1 As Panel
    Friend WithEvents BtnMostrar As Button
    Friend WithEvents Panel2 As Panel
    Friend WithEvents DTPFechaInicial As DateTimePicker
    Friend WithEvents Label2 As Label
    Friend WithEvents Button2 As Button
    Friend WithEvents Button1 As Button
    Friend WithEvents Label3 As Label
    Friend WithEvents DTPFechaFinal As DateTimePicker
    Friend WithEvents Label1 As Label
    Friend WithEvents ComboBoxEstado As ComboBox
    Friend WithEvents DataGridViewVentas As DataGridView
    Friend WithEvents fecha As DataGridViewTextBoxColumn
    Friend WithEvents Folio As DataGridViewTextBoxColumn
    Friend WithEvents cliente As DataGridViewTextBoxColumn
    Friend WithEvents est As DataGridViewTextBoxColumn
    Friend WithEvents total As DataGridViewTextBoxColumn
End Class
