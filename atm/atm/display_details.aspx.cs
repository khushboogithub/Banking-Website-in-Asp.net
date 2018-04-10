using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.SqlClient;

public partial class display_details : System.Web.UI.Page
{
    SqlConnection conn = new SqlConnection("Data Source=.\\SQLEXPRESS;AttachDbFilename=|DataDirectory|\\details.mdf;Integrated Security=True;User Instance=True");
    protected void Page_Load(object sender, EventArgs e)
    {
        conn.Open();
        String str = "select * from details where account_no=(select MAX(account_no) from details)";
        SqlCommand cmd1 = new SqlCommand(str, conn);
        //int count=Convert.ToInt32(cmd1.ExecuteScalar()) ;
        SqlDataReader dr = cmd1.ExecuteReader();
        //cmd.ExecuteNonQuery();
        while (dr.Read())
        {
            Label1.Text += dr[0].ToString();
            Label2.Text += dr[1].ToString();
            Label3.Text += dr[2].ToString();
            Label4.Text += dr[3].ToString();
            Label5.Text += dr[4].ToString();
            Label6.Text += dr[5].ToString();
            Label7.Text += dr[6].ToString();
            Label8.Text += dr[7].ToString();
            Label9.Text += dr[8].ToString();
            Label10.Text += dr[9].ToString();
            Label11.Text += dr[10].ToString();
            //Label12.Text += dr[11].ToString();
            //Label13.Text += dr[12].ToString();
            Label14.Text += dr[13].ToString();
        }
        conn.Close();
    }
    protected void Button1_Click(object sender, EventArgs e)
    {
        Response.Redirect("Login.aspx");
    }
}