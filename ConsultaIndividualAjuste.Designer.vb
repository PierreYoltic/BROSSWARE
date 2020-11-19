<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ConsultaIndividualAjuste
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
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.LblDate = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.LblUsuario = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.LblComentario = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.DataGridViewAjuste = New System.Windows.Forms.DataGridView()
        Me.codigo = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.descripcion = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.existencia = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Panel1.SuspendLayout()
        CType(Me.DataGridViewAjuste, System.ComponentModel.ISupportInitialize).BeginInit()
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
        Me.Panel1.Size = New System.Drawing.Size(664, 41)
        Me.Panel1.TabIndex = 3
        '
        'Button1
        '
        Me.Button1.BackgroundImage = Global.MotoBox.My.Resources.Resources._084_multiply
        Me.Button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.Button1.Dock = System.Windows.Forms.DockStyle.Right
        Me.Button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button1.Location = New System.Drawing.Point(623, 0)
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
        Me.Label1.Location = New System.Drawing.Point(191, 8)
        Me.Label1.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(268, 21)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Consulta de Ajuste de Inventario"
        '
        'LblDate
        '
        Me.LblDate.AutoSize = True
        Me.LblDate.Font = New System.Drawing.Font("Century Gothic", 12.0!)
        Me.LblDate.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.LblDate.Location = New System.Drawing.Point(491, 43)
        Me.LblDate.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.LblDate.Name = "LblDate"
        Me.LblDate.Size = New System.Drawing.Size(162, 21)
        Me.LblDate.TabIndex = 21
        Me.LblDate.Text = "00/00/0000 00:00:00"
        Me.LblDate.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Century Gothic", 12.0!)
        Me.Label4.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Label4.Location = New System.Drawing.Point(371, 43)
        Me.Label4.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(116, 21)
        Me.Label4.TabIndex = 20
        Me.Label4.Text = "Fecha y Hora:"
        Me.Label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'LblUsuario
        '
        Me.LblUsuario.AutoSize = True
        Me.LblUsuario.Font = New System.Drawing.Font("Century Gothic", 12.0!)
        Me.LblUsuario.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.LblUsuario.Location = New System.Drawing.Point(85, 43)
        Me.LblUsuario.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.LblUsuario.Name = "LblUsuario"
        Me.LblUsuario.Size = New System.Drawing.Size(66, 21)
        Me.LblUsuario.TabIndex = 23
        Me.LblUsuario.Text = "Usuario"
        Me.LblUsuario.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Century Gothic", 12.0!)
        Me.Label3.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Label3.Location = New System.Drawing.Point(11, 43)
        Me.Label3.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(70, 21)
        Me.Label3.TabIndex = 22
        Me.Label3.Text = "Usuario:"
        Me.Label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'LblComentario
        '
        Me.LblComentario.Font = New System.Drawing.Font("Century Gothic", 12.0!)
        Me.LblComentario.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.LblComentario.Location = New System.Drawing.Point(123, 75)
        Me.LblComentario.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.LblComentario.Name = "LblComentario"
        Me.LblComentario.Size = New System.Drawing.Size(530, 21)
        Me.LblComentario.TabIndex = 25
        Me.LblComentario.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Century Gothic", 12.0!)
        Me.Label6.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Label6.Location = New System.Drawing.Point(11, 75)
        Me.Label6.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(108, 21)
        Me.Label6.TabIndex = 24
        Me.Label6.Text = "Comentario:"
        Me.Label6.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'DataGridViewAjuste
        '
        Me.DataGridViewAjuste.AllowUserToAddRows = False
        Me.DataGridViewAjuste.AllowUserToDeleteRows = False
        Me.DataGridViewAjuste.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.DataGridViewAjuste.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridViewAjuste.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.codigo, Me.descripcion, Me.existencia})
        Me.DataGridViewAjuste.Location = New System.Drawing.Point(15, 111)
        Me.DataGridViewAjuste.Name = "DataGridViewAjuste"
        Me.DataGridViewAjuste.ReadOnly = True
        Me.DataGridViewAjuste.Size = New System.Drawing.Size(638, 288)
        Me.DataGridViewAjuste.TabIndex = 26
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
        'existencia
        '
        Me.existencia.HeaderText = "Existencia"
        Me.existencia.Name = "existencia"
        Me.existencia.ReadOnly = True
        '
        'ConsultaIndividualAjuste
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(664, 411)
        Me.Controls.Add(Me.DataGridViewAjuste)
        Me.Controls.Add(Me.LblComentario)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.LblUsuario)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.LblDate)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Panel1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "ConsultaIndividualAjuste"
        Me.Text = "ConsultaIndividualAjuste"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        CType(Me.DataGridViewAjuste, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Panel1 As Panel
    Friend WithEvents Button1 As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents LblDate As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents LblUsuario As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents LblComentario As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents DataGridViewAjuste As DataGridView
    Friend WithEvents codigo As DataGridViewTextBoxColumn
    Friend WithEvents descripcion As DataGridViewTextBoxColumn
    Friend WithEvents existencia As DataGridViewTextBoxColumn
End Class
