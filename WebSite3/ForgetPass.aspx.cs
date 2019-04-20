using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.SqlClient;
using System.Configuration;
using System.Net.Mail;

public partial class ForgetPass : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        string emailStr = "";
        if (IsPostBack)
        {
            SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["DatabaseConnectionString"].ToString());
            con.Open();
            string query = "select * from Users where Id='" + userName.Value + "'";
            SqlCommand cmd = new SqlCommand(query, con);

            SqlDataReader sdr = cmd.ExecuteReader();

            

            if (sdr.Read())
            {
                emailStr = sdr.GetString(2);
                Response.Write(emailStr);

                Random rnd = new Random();
                int n = rnd.Next(1999, 9999);

                // SEND EMAIL

                SmtpClient client = new SmtpClient();
                client.DeliveryMethod = SmtpDeliveryMethod.Network;
                client.EnableSsl = true;
                client.Host = "smtp.gmail.com";
                client.Port = 587;

                // setup Smtp authentication
                System.Net.NetworkCredential credentials =
                    new System.Net.NetworkCredential("muyeen.aiub@gmail.com", "01675737920");
                client.UseDefaultCredentials = false;
                client.Credentials = credentials;

                MailMessage msg = new MailMessage();
                msg.From = new MailAddress("muyeen.aiub@gmail.com");
                msg.To.Add(new MailAddress(emailStr));

                msg.Subject = "Verification CODE";
                msg.IsBodyHtml = true;
                msg.Body = string.Format("<html><head></head><body><b>Your Code is: "+n+"</b></body>");

                try
                {
                    client.Send(msg);
                    Response.Write("Your message has been successfully sent.");

                    Session["CODE"] = n;
                    Session["UserName"] = userName.Value;

                    Response.Redirect("ForgetPass2.aspx?code="+n+"&userName="+ userName.Value);

                }
                catch (Exception ex)
                {

                    Response.Write(ex.Message);
                }

            }
            else
            {
                Response.Write("alert('Wrong userName... LOL')");
            }

            con.Close();
        }
    }
}