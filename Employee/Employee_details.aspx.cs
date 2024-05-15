using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.SqlClient;
using System.Data;

public partial class Employee_distr : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        SqlConnection cn = new SqlConnection(@"Data Source=.\SQLEXPRESS;AttachDbFilename=C:\Users\khush\OneDrive\Desktop\stationary1\App_Data\Database.mdf;Integrated Security=True;User Instance=True");
        SqlCommand cm = new SqlCommand("select * from Employee_details where e_name=@e_name and passwd=@passwd", cn);
    }
    protected void btninsert_Click(object sender, EventArgs e)
    {
        SqlConnection cn = new SqlConnection(@"Data Source=.\SQLEXPRESS;AttachDbFilename=C:\Users\khush\OneDrive\Desktop\stationary1\App_Data\Database.mdf;Integrated Security=True;User Instance=True");
        SqlCommand cm = new SqlCommand("INSERT INTO Employee_details(e_id,e_name,passwd,e_mobileno,address,salary) VALUES (@e_id,@e_name,@passwd,@e_mobileno,@address,@salary)", cn);
        cm.Parameters.AddWithValue("@e_id", TextBox1.Text);
        cm.Parameters.AddWithValue("@e_name", TextBox2.Text);
        cm.Parameters.AddWithValue("@passwd", TextBox6.Text);
        cm.Parameters.AddWithValue("@e_mobileno", TextBox3.Text);
        cm.Parameters.AddWithValue("@address", TextBox4.Text);
        cm.Parameters.AddWithValue("@salary", TextBox5.Text);
        cn.Open();
        cm.ExecuteNonQuery();
        cn.Close();
        SqlDataSource1.DataBind();
        GridView1.DataBind();
       
    }
    protected void btnupdate_Click(object sender, EventArgs e)
    {
        SqlConnection cn = new SqlConnection(@"Data Source=.\SQLEXPRESS;AttachDbFilename=C:\Users\khush\OneDrive\Desktop\stationary1\App_Data\Database.mdf;Integrated Security=True;User Instance=True");
        SqlCommand cm = new SqlCommand("UPDATE Employee_details SET e_name=@e_name,passwd=@passwd,e_mobileno=@e_mobileno,address=@address,salary=@salary WHERE e_id=@e_id", cn);
        cm.Parameters.AddWithValue("@e_id", TextBox1.Text);
        cm.Parameters.AddWithValue("@e_name", TextBox2.Text);
        cm.Parameters.AddWithValue("@passwd", TextBox6.Text);
        cm.Parameters.AddWithValue("@e_mobileno", TextBox3.Text);
        cm.Parameters.AddWithValue("@address", TextBox4.Text);
        cm.Parameters.AddWithValue("@salary", TextBox5.Text);
        cn.Open();
        cm.ExecuteNonQuery();
        cn.Close();
        SqlDataSource1.DataBind();
        GridView1.DataBind();
       
    }
    protected void GridView1_SelectedIndexChanged(object sender, EventArgs e)
    {
        TextBox1.Text = GridView1.SelectedRow.Cells[1].Text;
        TextBox2.Text = GridView1.SelectedRow.Cells[2].Text;
        TextBox6.Text = GridView1.SelectedRow.Cells[3].Text;
        TextBox3.Text = GridView1.SelectedRow.Cells[4].Text;
        TextBox4.Text = GridView1.SelectedRow.Cells[5].Text;
        TextBox5.Text = GridView1.SelectedRow.Cells[6].Text;
    }
}