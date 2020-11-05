<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class AddArticulos
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
        Me.Label6 = New System.Windows.Forms.Label()
        Me.TxtClave = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.ComboBoxCategoria = New System.Windows.Forms.ComboBox()
        Me.BtnCancelar = New System.Windows.Forms.Button()
        Me.BtnGuardar = New System.Windows.Forms.Button()
        Me.TxtPrecioV = New System.Windows.Forms.TextBox()
        Me.TxtPrecioC = New System.Windows.Forms.TextBox()
        Me.NumExist = New System.Windows.Forms.NumericUpDown()
        Me.NumMax = New System.Windows.Forms.NumericUpDown()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.TxtCaracteristicas = New System.Windows.Forms.TextBox()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.NumMin = New System.Windows.Forms.NumericUpDown()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.TxtDescripcion = New System.Windows.Forms.TextBox()
        Me.ArticuloBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Taller_refaccionariaDataSet = New MotoBox.taller_refaccionariaDataSet()
        Me.ArticuloTableAdapter = New MotoBox.taller_refaccionariaDataSetTableAdapters.articuloTableAdapter()
        Me.Panel1.SuspendLayout()
        Me.Panel2.SuspendLayout()
        CType(Me.NumExist, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.NumMax, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.NumMin, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ArticuloBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Taller_refaccionariaDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.FromArgb(CType(CType(27, Byte), Integer), CType(CType(38, Byte), Integer), CType(CType(69, Byte), Integer))
        Me.Panel1.Controls.Add(Me.Label6)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Margin = New System.Windows.Forms.Padding(2)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(320, 57)
        Me.Panel1.TabIndex = 0
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Century Gothic", 16.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.ForeColor = System.Drawing.Color.White
        Me.Label6.Location = New System.Drawing.Point(46, 15)
        Me.Label6.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(245, 25)
        Me.Label6.TabIndex = 15
        Me.Label6.Text = "DATOS DEL ARTICULO"
        '
        'TxtClave
        '
        Me.TxtClave.Font = New System.Drawing.Font("Century Gothic", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtClave.Location = New System.Drawing.Point(12, 36)
        Me.TxtClave.Margin = New System.Windows.Forms.Padding(2)
        Me.TxtClave.Name = "TxtClave"
        Me.TxtClave.Size = New System.Drawing.Size(111, 25)
        Me.TxtClave.TabIndex = 1
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Century Gothic", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(9, 15)
        Me.Label1.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(64, 20)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "Código"
        '
        'Panel2
        '
        Me.Panel2.Controls.Add(Me.Label2)
        Me.Panel2.Controls.Add(Me.ComboBoxCategoria)
        Me.Panel2.Controls.Add(Me.BtnCancelar)
        Me.Panel2.Controls.Add(Me.BtnGuardar)
        Me.Panel2.Controls.Add(Me.TxtPrecioV)
        Me.Panel2.Controls.Add(Me.TxtPrecioC)
        Me.Panel2.Controls.Add(Me.NumExist)
        Me.Panel2.Controls.Add(Me.NumMax)
        Me.Panel2.Controls.Add(Me.Label12)
        Me.Panel2.Controls.Add(Me.TxtCaracteristicas)
        Me.Panel2.Controls.Add(Me.Label11)
        Me.Panel2.Controls.Add(Me.Label10)
        Me.Panel2.Controls.Add(Me.Label9)
        Me.Panel2.Controls.Add(Me.Label8)
        Me.Panel2.Controls.Add(Me.Label7)
        Me.Panel2.Controls.Add(Me.NumMin)
        Me.Panel2.Controls.Add(Me.Label4)
        Me.Panel2.Controls.Add(Me.Label5)
        Me.Panel2.Controls.Add(Me.Label3)
        Me.Panel2.Controls.Add(Me.TxtDescripcion)
        Me.Panel2.Controls.Add(Me.Label1)
        Me.Panel2.Controls.Add(Me.TxtClave)
        Me.Panel2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel2.Location = New System.Drawing.Point(0, 57)
        Me.Panel2.Margin = New System.Windows.Forms.Padding(2)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(320, 465)
        Me.Panel2.TabIndex = 1
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Century Gothic", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(134, 13)
        Me.Label2.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(84, 20)
        Me.Label2.TabIndex = 35
        Me.Label2.Text = "Categoria"
        '
        'ComboBoxCategoria
        '
        Me.ComboBoxCategoria.Font = New System.Drawing.Font("Century Gothic", 10.8!)
        Me.ComboBoxCategoria.FormattingEnabled = True
        Me.ComboBoxCategoria.Location = New System.Drawing.Point(138, 36)
        Me.ComboBoxCategoria.Name = "ComboBoxCategoria"
        Me.ComboBoxCategoria.Size = New System.Drawing.Size(167, 27)
        Me.ComboBoxCategoria.TabIndex = 34
        '
        'BtnCancelar
        '
        Me.BtnCancelar.BackColor = System.Drawing.SystemColors.ControlDark
        Me.BtnCancelar.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.BtnCancelar.Font = New System.Drawing.Font("Century Gothic", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnCancelar.ForeColor = System.Drawing.Color.Black
        Me.BtnCancelar.Image = Global.MotoBox.My.Resources.Resources._074_bin
        Me.BtnCancelar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.BtnCancelar.Location = New System.Drawing.Point(165, 403)
        Me.BtnCancelar.Margin = New System.Windows.Forms.Padding(2)
        Me.BtnCancelar.Name = "BtnCancelar"
        Me.BtnCancelar.Padding = New System.Windows.Forms.Padding(4, 0, 0, 0)
        Me.BtnCancelar.Size = New System.Drawing.Size(140, 39)
        Me.BtnCancelar.TabIndex = 33
        Me.BtnCancelar.Text = "      Cancelar"
        Me.BtnCancelar.UseVisualStyleBackColor = False
        '
        'BtnGuardar
        '
        Me.BtnGuardar.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(80, Byte), Integer), CType(CType(200, Byte), Integer))
        Me.BtnGuardar.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.BtnGuardar.Font = New System.Drawing.Font("Century Gothic", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnGuardar.ForeColor = System.Drawing.Color.White
        Me.BtnGuardar.Image = Global.MotoBox.My.Resources.Resources._008_tick_mark
        Me.BtnGuardar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.BtnGuardar.Location = New System.Drawing.Point(15, 403)
        Me.BtnGuardar.Margin = New System.Windows.Forms.Padding(2)
        Me.BtnGuardar.Name = "BtnGuardar"
        Me.BtnGuardar.Padding = New System.Windows.Forms.Padding(4, 0, 0, 0)
        Me.BtnGuardar.Size = New System.Drawing.Size(140, 39)
        Me.BtnGuardar.TabIndex = 2
        Me.BtnGuardar.Text = "      Guardar"
        Me.BtnGuardar.UseVisualStyleBackColor = False
        '
        'TxtPrecioV
        '
        Me.TxtPrecioV.Font = New System.Drawing.Font("Century Gothic", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtPrecioV.Location = New System.Drawing.Point(26, 200)
        Me.TxtPrecioV.Margin = New System.Windows.Forms.Padding(2)
        Me.TxtPrecioV.Name = "TxtPrecioV"
        Me.TxtPrecioV.Size = New System.Drawing.Size(97, 25)
        Me.TxtPrecioV.TabIndex = 32
        Me.TxtPrecioV.Text = "0.00"
        '
        'TxtPrecioC
        '
        Me.TxtPrecioC.Font = New System.Drawing.Font("Century Gothic", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtPrecioC.Location = New System.Drawing.Point(26, 145)
        Me.TxtPrecioC.Margin = New System.Windows.Forms.Padding(2)
        Me.TxtPrecioC.Name = "TxtPrecioC"
        Me.TxtPrecioC.Size = New System.Drawing.Size(97, 25)
        Me.TxtPrecioC.TabIndex = 31
        Me.TxtPrecioC.Text = "0.00"
        '
        'NumExist
        '
        Me.NumExist.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.NumExist.Location = New System.Drawing.Point(166, 200)
        Me.NumExist.Margin = New System.Windows.Forms.Padding(2)
        Me.NumExist.Name = "NumExist"
        Me.NumExist.Size = New System.Drawing.Size(60, 27)
        Me.NumExist.TabIndex = 30
        '
        'NumMax
        '
        Me.NumMax.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.NumMax.Location = New System.Drawing.Point(245, 144)
        Me.NumMax.Margin = New System.Windows.Forms.Padding(2)
        Me.NumMax.Name = "NumMax"
        Me.NumMax.Size = New System.Drawing.Size(60, 27)
        Me.NumMax.TabIndex = 29
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Font = New System.Drawing.Font("Century Gothic", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label12.Location = New System.Drawing.Point(12, 237)
        Me.Label12.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(119, 20)
        Me.Label12.TabIndex = 28
        Me.Label12.Text = "Caracteristicas"
        '
        'TxtCaracteristicas
        '
        Me.TxtCaracteristicas.Font = New System.Drawing.Font("Century Gothic", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtCaracteristicas.Location = New System.Drawing.Point(15, 258)
        Me.TxtCaracteristicas.Margin = New System.Windows.Forms.Padding(2)
        Me.TxtCaracteristicas.Multiline = True
        Me.TxtCaracteristicas.Name = "TxtCaracteristicas"
        Me.TxtCaracteristicas.Size = New System.Drawing.Size(290, 133)
        Me.TxtCaracteristicas.TabIndex = 27
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Font = New System.Drawing.Font("Century Gothic", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.Location = New System.Drawing.Point(163, 178)
        Me.Label11.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(80, 20)
        Me.Label11.TabIndex = 25
        Me.Label11.Text = "Existencia"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Century Gothic", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.Location = New System.Drawing.Point(12, 203)
        Me.Label10.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(17, 20)
        Me.Label10.TabIndex = 23
        Me.Label10.Text = "$"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Century Gothic", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.Location = New System.Drawing.Point(12, 147)
        Me.Label9.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(17, 20)
        Me.Label9.TabIndex = 19
        Me.Label9.Text = "$"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Century Gothic", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(12, 178)
        Me.Label8.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(105, 20)
        Me.Label8.TabIndex = 18
        Me.Label8.Text = "Precio Venta"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Century Gothic", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(12, 127)
        Me.Label7.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(116, 20)
        Me.Label7.TabIndex = 16
        Me.Label7.Text = "Costo Compra"
        '
        'NumMin
        '
        Me.NumMin.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.NumMin.Location = New System.Drawing.Point(165, 143)
        Me.NumMin.Margin = New System.Windows.Forms.Padding(2)
        Me.NumMin.Name = "NumMin"
        Me.NumMin.Size = New System.Drawing.Size(60, 27)
        Me.NumMin.TabIndex = 13
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Century Gothic", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(242, 124)
        Me.Label4.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(41, 20)
        Me.Label4.TabIndex = 12
        Me.Label4.Text = "Max"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Century Gothic", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(162, 123)
        Me.Label5.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(36, 20)
        Me.Label5.TabIndex = 10
        Me.Label5.Text = "Min"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Century Gothic", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(12, 67)
        Me.Label3.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(96, 20)
        Me.Label3.TabIndex = 6
        Me.Label3.Text = "Descripcion"
        '
        'TxtDescripcion
        '
        Me.TxtDescripcion.Font = New System.Drawing.Font("Century Gothic", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtDescripcion.Location = New System.Drawing.Point(15, 87)
        Me.TxtDescripcion.Margin = New System.Windows.Forms.Padding(2)
        Me.TxtDescripcion.Name = "TxtDescripcion"
        Me.TxtDescripcion.Size = New System.Drawing.Size(290, 25)
        Me.TxtDescripcion.TabIndex = 5
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
        'ArticuloTableAdapter
        '
        Me.ArticuloTableAdapter.ClearBeforeFill = True
        '
        'AddArticulos
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(320, 522)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.Panel1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Margin = New System.Windows.Forms.Padding(2)
        Me.Name = "AddArticulos"
        Me.Text = "AddArticulos"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        CType(Me.NumExist, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.NumMax, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.NumMin, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ArticuloBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Taller_refaccionariaDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Panel1 As Panel
    Friend WithEvents Label6 As Label
    Friend WithEvents TxtClave As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Panel2 As Panel
    Friend WithEvents Label9 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents NumMin As NumericUpDown
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents TxtDescripcion As TextBox
    Friend WithEvents TxtPrecioV As TextBox
    Friend WithEvents TxtPrecioC As TextBox
    Friend WithEvents NumExist As NumericUpDown
    Friend WithEvents NumMax As NumericUpDown
    Friend WithEvents Label12 As Label
    Friend WithEvents TxtCaracteristicas As TextBox
    Friend WithEvents Label11 As Label
    Friend WithEvents Label10 As Label
    Friend WithEvents BtnGuardar As Button
    Friend WithEvents BtnCancelar As Button
    Friend WithEvents Taller_refaccionariaDataSet As taller_refaccionariaDataSet
    Friend WithEvents ArticuloBindingSource As BindingSource
    Friend WithEvents ArticuloTableAdapter As taller_refaccionariaDataSetTableAdapters.articuloTableAdapter
    Friend WithEvents Label2 As Label
    Friend WithEvents ComboBoxCategoria As ComboBox
End Class
