<%@ Page Language="C#" AutoEventWireup="true" CodeFile="CusDataEntry.aspx.cs" Inherits="_1_DataEntry" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <style type="text/css">
        #form1 {
            height: 737px;
            width: 681px;
        }
    </style>
</head>
<body style="height: 824px"> <div style="height: 498px; width: 654px">
    <form id="form1" runat="server">
       
        <p>
            <asp:TextBox ID="txtPaymentStatus" runat="server" style="z-index: 1; left: 194px; top: 198px; position: absolute; bottom: 380px; width: 188px;" OnTextChanged="txtPaymentStatus_TextChanged"></asp:TextBox>
            <asp:TextBox ID="txtCustomerEmail" runat="server" style="z-index: 1; left: 206px; top: 97px; position: absolute" height="22px" width="128px"></asp:TextBox>
            <asp:Label ID="lblSubscriptionId" runat="server" style="z-index: 1; left: 44px; top: 148px; position: absolute; width: 99px" Text="Subscription ID"></asp:Label>
            <asp:Label ID="lblPaymentStatus" runat="server" style="z-index: 1; left: 19px; top: 200px; position: absolute" Text="Payment Status"></asp:Label>
         <asp:Calendar ID="txtDate" runat="server" style="z-index: 1; left: 175px; top: 257px; position: absolute; height: 161px; width: 167px; margin-top: 0px" OnSelectionChanged="txtDate_SelectionChanged"></asp:Calendar>
            <asp:Label ID="lblCreatedAt" runat="server" style="z-index: 1; left: 33px; top: 259px; position: absolute" Text="Created At"></asp:Label>
            <asp:Button ID="btnSave" runat="server" style="z-index: 1; left: 80px; top: 581px; position: absolute; height: 30px; width: 79px; right: 1359px;" Text="Save" OnClick="btnSave_Click" />
         <asp:TextBox ID="txtCustomerName" runat="server" style="z-index: 1; top: 60px; position: absolute; left: 210px" height="22px" width="128px" OnTextChanged="txtCustomerName_TextChanged"></asp:TextBox>
            </p>
            <asp:TextBox ID="txtCustomerId" runat="server" style="z-index: 1; top: 24px; position: absolute; left: 207px" height="22px" width="128px"></asp:TextBox>
            <asp:Label ID="lblCustomerName" runat="server" style="z-index: 1; left: 24px; top: 61px; position: absolute" Text="Customer Name"></asp:Label>
            <asp:Button ID="btnCancel" runat="server" OnClick="Button2_Click" style="z-index: 1; left: 204px; top: 579px; position: absolute; height: 30px; width: 79px" Text="Cancel" />
            <asp:Label ID="lblCustomerId" runat="server" style="z-index: 1; left: 23px; top: 28px; position: absolute" Text="Customer Id"></asp:Label>
            <asp:Label ID="lblCustomerEmail" runat="server" style="z-index: 1; left: 23px; top: 96px; position: absolute; height: 37px; width: 164px" Text="Customer Email"></asp:Label>
            <asp:TextBox ID="txtSubscriptionId" runat="server" style="z-index: 1; left: 197px; top: 151px; position: absolute" height="22px" width="128px"></asp:TextBox>
        
    </form></div>
    </body>
</html>
