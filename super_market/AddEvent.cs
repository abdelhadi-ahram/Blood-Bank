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
    public partial class AddEvent : UserControl
    {
        SqlConnection connection = new SqlConnection(@"Data Source=.;Initial Catalog=DB_Blood_Bank;Integrated Security=True");
        List<int> doctorsID = new List<int>();
        List<int> nursesID = new List<int>();
        Admin parent;

        int id;

        bool update = false;

        public AddEvent(Admin parent)
        {
            InitializeComponent();
            this.parent = parent;
            showDoctors();
            showNurses();
            this.update = false;
        }

        public AddEvent(Admin parent, int id)
        {
            InitializeComponent();
            this.parent = parent;
            this.id = id;
            fillDoctorsAndNurses();
            showDoctors(id);
            showNurses(id);
            fillFields(id);
            this.update = true;
        }

        public void fillFields(int id)
        {
            try
            {
                connection.Open();

                String query = "select adress, startDate, endDate from Event where eventID = " + id;

                SqlCommand cmd = new SqlCommand(query, connection);
                SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                DataSet ds = new DataSet();
                adapter.Fill(ds);
                connection.Close();
                String adress = ds.Tables[0].Rows[0]["adress"].ToString();
                DateTime startDate = (DateTime)ds.Tables[0].Rows[0]["startDate"];
                DateTime endDate = (DateTime)ds.Tables[0].Rows[0]["endDate"];
                this.adressField.Text = adress;
                this.startDateField.Value = startDate;
                this.endDateField.Value = endDate;
                
            }
            catch (Exception exp)
            {
                MessageBox.Show(exp.Message);
            }
            finally
            {
                connection.Close();
            }
        }

        public void fillDoctorsAndNurses ()
        {
            try
            {
                connection.Open();

                String query = "select doctorID from DoctorsInEvent where eventID = " + this.id + ";";
                SqlCommand cmd = new SqlCommand(query, connection);
                SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                DataSet ds = new DataSet();
                adapter.Fill(ds);
                connection.Close();

                for (int i = 0; i < ds.Tables[0].Rows.Count; i++)
                {
                    String doctorID = ds.Tables[0].Rows[i]["doctorID"].ToString();
                    this.doctorsID.Add(int.Parse(doctorID));
                }

                connection.Open();

                query = "select nurseID from NurseInEvent where eventID = " + this.id + ";";
                cmd = new SqlCommand(query, connection);
                adapter = new SqlDataAdapter(cmd);
                ds = new DataSet();
                adapter.Fill(ds);
                connection.Close();

                for (int i = 0; i < ds.Tables[0].Rows.Count; i++)
                {
                    String nurseID = ds.Tables[0].Rows[i]["nurseID"].ToString();
                    this.nursesID.Add(int.Parse(nurseID));
                }
            }
            catch (Exception exp)
            {
                MessageBox.Show(exp.Message);
            }
            finally
            {
                connection.Close();
            }
        }

        public void showDoctors()
        {
            try
            {
                connection.Open();

                String query = "select employeeID, fullName, CIN, phone from dbo.getEmployee() where employee_type = 'Doctor'";
                SqlCommand cmd = new SqlCommand(query, connection);
                SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                DataSet ds = new DataSet();
                adapter.Fill(ds);
                connection.Close();

                for (int i = 0; i < ds.Tables[0].Rows.Count; i++)
                {
                    String fullName = ds.Tables[0].Rows[i]["fullName"].ToString();
                    String cin = ds.Tables[0].Rows[i]["CIN"].ToString();
                    String phone = ds.Tables[0].Rows[i]["phone"].ToString();
                    String employeeID = ds.Tables[0].Rows[i]["employeeID"].ToString();
                    EmployeesArray ne = new EmployeesArray(employeeID, fullName, cin, phone, doctorsID);
                    ne.setLocation(0, i * 40 + 1);
                    if (i % 2 == 0) ne.setPair();
                    this.DoctorsGrid.Controls.Add(ne);
                }
            } catch(Exception exp)
            {
                MessageBox.Show(exp.Message);
            }finally
            {
                connection.Close();
            }
        }


        public void showDoctors(int id)
        {
            try
            {
                connection.Open();

                String query = "select employeeID, fullName, CIN, phone from dbo.getEmployee() where employee_type = 'Doctor'";
                SqlCommand cmd = new SqlCommand(query, connection);
                SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                DataSet ds = new DataSet();
                adapter.Fill(ds);
                connection.Close();

                for (int i = 0; i < ds.Tables[0].Rows.Count; i++)
                {
                    String fullName = ds.Tables[0].Rows[i]["fullName"].ToString();
                    String cin = ds.Tables[0].Rows[i]["CIN"].ToString();
                    String phone = ds.Tables[0].Rows[i]["phone"].ToString();
                    String employeeID = ds.Tables[0].Rows[i]["employeeID"].ToString();
                    EmployeesArray ne = new EmployeesArray(employeeID, fullName, cin, phone, doctorsID);
                    ne.setLocation(0, i * 40 + 1);
                    //ne.setCheck();
                    if (this.doctorsID.Contains(int.Parse(employeeID)) )
                    {
                        ne.setCheck();
                    }
                    if (i % 2 == 0) ne.setPair();
                    this.DoctorsGrid.Controls.Add(ne);
                }
            }
            catch (Exception exp)
            {
                MessageBox.Show(exp.Message);
            }
            finally
            {
                connection.Close();
            }
        }


        public void showNurses()
        {
            try
            {
                connection.Open();

                String query = "select employeeID, fullName, CIN, phone from dbo.getEmployee() where employee_type = 'Nurse'";
                SqlCommand cmd = new SqlCommand(query, connection);
                SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                DataSet ds = new DataSet();
                adapter.Fill(ds);
                connection.Close();

                for (int i = 0; i < ds.Tables[0].Rows.Count; i++)
                {
                    String fullName = ds.Tables[0].Rows[i]["fullName"].ToString();
                    String cin = ds.Tables[0].Rows[i]["CIN"].ToString();
                    String phone = ds.Tables[0].Rows[i]["phone"].ToString();
                    String employeeID = ds.Tables[0].Rows[i]["employeeID"].ToString();
                    EmployeesArray ne = new EmployeesArray(employeeID, fullName, cin, phone, nursesID);
                    ne.setLocation(0, i * 40 + 1);
                    if (i % 2 == 0) ne.setPair();
                    this.NurseGrid.Controls.Add(ne);
                }
            }
            catch (Exception exp)
            {
                MessageBox.Show(exp.Message);
            }
            finally
            {
                connection.Close();
            }
        }


        public void showNurses(int id)
        {
            try
            {
                connection.Open();

                String query = "select employeeID, fullName, CIN, phone from dbo.getEmployee() where employee_type = 'Nurse'";
                SqlCommand cmd = new SqlCommand(query, connection);
                SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                DataSet ds = new DataSet();
                adapter.Fill(ds);
                connection.Close();

                for (int i = 0; i < ds.Tables[0].Rows.Count; i++)
                {
                    String fullName = ds.Tables[0].Rows[i]["fullName"].ToString();
                    String cin = ds.Tables[0].Rows[i]["CIN"].ToString();
                    String phone = ds.Tables[0].Rows[i]["phone"].ToString();
                    String employeeID = ds.Tables[0].Rows[i]["employeeID"].ToString();
                    EmployeesArray ne = new EmployeesArray(employeeID, fullName, cin, phone, nursesID);
                    ne.setLocation(0, i * 40 + 1);
                    if (this.nursesID.Contains(int.Parse(employeeID)))
                    {
                        ne.setCheck();
                    }
                    if (i % 2 == 0) ne.setPair();
                    this.NurseGrid.Controls.Add(ne);
                }
            }
            catch (Exception exp)
            {
                MessageBox.Show(exp.Message);
            }
            finally
            {
                connection.Close();
            }
        }

        /* public bool isSafe()
         {
             if(this.adressField.Text != "" && DateTime.Compare(DateTime.Now, this.startDateField.Value.Date) < 0 && DateTime.Compare(DateTime.Now, this.endDateField.Value.Date) < 0)
             {
                 return true;
             }
             return false;
         }*/

        private void addEventBtn_Click(object sender, EventArgs e)
        {
            if(this.adressField.Text == "")
            {
                this.parent.showMessage("The field 'adress' must not be empty", "error");
            }
            else if(this.doctorsID.Count == 0 && this.nursesID.Count == 0)
            {
                this.parent.showMessage("You must select at least one doctor or a nurse", "error");
            } /*else if(
                DateTime.Compare(DateTime.Now, this.endDateField.Value.Date) >= 0 ||
                DateTime.Compare(this.startDateField.Value.Date, this.endDateField.Value.Date) > 0)
            {
                this.parent.showMessage("You must select a valid date", "error");
            }*/

            else
            {
                if (update)
                {

                }
                else
                {

                    this.startDateField.CustomFormat = "dd-MM-yyyy";
                    this.startDateField.Format = DateTimePickerFormat.Custom;
                    this.endDateField.CustomFormat = "dd-MM-yyyy";
                    this.endDateField.Format = DateTimePickerFormat.Custom;
                    try
                    {
                        connection.Open();
                        SqlCommand cmd = new SqlCommand("add_event", connection);
                        cmd.CommandType = CommandType.StoredProcedure;
                        cmd.Parameters.AddWithValue("adress", this.adressField.Text);
                        cmd.Parameters.AddWithValue("startDate", this.startDateField.Text);
                        cmd.Parameters.AddWithValue("endDate", this.endDateField.Text);

                        var returnParameter = cmd.Parameters.Add("@id", SqlDbType.Int);
                        returnParameter.Direction = ParameterDirection.ReturnValue;

                        cmd.ExecuteNonQuery();
                        var result = returnParameter.Value;


                        for (int i = 0; i < this.doctorsID.Count; i++)
                        {
                            String str = "insert into doctorsInEvent values(" + result + ", " + this.doctorsID[i] + ");";
                            SqlCommand cmd2 = new SqlCommand(str, connection);
                            cmd2.ExecuteNonQuery();
                        }

                        for (int i = 0; i < this.nursesID.Count; i++)
                        {
                            String str = "insert into nurseInEvent values(" + result + ", " + this.nursesID[i] + ");";
                            SqlCommand cmd2 = new SqlCommand(str, connection);
                            cmd2.ExecuteNonQuery();
                        }

                        this.parent.showMessage("A new event has been added successfully N°" + result, "success");
                        this.parent.setBody(new Dashboard(this.parent));
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
            }
        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {
            this.parent.setBody(new Dashboard(this.parent));
        }
    }
}
