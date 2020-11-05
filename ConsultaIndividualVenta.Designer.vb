<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ConsultaIndividualVenta
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
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.LblDate = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.LblFolio = New System.Windows.Forms.Label()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.LblCP = New System.Windows.Forms.Label()
        Me.LblEstado = New System.Windows.Forms.Label()
        Me.LblCiudad = New System.Windows.Forms.Label()
        Me.LblDomicilio = New System.Windows.Forms.Label()
        Me.LblRFC = New System.Windows.Forms.Label()
        Me.LblNombre = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.DataGridViewVenta = New System.Windows.Forms.DataGridView()
        Me.Cant = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Clave = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.servicio = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Descripcion = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Importe = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.LblComentario = New System.Windows.Forms.Label()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.LblTotal = New System.Windows.Forms.Label()
        Me.Panel1.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        CType(Me.DataGridViewVenta, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel2.SuspendLayout()
        Me.Panel3.SuspendLayout()
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
        Me.Panel1.Size = New System.Drawing.Size(680, 41)
        Me.Panel1.TabIndex = 1
        '
        'Button1
        '
        Me.Button1.BackgroundImage = Global.MotoBox.My.Resources.Resources._084_multiply
        Me.Button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.Button1.Dock = System.Windows.Forms.DockStyle.Right
        Me.Button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button1.Location = New System.Drawing.Point(639, 0)
        Me.Button1.Margin = New System.Windows.Forms.Padding(2)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(41, 41)
        Me.Button1.TabIndex = 1
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Century Gothic", 12.0!)
        Me.Label1.ForeColor = System.Drawing.Color.WhiteSmoke
        Me.Label1.Location = New System.Drawing.Point(261, 10)
        Me.Label1.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(158, 21)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Consulta de Venta"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Century Gothic", 12.0!)
        Me.Label4.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Label4.Location = New System.Drawing.Point(11, 56)
        Me.Label4.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(116, 21)
        Me.Label4.TabIndex = 7
        Me.Label4.Text = "Fecha y Hora:"
        Me.Label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'LblDate
        '
        Me.LblDate.AutoSize = True
        Me.LblDate.Font = New System.Drawing.Font("Century Gothic", 12.0!)
        Me.LblDate.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.LblDate.Location = New System.Drawing.Point(131, 56)
        Me.LblDate.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.LblDate.Name = "LblDate"
        Me.LblDate.Size = New System.Drawing.Size(162, 21)
        Me.LblDate.TabIndex = 8
        Me.LblDate.Text = "00/00/0000 00:00:00"
        Me.LblDate.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Dock = System.Windows.Forms.DockStyle.Right
        Me.Label3.Font = New System.Drawing.Font("Century Gothic", 12.0!)
        Me.Label3.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Label3.Location = New System.Drawing.Point(20, 0)
        Me.Label3.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(48, 21)
        Me.Label3.TabIndex = 9
        Me.Label3.Text = "Folio:"
        Me.Label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'LblFolio
        '
        Me.LblFolio.AutoSize = True
        Me.LblFolio.Dock = System.Windows.Forms.DockStyle.Right
        Me.LblFolio.Font = New System.Drawing.Font("Century Gothic", 12.0!)
        Me.LblFolio.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.LblFolio.Location = New System.Drawing.Point(68, 0)
        Me.LblFolio.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.LblFolio.Name = "LblFolio"
        Me.LblFolio.Size = New System.Drawing.Size(19, 21)
        Me.LblFolio.TabIndex = 10
        Me.LblFolio.Text = "0"
        Me.LblFolio.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.LblCP)
        Me.GroupBox1.Controls.Add(Me.LblEstado)
        Me.GroupBox1.Controls.Add(Me.LblCiudad)
        Me.GroupBox1.Controls.Add(Me.LblDomicilio)
        Me.GroupBox1.Controls.Add(Me.LblRFC)
        Me.GroupBox1.Controls.Add(Me.LblNombre)
        Me.GroupBox1.Controls.Add(Me.Label7)
        Me.GroupBox1.Controls.Add(Me.Label8)
        Me.GroupBox1.Controls.Add(Me.Label9)
        Me.GroupBox1.Controls.Add(Me.Label6)
        Me.GroupBox1.Controls.Add(Me.Label5)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Location = New System.Drawing.Point(15, 91)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(650, 80)
        Me.GroupBox1.TabIndex = 11
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Cliente:"
        '
        'LblCP
        '
        Me.LblCP.Font = New System.Drawing.Font("Century Gothic", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblCP.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.LblCP.Location = New System.Drawing.Point(450, 59)
        Me.LblCP.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.LblCP.Name = "LblCP"
        Me.LblCP.Size = New System.Drawing.Size(175, 21)
        Me.LblCP.TabIndex = 23
        Me.LblCP.Text = "0"
        Me.LblCP.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'LblEstado
        '
        Me.LblEstado.Font = New System.Drawing.Font("Century Gothic", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblEstado.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.LblEstado.Location = New System.Drawing.Point(450, 38)
        Me.LblEstado.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.LblEstado.Name = "LblEstado"
        Me.LblEstado.Size = New System.Drawing.Size(175, 21)
        Me.LblEstado.TabIndex = 22
        Me.LblEstado.Text = "0"
        Me.LblEstado.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'LblCiudad
        '
        Me.LblCiudad.Font = New System.Drawing.Font("Century Gothic", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblCiudad.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.LblCiudad.Location = New System.Drawing.Point(450, 17)
        Me.LblCiudad.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.LblCiudad.Name = "LblCiudad"
        Me.LblCiudad.Size = New System.Drawing.Size(175, 21)
        Me.LblCiudad.TabIndex = 21
        Me.LblCiudad.Text = "0"
        Me.LblCiudad.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'LblDomicilio
        '
        Me.LblDomicilio.Font = New System.Drawing.Font("Century Gothic", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblDomicilio.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.LblDomicilio.Location = New System.Drawing.Point(67, 54)
        Me.LblDomicilio.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.LblDomicilio.Name = "LblDomicilio"
        Me.LblDomicilio.Size = New System.Drawing.Size(318, 21)
        Me.LblDomicilio.TabIndex = 20
        Me.LblDomicilio.Text = "0"
        Me.LblDomicilio.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'LblRFC
        '
        Me.LblRFC.Font = New System.Drawing.Font("Century Gothic", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblRFC.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.LblRFC.Location = New System.Drawing.Point(67, 31)
        Me.LblRFC.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.LblRFC.Name = "LblRFC"
        Me.LblRFC.Size = New System.Drawing.Size(318, 21)
        Me.LblRFC.TabIndex = 19
        Me.LblRFC.Text = "0"
        Me.LblRFC.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'LblNombre
        '
        Me.LblNombre.Font = New System.Drawing.Font("Century Gothic", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblNombre.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.LblNombre.Location = New System.Drawing.Point(67, 12)
        Me.LblNombre.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.LblNombre.Name = "LblNombre"
        Me.LblNombre.Size = New System.Drawing.Size(318, 21)
        Me.LblNombre.TabIndex = 18
        Me.LblNombre.Text = "0"
        Me.LblNombre.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Century Gothic", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Label7.Location = New System.Drawing.Point(393, 59)
        Me.Label7.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(33, 16)
        Me.Label7.TabIndex = 17
        Me.Label7.Text = "C.P.:"
        Me.Label7.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Century Gothic", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Label8.Location = New System.Drawing.Point(393, 38)
        Me.Label8.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(48, 16)
        Me.Label8.TabIndex = 16
        Me.Label8.Text = "Estado:"
        Me.Label8.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Century Gothic", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Label9.Location = New System.Drawing.Point(393, 17)
        Me.Label9.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(53, 16)
        Me.Label9.TabIndex = 15
        Me.Label9.Text = "Ciudad:"
        Me.Label9.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Century Gothic", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Label6.Location = New System.Drawing.Point(5, 56)
        Me.Label6.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(58, 16)
        Me.Label6.TabIndex = 14
        Me.Label6.Text = "Domicilio:"
        Me.Label6.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Century Gothic", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Label5.Location = New System.Drawing.Point(5, 35)
        Me.Label5.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(41, 16)
        Me.Label5.TabIndex = 13
        Me.Label5.Text = "R.F.C.:"
        Me.Label5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Century Gothic", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Label2.Location = New System.Drawing.Point(5, 14)
        Me.Label2.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(54, 16)
        Me.Label2.TabIndex = 12
        Me.Label2.Text = "Nombre:"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'DataGridViewVenta
        '
        Me.DataGridViewVenta.AllowUserToAddRows = False
        Me.DataGridViewVenta.AllowUserToDeleteRows = False
        Me.DataGridViewVenta.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.DataGridViewVenta.BackgroundColor = System.Drawing.SystemColors.ControlLight
        Me.DataGridViewVenta.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridViewVenta.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Cant, Me.Clave, Me.servicio, Me.Descripcion, Me.Importe})
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Century Gothic", 10.0!)
        DataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.DataGridViewVenta.DefaultCellStyle = DataGridViewCellStyle1
        Me.DataGridViewVenta.Location = New System.Drawing.Point(13, 179)
        Me.DataGridViewVenta.Margin = New System.Windows.Forms.Padding(2)
        Me.DataGridViewVenta.Name = "DataGridViewVenta"
        Me.DataGridViewVenta.ReadOnly = True
        Me.DataGridViewVenta.RowHeadersWidth = 51
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Century Gothic", 12.0!)
        Me.DataGridViewVenta.RowsDefaultCellStyle = DataGridViewCellStyle2
        Me.DataGridViewVenta.RowTemplate.Height = 24
        Me.DataGridViewVenta.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.DataGridViewVenta.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.DataGridViewVenta.Size = New System.Drawing.Size(654, 200)
        Me.DataGridViewVenta.TabIndex = 12
        '
        'Cant
        '
        Me.Cant.FillWeight = 81.94307!
        Me.Cant.HeaderText = "Cant."
        Me.Cant.MinimumWidth = 6
        Me.Cant.Name = "Cant"
        Me.Cant.ReadOnly = True
        '
        'Clave
        '
        Me.Clave.FillWeight = 108.6229!
        Me.Clave.HeaderText = "ID/Código"
        Me.Clave.MinimumWidth = 6
        Me.Clave.Name = "Clave"
        Me.Clave.ReadOnly = True
        '
        'servicio
        '
        Me.servicio.FillWeight = 41.63171!
        Me.servicio.HeaderText = "S"
        Me.servicio.Name = "servicio"
        Me.servicio.ReadOnly = True
        '
        'Descripcion
        '
        Me.Descripcion.FillWeight = 291.9571!
        Me.Descripcion.HeaderText = "Descripción"
        Me.Descripcion.MinimumWidth = 6
        Me.Descripcion.Name = "Descripcion"
        Me.Descripcion.ReadOnly = True
        '
        'Importe
        '
        Me.Importe.FillWeight = 83.27744!
        Me.Importe.HeaderText = "Importe"
        Me.Importe.MinimumWidth = 6
        Me.Importe.Name = "Importe"
        Me.Importe.ReadOnly = True
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Century Gothic", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.Location = New System.Drawing.Point(9, 390)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(82, 17)
        Me.Label10.TabIndex = 13
        Me.Label10.Text = "Comentario:"
        '
        'LblComentario
        '
        Me.LblComentario.Font = New System.Drawing.Font("Century Gothic", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblComentario.Location = New System.Drawing.Point(12, 410)
        Me.LblComentario.Name = "LblComentario"
        Me.LblComentario.Size = New System.Drawing.Size(388, 20)
        Me.LblComentario.TabIndex = 14
        '
        'Panel2
        '
        Me.Panel2.Controls.Add(Me.Label3)
        Me.Panel2.Controls.Add(Me.LblFolio)
        Me.Panel2.Location = New System.Drawing.Point(578, 56)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(87, 29)
        Me.Panel2.TabIndex = 16
        '
        'Panel3
        '
        Me.Panel3.Controls.Add(Me.LblTotal)
        Me.Panel3.Location = New System.Drawing.Point(424, 392)
        Me.Panel3.Margin = New System.Windows.Forms.Padding(2)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(243, 38)
        Me.Panel3.TabIndex = 17
        '
        'LblTotal
        '
        Me.LblTotal.Font = New System.Drawing.Font("Century Gothic", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblTotal.ForeColor = System.Drawing.Color.Black
        Me.LblTotal.Location = New System.Drawing.Point(4, 4)
        Me.LblTotal.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.LblTotal.Name = "LblTotal"
        Me.LblTotal.Size = New System.Drawing.Size(236, 30)
        Me.LblTotal.TabIndex = 0
        Me.LblTotal.Text = "Total: $0.00 MXN"
        Me.LblTotal.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'ConsultaIndividualVenta
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(680, 450)
        Me.Controls.Add(Me.Panel3)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.LblComentario)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.DataGridViewVenta)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.LblDate)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Panel1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "ConsultaIndividualVenta"
        Me.Text = "ConsultaIndividualVenta"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.DataGridViewVenta, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        Me.Panel3.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Panel1 As Panel
    Friend WithEvents Button1 As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents LblDate As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents LblFolio As Label
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents Label7 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents DataGridViewVenta As DataGridView
    Friend WithEvents Label10 As Label
    Friend WithEvents LblComentario As Label
    Friend WithEvents Panel2 As Panel
    Friend WithEvents LblDomicilio As Label
    Friend WithEvents LblRFC As Label
    Friend WithEvents LblNombre As Label
    Friend WithEvents LblCP As Label
    Friend WithEvents LblEstado As Label
    Friend WithEvents LblCiudad As Label
    Friend WithEvents Panel3 As Panel
    Friend WithEvents LblTotal As Label
    Friend WithEvents Cant As DataGridViewTextBoxColumn
    Friend WithEvents Clave As DataGridViewTextBoxColumn
    Friend WithEvents servicio As DataGridViewTextBoxColumn
    Friend WithEvents Descripcion As DataGridViewTextBoxColumn
    Friend WithEvents Importe As DataGridViewTextBoxColumn
End Class
