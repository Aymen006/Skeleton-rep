<%@ Page Language="C#" AutoEventWireup="true" CodeFile="CusList.aspx.cs" Inherits="_1_List" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body style="height: 483px">
    <form id="form1" runat="server">
        <div style="height: 397px; width: 705px">
            <asp:ListBox ID="lstCustomerList" runat="server" Height="409px" Width="387px"></asp:ListBox>
        </div>
        <p>
            <asp:Button ID="btnAdd" runat="server" OnClick="btnAdd_Click" Text="Add" Width="72px" />
            <asp:Button ID="btnEdit" runat="server" Height="24px" OnClick="btnEdit_Click" Text="Edit" Width="91px" />
        </p>
    </form>
</body>
</html>
