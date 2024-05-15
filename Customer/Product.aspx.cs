namespace git_demo;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.Data.SqlClient;

public partial class Customer1_Product1 : System.Web.UI.Page
{
   
    protected void Page_Load(object sender, EventArgs e)
    {

    }
    protected void btnAddToCart_Click(object sender, EventArgs e)
    {
        
        DataList1.Visible = false;
        GridView1.Visible = true;
        SqlConnection cn = new SqlConnection(@"Data Source=.\SQLEXPRESS;AttachDbFilename=C:\Users\khush\OneDrive\Desktop\stationary1\App_Data\Database.mdf;Integrated Security=True;User Instance=True");
        SqlCommand cm = new SqlCommand("insert into Cart_view(cart_id,product,price,quantity,total,date) values(@cart_id,@product,@price,@quantity,@total,@date)", cn);
        cm.Parameters.AddWithValue("@cart_id",cart_idLabel.Text);
        cm.Parameters.AddWithValue("@product",p_idLabel.Text);
        cm.Parameters.AddWithValue("@price",priceLabel.Text);
        cm.Parameters.AddWithValue("@quantity", qtyLabel.Text);
        cm.Parameters.AddWithValue("@total", lblTotal.Text);
        cm.Parameters.AddWithValue("@date",DateTime.Now);
        cn.Open();
        cm.ExecuteNonQuery();
        cn.Close();
        SqlDataSource2.DataBind();
        GridView1.DataBind();

    }
   
    protected void DataList1_ItemDataBound(object sender, DataListItemEventArgs e)
    {
       
    }
}