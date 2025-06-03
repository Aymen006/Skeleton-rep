<%@ Page Language="C#" AutoEventWireup="true" CodeFile="AgnList.aspx.cs" Inherits="_1_List" %>

<!DOCTYPE html>
<html xmlns="http://www.w3.org/1999/xhtml" lang="en">
<head runat="server">
    <meta charset="utf-8" />
    <meta name="viewport" content="width=device-width, initial-scale=1" />
    <title>Agent List</title>
    <style>
        /* Reset */
        * {
            box-sizing: border-box;
        }

        body {
            margin: 0;
            font-family: 'Segoe UI', Tahoma, Geneva, Verdana, sans-serif;
            background: linear-gradient(135deg, #667eea, #764ba2);
            display: flex;
            justify-content: center;
            align-items: flex-start;
            min-height: 100vh;
            padding: 2rem;
            color: #333;
        }

        form {
            background: #fff;
            padding: 2.5rem 3rem;
            border-radius: 12px;
            box-shadow: 0 10px 30px rgba(0, 0, 0, 0.15);
            width: 700px;
            max-width: 100%;
            display: flex;
            flex-direction: column;
            gap: 1.75rem;
        }

        /* ListBox styling */
        #<%= lstAgentList.ClientID %> {
            width: 100%;
            height: 480px;
            border-radius: 8px;
            border: 1.5px solid #ccc;
            padding: 0.5rem;
            font-size: 1rem;
            box-shadow: inset 0 1px 4px rgba(0,0,0,0.1);
            outline: none;
            transition: border-color 0.3s ease;
        }
        #<%= lstAgentList.ClientID %>:focus {
            border-color: #5a67d8;
            box-shadow: 0 0 8px rgba(90, 103, 216, 0.5);
        }

        /* Buttons */
        asp\:Button, .aspNetButton, button, input[type="button"], input[type="submit"] {
            background-color: #5a67d8;
            color: white;
            border: none;
            padding: 0.75rem 1.5rem;
            font-size: 1rem;
            border-radius: 8px;
            cursor: pointer;
            box-shadow: 0 4px 6px rgba(90, 103, 216, 0.4);
            transition: background-color 0.25s ease, box-shadow 0.25s ease;
            margin-right: 1rem;
        }

        /* Group button container */
        .btn-group {
            display: flex;
            flex-wrap: wrap;
            gap: 1rem;
        }

        asp\:Button:hover, .aspNetButton:hover, button:hover, input[type="button"]:hover, input[type="submit"]:hover {
            background-color: #434190;
            box-shadow: 0 6px 12px rgba(67, 65, 144, 0.6);
            outline: none;
        }

        /* Label and TextBox */
        label, asp\:Label {
            font-weight: 600;
            font-size: 1.1rem;
            margin-bottom: 0.5rem;
            display: block;
        }

        #<%= txtFilter.ClientID %> {
            width: 100%;
            padding: 0.5rem;
            font-size: 1rem;
            border: 1.5px solid #ccc;
            border-radius: 8px;
            transition: border-color 0.3s ease;
        }

        #<%= txtFilter.ClientID %>:focus {
            border-color: #5a67d8;
            box-shadow: 0 0 8px rgba(90, 103, 216, 0.5);
            outline: none;
        }

        /* Error Label */
        #<%= lblError.ClientID %> {
            color: #e53e3e; /* red-ish */
            font-weight: 600;
            font-size: 1rem;
            min-height: 1.25rem; /* reserve space */
        }
        .logo-container {
            text-align: center;
            margin-bottom: 2rem;
        }

        .logo-container img {
            max-width: 180px;   /* Adjust size as needed */
            height: auto;
            filter: brightness(0) invert(0); /* keep it black, no changes */
            user-select: none;
        }

        /* Logged in info Container */
        .logged-in-info {
            position: absolute;
            top: 1.5rem; /* Adjust as needed for vertical positioning */
            left: 2rem; /* Adjust as needed for horizontal positioning */
            color: #fff; /* White color for overall text */
            font-size: 1.1rem;
            font-weight: 600; /* Default weight for the whole line */
            text-shadow: 1px 1px 3px rgba(0, 0, 0, 0.3); /* Subtle shadow for better contrast */
            z-index: 10; /* Ensure it stays above other elements if they overlap */
            /* You can add more styling here for the container if you want a background, padding, etc. */
            /* background-color: rgba(0, 0, 0, 0.2); */
            /* padding: 0.5rem 1rem; */
            /* border-radius: 8px; */
        }

        /* Style for the dynamic username part */
        .username-dynamic {
            color: #ffd700; /* A golden color for the username */
            font-weight: bold; /* Make the username more prominent */
        }
    </style>
</head>
<body>
    <div class="logged-in-info">
        <asp:Literal ID="litLoggedInUser" runat="server"></asp:Literal>
    </div>

    <form id="form1" runat="server" autocomplete="off">

        <div class="logo-container">
            <img src="logo.png" alt="Company Logo" />
        </div>

        <asp:ListBox ID="lstAgentList" runat="server"></asp:ListBox>

        <div class="btn-group">
            <asp:Button ID="btnAdd" runat="server" OnClick="btnAdd_Click" Text="Add" />
            <asp:Button ID="btnEdit" runat="server" OnClick="btnEdit_Click" Text="Edit" />
            <asp:Button ID="btnDelete" runat="server" OnClick="btnDelete_Click" Text="Delete" />
        </div>

        <div>
            <asp:Label ID="lblCategory" runat="server" Text="Enter A Category"></asp:Label>
            <asp:TextBox ID="txtFilter" runat="server" />
        </div>

        <div class="btn-group">
            <asp:Button ID="btnApply" runat="server" OnClick="btnApply_Click" Text="Apply Filter" />
            <asp:Button ID="btnClear" runat="server" OnClick="btnClear_Click" Text="Clear Filter" />
        </div>

        <div>
            <asp:Button ID="btnRetourMenu" runat="server" OnClick="btnRetourMenu_Click" Text="Retour to Main Menu" CssClass="aspNetButton" />
        </div>

        <asp:Label ID="lblError" runat="server"></asp:Label>
    </form>
</body>
</html>
