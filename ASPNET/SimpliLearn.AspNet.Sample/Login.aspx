<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Login.aspx.cs" Inherits="SimpliLearn.AspNet.Sample.Login" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <link href="Content/bootstrap.css" rel="stylesheet" />
</head>
<body>
    <form id="form1" runat="server">
        <asp:Panel ID="Panel1" runat="server">
            <div class="col-lg-3">
                <div class="form-group">
                    <label for="txtUserName">User Name:</label>
                    <asp:TextBox ID="txtUserName" runat="server" class="form-control"></asp:TextBox>
                    <asp:RequiredFieldValidator ID="reqtxtFirstName" runat="server"
                        ErrorMessage="User name is required" ForeColor="Red" ControlToValidate="txtUserName"></asp:RequiredFieldValidator>
                </div>
                <div class="form-group">
                    <label for="txtUserName">Password:</label>
                    <asp:TextBox ID="txtPassword" runat="server" class="form-control"></asp:TextBox>
                    <asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server"
                        ErrorMessage="Passwrd is required" ForeColor="Red" ControlToValidate="txtPassword"></asp:RequiredFieldValidator>
                </div>
                <div class="form-group">
                    <label for="chkRememberMe">Remember me:</label>
                    <asp:CheckBox ID="chkRememberMe" runat="server" />
                   
                </div>
                <div class="form-group">
                    <asp:Button ID="btnLogin" runat="server" Text="Login" OnClick="btnLogin_Click" />
                    <span id="spError" runat="server"></span>
                </div>
            </div>
        </asp:Panel>
    </form>
</body>
</html>
