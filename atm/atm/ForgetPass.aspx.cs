using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.SqlClient;


public partial class Default2 : System.Web.UI.Page
{
    SqlConnection con = new SqlConnection("Data Source=.\\SQLEXPRESS;AttachDbFilename=|DataDirectory|\\details.mdf;Integrated Security=True;User Instance=True");
    String account;
    protected void Page_Load(object sender, EventArgs e)
    {
        up_ques2.Visible = false;
        up_ques3.Visible = false;

    }
    protected void btn_verify_Click(object sender, EventArgs e)
    {
        con.Open();
        account = txt_acc.Text;
       // lbl_acc.Text = account;
        SqlCommand cmd = new SqlCommand("select question1,question2,question3 from details where account_no='" + account + "'", con);
        SqlDataReader dr = cmd.ExecuteReader();
        if (dr.HasRows)
        {
            if (dr.Read())
            {
                if (txt_ans1.Text.Equals(dr[0]))
                {
                    up_ques2.Visible = true;
                    if (txt_ans2.Text.Equals(dr[1]))
                    {
                        up_ques3.Visible = true;
                        if (txt_ans3.Text.Equals(dr[2]))
                        {
                            Session["Useracc"] = txt_acc.Text;
                            Response.Redirect("ForgetChangePin.aspx");
                        }
                    }
                }
                else
                    lbl_ans1.Text = "Sorry wrong answer outer";
            }
        }
    }
}