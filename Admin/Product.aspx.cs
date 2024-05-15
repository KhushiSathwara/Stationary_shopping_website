namespace git_demo;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.SqlClient;
using System.Data;
using System.IO;

public partial class Product : System.Web.UI.Page
{
    byte[] imagedata;
    protected void Page_Load(object sender, EventArgs e)
    {
       
    }
    protected void Button1_Click(object sender, EventArgs e)
    {
        SqlConnection cn = new SqlConnection(@"Data Source=.\SQLEXPRESS;AttachDbFilename=C:\Users\khush\OneDrive\Desktop\stationary1\App_Data\Database.mdf;Integrated Security=True;User Instance=True");
        SqlCommand cm = new SqlCommand("INSERT INTO Product(p_id,cat_id,p_name,m_id,price,image) VALUES(@p_id,@cat_id,@p_name,@m_id,@price,@image)", cn);
        cm.Parameters.AddWithValue("@p_id", TextBox1.Text);
        cm.Parameters.AddWithValue("@cat_id", DropDownList1.SelectedValue);
        cm.Parameters.AddWithValue("@p_name", TextBox3.Text);
        cm.Parameters.AddWithValue("@m_id", DropDownList2.SelectedValue);
        cm.Parameters.AddWithValue("@price", TextBox4.Text);
         if (FileUpload1.HasFile)
        {
            FileUpload1.SaveAs(Server.MapPath("~/Images/") + FileUpload1.FileName);
            cm.Parameters.AddWithValue("@image", "~/Images/" + FileUpload1.FileName);
        }
        else
        {
            cm.Parameters.AddWithValue("@image", DBNull.Value);
        }
        cn.Open();
        cm.ExecuteNonQuery();
        cn.Close();
        SqlDataSource1.DataBind();
        GridView1.DataBind();
        Response.Redirect(Request.Url.AbsoluteUri);
        
    }
    protected void btnupdate_Click(object sender, EventArgs e)
    {
        SqlConnection cn = new SqlConnection(@"Data Source=.\SQLEXPRESS;AttachDbFilename=C:\Users\khush\OneDrive\Desktop\stationary1\App_Data\Database.mdf;Integrated Security=True;User Instance=True");
        SqlCommand cm = new SqlCommand("UPDATE Product SET cat_id=@cat_id,p_name=@p_name,m_id=@m_id,price=@price,image=@image WHERE p_id=@p_id", cn);
        cm.Parameters.AddWithValue("@p_id", TextBox1.Text);
        cm.Parameters.AddWithValue("@cat_id", DropDownList2.SelectedValue);
        cm.Parameters.AddWithValue("@p_name", TextBox3.Text);
        cm.Parameters.AddWithValue("@m_id", DropDownList1.SelectedValue);
        cm.Parameters.AddWithValue("@price", TextBox4.Text);
        if (FileUpload1.HasFile)
        {
            FileUpload1.SaveAs(Server.MapPath("~/Images/") + FileUpload1.FileName);
            cm.Parameters.AddWithValue("@image", "~/Images/" + FileUpload1.FileName);
        }
        else
        {
            cm.Parameters.AddWithValue("@image", DBNull.Value);
        }
        cn.Open();
        cm.ExecuteNonQuery();
        cn.Close();
        SqlDataSource1.DataBind();
        GridView1.DataBind();
        Response.Redirect(Request.Url.AbsoluteUri);
       
    }
    protected void btndelete_Click(object sender, EventArgs e)
    {
        SqlConnection cn = new SqlConnection(@"Data Source=.\SQLEXPRESS;AttachDbFilename=C:\Users\khush\OneDrive\Desktop\stationary1\App_Data\Database.mdf;Integrated Security=True;User Instance=True");
        SqlCommand cm = new SqlCommand("DELETE FROM Product WHERE p_id=@p_id", cn);
        cm.Parameters.AddWithValue("@p_id", TextBox1.Text);
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
        TextBox3.Text = GridView1.SelectedRow.Cells[3].Text;
        DropDownList1.SelectedValue = GridView1.SelectedRow.Cells[4].Text;
        TextBox4.Text = GridView1.SelectedRow.Cells[5].Text; 
       
    }

    public string FileName { get; set; }
}