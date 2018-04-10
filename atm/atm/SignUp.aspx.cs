using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.IO;
using System.Data.SqlClient;
//static uint ac_no=3014979710;



namespace atm
{
        
    public partial class WebForm3 : System.Web.UI.Page
    {
        uint ac_no=3014979700 ;
        String pic_name;
        String adhar_name;
        uint balance = 0;
        SqlConnection con=new SqlConnection("Data Source=.\\SQLEXPRESS;AttachDbFilename=|DataDirectory|\\details.mdf;Integrated Security=True;User Instance=True");
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        

        protected void tb_date_TextChanged(object sender, EventArgs e)
        {
        }

        protected void btn_submit_Click(object sender, EventArgs e)
        {

            
            if (FileUpload1.HasFile)
            {
                if ((FileUpload1.PostedFile.ContentType == "image/jpeg") || (FileUpload1.PostedFile.ContentType == "image/jpg") || (FileUpload1.PostedFile.ContentType == "image/png"))
                {
                     pic_name = Path.GetFileName(FileUpload1.PostedFile.FileName);
                    FileUpload1.SaveAs(Server.MapPath("~/pic_upload/") + pic_name);
                    Label1.Text = "file uploaded";
                }
                else
                {
                    Label1.Text = "select an image file ";
                }
            }
            else
            {
                Label1.Text = "file not uploaded";
            }

            if (FileUpload2.HasFile)
            {
                if ((FileUpload2.PostedFile.ContentType == "image/jpeg") || (FileUpload2.PostedFile.ContentType == "image/jpg") || (FileUpload2.PostedFile.ContentType == "image/png"))
                {
                     adhar_name = Path.GetFileName(FileUpload2.PostedFile.FileName);
                    FileUpload2.SaveAs(Server.MapPath("~/pic_upload/") + adhar_name);
                    Label2.Text = "file uploaded";
                }
                else
                {
                    Label2.Text = "select an image file ";
                }
            }
            else
            {
                Label2.Text = "file not uploaded";
            }
            if (Page.IsValid)
            {
                con.Open();

                SqlCommand cmd = new SqlCommand("insert into details values('" + tb_name.Text + "','" + tb_dob.Text + "','" + dd_sex.Text + "','" + tb_add.Text + "','" + tb_city.Text + "','" + tb_state.Text + "','" + tb_pincode.Text + "','" + tb_email.Text + "','" + tb_contact.Text + "','" + tb_pinnum.Text + "','" + pic_name + "','" + adhar_name + "','" +balance + "','"+ans1_txt.Text+"','"+ans2_txt.Text+"','"+ans3_txt.Text+"')", con);
                cmd.ExecuteNonQuery();
                con.Close();
                Label3.Text = "Data inserted Successfully";
                Response.Redirect("display_details.aspx");

            }
            if (!Page.IsValid)
            {
                Label3.Text = "Data not inserted Successfully";
            }


        }

        protected void dd_month_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        protected void tb_contact_TextChanged(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            

         }

        protected void CustomValidator1_ServerValidate(object source, ServerValidateEventArgs args)
        {
            if (args.Value.Length == 10)
            {
                args.IsValid = true;
            }
            else
            {
                args.IsValid = false;
            }
           
        }

        



    protected void  CustomValidator2_ServerValidate(object source, ServerValidateEventArgs args)
{
        String date=tb_dob.Text;
         String[] y=date.Split('/');
         int year = Convert.ToInt32(y[2]);


         String sys_year = System.DateTime.Now.ToString("dd-mm-yyyy");
         String[] sy = sys_year.Split('-');
         int s_year = Convert.ToInt32(sy[2]);

         if ((s_year-year<18) && (s_year > year))
         {
             args.IsValid = false;
         }

      


}
    protected void tb_state_TextChanged(object sender, EventArgs e)
    {

    }
}
 }
    