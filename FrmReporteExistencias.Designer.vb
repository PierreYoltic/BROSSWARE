<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmReporteExistencias
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
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.BtnMostrar = New System.Windows.Forms.Button()
        Me.Taller_refaccionariaDataSet1 = New MotoBox.taller_refaccionariaDataSet()
        Me.CheckBoxCategoria = New System.Windows.Forms.CheckBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.CboCategoria = New System.Windows.Forms.ComboBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.RBTodos = New System.Windows.Forms.RadioButton()
        Me.RBConExist = New System.Windows.Forms.RadioButton()
        Me.RBSinExist = New System.Windows.Forms.RadioButton()
        Me.RBMax = New System.Windows.Forms.RadioButton()
        Me.RBMin = New System.Windows.Forms.RadioButton()
        Me.CboOrden = New System.Windows.Forms.ComboBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.CboAscDesc = New System.Windows.Forms.ComboBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Panel1.SuspendLayout()
        CType(Me.Taller_refaccionariaDataSet1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.FromArgb(CType(CType(27, Byte), Integer), CType(CType(38, Byte), Integer), CType(CType(69, Byte), Integer))
        Me.Panel1.Controls.Add(Me.Label4)
        Me.Panel1.Controls.Add(Me.Button2)
        Me.Panel1.Controls.Add(Me.BtnMostrar)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Margin = New System.Windows.Forms.Padding(2)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(774, 65)
        Me.Panel1.TabIndex = 4
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.BackColor = System.Drawing.Color.FromArgb(CType(CType(32, Byte), Integer), CType(CType(43, Byte), Integer), CType(CType(76, Byte), Integer))
        Me.Label4.Font = New System.Drawing.Font("Century Gothic", 18.0!)
        Me.Label4.ForeColor = System.Drawing.Color.White
        Me.Label4.Location = New System.Drawing.Point(466, 17)
        Me.Label4.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(281, 30)
        Me.Label4.TabIndex = 8
        Me.Label4.Text = "Reporte de Existencias"
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
        Me.Button2.Location = New System.Drawing.Point(94, 0)
        Me.Button2.Margin = New System.Windows.Forms.Padding(2)
        Me.Button2.Name = "Button2"
        Me.Button2.Padding = New System.Windows.Forms.Padding(0, 4, 0, 4)
        Me.Button2.Size = New System.Drawing.Size(88, 65)
        Me.Button2.TabIndex = 2
        Me.Button2.Text = "Imprimir"
        Me.Button2.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.Button2.UseVisualStyleBackColor = True
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
        Me.BtnMostrar.Text = "Mostrar"
        Me.BtnMostrar.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.BtnMostrar.UseVisualStyleBackColor = True
        '
        'Taller_refaccionariaDataSet1
        '
        Me.Taller_refaccionariaDataSet1.DataSetName = "taller_refaccionariaDataSet"
        Me.Taller_refaccionariaDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'CheckBoxCategoria
        '
        Me.CheckBoxCategoria.AutoSize = True
        Me.CheckBoxCategoria.Checked = True
        Me.CheckBoxCategoria.CheckState = System.Windows.Forms.CheckState.Checked
        Me.CheckBoxCategoria.FlatAppearance.CheckedBackColor = System.Drawing.Color.Blue
        Me.CheckBoxCategoria.Font = New System.Drawing.Font("Century Gothic", 12.0!)
        Me.CheckBoxCategoria.ForeColor = System.Drawing.Color.Black
        Me.CheckBoxCategoria.Location = New System.Drawing.Point(12, 81)
        Me.CheckBoxCategoria.Name = "CheckBoxCategoria"
        Me.CheckBoxCategoria.Size = New System.Drawing.Size(187, 25)
        Me.CheckBoxCategoria.TabIndex = 6
        Me.CheckBoxCategoria.Text = "Todas las categorías"
        Me.CheckBoxCategoria.UseVisualStyleBackColor = True
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Century Gothic", 12.0!)
        Me.Label2.ForeColor = System.Drawing.Color.Black
        Me.Label2.Location = New System.Drawing.Point(217, 80)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(95, 21)
        Me.Label2.TabIndex = 8
        Me.Label2.Text = "Categoría:"
        '
        'CboCategoria
        '
        Me.CboCategoria.Enabled = False
        Me.CboCategoria.Font = New System.Drawing.Font("Century Gothic", 12.0!)
        Me.CboCategoria.FormattingEnabled = True
        Me.CboCategoria.Location = New System.Drawing.Point(318, 77)
        Me.CboCategoria.Name = "CboCategoria"
        Me.CboCategoria.Size = New System.Drawing.Size(176, 29)
        Me.CboCategoria.TabIndex = 9
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(189, Byte), Integer), CType(CType(189, Byte), Integer), CType(CType(189, Byte), Integer))
        Me.Label1.Location = New System.Drawing.Point(9, 109)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(733, 13)
        Me.Label1.TabIndex = 10
        Me.Label1.Text = "_________________________________________________________________________________" &
    "________________________________________"
        '
        'RBTodos
        '
        Me.RBTodos.AutoSize = True
        Me.RBTodos.Checked = True
        Me.RBTodos.Font = New System.Drawing.Font("Century Gothic", 12.0!)
        Me.RBTodos.ForeColor = System.Drawing.Color.Black
        Me.RBTodos.Location = New System.Drawing.Point(12, 125)
        Me.RBTodos.Name = "RBTodos"
        Me.RBTodos.Size = New System.Drawing.Size(165, 25)
        Me.RBTodos.TabIndex = 11
        Me.RBTodos.TabStop = True
        Me.RBTodos.Text = "Todos los artículos"
        Me.RBTodos.UseVisualStyleBackColor = True
        '
        'RBConExist
        '
        Me.RBConExist.AutoSize = True
        Me.RBConExist.Font = New System.Drawing.Font("Century Gothic", 12.0!)
        Me.RBConExist.ForeColor = System.Drawing.Color.Black
        Me.RBConExist.Location = New System.Drawing.Point(12, 150)
        Me.RBConExist.Name = "RBConExist"
        Me.RBConExist.Size = New System.Drawing.Size(244, 25)
        Me.RBConExist.TabIndex = 12
        Me.RBConExist.Text = "Sólo artículos con existencia"
        Me.RBConExist.UseVisualStyleBackColor = True
        '
        'RBSinExist
        '
        Me.RBSinExist.AutoSize = True
        Me.RBSinExist.Font = New System.Drawing.Font("Century Gothic", 12.0!)
        Me.RBSinExist.ForeColor = System.Drawing.Color.Black
        Me.RBSinExist.Location = New System.Drawing.Point(12, 175)
        Me.RBSinExist.Name = "RBSinExist"
        Me.RBSinExist.Size = New System.Drawing.Size(233, 25)
        Me.RBSinExist.TabIndex = 13
        Me.RBSinExist.Text = "Sólo artículos sin existencia"
        Me.RBSinExist.UseVisualStyleBackColor = True
        '
        'RBMax
        '
        Me.RBMax.AutoSize = True
        Me.RBMax.Font = New System.Drawing.Font("Century Gothic", 12.0!)
        Me.RBMax.ForeColor = System.Drawing.Color.Black
        Me.RBMax.Location = New System.Drawing.Point(12, 200)
        Me.RBMax.Name = "RBMax"
        Me.RBMax.Size = New System.Drawing.Size(416, 25)
        Me.RBMax.TabIndex = 14
        Me.RBMax.Text = "Artículos que sobrepasan el máximo de inventario"
        Me.RBMax.UseVisualStyleBackColor = True
        '
        'RBMin
        '
        Me.RBMin.AutoSize = True
        Me.RBMin.Font = New System.Drawing.Font("Century Gothic", 12.0!)
        Me.RBMin.ForeColor = System.Drawing.Color.Black
        Me.RBMin.Location = New System.Drawing.Point(12, 225)
        Me.RBMin.Name = "RBMin"
        Me.RBMin.Size = New System.Drawing.Size(451, 25)
        Me.RBMin.TabIndex = 15
        Me.RBMin.Text = "Artículos con existencia menor al mínimo de inventario"
        Me.RBMin.UseVisualStyleBackColor = True
        '
        'CboOrden
        '
        Me.CboOrden.Font = New System.Drawing.Font("Century Gothic", 12.0!)
        Me.CboOrden.ForeColor = System.Drawing.Color.Black
        Me.CboOrden.FormattingEnabled = True
        Me.CboOrden.Items.AddRange(New Object() {"Descripción", "Categoría", "Existencia"})
        Me.CboOrden.Location = New System.Drawing.Point(128, 277)
        Me.CboOrden.Name = "CboOrden"
        Me.CboOrden.Size = New System.Drawing.Size(166, 29)
        Me.CboOrden.TabIndex = 17
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Century Gothic", 12.0!)
        Me.Label3.ForeColor = System.Drawing.Color.Black
        Me.Label3.Location = New System.Drawing.Point(12, 280)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(110, 21)
        Me.Label3.TabIndex = 16
        Me.Label3.Text = "Ordenar por:"
        '
        'CboAscDesc
        '
        Me.CboAscDesc.Font = New System.Drawing.Font("Century Gothic", 12.0!)
        Me.CboAscDesc.ForeColor = System.Drawing.Color.Black
        Me.CboAscDesc.FormattingEnabled = True
        Me.CboAscDesc.Items.AddRange(New Object() {"Ascendente", "Descendente"})
        Me.CboAscDesc.Location = New System.Drawing.Point(300, 277)
        Me.CboAscDesc.Name = "CboAscDesc"
        Me.CboAscDesc.Size = New System.Drawing.Size(194, 29)
        Me.CboAscDesc.TabIndex = 18
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.ForeColor = System.Drawing.Color.FromArgb(CType(CType(189, Byte), Integer), CType(CType(189, Byte), Integer), CType(CType(189, Byte), Integer))
        Me.Label5.Location = New System.Drawing.Point(9, 253)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(733, 13)
        Me.Label5.TabIndex = 19
        Me.Label5.Text = "_________________________________________________________________________________" &
    "________________________________________"
        '
        'FrmReporteExistencias
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.WhiteSmoke
        Me.ClientSize = New System.Drawing.Size(774, 449)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.CboAscDesc)
        Me.Controls.Add(Me.CboOrden)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.RBMin)
        Me.Controls.Add(Me.RBMax)
        Me.Controls.Add(Me.RBSinExist)
        Me.Controls.Add(Me.RBConExist)
        Me.Controls.Add(Me.RBTodos)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.CboCategoria)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.CheckBoxCategoria)
        Me.Controls.Add(Me.Panel1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "FrmReporteExistencias"
        Me.Text = "FrmReporteExistencias"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        CType(Me.Taller_refaccionariaDataSet1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Panel1 As Panel
    Friend WithEvents Button2 As Button
    Friend WithEvents BtnMostrar As Button
    Friend WithEvents Taller_refaccionariaDataSet1 As taller_refaccionariaDataSet
    Friend WithEvents Label4 As Label
    Friend WithEvents CheckBoxCategoria As CheckBox
    Friend WithEvents Label2 As Label
    Friend WithEvents CboCategoria As ComboBox
    Friend WithEvents Label1 As Label
    Friend WithEvents RBTodos As RadioButton
    Friend WithEvents RBConExist As RadioButton
    Friend WithEvents RBSinExist As RadioButton
    Friend WithEvents RBMax As RadioButton
    Friend WithEvents RBMin As RadioButton
    Friend WithEvents CboOrden As ComboBox
    Friend WithEvents Label3 As Label
    Friend WithEvents CboAscDesc As ComboBox
    Friend WithEvents Label5 As Label
End Class
