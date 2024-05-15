<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Login.aspx.cs" Inherits="Customer1_Login" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
        <meta charset="utf-8" />
        <meta name="viewport" content="width=device-width, initial-scale=1, shrink-to-fit=no" />
        <meta name="description" content="" />
        <meta name="author" content="" />
        <title>Freelancer - Start Bootstrap Theme</title>
        <!-- Favicon-->
        <link rel="icon" type="image/x-icon" href="assets/favicon.ico" />
        <!-- Font Awesome icons (free version)-->
        <script src="https://use.fontawesome.com/releases/v6.3.0/js/all.js" crossorigin="anonymous"></script>
        <!-- Google fonts-->
        <link href="https://fonts.googleapis.com/css?family=Montserrat:400,700" rel="stylesheet" type="text/css" />
        <link href="https://fonts.googleapis.com/css?family=Lato:400,700,400italic,700italic" rel="stylesheet" type="text/css" />
        <!-- Core theme CSS (includes Bootstrap)-->
        <link href="css/styles.css" rel="stylesheet" />
    <script language="javascript" type="text/javascript">
// <![CDATA[

        function submitButton_onclick() {

        }

// ]]>
    </script>
</head>
<body id="page-top">
    <form id="form1" runat="server">
    <div>
        <!-- Masthead-->
        <header class="masthead bg-primary text-white text-center py-3">
            <div class="container d-flex align-items-center flex-column">
                <!-- Masthead Avatar Image-->
                <img class="masthead-avatar mb-3 rounded-circle" src="../Images/logo.jpg" alt="..." />
                <!-- Masthead Heading-->
                <h1 class="masthead-heading text-uppercase mb-0 fs-4"> Kalpna Stationary </h1>
                <!-- Icon Divider-->
                <div class="divider-custom divider-light mb-3">
                    <div class="divider-custom-line"></div>
                    <div class="divider-custom-icon"><i class="fas fa-star"></i></div>
                    <div class="divider-custom-line"></div>
                </div>
                <h2 class="fs-5"> Login </h2>
                <!-- Masthead Subheading-->   
            </div>
        </header>
        <form id="contactForm" data-sb-form-api-token="API_TOKEN">
             <main class="container">
                <section class="row">
                <div class="col-md-6 offset-md-3">
                  <div class="card">
                    <div class="card-body" align="center">
              <!-- Email address input-->
                 <div class="form-floating mb-3">
                    <asp:Label ID="EmailLabel" runat="server" AssociatedControlID="TextBox1">Email address</asp:Label>
                    <br />
                      <br />
                <br />
                    <asp:TextBox ID="TextBox1" runat="server" style="width: 100%; padding: 8px; border: 1px solid #ccc; border-radius: 4px; box-sizing: border-box;" placeholder="Enter your email address"></asp:TextBox>
                    <asp:RegularExpressionValidator ID="EmailValidator" runat="server" ControlToValidate="TextBox1"
                        ValidationExpression="^[a-zA-Z0-9._%+-]+@[a-zA-Z0-9.-]+\.[a-zA-Z]{2,}$" ErrorMessage="Email is not valid."
                        ValidationGroup="EmailValidationGroup"></asp:RegularExpressionValidator>
                    <asp:RequiredFieldValidator ID="EmailRequiredValidator" runat="server" ControlToValidate="TextBox1"
                        ErrorMessage="An email is required." ValidationGroup="EmailValidationGroup"></asp:RequiredFieldValidator>
                </div>
               
               <!-- Password input-->
              <div class="form-floating mb-3 text-center">
                <asp:Label ID="PasswordLabel" runat="server" AssociatedControlID="TextBox2">Password</asp:Label>
                <br />
                  <br />
                <br />
                <asp:TextBox ID="TextBox2" runat="server" style="width: 100%; padding: 8px; border: 1px solid #ccc; border-radius: 4px; box-sizing: border-box;" TextMode="Password" placeholder="Enter password"></asp:TextBox>
                <asp:RequiredFieldValidator ID="PasswordRequiredValidator" runat="server" ControlToValidate="TextBox2" ErrorMessage="A password is required." ValidationGroup="PasswordValidationGroup"></asp:RequiredFieldValidator>
            </div>
               
               <!-- Submit Button-->
               
                <asp:Button CssClass="btn btn-primary btn-xl" ID="btnlogin" 
                   runat="server" Text="Login" onclick="btnlogin_Click"  />
                </div>
              </div>
            </div>
            </main>
        </form>
    </div>
    </form>
</body>
</html>
