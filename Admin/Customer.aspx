<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Customer.aspx.cs" Inherits="Admin_Customer" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
      <!-- Required meta tags -->
    <meta charset="utf-8">
    <meta name="viewport" content="width=device-width, initial-scale=1, shrink-to-fit=no">
    <title>Purple Admin</title>
    <!-- plugins:css -->
    <link rel="stylesheet" href="assets/vendors/mdi/css/materialdesignicons.min.css">
    <link rel="stylesheet" href="assets/vendors/css/vendor.bundle.base.css">
    <!-- endinject -->
    <!-- Plugin css for this page -->
    <!-- End plugin css for this page -->
    <!-- inject:css -->
    <!-- endinject -->
    <!-- Layout styles -->
    <link rel="stylesheet" href="assets/css/style.css">
    <!-- End layout styles -->
    <link rel="shortcut icon" href="assets/images/favicon.ico" />
</head>
<body>
    <form id="form1" runat="server">
    <div>
          <div class="container-scroller">
      <!-- partial:partials/_navbar.html -->
      <nav class="navbar default-layout-navbar col-lg-12 col-12 p-0 fixed-top d-flex flex-row">
        <div class="text-center navbar-brand-wrapper d-flex align-items-center justify-content-center">
          
        </div>
        <div class="navbar-menu-wrapper d-flex align-items-stretch">
          <button class="navbar-toggler navbar-toggler align-self-center" type="button" data-toggle="minimize">
            <span class="mdi mdi-menu"></span>
          </button>
          <div class="search-field d-none d-md-block">
            <form class="d-flex align-items-center h-100" action="#">
              <div class="input-group">
                <div class="input-group-prepend bg-transparent">
                  <i class="input-group-text border-0 mdi mdi-magnify"></i>
                </div>
                <input type="text" class="form-control bg-transparent border-0" placeholder="Search">
              </div>
            </form>
          </div>
          <ul class="navbar-nav navbar-nav-right">
            <li class="nav-item nav-profile dropdown">
              <a class="nav-link dropdown-toggle" id="profileDropdown" href="#" data-bs-toggle="dropdown" aria-expanded="false">
                <div class="nav-profile-img">
                  <img src="" alt="image">
                  <span class="availability-status online"></span>
                </div>
                <div class="nav-profile-text">
                  <p class="mb-1 text-black">Kalpna stationary</p>
                </div>
              </a>
              <div class="dropdown-menu navbar-dropdown" aria-labelledby="profileDropdown">
                <a class="dropdown-item" href="#">
                  <i class="mdi mdi-cached me-2 text-success"></i> Activity Log </a>
                <div class="dropdown-divider"></div>
                <a class="dropdown-item" href="#">
                  <i class="mdi mdi-logout me-2 text-primary"></i> Signout </a>
              </div>
            </li>
            <li class="nav-item d-none d-lg-block full-screen-link">
              <a class="nav-link">
                <i class="mdi mdi-fullscreen" id="fullscreen-button"></i>
              </a>
            </li>
            <li class="nav-item dropdown">
              <a class="nav-link count-indicator dropdown-toggle" id="messageDropdown" href="#" data-bs-toggle="dropdown" aria-expanded="false">
                <i class="mdi mdi-email-outline"></i>
                <span class="count-symbol bg-warning"></span>
              </a>
              <div class="dropdown-menu dropdown-menu-right navbar-dropdown preview-list" aria-labelledby="messageDropdown">
                <h6 class="p-3 mb-0">Messages</h6>
                <div class="dropdown-divider"></div>
                <a class="dropdown-item preview-item">
                  <div class="preview-thumbnail">
                    <img src="assets/images/faces/face4.jpg" alt="image" class="profile-pic">
                  </div>
                  <div class="preview-item-content d-flex align-items-start flex-column justify-content-center">
                    <h6 class="preview-subject ellipsis mb-1 font-weight-normal">Mark send you a message</h6>
                    <p class="text-gray mb-0"> 1 Minutes ago </p>
                  </div>
                </a>
                <div class="dropdown-divider"></div>
                <a class="dropdown-item preview-item">
                  <div class="preview-thumbnail">
                    <img src="assets/images/faces/face2.jpg" alt="image" class="profile-pic">
                  </div>
                  <div class="preview-item-content d-flex align-items-start flex-column justify-content-center">
                    <h6 class="preview-subject ellipsis mb-1 font-weight-normal">Cregh send you a message</h6>
                    <p class="text-gray mb-0"> 15 Minutes ago </p>
                  </div>
                </a>
                <div class="dropdown-divider"></div>
                <a class="dropdown-item preview-item">
                  <div class="preview-thumbnail">
                    <img src="assets/images/faces/face3.jpg" alt="image" class="profile-pic">
                  </div>
                  <div class="preview-item-content d-flex align-items-start flex-column justify-content-center">
                    <h6 class="preview-subject ellipsis mb-1 font-weight-normal">Profile picture updated</h6>
                    <p class="text-gray mb-0"> 18 Minutes ago </p>
                  </div>
                </a>
                <div class="dropdown-divider"></div>
                <h6 class="p-3 mb-0 text-center">4 new messages</h6>
              </div>
            </li>
            <li class="nav-item dropdown">
              <a class="nav-link count-indicator dropdown-toggle" id="notificationDropdown" href="#" data-bs-toggle="dropdown">
                <i class="mdi mdi-bell-outline"></i>
                <span class="count-symbol bg-danger"></span>
              </a>
              <div class="dropdown-menu dropdown-menu-right navbar-dropdown preview-list" aria-labelledby="notificationDropdown">
                <h6 class="p-3 mb-0">Notifications</h6>
                <div class="dropdown-divider"></div>
                <a class="dropdown-item preview-item">
                  <div class="preview-thumbnail">
                    <div class="preview-icon bg-success">
                      <i class="mdi mdi-calendar"></i>
                    </div>
                  </div>
                  <div class="preview-item-content d-flex align-items-start flex-column justify-content-center">
                    <h6 class="preview-subject font-weight-normal mb-1">Event today</h6>
                    <p class="text-gray ellipsis mb-0"> Just a reminder that you have an event today </p>
                  </div>
                </a>
                <div class="dropdown-divider"></div>
                <a class="dropdown-item preview-item">
                  <div class="preview-thumbnail">
                    <div class="preview-icon bg-warning">
                      <i class="mdi mdi-settings"></i>
                    </div>
                  </div>
                  <div class="preview-item-content d-flex align-items-start flex-column justify-content-center">
                    <h6 class="preview-subject font-weight-normal mb-1">Settings</h6>
                    <p class="text-gray ellipsis mb-0"> Update dashboard </p>
                  </div>
                </a>
                <div class="dropdown-divider"></div>
                <a class="dropdown-item preview-item">
                  <div class="preview-thumbnail">
                    <div class="preview-icon bg-info">
                      <i class="mdi mdi-link-variant"></i>
                    </div>
                  </div>
                  <div class="preview-item-content d-flex align-items-start flex-column justify-content-center">
                    <h6 class="preview-subject font-weight-normal mb-1">Launch Admin</h6>
                    <p class="text-gray ellipsis mb-0"> New admin wow! </p>
                  </div>
                </a>
                <div class="dropdown-divider"></div>
                <h6 class="p-3 mb-0 text-center">See all notifications</h6>
              </div>
            </li>
            <li class="nav-item nav-logout d-none d-lg-block">
              <a class="nav-link" href="#">
                <i class="mdi mdi-power"></i>
              </a>
            </li>
            <li class="nav-item nav-settings d-none d-lg-block">
              <a class="nav-link" href="#">
                <i class="mdi mdi-format-line-spacing"></i>
              </a>
            </li>
          </ul>
          <button class="navbar-toggler navbar-toggler-right d-lg-none align-self-center" type="button" data-toggle="offcanvas">
            <span class="mdi mdi-menu"></span>
          </button>
        </div>
      </nav>
      <!-- partial -->
      <div class="container-fluid page-body-wrapper">
        <!-- partial:partials/_sidebar.html -->
        <nav class="sidebar sidebar-offcanvas" id="sidebar">
          <ul class="nav">
            <li class="nav-item nav-profile">
              <a href="#" class="nav-link">
                <div class="nav-profile-image">
                  <img src="assets/images/logo.jpg" alt="profile">
                  <span class="login-status online"></span>
                  <!--change to offline or busy as needed-->
                </div>
                <div class="nav-profile-text d-flex flex-column">
                  <span class="font-weight-bold mb-2">Prakash</span>
                  <span class="text-secondary text-small">Project Manager</span>
                </div>
                <i class="mdi mdi-bookmark-check text-success nav-profile-badge"></i>
              </a>
            </li>
            <li class="nav-item">
              <a class="nav-link" href="index.html">
                <span class="menu-title"> Dashboard </span>
                <i class="mdi mdi-home menu-icon"></i>
              </a>
            </li>
          
            <li class="nav-item">
              <a class="nav-link" href="pages/forms/basic_elements.html">
                <span class="menu-title">Forms</span>
                <i class="mdi mdi-format-list-bulleted menu-icon"></i>
              </a>
            </li>
           
            <ul class="nav">
           <li class="nav-item">
        <a class="nav-link"  id="tablesMenu">
            <span class="menu-title">Tables</span>
            <i class="mdi mdi-table-large menu-icon"></i>
        </a>    
          <ul class="nav flex-column sub-menu" id="tablesSubMenu">
            <li class="nav-item">
              <a class="nav-link" href="State.aspx">
                <span class="menu-title"> State Table</span>
                <i class="nav flex-column sub-menu"></i>
              </a>
            </li>
            <li class="nav-item">
              <a class="nav-link" href="City.aspx">
                <span class="menu-title"> City Table</span>
                <i class="nav flex-column sub-menu"></i>
              </a>
            </li>
            <li class="nav-item">
              <a class="nav-link" href="Area.aspx">
                <span class="menu-title"> Area Table</span>
                <i class="nav flex-column sub-menu"></i>
              </a>
            </li>
            <li class="nav-item">
              <a class="nav-link" href="Distributer.aspx">
                <span class="menu-title"> Distributer Table</span>
                <i class="nav flex-column sub-menu"></i>
              </a>
            </li>
            <li class="nav-item">
              <a class="nav-link" href="Distributer_details.aspx">
                <span class="menu-title"> Distributer details Table</span>
                <i class="nav flex-column sub-menu"></i>
              </a>
            </li>
           <li class="nav-item">
              <a class="nav-link" href="Distributer_receipt.aspx">
                <span class="menu-title"> Distributer receipt Table</span>
                <i class="nav flex-column sub-menu"></i>
              </a>
            </li>
           <li class="nav-item">
              <a class="nav-link" href="Customer.aspx">
                <span class="menu-title"> Customer Table</span>
                <i class="nav flex-column sub-menu"></i>
              </a>
            </li>
             <li class="nav-item">
              <a class="nav-link" href="Customer_order.aspx">
                <span class="menu-title"> Customer order Table</span>
                <i class="nav flex-column sub-menu"></i>
              </a>
            </li>
             <li class="nav-item">
              <a class="nav-link" href="Customer_receipt.aspx">
                <span class="menu-title"> Customer receipt Table</span>
                <i class="nav flex-column sub-menu"></i>
              </a>
            </li>
            <li class="nav-item">
              <a class="nav-link" href="Employee_details.aspx">
                <span class="menu-title"> Employee details Table</span>
                <i class="nav flex-column sub-menu"></i>
              </a>
            </li>
            <li class="nav-item">
              <a class="nav-link" href="Product.aspx">
                <span class="menu-title"> Product Table</span>
                <i class="nav flex-column sub-menu"></i>
              </a>
            </li>
            <li class="nav-item">
              <a class="nav-link" href="Product_category.aspx">
                <span class="menu-title"> Product category Table</span>
                <i class="nav flex-column sub-menu"></i>
              </a>
            </li>
            <li class="nav-item">
              <a class="nav-link" href="Product_Company.aspx">
                <span class="menu-title"> Product company Table</span>
                <i class="nav flex-column sub-menu"></i>
              </a>
            </li>
            <li class="nav-item">
              <a class="nav-link" href="Product_material.aspx">
                <span class="menu-title"> Product material Table</span>
                <i class="nav flex-column sub-menu"></i>
              </a>
            </li>
             <li class="nav-item">
              <a class="nav-link" href="Sub_categories.aspx">
                <span class="menu-title"> Sub categories Table</span>
                <i class="nav flex-column sub-menu"></i>
              </a>
            </li>
             <li class="nav-item">
              <a class="nav-link" href="Salary.aspx">
                <span class="menu-title"> Salary Table</span>
                <i class="nav flex-column sub-menu"></i>
              </a>
            </li>
           </ul> 
          </ul>
          </ul>
        </nav>
        <!-- partial -->
         <div class="main-panel">
          <div class="content-wrapper">
           <div class="page-header">
              <h3 class="page-title"> Customer Table </h3>
            </div>
              <div class="row">
                <asp:SqlDataSource ID="SqlDataSource1" runat="server" 
        ConnectionString="<%$ ConnectionStrings:ConnectionString %>" 
        SelectCommand="SELECT * FROM [Customer]"></asp:SqlDataSource>
    <asp:GridView ID="GridView1" runat="server" AutoGenerateColumns="False" DataKeyNames="c_id" DataSourceID="SqlDataSource1" OnSelectedIndexChanged="GridView1_SelectedIndexChanged" CssClass="table table-striped">
    <Columns>
        <asp:CommandField ShowSelectButton="True" ItemStyle-Width="100px" />
        <asp:BoundField DataField="c_id" HeaderText="c_id" ReadOnly="True" 
            SortExpression="c_id" ItemStyle-Width="100px" >
