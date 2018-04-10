using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.SqlClient;

public partial class Default2 : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        String account=null;
        SqlConnection conn = new SqlConnection("Data Source=.\\SQLEXPRESS;AttachDbFilename=|DataDirectory|\\details.mdf;Integrated Security=True;User Instance=True");
        conn.Open();
        account = Session["Useracc"].ToString();
        SqlCommand cmd = new SqlCommand("select name from details where account_no='" + account + "'", conn);
        SqlDataReader dr = cmd.ExecuteReader();
        if (dr.HasRows)
        {
            if (dr.Read())
            {
                lbl_welcome.Text = " HEY " + dr[0].ToString() + " !! ";
            }
        }
        conn.Close();

    }
}