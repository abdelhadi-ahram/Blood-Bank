
namespace super_market
{
    partial class LoginForm
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
            this.guna2CustomGradientPanel1 = new Guna.UI2.WinForms.Guna2CustomGradientPanel();
            this.fieldsLayout = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.passwordShow = new Guna.UI2.WinForms.Guna2CheckBox();
            this.loginBtn = new Guna.UI2.WinForms.Guna2Button();
            this.passwordField = new Guna.UI2.WinForms.Guna2TextBox();
            this.cinField = new Guna.UI2.WinForms.Guna2TextBox();
            this.messageLayout = new Guna.UI2.WinForms.Guna2CustomGradientPanel();
            this.messageText = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.guna2CustomGradientPanel1.SuspendLayout();
            this.fieldsLayout.SuspendLayout();
            this.messageLayout.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // guna2CustomGradientPanel1
            // 
            this.guna2CustomGradientPanel1.BorderRadius = 15;
            this.guna2CustomGradientPanel1.Controls.Add(this.fieldsLayout);
            this.guna2CustomGradientPanel1.Controls.Add(this.messageLayout);
            this.guna2CustomGradientPanel1.Location = new System.Drawing.Point(91, 74);
            this.guna2CustomGradientPanel1.Name = "guna2CustomGradientPanel1";
            this.guna2CustomGradientPanel1.ShadowDecoration.Parent = this.guna2CustomGradientPanel1;
            this.guna2CustomGradientPanel1.Size = new System.Drawing.Size(356, 394);
            this.guna2CustomGradientPanel1.TabIndex = 0;
            // 
            // fieldsLayout
            // 
            this.fieldsLayout.BackColor = System.Drawing.Color.White;
            this.fieldsLayout.Controls.Add(this.label1);
            this.fieldsLayout.Controls.Add(this.label2);
            this.fieldsLayout.Controls.Add(this.passwordShow);
            this.fieldsLayout.Controls.Add(this.loginBtn);
            this.fieldsLayout.Controls.Add(this.passwordField);
            this.fieldsLayout.Controls.Add(this.cinField);
            this.fieldsLayout.Location = new System.Drawing.Point(34, 55);
            this.fieldsLayout.Name = "fieldsLayout";
            this.fieldsLayout.Size = new System.Drawing.Size(290, 286);
            this.fieldsLayout.TabIndex = 8;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.White;
            this.label1.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label1.Location = new System.Drawing.Point(20, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(38, 16);
            this.label1.TabIndex = 8;
            this.label1.Text = "CIN :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.White;
            this.label2.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label2.Location = new System.Drawing.Point(20, 106);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(77, 16);
            this.label2.TabIndex = 9;
            this.label2.Text = "Password :";
            // 
            // passwordShow
            // 
            this.passwordShow.AutoSize = true;
            this.passwordShow.BackColor = System.Drawing.Color.White;
            this.passwordShow.CheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(38)))), ((int)(((byte)(38)))));
            this.passwordShow.CheckedState.BorderRadius = 0;
            this.passwordShow.CheckedState.BorderThickness = 0;
            this.passwordShow.CheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(38)))), ((int)(((byte)(38)))));
            this.passwordShow.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.passwordShow.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.passwordShow.Location = new System.Drawing.Point(12, 177);
            this.passwordShow.Name = "passwordShow";
            this.passwordShow.Size = new System.Drawing.Size(101, 17);
            this.passwordShow.TabIndex = 11;
            this.passwordShow.Text = "Show password";
            this.passwordShow.UncheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(38)))), ((int)(((byte)(38)))));
            this.passwordShow.UncheckedState.BorderRadius = 2;
            this.passwordShow.UncheckedState.BorderThickness = 1;
            this.passwordShow.UncheckedState.FillColor = System.Drawing.Color.White;
            this.passwordShow.UseVisualStyleBackColor = false;
            this.passwordShow.CheckedChanged += new System.EventHandler(this.passwordShow_CheckedChanged);
            // 
            // loginBtn
            // 
            this.loginBtn.BackColor = System.Drawing.Color.White;
            this.loginBtn.BorderRadius = 5;
            this.loginBtn.CheckedState.Parent = this.loginBtn;
            this.loginBtn.CustomImages.Parent = this.loginBtn;
            this.loginBtn.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.loginBtn.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.loginBtn.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.loginBtn.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.loginBtn.DisabledState.Parent = this.loginBtn;
            this.loginBtn.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(38)))), ((int)(((byte)(38)))));
            this.loginBtn.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold);
            this.loginBtn.ForeColor = System.Drawing.Color.White;
            this.loginBtn.HoverState.Parent = this.loginBtn;
            this.loginBtn.Location = new System.Drawing.Point(9, 218);
            this.loginBtn.Name = "loginBtn";
            this.loginBtn.ShadowDecoration.Parent = this.loginBtn;
            this.loginBtn.Size = new System.Drawing.Size(269, 42);
            this.loginBtn.TabIndex = 10;
            this.loginBtn.Text = "Login";
            this.loginBtn.Click += new System.EventHandler(this.loginBtn_Click);
            // 
            // passwordField
            // 
            this.passwordField.BackColor = System.Drawing.Color.White;
            this.passwordField.BorderRadius = 5;
            this.passwordField.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.passwordField.DefaultText = "";
            this.passwordField.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.passwordField.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.passwordField.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.passwordField.DisabledState.Parent = this.passwordField;
            this.passwordField.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.passwordField.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(38)))), ((int)(((byte)(38)))));
            this.passwordField.FocusedState.Parent = this.passwordField;
            this.passwordField.Font = new System.Drawing.Font("Segoe UI", 13F);
            this.passwordField.ForeColor = System.Drawing.Color.Black;
            this.passwordField.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.passwordField.HoverState.Parent = this.passwordField;
            this.passwordField.Location = new System.Drawing.Point(9, 114);
            this.passwordField.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.passwordField.Name = "passwordField";
            this.passwordField.PasswordChar = '\0';
            this.passwordField.PlaceholderText = "";
            this.passwordField.SelectedText = "";
            this.passwordField.ShadowDecoration.Parent = this.passwordField;
            this.passwordField.Size = new System.Drawing.Size(269, 45);
            this.passwordField.TabIndex = 12;
            this.passwordField.UseSystemPasswordChar = true;
            // 
            // cinField
            // 
            this.cinField.BackColor = System.Drawing.Color.White;
            this.cinField.BorderRadius = 5;
            this.cinField.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.cinField.DefaultText = "";
            this.cinField.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.cinField.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.cinField.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.cinField.DisabledState.Parent = this.cinField;
            this.cinField.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.cinField.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(38)))), ((int)(((byte)(38)))));
            this.cinField.FocusedState.Parent = this.cinField;
            this.cinField.Font = new System.Drawing.Font("Segoe UI", 13F);
            this.cinField.ForeColor = System.Drawing.Color.Black;
            this.cinField.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cinField.HoverState.Parent = this.cinField;
            this.cinField.Location = new System.Drawing.Point(9, 35);
            this.cinField.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.cinField.Name = "cinField";
            this.cinField.PasswordChar = '\0';
            this.cinField.PlaceholderText = "";
            this.cinField.SelectedText = "";
            this.cinField.ShadowDecoration.Parent = this.cinField;
            this.cinField.Size = new System.Drawing.Size(269, 45);
            this.cinField.TabIndex = 7;
            // 
            // messageLayout
            // 
            this.messageLayout.BorderRadius = 7;
            this.messageLayout.BorderThickness = 1;
            this.messageLayout.Controls.Add(this.messageText);
            this.messageLayout.CustomBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(68)))), ((int)(((byte)(68)))));
            this.messageLayout.CustomBorderThickness = new System.Windows.Forms.Padding(5, 0, 0, 0);
            this.messageLayout.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(254)))), ((int)(((byte)(202)))), ((int)(((byte)(202)))));
            this.messageLayout.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(254)))), ((int)(((byte)(202)))), ((int)(((byte)(202)))));
            this.messageLayout.FillColor3 = System.Drawing.Color.FromArgb(((int)(((byte)(254)))), ((int)(((byte)(202)))), ((int)(((byte)(202)))));
            this.messageLayout.FillColor4 = System.Drawing.Color.FromArgb(((int)(((byte)(254)))), ((int)(((byte)(202)))), ((int)(((byte)(202)))));
            this.messageLayout.Location = new System.Drawing.Point(44, 24);
            this.messageLayout.Name = "messageLayout";
            this.messageLayout.ShadowDecoration.Parent = this.messageLayout;
            this.messageLayout.Size = new System.Drawing.Size(269, 0);
            this.messageLayout.TabIndex = 7;
            // 
            // messageText
            // 
            this.messageText.AutoSize = true;
            this.messageText.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(254)))), ((int)(((byte)(202)))), ((int)(((byte)(202)))));
            this.messageText.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.messageText.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(68)))), ((int)(((byte)(68)))));
            this.messageText.Location = new System.Drawing.Point(23, 12);
            this.messageText.Name = "messageText";
            this.messageText.Size = new System.Drawing.Size(199, 17);
            this.messageText.TabIndex = 0;
            this.messageText.Text = "CIN or Password are incorrect!";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::super_market.Properties.Resources._4212524;
            this.pictureBox1.Location = new System.Drawing.Point(-3, -1);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(548, 536);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // LoginForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            this.ClientSize = new System.Drawing.Size(544, 535);
            this.Controls.Add(this.guna2CustomGradientPanel1);
            this.Controls.Add(this.pictureBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "LoginForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.guna2CustomGradientPanel1.ResumeLayout(false);
            this.fieldsLayout.ResumeLayout(false);
            this.fieldsLayout.PerformLayout();
            this.messageLayout.ResumeLayout(false);
            this.messageLayout.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI2.WinForms.Guna2CustomGradientPanel guna2CustomGradientPanel1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private Guna.UI2.WinForms.Guna2CustomGradientPanel messageLayout;
        private System.Windows.Forms.Label messageText;
        private System.Windows.Forms.Panel fieldsLayout;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private Guna.UI2.WinForms.Guna2CheckBox passwordShow;
        private Guna.UI2.WinForms.Guna2Button loginBtn;
        private Guna.UI2.WinForms.Guna2TextBox passwordField;
        private Guna.UI2.WinForms.Guna2TextBox cinField;
    }
}