using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.SqlClient;

namespace atm
{


    public partial class WebForm7 : System.Web.UI.Page
    {
        String account;
        uint dep_amt,bal;
        SqlConnection conn = new SqlConnection("Data Source=.\\SQLEXPRESS;AttachDbFilename=|DataDirectory|\\details.mdf;Integrated Security=True;User Instance=True;MultipleActiveResultSets=true;");
        protected void Page_Load(object sender, EventArgs e)
        {
            account = Session["Useracc"].ToString();
            lbl_accno.Text = account;

        }
        protected void btn_depo_Click(object sender, EventArgs e)
        {
            conn.Open();
            String s = txt_amtdepo.Text;
            int result;
            if (!(int.TryParse(s, out result)))
            {
                Label1.Text = "Enter amount only in digits ";
            }
            else
            {

                dep_amt = Convert.ToUInt32(txt_amtdepo.Text);
                SqlCommand cmd = new SqlCommand("select balance from details where account_no='" + account + "'", conn);
                SqlDataReader dr = cmd.ExecuteReader();
                if (dr.HasRows)
                {
                    if (dr.Read())
                    {
                        bal = Convert.ToUInt32(dr[0]);
                        bal += dep_amt;
                        SqlCommand cmd2 = new SqlCommand("update details set balance='" + bal + "' where account_no='" + account + "'", conn);
                        cmd2.ExecuteNonQuery();
                        lbl_rslt.Text = "Amount Deposited";
                    }
                }
                else
                {
                    lbl_rslt.Text = "Amount not Deposited";
                }

               
            }
            conn.Close();
        }
        protected void CustomValidator1_ServerValidate(object source, ServerValidateEventArgs args)
        {
            //String abc = args.GetType().ToString();
            //Label1.Text = abc;
            
                 
        }
}
}