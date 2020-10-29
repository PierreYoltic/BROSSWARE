<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmDescuento
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
        Me.Label1 = New System.Windows.Forms.Label()
        Me.BtnCancelar = New System.Windows.Forms.Button()
        Me.BtnGuardar = New System.Windows.Forms.Button()
        Me.TxtDescuento = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Panel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.FromArgb(CType(CType(27, Byte), Integer), CType(CType(38, Byte), Integer), CType(CType(69, Byte), Integer))
        Me.Panel1.Controls.Add(Me.Label1)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(450, 50)
        Me.Panel1.TabIndex = 36
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Century Gothic", 12.0!)
        Me.Label1.ForeColor = System.Drawing.Color.WhiteSmoke
        Me.Label1.Location = New System.Drawing.Point(162, 14)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(126, 23)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "DESCUENTO"
        '
        'BtnCancelar
        '
        Me.BtnCancelar.BackColor = System.Drawing.SystemColors.ControlDark
        Me.BtnCancelar.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.BtnCancelar.Font = New System.Drawing.Font("Century Gothic", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnCancelar.ForeColor = System.Drawing.Color.Black
        Me.BtnCancelar.Image = Global.MotoBox.My.Resources.Resources._074_bin
        Me.BtnCancelar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.BtnCancelar.Location = New System.Drawing.Point(242, 201)
        Me.BtnCancelar.Name = "BtnCancelar"
        Me.BtnCancelar.Padding = New System.Windows.Forms.Padding(5, 0, 0, 0)
        Me.BtnCancelar.Size = New System.Drawing.Size(186, 48)
        Me.BtnCancelar.TabIndex = 38
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
        Me.BtnGuardar.Location = New System.Drawing.Point(22, 201)
        Me.BtnGuardar.Name = "BtnGuardar"
        Me.BtnGuardar.Padding = New System.Windows.Forms.Padding(5, 0, 0, 0)
        Me.BtnGuardar.Size = New System.Drawing.Size(186, 48)
        Me.BtnGuardar.TabIndex = 37
        Me.BtnGuardar.Text = "      Aplicar"
        Me.BtnGuardar.UseVisualStyleBackColor = False
        '
        'TxtDescuento
        '
        Me.TxtDescuento.Font = New System.Drawing.Font("Century Gothic", 24.0!)
        Me.TxtDescuento.Location = New System.Drawing.Point(119, 122)
        Me.TxtDescuento.Name = "TxtDescuento"
        Me.TxtDescuento.Size = New System.Drawing.Size(212, 57)
        Me.TxtDescuento.TabIndex = 39
        Me.TxtDescuento.Text = "00.00"
        Me.TxtDescuento.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Century Gothic", 16.0!)
        Me.Label2.Location = New System.Drawing.Point(53, 68)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(331, 33)
        Me.Label2.TabIndex = 40
        Me.Label2.Text = "MONTO DEL DESCUENTO"
        '
        'FrmDescuento
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(450, 271)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.TxtDescuento)
        Me.Controls.Add(Me.BtnCancelar)
        Me.Controls.Add(Me.BtnGuardar)
        Me.Controls.Add(Me.Panel1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "FrmDescuento"
        Me.Text = "Descuento"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents BtnCancelar As Button
    Friend WithEvents BtnGuardar As Button
    Friend WithEvents Panel1 As Panel
    Friend WithEvents Label1 As Label
    Friend WithEvents TxtDescuento As TextBox
    Friend WithEvents Label2 As Label
End Class
