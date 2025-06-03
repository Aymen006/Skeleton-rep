<%@ Page Language="C#" AutoEventWireup="true" CodeFile="TeamMainMenu.aspx.cs" Inherits="TeamMainMenu" %>

<!DOCTYPE html>
<html xmlns="http://www.w3.org/1999/xhtml" lang="en">
<head runat="server">
    <meta charset="utf-8" />
    <meta name="viewport" content="width=device-width, initial-scale=1" />
    <title>AI Agent Main Menu</title>
    <style>
        /* Reset some basic elements */
        * {
            box-sizing: border-box;
        }

        body {
            margin: 0;
            font-family: 'Segoe UI', Tahoma, Geneva, Verdana, sans-serif;
            background: linear-gradient(135deg, #667eea, #764ba2);
            display: flex;
            justify-content: center;
            align-items: center;
            height: 100vh;
            color: #fff;
        }

        form {
            background: #ffffff;
            padding: 3rem 2.5rem;
            border-radius: 12px;
            box-shadow: 0 10px 30px rgba(0, 0, 0, 0.15);
            width: 320px;
            text-align: center;
            color: #333;
            transition: box-shadow 0.3s ease;
        }

        form:hover {
            box-shadow: 0 12px 40px rgba(0, 0, 0, 0.25);
        }

        #<%= lblMenu.ClientID %> {
            font-size: 1.75rem;
            font-weight: 700;
            margin-bottom: 2.5rem;
            letter-spacing: 0.05em;
        }

        .aspNetButton {
            background-color: #5a67d8;
            color: white;
            border: none;
            padding: 0.75rem 0;
            margin: 0.75rem 0;
            font-size: 1.1rem;
            border-radius: 8px;
            cursor: pointer;
            width: 100%;
            box-shadow: 0 4px 6px rgba(90, 103, 216, 0.4);
            transition: background-color 0.25s ease, box-shadow 0.25s ease;
        }

        .aspNetButton:hover,
        .aspNetButton:focus {
            background-color: #434190;
            box-shadow: 0 6px 12px rgba(67, 65, 144, 0.6);
            outline: none;
        }

        /* Accessibility improvements */
        .aspNetButton:focus-visible {
            outline: 3px solid #a3bffa;
            outline-offset: 3px;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server" autocomplete="off">
        <asp:Label ID="lblMenu" runat="server" Text="AI Agent Main Menu"></asp:Label>
        <asp:Button ID="btnAgents" runat="server" OnClick="btnAgents_Click" Text="Agents" CssClass="aspNetButton" />
        <asp:Button ID="btnCustomers" runat="server" OnClick="btnCustomers_Click" Text="Customers" CssClass="aspNetButton" />
    </form>
</body>
</html>
