namespace git_demo;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.SqlClient;
using System.Data;

public partial class Customer1_AddToCart : System.Web.UI.Page
{

    protected void Page_Load(object sender, EventArgs e)
    {
        if (Session["c_id"] == null)
            Response.Redirect("~/Customer1/Login.aspx");
        String cid = Session["c_id"].ToString();
        SqlDataSource1.SelectCommand = "select * from Cart_view where cust_id=" + cid;
        SqlConnection cn = new SqlConnection(@"Data Source=.\SQLEXPRESS;AttachDbFilename=C:\Users\khush\OneDrive\Pictures\Documents\Database.mdf;Integrated Security=True;Connect Timeout=30;User Instance=True");
        SqlCommand cm = new SqlCommand("insert into Cart_view (cart_id,cust_id,product,price,quantity,total,date) values(@cart_id,@cust_id,@product,@price,@quantity,@total,@date)", cn);
        cm.Parameters.AddWithValue("@p_id", TextBox1.Text);
        cm.Parameters.AddWithValue("@cat_id", DropDownList1.SelectedValue);
        cm.Parameters.AddWithValue("@p_name", TextBox3.Text);
        cm.Parameters.AddWithValue("@m_id", DropDownList2.SelectedValue);
        cm.Parameters.AddWithValue("@price", TextBox4.Text);
        SqlDataSource1.DataBind();
        GridView1.DataBind();
    }
    protected void checkbtn_Click(object sender, EventArgs e)
    {
       
    }
}
