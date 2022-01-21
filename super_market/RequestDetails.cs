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
    public partial class RequestDetails : UserControl
    {
        SqlConnection connection = new SqlConnection(@"Data Source=.;Initial Catalog=DB_Blood_Bank;Integrated Security=True");
        Admin parent;
        Request pre;

        int id;
        String header = "", textBody = "", body = "";


        public RequestDetails(Request pre, Admin parent, int id)
        {
            InitializeComponent();
            this.parent = parent;
            this.id = id;
            this.pre = pre;
            launchWeb();
        }

        public void launchWeb()
        {
            

            try
            {
                connection.Open();
                SqlCommand cmd = new SqlCommand("select * from dbo.getOrder() where orderID = " + this.id + ";", connection);
                SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                DataSet ds = new DataSet();
                adapter.Fill(ds);

                DateTime date = (DateTime)ds.Tables[0].Rows[0]["orderDate"];
                this.header = "<div class='header'>Order N°:" + ds.Tables[0].Rows[0]["orderID"].ToString() + "</div>" +
                    "<div class='header'>Hospital: " + ds.Tables[0].Rows[0]["name"].ToString() + "</div>" +
                    "<div class='header'>adress: " + ds.Tables[0].Rows[0]["adress"].ToString() + "</div>" +
                    "<div class='header'>Date: " + date.ToString("dd/MM/yyyy") + "</div>";

                cmd = new SqlCommand("select * from dbo.getOrderDetails(" + this.id + ");", connection);
                adapter = new SqlDataAdapter(cmd);
                ds = new DataSet();
                adapter.Fill(ds);

                foreach(DataRow row in ds.Tables[0].Rows)
                {
                    this.body += "<tr>";
                    foreach ( object col in row.ItemArray)
                    {
                        this.body += "<td>" + col.ToString() + "</td>";
                    }
                    this.body += "</tr>";
                }

                cmd = new SqlCommand("select fullName from Employee where employeeId = " + 3 + ";", connection);
                adapter = new SqlDataAdapter(cmd) ;
                ds = new DataSet();
                adapter.Fill(ds);

                this.writer.Text = ds.Tables[0].Rows[0]["fullName"].ToString();

                String textBody_ = "   As -"+ this.writer.Text +"- The director of the Blood " +
                "bank situated in Agadir, We have delievered to the hospital mentioned above :";

                this.textBody = textBody_;
                this.textarea.Text = textBody_;

            } catch(Exception exp)
            {
                this.parent.showMessage(exp.Message, "error");
            }finally
            {
                connection.Close();
            }

            setHtml();
        }

        private void writer_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void refreshBtn_Click(object sender, EventArgs e)
        {
            setHtml();
        }

        private void resetBtn_Click(object sender, EventArgs e)
        {
            this.textarea.Text = this.textBody;
            setHtml();
        }

        bool firstStart = true;
        private void textarea_TextChanged(object sender, EventArgs e)
        {
            if (firstStart)
            {
                firstStart = false;
            }
            else setHtml();
        }

        private void printBtn_Click(object sender, EventArgs e)
        {
            this.webBrowser1.Print();
        }

        private void goBackBtn_Click(object sender, EventArgs e)
        {
            this.parent.setBody(this.pre);
        }

        public void setHtml()
        {
            String html = "<html>" +
                "<head>" +
                "<style>html,body{width:100%;height:100%;}" +
                    "body{font-size:16px;font-family: Arial;background:#f0f0f0;}" +
                    "table{width:100%;font-family: Arial;}" +
                    ".header{font-size:12px;margin:0; padding:0;}" +
                    ".textBody{margin-top:20px;margin-bottom:7px;}" +
                "</style>" +
                "</head>" +
                "<body>" +
                    "<b style='width:100%; text-align:center'>The blood BANK</b>" +
                    this.header + "<p class='textBody'><span style='width:20px;height:5px'></span>" + this.textarea.Text + "</p>" +
                    "<table><thead><td>blood type</td><td>Quantity</td<</thead>" +
                       this.body +
                    "</table>" +
                     "<p style='position:absolute;right:15; bottom:50;'>Signature:</p>" +
                "</body></html>";
            this.webBrowser1.DocumentText = html;
        }

        private void guna2Button2_Click(object sender, EventArgs e)
        {

        }
    }
}
