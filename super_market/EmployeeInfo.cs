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
    public partial class EmployeeInfo : UserControl
    {
        int id;
        Employees parent;
        SqlConnection connection = new SqlConnection(@"Data Source=.;Initial Catalog=DB_Blood_Bank;Integrated Security=True");

        public EmployeeInfo(Employees obj, int id)
        {
            InitializeComponent();
            this.id = id;
            this.parent = obj;
            this.headerLabel.Text = "Employee N°" + id + " :";
            fillFields();
        }

        public void fillFields()
        {
            try
            {
                connection.Open();
                String query = "select * from dbo.getEmployee() where employeeID = " + id + ";";
                SqlCommand cmd = new SqlCommand(query, connection);
                SqlDataAdapter qdqpter = new SqlDataAdapter(cmd);
                DataSet ds = new DataSet();
                qdqpter.Fill(ds);

                this.fullNameField.Text = ds.Tables[0].Rows[0]["fullName"].ToString();
                this.cinField.Text = ds.Tables[0].Rows[0]["CIN"].ToString();
                this.phoneField.Text = ds.Tables[0].Rows[0]["phone"].ToString();
                this.adressField.Text = ds.Tables[0].Rows[0]["adress"].ToString();
                this.passwordField.Text = ds.Tables[0].Rows[0]["password"].ToString();
                this.employeeTypeField.Text = ds.Tables[0].Rows[0]["employee_Type"].ToString();

            } catch(Exception exp)
            {
                this.parent.showMessage(exp.Message, "error");
            }finally
            {
                connection.Close();
            }
           
        }
        private void addEmployeeBtn_Click(object sender, EventArgs e)
        {
            try
            {
                connection.Open();

                String query = "update Employee set " +
                    "fullName = '"+ this.fullNameField.Text + "',"+
                    "CIN = '" + this.cinField.Text + "'," +
                    "adress = '" + this.adressField.Text + "'," +
                    "phone = '" + this.phoneField.Text + "'," +
                    "[password] = '" + this.passwordField.Text + "'," +
                    "employee_type = '" + this.employeeTypeField.Text + "' " +
                    " where employeeID = " + this.id + ";";

                SqlCommand cmd = new SqlCommand(query, connection);
                cmd.ExecuteNonQuery();
                this.parent.hideRightPanel();
                this.parent.showMessage("The emplyee N°" + this.id + " has been updated!", "success");
                this.parent.showEmployees();
            }
            catch (Exception exp)
            {
                this.parent.showMessage(exp.Message, "error");
            }
            finally
            {
                connection.Close();
            }
        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {
            try
            {
                connection.Open();

                String query = "delete from Employee where employeeID = " + this.id + ";";

                SqlCommand cmd = new SqlCommand(query, connection);
                cmd.ExecuteNonQuery();
                this.parent.hideRightPanel();
                this.parent.showMessage("The emplyee N°" + this.id + " has been deleted successfully!", "normal");
                this.parent.showEmployees();
            }
            catch (Exception exp)
            {
                this.parent.showMessage(exp.Message, "error");
            }
            finally
            {
                connection.Close();
            }
        }

        private void closeBtn_Click(object sender, EventArgs e)
        {
            this.parent.hideRightPanel();
        }
    }
}
