using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace super_market
{
    class Animation
    {
        System.Windows.Forms.Panel obj1, obj2;
        Timer timer;

        public Animation(System.Windows.Forms.Panel obj1, System.Windows.Forms.Panel obj2)
        {
            this.obj1 = obj1;
            this.obj2 = obj2; 
        }

        public void startAnimationDashboard()
        {
            obj1.Size = new System.Drawing.Size(270, 524);
            obj1.Location = new System.Drawing.Point(750, 0);

            timer = new Timer();
            timer.Interval = 10;
            timer.Enabled = true;
            timer.Tick += new System.EventHandler(this.animateDashboardIn);
        }

        public void animateDashboardIn(object sender, System.EventArgs e)
        {
            if (this.obj1.Location.X > 480)
            {
                obj1.Location = new System.Drawing.Point(obj1.Location.X - 10, 0);
                obj2.Size = new System.Drawing.Size(this.obj2.Size.Width - 10, 524);
            }
            else
            {
                obj1.Location = new System.Drawing.Point(480, 0);
                obj2.Size = new System.Drawing.Size(478, 524);
                this.timer.Stop();
            }
        }

        public void animateDashboardOut(object sender, System.EventArgs e)
        {
            if (this.obj1.Location.X <= 750)
            {
                obj1.Location = new System.Drawing.Point(this.obj1.Location.X + 20, 0);
                obj2.Size = new System.Drawing.Size(this.obj2.Size.Width + 20, 524);
            }
            else
            {
                obj1.Location = new System.Drawing.Point(750, 0);
                obj2.Size = new System.Drawing.Size(750, 524);
                obj1.Size = new System.Drawing.Size(0, 524);
                this.timer.Stop();
            }
        }

        public void endAnimationDashboard()
        {
            timer = null;
            timer = new Timer();
            timer.Interval = 10;
            timer.Enabled = true;
            timer.Tick += new System.EventHandler(this.animateDashboardOut);
        }

       
    }
}
