using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.SqlClient;
using System.Configuration;

public partial class Registration : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        
            if (IsPostBack)
            {
                SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["DatabaseConnectionString"].ToString());
                con.Open();
                string query = "INSERT INTO Users VALUES('"+userName.Value+"', '"+password.Value+"', '"+email.Value+"') ";
                SqlCommand cmd = new SqlCommand(query, con);
                try
                {
                    cmd.ExecuteScalar();
                }
                catch (Exception ex)
                {
                    Response.Write("alert('Same user name may exist...try something new...')");
                    string sr = ex.Message;
                }

                con.Close();

            }
    }
    
}