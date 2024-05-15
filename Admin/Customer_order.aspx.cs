namespace git_demo;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.SqlClient;
using System.Data;
public partial class Admin_Customer_details : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        
    }


   
    protected void Button2_Click(object sender, EventArgs e)
    {
        string connectionString = @"Data Source=.\SQLEXPRESS;AttachDbFilename=C:\Users\khush\OneDrive\Desktop\stationary1\App_Data\Database.mdf;Integrated Security=True;User Instance=True";

         using (SqlConnection cn = new SqlConnection(connectionString))
         {
             try
             {

                 SqlCommand cm = new SqlCommand("UPDATE Customer_order SET c_id=@c_id,p_id=@p_id,quantity=@quantity,e_id=@e_id,place=@place,delivery_date=@delivery_date,total=@total,status=@status WHERE c_order_id=@c_order_id", cn);
                 cm.Parameters.AddWithValue("@c_order_id", TextBox1.Text);
                 cm.Parameters.AddWithValue("@c_id", DropDownList1.SelectedValue);
                 cm.Parameters.AddWithValue("@p_id", DropDownList2.SelectedValue);
                 cm.Parameters.AddWithValue("@quantity", TextBox2.Text);
                 cm.Parameters.AddWithValue("@e_id", DropDownList3.SelectedValue);
                 cm.Parameters.AddWithValue("@place", TextBox3.Text);
                 cm.Parameters.AddWithValue("@delivery_date", TextBox4.Text);
                 cm.Parameters.AddWithValue("@total", TextBox5.Text);
                 cm.Parameters.AddWithValue("@status", TextBox6.Text);
                 cn.Open();
                 int rowsAffected = cm.ExecuteNonQuery();
                 cn.Close();

                 // Check if any rows were affected by the update
                 if (rowsAffected > 0)
                 {
                     SqlDataSource1.DataBind(); // Refresh data source if needed
                     GridView1.DataBind(); // Refresh GridView if needed

                 }
                 else
                 {
                     // Display message if no rows were updated
                 }
             }
             catch (Exception ex)
             {
                 // Handle and log the exception

             }

         }
    }
   
    protected void GridView1_SelectedIndexChanged(object sender, EventArgs e)
    {
        TextBox1.Text = GridView1.SelectedRow.Cells[1].Text;
        DropDownList1.SelectedValue = GridView1.SelectedRow.Cells[2].Text;
        DropDownList2.SelectedValue = GridView1.SelectedRow.Cells[3].Text;
        TextBox2.Text = GridView1.SelectedRow.Cells[4].Text;
        DropDownList3.SelectedValue = GridView1.SelectedRow.Cells[5].Text;
        TextBox3.Text = GridView1.SelectedRow.Cells[6].Text;
        TextBox4.Text = GridView1.SelectedRow.Cells[7].Text;
        TextBox5.Text = GridView1.SelectedRow.Cells[8].Text;
        TextBox6.Text = GridView1.SelectedRow.Cells[9].Text;
    }
    protected void btndlt_Click(object sender, EventArgs e)
    {
        SqlConnection cn = new SqlConnection(@"Data Source=.\SQLEXPRESS;AttachDbFilename=C:\Users\khush\OneDrive\Desktop\stationary1\App_Data\Database.mdf;Integrated Security=True;User Instance=True");
        SqlCommand cm = new SqlCommand("DELETE FROM Customer_order WHERE c_order_id=@c_order_id", cn);
        cm.Parameters.AddWithValue("@c_order_id", TextBox1.Text);
        cn.Open();
        cm.ExecuteNonQuery();
        cn.Close();
        SqlDataSource1.DataBind();
        GridView1.DataBind();
        
    }
    
}
