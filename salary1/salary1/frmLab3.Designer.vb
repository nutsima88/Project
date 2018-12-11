<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmLab3
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
        Me.txtInput = New System.Windows.Forms.TextBox()
        Me.btnUp = New System.Windows.Forms.Button()
        Me.btnDown = New System.Windows.Forms.Button()
        Me.cboSize = New System.Windows.Forms.ComboBox()
        Me.label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.lblFBlue = New System.Windows.Forms.Label()
        Me.lblFYellow = New System.Windows.Forms.Label()
        Me.lblFSky = New System.Windows.Forms.Label()
        Me.lblFBlack = New System.Windows.Forms.Label()
        Me.lblFViolet = New System.Windows.Forms.Label()
        Me.lblFWhite = New System.Windows.Forms.Label()
        Me.lblFBrown = New System.Windows.Forms.Label()
        Me.lblFGreen = New System.Windows.Forms.Label()
        Me.lblFRed = New System.Windows.Forms.Label()
        Me.lblFOrange = New System.Windows.Forms.Label()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.lblBBlue = New System.Windows.Forms.Label()
        Me.lblBYellow = New System.Windows.Forms.Label()
        Me.lblBSky = New System.Windows.Forms.Label()
        Me.lblBBlack = New System.Windows.Forms.Label()
        Me.lblBViolet = New System.Windows.Forms.Label()
        Me.lblBWhite = New System.Windows.Forms.Label()
        Me.lblBBrown = New System.Windows.Forms.Label()
        Me.lblBGreen = New System.Windows.Forms.Label()
        Me.lblBRed = New System.Windows.Forms.Label()
        Me.lblBOrange = New System.Windows.Forms.Label()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.GroupBox2.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'txtInput
        '
        Me.txtInput.Location = New System.Drawing.Point(170, 72)
        Me.txtInput.Multiline = True
        Me.txtInput.Name = "txtInput"
        Me.txtInput.Size = New System.Drawing.Size(325, 74)
        Me.txtInput.TabIndex = 0
        '
        'btnUp
        '
        Me.btnUp.BackColor = System.Drawing.Color.DarkGray
        Me.btnUp.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnUp.Location = New System.Drawing.Point(492, 72)
        Me.btnUp.Name = "btnUp"
        Me.btnUp.Size = New System.Drawing.Size(35, 37)
        Me.btnUp.TabIndex = 1
        Me.btnUp.Text = "+"
        Me.btnUp.UseVisualStyleBackColor = False
        '
        'btnDown
        '
        Me.btnDown.BackColor = System.Drawing.Color.DarkGray
        Me.btnDown.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnDown.Location = New System.Drawing.Point(492, 107)
        Me.btnDown.Name = "btnDown"
        Me.btnDown.Size = New System.Drawing.Size(35, 39)
        Me.btnDown.TabIndex = 1
        Me.btnDown.Text = "-"
        Me.btnDown.UseVisualStyleBackColor = False
        '
        'cboSize
        '
        Me.cboSize.FormattingEnabled = True
        Me.cboSize.Items.AddRange(New Object() {"10", "12", "14", "16", "20", "22", "24", "26", "28", "30", "32", "34", "36", "38", "40"})
        Me.cboSize.Location = New System.Drawing.Point(374, 161)
        Me.cboSize.Name = "cboSize"
        Me.cboSize.Size = New System.Drawing.Size(121, 21)
        Me.cboSize.TabIndex = 3
        '
        'label1
        '
        Me.label1.AutoSize = True
        Me.label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.label1.Location = New System.Drawing.Point(82, 72)
        Me.label1.Name = "label1"
        Me.label1.Size = New System.Drawing.Size(82, 18)
        Me.label1.TabIndex = 4
        Me.label1.Text = "กำหนดตัวเลข"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(271, 161)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(74, 18)
        Me.Label2.TabIndex = 4
        Me.Label2.Text = "ขนาดฟอนต์"
        '
        'GroupBox2
        '
        Me.GroupBox2.BackColor = System.Drawing.SystemColors.ControlLight
        Me.GroupBox2.Controls.Add(Me.lblFBlue)
        Me.GroupBox2.Controls.Add(Me.lblFYellow)
        Me.GroupBox2.Controls.Add(Me.lblFSky)
        Me.GroupBox2.Controls.Add(Me.lblFBlack)
        Me.GroupBox2.Controls.Add(Me.lblFViolet)
        Me.GroupBox2.Controls.Add(Me.lblFWhite)
        Me.GroupBox2.Controls.Add(Me.lblFBrown)
        Me.GroupBox2.Controls.Add(Me.lblFGreen)
        Me.GroupBox2.Controls.Add(Me.lblFRed)
        Me.GroupBox2.Controls.Add(Me.lblFOrange)
        Me.GroupBox2.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox2.Location = New System.Drawing.Point(85, 224)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(260, 136)
        Me.GroupBox2.TabIndex = 2
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "ForeColor"
        '
        'lblFBlue
        '
        Me.lblFBlue.BackColor = System.Drawing.Color.Blue
        Me.lblFBlue.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblFBlue.Location = New System.Drawing.Point(64, 30)
        Me.lblFBlue.Name = "lblFBlue"
        Me.lblFBlue.Size = New System.Drawing.Size(40, 35)
        Me.lblFBlue.TabIndex = 5
        '
        'lblFYellow
        '
        Me.lblFYellow.BackColor = System.Drawing.Color.Yellow
        Me.lblFYellow.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblFYellow.Location = New System.Drawing.Point(64, 75)
        Me.lblFYellow.Name = "lblFYellow"
        Me.lblFYellow.Size = New System.Drawing.Size(40, 35)
        Me.lblFYellow.TabIndex = 5
        '
        'lblFSky
        '
        Me.lblFSky.BackColor = System.Drawing.Color.SkyBlue
        Me.lblFSky.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblFSky.Location = New System.Drawing.Point(202, 75)
        Me.lblFSky.Name = "lblFSky"
        Me.lblFSky.Size = New System.Drawing.Size(40, 35)
        Me.lblFSky.TabIndex = 5
        '
        'lblFBlack
        '
        Me.lblFBlack.BackColor = System.Drawing.Color.Black
        Me.lblFBlack.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblFBlack.Location = New System.Drawing.Point(202, 30)
        Me.lblFBlack.Name = "lblFBlack"
        Me.lblFBlack.Size = New System.Drawing.Size(40, 35)
        Me.lblFBlack.TabIndex = 5
        '
        'lblFViolet
        '
        Me.lblFViolet.BackColor = System.Drawing.Color.Violet
        Me.lblFViolet.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblFViolet.Location = New System.Drawing.Point(156, 30)
        Me.lblFViolet.Name = "lblFViolet"
        Me.lblFViolet.Size = New System.Drawing.Size(40, 35)
        Me.lblFViolet.TabIndex = 5
        '
        'lblFWhite
        '
        Me.lblFWhite.BackColor = System.Drawing.Color.White
        Me.lblFWhite.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblFWhite.Location = New System.Drawing.Point(156, 75)
        Me.lblFWhite.Name = "lblFWhite"
        Me.lblFWhite.Size = New System.Drawing.Size(40, 35)
        Me.lblFWhite.TabIndex = 5
        '
        'lblFBrown
        '
        Me.lblFBrown.BackColor = System.Drawing.Color.SaddleBrown
        Me.lblFBrown.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblFBrown.Location = New System.Drawing.Point(110, 75)
        Me.lblFBrown.Name = "lblFBrown"
        Me.lblFBrown.Size = New System.Drawing.Size(40, 35)
        Me.lblFBrown.TabIndex = 5
        '
        'lblFGreen
        '
        Me.lblFGreen.BackColor = System.Drawing.Color.YellowGreen
        Me.lblFGreen.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblFGreen.Location = New System.Drawing.Point(110, 30)
        Me.lblFGreen.Name = "lblFGreen"
        Me.lblFGreen.Size = New System.Drawing.Size(40, 35)
        Me.lblFGreen.TabIndex = 5
        '
        'lblFRed
        '
        Me.lblFRed.BackColor = System.Drawing.Color.Red
        Me.lblFRed.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblFRed.Location = New System.Drawing.Point(18, 30)
        Me.lblFRed.Name = "lblFRed"
        Me.lblFRed.Size = New System.Drawing.Size(40, 35)
        Me.lblFRed.TabIndex = 5
        '
        'lblFOrange
        '
        Me.lblFOrange.BackColor = System.Drawing.Color.DarkOrange
        Me.lblFOrange.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblFOrange.Location = New System.Drawing.Point(18, 75)
        Me.lblFOrange.Name = "lblFOrange"
        Me.lblFOrange.Size = New System.Drawing.Size(40, 35)
        Me.lblFOrange.TabIndex = 5
        '
        'GroupBox1
        '
        Me.GroupBox1.BackColor = System.Drawing.SystemColors.ControlLight
        Me.GroupBox1.Controls.Add(Me.lblBBlue)
        Me.GroupBox1.Controls.Add(Me.lblBYellow)
        Me.GroupBox1.Controls.Add(Me.lblBSky)
        Me.GroupBox1.Controls.Add(Me.lblBBlack)
        Me.GroupBox1.Controls.Add(Me.lblBViolet)
        Me.GroupBox1.Controls.Add(Me.lblBWhite)
        Me.GroupBox1.Controls.Add(Me.lblBBrown)
        Me.GroupBox1.Controls.Add(Me.lblBGreen)
        Me.GroupBox1.Controls.Add(Me.lblBRed)
        Me.GroupBox1.Controls.Add(Me.lblBOrange)
        Me.GroupBox1.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.Location = New System.Drawing.Point(404, 224)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(260, 136)
        Me.GroupBox1.TabIndex = 2
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "BgColor"
        '
        'lblBBlue
        '
        Me.lblBBlue.BackColor = System.Drawing.Color.Blue
        Me.lblBBlue.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblBBlue.Location = New System.Drawing.Point(64, 30)
        Me.lblBBlue.Name = "lblBBlue"
        Me.lblBBlue.Size = New System.Drawing.Size(40, 35)
        Me.lblBBlue.TabIndex = 5
        '
        'lblBYellow
        '
        Me.lblBYellow.BackColor = System.Drawing.Color.Yellow
        Me.lblBYellow.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblBYellow.Location = New System.Drawing.Point(64, 75)
        Me.lblBYellow.Name = "lblBYellow"
        Me.lblBYellow.Size = New System.Drawing.Size(40, 35)
        Me.lblBYellow.TabIndex = 5
        '
        'lblBSky
        '
        Me.lblBSky.BackColor = System.Drawing.Color.SkyBlue
        Me.lblBSky.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblBSky.Location = New System.Drawing.Point(202, 75)
        Me.lblBSky.Name = "lblBSky"
        Me.lblBSky.Size = New System.Drawing.Size(40, 35)
        Me.lblBSky.TabIndex = 5
        '
        'lblBBlack
        '
        Me.lblBBlack.BackColor = System.Drawing.Color.Black
        Me.lblBBlack.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblBBlack.Location = New System.Drawing.Point(202, 30)
        Me.lblBBlack.Name = "lblBBlack"
        Me.lblBBlack.Size = New System.Drawing.Size(40, 35)
        Me.lblBBlack.TabIndex = 5
        '
        'lblBViolet
        '
        Me.lblBViolet.BackColor = System.Drawing.Color.Violet
        Me.lblBViolet.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblBViolet.Location = New System.Drawing.Point(156, 30)
        Me.lblBViolet.Name = "lblBViolet"
        Me.lblBViolet.Size = New System.Drawing.Size(40, 35)
        Me.lblBViolet.TabIndex = 5
        '
        'lblBWhite
        '
        Me.lblBWhite.BackColor = System.Drawing.Color.White
        Me.lblBWhite.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblBWhite.Location = New System.Drawing.Point(156, 75)
        Me.lblBWhite.Name = "lblBWhite"
        Me.lblBWhite.Size = New System.Drawing.Size(40, 35)
        Me.lblBWhite.TabIndex = 5
        '
        'lblBBrown
        '
        Me.lblBBrown.BackColor = System.Drawing.Color.SaddleBrown
        Me.lblBBrown.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblBBrown.Location = New System.Drawing.Point(110, 75)
        Me.lblBBrown.Name = "lblBBrown"
        Me.lblBBrown.Size = New System.Drawing.Size(40, 35)
        Me.lblBBrown.TabIndex = 5
        '
        'lblBGreen
        '
        Me.lblBGreen.BackColor = System.Drawing.Color.YellowGreen
        Me.lblBGreen.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblBGreen.Location = New System.Drawing.Point(110, 30)
        Me.lblBGreen.Name = "lblBGreen"
        Me.lblBGreen.Size = New System.Drawing.Size(40, 35)
        Me.lblBGreen.TabIndex = 5
        '
        'lblBRed
        '
        Me.lblBRed.BackColor = System.Drawing.Color.Red
        Me.lblBRed.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblBRed.Location = New System.Drawing.Point(18, 30)
        Me.lblBRed.Name = "lblBRed"
        Me.lblBRed.Size = New System.Drawing.Size(40, 35)
        Me.lblBRed.TabIndex = 5
        '
        'lblBOrange
        '
        Me.lblBOrange.BackColor = System.Drawing.Color.DarkOrange
        Me.lblBOrange.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblBOrange.Location = New System.Drawing.Point(18, 75)
        Me.lblBOrange.Name = "lblBOrange"
        Me.lblBOrange.Size = New System.Drawing.Size(40, 35)
        Me.lblBOrange.TabIndex = 5
        '
        'Button1
        '
        Me.Button1.BackColor = System.Drawing.Color.Pink
        Me.Button1.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button1.Location = New System.Drawing.Point(252, 395)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(75, 43)
        Me.Button1.TabIndex = 5
        Me.Button1.Text = "Clear"
        Me.Button1.UseVisualStyleBackColor = False
        '
        'Button2
        '
        Me.Button2.BackColor = System.Drawing.Color.PaleVioletRed
        Me.Button2.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button2.Location = New System.Drawing.Point(387, 395)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(75, 43)
        Me.Button2.TabIndex = 6
        Me.Button2.Text = "Close"
        Me.Button2.UseVisualStyleBackColor = False
        '
        'frmLab3
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.InactiveCaption
        Me.ClientSize = New System.Drawing.Size(742, 450)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.label1)
        Me.Controls.Add(Me.cboSize)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.btnDown)
        Me.Controls.Add(Me.btnUp)
        Me.Controls.Add(Me.txtInput)
        Me.Name = "frmLab3"
        Me.Text = "lab3"
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox1.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents txtInput As TextBox
    Friend WithEvents btnUp As Button
    Friend WithEvents btnDown As Button
    Friend WithEvents cboSize As ComboBox
    Friend WithEvents label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents lblFBlue As Label
    Friend WithEvents lblFYellow As Label
    Friend WithEvents lblFSky As Label
    Friend WithEvents lblFBlack As Label
    Friend WithEvents lblFViolet As Label
    Friend WithEvents lblFWhite As Label
    Friend WithEvents lblFBrown As Label
    Friend WithEvents lblFGreen As Label
    Friend WithEvents lblFRed As Label
    Friend WithEvents lblFOrange As Label
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents lblBBlue As Label
    Friend WithEvents lblBYellow As Label
    Friend WithEvents lblBSky As Label
    Friend WithEvents lblBBlack As Label
    Friend WithEvents lblBViolet As Label
    Friend WithEvents lblBWhite As Label
    Friend WithEvents lblBBrown As Label
    Friend WithEvents lblBGreen As Label
    Friend WithEvents lblBRed As Label
    Friend WithEvents lblBOrange As Label
    Friend WithEvents Button1 As Button
    Friend WithEvents Button2 As Button
End Class
