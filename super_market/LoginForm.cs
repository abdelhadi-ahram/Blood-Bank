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
    public partial class LoginForm : Form
    {
        SqlConnection connection = new SqlConnection(@"Data Source=.;Initial Catalog=DB_Blood_Bank;Integrated Security=True");
        public LoginForm()
        {
            InitializeComponent();
            SetStyle(ControlStyles.SupportsTransparentBackColor, true);

            this.guna2CustomGradientPanel1.BackColor = Color.Transparent;
            this.TransparencyKey = this.pictureBox1.BackColor;
        }

        protected override void OnPaintBackground(PaintEventArgs e) { /* Ignore */ }


        public bool isSafe()
        {
            if ((this.cinField.Text != "" && this.passwordField.Text != "") && this.passwordField.Text.Length >= 4 && this.passwordField.Text.Length <= 25)
            {
                return true;
            }
            return false;
        } 

       /* public void hideMessage()
        {
            this.messageLayout.Size = new System.Drawing.Size(269, 0);
            this.fieldsLayout.Location = new System.Drawing.Point(34, 55);
        }*/

        public void showMessage(String str)
        {
            //this.messageText.Text = str;
            this.messageLayout.Size = new System.Drawing.Size(269, 41);
            this.fieldsLayout.Location = new System.Drawing.Point(34, 71);
        }

        private void loginBtn_Click(object sender, EventArgs e)
        {
            if (isSafe())
            {
                try
                {
                    connection.Open();
                    String query = "select * from dbo.connexion('" + this.cinField.Text + "', '" + this.passwordField.Text + "');";
                    SqlDataAdapter adapter = new SqlDataAdapter();
                    adapter.SelectCommand = new SqlCommand(query, this.connection);
                    connection.Close();

                    DataSet ds = new DataSet();
                    adapter.Fill(ds);

                    if (Convert.ToInt32(ds.Tables[0].Rows[0]["id"]) != -1)
                    {
                        if (ds.Tables[0].Rows[0]["employeeType"].ToString() == "Admin")
                        {
                            this.Hide();
                            new Admin(Convert.ToInt32(ds.Tables[0].Rows[0]["id"])).Show();
                        } else
                        {
                            this.Hide();
                            new Employee(Convert.ToInt32(ds.Tables[0].Rows[0]["id"])).Show();
                        }
                    }
                    else
                    {
                        showMessage("Your CIN or password are incorrect");
                    }
                }
                catch (Exception ex)
                {
                    showMessage("An error has been occured, pleaze try again!");
                }
            }
        }

        private void passwordShow_CheckedChanged(object sender, EventArgs e)
        {
            this.passwordField.UseSystemPasswordChar = !this.passwordShow.Checked;
        }
    }
}
