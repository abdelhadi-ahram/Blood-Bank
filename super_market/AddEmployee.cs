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
    public partial class AddEmployee : UserControl
    {
        Employees parent;
        SqlConnection connection = new SqlConnection(@"Data Source=.;Initial Catalog=DB_Blood_Bank;Integrated Security=True");

        public AddEmployee(Employees parent)
        {
            InitializeComponent();
            this.parent = parent;
        }

        private void UserControl1_Load(object sender, EventArgs e)
        {

        }

        public bool isSafe()
        {
            if (fullNameField.Text != "" && cinField.Text != "" && phoneField.Text != "" && adressField.Text !="" && passwordField.Text.Length >= 4 && employeeTypeField.Text != "")
                return true;
            return false;
        }

        private void loginBtn_Click(object sender, EventArgs e)
        {
            if (isSafe())
            {
                try
                {
                    connection.Open();
                    String query = "exec add_employee '" + fullNameField.Text + "', '" + cinField.Text + "', '" +
                        phoneField.Text + "', '" + adressField.Text + "', '" + passwordField.Text + "', '" +
                        employeeTypeField.Text + "'";

                    SqlCommand cmd = new SqlCommand(query, connection);
                    cmd.ExecuteNonQuery();

                    this.parent.showEmployees();
                    this.parent.showMessage("An employee has been added successfully", "success");
                } catch(Exception exp)
                {
                    this.parent.showMessage(exp.Message, "error");
                } finally
                {
                    connection.Close();
                }
               
            }
            this.parent.hideRightPanel();
            this.parent.clearRightPanel();
        }

        private void employeeTypeField_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void passwordField_TextChanged(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void adressField_TextChanged(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void phoneField_TextChanged(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void cinField_TextChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void fullNameField_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void closeBtn_Click(object sender, EventArgs e)
        {
            this.parent.hideRightPanel();
        }
    }
}
