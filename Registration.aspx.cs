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
    public partial class Registration : System.Web.UI.Page
    {
        SqlConnection sqlConnection = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=|DataDirectory|PhoneBook.mdf;Integrated Security=True");
        protected void Page_Load(object sender, EventArgs e)
        {
            if (sqlConnection.State == ConnectionState.Open)
            {
                sqlConnection.Close();
            }
            sqlConnection.Open();
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            int i = 0;
            SqlCommand sqlCommand1 = sqlConnection.CreateCommand();
            sqlCommand1.CommandType = CommandType.Text;
            sqlCommand1.CommandText = "select * from Registration where username='"+ username.Text +"'";
            sqlCommand1.ExecuteNonQuery();
            DataTable dt1 = new DataTable();
            SqlDataAdapter da1 = new SqlDataAdapter(sqlCommand1);
            da1.Fill(dt1);
            i = Convert.ToInt32(dt1.Rows.Count.ToString());

            if (i == 0)
            {
                SqlCommand sqlCommand = sqlConnection.CreateCommand();
                sqlCommand.CommandType = CommandType.Text;
                sqlCommand.CommandText = "insert into Registration values('" + firstName.Text + "','" + lastName.Text + "','" + email.Text + "','" + username.Text + "','" + password.Text + "','" + contact.Text + "')";
                sqlCommand.ExecuteNonQuery();

                Response.Write("<script>alert('Record inserted successfully');</script>");

            }
            else
            {
                Response.Write("<script>alert('This username already exists, please choose another username.');</script>");
            }


           
        }
    }
}