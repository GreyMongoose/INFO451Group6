﻿<%@ Page Language="C#" AutoEventWireup="true" CodeFile="customerDisplay.aspx.cs" Inherits="customerDisplay" %>

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
        <asp:Label ID="Label1" runat="server" Text="Customers"></asp:Label>
    
    </div>
    <asp:GridView ID="customerView" runat="server">
    </asp:GridView>
    <br />
    <br />
    <asp:Label ID="Label2" runat="server" Text="Admins"></asp:Label>
    <asp:GridView ID="adminView" runat="server">
    </asp:GridView>
    </form>
</body>
</html>
