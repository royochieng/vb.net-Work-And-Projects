namespace Water_Billing_MAnagemen_System
{
    partial class Login
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Login));
            this.panel1 = new System.Windows.Forms.Panel();
            this.ExitBtn = new Guna.UI.WinForms.GunaCircleButton();
            this.gunaLabel1 = new Guna.UI.WinForms.GunaLabel();
            this.gunaLabel9 = new Guna.UI.WinForms.GunaLabel();
            this.gunaElipse1 = new Guna.UI.WinForms.GunaElipse(this.components);
            this.PassTb = new Guna.UI.WinForms.GunaTextBox();
            this.gunaLabel8 = new Guna.UI.WinForms.GunaLabel();
            this.gunaLabel6 = new Guna.UI.WinForms.GunaLabel();
            this.UnameTb = new Guna.UI.WinForms.GunaTextBox();
            this.gunaPictureBox3 = new Guna.UI.WinForms.GunaPictureBox();
            this.AdminTbn = new Guna.UI.WinForms.GunaButton();
            this.LoginBtn = new Guna.UI.WinForms.GunaButton();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gunaPictureBox3)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Blue;
            this.panel1.Controls.Add(this.ExitBtn);
            this.panel1.Controls.Add(this.gunaLabel1);
            this.panel1.Controls.Add(this.gunaLabel9);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(310, 79);
            this.panel1.TabIndex = 0;
            // 
            // ExitBtn
            // 
            this.ExitBtn.AnimationHoverSpeed = 0.07F;
            this.ExitBtn.AnimationSpeed = 0.03F;
            this.ExitBtn.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.ExitBtn.BorderColor = System.Drawing.Color.Black;
            this.ExitBtn.DialogResult = System.Windows.Forms.DialogResult.None;
            this.ExitBtn.FocusedColor = System.Drawing.Color.Empty;
            this.ExitBtn.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.ExitBtn.ForeColor = System.Drawing.Color.White;
            this.ExitBtn.Image = ((System.Drawing.Image)(resources.GetObject("ExitBtn.Image")));
            this.ExitBtn.ImageSize = new System.Drawing.Size(32, 32);
            this.ExitBtn.Location = new System.Drawing.Point(266, 8);
            this.ExitBtn.Name = "ExitBtn";
            this.ExitBtn.OnHoverBaseColor = System.Drawing.Color.Red;
            this.ExitBtn.OnHoverBorderColor = System.Drawing.Color.Black;
            this.ExitBtn.OnHoverForeColor = System.Drawing.Color.White;
            this.ExitBtn.OnHoverImage = null;
            this.ExitBtn.OnPressedColor = System.Drawing.Color.Red;
            this.ExitBtn.Size = new System.Drawing.Size(35, 35);
            this.ExitBtn.TabIndex = 101;
            this.ExitBtn.Click += new System.EventHandler(this.ExitBtn_Click);
            // 
            // gunaLabel1
            // 
            this.gunaLabel1.AutoSize = true;
            this.gunaLabel1.Font = new System.Drawing.Font("Ebrima", 9.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gunaLabel1.ForeColor = System.Drawing.Color.White;
            this.gunaLabel1.Location = new System.Drawing.Point(124, 38);
            this.gunaLabel1.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.gunaLabel1.Name = "gunaLabel1";
            this.gunaLabel1.Size = new System.Drawing.Size(53, 17);
            this.gunaLabel1.TabIndex = 83;
            this.gunaLabel1.Text = "App 2.0";
            // 
            // gunaLabel9
            // 
            this.gunaLabel9.AutoSize = true;
            this.gunaLabel9.Font = new System.Drawing.Font("Ebrima", 9.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gunaLabel9.ForeColor = System.Drawing.Color.White;
            this.gunaLabel9.Location = new System.Drawing.Point(85, 20);
            this.gunaLabel9.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.gunaLabel9.Name = "gunaLabel9";
            this.gunaLabel9.Size = new System.Drawing.Size(136, 17);
            this.gunaLabel9.TabIndex = 82;
            this.gunaLabel9.Text = "Water Distribution Ltd";
            // 
            // gunaElipse1
            // 
            this.gunaElipse1.Radius = 25;
            this.gunaElipse1.TargetControl = this;
            // 
            // PassTb
            // 
            this.PassTb.BackColor = System.Drawing.Color.Transparent;
            this.PassTb.BaseColor = System.Drawing.Color.White;
            this.PassTb.BorderColor = System.Drawing.Color.Silver;
            this.PassTb.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.PassTb.FocusedBaseColor = System.Drawing.Color.White;
            this.PassTb.FocusedBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.PassTb.FocusedForeColor = System.Drawing.Color.MidnightBlue;
            this.PassTb.Font = new System.Drawing.Font("Ebrima", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PassTb.Location = new System.Drawing.Point(67, 232);
            this.PassTb.Name = "PassTb";
            this.PassTb.PasswordChar = '֎';
            this.PassTb.Radius = 10;
            this.PassTb.SelectedText = "";
            this.PassTb.Size = new System.Drawing.Size(180, 28);
            this.PassTb.TabIndex = 95;
            // 
            // gunaLabel8
            // 
            this.gunaLabel8.AutoSize = true;
            this.gunaLabel8.Font = new System.Drawing.Font("Ebrima", 9.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gunaLabel8.ForeColor = System.Drawing.Color.RoyalBlue;
            this.gunaLabel8.Location = new System.Drawing.Point(64, 212);
            this.gunaLabel8.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.gunaLabel8.Name = "gunaLabel8";
            this.gunaLabel8.Size = new System.Drawing.Size(64, 17);
            this.gunaLabel8.TabIndex = 94;
            this.gunaLabel8.Text = "Password";
            // 
            // gunaLabel6
            // 
            this.gunaLabel6.AutoSize = true;
            this.gunaLabel6.Font = new System.Drawing.Font("Ebrima", 9.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gunaLabel6.ForeColor = System.Drawing.Color.RoyalBlue;
            this.gunaLabel6.Location = new System.Drawing.Point(64, 156);
            this.gunaLabel6.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.gunaLabel6.Name = "gunaLabel6";
            this.gunaLabel6.Size = new System.Drawing.Size(74, 17);
            this.gunaLabel6.TabIndex = 93;
            this.gunaLabel6.Text = "User Name";
            // 
            // UnameTb
            // 
            this.UnameTb.BackColor = System.Drawing.Color.Transparent;
            this.UnameTb.BaseColor = System.Drawing.Color.White;
            this.UnameTb.BorderColor = System.Drawing.Color.Silver;
            this.UnameTb.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.UnameTb.FocusedBaseColor = System.Drawing.Color.White;
            this.UnameTb.FocusedBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.UnameTb.FocusedForeColor = System.Drawing.Color.MidnightBlue;
            this.UnameTb.Font = new System.Drawing.Font("Ebrima", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.UnameTb.Location = new System.Drawing.Point(67, 178);
            this.UnameTb.Name = "UnameTb";
            this.UnameTb.PasswordChar = '\0';
            this.UnameTb.Radius = 10;
            this.UnameTb.SelectedText = "";
            this.UnameTb.Size = new System.Drawing.Size(180, 28);
            this.UnameTb.TabIndex = 92;
            // 
            // gunaPictureBox3
            // 
            this.gunaPictureBox3.BaseColor = System.Drawing.Color.White;
            this.gunaPictureBox3.Image = ((System.Drawing.Image)(resources.GetObject("gunaPictureBox3.Image")));
            this.gunaPictureBox3.Location = new System.Drawing.Point(117, 95);
            this.gunaPictureBox3.Name = "gunaPictureBox3";
            this.gunaPictureBox3.Size = new System.Drawing.Size(75, 48);
            this.gunaPictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.gunaPictureBox3.TabIndex = 98;
            this.gunaPictureBox3.TabStop = false;
            // 
            // AdminTbn
            // 
            this.AdminTbn.AnimationHoverSpeed = 0.07F;
            this.AdminTbn.AnimationSpeed = 0.03F;
            this.AdminTbn.BackColor = System.Drawing.Color.Transparent;
            this.AdminTbn.BaseColor = System.Drawing.Color.Transparent;
            this.AdminTbn.BorderColor = System.Drawing.Color.Black;
            this.AdminTbn.DialogResult = System.Windows.Forms.DialogResult.None;
            this.AdminTbn.FocusedColor = System.Drawing.Color.Empty;
            this.AdminTbn.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.AdminTbn.ForeColor = System.Drawing.Color.RoyalBlue;
            this.AdminTbn.Image = null;
            this.AdminTbn.ImageSize = new System.Drawing.Size(20, 20);
            this.AdminTbn.Location = new System.Drawing.Point(103, 322);
            this.AdminTbn.Name = "AdminTbn";
            this.AdminTbn.OnHoverBaseColor = System.Drawing.Color.Azure;
            this.AdminTbn.OnHoverBorderColor = System.Drawing.Color.Black;
            this.AdminTbn.OnHoverForeColor = System.Drawing.Color.RoyalBlue;
            this.AdminTbn.OnHoverImage = null;
            this.AdminTbn.OnPressedColor = System.Drawing.Color.MediumSlateBlue;
            this.AdminTbn.Padding = new System.Windows.Forms.Padding(1);
            this.AdminTbn.Radius = 5;
            this.AdminTbn.Size = new System.Drawing.Size(103, 29);
            this.AdminTbn.TabIndex = 99;
            this.AdminTbn.Text = "Administrator";
            this.AdminTbn.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.AdminTbn.Click += new System.EventHandler(this.AdminTbn_Click);
            // 
            // LoginBtn
            // 
            this.LoginBtn.AnimationHoverSpeed = 0.07F;
            this.LoginBtn.AnimationSpeed = 0.03F;
            this.LoginBtn.BackColor = System.Drawing.Color.Transparent;
            this.LoginBtn.BaseColor = System.Drawing.Color.Transparent;
            this.LoginBtn.BorderColor = System.Drawing.Color.Black;
            this.LoginBtn.DialogResult = System.Windows.Forms.DialogResult.None;
            this.LoginBtn.FocusedColor = System.Drawing.Color.Empty;
            this.LoginBtn.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.LoginBtn.ForeColor = System.Drawing.Color.MediumBlue;
            this.LoginBtn.Image = ((System.Drawing.Image)(resources.GetObject("LoginBtn.Image")));
            this.LoginBtn.ImageSize = new System.Drawing.Size(20, 20);
            this.LoginBtn.Location = new System.Drawing.Point(109, 270);
            this.LoginBtn.Name = "LoginBtn";
            this.LoginBtn.OnHoverBaseColor = System.Drawing.Color.Azure;
            this.LoginBtn.OnHoverBorderColor = System.Drawing.Color.Black;
            this.LoginBtn.OnHoverForeColor = System.Drawing.Color.RoyalBlue;
            this.LoginBtn.OnHoverImage = null;
            this.LoginBtn.OnPressedColor = System.Drawing.Color.SpringGreen;
            this.LoginBtn.Padding = new System.Windows.Forms.Padding(1);
            this.LoginBtn.Radius = 10;
            this.LoginBtn.Size = new System.Drawing.Size(85, 29);
            this.LoginBtn.TabIndex = 100;
            this.LoginBtn.Text = "Login";
            this.LoginBtn.Click += new System.EventHandler(this.LoginBtn_Click);
            // 
            // Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(310, 380);
            this.Controls.Add(this.LoginBtn);
            this.Controls.Add(this.AdminTbn);
            this.Controls.Add(this.gunaPictureBox3);
            this.Controls.Add(this.PassTb);
            this.Controls.Add(this.gunaLabel8);
            this.Controls.Add(this.gunaLabel6);
            this.Controls.Add(this.UnameTb);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Login";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Login";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gunaPictureBox3)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private Guna.UI.WinForms.GunaElipse gunaElipse1;
        private Guna.UI.WinForms.GunaLabel gunaLabel1;
        private Guna.UI.WinForms.GunaLabel gunaLabel9;
        private Guna.UI.WinForms.GunaTextBox PassTb;
        private Guna.UI.WinForms.GunaLabel gunaLabel8;
        private Guna.UI.WinForms.GunaLabel gunaLabel6;
        private Guna.UI.WinForms.GunaTextBox UnameTb;
        private Guna.UI.WinForms.GunaPictureBox gunaPictureBox3;
        private Guna.UI.WinForms.GunaButton AdminTbn;
        private Guna.UI.WinForms.GunaButton LoginBtn;
        private Guna.UI.WinForms.GunaCircleButton ExitBtn;
    }
}