<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Details
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Details))
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.EmpDOBlbl = New System.Windows.Forms.Label()
        Me.EmpEdulbl = New System.Windows.Forms.Label()
        Me.EmpPoslbl = New System.Windows.Forms.Label()
        Me.EmpAddlbl = New System.Windows.Forms.Label()
        Me.EmpPhonelbl = New System.Windows.Forms.Label()
        Me.EmpGendlbl = New System.Windows.Forms.Label()
        Me.EmpNamelbl = New System.Windows.Forms.Label()
        Me.FetchDatabtn = New System.Windows.Forms.Button()
        Me.EmpIdTb = New System.Windows.Forms.TextBox()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.btnHome = New System.Windows.Forms.Button()
        Me.btnAdd = New System.Windows.Forms.Button()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.PictureBox6 = New System.Windows.Forms.PictureBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.PrintDocument1 = New System.Drawing.Printing.PrintDocument()
        Me.PrintPreviewDialog1 = New System.Windows.Forms.PrintPreviewDialog()
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        Me.Panel1.SuspendLayout()
        CType(Me.PictureBox6, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.White
        Me.Panel1.Controls.Add(Me.EmpDOBlbl)
        Me.Panel1.Controls.Add(Me.EmpEdulbl)
        Me.Panel1.Controls.Add(Me.EmpPoslbl)
        Me.Panel1.Controls.Add(Me.EmpAddlbl)
        Me.Panel1.Controls.Add(Me.EmpPhonelbl)
        Me.Panel1.Controls.Add(Me.EmpGendlbl)
        Me.Panel1.Controls.Add(Me.EmpNamelbl)
        Me.Panel1.Controls.Add(Me.FetchDatabtn)
        Me.Panel1.Controls.Add(Me.EmpIdTb)
        Me.Panel1.Controls.Add(Me.Label10)
        Me.Panel1.Controls.Add(Me.btnHome)
        Me.Panel1.Controls.Add(Me.btnAdd)
        Me.Panel1.Controls.Add(Me.Label8)
        Me.Panel1.Controls.Add(Me.Label7)
        Me.Panel1.Controls.Add(Me.Label6)
        Me.Panel1.Controls.Add(Me.Label5)
        Me.Panel1.Controls.Add(Me.Label4)
        Me.Panel1.Controls.Add(Me.Label3)
        Me.Panel1.Controls.Add(Me.Label2)
        Me.Panel1.Location = New System.Drawing.Point(-1, 76)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(1109, 431)
        Me.Panel1.TabIndex = 1
        '
        'EmpDOBlbl
        '
        Me.EmpDOBlbl.AutoSize = True
        Me.EmpDOBlbl.Font = New System.Drawing.Font("Imprint MT Shadow", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.EmpDOBlbl.ForeColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.EmpDOBlbl.Location = New System.Drawing.Point(329, 308)
        Me.EmpDOBlbl.Name = "EmpDOBlbl"
        Me.EmpDOBlbl.Size = New System.Drawing.Size(154, 23)
        Me.EmpDOBlbl.TabIndex = 37
        Me.EmpDOBlbl.Text = "Employee DOB"
        Me.EmpDOBlbl.Visible = False
        '
        'EmpEdulbl
        '
        Me.EmpEdulbl.AutoSize = True
        Me.EmpEdulbl.Font = New System.Drawing.Font("Imprint MT Shadow", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.EmpEdulbl.ForeColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.EmpEdulbl.Location = New System.Drawing.Point(779, 243)
        Me.EmpEdulbl.Name = "EmpEdulbl"
        Me.EmpEdulbl.Size = New System.Drawing.Size(200, 23)
        Me.EmpEdulbl.TabIndex = 36
        Me.EmpEdulbl.Text = "Employee Education"
        Me.EmpEdulbl.Visible = False
        '
        'EmpPoslbl
        '
        Me.EmpPoslbl.AutoSize = True
        Me.EmpPoslbl.Font = New System.Drawing.Font("Imprint MT Shadow", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.EmpPoslbl.ForeColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.EmpPoslbl.Location = New System.Drawing.Point(779, 173)
        Me.EmpPoslbl.Name = "EmpPoslbl"
        Me.EmpPoslbl.Size = New System.Drawing.Size(182, 23)
        Me.EmpPoslbl.TabIndex = 35
        Me.EmpPoslbl.Text = "Employee Position"
        Me.EmpPoslbl.Visible = False
        '
        'EmpAddlbl
        '
        Me.EmpAddlbl.AutoSize = True
        Me.EmpAddlbl.Font = New System.Drawing.Font("Imprint MT Shadow", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.EmpAddlbl.ForeColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.EmpAddlbl.Location = New System.Drawing.Point(779, 101)
        Me.EmpAddlbl.Name = "EmpAddlbl"
        Me.EmpAddlbl.Size = New System.Drawing.Size(178, 23)
        Me.EmpAddlbl.TabIndex = 34
        Me.EmpAddlbl.Text = "Employee Address"
        Me.EmpAddlbl.Visible = False
        '
        'EmpPhonelbl
        '
        Me.EmpPhonelbl.AutoSize = True
        Me.EmpPhonelbl.Font = New System.Drawing.Font("Imprint MT Shadow", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.EmpPhonelbl.ForeColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.EmpPhonelbl.Location = New System.Drawing.Point(329, 243)
        Me.EmpPhonelbl.Name = "EmpPhonelbl"
        Me.EmpPhonelbl.Size = New System.Drawing.Size(166, 23)
        Me.EmpPhonelbl.TabIndex = 33
        Me.EmpPhonelbl.Text = "Employee Phone"
        Me.EmpPhonelbl.Visible = False
        '
        'EmpGendlbl
        '
        Me.EmpGendlbl.AutoSize = True
        Me.EmpGendlbl.Font = New System.Drawing.Font("Imprint MT Shadow", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.EmpGendlbl.ForeColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.EmpGendlbl.Location = New System.Drawing.Point(329, 173)
        Me.EmpGendlbl.Name = "EmpGendlbl"
        Me.EmpGendlbl.Size = New System.Drawing.Size(174, 23)
        Me.EmpGendlbl.TabIndex = 32
        Me.EmpGendlbl.Text = "Employee Gender"
        Me.EmpGendlbl.Visible = False
        '
        'EmpNamelbl
        '
        Me.EmpNamelbl.AutoSize = True
        Me.EmpNamelbl.Font = New System.Drawing.Font("Imprint MT Shadow", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.EmpNamelbl.ForeColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.EmpNamelbl.Location = New System.Drawing.Point(329, 101)
        Me.EmpNamelbl.Name = "EmpNamelbl"
        Me.EmpNamelbl.Size = New System.Drawing.Size(161, 23)
        Me.EmpNamelbl.TabIndex = 31
        Me.EmpNamelbl.Text = "Employee Name"
        Me.EmpNamelbl.Visible = False
        '
        'FetchDatabtn
        '
        Me.FetchDatabtn.FlatAppearance.BorderColor = System.Drawing.Color.DarkViolet
        Me.FetchDatabtn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DarkOrchid
        Me.FetchDatabtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.FetchDatabtn.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FetchDatabtn.ForeColor = System.Drawing.Color.CornflowerBlue
        Me.FetchDatabtn.Location = New System.Drawing.Point(588, 34)
        Me.FetchDatabtn.Name = "FetchDatabtn"
        Me.FetchDatabtn.Size = New System.Drawing.Size(81, 21)
        Me.FetchDatabtn.TabIndex = 30
        Me.FetchDatabtn.Text = "Fetch Data"
        Me.FetchDatabtn.UseVisualStyleBackColor = True
        '
        'EmpIdTb
        '
        Me.EmpIdTb.BackColor = System.Drawing.Color.White
        Me.EmpIdTb.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.EmpIdTb.ForeColor = System.Drawing.Color.DarkViolet
        Me.EmpIdTb.Location = New System.Drawing.Point(388, 32)
        Me.EmpIdTb.Name = "EmpIdTb"
        Me.EmpIdTb.Size = New System.Drawing.Size(180, 22)
        Me.EmpIdTb.TabIndex = 29
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Imprint MT Shadow", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.ForeColor = System.Drawing.Color.DodgerBlue
        Me.Label10.Location = New System.Drawing.Point(255, 31)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(127, 23)
        Me.Label10.TabIndex = 28
        Me.Label10.Text = "Employee Id"
        '
        'btnHome
        '
        Me.btnHome.FlatAppearance.BorderColor = System.Drawing.Color.DarkViolet
        Me.btnHome.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DarkOrchid
        Me.btnHome.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnHome.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnHome.ForeColor = System.Drawing.Color.CornflowerBlue
        Me.btnHome.Location = New System.Drawing.Point(536, 367)
        Me.btnHome.Name = "btnHome"
        Me.btnHome.Size = New System.Drawing.Size(81, 21)
        Me.btnHome.TabIndex = 27
        Me.btnHome.Text = "Home"
        Me.btnHome.UseVisualStyleBackColor = True
        '
        'btnAdd
        '
        Me.btnAdd.FlatAppearance.BorderColor = System.Drawing.Color.DarkViolet
        Me.btnAdd.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DarkOrchid
        Me.btnAdd.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnAdd.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnAdd.ForeColor = System.Drawing.Color.CornflowerBlue
        Me.btnAdd.Location = New System.Drawing.Point(312, 367)
        Me.btnAdd.Name = "btnAdd"
        Me.btnAdd.Size = New System.Drawing.Size(81, 21)
        Me.btnAdd.TabIndex = 24
        Me.btnAdd.Text = "Print"
        Me.btnAdd.UseVisualStyleBackColor = True
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Imprint MT Shadow", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.ForeColor = System.Drawing.Color.DodgerBlue
        Me.Label8.Location = New System.Drawing.Point(152, 308)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(154, 23)
        Me.Label8.TabIndex = 21
        Me.Label8.Text = "Employee DOB"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Imprint MT Shadow", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.ForeColor = System.Drawing.Color.DodgerBlue
        Me.Label7.Location = New System.Drawing.Point(571, 243)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(200, 23)
        Me.Label7.TabIndex = 16
        Me.Label7.Text = "Employee Education"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Imprint MT Shadow", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.ForeColor = System.Drawing.Color.DodgerBlue
        Me.Label6.Location = New System.Drawing.Point(152, 243)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(166, 23)
        Me.Label6.TabIndex = 14
        Me.Label6.Text = "Employee Phone"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Imprint MT Shadow", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.Color.DodgerBlue
        Me.Label5.Location = New System.Drawing.Point(571, 173)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(182, 23)
        Me.Label5.TabIndex = 12
        Me.Label5.Text = "Employee Position"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Imprint MT Shadow", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.DodgerBlue
        Me.Label4.Location = New System.Drawing.Point(152, 173)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(174, 23)
        Me.Label4.TabIndex = 10
        Me.Label4.Text = "Employee Gender"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Imprint MT Shadow", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.DodgerBlue
        Me.Label3.Location = New System.Drawing.Point(571, 101)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(178, 23)
        Me.Label3.TabIndex = 8
        Me.Label3.Text = "Employee Address"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Imprint MT Shadow", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.DodgerBlue
        Me.Label2.Location = New System.Drawing.Point(152, 101)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(161, 23)
        Me.Label2.TabIndex = 6
        Me.Label2.Text = "Employee Name"
        '
        'PictureBox6
        '
        Me.PictureBox6.Image = CType(resources.GetObject("PictureBox6.Image"), System.Drawing.Image)
        Me.PictureBox6.Location = New System.Drawing.Point(972, 508)
        Me.PictureBox6.Name = "PictureBox6"
        Me.PictureBox6.Size = New System.Drawing.Size(26, 23)
        Me.PictureBox6.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox6.TabIndex = 31
        Me.PictureBox6.TabStop = False
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Imprint MT Shadow", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.ForeColor = System.Drawing.Color.White
        Me.Label9.Location = New System.Drawing.Point(998, 513)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(100, 14)
        Me.Label9.TabIndex = 30
        Me.Label9.Text = "Jabu_BaseCode"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Imprint MT Shadow", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.White
        Me.Label1.Location = New System.Drawing.Point(88, 51)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(171, 23)
        Me.Label1.TabIndex = 29
        Me.Label1.Text = "Employee Details"
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(27, 10)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(55, 64)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 30
        Me.PictureBox1.TabStop = False
        '
        'PrintDocument1
        '
        '
        'PrintPreviewDialog1
        '
        Me.PrintPreviewDialog1.AutoScrollMargin = New System.Drawing.Size(0, 0)
        Me.PrintPreviewDialog1.AutoScrollMinSize = New System.Drawing.Size(0, 0)
        Me.PrintPreviewDialog1.ClientSize = New System.Drawing.Size(400, 300)
        Me.PrintPreviewDialog1.Document = Me.PrintDocument1
        Me.PrintPreviewDialog1.Enabled = True
        Me.PrintPreviewDialog1.Icon = CType(resources.GetObject("PrintPreviewDialog1.Icon"), System.Drawing.Icon)
        Me.PrintPreviewDialog1.Name = "PrintPreviewDialog1"
        Me.PrintPreviewDialog1.Visible = False
        '
        'PictureBox2
        '
        Me.PictureBox2.Image = CType(resources.GetObject("PictureBox2.Image"), System.Drawing.Image)
        Me.PictureBox2.Location = New System.Drawing.Point(1078, 5)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(23, 21)
        Me.PictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox2.TabIndex = 37
        Me.PictureBox2.TabStop = False
        '
        'Details
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.DarkViolet
        Me.ClientSize = New System.Drawing.Size(1106, 536)
        Me.Controls.Add(Me.PictureBox2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.PictureBox6)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.Label9)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "Details"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Details"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        CType(Me.PictureBox6, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents btnHome As System.Windows.Forms.Button
    Friend WithEvents btnAdd As System.Windows.Forms.Button
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents PictureBox6 As System.Windows.Forms.PictureBox
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents EmpDOBlbl As System.Windows.Forms.Label
    Friend WithEvents EmpEdulbl As System.Windows.Forms.Label
    Friend WithEvents EmpPoslbl As System.Windows.Forms.Label
    Friend WithEvents EmpAddlbl As System.Windows.Forms.Label
    Friend WithEvents EmpPhonelbl As System.Windows.Forms.Label
    Friend WithEvents EmpGendlbl As System.Windows.Forms.Label
    Friend WithEvents EmpNamelbl As System.Windows.Forms.Label
    Friend WithEvents FetchDatabtn As System.Windows.Forms.Button
    Friend WithEvents EmpIdTb As System.Windows.Forms.TextBox
    Friend WithEvents PrintDocument1 As System.Drawing.Printing.PrintDocument
    Friend WithEvents PrintPreviewDialog1 As System.Windows.Forms.PrintPreviewDialog
    Friend WithEvents PictureBox2 As System.Windows.Forms.PictureBox
End Class
