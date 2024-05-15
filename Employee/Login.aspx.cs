namespace git_demo;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.SqlClient;
using System.Data;

public partial class Employee_loginaspx : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        Session["e_id"] = null;
    }
    protected void btnLogin_Click(object sender, EventArgs e)
    {
        SqlConnection cn = new SqlConnection(@"Data Source=.\SQLEXPRESS;AttachDbFilename=C:\Users\khush\OneDrive\Pictures\Documents\Database.mdf;Integrated Security=True;Connect Timeout=30;User Instance=True");
        SqlDataAdapter adp = new SqlDataAdapter("select * from Employee_details where e_name=@e_name and passwd=@pwd", cn);
        adp.SelectCommand.Parameters.AddWithValue("@e_name", TextBox1.Text);
        adp.SelectCommand.Parameters.AddWithValue("@pwd", TextBox2.Text);
        DataTable dt = new DataTable();
        adp.Fill(dt);
        if (dt.Rows.Count > 0)
        {
            Session["e_id"] = dt.Rows[0][0];
            Response.Redirect("~/Employee/employee_details.aspx");

        }
        else
        {
            Response.Write("<script>alert('Invalid User,Try again')</script>");
        }
    }
}
