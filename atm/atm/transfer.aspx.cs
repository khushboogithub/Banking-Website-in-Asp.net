using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.SqlClient;

namespace atm
{
    public partial class WebForm9 : System.Web.UI.Page
    {
        SqlConnection conn = new SqlConnection("Data Source=.\\SQLEXPRESS;AttachDbFilename=|DataDirectory|\\details.mdf;Integrated Security=True;User Instance=True;MultipleActiveResultSets=true");
         
         ulong racc_no;
         String account;
       
        protected void Page_Load(object sender, EventArgs e)
        {

            if (!IsPostBack)
            {
                up_transfer.Visible = false;


                conn.Open();
                account = Session["Useracc"].ToString();
                lbl_accno.Text = account;
                conn.Close();
            }

        }

        protected void btn_verify_Click(object sender, EventArgs e)
        {
            conn.Open();
            racc_no = Convert.ToUInt64(txt_recpno.Text);
            SqlCommand cmd = new SqlCommand("select name from details where account_no='" + racc_no + "'", conn);
            SqlDataReader dr = cmd.ExecuteReader();
            if (dr.HasRows)
            {
                if (dr.Read())
                {
                    up_transfer.Visible = true;

                }
            }
            else
            {
                lbl_disp.Text = "Please Enter a Valid Account Number ";
            }
            //dr.Close();
            //dr.Dispose();
            conn.Close();
        }
        protected void btn_transfer_Click(object sender, EventArgs e)
        {
            racc_no = Convert.ToUInt64(txt_recpno.Text);
           conn.Open();
           uint acc;
           account = Session["Useracc"].ToString();
           lbl_accno.Text = account;
           //lbl_disp_transfer.Text = account;
           acc = Convert.ToUInt32(account);

            int result;
            uint bal;
            uint trans_amount = Convert.ToUInt32(txt_amount.Text);
           
            SqlCommand cmd_s = new SqlCommand("select balance from details where account_no='" + acc + "'", conn);
            
            SqlDataReader dr_s = cmd_s.ExecuteReader();
           
            //lbl_disp_transfer.Text = dr_s[0].ToString();
            if (!(int.TryParse(txt_amount.Text, out result)))
            {
                lbl_disp_transfer.Text = "Enter amount only in digits ";
            }
            else
            {
                if (dr_s.HasRows)
                {
                    if (dr_s.Read())
                    {

                        if (Convert.ToUInt32(dr_s[0]) >= trans_amount )
                        {

                            //lbl_disp_transfer.Text = dr_s[0].ToString();
                            bal = Convert.ToUInt32(dr_s[0]);
                            bal -= trans_amount;
                            SqlCommand cmd2 = new SqlCommand("update details set balance='" + bal + "' where account_no='" + account + "'", conn);
                            cmd2.ExecuteNonQuery();
                            //lbl_disp_transfer.Text = "Amount Withdrawn";
                            uint r_acc;
                            //lbl_disp_transfer.Text = "the account number is " + racc_no;
                            r_acc = Convert.ToUInt32(racc_no);
                            //lbl_disp_transfer.Text = "the account number is " + r_acc.ToString();
                            SqlCommand cmd_r = new SqlCommand("select balance from details where account_no='" + r_acc + "'", conn);
                            SqlDataReader dr_r = cmd_r.ExecuteReader();
                                     if (dr_r.HasRows)
                                     {
                                         if (dr_r.Read())
                                         {
                                             lbl_disp_transfer.Text = "coming here ";
                                             //lbl_disp_transfer.Text = dr_r[0].ToString();
                                             bal = Convert.ToUInt32(dr_r[0]);
                                             bal += trans_amount;
                                             SqlCommand cmd_1 = new SqlCommand("update details set balance='" + bal + "' where account_no='" + racc_no + "'", conn);
                                             cmd_1.ExecuteNonQuery();
                                             lbl_disp_transfer.Text = "Amount Tranferred Successfully!";
                                         }
                                     }
                                     else
                                     {
                                         lbl_disp_transfer.Text = "There are some Issues !! Please try again sometime later!!";
                                     }
                            

                        }
                        else
                        {
                            lbl_disp_transfer.Text = "Sorry, you don't have suffient balance to transfer..!!";
                        }
                    }
                }
                else
                {
                    lbl_disp_transfer.Text = "Unable to transfer amount";
                }
               
            }
            conn.Close();

        }
}
}