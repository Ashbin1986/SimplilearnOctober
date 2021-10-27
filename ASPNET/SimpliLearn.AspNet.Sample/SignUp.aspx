<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="SignUp.aspx.cs" Inherits="SimpliLearn.AspNet.Sample.SignUp" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <link href="Content/bootstrap.css" rel="stylesheet" />
</head>
<body>
    <form id="form1" runat="server">
        <div class="col-lg-3">
            <div class="form-group">
                <label for="txtFirstName">First Name:</label>
                <asp:TextBox ID="txtFirstName" runat="server" class="form-control"></asp:TextBox>
                <asp:RequiredFieldValidator ID="reqtxtFirstName" runat="server"
                    ErrorMessage="FirstName is required"  ForeColor="Red" ControlToValidate="txtFirstName" ></asp:RequiredFieldValidator>
            </div>
            <div class="form-group">
                <label for="txtLastName">LastName:</label>
                <asp:TextBox ID="txtLastName" runat="server" class="form-control"></asp:TextBox>
                 <asp:RequiredFieldValidator ID="reqtxtLastName" runat="server" ForeColor="Red" ControlToValidate="txtLastName"
                    ErrorMessage="*"></asp:RequiredFieldValidator>
            </div>
             <div class="form-group">
                <label for="txtEmail">Email:</label>
                <asp:TextBox ID="txtEmail" runat="server" class="form-control" ></asp:TextBox>
                   <asp:RequiredFieldValidator ID="reqtxtEmail" runat="server" ForeColor="Red" ControlToValidate="txtEmail"
                    ErrorMessage="*"></asp:RequiredFieldValidator>
                 <asp:RegularExpressionValidator ID="regextxtEmail" ControlToValidate="txtEmail" ForeColor="Red" runat="server" ErrorMessage="Invalid email address!." ValidationExpression="\w+([-+.']\w+)*@\w+([-.]\w+)*\.\w+([-.]\w+)*" ></asp:RegularExpressionValidator>
            </div>
            <div class="form-group">
                <label for="txtAge">Age:</label>
                <asp:TextBox ID="txtAge" runat="server" class="form-control"></asp:TextBox>
                       <asp:RequiredFieldValidator ID="reqtxtAge" runat="server" ForeColor="Red" ControlToValidate="txtAge"
                    ErrorMessage="*"></asp:RequiredFieldValidator>
                <asp:RangeValidator ID="RangeValidator1" runat="server" ControlToValidate="txtAge" ForeColor="Red"  ErrorMessage="Age must be between 25 to 40" MaximumValue="40" MinimumValue="25" Type="Integer"></asp:RangeValidator>
            </div>
             <div class="form-group">
                <label for="gender">Gender:</label>
                 <asp:RadioButton ID="rdbMale" runat="server" GroupName="gender" /> Male
                 <asp:RadioButton ID="rdbFeMale" runat="server" GroupName="gender" /> FeMale
            </div>
             <div class="form-group">
                <label for="txtPassword">Password:</label>
                <asp:TextBox ID="txtPassword" runat="server" class="form-control" TextMode="Password"></asp:TextBox>
                       <asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server" ForeColor="Red" ControlToValidate="txtAge"
                    ErrorMessage="*"></asp:RequiredFieldValidator>
            </div>
            <div class="form-group">
                <label for="txtConfirmPwd"> Confirm Password:</label>
                <asp:TextBox ID="txtConfirmPwd" runat="server" class="form-control" TextMode="Password" ></asp:TextBox>
                       <asp:RequiredFieldValidator ID="RequiredFieldValidator2" runat="server" ForeColor="Red" ControlToValidate="txtAge"
                    ErrorMessage="*"></asp:RequiredFieldValidator>
                <asp:CompareValidator ID="CompareValidator1" runat="server" ForeColor="Red" ControlToValidate="txtConfirmPwd" ControlToCompare="txtPassword" ErrorMessage="Password & Confirm paasword must be same"></asp:CompareValidator>
            </div>
            <div class="form-group">
                <asp:Button ID="btnRegister" runat="server" Text="Register" />
                <asp:ValidationSummary ID="ValidationSummary1" runat="server" />
            </div>

        </div>
    </form>
</body>
</html>