<ItemStyle Width="100px"></ItemStyle>
        </asp:BoundField>
        <asp:BoundField DataField="pincode" HeaderText="pincode" 
            SortExpression="pincode" ItemStyle-Width="100px" >
<ItemStyle Width="100px"></ItemStyle>
        </asp:BoundField>
        <asp:BoundField DataField="c_name" HeaderText="c_name" SortExpression="c_name" 
            ItemStyle-Width="100px" >
<ItemStyle Width="100px"></ItemStyle>
        </asp:BoundField>
        <asp:BoundField DataField="gender" HeaderText="gender" SortExpression="gender" 
            ItemStyle-Width="100px" >
<ItemStyle Width="100px"></ItemStyle>
        </asp:BoundField>
        <asp:BoundField DataField="c_mobileno" HeaderText="c_mobileno" 
            SortExpression="c_mobileno" ItemStyle-Width="100px" >
<ItemStyle Width="100px"></ItemStyle>
        </asp:BoundField>
        <asp:BoundField DataField="email" HeaderText="email" SortExpression="email" 
            ItemStyle-Width="100px" >
<ItemStyle Width="100px"></ItemStyle>
        </asp:BoundField>
        <asp:BoundField DataField="password" HeaderText="password" 
            SortExpression="password" ItemStyle-Width="100px" >
