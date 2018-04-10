using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.SqlClient;

namespace atm
{
    public partial class WebForm8 : System.Web.UI.Page
    {
        String account;
        uint with_amt, bal;
        SqlConnection conn = new SqlConnection("Data Source=.\\SQLEXPRESS;AttachDbFilename=|DataDirectory|\\details.mdf;Integrated Security=True;User Instance=True;MultipleActiveResultSets=true;");
        protected void Page_Load(object sender, EventArgs e)
        {
            account = Session["Useracc"].ToString();
            lbl_accno.Text = account;
        }
        protected void Withdraw_Click(object sender, EventArgs e)
        {
            conn.Open();
            String s = txt_withdraw.Text;
            int result;
            if (!(int.TryParse(s, out result)))
            {
                lbl_withdrawrslt.Text = "Enter amount only in digits ";
            }
            else
            {

                with_amt = Convert.ToUInt32(txt_withdraw.Text);
                SqlCommand cmd = new SqlCommand("select balance from details where account_no='" + account + "'", conn);
                SqlDataReader dr = cmd.ExecuteReader();
                if (dr.HasRows)
                {
                    if (dr.Read())
                    {
                        if (Convert.ToUInt32(dr[0]) >= with_amt)
                        {
                            bal = Convert.ToUInt32(dr[0]);
                            bal -= with_amt;
                            SqlCommand cmd2 = new SqlCommand("update details set balance='" + bal + "' where account_no='" + account + "'", conn);
                            cmd2.ExecuteNonQuery();
                            lbl_withdrawrslt.Text = "Amount Withdrawn";
                        }
                        else
                        {
                            lbl_withdrawrslt.Text = "Sorry, you don't have suffient balance to withdraw..!!";
                        }
                    }
                }
                else
                {
                    lbl_withdrawrslt.Text = "Amount not Withdrawn";
                }
               
            }
            conn.Close();
        }
}
}