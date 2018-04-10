using System;

using System.Collections.Generic;

using System.Linq;

using System.Web;

using System.Web.UI;

using System.Web.UI.WebControls;

using System.Data;

using System.Data.SqlClient;

using System.Configuration;

 

public partial class Default3 : System.Web.UI.Page

{

   

    SqlCommand cmd;

    SqlDataAdapter da;

    DataSet ds;

 

    SqlConnection con = new SqlConnection("Data Source=.\\SQLEXPRESS;AttachDbFilename=|DataDirectory|\\details.mdf;Integrated Security=True;User Instance=True");

 
    protected void Page_Load(object sender, EventArgs e)
    {
        
        if (!IsPostBack)

        {

            RepeterData();

        }

    }

    protected void btnSubmit_click(object sender, EventArgs e)

    {

        try

        {

            con.Open();

             cmd = new SqlCommand("insert into Comment (UserName,Subject,CommentOn,Post_Date) values(@userName,@subject,@comment,@date)", con);

            cmd.Parameters.Add("@userName", SqlDbType.NVarChar).Value = txtName.Text.ToString();

            cmd.Parameters.Add("@subject", SqlDbType.NVarChar).Value = txtSubject.Text.ToString();

            cmd.Parameters.Add("@comment", SqlDbType.NVarChar).Value = txtComment.Text.ToString();

            cmd.Parameters.Add("@date", SqlDbType.DateTime).Value = DateTime.Now.Date;

            cmd.ExecuteNonQuery();

            con.Close();

            txtName.Text = string.Empty;

            txtSubject.Text = string.Empty;

            txtComment.Text = string.Empty;

            RepeterData();

 

        }

        catch(Exception ex)

            {

               txtComment.Text= ex.Message;

            }

 

    }

    public void RepeterData()

    {

        con.Open();

        cmd = new SqlCommand("Select * from feedback Order By Post_Date desc", con);

        DataSet ds = new DataSet();

        da = new SqlDataAdapter(cmd);

        da.Fill(ds);

        RepterDetails.DataSource = ds;

        RepterDetails.DataBind();

 

    }

}

 

   