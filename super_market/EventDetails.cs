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
    public partial class EventDetails : UserControl
    {
        public EventDetails()
        {
            InitializeComponent();
        }

        private void guna2CustomGradientPanel2_Paint(object sender, PaintEventArgs e)
        {
            //System.Drawing.Graphics graphicsObj;

            Graphics pe = e.Graphics;
            Pen pen = new Pen(Color.Black,5);
            for(float i=0; i<2*Math.PI; i+=0.1f)
            {
                int x = (int) Math.Sin(i) * 90+60;
                int y = (int)Math.Cos(i) * 90+60;
                pe.DrawLine(pen, 90, 90, 90+ x, 90+y);
                
            }
            
        }
    }
}
