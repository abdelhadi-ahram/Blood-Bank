
namespace super_market
{
    partial class DonorInfo
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
            this.bodyPanel = new Guna.UI2.WinForms.Guna2CustomGradientPanel();
            this.quantityField = new System.Windows.Forms.Label();
            this.typeField = new System.Windows.Forms.Label();
            this.birthField = new System.Windows.Forms.Label();
            this.phoneField = new System.Windows.Forms.Label();
            this.cinField = new System.Windows.Forms.Label();
            this.bodyPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // bodyPanel
            // 
            this.bodyPanel.Controls.Add(this.quantityField);
            this.bodyPanel.Controls.Add(this.typeField);
            this.bodyPanel.Controls.Add(this.birthField);
            this.bodyPanel.Controls.Add(this.phoneField);
            this.bodyPanel.Controls.Add(this.cinField);
            this.bodyPanel.Location = new System.Drawing.Point(0, 0);
            this.bodyPanel.Name = "bodyPanel";
            this.bodyPanel.ShadowDecoration.Color = System.Drawing.Color.Gray;
            this.bodyPanel.ShadowDecoration.Depth = 15;
            this.bodyPanel.ShadowDecoration.Enabled = true;
            this.bodyPanel.ShadowDecoration.Parent = this.bodyPanel;
            this.bodyPanel.Size = new System.Drawing.Size(389, 39);
            this.bodyPanel.TabIndex = 6;
            this.bodyPanel.Paint += new System.Windows.Forms.PaintEventHandler(this.guna2CustomGradientPanel3_Paint);
            // 
            // quantityField
            // 
            this.quantityField.AutoSize = true;
            this.quantityField.BackColor = System.Drawing.Color.White;
            this.quantityField.Font = new System.Drawing.Font("Arial", 10F);
            this.quantityField.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.quantityField.Location = new System.Drawing.Point(333, 11);
            this.quantityField.Name = "quantityField";
            this.quantityField.Size = new System.Drawing.Size(32, 16);
            this.quantityField.TabIndex = 9;
            this.quantityField.Text = "100";
            // 
            // typeField
            // 
            this.typeField.AutoSize = true;
            this.typeField.BackColor = System.Drawing.Color.White;
            this.typeField.Font = new System.Drawing.Font("Arial", 10F);
            this.typeField.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.typeField.Location = new System.Drawing.Point(281, 11);
            this.typeField.Name = "typeField";
            this.typeField.Size = new System.Drawing.Size(25, 16);
            this.typeField.TabIndex = 8;
            this.typeField.Text = "A+";
            // 
            // birthField
            // 
            this.birthField.AutoSize = true;
            this.birthField.BackColor = System.Drawing.Color.White;
            this.birthField.Font = new System.Drawing.Font("Arial", 10F);
            this.birthField.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.birthField.Location = new System.Drawing.Point(184, 11);
            this.birthField.Name = "birthField";
            this.birthField.Size = new System.Drawing.Size(80, 16);
            this.birthField.TabIndex = 7;
            this.birthField.Text = "12/15/1999";
            // 
            // phoneField
            // 
            this.phoneField.AutoSize = true;
            this.phoneField.BackColor = System.Drawing.Color.White;
            this.phoneField.Font = new System.Drawing.Font("Arial", 10F);
            this.phoneField.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.phoneField.Location = new System.Drawing.Point(84, 11);
            this.phoneField.Name = "phoneField";
            this.phoneField.Size = new System.Drawing.Size(88, 16);
            this.phoneField.TabIndex = 6;
            this.phoneField.Text = "0673618563";
            // 
            // cinField
            // 
            this.cinField.AutoSize = true;
            this.cinField.BackColor = System.Drawing.Color.White;
            this.cinField.Font = new System.Drawing.Font("Arial", 10F);
            this.cinField.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.cinField.Location = new System.Drawing.Point(10, 11);
            this.cinField.Name = "cinField";
            this.cinField.Size = new System.Drawing.Size(63, 16);
            this.cinField.TabIndex = 5;
            this.cinField.Text = "JY43767";
            // 
            // DonorInfo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(250)))), ((int)(((byte)(250)))));
            this.Controls.Add(this.bodyPanel);
            this.Name = "DonorInfo";
            this.Size = new System.Drawing.Size(389, 39);
            this.bodyPanel.ResumeLayout(false);
            this.bodyPanel.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI2.WinForms.Guna2CustomGradientPanel bodyPanel;
        private System.Windows.Forms.Label quantityField;
        private System.Windows.Forms.Label typeField;
        private System.Windows.Forms.Label birthField;
        private System.Windows.Forms.Label phoneField;
        private System.Windows.Forms.Label cinField;
    }
}
