using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class ForgetPass2 : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        if (IsPostBack)
        {
            
            if(password.Value == confirmPassword.Value)
            {
                string codes = Request.QueryString["code"];
                if(vcode.Value == codes)
                {
                    string userStr = Request.QueryString["userName"];

                    SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["DatabaseConnectionString"].ToString());
                    con.Open();
                    string query = "update Users set Password='" + password.Value + "' where Id='" + userStr + "'";
                    SqlCommand cmd = new SqlCommand(query, con);
                    try
                    {
                        string str = cmd.ExecuteNonQuery().ToString();
                        Response.Write("Successfully changed....");

                        SqlConnection con1 = new SqlConnection(ConfigurationManager.ConnectionStrings["DatabaseConnectionString"].ToString());
                        con1.Open();
                        string query1 = "UPDATE WrongPassCount SET Count = 0 WHERE Id='" + userStr + "'";
                        SqlCommand cmd1 = new SqlCommand(query1, con1);

                        cmd1.ExecuteNonQuery();

                        Response.Redirect("Login.aspx");
                    }
                    catch (Exception ex)
                    {
                        Response.Write(ex.Message);
                    }


                    con.Close();
                }
                
            }
        }
    }
}