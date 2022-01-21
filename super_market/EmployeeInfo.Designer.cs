
namespace super_market
{
    partial class EmployeeInfo
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
            this.label5 = new System.Windows.Forms.Label();
            this.employeeTypeField = new Guna.UI2.WinForms.Guna2ComboBox();
            this.updateEmployeeBtn = new Guna.UI2.WinForms.Guna2Button();
            this.label6 = new System.Windows.Forms.Label();
            this.passwordField = new Guna.UI2.WinForms.Guna2TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.adressField = new Guna.UI2.WinForms.Guna2TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.phoneField = new Guna.UI2.WinForms.Guna2TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.cinField = new Guna.UI2.WinForms.Guna2TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.fullNameField = new Guna.UI2.WinForms.Guna2TextBox();
            this.headerLabel = new System.Windows.Forms.Label();
            this.deleteEmployeeBtn = new Guna.UI2.WinForms.Guna2Button();
            this.closeBtn = new Guna.UI2.WinForms.Guna2Button();
            this.SuspendLayout();
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.White;
            this.label5.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label5.Location = new System.Drawing.Point(37, 390);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(46, 16);
            this.label5.TabIndex = 37;
            this.label5.Text = "Type :";
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
            this.employeeTypeField.Location = new System.Drawing.Point(24, 399);
            this.employeeTypeField.Name = "employeeTypeField";
            this.employeeTypeField.ShadowDecoration.Parent = this.employeeTypeField;
            this.employeeTypeField.Size = new System.Drawing.Size(232, 36);
            this.employeeTypeField.TabIndex = 36;
            // 
            // updateEmployeeBtn
            // 
            this.updateEmployeeBtn.BackColor = System.Drawing.Color.White;
            this.updateEmployeeBtn.BorderRadius = 5;
            this.updateEmployeeBtn.CheckedState.Parent = this.updateEmployeeBtn;
            this.updateEmployeeBtn.CustomImages.Parent = this.updateEmployeeBtn;
            this.updateEmployeeBtn.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.updateEmployeeBtn.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.updateEmployeeBtn.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.updateEmployeeBtn.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.updateEmployeeBtn.DisabledState.Parent = this.updateEmployeeBtn;
            this.updateEmployeeBtn.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(219)))), ((int)(((byte)(254)))));
            this.updateEmployeeBtn.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold);
            this.updateEmployeeBtn.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(59)))), ((int)(((byte)(130)))), ((int)(((byte)(246)))));
            this.updateEmployeeBtn.HoverState.Parent = this.updateEmployeeBtn;
            this.updateEmployeeBtn.Location = new System.Drawing.Point(23, 457);
            this.updateEmployeeBtn.Name = "updateEmployeeBtn";
            this.updateEmployeeBtn.ShadowDecoration.Parent = this.updateEmployeeBtn;
            this.updateEmployeeBtn.Size = new System.Drawing.Size(97, 38);
            this.updateEmployeeBtn.TabIndex = 35;
            this.updateEmployeeBtn.Text = "Update";
            this.updateEmployeeBtn.Click += new System.EventHandler(this.addEmployeeBtn_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.White;
            this.label6.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label6.Location = new System.Drawing.Point(34, 322);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(77, 16);
            this.label6.TabIndex = 34;
            this.label6.Text = "Password :";
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
            this.passwordField.Location = new System.Drawing.Point(23, 330);
            this.passwordField.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.passwordField.Name = "passwordField";
            this.passwordField.PasswordChar = '\0';
            this.passwordField.PlaceholderText = "";
            this.passwordField.SelectedText = "";
            this.passwordField.ShadowDecoration.Parent = this.passwordField;
            this.passwordField.Size = new System.Drawing.Size(233, 43);
            this.passwordField.TabIndex = 33;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.White;
            this.label7.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label7.Location = new System.Drawing.Point(34, 253);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(58, 16);
            this.label7.TabIndex = 32;
            this.label7.Text = "Adress :";
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
            this.adressField.Location = new System.Drawing.Point(23, 261);
            this.adressField.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.adressField.Name = "adressField";
            this.adressField.PasswordChar = '\0';
            this.adressField.PlaceholderText = "";
            this.adressField.SelectedText = "";
            this.adressField.ShadowDecoration.Parent = this.adressField;
            this.adressField.Size = new System.Drawing.Size(233, 43);
            this.adressField.TabIndex = 31;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.White;
            this.label4.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label4.Location = new System.Drawing.Point(34, 187);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(57, 16);
            this.label4.TabIndex = 30;
            this.label4.Text = "Phone :";
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
            this.phoneField.Location = new System.Drawing.Point(23, 195);
            this.phoneField.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.phoneField.Name = "phoneField";
            this.phoneField.PasswordChar = '\0';
            this.phoneField.PlaceholderText = "";
            this.phoneField.SelectedText = "";
            this.phoneField.ShadowDecoration.Parent = this.phoneField;
            this.phoneField.Size = new System.Drawing.Size(233, 43);
            this.phoneField.TabIndex = 29;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.White;
            this.label3.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label3.Location = new System.Drawing.Point(34, 121);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(38, 16);
            this.label3.TabIndex = 28;
            this.label3.Text = "CIN :";
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
            this.cinField.Location = new System.Drawing.Point(23, 129);
            this.cinField.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.cinField.Name = "cinField";
            this.cinField.PasswordChar = '\0';
            this.cinField.PlaceholderText = "";
            this.cinField.SelectedText = "";
            this.cinField.ShadowDecoration.Parent = this.cinField;
            this.cinField.Size = new System.Drawing.Size(233, 43);
            this.cinField.TabIndex = 27;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.White;
            this.label2.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label2.Location = new System.Drawing.Point(34, 56);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(80, 16);
            this.label2.TabIndex = 26;
            this.label2.Text = "Full name :";
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
            this.fullNameField.Location = new System.Drawing.Point(23, 64);
            this.fullNameField.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.fullNameField.Name = "fullNameField";
            this.fullNameField.PasswordChar = '\0';
            this.fullNameField.PlaceholderText = "";
            this.fullNameField.SelectedText = "";
            this.fullNameField.ShadowDecoration.Parent = this.fullNameField;
            this.fullNameField.Size = new System.Drawing.Size(233, 43);
            this.fullNameField.TabIndex = 25;
            // 
            // headerLabel
            // 
            this.headerLabel.AutoSize = true;
            this.headerLabel.Font = new System.Drawing.Font("Arial", 13F);
            this.headerLabel.Location = new System.Drawing.Point(20, 18);
            this.headerLabel.Name = "headerLabel";
            this.headerLabel.Size = new System.Drawing.Size(134, 21);
            this.headerLabel.TabIndex = 24;
            this.headerLabel.Text = "Employee N°0 :";
            // 
            // deleteEmployeeBtn
            // 
            this.deleteEmployeeBtn.BackColor = System.Drawing.Color.White;
            this.deleteEmployeeBtn.BorderRadius = 5;
            this.deleteEmployeeBtn.CheckedState.Parent = this.deleteEmployeeBtn;
            this.deleteEmployeeBtn.CustomImages.Parent = this.deleteEmployeeBtn;
            this.deleteEmployeeBtn.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.deleteEmployeeBtn.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.deleteEmployeeBtn.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.deleteEmployeeBtn.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.deleteEmployeeBtn.DisabledState.Parent = this.deleteEmployeeBtn;
            this.deleteEmployeeBtn.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(254)))), ((int)(((byte)(202)))), ((int)(((byte)(202)))));
            this.deleteEmployeeBtn.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold);
            this.deleteEmployeeBtn.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(38)))), ((int)(((byte)(38)))));
            this.deleteEmployeeBtn.HoverState.Parent = this.deleteEmployeeBtn;
            this.deleteEmployeeBtn.Location = new System.Drawing.Point(165, 457);
            this.deleteEmployeeBtn.Name = "deleteEmployeeBtn";
            this.deleteEmployeeBtn.ShadowDecoration.Parent = this.deleteEmployeeBtn;
            this.deleteEmployeeBtn.Size = new System.Drawing.Size(91, 38);
            this.deleteEmployeeBtn.TabIndex = 38;
            this.deleteEmployeeBtn.Text = "Delete";
            this.deleteEmployeeBtn.Click += new System.EventHandler(this.guna2Button1_Click);
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
            this.closeBtn.Location = new System.Drawing.Point(226, 11);
            this.closeBtn.Name = "closeBtn";
            this.closeBtn.ShadowDecoration.Parent = this.closeBtn;
            this.closeBtn.Size = new System.Drawing.Size(30, 30);
            this.closeBtn.TabIndex = 39;
            this.closeBtn.Text = "X";
            this.closeBtn.Click += new System.EventHandler(this.closeBtn_Click);
            // 
            // EmployeeInfo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.closeBtn);
            this.Controls.Add(this.deleteEmployeeBtn);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.employeeTypeField);
            this.Controls.Add(this.updateEmployeeBtn);
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
            this.Controls.Add(this.headerLabel);
            this.Name = "EmployeeInfo";
            this.Size = new System.Drawing.Size(280, 524);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label5;
        private Guna.UI2.WinForms.Guna2ComboBox employeeTypeField;
        private Guna.UI2.WinForms.Guna2Button updateEmployeeBtn;
        private System.Windows.Forms.Label label6;
        private Guna.UI2.WinForms.Guna2TextBox passwordField;
        private System.Windows.Forms.Label label7;
        private Guna.UI2.WinForms.Guna2TextBox adressField;
        private System.Windows.Forms.Label label4;
        private Guna.UI2.WinForms.Guna2TextBox phoneField;
        private System.Windows.Forms.Label label3;
        private Guna.UI2.WinForms.Guna2TextBox cinField;
        private System.Windows.Forms.Label label2;
        private Guna.UI2.WinForms.Guna2TextBox fullNameField;
        private System.Windows.Forms.Label headerLabel;
        private Guna.UI2.WinForms.Guna2Button deleteEmployeeBtn;
        private Guna.UI2.WinForms.Guna2Button closeBtn;
    }
}
