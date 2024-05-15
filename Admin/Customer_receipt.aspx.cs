using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.SqlClient;
using System.Data;

public partial class Admin_Customer_receipt : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        
    }
    protected void SqlDataSource1_Selecting(object sender, SqlDataSourceSelectingEventArgs e)
    {

    }
    protected void Button1_Click(object sender, EventArgs e)
    {

        SqlConnection cn = new SqlConnection(@"Data Source=.\SQLEXPRESS;AttachDbFilename=C:\Users\khush\OneDrive\Pictures\Documents\Database.mdf;Integrated Security=True;Connect Timeout=30;User Instance=True");
        SqlCommand cm = new SqlCommand("INSERT INTO Customer_receipt(c_rec_id,c_id,payment_date,amount,mode) VALUES(@c_rec_id,@c_id,@payment_date,@amount,@mode)", cn);
        cm.Parameters.AddWithValue("@c_rec_id", TextBox4.Text);
        cm.Parameters.AddWithValue("@c_id", dropdown1.SelectedValue);
        cm.Parameters.AddWithValue("@payment_date",TextBox8.Text);
        cm.Parameters.AddWithValue("@amount", TextBox9.Text);
        cm.Parameters.AddWithValue("@mode", TextBox10.Text);
        cn.Open();
        cm.ExecuteNonQuery();
        cn.Close();
        SqlDataSource3.DataBind();
        GridView1.DataBind();
       
    }
    protected void Button2_Click(object sender, EventArgs e)
    {
        SqlConnection cn = new SqlConnection(@"Data Source=.\SQLEXPRESS;AttachDbFilename=C:\Users\khush\OneDrive\Pictures\Documents\Database.mdf;Integrated Security=True;Connect Timeout=30;User Instance=True");
        SqlCommand cm = new SqlCommand("UPDATE Customer_receipt SET c_id=@c_id,payment_date=@payment_date,amount=@amount,mode=@mode WHERE c_rec_id=@c_rec_id", cn);
        cm.Parameters.AddWithValue("@c_rec_id", TextBox4.Text);
        cm.Parameters.AddWithValue("@c_id", dropdown1.SelectedValue);
        cm.Parameters.AddWithValue("@payment_date", TextBox8.Text);
        cm.Parameters.AddWithValue("@amount", TextBox9.Text);
        cm.Parameters.AddWithValue("@mode", TextBox10.Text);
        cn.Open();
        cm.ExecuteNonQuery();
        cn.Close();
        SqlDataSource3.DataBind();
        GridView1.DataBind();
       
    }
    protected void Button3_Click(object sender, EventArgs e)
    {

        SqlConnection cn = new SqlConnection(@"Data Source=.\SQLEXPRESS;AttachDbFilename=C:\Users\khush\OneDrive\Pictures\Documents\Database.mdf;Integrated Security=True;Connect Timeout=30;User Instance=True");
        SqlCommand cm = new SqlCommand("DELETE FROM Customer_receipt WHERE c_rec_id=@c_rec_id", cn);
        cm.Parameters.AddWithValue("@c_rec_id", TextBox4.Text);
        cn.Open();
        cm.ExecuteNonQuery();
        cn.Close();
        SqlDataSource3.DataBind();
        GridView1.DataBind();
        
    }
    protected void GridView3_SelectedIndexChanged(object sender, EventArgs e)
    {
        TextBox4.Text = GridView1.SelectedRow.Cells[1].Text;
        dropdown1.SelectedValue = GridView1.SelectedRow.Cells[2].Text;
        TextBox8.Text = GridView1.SelectedRow.Cells[3].Text;
        TextBox9.Text = GridView1.SelectedRow.Cells[4].Text;
        TextBox10.Text = GridView1.SelectedRow.Cells[5].Text;
    }
}