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
    public partial class EmployeesArray : UserControl
    {
        int id;
        bool pair;
        List<int> employees = new List<int>();
        
        public EmployeesArray(String id, String name, String cin, String phone, List<int> employees)
        {
            InitializeComponent();
            this.id = int.Parse(id);
            this.fullName.Text = name;
            this.cin.Text = cin;
            this.phone.Text = phone;
            this.employees = employees;
        }

        public bool isChecked()
        {
            return this.CheckEmployee.Checked;
        }

        public int getId()
        {
            return this.id;
        }

        public void setCheck()
        {
            this.CheckEmployee.Checked = true;
            employees.Add(this.id);
            this.panel1.BackColor = Color.FromArgb(((int)(((byte)(254)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
        }

        public void setPair()
        {
            this.pair = true;
            this.panel1.BackColor = Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(250)))), ((int)(((byte)(250)))));
        }

        public void setLocation(int x, int y)
        {
            this.Location = new System.Drawing.Point(x,y);
        }

        private void guna2CheckBox1_CheckedChanged(object sender, EventArgs e)
        {
           
               

        }

        private void CheckEmployee_CheckedChanged(object sender, EventArgs e)
        {
            if (this.isChecked())
            {
                employees.Add(this.id);
                this.panel1.BackColor = Color.FromArgb(((int)(((byte)(254)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));

            }
            else
            {
                employees.Remove(this.id);
                if (this.pair)
                    this.panel1.BackColor = Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(250)))), ((int)(((byte)(250)))));
                else
                    this.panel1.BackColor = Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            }
        }
    }
}
