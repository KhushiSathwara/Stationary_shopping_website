namespace git_demo;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.SqlClient;
using System.Data;

public partial class Admin_Product_Company : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
       
    }
    protected void btnisert_Click(object sender, EventArgs e)
    {
        SqlConnection cn = new SqlConnection(@"Data Source=.\SQLEXPRESS;AttachDbFilename=C:\Users\khush\OneDrive\Desktop\stationary1\App_Data\Database.mdf;Integrated Security=True;User Instance=True");
        SqlCommand cm = new SqlCommand("INSERT INTO Poduct_company(cmp_id,cat_id,cmp_name,price,quantity) VALUES (@cmp_id,@cat_id,@cmp_name,@price,@quantity)", cn);
        cm.Parameters.AddWithValue("@cmp_id", TextBox1.Text);
        cm.Parameters.AddWithValue("@cat_id", DropDownList1.SelectedValue);
        cm.Parameters.AddWithValue("@cmp_name", TextBox2.Text);
        cm.Parameters.AddWithValue("@price", TextBox3.Text);
        cm.Parameters.AddWithValue("@quantity", TextBox4.Text);
        cn.Open();
        cm.ExecuteNonQuery();
        cn.Close();
        SqlDataSource1.DataBind();
        GridView1.DataBind();
      
    }
    protected void btnupdate_Click(object sender, EventArgs e)
    {
        SqlConnection cn = new SqlConnection(@"Data Source=.\SQLEXPRESS;AttachDbFilename=C:\Users\khush\OneDrive\Desktop\stationary1\App_Data\Database.mdf;Integrated Security=True;User Instance=True");
        SqlCommand cm = new SqlCommand("UPDATE Poduct_company SET cat_id=@cat_id,cmp_name=@cmp_name,price=@price,quantity=@quantity WHERE cmp_id=@cmp_id", cn);
        cm.Parameters.AddWithValue("@cmp_id", TextBox1.Text);
        cm.Parameters.AddWithValue("@cat_id", DropDownList1.SelectedValue);
        cm.Parameters.AddWithValue("@cmp_name", TextBox2.Text);
        cm.Parameters.AddWithValue("@price", TextBox3.Text);
        cm.Parameters.AddWithValue("@quantity", TextBox4.Text);
        cn.Open();
        cm.ExecuteNonQuery();
        cn.Close();
        SqlDataSource1.DataBind();
        GridView1.DataBind();
        
    }
    protected void btndlt_Click(object sender, EventArgs e)
    {
        SqlConnection cn = new SqlConnection(@"Data Source=.\SQLEXPRESS;AttachDbFilename=C:\Users\khush\OneDrive\Desktop\stationary1\App_Data\Database.mdf;Integrated Security=True;User Instance=True");
        SqlCommand cm = new SqlCommand("DELETE FROM Poduct_company WHERE cmp_id=@cmp_id", cn);
        cm.Parameters.AddWithValue("@cmp_id", TextBox1.Text);
        cn.Open();
        cm.ExecuteNonQuery();
        cn.Close();
        SqlDataSource1.DataBind();
        GridView1.DataBind();
        
    }
    protected void GridView1_SelectedIndexChanged(object sender, EventArgs e)
    {

        TextBox1.Text = GridView1.SelectedRow.Cells[1].Text;
        DropDownList1.SelectedValue = GridView1.SelectedRow.Cells[2].Text;
        TextBox2.Text = GridView1.SelectedRow.Cells[3].Text;
        TextBox3.Text = GridView1.SelectedRow.Cells[4].Text;
        TextBox4.Text = GridView1.SelectedRow.Cells[5].Text;
    }
}