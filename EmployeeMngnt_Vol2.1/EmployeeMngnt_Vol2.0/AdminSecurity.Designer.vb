<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class AdminSecurity
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(AdminSecurity))
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.CancelBt = New System.Windows.Forms.Button()
        Me.AllowBt = New System.Windows.Forms.Button()
        Me.PassTbl = New System.Windows.Forms.TextBox()
        Me.UserNameTbl = New System.Windows.Forms.TextBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Panel1.SuspendLayout()
        Me.Panel2.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.Tomato
        Me.Panel1.Controls.Add(Me.Panel2)
        Me.Panel1.Controls.Add(Me.CancelBt)
        Me.Panel1.Controls.Add(Me.AllowBt)
        Me.Panel1.Controls.Add(Me.PassTbl)
        Me.Panel1.Controls.Add(Me.UserNameTbl)
        Me.Panel1.Controls.Add(Me.Label8)
        Me.Panel1.Controls.Add(Me.Label3)
        Me.Panel1.Location = New System.Drawing.Point(1, 33)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(321, 91)
        Me.Panel1.TabIndex = 0
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.Color.White
        Me.Panel2.Controls.Add(Me.PictureBox1)
        Me.Panel2.Location = New System.Drawing.Point(235, 8)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(72, 77)
        Me.Panel2.TabIndex = 18
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(0, 4)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(72, 69)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 18
        Me.PictureBox1.TabStop = False
        '
        'CancelBt
        '
        Me.CancelBt.BackColor = System.Drawing.Color.Honeydew
        Me.CancelBt.FlatAppearance.BorderColor = System.Drawing.Color.Blue
        Me.CancelBt.FlatAppearance.MouseDownBackColor = System.Drawing.Color.RoyalBlue
        Me.CancelBt.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DeepSkyBlue
        Me.CancelBt.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.CancelBt.Font = New System.Drawing.Font("Microsoft Sans Serif", 6.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CancelBt.ForeColor = System.Drawing.Color.Blue
        Me.CancelBt.Location = New System.Drawing.Point(124, 57)
        Me.CancelBt.Name = "CancelBt"
        Me.CancelBt.Size = New System.Drawing.Size(100, 27)
        Me.CancelBt.TabIndex = 16
        Me.CancelBt.Text = "Cancel"
        Me.CancelBt.UseVisualStyleBackColor = False
        '
        'AllowBt
        '
        Me.AllowBt.BackColor = System.Drawing.Color.Honeydew
        Me.AllowBt.FlatAppearance.BorderColor = System.Drawing.Color.Lime
        Me.AllowBt.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Lime
        Me.AllowBt.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Green
        Me.AllowBt.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.AllowBt.Font = New System.Drawing.Font("Microsoft Sans Serif", 6.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.AllowBt.ForeColor = System.Drawing.Color.LawnGreen
        Me.AllowBt.Location = New System.Drawing.Point(20, 57)
        Me.AllowBt.Name = "AllowBt"
        Me.AllowBt.Size = New System.Drawing.Size(97, 27)
        Me.AllowBt.TabIndex = 15
        Me.AllowBt.Text = "Allow Access"
        Me.AllowBt.UseVisualStyleBackColor = False
        '
        'PassTbl
        '
        Me.PassTbl.BackColor = System.Drawing.SystemColors.InactiveBorder
        Me.PassTbl.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.PassTbl.Font = New System.Drawing.Font("Arial Rounded MT Bold", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.PassTbl.ForeColor = System.Drawing.Color.DarkViolet
        Me.PassTbl.Location = New System.Drawing.Point(88, 32)
        Me.PassTbl.Name = "PassTbl"
        Me.PassTbl.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.PassTbl.Size = New System.Drawing.Size(136, 13)
        Me.PassTbl.TabIndex = 14
        '
        'UserNameTbl
        '
        Me.UserNameTbl.BackColor = System.Drawing.SystemColors.InactiveBorder
        Me.UserNameTbl.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.UserNameTbl.Font = New System.Drawing.Font("Arial Rounded MT Bold", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.UserNameTbl.ForeColor = System.Drawing.Color.DarkViolet
        Me.UserNameTbl.Location = New System.Drawing.Point(87, 11)
        Me.UserNameTbl.Name = "UserNameTbl"
        Me.UserNameTbl.Size = New System.Drawing.Size(137, 13)
        Me.UserNameTbl.TabIndex = 13
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Rockwell", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.ForeColor = System.Drawing.Color.GhostWhite
        Me.Label8.Location = New System.Drawing.Point(19, 31)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(71, 14)
        Me.Label8.TabIndex = 12
        Me.Label8.Text = "password :"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Rockwell", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.GhostWhite
        Me.Label3.Location = New System.Drawing.Point(11, 10)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(82, 14)
        Me.Label3.TabIndex = 11
        Me.Label3.Text = "User Name : "
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Imprint MT Shadow", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.ForeColor = System.Drawing.Color.GhostWhite
        Me.Label6.Location = New System.Drawing.Point(12, 7)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(210, 23)
        Me.Label6.TabIndex = 17
        Me.Label6.Text = "Administrator Access "
        '
        'AdminSecurity
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Red
        Me.ClientSize = New System.Drawing.Size(322, 135)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Panel1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "AdminSecurity"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "AdminSecurity"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.Panel2.ResumeLayout(False)
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents PassTbl As System.Windows.Forms.TextBox
    Friend WithEvents UserNameTbl As System.Windows.Forms.TextBox
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents AllowBt As System.Windows.Forms.Button
    Friend WithEvents CancelBt As System.Windows.Forms.Button
    Friend WithEvents Panel2 As System.Windows.Forms.Panel
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
End Class
