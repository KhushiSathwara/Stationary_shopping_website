namespace git_demo;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.SqlClient;
using System.Data;

public partial class Admin_Distributer_details : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        
    }
    protected void Button1_Click(object sender, EventArgs e)
    {
        SqlConnection cn = new SqlConnection(@"Data Source=.\SQLEXPRESS;AttachDbFilename=C:\Users\khush\OneDrive\Desktop\stationary1\App_Data\Database.mdf;Integrated Security=True;User Instance=True");
        SqlCommand cm = new SqlCommand("INSERT INTO Distributer_details(d_details_id,p_id,quantity,date,rate,total) VALUES (@d_details_id,@p_id,@quantity,@date,@rate,@total)", cn);
        cm.Parameters.AddWithValue("@d_details_id", TextBox1.Text);
        cm.Parameters.AddWithValue("@p_id", DropDownList1.Text);
        cm.Parameters.AddWithValue("@quantity", TextBox3.Text);
        cm.Parameters.AddWithValue("@date", TextBox4.Text);
        cm.Parameters.AddWithValue("@rate", TextBox5.Text);
        cm.Parameters.AddWithValue("@total", TextBox6.Text);
        cn.Open();
        cm.ExecuteNonQuery();
        cn.Close();
        SqlDataSource2.DataBind();
        GridView1.DataBind();
        
        
    }
    protected void Button2_Click(object sender, EventArgs e)
    {
        SqlConnection cn = new SqlConnection(@"Data Source=.\SQLEXPRESS;AttachDbFilename=C:\Users\khush\OneDrive\Desktop\stationary1\App_Data\Database.mdf;Integrated Security=True;User Instance=True");
        SqlCommand cm = new SqlCommand("UPDATE Distributer_details SET p_id=@p_id,quantity=@quantity,date=@date,rate=@rate,total=@total WHERE d_details_id=@d_details_id", cn);
        cm.Parameters.AddWithValue("@d_details_id", TextBox1.Text);
        cm.Parameters.AddWithValue("@p_id", DropDownList1.Text);
        cm.Parameters.AddWithValue("@quantity", TextBox3.Text);
        cm.Parameters.AddWithValue("@date", TextBox4.Text);
        cm.Parameters.AddWithValue("@rate", TextBox5.Text);
        cm.Parameters.AddWithValue("@total", TextBox6.Text);
        cn.Open();
        cm.ExecuteNonQuery();
        cn.Close();
        SqlDataSource2.DataBind();
        GridView1.DataBind();
       
    }
    protected void Button3_Click(object sender, EventArgs e)
    {
        SqlConnection cn = new SqlConnection(@"Data Source=.\SQLEXPRESS;AttachDbFilename=C:\Users\khush\OneDrive\Desktop\stationary1\App_Data\Database.mdf;Integrated Security=True;User Instance=True");
        SqlCommand cm = new SqlCommand("DELETE from Distributer_details WHERE d_details_id=@d_details_id ", cn);
        cm.Parameters.AddWithValue("@d_details_id", TextBox1.Text);
        cn.Open();
        cm.ExecuteNonQuery();
        cn.Close();
        SqlDataSource2.DataBind();
        GridView1.DataBind();
        
    }
   

    protected void GridView1_SelectedIndexChanged1(object sender, EventArgs e)
    {
        TextBox1.Text = GridView1.SelectedRow.Cells[1].Text;
        DropDownList1.SelectedValue = GridView1.SelectedRow.Cells[2].Text;
        TextBox3.Text = GridView1.SelectedRow.Cells[3].Text;
        TextBox4.Text = GridView1.SelectedRow.Cells[4].Text;
        TextBox5.Text = GridView1.SelectedRow.Cells[5].Text;
        TextBox6.Text = GridView1.SelectedRow.Cells[6].Text;
    }
}