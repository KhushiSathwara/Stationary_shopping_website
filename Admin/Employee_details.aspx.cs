namespace git_demo;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.SqlClient;
using System.Data;

public partial class Employee_details : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
       
    }
   
    protected void btnupdate_Click(object sender, EventArgs e)
    {
        SqlConnection cn = new SqlConnection(@"Data Source=.\SQLEXPRESS;AttachDbFilename=C:\Users\khush\OneDrive\Desktop\stationary1\App_Data\Database.mdf;Integrated Security=True;User Instance=True");
        SqlCommand cm = new SqlCommand("UPDATE Employee_details SET e_name=@e_name,passwd=@passwd,e_mobileno=@e_mobileno,address=@address,salary=@salary WHERE e_id=@e_id", cn);
        cm.Parameters.AddWithValue("@e_id", TextBox11.Text);
        cm.Parameters.AddWithValue("@e_name", TextBox12.Text);
        cm.Parameters.AddWithValue("@passwd", TextBox16.Text);
        cm.Parameters.AddWithValue("@e_mobileno", TextBox13.Text);
        cm.Parameters.AddWithValue("@address", TextBox14.Text);
        cm.Parameters.AddWithValue("@salary", TextBox15.Text);
        cn.Open();
        cm.ExecuteNonQuery();
        cn.Close();
        SqlDataSource2.DataBind();
        GridView2.DataBind();
       
    }
    protected void btndlt_Click(object sender, EventArgs e)
    {
        SqlConnection cn = new SqlConnection(@"Data Source=.\SQLEXPRESS;AttachDbFilename=C:\Users\khush\OneDrive\Desktop\stationary1\App_Data\Database.mdf;Integrated Security=True;User Instance=True");
        SqlCommand cm = new SqlCommand("DELETE FROM Employee_details WHERE e_id=@e_id", cn);
        cm.Parameters.AddWithValue("@e_id", TextBox11.Text);
        cn.Open();
        cm.ExecuteNonQuery();
        cn.Close();
        SqlDataSource2.DataBind();
        GridView2.DataBind();
       
    }
    protected void GridView2_SelectedIndexChanged(object sender, EventArgs e)
    {
        TextBox11.Text = GridView2.SelectedRow.Cells[1].Text;
        TextBox12.Text = GridView2.SelectedRow.Cells[2].Text;
        TextBox16.Text = GridView2.SelectedRow.Cells[3].Text;
        TextBox13.Text = GridView2.SelectedRow.Cells[4].Text;
        TextBox14.Text = GridView2.SelectedRow.Cells[5].Text;
        TextBox15.Text = GridView2.SelectedRow.Cells[6].Text;
    }
}
