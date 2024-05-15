namespace git_demo;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.Data.SqlClient;

public partial class Admin_Distributer : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {

    }
    protected void btninsert_Click(object sender, EventArgs e)
    {
        SqlConnection cn = new SqlConnection(@"Data Source=.\SQLEXPRESS;AttachDbFilename=C:\Users\khush\OneDrive\Desktop\stationary1\App_Data\Database.mdf;Integrated Security=True;User Instance=True");
        SqlCommand cm = new SqlCommand("INSERT INTO Distributer(d_id,d_name,email,d_mobileno,gst_no,city_id) VALUES (@d_id,@d_name,@email,@d_mobileno,@gst_no,@city_id)", cn);
        cm.Parameters.AddWithValue("@d_id", TextBox1.Text);
        cm.Parameters.AddWithValue("@d_name", TextBox2.Text);
        cm.Parameters.AddWithValue("@email", TextBox3.Text);
        cm.Parameters.AddWithValue("@d_mobileno", TextBox4.Text);
        cm.Parameters.AddWithValue("@gst_no", TextBox5.Text);
        cm.Parameters.AddWithValue("@city_id", DropDownList1.SelectedValue);
        cn.Open();
        cm.ExecuteNonQuery();
        cn.Close();
        SqlDataSource1.DataBind();
        GridView1.DataBind();

    }
    protected void btnupdate_Click(object sender, EventArgs e)
    {
        SqlConnection cn = new SqlConnection(@"Data Source=.\SQLEXPRESS;AttachDbFilename=C:\Users\khush\OneDrive\Desktop\stationary1\App_Data\Database.mdf;Integrated Security=True;User Instance=True");
        SqlCommand cm = new SqlCommand("UPDATE Distributer SET d_name=@d_name,email=@email,d_mobileno=@d_mobileno,gst_no=@gst_no,city_id=@city_id WHERE d_id=@d_id", cn);
        cm.Parameters.AddWithValue("@d_id", TextBox1.Text);
        cm.Parameters.AddWithValue("@d_name", TextBox2.Text);
        cm.Parameters.AddWithValue("@email", TextBox3.Text);
        cm.Parameters.AddWithValue("@d_mobileno", TextBox4.Text);
        cm.Parameters.AddWithValue("@gst_no", TextBox5.Text);
        cm.Parameters.AddWithValue("@city_id", DropDownList1.SelectedValue);
        cn.Open();
        cm.ExecuteNonQuery();
        cn.Close();
        SqlDataSource1.DataBind();
        GridView1.DataBind();

    }
    protected void btndlt_Click(object sender, EventArgs e)
    {
        SqlConnection cn = new SqlConnection(@"Data Source=.\SQLEXPRESS;AttachDbFilename=C:\Users\khush\OneDrive\Desktop\stationary1\App_Data\Database.mdf;Integrated Security=True;User Instance=True");
        SqlCommand cm = new SqlCommand("DELETE FROM Distributer WHERE d_id=@d_id", cn);
        cm.Parameters.AddWithValue("@d_id", TextBox1.Text);
        cn.Open();
        cm.ExecuteNonQuery();
        cn.Close();
        SqlDataSource1.DataBind();
        GridView1.DataBind();
    }
    protected void GridView1_SelectedIndexChanged1(object sender, EventArgs e)
    {
        TextBox1.Text = GridView1.SelectedRow.Cells[1].Text;
        TextBox2.Text = GridView1.SelectedRow.Cells[2].Text;
        TextBox3.Text = GridView1.SelectedRow.Cells[3].Text;
        TextBox4.Text = GridView1.SelectedRow.Cells[4].Text;
        TextBox5.Text = GridView1.SelectedRow.Cells[5].Text;
        DropDownList1.SelectedValue = GridView1.SelectedRow.Cells[6].Text;
       

    }
}
