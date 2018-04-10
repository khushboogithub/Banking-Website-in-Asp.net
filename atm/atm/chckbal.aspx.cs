using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.SqlClient;

namespace atm
{
    public partial class WebForm6 : System.Web.UI.Page
    {
        String account;
        uint bal;
        SqlConnection conn = new SqlConnection("Data Source=.\\SQLEXPRESS;AttachDbFilename=|DataDirectory|\\details.mdf;Integrated Security=True;User Instance=True");
       
        protected void Page_Load(object sender, EventArgs e)
        {
            conn.Open();
            account = Session["Useracc"].ToString();
            lbl_chkbal.Text = account;
            SqlCommand cmd = new SqlCommand("select name,balance from details where account_no='" + account + "'", conn);
            SqlDataReader dr = cmd.ExecuteReader();
             if (dr.HasRows)
                {
                    if (dr.Read())
                    {
                        lbl_name.Text = dr[0].ToString();
                        bal = Convert.ToUInt32(dr[1]);
                        lbl_currbal.Text = bal.ToString();
                    }
                }
             conn.Close();
        }
    }
}