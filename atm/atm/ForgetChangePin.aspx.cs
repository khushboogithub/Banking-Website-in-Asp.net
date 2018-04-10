using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.SqlClient;
public partial class _Default : System.Web.UI.Page
{
    String acc;
    SqlConnection conn = new SqlConnection("Data Source=.\\SQLEXPRESS;AttachDbFilename=|DataDirectory|\\details.mdf;Integrated Security=True;User Instance=True;MultipleActiveResultSets=true");
    
    protected void Page_Load(object sender, EventArgs e)
    {
        acc = Session["Useracc"].ToString();
        lbl_acc.Text = acc;
    }
    protected void OK_Click(object sender, EventArgs e)
    {
        conn.Open();
        acc = Session["Useracc"].ToString();
        //lbl_acc.Text = acc;
        if (Page.IsValid)
            {
                
                    SqlCommand cmd = new SqlCommand("update details set pin= '"+ txt_pin.Text +"' where account_no='" + acc + "' ", conn);
                    cmd.ExecuteNonQuery();
                   
                    lbl_disp.Text = "Pin changed Successfully";
                
            }
            else
            {
                lbl_disp.Text = "Pin Not chaged";
            }
    }
}