using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.SqlClient;
using System.Data;

namespace atm
{
    public partial class Site2 : System.Web.UI.MasterPage
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            String account = Session["Useracc"].ToString();
            //lbl_pic.Text = account;
            Convert.ToUInt32(account);
            SqlConnection conn = new SqlConnection("Data Source=.\\SQLEXPRESS;AttachDbFilename=|DataDirectory|\\details.mdf;Integrated Security=True;User Instance=True");
            SqlDataAdapter sda = new SqlDataAdapter("select photo from details where account_no='" + account + "'", conn);
            DataTable dt = new DataTable();
            sda.Fill(dt);

            conn.Open();

            if (dt.Rows[0]["photo"].ToString().Length > 1)
            {
                Image1.ImageUrl = "pic_upload/" + dt.Rows[0]["photo"].ToString();
            }
            else
            {
               // lbl_pic.Text = "pic!!!!!!!!!!!";
                Image1.AlternateText = "Profile Picture Unavalaible";
            }

            //String str1 = "select photo from details where account_no='" + account + "'";
            //SqlCommand cmd = new SqlCommand(str1, conn);
            //SqlDataReader dr = cmd.ExecuteReader();
            //if (dr.HasRows)
            //{
            //    if (dr.Read())
            //    {
            //        String pic = dr[0].ToString();
            //        lbl_pic.Text = Server.MapPath("~/pic_upload/") + pic;
            //        String x = Server.MapPath("~/pic_upload/") + pic;
            //        Image1.ToolTip = x;
            //        Image1.ImageUrl = Server.MapPath("~/pic_upload/") + pic;
                
            //    }
            //}
            //else
            //{
            //    lbl_pic.Text = "no pic uploaded ";
            //}


        }

    }
}