namespace git_demo;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.SqlClient;
using System.Data;

public partial class Admin_Sub_categories : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        
    }
    protected void btninsert_Click(object sender, EventArgs e)
    {
        SqlConnection cn = new SqlConnection(@"Data Source=.\SQLEXPRESS;AttachDbFilename=C:\Users\khush\OneDrive\Desktop\stationary1\App_Data\Database.mdf;Integrated Security=True;User Instance=True");
        SqlCommand cm = new SqlCommand("INSERT INTO Sub_categories(sub_cat_id,sub_cat_name,cat_id) VALUES (@sub_cat_id,@sub_cat_name,@cat_id)", cn);
        cm.Parameters.AddWithValue("@sub_cat_id", TextBox1.Text);
        cm.Parameters.AddWithValue("@sub_cat_name", TextBox2.Text);
        cm.Parameters.AddWithValue("@cat_id", DropDownList1.SelectedValue);
        cn.Open();
        cm.ExecuteNonQuery();
        cn.Close();
        SqlDataSource1.DataBind();
        GridView1.DataBind();
        
    }
    protected void btnupdate_Click(object sender, EventArgs e)
    {
        SqlConnection cn = new SqlConnection(@"Data Source=.\SQLEXPRESS;AttachDbFilename=C:\Users\khush\OneDrive\Desktop\stationary1\App_Data\Database.mdf;Integrated Security=True;User Instance=True");
        SqlCommand cm = new SqlCommand("UPDATE Sub_categories SET sub_cat_name=@sub_cat_name,cat_id=@cat_id WHERE sub_cat_id=@sub_cat_id", cn);
        cm.Parameters.AddWithValue("@sub_cat_id", TextBox1.Text);
        cm.Parameters.AddWithValue("@sub_cat_name", TextBox2.Text);
        cm.Parameters.AddWithValue("@cat_id", DropDownList1.SelectedValue);
        cn.Open();
        cm.ExecuteNonQuery();
        cn.Close();
        SqlDataSource1.DataBind();
        GridView1.DataBind();
      
    }
    protected void btndlt_Click(object sender, EventArgs e)
    {
        SqlConnection cn = new SqlConnection(@"Data Source=.\SQLEXPRESS;AttachDbFilename=C:\Users\khush\OneDrive\Desktop\stationary1\App_Data\Database.mdf;Integrated Security=True;User Instance=True");
        SqlCommand cm = new SqlCommand("DELETE FROM Sub_categories WHERE sub_cat_id=@sub_cat_id", cn);
        cm.Parameters.AddWithValue("@sub_cat_id", TextBox1.Text);
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
  
    }
}