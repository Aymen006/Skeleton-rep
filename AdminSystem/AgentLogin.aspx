<%@ Page Language="C#" AutoEventWireup="true" CodeFile="AgentLogin.aspx.cs" Inherits="AgentLogin" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
        </div>
        <br />
        <br />
        <br />
        <asp:Label ID="lblLogin" runat="server" Text="Agent Login Page"></asp:Label>
        <p>
            <asp:Label ID="lblUserName" runat="server" Text="UserName"></asp:Label>
            <asp:TextBox ID="txtUserName" runat="server"></asp:TextBox>
        </p>
        <p>
            <asp:Label ID="lblPassword" runat="server" Text="Password"></asp:Label>
            <asp:TextBox ID="txtPassword" runat="server" TextMode="Password"></asp:TextBox>
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
            <asp:Label ID="lblError" runat="server" ForeColor="#FF3300"></asp:Label>
        </p>
        <p>
            &nbsp;</p>
        <p>
            <asp:Button ID="btnLogin" runat="server" OnClick="Button1_Click" Text="Login" />
            <asp:Button ID="btnCancel" runat="server" Text="Cancel" OnClick="btnCancel_Click" />
        </p>
    </form>
</body>
</html>
