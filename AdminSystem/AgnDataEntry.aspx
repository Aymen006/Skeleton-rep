<%@ Page Language="C#" AutoEventWireup="true" CodeFile="AgnDataEntry.aspx.cs" Inherits="_1_DataEntry" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <p>
            <asp:Label ID="lblAgentId" runat="server" style="z-index: 1; left: 12px; position: absolute; top: 96px; right: 1412px" Text="AgentId"></asp:Label>
             <asp:TextBox ID="txtAgentId" runat="server" OnTextChanged="TextBox1_TextChanged" style="z-index: 1; left: 122px; top: 88px; position: absolute; height: 22px; width: 125px; right: 1134px;"></asp:TextBox>
        </p>
        <p>
            <asp:TextBox ID="txtAgentName" runat="server" height="22px" style="z-index: 1; left: 121px; top: 125px; position: absolute" width="128px"></asp:TextBox>
            <asp:Label ID="lblAgentName" runat="server" style="z-index: 1; left: 13px; top: 125px; position: absolute" Text="Agent Name" width="49px"></asp:Label>
            <asp:Button ID="btnFind" runat="server" Height="26px" OnClick="btnFind_Click" Text="Find" Width="38px" />
        </p>
        <p>
            <asp:TextBox ID="txtDescription" runat="server" height="22px" style="z-index: 1; left: 121px; top: 165px; position: absolute" width="128px"></asp:TextBox>
            <asp:Label ID="lblDescription" runat="server" style="z-index: 1; left: 12px; top: 165px; position: absolute" Text="Description" width="49px"></asp:Label>
        </p>
        <p>
            <asp:Label ID="lblCategory" runat="server" style="z-index: 1; left: 12px; top: 205px; position: absolute" Text="Category" width="49px"></asp:Label>
            <asp:TextBox ID="txtCategory" runat="server" height="22px" style="z-index: 1; left: 121px; top: 204px; position: absolute" width="128px"></asp:TextBox>
        </p>
        <p>
            <asp:Label ID="lblIntegration" runat="server" style="z-index: 1; left: 12px; top: 243px; position: absolute" Text="Integration Type" width="49px"></asp:Label>
            <asp:TextBox ID="txtIntegration" runat="server" height="22px" style="z-index: 1; left: 121px; top: 241px; position: absolute" width="128px"></asp:TextBox>
        </p>
        <p>
            <asp:Label ID="lblStatus" runat="server" style="z-index: 1; left: 12px; top: 281px; position: absolute" Text="Status" width="49px"></asp:Label>
            <asp:CheckBox ID="chkActive" runat="server" height="22px" style="z-index: 1; left: 125px; top: 281px; position: absolute" Text="Active" width="128px" />
        </p>
        <p>
            <asp:Label ID="lblUpdatedAt" runat="server" style="z-index: 1; left: 12px; top: 319px; position: absolute" Text="Updated At" width="49px"></asp:Label>
            <asp:TextBox ID="txtUpdatedAt" runat="server" height="22px" style="z-index: 1; left: 121px; top: 317px; position: absolute" width="128px"></asp:TextBox>
        </p>
        <p>
            <asp:Label ID="lblPrice" runat="server" style="z-index: 1; left: 12px; position: absolute; bottom: 276px" Text="Price" width="49px"></asp:Label>
            <asp:TextBox ID="txtPrice" runat="server" height="22px" style="z-index: 1; left: 118px; top: 380px; position: absolute" width="128px"></asp:TextBox>
        </p>
        <p>
            &nbsp;</p>
        <p>
            &nbsp;</p>
        <p>
            <asp:Label ID="lblError" runat="server" style="z-index: 1; left: 10px; top: 433px; position: absolute"></asp:Label>
        </p>
        <p>
            <asp:Button ID="btnOk" runat="server" OnClick="btnOk_Click" style="z-index: 1; left: 10px; top: 471px; position: absolute" Text="OK" />
            <asp:Button ID="btnCancel" runat="server" style="z-index: 1; top: 470px; position: absolute; left: 75px" Text="Cancel" OnClick="btnCancel_Click" />
        </p>
        <p>
            &nbsp;</p>
        <p>
            <asp:Button ID="btnRetourMenu" runat="server" OnClick="btnRetourMenu_Click" Text="Return to Main Menu" />
        </p>
        <p>
            &nbsp;</p>
        <p>
            &nbsp;</p>
        <p>
            &nbsp;</p>
        <p>
            &nbsp;</p>
        <p>
            &nbsp;</p>
        <p>
            &nbsp;</p>
        <p>
            &nbsp;</p>
        <p>
            &nbsp;</p>
        <p>
            &nbsp;</p>
        <p>
            &nbsp;</p>
    </form>
</body>
</html>
