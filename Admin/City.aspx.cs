using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.SqlClient;
using System.Data;

public partial class Admin_City : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {

    }
    protected void btninsert_Click(object sender, EventArgs e)
    {
        SqlConnection cn = new SqlConnection(@"Data Source=.\SQLEXPRESS;AttachDbFilename=C:\Users\khush\OneDrive\Pictures\Documents\Database.mdf;Integrated Security=True;Connect Timeout=30;User Instance=True");
        SqlCommand cm = new SqlCommand("INSERT INTO City(city_id,city_name,state_code) VALUES (@city_id,@city_name,@state_code)", cn);
        cm.Parameters.AddWithValue("@city_id", TextBox1.Text);
        cm.Parameters.AddWithValue("@city_name", TextBox2.Text);
        cm.Parameters.AddWithValue("@state_code", DropDownList1.SelectedValue);
        cn.Open();
        cm.ExecuteNonQuery();
        cn.Close();
        SqlDataSource2.DataBind();
        GridView2.DataBind();
    }
    protected void btnupdate_Click(object sender, EventArgs e)
    {
                SqlConnection cn = new SqlConnection(@"Data Source=.\SQLEXPRESS;AttachDbFilename=C:\Users\khush\OneDrive\Pictures\Documents\Database.mdf;Integrated Security=True;Connect Timeout=30;User Instance=True");
        SqlCommand cm = new SqlCommand("UPDATE City SET city_name=@city_name,state_code=@state_code WHERE city_id=@city_id", cn);
        cm.Parameters.AddWithValue("@city_id", TextBox1.Text);
        cm.Parameters.AddWithValue("@city_name", TextBox2.Text);
        cm.Parameters.AddWithValue("@state_code", DropDownList1.SelectedValue);
        cn.Open();
        cm.ExecuteNonQuery();
        cn.Close();
        SqlDataSource2.DataBind();
        GridView2.DataBind();
    }
    protected void btndlt_Click(object sender, EventArgs e)
    {
        SqlConnection cn = new SqlConnection(@"Data Source=.\SQLEXPRESS;AttachDbFilename=C:\Users\khush\OneDrive\Pictures\Documents\Database.mdf;Integrated Security=True;Connect Timeout=30;User Instance=True ");
        SqlCommand cm = new SqlCommand("DELETE FROM City WHERE city_id=@city_id", cn);
        cm.Parameters.AddWithValue("@city_id", TextBox1.Text);
        cn.Open();
        cm.ExecuteNonQuery();
        cn.Close();
        SqlDataSource2.DataBind();
        GridView2.DataBind();
  
    }
    protected void GridView2_SelectedIndexChanged(object sender, EventArgs e)
    {
        TextBox1.Text = GridView2.SelectedRow.Cells[1].Text;
        TextBox2.Text = GridView2.SelectedRow.Cells[2].Text;
        //DropDownList1.SelectedValue = GridView2.SelectedRow.Cells[3].Text;
        string cell3Text = GridView2.SelectedRow.Cells[3].Text;
        if (DropDownList1.Items.FindByValue(cell3Text) != null)
        {
            DropDownList1.SelectedValue = cell3Text;
        }
    }
}