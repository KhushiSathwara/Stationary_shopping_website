namespace git_demo;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.SqlClient;
using System.Data;

public partial class Admin_Distributer_receipt : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
       
    }
   
    protected void btnupdate_Click(object sender, EventArgs e)
    {
        SqlConnection cn = new SqlConnection(@"Data Source=.\SQLEXPRESS;AttachDbFilename=C:\Users\khush\OneDrive\Desktop\stationary1\App_Data\Database.mdf;Integrated Security=True;User Instance=True");
        SqlCommand cm = new SqlCommand("UPDATE Distributer_receipt SET d_id=@d_id,payment_date=@payment_date,amount=@amount,mode=@mode WHERE d_rec_id=@d_rec_id ", cn);
        cm.Parameters.AddWithValue("@d_rec_id", TextBox1.Text);
        cm.Parameters.AddWithValue("@d_id", DropDownList1.SelectedValue);
        cm.Parameters.AddWithValue("@payment_date", TextBox2.Text);
        cm.Parameters.AddWithValue("@amount", TextBox3.Text);
        cm.Parameters.AddWithValue("@mode", TextBox4.Text);
        cn.Open();
        cm.ExecuteNonQuery();
        cn.Close();
        SqlDataSource1.DataBind();
        GridView1.DataBind();
        
    }
    protected void btndlt_Click(object sender, EventArgs e)
    {
        SqlConnection cn = new SqlConnection(@"Data Source=.\SQLEXPRESS;AttachDbFilename=C:\Users\khush\OneDrive\Desktop\stationary1\App_Data\Database.mdf;Integrated Security=True;User Instance=True");
        SqlCommand cm = new SqlCommand("DELETE FROM Distributer_receipt WHERE d_rec_id=@d_rec_id ", cn);
        cm.Parameters.AddWithValue("@d_rec_id", TextBox1.Text);
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
    protected void btninsert_Click(object sender, EventArgs e)
    {
        SqlConnection cn = new SqlConnection(@"Data Source=.\SQLEXPRESS;AttachDbFilename=C:\Users\khush\OneDrive\Desktop\stationary1\App_Data\Database.mdf;Integrated Security=True;User Instance=True");
        SqlCommand cm = new SqlCommand("INSERT INTO Distributer_receipt(d_rec_id,d_id,payment_date,amount,mode) VALUES (@d_rec_id,@d_id,@payment_date,@amount,@mode)", cn);
        cm.Parameters.AddWithValue("@d_rec_id", TextBox1.Text);
        cm.Parameters.AddWithValue("@d_id", DropDownList1.SelectedValue);
        cm.Parameters.AddWithValue("@payment_date", TextBox2.Text);
        cm.Parameters.AddWithValue("@amount", TextBox3.Text);
        cm.Parameters.AddWithValue("@mode", TextBox4.Text);
        cn.Open();
        cm.ExecuteNonQuery();
        cn.Close();
        SqlDataSource1.DataBind();
        GridView1.DataBind();
    }
}
