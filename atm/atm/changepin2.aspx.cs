using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.SqlClient;
namespace atm
{
    public partial class WebForm20 : System.Web.UI.Page
    {
        SqlConnection conn = new SqlConnection("Data Source=.\\SQLEXPRESS;AttachDbFilename=|DataDirectory|\\details.mdf;Integrated Security=True;User Instance=True;MultipleActiveResultSets=true");

        
        String account;
        String pin2,  newpin;
        
        protected void Page_Load(object sender, EventArgs e)
        {

            if (!IsPostBack)
            {
                UpdatePanel2.Visible = false;


                conn.Open();
                account = Session["Useracc"].ToString();
                lbl_accno.Text = account;
                conn.Close();
            }
        }
        protected void checkbtn_Click(object sender, EventArgs e)
        {
           
        }
        protected void changebtn_Click(object sender, EventArgs e)
        {
             account = Session["Useracc"].ToString();
            newpin = textboxnewpin.Text;
            conn.Open();
            if (Page.IsValid)
            {
                
                    SqlCommand cmd = new SqlCommand("update details set pin= '"+ newpin +"' where account_no='" + account + "' ", conn);
                    cmd.ExecuteNonQuery();
                   
                    lblmsg.Text = "Pin updated Successfully";
                
            }
            else
            {
                lblmsg.Text = "Pin Not Updated";
            }
            conn.Close();

        }
        protected void _verify_Click(object sender, EventArgs e)
        {
            conn.Open();
            account = Session["Useracc"].ToString();
            lbl_accno.Text = account;

            SqlCommand cmd = new SqlCommand("select pin from details where account_no='" + account + "'", conn);
            SqlDataReader dr = cmd.ExecuteReader();
            pin2 = TextBox1.Text;
            if (dr.HasRows)
            {
                if (dr.Read())
                {

                    if (pin2 == dr[0].ToString())
                    {
                        Label4.Visible = false;
                        UpdatePanel2.Visible = true;
                        
                    }
                    else
                    {
                        Label4.Text = "Sorry Wrong Pin Number!";
                    }


                }


            }

            conn.Close();
        }
}
}