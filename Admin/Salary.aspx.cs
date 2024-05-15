namespace git_demo;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.SqlClient;
using System.Data;

public partial class Admin_Salary : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
       
    }
    protected void btninsert_Click(object sender, EventArgs e)
    {
        SqlConnection cn = new SqlConnection(@"Data Source=.\SQLEXPRESS;AttachDbFilename=C:\Users\khush\OneDrive\Pictures\Documents\Database.mdf;Integrated Security=True;Connect Timeout=30;User Instance=True");
        SqlCommand cm = new SqlCommand("INSERT INTO Salary(salary_id,e_id,salary) VALUES(@salary_id,@e_id,@salary)", cn);
        cm.Parameters.AddWithValue("@salary_id", TextBox1.Text);
        cm.Parameters.AddWithValue("@e_id", DropDownList2.SelectedValue);
        cm.Parameters.AddWithValue("@salary", TextBox2.Text);
        cn.Open();
        cm.ExecuteNonQuery();
        cn.Close();
        SqlDataSource1.DataBind();
        GridView1.DataBind();
        
    }
    protected void btnupdate_Click(object sender, EventArgs e)
    {
        SqlConnection cn = new SqlConnection(@"Data Source=.\SQLEXPRESS;AttachDbFilename=C:\Users\khush\OneDrive\Pictures\Documents\Database.mdf;Integrated Security=True;Connect Timeout=30;User Instance=True");
        SqlCommand cm = new SqlCommand("UPDATE Salary SET e_id=@e_id,salary=@salary WHERE salary_id=@salary_id", cn);
        cm.Parameters.AddWithValue("@salary_id", TextBox1.Text);
        cm.Parameters.AddWithValue("@e_id", DropDownList2.SelectedValue);
        cm.Parameters.AddWithValue("@salary", TextBox2.Text);
        cn.Open();
        cm.ExecuteNonQuery();
        cn.Close();
        SqlDataSource1.DataBind();
        GridView1.DataBind();
       
    }
    protected void btndlt_Click(object sender, EventArgs e)
    {
        SqlConnection cn = new SqlConnection(@"Data Source=.\SQLEXPRESS;AttachDbFilename=C:\Users\khush\OneDrive\Pictures\Documents\Database.mdf;Integrated Security=True;Connect Timeout=30;User Instance=True");
        SqlCommand cm = new SqlCommand("DELETE FROM Salary WHERE salary_id=@salary_id", cn);
        cm.Parameters.AddWithValue("@salary_id", TextBox1.Text);
        cn.Open();
        cm.ExecuteNonQuery();
        cn.Close();
        SqlDataSource1.DataBind();
        GridView1.DataBind();
       
    }
    protected void GridView1_SelectedIndexChanged(object sender, EventArgs e)
    {
        TextBox1.Text = GridView1.SelectedRow.Cells[1].Text;
        DropDownList2.SelectedValue = GridView1.SelectedRow.Cells[2].Text;
        TextBox2.Text = GridView1.SelectedRow.Cells[3].Text;
    }
}