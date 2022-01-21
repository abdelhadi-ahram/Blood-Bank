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
    public partial class Request : UserControl
    {
        Admin parent;
        SqlConnection connection = new SqlConnection(@"Data Source=.;Initial Catalog=DB_Blood_Bank;Integrated Security=True");

        public Request(Admin parent)
        {
            InitializeComponent();
            this.parent = parent;
            clear();
            getQuantity();
        }


        public void getQuantity()
        {
            try
            {
                connection.Open();
                SqlCommand cmd = new SqlCommand("select * from dbo.getBloodQuantity();", connection);
                SqlDataAdapter adapter = new SqlDataAdapter(cmd);

                DataSet ds = new DataSet();
                adapter.Fill(ds);

                this.aplusQuantity.Text = ds.Tables[0].Rows[0]["quantity"].ToString();
                this.aminusQuantity.Text = ds.Tables[0].Rows[1]["quantity"].ToString();
                this.oplusQuantity.Text = ds.Tables[0].Rows[2]["quantity"].ToString();
                this.ominusQuantity.Text = ds.Tables[0].Rows[3]["quantity"].ToString();
                this.bplusQuantity.Text = ds.Tables[0].Rows[4]["quantity"].ToString();
                this.bminusQuantity.Text = ds.Tables[0].Rows[5]["quantity"].ToString();
                this.abplusQuantity.Text = ds.Tables[0].Rows[6]["quantity"].ToString();
                this.abminusQuantity.Text = ds.Tables[0].Rows[7]["quantity"].ToString();
            }
            catch(Exception exp)
            {
                this.parent.showMessage("An error has been occured! Couldn't fetch the quantity!", "error");
            }finally
            {
                connection.Close();
            }
        }
        public void clear()
        {
            Guna.UI2.WinForms.Guna2TextBox[] array = new Guna.UI2.WinForms.Guna2TextBox[8] {
                this.aplus,
                this.aminus,
                this.ominus,
                this.oplus,
                this.abminus,
                this.abplus,
                this.bminus,
                this.bplus,
            };

            foreach (Guna.UI2.WinForms.Guna2TextBox box in array)
            {
                box.Text = "0";
            }
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void guna2CustomGradientPanel3_Paint(object sender, PaintEventArgs e)
        {

        }

        private void loginBtn_Click(object sender, EventArgs e)
        {
            try
            {
                connection.Open();
                SqlCommand cmd = new SqlCommand("add_hospital", connection);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("name", this.hospitalName.Text);
                cmd.Parameters.AddWithValue("adress", this.hospitalAdress.Text);

                var returnParameter = cmd.Parameters.Add("@id", SqlDbType.Int);
                returnParameter.Direction = ParameterDirection.ReturnValue;

                cmd.ExecuteNonQuery();
                var hospitalID = returnParameter.Value;

                cmd = new SqlCommand("create_order", connection);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("hospitalID", hospitalID);

                returnParameter = cmd.Parameters.Add("@id", SqlDbType.Int);
                returnParameter.Direction = ParameterDirection.ReturnValue;

                cmd.ExecuteNonQuery();
                int orderID = (int)returnParameter.Value;

                if (int.Parse(this.aplus.Text) > 0)
                {
                    cmd = new SqlCommand("exec create_order_details " + orderID + ", " + 1 + ", " + this.aplus.Text + ";", connection);
                    cmd.ExecuteNonQuery();
                }
                if (int.Parse(this.aminus.Text) > 0)
                {
                    cmd = new SqlCommand("exec create_order_details " + orderID + ", " + 2 + ", " + this.aminus.Text + ";", connection);
                    cmd.ExecuteNonQuery();
                }
                if (int.Parse(this.oplus.Text) > 0)
                {
                    cmd = new SqlCommand("exec create_order_details " + orderID + ", " + 3 + ", " + this.oplus.Text + ";", connection);
                    cmd.ExecuteNonQuery();
                }
                if (int.Parse(this.ominus.Text) > 0)
                {
                    cmd = new SqlCommand("exec create_order_details " + orderID + ", " + 4 + ", " + this.ominus.Text + ";", connection);
                    cmd.ExecuteNonQuery();
                }
                if (int.Parse(this.bplus.Text) > 0)
                {
                    cmd = new SqlCommand("exec create_order_details " + orderID + ", " + 5 + ", " + this.bplus.Text + ";", connection);
                    cmd.ExecuteNonQuery();
                }
                if (int.Parse(this.bminus.Text) > 0)
                {
                    cmd = new SqlCommand("exec create_order_details " + orderID + ", " + 6 + ", " + this.bminus.Text + ";", connection);
                    cmd.ExecuteNonQuery();
                }
                if (int.Parse(this.abplus.Text) > 0)
                {
                    cmd = new SqlCommand("exec create_order_details " + orderID + ", " + 7 + ", " + this.abplus.Text + ";", connection);
                    cmd.ExecuteNonQuery();
                }
                if (int.Parse(this.abminus.Text) > 0)
                {
                    cmd = new SqlCommand("exec create_order_details " + orderID + ", " + 8 + ", " + this.abminus.Text + ";", connection);
                    cmd.ExecuteNonQuery();
                }

                this.parent.setBody(new RequestDetails(this, this.parent, orderID));
            } catch(Exception exp)
            {
                this.parent.showMessage(exp.Message, "error");
            } finally
            {
                connection.Close();
            }
        }
    }
}
