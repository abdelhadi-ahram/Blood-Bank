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
    public partial class Employees : SplitPanel
    {
        SqlConnection connection = new SqlConnection(@"Data Source=.;Initial Catalog=DB_Blood_Bank;Integrated Security=True");

        Admin parent;
        public Employees(Admin obj)
        {
            InitializeComponent();
            this.addToLeftPanel(this.panel1);
            this.parent = obj;
            showEmployees();
        }


        public void showEmployees()
        {
            try
            {
                connection.Open();
                SqlCommand cmd = new SqlCommand("select * from dbo.getEmployee();", connection);
                SqlDataAdapter sql = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                sql.Fill(dt);
                this.employeesDGV.DataSource = dt;
            } catch(Exception exp)
            {
                parent.showMessage(exp.Message, "error");
            } finally
            {
                connection.Close();
            }
        }

        public void showMessage(String str, String type)
        {
            this.parent.showMessage(str, type);
        }


        private void UserControl1_Load(object sender, EventArgs e)
        {

        }

        private void addEmployeeBtn_Click(object sender, EventArgs e)
        {
            this.addToRightPanel(new AddEmployee(this));
            this.showRightPanel();
        }

        private void employeesDGV_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void employeesDGV_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {
            EmployeeInfo emp = new EmployeeInfo(this, int.Parse(this.employeesDGV.SelectedRows[0].Cells["employeeID"].Value.ToString()));
            this.addToRightPanel(emp);
            this.showRightPanel();
        }

        private void guna2TextBox1_TextChanged(object sender, EventArgs e)
        {
            try
            {
                connection.Open();
                SqlCommand cmd = new SqlCommand("select * from search('" + this.guna2TextBox1.Text +"');", connection);
                SqlDataAdapter sql = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                sql.Fill(dt);
                this.employeesDGV.DataSource = dt;
            }
            catch (Exception exp)
            {
                parent.showMessage(exp.Message, "error");
            }
            finally
            {
                connection.Close();
            }
        }

        private void guna2ComboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(this.guna2ComboBox1.Text != "All")
            {
                try
                {
                    connection.Open();
                    SqlCommand cmd = new SqlCommand("select * from filterBy('" + this.guna2ComboBox1.Text + "');", connection);
                    SqlDataAdapter sql = new SqlDataAdapter(cmd);
                    DataTable dt = new DataTable();
                    sql.Fill(dt);
                    this.employeesDGV.DataSource = dt;
                }
                catch (Exception exp)
                {
                    parent.showMessage(exp.Message, "error");
                }
                finally
                {
                    connection.Close();
                }
            } else
            {
                this.showEmployees();
            }
        }
    }
}
