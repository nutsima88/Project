<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class sale
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
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txtSaleAcer = New System.Windows.Forms.TextBox()
        Me.txtSaleHP = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.lblTotalSale = New System.Windows.Forms.Label()
        Me.lblComAcer = New System.Windows.Forms.Label()
        Me.lblComHP = New System.Windows.Forms.Label()
        Me.lblTotalCom = New System.Windows.Forms.Label()
        Me.btnCal = New System.Windows.Forms.Button()
        Me.btnClose = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(174, 48)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(230, 20)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "โปรแกรมคำนวนยอยขายคอมพิวเตอร์"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(71, 116)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(191, 20)
        Me.Label2.TabIndex = 0
        Me.Label2.Text = "Computer Acer Veriton x5"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(71, 165)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(148, 20)
        Me.Label3.TabIndex = 0
        Me.Label3.Text = "Printer HP M529DN"
        '
        'txtSaleAcer
        '
        Me.txtSaleAcer.Location = New System.Drawing.Point(418, 116)
        Me.txtSaleAcer.Name = "txtSaleAcer"
        Me.txtSaleAcer.Size = New System.Drawing.Size(100, 20)
        Me.txtSaleAcer.TabIndex = 1
        '
        'txtSaleHP
        '
        Me.txtSaleHP.Location = New System.Drawing.Point(418, 165)
        Me.txtSaleHP.Name = "txtSaleHP"
        Me.txtSaleHP.Size = New System.Drawing.Size(100, 20)
        Me.txtSaleHP.TabIndex = 1
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(71, 207)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(82, 20)
        Me.Label4.TabIndex = 0
        Me.Label4.Text = "รวมยอดขาย"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(71, 267)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(275, 20)
        Me.Label5.TabIndex = 0
        Me.Label5.Text = "ค่าคอมมิชชั่น Computer Acer Veriton x5"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(71, 310)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(232, 20)
        Me.Label6.TabIndex = 0
        Me.Label6.Text = "ค่าคอมมิชชั่น Printer HP M529DN"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(71, 353)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(113, 20)
        Me.Label7.TabIndex = 0
        Me.Label7.Text = "รวมค่าคอมมิชชั่น"
        '
        'lblTotalSale
        '
        Me.lblTotalSale.BackColor = System.Drawing.Color.MediumOrchid
        Me.lblTotalSale.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblTotalSale.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.lblTotalSale.Location = New System.Drawing.Point(418, 204)
        Me.lblTotalSale.Name = "lblTotalSale"
        Me.lblTotalSale.Size = New System.Drawing.Size(100, 23)
        Me.lblTotalSale.TabIndex = 2
        '
        'lblComAcer
        '
        Me.lblComAcer.BackColor = System.Drawing.Color.Plum
        Me.lblComAcer.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblComAcer.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.lblComAcer.Location = New System.Drawing.Point(418, 271)
        Me.lblComAcer.Name = "lblComAcer"
        Me.lblComAcer.Size = New System.Drawing.Size(100, 23)
        Me.lblComAcer.TabIndex = 2
        '
        'lblComHP
        '
        Me.lblComHP.BackColor = System.Drawing.Color.Plum
        Me.lblComHP.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblComHP.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.lblComHP.Location = New System.Drawing.Point(418, 310)
        Me.lblComHP.Name = "lblComHP"
        Me.lblComHP.Size = New System.Drawing.Size(100, 23)
        Me.lblComHP.TabIndex = 2
        '
        'lblTotalCom
        '
        Me.lblTotalCom.BackColor = System.Drawing.Color.MediumOrchid
        Me.lblTotalCom.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblTotalCom.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.lblTotalCom.Location = New System.Drawing.Point(418, 350)
        Me.lblTotalCom.Name = "lblTotalCom"
        Me.lblTotalCom.Size = New System.Drawing.Size(100, 23)
        Me.lblTotalCom.TabIndex = 2
        '
        'btnCal
        '
        Me.btnCal.BackColor = System.Drawing.Color.DeepPink
        Me.btnCal.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnCal.Location = New System.Drawing.Point(252, 396)
        Me.btnCal.Name = "btnCal"
        Me.btnCal.Size = New System.Drawing.Size(94, 30)
        Me.btnCal.TabIndex = 3
        Me.btnCal.Text = "คำนวณ"
        Me.btnCal.UseVisualStyleBackColor = False
        '
        'btnClose
        '
        Me.btnClose.BackColor = System.Drawing.Color.DeepPink
        Me.btnClose.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnClose.Location = New System.Drawing.Point(380, 396)
        Me.btnClose.Name = "btnClose"
        Me.btnClose.Size = New System.Drawing.Size(94, 30)
        Me.btnClose.TabIndex = 3
        Me.btnClose.Text = "ปิด"
        Me.btnClose.UseVisualStyleBackColor = False
        '
        'sale
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.btnClose)
        Me.Controls.Add(Me.btnCal)
        Me.Controls.Add(Me.lblTotalCom)
        Me.Controls.Add(Me.lblComHP)
        Me.Controls.Add(Me.lblComAcer)
        Me.Controls.Add(Me.lblTotalSale)
        Me.Controls.Add(Me.txtSaleHP)
        Me.Controls.Add(Me.txtSaleAcer)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Name = "sale"
        Me.Text = "sale"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents txtSaleAcer As TextBox
    Friend WithEvents txtSaleHP As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents lblTotalSale As Label
    Friend WithEvents lblComAcer As Label
    Friend WithEvents lblComHP As Label
    Friend WithEvents lblTotalCom As Label
    Friend WithEvents btnCal As Button
    Friend WithEvents btnClose As Button
End Class
