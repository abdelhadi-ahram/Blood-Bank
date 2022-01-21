


namespace super_market
{
    partial class AddEmployee
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.fullNameField = new Guna.UI2.WinForms.Guna2TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.cinField = new Guna.UI2.WinForms.Guna2TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.phoneField = new Guna.UI2.WinForms.Guna2TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.passwordField = new Guna.UI2.WinForms.Guna2TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.adressField = new Guna.UI2.WinForms.Guna2TextBox();
            this.addEmployeeBtn = new Guna.UI2.WinForms.Guna2Button();
            this.employeeTypeField = new Guna.UI2.WinForms.Guna2ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.closeBtn = new Guna.UI2.WinForms.Guna2Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 13F);
            this.label1.Location = new System.Drawing.Point(22, 17);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(186, 21);
            this.label1.TabIndex = 0;
            this.label1.Text = "Add a new employee :";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.White;
            this.label2.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label2.Location = new System.Drawing.Point(36, 55);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(80, 16);
            this.label2.TabIndex = 10;
            this.label2.Text = "Full name :";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // fullNameField
            // 
            this.fullNameField.BackColor = System.Drawing.Color.White;
            this.fullNameField.BorderRadius = 5;
            this.fullNameField.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.fullNameField.DefaultText = "";
            this.fullNameField.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.fullNameField.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.fullNameField.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.fullNameField.DisabledState.Parent = this.fullNameField;
            this.fullNameField.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.fullNameField.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(38)))), ((int)(((byte)(38)))));
            this.fullNameField.FocusedState.Parent = this.fullNameField;
            this.fullNameField.Font = new System.Drawing.Font("Segoe UI", 13F);
            this.fullNameField.ForeColor = System.Drawing.Color.Black;
            this.fullNameField.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.fullNameField.HoverState.Parent = this.fullNameField;
            this.fullNameField.Location = new System.Drawing.Point(25, 63);
            this.fullNameField.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.fullNameField.Name = "fullNameField";
            this.fullNameField.PasswordChar = '\0';
            this.fullNameField.PlaceholderText = "";
            this.fullNameField.SelectedText = "";
            this.fullNameField.ShadowDecoration.Parent = this.fullNameField;
            this.fullNameField.Size = new System.Drawing.Size(233, 43);
            this.fullNameField.TabIndex = 9;
            this.fullNameField.TextChanged += new System.EventHandler(this.fullNameField_TextChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.White;
            this.label3.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label3.Location = new System.Drawing.Point(36, 120);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(38, 16);
            this.label3.TabIndex = 12;
            this.label3.Text = "CIN :";
            this.label3.Click += new System.EventHandler(this.label3_Click);
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
            this.cinField.Location = new System.Drawing.Point(25, 128);
            this.cinField.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.cinField.Name = "cinField";
            this.cinField.PasswordChar = '\0';
            this.cinField.PlaceholderText = "";
            this.cinField.SelectedText = "";
            this.cinField.ShadowDecoration.Parent = this.cinField;
            this.cinField.Size = new System.Drawing.Size(233, 43);
            this.cinField.TabIndex = 11;
            this.cinField.TextChanged += new System.EventHandler(this.cinField_TextChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.White;
            this.label4.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label4.Location = new System.Drawing.Point(36, 186);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(57, 16);
            this.label4.TabIndex = 14;
            this.label4.Text = "Phone :";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // phoneField
            // 
            this.phoneField.BackColor = System.Drawing.Color.White;
            this.phoneField.BorderRadius = 5;
            this.phoneField.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.phoneField.DefaultText = "";
            this.phoneField.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.phoneField.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.phoneField.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.phoneField.DisabledState.Parent = this.phoneField;
            this.phoneField.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.phoneField.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(38)))), ((int)(((byte)(38)))));
            this.phoneField.FocusedState.Parent = this.phoneField;
            this.phoneField.Font = new System.Drawing.Font("Segoe UI", 13F);
            this.phoneField.ForeColor = System.Drawing.Color.Black;
            this.phoneField.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.phoneField.HoverState.Parent = this.phoneField;
            this.phoneField.Location = new System.Drawing.Point(25, 194);
            this.phoneField.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.phoneField.Name = "phoneField";
            this.phoneField.PasswordChar = '\0';
            this.phoneField.PlaceholderText = "";
            this.phoneField.SelectedText = "";
            this.phoneField.ShadowDecoration.Parent = this.phoneField;
            this.phoneField.Size = new System.Drawing.Size(233, 43);
            this.phoneField.TabIndex = 13;
            this.phoneField.TextChanged += new System.EventHandler(this.phoneField_TextChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.White;
            this.label6.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label6.Location = new System.Drawing.Point(36, 321);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(77, 16);
            this.label6.TabIndex = 18;
            this.label6.Text = "Password :";
            this.label6.Click += new System.EventHandler(this.label6_Click);
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
            this.passwordField.Location = new System.Drawing.Point(25, 329);
            this.passwordField.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.passwordField.Name = "passwordField";
            this.passwordField.PasswordChar = '\0';
            this.passwordField.PlaceholderText = "";
            this.passwordField.SelectedText = "";
            this.passwordField.ShadowDecoration.Parent = this.passwordField;
            this.passwordField.Size = new System.Drawing.Size(233, 43);
            this.passwordField.TabIndex = 17;
            this.passwordField.TextChanged += new System.EventHandler(this.passwordField_TextChanged);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.White;
            this.label7.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label7.Location = new System.Drawing.Point(36, 252);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(58, 16);
            this.label7.TabIndex = 16;
            this.label7.Text = "Adress :";
            this.label7.Click += new System.EventHandler(this.label7_Click);
            // 
            // adressField
            // 
            this.adressField.BackColor = System.Drawing.Color.White;
            this.adressField.BorderRadius = 5;
            this.adressField.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.adressField.DefaultText = "";
            this.adressField.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.adressField.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.adressField.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.adressField.DisabledState.Parent = this.adressField;
            this.adressField.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.adressField.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(38)))), ((int)(((byte)(38)))));
            this.adressField.FocusedState.Parent = this.adressField;
            this.adressField.Font = new System.Drawing.Font("Segoe UI", 13F);
            this.adressField.ForeColor = System.Drawing.Color.Black;
            this.adressField.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.adressField.HoverState.Parent = this.adressField;
            this.adressField.Location = new System.Drawing.Point(25, 260);
            this.adressField.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.adressField.Name = "adressField";
            this.adressField.PasswordChar = '\0';
            this.adressField.PlaceholderText = "";
            this.adressField.SelectedText = "";
            this.adressField.ShadowDecoration.Parent = this.adressField;
            this.adressField.Size = new System.Drawing.Size(233, 43);
            this.adressField.TabIndex = 15;
            this.adressField.TextChanged += new System.EventHandler(this.adressField_TextChanged);
            // 
            // addEmployeeBtn
            // 
            this.addEmployeeBtn.BackColor = System.Drawing.Color.White;
            this.addEmployeeBtn.BorderRadius = 5;
            this.addEmployeeBtn.CheckedState.Parent = this.addEmployeeBtn;
            this.addEmployeeBtn.CustomImages.Parent = this.addEmployeeBtn;
            this.addEmployeeBtn.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.addEmployeeBtn.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.addEmployeeBtn.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.addEmployeeBtn.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.addEmployeeBtn.DisabledState.Parent = this.addEmployeeBtn;
            this.addEmployeeBtn.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(38)))), ((int)(((byte)(38)))));
            this.addEmployeeBtn.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold);
            this.addEmployeeBtn.ForeColor = System.Drawing.Color.White;
            this.addEmployeeBtn.HoverState.Parent = this.addEmployeeBtn;
            this.addEmployeeBtn.Location = new System.Drawing.Point(25, 456);
            this.addEmployeeBtn.Name = "addEmployeeBtn";
            this.addEmployeeBtn.ShadowDecoration.Parent = this.addEmployeeBtn;
            this.addEmployeeBtn.Size = new System.Drawing.Size(233, 38);
            this.addEmployeeBtn.TabIndex = 21;
            this.addEmployeeBtn.Text = "Add employee";
            this.addEmployeeBtn.Click += new System.EventHandler(this.loginBtn_Click);
            // 
            // employeeTypeField
            // 
            this.employeeTypeField.BackColor = System.Drawing.Color.Transparent;
            this.employeeTypeField.BorderRadius = 5;
            this.employeeTypeField.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.employeeTypeField.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.employeeTypeField.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.employeeTypeField.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.employeeTypeField.FocusedState.Parent = this.employeeTypeField;
            this.employeeTypeField.Font = new System.Drawing.Font("Arial", 11F);
            this.employeeTypeField.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(88)))), ((int)(((byte)(112)))));
            this.employeeTypeField.HoverState.Parent = this.employeeTypeField;
            this.employeeTypeField.ItemHeight = 30;
            this.employeeTypeField.Items.AddRange(new object[] {
            "Admin",
            "Doctor",
            "Nurse"});
            this.employeeTypeField.ItemsAppearance.Parent = this.employeeTypeField;
            this.employeeTypeField.Location = new System.Drawing.Point(26, 398);
            this.employeeTypeField.Name = "employeeTypeField";
            this.employeeTypeField.ShadowDecoration.Parent = this.employeeTypeField;
            this.employeeTypeField.Size = new System.Drawing.Size(232, 36);
            this.employeeTypeField.TabIndex = 22;
            this.employeeTypeField.SelectedIndexChanged += new System.EventHandler(this.employeeTypeField_SelectedIndexChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.White;
            this.label5.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label5.Location = new System.Drawing.Point(39, 389);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(46, 16);
            this.label5.TabIndex = 23;
            this.label5.Text = "Type :";
            this.label5.Click += new System.EventHandler(this.label5_Click);
            // 
            // closeBtn
            // 
            this.closeBtn.BackColor = System.Drawing.Color.White;
            this.closeBtn.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(116)))), ((int)(((byte)(139)))));
            this.closeBtn.BorderRadius = 15;
            this.closeBtn.BorderThickness = 1;
            this.closeBtn.CheckedState.Parent = this.closeBtn;
            this.closeBtn.CustomImages.Parent = this.closeBtn;
            this.closeBtn.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.closeBtn.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.closeBtn.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.closeBtn.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.closeBtn.DisabledState.Parent = this.closeBtn;
            this.closeBtn.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(250)))), ((int)(((byte)(250)))));
            this.closeBtn.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold);
            this.closeBtn.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(116)))), ((int)(((byte)(139)))));
            this.closeBtn.HoverState.Parent = this.closeBtn;
            this.closeBtn.Location = new System.Drawing.Point(228, 14);
            this.closeBtn.Name = "closeBtn";
            this.closeBtn.ShadowDecoration.Parent = this.closeBtn;
            this.closeBtn.Size = new System.Drawing.Size(30, 30);
            this.closeBtn.TabIndex = 40;
            this.closeBtn.Text = "X";
            this.closeBtn.Click += new System.EventHandler(this.closeBtn_Click);
            // 
            // AddEmployee
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.closeBtn);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.employeeTypeField);
            this.Controls.Add(this.addEmployeeBtn);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.passwordField);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.adressField);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.phoneField);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.cinField);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.fullNameField);
            this.Controls.Add(this.label1);
            this.Name = "AddEmployee";
            this.Size = new System.Drawing.Size(280, 524);
            this.Load += new System.EventHandler(this.UserControl1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private Guna.UI2.WinForms.Guna2TextBox fullNameField;
        private System.Windows.Forms.Label label3;
        private Guna.UI2.WinForms.Guna2TextBox cinField;
        private System.Windows.Forms.Label label4;
        private Guna.UI2.WinForms.Guna2TextBox phoneField;
        private System.Windows.Forms.Label label6;
        private Guna.UI2.WinForms.Guna2TextBox passwordField;
        private System.Windows.Forms.Label label7;
        private Guna.UI2.WinForms.Guna2TextBox adressField;
        private Guna.UI2.WinForms.Guna2Button addEmployeeBtn;
        private Guna.UI2.WinForms.Guna2ComboBox employeeTypeField;
        private System.Windows.Forms.Label label5;
        private Guna.UI2.WinForms.Guna2Button closeBtn;
    }
}
