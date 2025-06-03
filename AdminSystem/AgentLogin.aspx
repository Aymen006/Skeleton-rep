<%@ Page Language="C#" AutoEventWireup="true" CodeFile="AgentLogin.aspx.cs" Inherits="AgentLogin" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Agent Login</title>
    <style>
        /* Reset some default styles */
        * {
            box-sizing: border-box;
        }

        body {
            font-family: 'Segoe UI', Tahoma, Geneva, Verdana, sans-serif;
            background: linear-gradient(135deg, #667eea, #764ba2);
            height: 100vh;
            margin: 0;
            display: flex;
            justify-content: center;
            align-items: center;
            color: #333;
        }

        form {
            background: #fff;
            padding: 40px 35px;
            border-radius: 12px;
            box-shadow: 0 12px 30px rgba(0, 0, 0, 0.15);
            width: 350px;
            transition: box-shadow 0.3s ease;
        }
        form:hover {
            box-shadow: 0 18px 40px rgba(0, 0, 0, 0.25);
        }

        #<%= lblLogin.ClientID %> {
            font-size: 28px;
            font-weight: 700;
            margin-bottom: 25px;
            text-align: center;
            color: #333;
            letter-spacing: 1.2px;
        }

        p {
            margin: 18px 0;
        }

        label {
            display: block;
            font-weight: 600;
            margin-bottom: 8px;
            color: #555;
            letter-spacing: 0.03em;
        }

        input[type="text"], input[type="password"], 
        input[type="submit"], input[type="button"],
        .aspNetTextBox {
            width: 100%;
            padding: 12px 15px;
            font-size: 16px;
            border-radius: 8px;
            border: 1.5px solid #ccc;
            transition: border-color 0.3s ease, box-shadow 0.3s ease;
            font-family: inherit;
            outline: none;
        }

        input[type="text"]:focus, input[type="password"]:focus {
            border-color: #667eea;
            box-shadow: 0 0 6px #667eea;
        }

        #<%= lblError.ClientID %> {
            color: #e74c3c;
            font-weight: 600;
            font-size: 14px;
            margin-left: 12px;
            vertical-align: middle;
        }

        .button-row {
            display: flex;
            justify-content: space-between;
            margin-top: 30px;
        }

        input[type="submit"], input[type="button"] {
            width: 48%;
            padding: 12px 0;
            font-weight: 700;
            border: none;
            border-radius: 8px;
            cursor: pointer;
            transition: background-color 0.3s ease;
            font-family: inherit;
            color: white;
            letter-spacing: 0.05em;
            box-shadow: 0 4px 12px rgba(0, 0, 0, 0.1);
        }

        #<%= btnLogin.ClientID %> {
            background-color: #667eea;
            box-shadow: 0 6px 15px rgba(102, 126, 234, 0.5);
        }
        #<%= btnLogin.ClientID %>:hover {
            background-color: #5a6fd8;
            box-shadow: 0 8px 18px rgba(90, 111, 216, 0.7);
        }

        #<%= btnCancel.ClientID %> {
            background-color: #e74c3c;
            box-shadow: 0 6px 15px rgba(231, 76, 60, 0.5);
        }
        #<%= btnCancel.ClientID %>:hover {
            background-color: #c0392b;
            box-shadow: 0 8px 18px rgba(192, 57, 43, 0.7);
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
        <asp:Label ID="lblLogin" runat="server" Text="Agent Login Page"></asp:Label>
        <p>
            <asp:Label ID="lblUserName" runat="server" Text="UserName" AssociatedControlID="txtUserName"></asp:Label>
            <asp:TextBox ID="txtUserName" runat="server"></asp:TextBox>
        </p>
        <p>
            <asp:Label ID="lblPassword" runat="server" Text="Password" AssociatedControlID="txtPassword"></asp:Label>
            <asp:TextBox ID="txtPassword" runat="server" TextMode="Password"></asp:TextBox>
            <asp:Label ID="lblError" runat="server"></asp:Label>
        </p>
        <div class="button-row">
            <asp:Button ID="btnLogin" runat="server" OnClick="Button1_Click" Text="Login" />
            <asp:Button ID="btnCancel" runat="server" Text="Cancel" OnClick="btnCancel_Click" />
        </div>
    </form>
</body>
</html>
