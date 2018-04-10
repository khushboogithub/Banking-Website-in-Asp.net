using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.SqlClient;
using System.Web.Configuration;
using System.Data;

namespace atm
{
    public partial class WebForm2 : System.Web.UI.Page
    {
        SqlConnection con = new SqlConnection("Data Source=.\\SQLEXPRESS;AttachDbFilename=|DataDirectory|\\details.mdf;Integrated Security=True;User Instance=True");
        
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                tb_password.TextMode = TextBoxMode.Password;
            }
        }

        protected void tb_username_TextChanged(object sender, EventArgs e)
        {
           
        }

        protected void tb_password_TextChanged(object sender, EventArgs e)
        {
           
        }

        protected void btn_login_Click(object sender, EventArgs e)
        {
           
            
            
       

           
            SqlConnection conn = new SqlConnection("Data Source=.\\SQLEXPRESS;AttachDbFilename=|DataDirectory|\\details.mdf;Integrated Security=True;User Instance=True");
            conn.Open();
           
            SqlCommand cmd = new SqlCommand("select * from details where account_no='"+tb_accountno.Text+"' and pin='"+tb_password.Text+"' ",conn);
            SqlDataReader dr = cmd.ExecuteReader();

            
           if(dr.HasRows)
            {
                if (dr.Read())
                {
                    Session["Useracc"] = tb_accountno.Text;
                    Response.Redirect("welcome.aspx");
                }
            }
           else
            {
                Label1.Text = "incorrect pin or account number";
               // Session["Useracc"]="";
            }

            
            
        }
}
}