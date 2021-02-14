using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.SqlClient;
using System.Data;

namespace PhoneBook
{
    public partial class add_contact : System.Web.UI.Page
    {
        SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=|DataDirectory|PhoneBook.mdf;Integrated Security=True");
        protected void Page_Load(object sender, EventArgs e)
        {
            if(con.State==ConnectionState.Open)
            {
                con.Close();
            }
            con.Open();

            if(Session["username"] == null)
            {
                Response.Redirect("login.aspx");
            }
        }

        protected void b1_Click(object sender, EventArgs e)
        {
            SqlCommand cmd = con.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "insert into add_contact values('"+ Session["username"].ToString() + "','"+ firstname.Text +"','"+ lastname.Text +"','"+ contactno.Text +"','"+ email.Text +"','"+ residentaddress.Text +"','"+ city.Text +"')";
            cmd.ExecuteNonQuery();

            Response.Write("<script>alert('your contact added successfully');</script>");
        }
    }
}