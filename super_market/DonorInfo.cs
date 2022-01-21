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
    public partial class DonorInfo : UserControl
    {
        public DonorInfo(String cin, String phone, String birthDay, String type, String quantity)
        {
            InitializeComponent();
            this.cinField.Text = cin;
            this.phoneField.Text = phone;
            this.birthField.Text = birthDay;
            this.typeField.Text = type;
            this.quantityField.Text = quantity;
        }


        private void label4_Click(object sender, EventArgs e)
        {

        }

        public void setPair()
        {
            this.bodyPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(250)))), ((int)(((byte)(250)))));
        }
        private void guna2CustomGradientPanel3_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
