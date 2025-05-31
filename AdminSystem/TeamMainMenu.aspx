<%@ Page Language="C#" AutoEventWireup="true" CodeFile="TeamMainMenu.aspx.cs" Inherits="TeamMainMenu" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <asp:Label ID="lblMenu" runat="server" Text="AI Agent Main Menu "></asp:Label>
            <br />
            <br />
            <asp:Button ID="btnAgents" runat="server" OnClick="btnAgents_Click" Text="Agents" />
            <asp:Button ID="btnCustomers" runat="server" OnClick="btnCustomers_Click" Text="Customers" />
        </div>
    </form>
</body>
</html>
