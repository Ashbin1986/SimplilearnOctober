<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="EmployeeDetails.aspx.cs" Inherits="SimpliLearnWebServiceClient.EmployeeDetails" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <asp:TextBox ID="txtName" runat="server" placeholder="Name"></asp:TextBox>
        </div>
        <div>
            <asp:TextBox ID="txtDesgnation" runat="server" placeholder="Designation"></asp:TextBox>
        </div>
        <asp:Button ID="AddEmployee" runat="server" Text="Add Employee" OnClick="AddEmployee_Click" />
    </form>
</body>
</html>
