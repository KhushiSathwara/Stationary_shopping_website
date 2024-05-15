using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.SqlClient;
using System.Data;



public partial class Admin_Area : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
   
      
       
    }
    protected void Button1_Click(object sender, EventArgs e)
    {
        SqlConnection cn = new SqlConnection(@"Data Source=.\SQLEXPRESS;AttachDbFilename=C:\Users\khush\OneDrive\Pictures\Documents\Database.mdf;Integrated Security=True;Connect Timeout=30;User Instance=True");
        SqlCommand cm = new SqlCommand("INSERT INTO Area(pincode,area_name,city_id) VALUES (@pincode,@area_name,@city_id)", cn);
        cm.Parameters.AddWithValue("@pincode", TextBox1.Text);
        cm.Parameters.AddWithValue("@area_name", TextBox2.Text);
        cm.Parameters.AddWithValue("@city_id", DropDownList1.SelectedValue);
        cn.Open();
        cm.ExecuteNonQuery();
        cn.Close();
        SqlDataSource1.DataBind();
        GridView1.DataBind();
       
    }
    protected void Button2_Click(object sender, EventArgs e)
    {

        string connectionString = @"Data Source=.\SQLEXPRESS;AttachDbFilename=C:\Users\khush\OneDrive\Pictures\Documents\Database.mdf;Integrated Security=True;Connect Timeout=30;User Instance=True";

        using (SqlConnection cn = new SqlConnection(connectionString))
        {
            try
            {
                SqlCommand cm = new SqlCommand("UPDATE Area SET area_name=@area_name, city_id=@city_id WHERE pincode=@pincode", cn);
                cm.Parameters.AddWithValue("@pincode", TextBox1.Text);
                cm.Parameters.AddWithValue("@area_name", TextBox2.Text);
                cm.Parameters.AddWithValue("@city_id", DropDownList1.SelectedValue);

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
    protected void btndelete_Click(object sender, EventArgs e)
    {
        SqlConnection cn = new SqlConnection(@"Data Source=.\SQLEXPRESS;AttachDbFilename=C:\Users\khush\OneDrive\Pictures\Documents\Database.mdf;Integrated Security=True;Connect Timeout=30;User Instance=True");
        SqlCommand cm = new SqlCommand("DELETE from Area WHERE pincode=@pincode", cn);
        cm.Parameters.AddWithValue("@pincode", TextBox1.Text);
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
        string cell3Text = GridView1.SelectedRow.Cells[3].Text;
        if (DropDownList1.Items.FindByValue(cell3Text) != null)
        {
            DropDownList1.SelectedValue = cell3Text;
        }
        //DropDownList1.SelectedValue = GridView1.SelectedRow.Cells[3].Text;

    }
}