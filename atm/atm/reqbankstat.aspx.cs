using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Net.Mail;
using System.IO;
using System.Data.SqlClient;
namespace atm
{
    public partial class WebForm11 : System.Web.UI.Page
    {
        String account;
        SqlConnection con = new SqlConnection("Data Source=.\\SQLEXPRESS;AttachDbFilename=|DataDirectory|\\details.mdf;Integrated Security=True;User Instance=True");
        protected void Page_Load(object sender, EventArgs e)
        {
            account = Session["Useracc"].ToString();
        }
        protected void btn_reqStat_Click(object sender, EventArgs e)
        {
             
            String reciever;
            con.Open();

            SqlCommand cmd = new SqlCommand("select email from details where account_no='" + account + "' ", con);
            SqlDataReader dr = cmd.ExecuteReader();


            if (dr.HasRows)
            {
                if (dr.Read())
                {
                    
               
            MailMessage mm = new MailMessage("2018asp.net@gmail.com",dr[0].ToString());
            mm.Subject = "Request for Bank Statement";
            mm.IsBodyHtml = true;
            mm.Body = "Hello customer, your Bank Statement request has been processed. You will get a mail soon regarding it. Thank you";

            System.Net.NetworkCredential nc = new System.Net.NetworkCredential("2018asp.net@gmail.com", "20182018");
            SmtpClient smc = new SmtpClient();
            smc.EnableSsl = true;
            smc.UseDefaultCredentials = false;
            smc.Credentials = nc;
            smc.Host = "smtp.gmail.com";
            smc.Port = 587;
            smc.Send(mm);
                }
            }
            //Response.Write("Mail successfully sent");
            lbl_disp.Text = "Mail successfully sent..!!";
        }
}
}