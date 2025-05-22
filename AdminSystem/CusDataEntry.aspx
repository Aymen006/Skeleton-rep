<%@ Page Language="C#" AutoEventWireup="true" CodeFile="CusDataEntry.aspx.cs" Inherits="_1_DataEntry" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <style type="text/css">
        #form1 {
            height: 524px;
            width: 397px;
        }
    </style>
</head>
<body style="height: 824px"> <div style="height: 517px; width: 386px">
    <form id="form1" runat="server">
       
        <p>
            <asp:TextBox ID="txtPaymentStatus" runat="server" style="z-index: 1; left: 134px; top: 174px; position: absolute; bottom: 761px"></asp:TextBox>
            <asp:TextBox ID="txtCustomerEmail" runat="server" style="z-index: 1; left: 135px; top: 92px; position: absolute" height="22px" width="128px"></asp:TextBox>
            <asp:Label ID="lblSubscriptionId" runat="server" style="z-index: 1; left: 18px; top: 139px; position: absolute; width: 99px" Text="Subscription ID"></asp:Label>
            <asp:Label ID="lblPaymentStatus" runat="server" style="z-index: 1; left: 22px; top: 180px; position: absolute" Text="Payment Status"></asp:Label>
         <asp:TextBox ID="txtCustomerName" runat="server" style="z-index: 1; top: 60px; position: absolute; left: 136px" height="22px" width="128px"></asp:TextBox>
         <asp:Calendar ID="txtDate" runat="server" style="z-index: 1; left: 133px; top: 230px; position: absolute; height: 161px; width: 167px; margin-top: 0px"></asp:Calendar>
            <asp:Label ID="lblCreatedAt" runat="server" style="z-index: 1; left: 24px; top: 238px; position: absolute" Text="Created At"></asp:Label>
            <asp:Button ID="btnSave" runat="server" style="z-index: 1; left: 117px; top: 445px; position: absolute; height: 30px; width: 79px; right: 1184px;" Text="Save" OnClick="btnSave_Click" />
            </p>
            <asp:TextBox ID="txtCustomerId" runat="server" style="z-index: 1; top: 24px; position: absolute; left: 136px" height="22px" width="128px"></asp:TextBox>
            <asp:Label ID="lblCustomerName" runat="server" style="z-index: 1; left: 24px; top: 61px; position: absolute" Text="Customer Name"></asp:Label>
            <asp:Button ID="btnCancel" runat="server" OnClick="Button2_Click" style="z-index: 1; left: 228px; top: 446px; position: absolute; height: 30px; width: 79px" Text="Cancel" />
            <asp:Label ID="lblCustomerId" runat="server" style="z-index: 1; left: 23px; top: 28px; position: absolute" Text="Customer Id"></asp:Label>
            <asp:Label ID="lblCustomerEmail" runat="server" style="z-index: 1; left: 23px; top: 94px; position: absolute; height: 29px; width: 108px" Text="Customer Email"></asp:Label>
            <asp:TextBox ID="txtSubscriptionId" runat="server" style="z-index: 1; left: 135px; top: 137px; position: absolute" height="22px" width="128px"></asp:TextBox>
        
    </form></div>
</body>
</html>
