<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class register
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(register))
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.registerBt = New System.Windows.Forms.Button()
        Me.UserPassTb = New System.Windows.Forms.TextBox()
        Me.FullNameTb = New System.Windows.Forms.TextBox()
        Me.UserLevelCb = New System.Windows.Forms.ComboBox()
        Me.UserPhoneTb = New System.Windows.Forms.TextBox()
        Me.UserNameTb = New System.Windows.Forms.TextBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.PictureBox6 = New System.Windows.Forms.PictureBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        Me.Panel1.SuspendLayout()
        Me.Panel3.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel2.SuspendLayout()
        CType(Me.PictureBox6, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Imprint MT Shadow", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.DarkViolet
        Me.Label2.Location = New System.Drawing.Point(12, 31)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(298, 23)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "Employee Management System"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Imprint MT Shadow", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.DarkViolet
        Me.Label1.Location = New System.Drawing.Point(12, 9)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(180, 15)
        Me.Label1.TabIndex = 3
        Me.Label1.Text = "Admin Block to Add Users"
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.DarkViolet
        Me.Panel1.Controls.Add(Me.Panel3)
        Me.Panel1.Controls.Add(Me.PictureBox1)
        Me.Panel1.Controls.Add(Me.Panel2)
        Me.Panel1.Controls.Add(Me.UserPassTb)
        Me.Panel1.Controls.Add(Me.FullNameTb)
        Me.Panel1.Controls.Add(Me.UserLevelCb)
        Me.Panel1.Controls.Add(Me.UserPhoneTb)
        Me.Panel1.Controls.Add(Me.UserNameTb)
        Me.Panel1.Controls.Add(Me.Label9)
        Me.Panel1.Controls.Add(Me.Label8)
        Me.Panel1.Controls.Add(Me.Label6)
        Me.Panel1.Controls.Add(Me.Label5)
        Me.Panel1.Controls.Add(Me.Label4)
        Me.Panel1.Controls.Add(Me.Label3)
        Me.Panel1.Location = New System.Drawing.Point(2, 57)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(523, 138)
        Me.Panel1.TabIndex = 4
        '
        'Panel3
        '
        Me.Panel3.BackColor = System.Drawing.Color.Thistle
        Me.Panel3.Controls.Add(Me.Button1)
        Me.Panel3.Location = New System.Drawing.Point(444, 94)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(79, 41)
        Me.Panel3.TabIndex = 12
        '
        'Button1
        '
        Me.Button1.BackColor = System.Drawing.Color.Silver
        Me.Button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button1.Font = New System.Drawing.Font("Arial Rounded MT Bold", 6.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button1.ForeColor = System.Drawing.Color.DarkViolet
        Me.Button1.Image = CType(resources.GetObject("Button1.Image"), System.Drawing.Image)
        Me.Button1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Button1.Location = New System.Drawing.Point(3, 4)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(73, 33)
        Me.Button1.TabIndex = 10
        Me.Button1.Text = "Update Details"
        Me.Button1.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.Button1.UseVisualStyleBackColor = False
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(247, 72)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(83, 61)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 12
        Me.PictureBox1.TabStop = False
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.Color.Thistle
        Me.Panel2.Controls.Add(Me.registerBt)
        Me.Panel2.Location = New System.Drawing.Point(330, 94)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(111, 39)
        Me.Panel2.TabIndex = 11
        '
        'registerBt
        '
        Me.registerBt.BackColor = System.Drawing.Color.Silver
        Me.registerBt.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.registerBt.Font = New System.Drawing.Font("Arial Rounded MT Bold", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.registerBt.ForeColor = System.Drawing.Color.DarkViolet
        Me.registerBt.Image = CType(resources.GetObject("registerBt.Image"), System.Drawing.Image)
        Me.registerBt.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.registerBt.Location = New System.Drawing.Point(3, 3)
        Me.registerBt.Name = "registerBt"
        Me.registerBt.Size = New System.Drawing.Size(105, 33)
        Me.registerBt.TabIndex = 8
        Me.registerBt.Text = "Register User"
        Me.registerBt.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.registerBt.UseVisualStyleBackColor = False
        '
        'UserPassTb
        '
        Me.UserPassTb.BackColor = System.Drawing.SystemColors.InactiveBorder
        Me.UserPassTb.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.UserPassTb.Font = New System.Drawing.Font("Arial Rounded MT Bold", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.UserPassTb.ForeColor = System.Drawing.Color.DarkViolet
        Me.UserPassTb.Location = New System.Drawing.Point(306, 53)
        Me.UserPassTb.Name = "UserPassTb"
        Me.UserPassTb.Size = New System.Drawing.Size(135, 13)
        Me.UserPassTb.TabIndex = 10
        '
        'FullNameTb
        '
        Me.FullNameTb.BackColor = System.Drawing.SystemColors.InactiveBorder
        Me.FullNameTb.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.FullNameTb.Font = New System.Drawing.Font("Arial Rounded MT Bold", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FullNameTb.ForeColor = System.Drawing.Color.DarkViolet
        Me.FullNameTb.Location = New System.Drawing.Point(306, 27)
        Me.FullNameTb.Name = "FullNameTb"
        Me.FullNameTb.Size = New System.Drawing.Size(207, 13)
        Me.FullNameTb.TabIndex = 9
        '
        'UserLevelCb
        '
        Me.UserLevelCb.BackColor = System.Drawing.SystemColors.InactiveBorder
        Me.UserLevelCb.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.UserLevelCb.Font = New System.Drawing.Font("Arial Rounded MT Bold", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.UserLevelCb.ForeColor = System.Drawing.Color.DarkViolet
        Me.UserLevelCb.FormattingEnabled = True
        Me.UserLevelCb.Items.AddRange(New Object() {"Administrator", "Manager", "Employee ", "non_Staff", "Intern"})
        Me.UserLevelCb.Location = New System.Drawing.Point(120, 78)
        Me.UserLevelCb.Name = "UserLevelCb"
        Me.UserLevelCb.Size = New System.Drawing.Size(121, 20)
        Me.UserLevelCb.TabIndex = 8
        '
        'UserPhoneTb
        '
        Me.UserPhoneTb.BackColor = System.Drawing.SystemColors.InactiveBorder
        Me.UserPhoneTb.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.UserPhoneTb.Font = New System.Drawing.Font("Arial Rounded MT Bold", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.UserPhoneTb.ForeColor = System.Drawing.Color.DarkViolet
        Me.UserPhoneTb.Location = New System.Drawing.Point(120, 53)
        Me.UserPhoneTb.Name = "UserPhoneTb"
        Me.UserPhoneTb.Size = New System.Drawing.Size(109, 13)
        Me.UserPhoneTb.TabIndex = 7
        '
        'UserNameTb
        '
        Me.UserNameTb.BackColor = System.Drawing.SystemColors.InactiveBorder
        Me.UserNameTb.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.UserNameTb.Font = New System.Drawing.Font("Arial Rounded MT Bold", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.UserNameTb.ForeColor = System.Drawing.Color.DarkViolet
        Me.UserNameTb.Location = New System.Drawing.Point(92, 27)
        Me.UserNameTb.Name = "UserNameTb"
        Me.UserNameTb.Size = New System.Drawing.Size(137, 13)
        Me.UserNameTb.TabIndex = 6
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Rockwell", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.ForeColor = System.Drawing.Color.GhostWhite
        Me.Label9.Location = New System.Drawing.Point(230, 26)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(80, 14)
        Me.Label9.TabIndex = 5
        Me.Label9.Text = "Full Name : "
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Rockwell", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.ForeColor = System.Drawing.Color.GhostWhite
        Me.Label8.Location = New System.Drawing.Point(230, 52)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(71, 14)
        Me.Label8.TabIndex = 4
        Me.Label8.Text = "password :"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Rockwell", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.ForeColor = System.Drawing.Color.GhostWhite
        Me.Label6.Location = New System.Drawing.Point(16, 78)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(79, 14)
        Me.Label6.TabIndex = 3
        Me.Label6.Text = "User Level : "
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Rockwell", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.Color.GhostWhite
        Me.Label5.Location = New System.Drawing.Point(16, 52)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(108, 14)
        Me.Label5.TabIndex = 2
        Me.Label5.Text = "Phone Number : "
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Rockwell", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.GhostWhite
        Me.Label4.Location = New System.Drawing.Point(16, 5)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(147, 14)
        Me.Label4.TabIndex = 1
        Me.Label4.Text = "Fill in User Details Here"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Rockwell", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.GhostWhite
        Me.Label3.Location = New System.Drawing.Point(16, 26)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(82, 14)
        Me.Label3.TabIndex = 0
        Me.Label3.Text = "User Name : "
        '
        'PictureBox6
        '
        Me.PictureBox6.Image = CType(resources.GetObject("PictureBox6.Image"), System.Drawing.Image)
        Me.PictureBox6.Location = New System.Drawing.Point(389, 194)
        Me.PictureBox6.Name = "PictureBox6"
        Me.PictureBox6.Size = New System.Drawing.Size(26, 23)
        Me.PictureBox6.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox6.TabIndex = 20
        Me.PictureBox6.TabStop = False
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Imprint MT Shadow", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.ForeColor = System.Drawing.Color.DarkViolet
        Me.Label7.Location = New System.Drawing.Point(415, 199)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(100, 14)
        Me.Label7.TabIndex = 19
        Me.Label7.Text = "Jabu_BaseCode"
        '
        'PictureBox2
        '
        Me.PictureBox2.Image = CType(resources.GetObject("PictureBox2.Image"), System.Drawing.Image)
        Me.PictureBox2.Location = New System.Drawing.Point(499, 5)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(23, 21)
        Me.PictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox2.TabIndex = 37
        Me.PictureBox2.TabStop = False
        '
        'register
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(527, 223)
        Me.Controls.Add(Me.PictureBox2)
        Me.Controls.Add(Me.PictureBox6)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Label2)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "register"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "register"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.Panel3.ResumeLayout(False)
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel2.ResumeLayout(False)
        CType(Me.PictureBox6, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents PictureBox6 As System.Windows.Forms.PictureBox
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents UserPassTb As System.Windows.Forms.TextBox
    Friend WithEvents FullNameTb As System.Windows.Forms.TextBox
    Friend WithEvents UserLevelCb As System.Windows.Forms.ComboBox
    Friend WithEvents UserPhoneTb As System.Windows.Forms.TextBox
    Friend WithEvents UserNameTb As System.Windows.Forms.TextBox
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Panel2 As System.Windows.Forms.Panel
    Friend WithEvents registerBt As System.Windows.Forms.Button
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents Panel3 As System.Windows.Forms.Panel
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents PictureBox2 As System.Windows.Forms.PictureBox
End Class
