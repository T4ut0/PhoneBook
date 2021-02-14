using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.Data.SqlClient;

namespace PhoneBook
{
    public partial class edit : System.Web.UI.Page
    {
        SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=|DataDirectory|PhoneBook.mdf;Integrated Security=True");
        int id;
        protected void Page_Load(object sender, EventArgs e)
        {

            if (con.State == ConnectionState.Open)
            {
                con.Close();
            }
            con.Open();

            if (Session["username"] == null)
            {
                Response.Redirect("login.aspx");
            }

            id = Convert.ToInt32(Request.QueryString["id"].ToString());

            if (IsPostBack) return;

            SqlCommand cmd = con.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "select * from add_contact where id=" + id + "";
            cmd.ExecuteNonQuery();
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            da.Fill(dt);

            foreach(DataRow dr in dt.Rows)
            {
                firstname.Text = dr["firstname"].ToString();
                lastname.Text = dr["lastname"].ToString();
                contactno.Text = dr["contactno"].ToString();
                email.Text = dr["email"].ToString();
                residentaddress.Text = dr["resident_address"].ToString();
                city.Text = dr["city"].ToString();
            }

        }

        protected void b1_Click(object sender, EventArgs e)
        {
            SqlCommand cmd = con.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "update add_contact set firstname='"+firstname.Text+"', lastname='"+ lastname.Text +"', contactno='"+ contactno.Text+"', email='"+ email.Text +"', resident_address='"+ residentaddress.Text +"', city='"+ city.Text +"' where id=" + id +"";
            cmd.ExecuteNonQuery();

            Response.Redirect("mycontact.aspx");
        }
    }
}