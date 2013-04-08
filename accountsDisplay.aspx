<%@ Page Language="C#" AutoEventWireup="true" CodeFile="accountsDisplay.aspx.cs" Inherits="accountsDisplay" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">

    <div>
        <asp:HyperLink ID="HyperLink1" runat="server" NavigateUrl="~/Deliverable2/Default.aspx">Return Home</asp:HyperLink>
        <br />
        <asp:Label ID="Label1" runat="server" Text="Hosting Accounts"></asp:Label>
    
    </div>
    <p>
        <asp:GridView ID="hostingView" runat="server">
        </asp:GridView>
    </p>
    <p>
        &nbsp;</p>
    <asp:Label ID="Label2" runat="server" Text="Storage Accounts"></asp:Label>
    <br />
    <asp:GridView ID="storageView" runat="server">
    </asp:GridView>
    <br />
    <br />
    <asp:Label ID="Label3" runat="server" Text="Management Accounts"></asp:Label>
    <asp:GridView ID="managementView" runat="server">
    </asp:GridView>
    </form>
</body>
</html>
