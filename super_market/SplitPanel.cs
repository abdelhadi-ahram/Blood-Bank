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
    public partial class SplitPanel : UserControl
    {
        public SplitPanel()
        {
            InitializeComponent();
        }

        public void addToRightPanel(UserControl obj)
        {
            this.clearRightPanel();
            this.rightPanel.Controls.Add(obj);
        }


        public void clearRightPanel()
        {
            this.rightPanel.Controls.Clear();
        }

        public void addToLeftPanel(Panel obj)
        {
            clearLeftPanel();
            this.leftPanel.Controls.Add(obj);
        }

        public void clearLeftPanel()
        {
            this.leftPanel.Controls.Clear();
        }

        public void hideRightPanel()
        {
            Animation an = new Animation(this.rightPanel, this.leftPanel);
            an.endAnimationDashboard();
        }

        public void showRightPanel()
        {
            Animation an = new Animation(this.rightPanel, this.leftPanel);
            an.startAnimationDashboard();
        }

        public bool isShown()
        {
            return this.rightPanel.Size.Width > 0;
        }
        private void guna2Button1_Click(object sender, EventArgs e)
        {
            if (isShown())
                hideRightPanel();
            else
                showRightPanel();
        }
    }
}
