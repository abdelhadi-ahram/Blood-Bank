
namespace super_market
{
    partial class EmployeesArray
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.CheckEmployee = new Guna.UI2.WinForms.Guna2CheckBox();
            this.fullName = new System.Windows.Forms.Label();
            this.cin = new System.Windows.Forms.Label();
            this.phone = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Controls.Add(this.phone);
            this.panel1.Controls.Add(this.cin);
            this.panel1.Controls.Add(this.fullName);
            this.panel1.Controls.Add(this.CheckEmployee);
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(388, 40);
            this.panel1.TabIndex = 0;
            // 
            // CheckEmployee
            // 
            this.CheckEmployee.AutoSize = true;
            this.CheckEmployee.CheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.CheckEmployee.CheckedState.BorderRadius = 5;
            this.CheckEmployee.CheckedState.BorderThickness = 0;
            this.CheckEmployee.CheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(38)))), ((int)(((byte)(38)))));
            this.CheckEmployee.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.CheckEmployee.Location = new System.Drawing.Point(12, 11);
            this.CheckEmployee.Name = "CheckEmployee";
            this.CheckEmployee.Size = new System.Drawing.Size(15, 14);
            this.CheckEmployee.TabIndex = 1;
            this.CheckEmployee.UncheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(38)))), ((int)(((byte)(38)))));
            this.CheckEmployee.UncheckedState.BorderRadius = 5;
            this.CheckEmployee.UncheckedState.BorderThickness = 1;
            this.CheckEmployee.UncheckedState.FillColor = System.Drawing.Color.White;
            this.CheckEmployee.CheckedChanged += new System.EventHandler(this.CheckEmployee_CheckedChanged);
            // 
            // fullName
            // 
            this.fullName.AutoSize = true;
            this.fullName.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.fullName.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.fullName.Location = new System.Drawing.Point(48, 11);
            this.fullName.Name = "fullName";
            this.fullName.Size = new System.Drawing.Size(117, 17);
            this.fullName.TabIndex = 3;
            this.fullName.Text = "Abdelhadi Ahram";
            // 
            // cin
            // 
            this.cin.AutoSize = true;
            this.cin.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cin.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.cin.Location = new System.Drawing.Point(186, 11);
            this.cin.Name = "cin";
            this.cin.Size = new System.Drawing.Size(64, 17);
            this.cin.TabIndex = 4;
            this.cin.Text = "JY43767";
            // 
            // phone
            // 
            this.phone.AutoSize = true;
            this.phone.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.phone.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.phone.Location = new System.Drawing.Point(275, 11);
            this.phone.Name = "phone";
            this.phone.Size = new System.Drawing.Size(88, 17);
            this.phone.TabIndex = 5;
            this.phone.Text = "0673618563";
            // 
            // EmployeesArray
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.panel1);
            this.Name = "EmployeesArray";
            this.Size = new System.Drawing.Size(388, 40);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label phone;
        private System.Windows.Forms.Label cin;
        private System.Windows.Forms.Label fullName;
        private Guna.UI2.WinForms.Guna2CheckBox CheckEmployee;
    }
}
