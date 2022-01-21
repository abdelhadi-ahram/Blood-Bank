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
    public partial class EventCard : UserControl
    {
        Admin parent;
        int id;
        public EventCard(String id, String adress, String startDate, String endDate, Admin parent)
        {
            InitializeComponent();

            this.id = int.Parse(id);
            this.adressField.Text = adress;
            this.startField.Text = startDate;
            this.endField.Text = endDate;
            this.parent = parent;
        }


        public void setLocation(int x, int y)
        {
            this.Location = new Point(x, y);
        }
        private void kryptonLabel4_Paint(object sender, PaintEventArgs e)
        {

        }

        private void editBtn_Click(object sender, EventArgs e)
        {
            this.parent.setBody(new AddEvent(this.parent, this.id));
        }
    }
}
