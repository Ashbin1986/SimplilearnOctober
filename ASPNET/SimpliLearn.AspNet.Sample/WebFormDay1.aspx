<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="WebFormDay1.aspx.cs" Inherits="SimpliLearn.AspNet.Sample.WebFormDay1" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
<div>
    File Upload : <asp:FileUpload ID="fileuploadImage" runat="server" />
    <asp:Button ID="btnSave" runat="server" Text="Save" BackColor="#FF9966" OnClick="btnSave_Click" />
    <asp:Image ID="img" runat="server" />
    <br />
    <br />
    <asp:Label ID="lblError" runat="server" ></asp:Label>
</div>
    </form>
</body>
</html>
