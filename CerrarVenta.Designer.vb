<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class CerrarVenta
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
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.LblTotal = New System.Windows.Forms.Label()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.LblCliente = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.TxtComentario = New System.Windows.Forms.TextBox()
        Me.LblCambio = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.BtnGuardar = New System.Windows.Forms.Button()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.TxtEfectivo = New System.Windows.Forms.TextBox()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.Panel1.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel2.SuspendLayout()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.FromArgb(CType(CType(32, Byte), Integer), CType(CType(43, Byte), Integer), CType(CType(76, Byte), Integer))
        Me.Panel1.Controls.Add(Me.Button2)
        Me.Panel1.Controls.Add(Me.Button1)
        Me.Panel1.Controls.Add(Me.Label1)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Margin = New System.Windows.Forms.Padding(2)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(450, 40)
        Me.Panel1.TabIndex = 2
        '
        'Button2
        '
        Me.Button2.BackgroundImage = Global.MotoBox.My.Resources.Resources._084_multiply
        Me.Button2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.Button2.Dock = System.Windows.Forms.DockStyle.Right
        Me.Button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button2.Location = New System.Drawing.Point(410, 0)
        Me.Button2.Margin = New System.Windows.Forms.Padding(2)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(40, 40)
        Me.Button2.TabIndex = 2
        Me.Button2.UseVisualStyleBackColor = True
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
        Me.Label1.Location = New System.Drawing.Point(169, 10)
        Me.Label1.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(112, 21)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Cerrar Venta"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Century Gothic", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.DodgerBlue
        Me.Label2.Location = New System.Drawing.Point(174, 56)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(103, 18)
        Me.Label2.TabIndex = 3
        Me.Label2.Text = "Total a Pagar"
        '
        'LblTotal
        '
        Me.LblTotal.AutoSize = True
        Me.LblTotal.Font = New System.Drawing.Font("Century Gothic", 24.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblTotal.ForeColor = System.Drawing.Color.DodgerBlue
        Me.LblTotal.Location = New System.Drawing.Point(121, 74)
        Me.LblTotal.Name = "LblTotal"
        Me.LblTotal.Size = New System.Drawing.Size(209, 38)
        Me.LblTotal.TabIndex = 4
        Me.LblTotal.Text = "$ 00.00 MXN"
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = Global.MotoBox.My.Resources.Resources._359_users
        Me.PictureBox1.Location = New System.Drawing.Point(13, 327)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(32, 32)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox1.TabIndex = 5
        Me.PictureBox1.TabStop = False
        '
        'LblCliente
        '
        Me.LblCliente.AutoSize = True
        Me.LblCliente.Font = New System.Drawing.Font("Century Gothic", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblCliente.ForeColor = System.Drawing.Color.DodgerBlue
        Me.LblCliente.Location = New System.Drawing.Point(51, 334)
        Me.LblCliente.Name = "LblCliente"
        Me.LblCliente.Size = New System.Drawing.Size(151, 18)
        Me.LblCliente.TabIndex = 6
        Me.LblCliente.Text = "Público en General"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Century Gothic", 11.0!)
        Me.Label5.Location = New System.Drawing.Point(14, 231)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(100, 20)
        Me.Label5.TabIndex = 7
        Me.Label5.Text = "Comentario:"
        '
        'TxtComentario
        '
        Me.TxtComentario.Font = New System.Drawing.Font("Century Gothic", 11.0!)
        Me.TxtComentario.Location = New System.Drawing.Point(18, 254)
        Me.TxtComentario.Name = "TxtComentario"
        Me.TxtComentario.Size = New System.Drawing.Size(419, 25)
        Me.TxtComentario.TabIndex = 8
        '
        'LblCambio
        '
        Me.LblCambio.AutoSize = True
        Me.LblCambio.Dock = System.Windows.Forms.DockStyle.Right
        Me.LblCambio.Font = New System.Drawing.Font("Century Gothic", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblCambio.ForeColor = System.Drawing.Color.ForestGreen
        Me.LblCambio.Location = New System.Drawing.Point(41, 0)
        Me.LblCambio.Name = "LblCambio"
        Me.LblCambio.Size = New System.Drawing.Size(154, 28)
        Me.LblCambio.TabIndex = 10
        Me.LblCambio.Text = "$ 00.00 MXN"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Century Gothic", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.ForeColor = System.Drawing.Color.ForestGreen
        Me.Label7.Location = New System.Drawing.Point(366, 312)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(68, 18)
        Me.Label7.TabIndex = 9
        Me.Label7.Text = "Cambio"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(14, 208)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(427, 13)
        Me.Label8.TabIndex = 11
        Me.Label8.Text = "______________________________________________________________________"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(14, 280)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(427, 13)
        Me.Label9.TabIndex = 12
        Me.Label9.Text = "______________________________________________________________________"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(12, 379)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(427, 13)
        Me.Label10.TabIndex = 13
        Me.Label10.Text = "______________________________________________________________________"
        '
        'BtnGuardar
        '
        Me.BtnGuardar.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(80, Byte), Integer), CType(CType(200, Byte), Integer))
        Me.BtnGuardar.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.BtnGuardar.Font = New System.Drawing.Font("Century Gothic", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnGuardar.ForeColor = System.Drawing.Color.White
        Me.BtnGuardar.Image = Global.MotoBox.My.Resources.Resources._008_tick_mark
        Me.BtnGuardar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.BtnGuardar.Location = New System.Drawing.Point(157, 399)
        Me.BtnGuardar.Margin = New System.Windows.Forms.Padding(2)
        Me.BtnGuardar.Name = "BtnGuardar"
        Me.BtnGuardar.Padding = New System.Windows.Forms.Padding(4, 0, 0, 0)
        Me.BtnGuardar.Size = New System.Drawing.Size(140, 40)
        Me.BtnGuardar.TabIndex = 14
        Me.BtnGuardar.Text = "      Aceptar"
        Me.BtnGuardar.UseVisualStyleBackColor = False
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Location = New System.Drawing.Point(11, 130)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(427, 13)
        Me.Label12.TabIndex = 17
        Me.Label12.Text = "______________________________________________________________________"
        '
        'TxtEfectivo
        '
        Me.TxtEfectivo.Font = New System.Drawing.Font("Century Gothic", 11.0!)
        Me.TxtEfectivo.ForeColor = System.Drawing.Color.DodgerBlue
        Me.TxtEfectivo.Location = New System.Drawing.Point(124, 180)
        Me.TxtEfectivo.Name = "TxtEfectivo"
        Me.TxtEfectivo.Size = New System.Drawing.Size(202, 25)
        Me.TxtEfectivo.TabIndex = 16
        Me.TxtEfectivo.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Font = New System.Drawing.Font("Century Gothic", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label13.ForeColor = System.Drawing.Color.DimGray
        Me.Label13.Location = New System.Drawing.Point(184, 157)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(83, 18)
        Me.Label13.TabIndex = 15
        Me.Label13.Text = "Pagó con:"
        '
        'Panel2
        '
        Me.Panel2.Controls.Add(Me.LblCambio)
        Me.Panel2.Location = New System.Drawing.Point(242, 330)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(195, 35)
        Me.Panel2.TabIndex = 18
        '
        'CerrarVenta
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.WhiteSmoke
        Me.ClientSize = New System.Drawing.Size(450, 450)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Label12)
        Me.Controls.Add(Me.TxtEfectivo)
        Me.Controls.Add(Me.Label13)
        Me.Controls.Add(Me.BtnGuardar)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.TxtComentario)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.LblCliente)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.LblTotal)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Panel1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "CerrarVenta"
        Me.Text = "CerrarVenta"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Button1 As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents Button2 As Button
    Friend WithEvents Panel1 As Panel
    Friend WithEvents Label2 As Label
    Friend WithEvents LblTotal As Label
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents LblCliente As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents TxtComentario As TextBox
    Friend WithEvents LblCambio As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents Label10 As Label
    Friend WithEvents BtnGuardar As Button
    Friend WithEvents Label12 As Label
    Friend WithEvents TxtEfectivo As TextBox
    Friend WithEvents Label13 As Label
    Friend WithEvents Panel2 As Panel
End Class
