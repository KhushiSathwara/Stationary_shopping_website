<%@ Page Title="" Language="C#" MasterPageFile="~/Customer1/Customer.master" AutoEventWireup="true" CodeFile="Product1.aspx.cs" Inherits="Customer1_Product1" %>

<asp:Content ID="Content1" ContentPlaceHolderID="c1" Runat="Server" Visible="true">
 
     <div class="container">
                <!-- Portfolio Section Heading-->
               
                <!-- Icon Divider-->
                 <div class="row justify-content-center">
                   <asp:DataList ID="DataList1" runat="server" DataKeyField="p_id" Visible="true" 
        DataSourceID="SqlDataSource1" RepeatColumns="2" 
        onitemdatabound="DataList1_ItemDataBound">
        <ItemTemplate>
             <table id="prods" align="center">
         <tr>
            <td> 
                <asp:Image ID="Image1" runat="server" CssClass="img-fluid" ImageUrl='<%# Eval("image") %>' Height="279px" Width="278px"  />
            </td>
        </tr>
        
        <tr>
            <td class="product-name">
                <asp:Label ID="lblProdName" runat="server" Text='<%# Eval("p_name") %>' Font-Bold="True" CssClass="text-center"
                    Font-Names="Open Sans Extrabold" ForeColor="White" BackColor="Black" 
                    Height="30px" Width="400px" Font-Size="Large"></asp:Label>
            </td>
        </tr>
        <tr>
            <td>
                <asp:Label ID="lblPrice" runat="server" Text='<%# "Rs. " + Eval("price") %>' Font-Names="Arial" ForeColor="Black"></asp:Label>
               
            </td>
        </tr>
        <tr>
            <td align="center">Quantity
                <asp:DropDownList ID="DropDownList1" runat="server">
                    <asp:ListItem>1</asp:ListItem>
                    <asp:ListItem>2</asp:ListItem>
                    <asp:ListItem>3</asp:ListItem>
                    <asp:ListItem>4</asp:ListItem>
                    <asp:ListItem>5</asp:ListItem>
                </asp:DropDownList>
                <asp:Label ID="lblProductId" runat="server" Visible="true" Text='<%# Eval("p_id") %>' />
            </td>
        </tr>
         <tr>
            <td>
                <asp:Button ID="btnAddToCart" CssClass="mainButton" runat="server" 
                    Text="Add to Cart" BorderStyle="None" onclick="btnAddToCart_Click"  />

            </td>
            </tr>
    </table>

        </ItemTemplate>
    </asp:DataList>
     
    <asp:SqlDataSource ID="SqlDataSource1" runat="server" 
        ConnectionString="<%$ ConnectionStrings:ConnectionString %>" 
        SelectCommand="SELECT * FROM [Product]"></asp:SqlDataSource> 
                           </div>
                        </div>
       
        
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server" Visible="true">
 <asp:Label ID="p_idLabel" runat="server" Visible="false" Text="2" />
                <asp:Label ID="lblTotal" runat="server" Visible="false" Text="290"></asp:Label> 
         <asp:Label ID="priceLabel" runat="server" Visible="false" Text="145" />
    <asp:Label ID="qtyLabel" runat="server" Visible="false" Text="2"></asp:Label>
                <asp:Label ID="cart_idLabel" runat="server" Visible="false" Text="1"></asp:Label> 
    <asp:GridView ID="GridView1" runat="server" AutoGenerateColumns="False" 
        Visible="False" DataSourceID="SqlDataSource2" CellPadding="4" 
        ForeColor="#333333" GridLines="None" Width="1275px">
        <AlternatingRowStyle BackColor="White" ForeColor="#284775" />
        <Columns>
            <asp:BoundField DataField="cart_id" HeaderText="cart_id" 
                SortExpression="cart_id" />
            <asp:BoundField DataField="product" HeaderText="product" 
                SortExpression="product" />
            <asp:BoundField DataField="price" HeaderText="price" SortExpression="price" />
            <asp:BoundField DataField="quantity" HeaderText="quantity" 
                SortExpression="quantity" />
            <asp:BoundField DataField="total" HeaderText="total" SortExpression="total" />
            <asp:BoundField DataField="date" HeaderText="date" SortExpression="date" />
        </Columns>
        <EditRowStyle BackColor="#999999" />
        <FooterStyle BackColor="#5D7B9D" Font-Bold="True" ForeColor="White" />
        <HeaderStyle BackColor="#5D7B9D" Font-Bold="True" ForeColor="White" />
        <PagerStyle BackColor="#284775" ForeColor="White" HorizontalAlign="Center" />
        <RowStyle BackColor="#F7F6F3" ForeColor="#333333" />
        <SelectedRowStyle BackColor="#E2DED6" Font-Bold="True" ForeColor="#333333" />
        <SortedAscendingCellStyle BackColor="#E9E7E2" />
        <SortedAscendingHeaderStyle BackColor="#506C8C" />
        <SortedDescendingCellStyle BackColor="#FFFDF8" />
        <SortedDescendingHeaderStyle BackColor="#6F8DAE" />
    </asp:GridView>
    <asp:SqlDataSource ID="SqlDataSource2" runat="server" 
        ConnectionString="<%$ ConnectionStrings:ConnectionString %>" 
        SelectCommand="SELECT [cart_id], [product], [price], [quantity], [total], [date] FROM [Cart_view]"></asp:SqlDataSource> 
</asp:Content>

