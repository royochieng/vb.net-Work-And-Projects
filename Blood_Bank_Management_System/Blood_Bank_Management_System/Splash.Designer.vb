<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Splash
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
        Me.components = New System.ComponentModel.Container()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.PercentageLbl = New System.Windows.Forms.Label()
        Me.MyProgressBar = New System.Windows.Forms.ProgressBar()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft YaHei UI", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.Red
        Me.Label1.Location = New System.Drawing.Point(151, 30)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(361, 28)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Blood Bank Management system"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft YaHei UI", 12.0!, System.Drawing.FontStyle.Bold)
        Me.Label2.ForeColor = System.Drawing.Color.Red
        Me.Label2.Location = New System.Drawing.Point(77, 218)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(171, 22)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "Loading Modules ..."
        '
        'PercentageLbl
        '
        Me.PercentageLbl.AutoSize = True
        Me.PercentageLbl.Font = New System.Drawing.Font("Brush Script MT", 14.25!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.PercentageLbl.ForeColor = System.Drawing.Color.Red
        Me.PercentageLbl.Location = New System.Drawing.Point(261, 215)
        Me.PercentageLbl.Name = "PercentageLbl"
        Me.PercentageLbl.Size = New System.Drawing.Size(24, 23)
        Me.PercentageLbl.TabIndex = 4
        Me.PercentageLbl.Text = "%"
        '
        'MyProgressBar
        '
        Me.MyProgressBar.BackColor = System.Drawing.Color.Red
        Me.MyProgressBar.ForeColor = System.Drawing.Color.Red
        Me.MyProgressBar.Location = New System.Drawing.Point(30, 254)
        Me.MyProgressBar.Name = "MyProgressBar"
        Me.MyProgressBar.Size = New System.Drawing.Size(594, 10)
        Me.MyProgressBar.Step = 5
        Me.MyProgressBar.TabIndex = 5
        '
        'Timer1
        '
        '
        'Splash
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(647, 290)
        Me.Controls.Add(Me.MyProgressBar)
        Me.Controls.Add(Me.PercentageLbl)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "Splash"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Form1"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents PercentageLbl As System.Windows.Forms.Label
    Friend WithEvents MyProgressBar As System.Windows.Forms.ProgressBar
    Friend WithEvents Timer1 As System.Windows.Forms.Timer

End Class
