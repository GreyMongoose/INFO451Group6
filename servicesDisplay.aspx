<%@ Page Language="C#" AutoEventWireup="true" CodeFile="servicesDisplay.aspx.cs" Inherits="servicesDisplay" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
    <asp:HyperLink ID="HyperLink1" runat="server" NavigateUrl="~/Default.aspx">Return Home</asp:HyperLink>
        <br />
    </div>
    <asp:Button ID="Button1" runat="server" onclick="Button1_Click" 
        Text="View Service Categories" />
    <br />
    <br />
    <asp:Label ID="Label2" runat="server" Text="Service Categories"></asp:Label>
    <br />
    <asp:GridView ID="categoriesView" runat="server" CellPadding="4" 
        ForeColor="#333333" GridLines="None" ShowHeader="False" 
        style="text-align: left">
        <AlternatingRowStyle BackColor="White" />
        <EditRowStyle BackColor="#7C6F57" />
        <FooterStyle BackColor="#1C5E55" Font-Bold="True" ForeColor="White" />
        <HeaderStyle BackColor="#1C5E55" Font-Bold="True" ForeColor="White" />
        <PagerStyle BackColor="#666666" ForeColor="White" HorizontalAlign="Center" />
        <RowStyle BackColor="#E3EAEB" />
        <SelectedRowStyle BackColor="#C5BBAF" Font-Bold="True" ForeColor="#333333" />
        <SortedAscendingCellStyle BackColor="#F8FAFA" />
        <SortedAscendingHeaderStyle BackColor="#246B61" />
        <SortedDescendingCellStyle BackColor="#D4DFE1" />
        <SortedDescendingHeaderStyle BackColor="#15524A" />
    </asp:GridView>
    <br />
    <asp:Button ID="Button2" runat="server" onclick="Button2_Click" 
        Text="Show Hosting Services" />
    <asp:Button ID="Button3" runat="server" onclick="Button3_Click" 
        Text="Show Storage Services" />
    <asp:Button ID="Button4" runat="server" onclick="Button4_Click" 
        Text="Show Management Services" />
    <br />
    <asp:Label ID="Label1" runat="server"></asp:Label>
    <asp:GridView ID="serviceView" runat="server">
    </asp:GridView>
    <br />
    </form>
</body>
</html>
