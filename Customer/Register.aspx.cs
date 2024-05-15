namespace git_demo;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.SqlClient;
using System.Data;

public partial class Customer1_Register : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
       
    }
    protected void btnlogin_Click(object sender, EventArgs e)
    {
        SqlConnection cn = new SqlConnection(@"Data Source=.\SQLEXPRESS;AttachDbFilename=C:\Users\khush\OneDrive\Desktop\stationary1\App_Data\Database.mdf;Integrated Security=True;User Instance=True");
        SqlCommand cm = new SqlCommand("insert into Customer(c_id,pincode,c_name,gender,c_mobileno,email,password,address) values(@c_id,@pincode,@c_name,@gender,@c_mobileno,@email,@password,@address)",cn);
        // Assuming conn is your SqlConnection object
        using (SqlCommand cmd = new SqlCommand("SELECT MAX(c_id) FROM Customer", cn))
        {
            cn.Open();
            object result = cmd.ExecuteScalar();
            cn.Close();

            int maxId = result != DBNull.Value ? Convert.ToInt32(result) : 0;
            int newId = maxId + 1;

            // Use newId in your parameter
            cm.Parameters.AddWithValue("@c_id", newId);
        }

        cm.Parameters.AddWithValue("@pincode", TextBox1.Text);
        cm.Parameters.AddWithValue("@c_name", NameTextBox.Text);
        cm.Parameters.AddWithValue("@gender", GenderDropDownList.SelectedValue);
        cm.Parameters.AddWithValue("@c_mobileno", TextBox4.Text);
        cm.Parameters.AddWithValue("@email", TextBox5.Text);
        cm.Parameters.AddWithValue("@password", TextBox6.Text);
        cm.Parameters.AddWithValue("@address", TextBox7.Text);
        cn.Open();
        cm.ExecuteNonQuery();
        cn.Close();
        Response.Redirect("~/Customer1/Product.aspx");
    }
}