<ItemStyle Width="100px"></ItemStyle>
        </asp:BoundField>
        <asp:BoundField DataField="address" HeaderText="address" 
            SortExpression="address" ItemStyle-Width="100px" >
<ItemStyle Width="100px"></ItemStyle>
        </asp:BoundField>
    </Columns>
        <FooterStyle BackColor="White" ForeColor="#000066" />
        <HeaderStyle BackColor="#006699" Font-Bold="True" ForeColor="White" />
        <PagerStyle BackColor="White" ForeColor="#000066" HorizontalAlign="Left" />
        <RowStyle ForeColor="#000066" />
        <SelectedRowStyle BackColor="#669999" Font-Bold="True" ForeColor="White" />
</asp:GridView>

    <p>
        &nbsp;</p>
    <table class="w-100">
        <tr>
            <td>
                C_id</td>
            <td>
                <asp:TextBox ID="TextBox1" runat="server" class="form-control"></asp:TextBox>
            </td>
        </tr>
        <tr>
            <td>
                Pincode</td>
            <td>
                <asp:DropDownList ID="DropDownList1" runat="server" class="form-control"
                    DataSourceID="SqlDataSource2" DataTextField="area_name" 
                    DataValueField="pincode">
                </asp:DropDownList>
                <br />
                <asp:SqlDataSource ID="SqlDataSource2" runat="server" 
                    ConnectionString="<%$ ConnectionStrings:ConnectionString %>" 
                    SelectCommand="SELECT [pincode], [area_name] FROM [Area]"></asp:SqlDataSource>
            </td>
        </tr>
        <tr>
            <td>
                C_name</td>
            <td>
                <asp:TextBox ID="TextBox2" runat="server" class="form-control"></asp:TextBox>
            </td>
        </tr>
        <tr>
            <td>
                Gender</td>
            <td>
                <asp:TextBox ID="TextBox3" runat="server" class="form-control"></asp:TextBox>
            </td>
        </tr>
        <tr>
            <td>
                Mobileno</td>
            <td>
                <asp:TextBox ID="TextBox4" runat="server" class="form-control"></asp:TextBox>
            </td>
        </tr>
        <tr>
            <td>
                email</td>
            <td>
                <asp:TextBox ID="TextBox5" runat="server" class="form-control"></asp:TextBox>
            </td>
        </tr>
        <tr>
            <td>
                password</td>
            <td>
                <asp:TextBox ID="TextBox6" runat="server" class="form-control"></asp:TextBox>
            </td>
        </tr>
        <tr>
            <td>
                address</td>
            <td>
                <asp:TextBox ID="TextBox7" runat="server" class="form-control"></asp:TextBox>
               
                
            </td>
        </tr>
        <tr>
            <td colspan="2" align="center">
               
               
                <asp:Button ID="btndlt" runat="server" CssClass="btn btn-info" onclick="btndlt_Click" Text="Delete" />
                <br />
               
            </td>
        </tr>
    </table> 
      <!-- page-body-wrapper ends -->
    </div>
    <!-- container-scroller -->
    <!-- plugins:js -->
    <script src="assets/vendors/js/vendor.bundle.base.js"></script>
    <!-- endinject -->
    <!-- Plugin js for this page -->
    <!-- End plugin js for this page -->
    <!-- inject:js -->
    <script src="assets/js/off-canvas.js"></script>
    <script src="assets/js/hoverable-collapse.js"></script>
    <script src="assets/js/misc.js"></script>
    </div>
    </div>
    </form>
    </div>
   
</body>
</html>
