using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.SqlClient;
using System.Configuration;

public partial class Login : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        if (IsPostBack)
        {
            SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["DatabaseConnectionString"].ToString());
            con.Open();
            string query = "select * from Users where Id='" + TextBox1.Text + "' and Password='" + TextBox2.Text + "'";
            SqlCommand cmd = new SqlCommand(query, con);
            //string o = cmd.ExecuteScalar().ToString();
            SqlDataReader sdr = cmd.ExecuteReader();
            if (sdr.Read())
            {
                con.Close();
                // Check pass count
                SqlConnection con2 = new SqlConnection(ConfigurationManager.ConnectionStrings["DatabaseConnectionString"].ToString());
                con2.Open();
                string query1 = "select * from WrongPassCount where Id='" + TextBox1.Text + "'";
                SqlCommand cmd1 = new SqlCommand(query1, con2);
                
                SqlDataReader sdr1 = cmd1.ExecuteReader();
                int i = 0;
                if (sdr1.Read())
                {
                     i = sdr1.GetInt32(1);
                }

                if (i < 3)
                {
                    Response.Write("Successfully Login");
                    HttpCookie cookie = new HttpCookie("LogInInformation");
                    cookie["userName"] = TextBox1.Text;
                    if (rememberMe.Checked)
                    {
                        cookie["rememberMeUserName"] = TextBox1.Text;
                        cookie["rememberMePassword"] = TextBox2.Text;

                    }
                    cookie.Expires = DateTime.Now.AddMinutes(2);
                    Response.Cookies.Add(cookie);
                    
                        Response.Redirect("home.aspx");
                    
                    
                }
                else
                {
                    Response.Redirect("ForgetPass.aspx");
                }
                con2.Close();
            }
            else
            {
                con.Close();
                SqlConnection con1 = new SqlConnection(ConfigurationManager.ConnectionStrings["DatabaseConnectionString"].ToString());
                con1.Open();
                string query1 = "UPDATE  uuuuuuuuuuuuuuuuuuuuuuuuuuuuuuuuuuuuuuuuuuuuuuuuuuuuuuuuuuuuuuuuuuuuuuuuuuuuuuuuuuuuuuuuuuuuuuuuuuuuuuuuuuuuuuuuuuuuuuuuuuuuuuuuuuuuuuuuuuuuuuuuuuuuuuuuuuuuuuuuuuuuuuuuuuuuuuuuuuuuuuuuuuuuuuuu  SET Count = Count + 1 WHERE Id='" + TextBox1.Text + "'";
                SqlCommand cmd1 = new SqlCommand(query1, con1);
                
                cmd1.ExecuteNonQuery();
                

                Response.Write("Login Failed");
                con1.Close();

                SqlConnection con2 = new SqlConnection(ConfigurationManager.ConnectionStrings["DatabaseConnectionString"].ToString());
                con2.Open();
                string query3 = "select * from WrongPassCount where Id='" + TextBox1.Text + "'";
                SqlCommand cmd3 = new SqlCommand(query3, con2);

                SqlDataReader sdr1 = cmd3.ExecuteReader();
                int i = 0;
                if (sdr1.Read())
                {
                    i = sdr1.GetInt32(1);
                }
                if (i > 3)
                {
                    Response.Redirect("ForgetPass.aspx");
                }

                
            }
            con.Close();
            
            
        }
        else
        {
            HttpCookie cookie = Request.Cookies["LogInInformation"];
            if (cookie != null)
            {
                TextBox1.Text = cookie["rememberMeUserName"];
                TextBox2.Text = cookie["rememberMePassword"];
            }
        }
    }

    protected void Button1_Click(object sender, EventArgs e)
    {

    }
}