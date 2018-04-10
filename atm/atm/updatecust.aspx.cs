using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.IO;
using System.Web.UI.WebControls;
using System.Data.SqlClient;

namespace atm
{
    public partial class WebForm12 : System.Web.UI.Page
    {
        String pic_name,useracc;
        SqlConnection con = new SqlConnection("Data Source=.\\SQLEXPRESS;AttachDbFilename=|DataDirectory|\\details.mdf;Integrated Security=True;User Instance=True");
        protected void Page_Load(object sender, EventArgs e)
        {
            useracc = Session["Useracc"].ToString();
            Label3.Text = useracc;
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


        protected void btn_update_Click(object sender, EventArgs e)
        {

            con.Open();
            
            if (FileUpload1.HasFile)
            {
                if ((FileUpload1.PostedFile.ContentType == "image/jpeg") || (FileUpload1.PostedFile.ContentType == "image/jpg") || (FileUpload1.PostedFile.ContentType == "image/png"))
                {
                    pic_name = Path.GetFileName(FileUpload1.PostedFile.FileName);
                    FileUpload1.SaveAs(Server.MapPath("~/pic_upload/") + pic_name);
                    Label2.Text = "File Uploaded";
                }
                else
                {
                    Label2.Text = "Select An Image File ";
                }
            }
            else
            {
                Label2.Text = "File Not Uploaded";
            }

            if (Page.IsValid)
            {
                if ((FileUpload1.PostedFile.ContentType == "image/jpeg") || (FileUpload1.PostedFile.ContentType == "image/jpg") || (FileUpload1.PostedFile.ContentType == "image/png"))
                {
                    SqlCommand cmd = new SqlCommand("update details set name='" + txt_name.Text + "',  address='" + txt_addr.Text + "',number='" + txt_phno.Text + "',email='" + txt_email.Text + "',photo='" + pic_name + "' where account_no='" + useracc + "' ", con);
                    cmd.ExecuteNonQuery();
                    con.Close();
                    Label1.Text = "Data updated Successfully";
                }
            }
            else
            {
                Label1.Text = "Data Not Updated";
            }

        }
    }
}