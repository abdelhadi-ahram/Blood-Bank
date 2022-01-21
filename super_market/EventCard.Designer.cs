
namespace super_market
{
    partial class EventCard
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
            this.guna2CustomGradientPanel1 = new Guna.UI2.WinForms.Guna2CustomGradientPanel();
            this.kryptonLabel4 = new Krypton.Toolkit.KryptonLabel();
            this.kryptonLabel3 = new Krypton.Toolkit.KryptonLabel();
            this.endField = new Krypton.Toolkit.KryptonLabel();
            this.editBtn = new Guna.UI2.WinForms.Guna2Button();
            this.startField = new Krypton.Toolkit.KryptonLabel();
            this.adressField = new System.Windows.Forms.Label();
            this.guna2CustomGradientPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // guna2CustomGradientPanel1
            // 
            this.guna2CustomGradientPanel1.BackColor = System.Drawing.Color.Transparent;
            this.guna2CustomGradientPanel1.BorderRadius = 7;
            this.guna2CustomGradientPanel1.Controls.Add(this.kryptonLabel4);
            this.guna2CustomGradientPanel1.Controls.Add(this.kryptonLabel3);
            this.guna2CustomGradientPanel1.Controls.Add(this.endField);
            this.guna2CustomGradientPanel1.Controls.Add(this.editBtn);
            this.guna2CustomGradientPanel1.Controls.Add(this.startField);
            this.guna2CustomGradientPanel1.Controls.Add(this.adressField);
            this.guna2CustomGradientPanel1.Location = new System.Drawing.Point(4, 4);
            this.guna2CustomGradientPanel1.Name = "guna2CustomGradientPanel1";
            this.guna2CustomGradientPanel1.ShadowDecoration.Color = System.Drawing.Color.Gray;
            this.guna2CustomGradientPanel1.ShadowDecoration.Depth = 15;
            this.guna2CustomGradientPanel1.ShadowDecoration.Enabled = true;
            this.guna2CustomGradientPanel1.ShadowDecoration.Parent = this.guna2CustomGradientPanel1;
            this.guna2CustomGradientPanel1.Size = new System.Drawing.Size(202, 130);
            this.guna2CustomGradientPanel1.TabIndex = 2;
            // 
            // kryptonLabel4
            // 
            this.kryptonLabel4.Location = new System.Drawing.Point(11, 64);
            this.kryptonLabel4.Name = "kryptonLabel4";
            this.kryptonLabel4.Size = new System.Drawing.Size(24, 20);
            this.kryptonLabel4.TabIndex = 7;
            this.kryptonLabel4.Values.Text = "To";
            this.kryptonLabel4.Paint += new System.Windows.Forms.PaintEventHandler(this.kryptonLabel4_Paint);
            // 
            // kryptonLabel3
            // 
            this.kryptonLabel3.Location = new System.Drawing.Point(10, 40);
            this.kryptonLabel3.Name = "kryptonLabel3";
            this.kryptonLabel3.Size = new System.Drawing.Size(39, 20);
            this.kryptonLabel3.TabIndex = 6;
            this.kryptonLabel3.Values.Text = "From";
            // 
            // endField
            // 
            this.endField.LabelStyle = Krypton.Toolkit.LabelStyle.BoldPanel;
            this.endField.Location = new System.Drawing.Point(45, 64);
            this.endField.Name = "endField";
            this.endField.Size = new System.Drawing.Size(78, 20);
            this.endField.TabIndex = 5;
            this.endField.Values.Text = "12/10/2021";
            // 
            // editBtn
            // 
            this.editBtn.BorderRadius = 5;
            this.editBtn.CheckedState.Parent = this.editBtn;
            this.editBtn.CustomImages.Parent = this.editBtn;
            this.editBtn.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.editBtn.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.editBtn.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.editBtn.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.editBtn.DisabledState.Parent = this.editBtn;
            this.editBtn.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(235)))), ((int)(((byte)(235)))));
            this.editBtn.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.editBtn.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(60)))), ((int)(((byte)(60)))));
            this.editBtn.HoverState.Parent = this.editBtn;
            this.editBtn.Location = new System.Drawing.Point(112, 92);
            this.editBtn.Name = "editBtn";
            this.editBtn.ShadowDecoration.Parent = this.editBtn;
            this.editBtn.Size = new System.Drawing.Size(81, 29);
            this.editBtn.TabIndex = 4;
            this.editBtn.Text = "Edit";
            this.editBtn.Click += new System.EventHandler(this.editBtn_Click);
            // 
            // startField
            // 
            this.startField.LabelStyle = Krypton.Toolkit.LabelStyle.BoldPanel;
            this.startField.Location = new System.Drawing.Point(44, 40);
            this.startField.Name = "startField";
            this.startField.Size = new System.Drawing.Size(78, 20);
            this.startField.TabIndex = 3;
            this.startField.Values.Text = "12/10/2021";
            // 
            // adressField
            // 
            this.adressField.AutoSize = true;
            this.adressField.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Bold);
            this.adressField.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(68)))), ((int)(((byte)(68)))));
            this.adressField.Location = new System.Drawing.Point(7, 14);
            this.adressField.Name = "adressField";
            this.adressField.Size = new System.Drawing.Size(117, 16);
            this.adressField.TabIndex = 2;
            this.adressField.Text = "Agadir, El farah:";
            // 
            // EventCard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(250)))), ((int)(((byte)(250)))));
            this.Controls.Add(this.guna2CustomGradientPanel1);
            this.Name = "EventCard";
            this.Size = new System.Drawing.Size(210, 138);
            this.guna2CustomGradientPanel1.ResumeLayout(false);
            this.guna2CustomGradientPanel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI2.WinForms.Guna2CustomGradientPanel guna2CustomGradientPanel1;
        private Krypton.Toolkit.KryptonLabel endField;
        private Guna.UI2.WinForms.Guna2Button editBtn;
        private Krypton.Toolkit.KryptonLabel startField;
        private System.Windows.Forms.Label adressField;
        private Krypton.Toolkit.KryptonLabel kryptonLabel4;
        private Krypton.Toolkit.KryptonLabel kryptonLabel3;
    }
}
