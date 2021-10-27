<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Controls.aspx.cs" Inherits="SimpliLearn.AspNet.Sample.Controls" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>

            HyperLink Example :<br />
            <br />
            <asp:HyperLink ID="HyperLink1" runat="server" NavigateUrl="~/WebFormDay1.aspx">Home</asp:HyperLink>

        </div>

        <div>

            LinkButtom Example :<br />
            <br />
            <asp:LinkButton ID="lnkSubmit" runat="server" OnClick="lnkSubmit_Click">SUbmit</asp:LinkButton>

        </div>

             <div>

            ImageButton Example :<br />
            <br />
           
                 <asp:ImageButton ID="ImageButton1" ImageUrl="~/Files/2021-10-27 15_31_45-AsBorder.png" Width="150"  runat="server" OnClick="ImageButton1_Click" />
        </div>
        <asp:DropDownList ID="ddlCountry" runat="server" OnSelectedIndexChanged="ddlCountry_SelectedIndexChanged" AutoPostBack="true">
                 <asp:ListItem Text="India" Value="IND"></asp:ListItem>
                 <asp:ListItem Text="UAE" Value="UAE"></asp:ListItem>

             </asp:DropDownList>
        <asp:HiddenField ID="hdnEmpId" runat="server" />
             
        <asp:Image ID="Image1" runat="server" ImageUrl="~/Files/2021-10-27 15_31_45-AsBorder.png" ToolTip="Plz Subscribe me" AlternateText="Image not found" />
      <%--  <asp:Calendar ID="Calendar1" runat="server" BackColor="White" BorderColor="White" BorderWidth="1px" Font-Names="Verdana" Font-Size="9pt" ForeColor="Black" Height="190px" NextPrevFormat="FullMonth" Width="350px">
            <DayHeaderStyle Font-Bold="True" Font-Size="8pt" />
            <NextPrevStyle Font-Bold="True" Font-Size="8pt" ForeColor="#333333" VerticalAlign="Bottom" />
            <OtherMonthDayStyle ForeColor="#999999" />
            <SelectedDayStyle BackColor="#333399" ForeColor="White" />
            <TitleStyle BackColor="White" BorderColor="Black" BorderWidth="4px" Font-Bold="True" Font-Size="12pt" ForeColor="#333399" />
            <TodayDayStyle BackColor="#CCCCCC" />
        </asp:Calendar>--%>

    </form>
</body>
</html>
