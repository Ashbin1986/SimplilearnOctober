<%@ Page Title="About" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="About.aspx.cs" Inherits="SimpliLearn.AspNet.Sample.About" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">
<div>
    <asp:Label ID="lblUserName" runat="server"></asp:Label>
    <asp:Button ID="btnLogout" runat="server" Text="Logout" OnClick="btnLogout_Click" />
</div>
</asp:Content>
