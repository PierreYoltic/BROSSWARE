<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class AjusteInventario
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
        Me.BtnAjustar = New System.Windows.Forms.Button()
        Me.BtnRemover = New System.Windows.Forms.Button()
        Me.BtnEditar = New System.Windows.Forms.Button()
        Me.BtnBuscar = New System.Windows.Forms.Button()
        Me.Panel5 = New System.Windows.Forms.Panel()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.TxtCodigoBarras = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.TxtComentario = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.DataGridViewAjuste = New System.Windows.Forms.DataGridView()
        Me.codigo = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.descripcion = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.nueva = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.existencia = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.diferencia = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Panel1.SuspendLayout()
        Me.Panel5.SuspendLayout()
        CType(Me.DataGridViewAjuste, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.FromArgb(CType(CType(27, Byte), Integer), CType(CType(38, Byte), Integer), CType(CType(69, Byte), Integer))
        Me.Panel1.Controls.Add(Me.BtnAjustar)
        Me.Panel1.Controls.Add(Me.BtnRemover)
        Me.Panel1.Controls.Add(Me.BtnEditar)
        Me.Panel1.Controls.Add(Me.BtnBuscar)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Margin = New System.Windows.Forms.Padding(2)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(774, 65)
        Me.Panel1.TabIndex = 2
        '
        'BtnAjustar
        '
        Me.BtnAjustar.FlatAppearance.BorderSize = 0
        Me.BtnAjustar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnAjustar.Font = New System.Drawing.Font("Century Gothic", 7.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnAjustar.ForeColor = System.Drawing.Color.White
        Me.BtnAjustar.Image = Global.MotoBox.My.Resources.Resources._033_handshake
        Me.BtnAjustar.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.BtnAjustar.Location = New System.Drawing.Point(266, 0)
        Me.BtnAjustar.Margin = New System.Windows.Forms.Padding(2)
        Me.BtnAjustar.Name = "BtnAjustar"
        Me.BtnAjustar.Padding = New System.Windows.Forms.Padding(0, 4, 0, 4)
        Me.BtnAjustar.Size = New System.Drawing.Size(88, 65)
        Me.BtnAjustar.TabIndex = 4
        Me.BtnAjustar.Text = "Ajustar"
        Me.BtnAjustar.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.BtnAjustar.UseVisualStyleBackColor = True
        '
        'BtnRemover
        '
        Me.BtnRemover.FlatAppearance.BorderSize = 0
        Me.BtnRemover.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnRemover.Font = New System.Drawing.Font("Century Gothic", 7.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnRemover.ForeColor = System.Drawing.Color.White
        Me.BtnRemover.Image = Global.MotoBox.My.Resources.Resources._058_error
        Me.BtnRemover.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.BtnRemover.Location = New System.Drawing.Point(178, 0)
        Me.BtnRemover.Margin = New System.Windows.Forms.Padding(2)
        Me.BtnRemover.Name = "BtnRemover"
        Me.BtnRemover.Padding = New System.Windows.Forms.Padding(0, 4, 0, 4)
        Me.BtnRemover.Size = New System.Drawing.Size(88, 65)
        Me.BtnRemover.TabIndex = 3
        Me.BtnRemover.Text = "Remover"
        Me.BtnRemover.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.BtnRemover.UseVisualStyleBackColor = True
        '
        'BtnEditar
        '
        Me.BtnEditar.FlatAppearance.BorderSize = 0
        Me.BtnEditar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnEditar.Font = New System.Drawing.Font("Century Gothic", 7.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnEditar.ForeColor = System.Drawing.Color.White
        Me.BtnEditar.Image = Global.MotoBox.My.Resources.Resources._279_edit
        Me.BtnEditar.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.BtnEditar.Location = New System.Drawing.Point(90, 0)
        Me.BtnEditar.Margin = New System.Windows.Forms.Padding(2)
        Me.BtnEditar.Name = "BtnEditar"
        Me.BtnEditar.Padding = New System.Windows.Forms.Padding(0, 4, 0, 4)
        Me.BtnEditar.Size = New System.Drawing.Size(88, 65)
        Me.BtnEditar.TabIndex = 2
        Me.BtnEditar.Text = "Editar"
        Me.BtnEditar.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.BtnEditar.UseVisualStyleBackColor = True
        '
        'BtnBuscar
        '
        Me.BtnBuscar.FlatAppearance.BorderSize = 0
        Me.BtnBuscar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnBuscar.Font = New System.Drawing.Font("Century Gothic", 7.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnBuscar.ForeColor = System.Drawing.Color.White
        Me.BtnBuscar.Image = Global.MotoBox.My.Resources.Resources._313_search
        Me.BtnBuscar.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.BtnBuscar.Location = New System.Drawing.Point(2, 0)
        Me.BtnBuscar.Margin = New System.Windows.Forms.Padding(2)
        Me.BtnBuscar.Name = "BtnBuscar"
        Me.BtnBuscar.Padding = New System.Windows.Forms.Padding(0, 4, 0, 4)
        Me.BtnBuscar.Size = New System.Drawing.Size(88, 65)
        Me.BtnBuscar.TabIndex = 0
        Me.BtnBuscar.Text = "Buscar"
        Me.BtnBuscar.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.BtnBuscar.UseVisualStyleBackColor = True
        '
        'Panel5
        '
        Me.Panel5.Controls.Add(Me.Button1)
        Me.Panel5.Controls.Add(Me.TxtCodigoBarras)
        Me.Panel5.Controls.Add(Me.Label4)
        Me.Panel5.Controls.Add(Me.TxtComentario)
        Me.Panel5.Controls.Add(Me.Label5)
        Me.Panel5.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel5.Location = New System.Drawing.Point(0, 65)
        Me.Panel5.Margin = New System.Windows.Forms.Padding(2)
        Me.Panel5.Name = "Panel5"
        Me.Panel5.Size = New System.Drawing.Size(774, 80)
        Me.Panel5.TabIndex = 3
        '
        'Button1
        '
        Me.Button1.FlatAppearance.BorderSize = 0
        Me.Button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button1.Font = New System.Drawing.Font("Century Gothic", 7.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button1.ForeColor = System.Drawing.Color.White
        Me.Button1.Image = Global.MotoBox.My.Resources.Resources._313_search
        Me.Button1.Location = New System.Drawing.Point(737, 42)
        Me.Button1.Margin = New System.Windows.Forms.Padding(2)
        Me.Button1.Name = "Button1"
        Me.Button1.Padding = New System.Windows.Forms.Padding(0, 4, 0, 4)
        Me.Button1.Size = New System.Drawing.Size(25, 25)
        Me.Button1.TabIndex = 13
        Me.Button1.UseVisualStyleBackColor = True
        '
        'TxtCodigoBarras
        '
        Me.TxtCodigoBarras.Font = New System.Drawing.Font("Century Gothic", 11.0!)
        Me.TxtCodigoBarras.Location = New System.Drawing.Point(478, 42)
        Me.TxtCodigoBarras.Margin = New System.Windows.Forms.Padding(2)
        Me.TxtCodigoBarras.Name = "TxtCodigoBarras"
        Me.TxtCodigoBarras.Size = New System.Drawing.Size(252, 25)
        Me.TxtCodigoBarras.TabIndex = 12
        '
        'Label4
        '
        Me.Label4.Font = New System.Drawing.Font("Century Gothic", 11.0!)
        Me.Label4.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Label4.Location = New System.Drawing.Point(311, 44)
        Me.Label4.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(169, 19)
        Me.Label4.TabIndex = 11
        Me.Label4.Text = "Código de Barras:"
        Me.Label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'TxtComentario
        '
        Me.TxtComentario.Font = New System.Drawing.Font("Century Gothic", 11.0!)
        Me.TxtComentario.Location = New System.Drawing.Point(114, 12)
        Me.TxtComentario.Name = "TxtComentario"
        Me.TxtComentario.Size = New System.Drawing.Size(648, 25)
        Me.TxtComentario.TabIndex = 10
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Century Gothic", 11.0!)
        Me.Label5.Location = New System.Drawing.Point(8, 12)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(100, 20)
        Me.Label5.TabIndex = 9
        Me.Label5.Text = "Comentario:"
        '
        'DataGridViewAjuste
        '
        Me.DataGridViewAjuste.AllowUserToAddRows = False
        Me.DataGridViewAjuste.AllowUserToDeleteRows = False
        Me.DataGridViewAjuste.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.DataGridViewAjuste.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridViewAjuste.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.codigo, Me.descripcion, Me.nueva, Me.existencia, Me.diferencia})
        Me.DataGridViewAjuste.Dock = System.Windows.Forms.DockStyle.Fill
        Me.DataGridViewAjuste.Location = New System.Drawing.Point(0, 145)
        Me.DataGridViewAjuste.Name = "DataGridViewAjuste"
        Me.DataGridViewAjuste.ReadOnly = True
        Me.DataGridViewAjuste.Size = New System.Drawing.Size(774, 304)
        Me.DataGridViewAjuste.TabIndex = 4
        '
        'codigo
        '
        Me.codigo.HeaderText = "Código"
        Me.codigo.Name = "codigo"
        Me.codigo.ReadOnly = True
        '
        'descripcion
        '
        Me.descripcion.HeaderText = "Descripción"
        Me.descripcion.Name = "descripcion"
        Me.descripcion.ReadOnly = True
        '
        'nueva
        '
        Me.nueva.HeaderText = "Nueva Existencia"
        Me.nueva.Name = "nueva"
        Me.nueva.ReadOnly = True
        '
        'existencia
        '
        Me.existencia.HeaderText = "Existencia Actual"
        Me.existencia.Name = "existencia"
        Me.existencia.ReadOnly = True
        '
        'diferencia
        '
        Me.diferencia.HeaderText = "Diferencia"
        Me.diferencia.Name = "diferencia"
        Me.diferencia.ReadOnly = True
        '
        'AjusteInventario
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(774, 449)
        Me.Controls.Add(Me.DataGridViewAjuste)
        Me.Controls.Add(Me.Panel5)
        Me.Controls.Add(Me.Panel1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "AjusteInventario"
        Me.Text = "AjusteInventario"
        Me.Panel1.ResumeLayout(False)
        Me.Panel5.ResumeLayout(False)
        Me.Panel5.PerformLayout()
        CType(Me.DataGridViewAjuste, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Panel1 As Panel
    Friend WithEvents BtnRemover As Button
    Friend WithEvents BtnEditar As Button
    Friend WithEvents BtnBuscar As Button
    Friend WithEvents Panel5 As Panel
    Friend WithEvents TxtComentario As TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents BtnAjustar As Button
    Friend WithEvents DataGridViewAjuste As DataGridView
    Friend WithEvents codigo As DataGridViewTextBoxColumn
    Friend WithEvents descripcion As DataGridViewTextBoxColumn
    Friend WithEvents nueva As DataGridViewTextBoxColumn
    Friend WithEvents existencia As DataGridViewTextBoxColumn
    Friend WithEvents diferencia As DataGridViewTextBoxColumn
    Friend WithEvents Button1 As Button
    Friend WithEvents TxtCodigoBarras As TextBox
    Friend WithEvents Label4 As Label
End Class
