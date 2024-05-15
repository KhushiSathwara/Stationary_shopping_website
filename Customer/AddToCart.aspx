<%@ Page Language="C#" AutoEventWireup="true" CodeFile="AddToCart.aspx.cs" Inherits="Customer1_AddToCart" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <style type="text/css">
        .style1
        {
            width: 66px;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
    <div align="center" style=" margin: 0 auto;">
        <h2 style="text-decoration: underline overline blink; color:Blue">You have following product in your cart</h2>
        <br /> <br />
        <asp:HyperLink ID="HyperLink1" runat="server" Font-Bold="True" 
            Font-Size="X-Large" NavigateUrl="~/Customer1/Product.aspx">Continue Shoping</asp:HyperLink>
            <br /> <br />
        <br />
        <asp:GridView ID="GridView1" runat="server" 
            CellPadding="4" EmptyDataText="No particular data available in shoping cart" 
            ForeColor="#333333" DataKeyNames="cart_id" DataSourceID="SqlDataSource1">
            <AlternatingRowStyle BackColor="White" />
            <Columns>
                <asp:BoundField DataField="cart_id" HeaderText="cart_id" ReadOnly="True" InsertVisible="false"
                    SortExpression="cart_id">
                </asp:BoundField>
                <asp:BoundField DataField="cust_id" HeaderText="cust_id" 
                    SortExpression="cust_id">
                </asp:BoundField>
                <asp:BoundField DataField="product" HeaderText="product" 
                    SortExpression="product">
                </asp:BoundField>
                <asp:BoundField DataField="price" HeaderText="price" SortExpression="price">
                </asp:BoundField>
                <asp:BoundField DataField="quantity" HeaderText="quantity" 
                    SortExpression="quantity" />
                <asp:BoundField DataField="total" HeaderText="total" SortExpression="total" />
                <asp:BoundField DataField="date" HeaderText="date" SortExpression="date" />
            </Columns>
            <EditRowStyle BackColor="#2461BF" />
            <FooterStyle BackColor="#507CD1" Font-Bold="True" ForeColor="White" />
            <HeaderStyle BackColor="#507CD1" Font-Bold="True" ForeColor="White" />
            <PagerStyle BackColor="#2461BF" ForeColor="White" HorizontalAlign="Center" />
            <RowStyle BackColor="#EFF3FB" />
            <SelectedRowStyle BackColor="#D1DDF1" Font-Bold="True" ForeColor="#333333" />
            <SortedAscendingCellStyle BackColor="#F5F7FB" />
            <SortedAscendingHeaderStyle BackColor="#6D95E1" />
            <SortedDescendingCellStyle BackColor="#E9EBEF" />
            <SortedDescendingHeaderStyle BackColor="#4870BE" />
        </asp:GridView>
        <br />
        <asp:SqlDataSource ID="SqlDataSource1" runat="server" 
            ConnectionString="<%$ ConnectionStrings:DatabaseConnectionString2 %>" 
            SelectCommand="SELECT * FROM [Cart_view]"></asp:SqlDataSource>
   
    <script src="js/main.js"></script>
    <br />
    <asp:Button ID="checkbtn" runat="server" Text="Check out" CssClass="btn" 
            onclick="checkbtn_Click" />
     </div>
    </form>
</body>
</html>
