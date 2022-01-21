
namespace super_market
{
    partial class Admin
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Admin));
            this.upLayout = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.messageLayout = new System.Windows.Forms.Panel();
            this.navBtnLayout = new System.Windows.Forms.Panel();
            this.logoutPanel = new Guna.UI2.WinForms.Guna2CustomGradientPanel();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.guna2Button1 = new Guna.UI2.WinForms.Guna2Button();
            this.logoutBtn = new Guna.UI2.WinForms.Guna2Button();
            this.requestsBtn = new Guna.UI2.WinForms.Guna2Button();
            this.employeesBtn = new Guna.UI2.WinForms.Guna2Button();
            this.dashboardBtn = new Guna.UI2.WinForms.Guna2Button();
            this.custumizedMessagePanel = new Guna.UI2.WinForms.Guna2GradientPanel();
            this.bodyLayout = new System.Windows.Forms.Panel();
            this.dataPanel = new System.Windows.Forms.Panel();
            this.upLayout.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.navBtnLayout.SuspendLayout();
            this.logoutPanel.SuspendLayout();
            this.bodyLayout.SuspendLayout();
            this.SuspendLayout();
            // 
            // upLayout
            // 
            this.upLayout.BackColor = System.Drawing.Color.White;
            this.upLayout.Controls.Add(this.pictureBox1);
            this.upLayout.Location = new System.Drawing.Point(181, 0);
            this.upLayout.Name = "upLayout";
            this.upLayout.Size = new System.Drawing.Size(750, 36);
            this.upLayout.TabIndex = 0;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(718, 7);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(22, 22);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 2;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // messageLayout
            // 
            this.messageLayout.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(250)))), ((int)(((byte)(250)))));
            this.messageLayout.Location = new System.Drawing.Point(0, 0);
            this.messageLayout.Name = "messageLayout";
            this.messageLayout.Size = new System.Drawing.Size(0, 0);
            this.messageLayout.TabIndex = 0;
            // 
            // navBtnLayout
            // 
            this.navBtnLayout.BackColor = System.Drawing.Color.White;
            this.navBtnLayout.Controls.Add(this.logoutPanel);
            this.navBtnLayout.Controls.Add(this.logoutBtn);
            this.navBtnLayout.Controls.Add(this.requestsBtn);
            this.navBtnLayout.Controls.Add(this.employeesBtn);
            this.navBtnLayout.Controls.Add(this.dashboardBtn);
            this.navBtnLayout.Location = new System.Drawing.Point(0, -2);
            this.navBtnLayout.Name = "navBtnLayout";
            this.navBtnLayout.Size = new System.Drawing.Size(181, 561);
            this.navBtnLayout.TabIndex = 1;
            // 
            // logoutPanel
            // 
            this.logoutPanel.BackColor = System.Drawing.Color.Transparent;
            this.logoutPanel.BorderRadius = 7;
            this.logoutPanel.Controls.Add(this.label3);
            this.logoutPanel.Controls.Add(this.label2);
            this.logoutPanel.Controls.Add(this.label1);
            this.logoutPanel.Controls.Add(this.guna2Button1);
            this.logoutPanel.Location = new System.Drawing.Point(5, 305);
            this.logoutPanel.Name = "logoutPanel";
            this.logoutPanel.ShadowDecoration.Color = System.Drawing.Color.Gray;
            this.logoutPanel.ShadowDecoration.Depth = 15;
            this.logoutPanel.ShadowDecoration.Enabled = true;
            this.logoutPanel.ShadowDecoration.Parent = this.logoutPanel;
            this.logoutPanel.Size = new System.Drawing.Size(170, 125);
            this.logoutPanel.TabIndex = 6;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Arial", 11F);
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label3.Location = new System.Drawing.Point(7, 63);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(63, 17);
            this.label3.TabIndex = 9;
            this.label3.Text = "to logout";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial", 11F);
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label2.Location = new System.Drawing.Point(6, 41);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(152, 17);
            this.label2.TabIndex = 8;
            this.label2.Text = "Are you sure you want";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 11F, System.Drawing.FontStyle.Bold);
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label1.Location = new System.Drawing.Point(7, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(58, 18);
            this.label1.TabIndex = 7;
            this.label1.Text = "Logout";
            // 
            // guna2Button1
            // 
            this.guna2Button1.BorderRadius = 5;
            this.guna2Button1.CheckedState.Parent = this.guna2Button1;
            this.guna2Button1.CustomBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(168)))), ((int)(((byte)(85)))), ((int)(((byte)(247)))));
            this.guna2Button1.CustomImages.Parent = this.guna2Button1;
            this.guna2Button1.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.guna2Button1.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.guna2Button1.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.guna2Button1.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.guna2Button1.DisabledState.Parent = this.guna2Button1;
            this.guna2Button1.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(68)))), ((int)(((byte)(68)))));
            this.guna2Button1.Font = new System.Drawing.Font("Arial", 11F, System.Drawing.FontStyle.Bold);
            this.guna2Button1.ForeColor = System.Drawing.Color.White;
            this.guna2Button1.HoverState.Parent = this.guna2Button1;
            this.guna2Button1.Location = new System.Drawing.Point(5, 90);
            this.guna2Button1.Name = "guna2Button1";
            this.guna2Button1.ShadowDecoration.Parent = this.guna2Button1;
            this.guna2Button1.Size = new System.Drawing.Size(160, 30);
            this.guna2Button1.TabIndex = 6;
            this.guna2Button1.Text = "Hell yes";
            this.guna2Button1.Click += new System.EventHandler(this.guna2Button1_Click);
            // 
            // logoutBtn
            // 
            this.logoutBtn.BorderRadius = 5;
            this.logoutBtn.CheckedState.Parent = this.logoutBtn;
            this.logoutBtn.CustomBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(168)))), ((int)(((byte)(85)))), ((int)(((byte)(247)))));
            this.logoutBtn.CustomImages.Parent = this.logoutBtn;
            this.logoutBtn.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.logoutBtn.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.logoutBtn.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.logoutBtn.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.logoutBtn.DisabledState.Parent = this.logoutBtn;
            this.logoutBtn.FillColor = System.Drawing.Color.Empty;
            this.logoutBtn.Font = new System.Drawing.Font("Arial", 11F, System.Drawing.FontStyle.Bold);
            this.logoutBtn.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(65)))), ((int)(((byte)(85)))));
            this.logoutBtn.HoverState.Parent = this.logoutBtn;
            this.logoutBtn.Location = new System.Drawing.Point(3, 262);
            this.logoutBtn.Name = "logoutBtn";
            this.logoutBtn.ShadowDecoration.Parent = this.logoutBtn;
            this.logoutBtn.Size = new System.Drawing.Size(175, 37);
            this.logoutBtn.TabIndex = 5;
            this.logoutBtn.Text = "Logout";
            this.logoutBtn.Click += new System.EventHandler(this.stockBtn_Click);
            // 
            // requestsBtn
            // 
            this.requestsBtn.BorderRadius = 5;
            this.requestsBtn.CheckedState.Parent = this.requestsBtn;
            this.requestsBtn.CustomBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(168)))), ((int)(((byte)(85)))), ((int)(((byte)(247)))));
            this.requestsBtn.CustomImages.Parent = this.requestsBtn;
            this.requestsBtn.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.requestsBtn.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.requestsBtn.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.requestsBtn.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.requestsBtn.DisabledState.Parent = this.requestsBtn;
            this.requestsBtn.FillColor = System.Drawing.Color.Empty;
            this.requestsBtn.Font = new System.Drawing.Font("Arial", 11F, System.Drawing.FontStyle.Bold);
            this.requestsBtn.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(65)))), ((int)(((byte)(85)))));
            this.requestsBtn.HoverState.Parent = this.requestsBtn;
            this.requestsBtn.Location = new System.Drawing.Point(3, 220);
            this.requestsBtn.Name = "requestsBtn";
            this.requestsBtn.ShadowDecoration.Parent = this.requestsBtn;
            this.requestsBtn.Size = new System.Drawing.Size(175, 37);
            this.requestsBtn.TabIndex = 4;
            this.requestsBtn.Text = "Requests";
            this.requestsBtn.Click += new System.EventHandler(this.requestsBtn_Click);
            // 
            // employeesBtn
            // 
            this.employeesBtn.BorderRadius = 5;
            this.employeesBtn.CheckedState.Parent = this.employeesBtn;
            this.employeesBtn.CustomBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(168)))), ((int)(((byte)(85)))), ((int)(((byte)(247)))));
            this.employeesBtn.CustomImages.Parent = this.employeesBtn;
            this.employeesBtn.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.employeesBtn.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.employeesBtn.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.employeesBtn.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.employeesBtn.DisabledState.Parent = this.employeesBtn;
            this.employeesBtn.FillColor = System.Drawing.Color.Empty;
            this.employeesBtn.Font = new System.Drawing.Font("Arial", 11F, System.Drawing.FontStyle.Bold);
            this.employeesBtn.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(65)))), ((int)(((byte)(85)))));
            this.employeesBtn.HoverState.Parent = this.employeesBtn;
            this.employeesBtn.Location = new System.Drawing.Point(3, 177);
            this.employeesBtn.Name = "employeesBtn";
            this.employeesBtn.ShadowDecoration.Parent = this.employeesBtn;
            this.employeesBtn.Size = new System.Drawing.Size(175, 37);
            this.employeesBtn.TabIndex = 3;
            this.employeesBtn.Text = "Employees";
            this.employeesBtn.Click += new System.EventHandler(this.employeesBtn_Click);
            // 
            // dashboardBtn
            // 
            this.dashboardBtn.BackColor = System.Drawing.Color.White;
            this.dashboardBtn.BorderRadius = 5;
            this.dashboardBtn.CheckedState.Parent = this.dashboardBtn;
            this.dashboardBtn.CustomBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(68)))), ((int)(((byte)(68)))));
            this.dashboardBtn.CustomBorderThickness = new System.Windows.Forms.Padding(5, 0, 0, 0);
            this.dashboardBtn.CustomImages.Parent = this.dashboardBtn;
            this.dashboardBtn.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.dashboardBtn.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.dashboardBtn.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.dashboardBtn.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.dashboardBtn.DisabledState.Parent = this.dashboardBtn;
            this.dashboardBtn.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(254)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.dashboardBtn.Font = new System.Drawing.Font("Arial", 11F, System.Drawing.FontStyle.Bold);
            this.dashboardBtn.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(68)))), ((int)(((byte)(68)))));
            this.dashboardBtn.HoverState.Parent = this.dashboardBtn;
            this.dashboardBtn.Location = new System.Drawing.Point(3, 134);
            this.dashboardBtn.Name = "dashboardBtn";
            this.dashboardBtn.ShadowDecoration.Parent = this.dashboardBtn;
            this.dashboardBtn.Size = new System.Drawing.Size(175, 37);
            this.dashboardBtn.TabIndex = 2;
            this.dashboardBtn.Text = "Dashboard";
            this.dashboardBtn.Click += new System.EventHandler(this.dashboardBtn_Click);
            // 
            // custumizedMessagePanel
            // 
            this.custumizedMessagePanel.Location = new System.Drawing.Point(0, 0);
            this.custumizedMessagePanel.Name = "custumizedMessagePanel";
            this.custumizedMessagePanel.ShadowDecoration.Parent = this.custumizedMessagePanel;
            this.custumizedMessagePanel.Size = new System.Drawing.Size(200, 100);
            this.custumizedMessagePanel.TabIndex = 0;
            // 
            // bodyLayout
            // 
            this.bodyLayout.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(250)))), ((int)(((byte)(250)))));
            this.bodyLayout.Controls.Add(this.messageLayout);
            this.bodyLayout.Controls.Add(this.dataPanel);
            this.bodyLayout.Location = new System.Drawing.Point(181, 35);
            this.bodyLayout.Name = "bodyLayout";
            this.bodyLayout.Size = new System.Drawing.Size(750, 524);
            this.bodyLayout.TabIndex = 2;
            // 
            // dataPanel
            // 
            this.dataPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(250)))), ((int)(((byte)(250)))));
            this.dataPanel.Location = new System.Drawing.Point(0, 0);
            this.dataPanel.Name = "dataPanel";
            this.dataPanel.Size = new System.Drawing.Size(750, 524);
            this.dataPanel.TabIndex = 0;
            this.dataPanel.Paint += new System.Windows.Forms.PaintEventHandler(this.dataPanel_Paint);
            // 
            // Admin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(250)))), ((int)(((byte)(250)))));
            this.ClientSize = new System.Drawing.Size(930, 560);
            this.Controls.Add(this.bodyLayout);
            this.Controls.Add(this.navBtnLayout);
            this.Controls.Add(this.upLayout);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Admin";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.HomeLayout_Load);
            this.upLayout.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.navBtnLayout.ResumeLayout(false);
            this.logoutPanel.ResumeLayout(false);
            this.logoutPanel.PerformLayout();
            this.bodyLayout.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion


        Guna.UI2.WinForms.Guna2GradientPanel custumizedMessagePanel;

        private System.Windows.Forms.Panel upLayout;
        private System.Windows.Forms.Panel navBtnLayout;
        private System.Windows.Forms.PictureBox pictureBox1;
        private Guna.UI2.WinForms.Guna2Button requestsBtn;
        private Guna.UI2.WinForms.Guna2Button employeesBtn;
        private Guna.UI2.WinForms.Guna2Button dashboardBtn;
        private System.Windows.Forms.Panel messageLayout;
        private System.Windows.Forms.Panel bodyLayout;
        private System.Windows.Forms.Panel dataPanel;
        private Guna.UI2.WinForms.Guna2Button logoutBtn;
        private Guna.UI2.WinForms.Guna2CustomGradientPanel logoutPanel;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private Guna.UI2.WinForms.Guna2Button guna2Button1;
        /*        private System.Windows.Forms.PictureBox pictureBox2;
*/        /*private System.Windows.Forms.Label textMessage;*/
    }
}