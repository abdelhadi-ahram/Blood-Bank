using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;


namespace super_market
{
    public partial class Dashboard : SplitPanel
    {
        SqlConnection connection = new SqlConnection(@"Data Source=.;Initial Catalog=DB_Blood_Bank;Integrated Security=True");
        private System.Windows.Forms.Panel product_details;
        Admin parent;

        public Dashboard(Admin parent)
        {
            InitializeComponent();
            this.parent = parent;
            this.addToLeftPanel(this.product_panel);
            showEvents();
            showStock();
            //this.eventCardLayout.Controls.Add(new EventDetails());
        }


        public void showStock()
        {
            try
            {
                connection.Open();
                SqlCommand cmd = new SqlCommand("select * from dbo.getBloodQuantity();", connection);
                SqlDataAdapter adapter = new SqlDataAdapter(cmd);

                DataSet ds = new DataSet();
                adapter.Fill(ds);

                this.aplusField.Text = ds.Tables[0].Rows[0]["quantity"].ToString();
                this.aminusField.Text = ds.Tables[0].Rows[1]["quantity"].ToString();
                this.oplusField.Text = ds.Tables[0].Rows[2]["quantity"].ToString();
                this.ominusField.Text = ds.Tables[0].Rows[3]["quantity"].ToString();
                this.bplusField.Text = ds.Tables[0].Rows[4]["quantity"].ToString();
                this.bminusField.Text = ds.Tables[0].Rows[5]["quantity"].ToString();
                this.abplusField.Text = ds.Tables[0].Rows[6]["quantity"].ToString();
                this.abminusField.Text = ds.Tables[0].Rows[7]["quantity"].ToString();
            }
            catch (Exception exp)
            {
                this.parent.showMessage("An error has been occured! Couldn't fetch the quantity!", "error");
            }
            finally
            {
                connection.Close();
            }
        }


        public void showEvents()
        {
            try
            {

                connection.Open();
                SqlCommand cmd = new SqlCommand("select * from dbo.getUpcomingEvents();", connection);
                SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                DataSet ds = new DataSet();
                adapter.Fill(ds);

                int tracker = 0;
                for(int i=0; i<ds.Tables[0].Rows.Count; i++)
                {
                    String eventId = ds.Tables[0].Rows[i]["eventID"].ToString();
                    String adress = ds.Tables[0].Rows[i]["adress"].ToString();
                    DateTime startDate = (DateTime)ds.Tables[0].Rows[i]["startDate"];
                    DateTime endDate = (DateTime)ds.Tables[0].Rows[i]["endDate"];

                    EventCard ec = new EventCard(eventId, adress, startDate.ToString("dd//MM/yyyy"), endDate.ToString("dd//MM/yyyy"), this.parent);
                    if(i%2 != 0)
                    {
                        ec.setLocation(ec.Size.Width + 10, tracker);
                        tracker += ec.Size.Height;
                    } else
                    {
                        int a = i == 0 ? i : i - 1;
                        ec.setLocation(0, tracker);
                    }
                   
                    this.eventCardLayout.Controls.Add(ec);
                }

            } catch(Exception exp)
            {
                this.parent.showMessage(exp.Message, "error");
            }
            finally
            {
                connection.Close();
            }
        }

        public void showMessage(String str, String type)
        {
            this.parent.showMessage(str, type);
        }
        private void newEventBtn_Click(object sender, EventArgs e)
        {
            this.parent.setBody(new AddEvent(this.parent));
        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {
        }

        private void guna2GradientCircleButton1_Click(object sender, EventArgs e)
        {

        }
    }
}
