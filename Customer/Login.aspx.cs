namespace git_demo;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.SqlClient;
using System.Data;

public partial class Customer1_Login : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        Session["c_id"] = null;
    }
   
    protected void btnlogin_Click(object sender, EventArgs e)
    {
        SqlConnection cn = new SqlConnection(@"Data Source=.\SQLEXPRESS;AttachDbFilename=C:\Users\khush\OneDrive\Desktop\stationary1\App_Data\Database.mdf;Integrated Security=True;User Instance=True");
        SqlDataAdapter adp = new SqlDataAdapter("select * from Customer where email=@email and password=@pwd", cn);
        adp.SelectCommand.Parameters.AddWithValue("@email", TextBox1.Text);
        adp.SelectCommand.Parameters.AddWithValue("@pwd", TextBox2.Text);
        DataTable dt = new DataTable();
        adp.Fill(dt);
        if (dt.Rows.Count > 0)
        {
            Session["c_id"] = dt.Rows[0][0];
            Response.Redirect("~/Customer1/Product1.aspx");

        }
        else
        {
            Response.Write("<script>alert('Invalid User,Try again')</script>");
        }
    }
}
