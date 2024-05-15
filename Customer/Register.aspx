<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Register.aspx.cs" Inherits="Customer1_Register" %>

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
        
   
</head>
<body>
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
                <h2 class="fs-5"> Registration </h2>
                <!-- Masthead Subheading-->   
            </div>
        </header>
        <form id="contactForm" data-sb-form-api-token="API_TOKEN">
               
           <main class="container">
            <section class="row">
            <div class="col-md-6 offset-md-3">
                <div class="card">
                    <div class="card-body" align="center">
                   
               <!-- Name input-->
               <div class="form-floating mb-1">
                    <asp:Label ID="NameLabel" runat="server" AssociatedControlID="NameTextBox">Name</asp:Label>
                    <br />
                     <br />
                      <br />
                    <asp:TextBox ID="NameTextBox" runat="server"  style="width: 100%; padding: 8px; border: 1px solid #ccc; border-radius: 4px; box-sizing: border-box;" placeholder="Enter your name..."></asp:TextBox>

                    <asp:RequiredFieldValidator ID="NameRequiredValidator" runat="server" ControlToValidate="NameTextBox" ErrorMessage="A name is required." ValidationGroup="NameValidationGroup"></asp:RequiredFieldValidator>
                </div>

                <!-- Pincode input-->
              <div class="form-floating mb-1">
                <label for="TextBox1">Pincode</label>
                <br />
                <br />
                <br />
                <asp:TextBox ID="TextBox1" runat="server" style="width: 100%; padding: 8px; border: 1px solid #ccc; border-radius: 4px; box-sizing: border-box;" placeholder="Enter your pincode..." TextMode="SingleLine"></asp:TextBox>
                <asp:RequiredFieldValidator ID="PincodeRequiredValidator" runat="server" ControlToValidate="TextBox1" ErrorMessage="Pincode is required." ValidationGroup="PincodeValidationGroup"></asp:RequiredFieldValidator>
                <asp:RegularExpressionValidator ID="PincodeNumberValidator" runat="server" ControlToValidate="TextBox1" ErrorMessage="Pincode must be a number." ValidationExpression="^\d+$" ValidationGroup="PincodeValidationGroup"></asp:RegularExpressionValidator>
                <asp:RegularExpressionValidator ID="PincodeLengthValidator" runat="server" ControlToValidate="TextBox1" ErrorMessage="Pincode must be exactly 6 digits long." ValidationExpression="^\d{6}$" ValidationGroup="PincodeValidationGroup"></asp:RegularExpressionValidator>
            </div>
            
             <style>
                .form-floating.mb-3,
                .form-select {
                    margin-bottom: 0rem; /* Adjust this value as needed */
                }
            </style>

            <!-- Gender input (ASP.NET DropDownList) -->
            

            <div class="form-floating mb-3">
                <asp:Label ID="Label2" runat="server" AssociatedControlID="GenderDropDownList">Gender</asp:Label>
                    <br />
                <br />
                <br />
                <asp:DropDownList ID="GenderDropDownList" runat="server" style="width: 100%; padding: 8px; border: 1px solid #ccc; border-radius: 4px; box-sizing: border-box;" DataTextField="Text" DataValueField="Value">
                    <asp:ListItem Text="Select gender..." Value="" />
                    <asp:ListItem Text="Male" Value="Male" />
                    <asp:ListItem Text="Female" Value="Female" />
                    <asp:ListItem Text="Other" Value="Other" />
                </asp:DropDownList>
                <asp:RequiredFieldValidator ID="GenderRequiredValidator" runat="server" ControlToValidate="GenderDropDownList" InitialValue="" ErrorMessage="Please select a gender." ValidationGroup="GenderValidationGroup"></asp:RequiredFieldValidator>
            </div>


                <!-- Phone number input-->
                 <div class="form-floating mb-3">
                    <asp:Label ID="PhoneLabel" runat="server" AssociatedControlID="TextBox4">Phone number</asp:Label>
                    <br />
                      <br />
                <br />
                    <asp:TextBox ID="TextBox4" runat="server" style="width: 100%; padding: 8px; border: 1px solid #ccc; border-radius: 4px; box-sizing: border-box;" placeholder="Enter your phone number"></asp:TextBox>
                    <asp:RegularExpressionValidator ID="PhoneNumberValidator" runat="server" ControlToValidate="TextBox4"
                        ValidationExpression="^\d{10}$" ErrorMessage="Phone number must be 10 digits." ValidationGroup="PhoneNumberValidationGroup"></asp:RegularExpressionValidator>
                    <asp:RequiredFieldValidator ID="PhoneNumberRequiredValidator" runat="server" ControlToValidate="TextBox4"
                        ErrorMessage="A phone number is required." ValidationGroup="PhoneNumberValidationGroup"></asp:RequiredFieldValidator>
                </div>

                 <!-- Email address input-->
                 <div class="form-floating mb-3">
                    <asp:Label ID="EmailLabel" runat="server" AssociatedControlID="TextBox5">Email address</asp:Label>
                    <br />
                      <br />
                <br />
                    <asp:TextBox ID="TextBox5" runat="server" style="width: 100%; padding: 8px; border: 1px solid #ccc; border-radius: 4px; box-sizing: border-box;" placeholder="Enter your email address"></asp:TextBox>
                    <asp:RegularExpressionValidator ID="EmailValidator" runat="server" ControlToValidate="TextBox5"
                        ValidationExpression="^[a-zA-Z0-9._%+-]+@[a-zA-Z0-9.-]+\.[a-zA-Z]{2,}$" ErrorMessage="Email is not valid."
                        ValidationGroup="EmailValidationGroup"></asp:RegularExpressionValidator>
                    <asp:RequiredFieldValidator ID="EmailRequiredValidator" runat="server" ControlToValidate="TextBox5"
                        ErrorMessage="An email is required." ValidationGroup="EmailValidationGroup"></asp:RequiredFieldValidator>
                </div>

               
               <!-- Password input-->
              <div class="form-floating mb-3 text-center">
                <asp:Label ID="PasswordLabel" runat="server" AssociatedControlID="TextBox6">Password</asp:Label>
                <br />
                  <br />
                <br />
                <asp:TextBox ID="TextBox6" runat="server" style="width: 100%; padding: 8px; border: 1px solid #ccc; border-radius: 4px; box-sizing: border-box;" TextMode="Password" placeholder="Enter password"></asp:TextBox>
                <asp:RequiredFieldValidator ID="PasswordRequiredValidator" runat="server" ControlToValidate="TextBox6" ErrorMessage="A password is required." ValidationGroup="PasswordValidationGroup"></asp:RequiredFieldValidator>
            </div>


                <!-- Address input-->
                 <div class="form-floating mb-3">
                    <asp:Label ID="AddressLabel" runat="server" AssociatedControlID="TextBox7">Address</asp:Label>
                    <br />
                      <br />
                <br />
                    <asp:TextBox ID="TextBox7" runat="server" style="width: 100%; padding: 8px; border: 1px solid #ccc; border-radius: 4px; box-sizing: border-box;" TextMode="MultiLine" Rows="4" Placeholder="Enter your address..."></asp:TextBox>
                    <asp:RequiredFieldValidator ID="AddressRequiredValidator" runat="server" ControlToValidate="TextBox7" ErrorMessage="Address is required." ValidationGroup="AddressValidationGroup"></asp:RequiredFieldValidator>
                </div>


               
               <!-- Submit Button-->
                <asp:Button CssClass="btn btn-primary btn-xl" ID="btnlogin" runat="server" Text="Submit" onclick="btnlogin_Click"  PostBackUrl="~/Customer1/Product.aspx" />
                 <div class="text-center mt-4 font-weight-light"> Already have an account? <a href="Login.aspx" class="text-primary">Login</a>
                  </div>
             </div> 
            </div>
           </div>
           </main>
           
        </form>
    </div>
    </form>
</body>
</html>
