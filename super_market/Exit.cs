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
    public partial class Exit : Form
    {
        Form obj;
        public Exit(Form obj)
        {
            InitializeComponent();
            this.obj = obj;
        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {
            System.Windows.Forms.Application.Exit();
        }

        private void guna2Button2_Click(object sender, EventArgs e)
        {
            this.obj.Opacity = 1;
            this.Hide();
        }
    }
}
