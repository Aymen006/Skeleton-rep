<%@ Page Language="C#" AutoEventWireup="true" CodeFile="AgnList.aspx.cs" Inherits="_1_List" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
        </div>
        <asp:ListBox ID="lstAgentList" runat="server" Height="478px" Width="672px"></asp:ListBox>
        <p>
            <asp:Button ID="btnAdd" runat="server" OnClick="btnAdd_Click" Text="Add" />
            <asp:Button ID="btnEdit" runat="server" OnClick="btnEdit_Click" Text="Edit" />
            <asp:Button ID="btnDelete" runat="server" OnClick="btnDelete_Click" Text="Delete" />
        </p>
        <p>
            <asp:Label ID="lblCategory" runat="server" Text="Enter A Category"></asp:Label>
            <asp:TextBox ID="txtFilter" runat="server" Height="20px"></asp:TextBox>
        </p>
        <p>
            <asp:Button ID="btnApply" runat="server" OnClick="btnApply_Click" Text="Apply Filter" />
            <asp:Button ID="btnClear" runat="server" OnClick="btnClear_Click" Text="Clear Filter" />
        </p>
        <p>
            <asp:Button ID="btnRetourMenu" runat="server" OnClick="btnRetourMenu_Click" Text="Retour to Main Menu" />
        </p>
        <p>
            &nbsp;</p>
        <p>
            <asp:Label ID="lblError" runat="server"></asp:Label>
        </p>
    </form>
</body>
</html>
