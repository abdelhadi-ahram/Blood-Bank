using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace super_market
{
    public partial class Admin : Form
    {
        Guna.UI2.WinForms.Guna2Button selectedBtn;
        UserControl dashboard;
        UserControl employees;
        UserControl requests;

        private int id;
         
        public Admin(int id)
        {
            this.id = id;
            InitializeComponent();
            this.logoutPanel.Size = new System.Drawing.Size(0, 0);
            selectedBtn = this.dashboardBtn;
            this.dashboard = new Dashboard(this); 
            this.employees = new Employees(this);
            this.requests = new Request(this);
            this.setBody(this.dashboard);
        }

        public int getID()
        {
            return this.id;
        }

        void selectButton(Guna.UI2.WinForms.Guna2Button btn)
        {
            btn.BackColor = System.Drawing.Color.White;
            btn.BorderRadius = 5;
            btn.CustomBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(68)))), ((int)(((byte)(68)))));
            btn.CustomBorderThickness = new System.Windows.Forms.Padding(5, 0, 0, 0);
            btn.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            btn.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            btn.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            btn.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            btn.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(254)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            btn.Font = new System.Drawing.Font("Arial", 11F, System.Drawing.FontStyle.Bold);
            btn.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(68)))), ((int)(((byte)(68)))));

        }

        void unselectButton(Guna.UI2.WinForms.Guna2Button btn)
        {
            btn.BorderRadius = 5;
            btn.CustomBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            btn.DisabledState.BorderColor = System.Drawing.Color.White;
            btn.DisabledState.CustomBorderColor = System.Drawing.Color.White;
            btn.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            btn.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            btn.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            btn.Font = new System.Drawing.Font("Arial", 11F, System.Drawing.FontStyle.Bold);
            btn.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(65)))), ((int)(((byte)(85)))));
        }

        public void setBody(UserControl obj)
        {
            this.dataPanel.Controls.Clear();
            this.dataPanel.Controls.Add(obj);
        }

        private void employeesBtn_Click(object sender, EventArgs e)
        {
            if (this.employeesBtn != this.selectedBtn)
            {
                this.unselectButton(this.selectedBtn);
                this.selectedBtn = this.employeesBtn;
                this.selectButton(this.employeesBtn);
                this.setBody(this.employees);
            }
        }

        private void dashboardBtn_Click(object sender, EventArgs e)
        {
            this.unselectButton(this.selectedBtn);
            this.selectedBtn = this.dashboardBtn;
            this.selectButton(this.dashboardBtn);
            this.setBody(this.dashboard);
          
            this.setBody(this.dashboard);
            
        }

        private void requestsBtn_Click(object sender, EventArgs e)
        {
            if (this.requestsBtn != this.selectedBtn) { 
                this.unselectButton(this.selectedBtn);
                this.selectedBtn = this.requestsBtn;
                this.selectButton(this.requestsBtn);
                this.setBody(this.requests);
            }
        }

        public void HideLogoutPanel(object sender, EventArgs e)
        {
            this.logoutPanel.Size = new System.Drawing.Size(0, 0);
            this.timer.Stop();
        }
        private void stockBtn_Click(object sender, EventArgs e)
        {
            this.logoutPanel.Size = new System.Drawing.Size(170, 125);
            this.timer = new System.Windows.Forms.Timer();
            this.timer.Interval = 3000;
            this.timer.Enabled = true;
            this.timer.Tick += new System.EventHandler(this.HideLogoutPanel);
        }


        public void hideMessage()
        {
            this.timer = new System.Windows.Forms.Timer();
            this.timer.Interval = 50;
            this.timer.Enabled = true;
            this.timer.Tick += new System.EventHandler(this.animateOut);
        }

        private void animateOut(object sender, EventArgs e)
        {
            if (this.messageLayout.Location.Y > -75)
            {
                this.messageLayout.Location = new System.Drawing.Point(0, this.messageLayout.Location.Y - 13);
                this.dataPanel.Location = new System.Drawing.Point(0, this.dataPanel.Location.Y - 13);
            }
            else
            {
                this.timer.Stop();
                this.messageLayout.Size = new System.Drawing.Size(0, 0);
            }
        }

        public void hideMessageTimer(object sender, EventArgs e)
        {
            this.timer.Stop();
            hideMessage();
        }
        private void animateIn(object sender, EventArgs e)
        {
            if (this.messageLayout.Location.Y < 0)
            {
                this.messageLayout.Location = new System.Drawing.Point(0, this.messageLayout.Location.Y + 13);
                this.dataPanel.Location = new System.Drawing.Point(0, this.dataPanel.Location.Y + 13);
            }
            else
            {
                this.timer.Stop();
                this.timer = new System.Windows.Forms.Timer();
                this.timer.Interval = 3000;
                this.timer.Enabled = true;
                this.timer.Tick += new System.EventHandler(this.hideMessageTimer);
            }
                
        }

        System.Windows.Forms.Timer timer;

        public void showMessage(String str, String type)
        {
            this.timer = new System.Windows.Forms.Timer();
            this.timer.Interval = 50;
            this.timer.Enabled = true;
            this.timer.Tick += new System.EventHandler(this.animateIn);

            Color backgroundColor = new Color();
            Color textColor = new Color() ;

            if(type == "success")
            {
                backgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(167)))), ((int)(((byte)(243)))), ((int)(((byte)(208)))));
                textColor = System.Drawing.Color.FromArgb(((int)(((byte)(4)))), ((int)(((byte)(120)))), ((int)(((byte)(87)))));
            } else if(type == "error"){
                textColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(68)))), ((int)(((byte)(68)))));
                backgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(254)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            }else
            {
                textColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(158)))), ((int)(((byte)(11)))));
                backgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(254)))), ((int)(((byte)(243)))), ((int)(((byte)(199)))));
            }

            this.messageLayout.Location = new System.Drawing.Point(0, -75);
            this.messageLayout.Size = new System.Drawing.Size(750, 75);

            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Admin));
            Guna.UI2.WinForms.Guna2GradientPanel custumizedMessagePanel = new Guna.UI2.WinForms.Guna2GradientPanel();
            System.Windows.Forms.PictureBox pictureBox2 = new System.Windows.Forms.PictureBox();
            System.Windows.Forms.Label textMessage = new System.Windows.Forms.Label();

            //
            pictureBox2.BackColor = backgroundColor;
            pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            pictureBox2.Location = new System.Drawing.Point(17, 16);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new System.Drawing.Size(22, 22);
            pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            pictureBox2.TabIndex = 3;
            pictureBox2.TabStop = false;

            //
            textMessage.AutoSize = true;
            textMessage.BackColor = backgroundColor;
            textMessage.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            textMessage.ForeColor = textColor;
            textMessage.Location = new System.Drawing.Point(49, 16);
            textMessage.Name = "textMessage";
            textMessage.Size = new System.Drawing.Size(242, 18);
            textMessage.TabIndex = 0;
            textMessage.Text = str;

            //
            ((System.ComponentModel.ISupportInitialize)(pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(pictureBox2)).EndInit();
            this.messageLayout.Controls.Clear();

            //panel
            custumizedMessagePanel.BorderRadius = 7;
            custumizedMessagePanel.BorderThickness = 1;
            custumizedMessagePanel.Controls.Add(pictureBox2);
            custumizedMessagePanel.Controls.Add(textMessage);
            custumizedMessagePanel.CustomBorderColor = textColor;
            custumizedMessagePanel.CustomBorderThickness = new System.Windows.Forms.Padding(7, 1, 1, 1);
            custumizedMessagePanel.FillColor = backgroundColor;
            custumizedMessagePanel.FillColor2 = backgroundColor;
            custumizedMessagePanel.Location = new System.Drawing.Point(9, 12);
            custumizedMessagePanel.Name = "custumizedMessagePanel";
            custumizedMessagePanel.ShadowDecoration.Parent = this.custumizedMessagePanel;
            custumizedMessagePanel.Size = new System.Drawing.Size(731, 51);
            custumizedMessagePanel.TabIndex = 0;

            this.messageLayout.Controls.Add(custumizedMessagePanel);
            this.messageLayout.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(250)))), ((int)(((byte)(250)))));
        }

        private void HomeLayout_Load(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            this.Opacity = .90;
            Exit obj = new Exit(this);
            obj.Show();
        }

        private void dataPanel_Paint(object sender, PaintEventArgs e)
        {

        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            new LoginForm().Show();
        }
    }
}
