<%@ Page Language="C#" AutoEventWireup="true" CodeFile="login.aspx.cs" Inherits="Employee_loginaspx" %>

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
        <div class="container-scroller">
            <div class="container-fluid page-body-wrapper full-page-wrapper">
                <div class="content-wrapper d-flex align-items-center auth">
                    <div class="row flex-grow">
                        <div class="col-lg-4 mx-auto">
                            <div class="auth-form-light text-left p-5">
                                <div class="brand-logo d-flex justify-content-center align-items-center">
                                    <img src="../assets/images/logo.jpg" />
                                </div>
                                <h4> LOGIN</h4>
                                <div class="form-group">
                                    <asp:TextBox ID="TextBox1" runat="server" CssClass="form-control form-control-lg" placeholder="Username"></asp:TextBox>
                                </div>
                                <div class="form-group">
                                    <asp:TextBox ID="TextBox2" runat="server" TextMode="Password" CssClass="form-control form-control-lg" placeholder="Password"></asp:TextBox>
                                </div>
                                <div class="mt-3" align="center">
                                    <asp:Button ID="Button1" runat="server" Text="SIGN IN" CssClass="btn btn-block btn-gradient-primary btn-lg font-weight-medium auth-form-btn" OnClick="btnLogin_Click" />
                                </div>
                                
                            </div>
                        </div>
                    </div>
                </div>
                <!-- content-wrapper ends -->
            </div>
            <!-- page-body-wrapper ends -->
        </div>
        <!-- container-scroller -->
    </form>
</body>
</html>
