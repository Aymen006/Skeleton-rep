<%@ Page Language="C#" AutoEventWireup="true" CodeFile="AgnDataEntry.aspx.cs" Inherits="_1_DataEntry" %>

<!DOCTYPE html>
<html xmlns="http://www.w3.org/1999/xhtml" lang="en">
<head runat="server">
    <meta charset="utf-8" />
    <meta name="viewport" content="width=device-width, initial-scale=1" />
    <title>Agent Data Entry</title>
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
            align-items: flex-start; /* Align form to the top */
            min-height: 100vh;
            padding: 2rem;
            color: #333;
        }

        form {
            background: #fff;
            padding: 2.5rem 3rem;
            border-radius: 12px;
            box-shadow: 0 10px 30px rgba(0, 0, 0, 0.15);
            width: 500px; /* Adjusted width for a data entry form */
            max-width: 100%;
            display: flex;
            flex-direction: column;
            gap: 1.25rem; /* Reduced gap for more compact form */
        }

        /* Form Row Styling */
        .form-row {
            display: flex;
            align-items: center; /* Vertically align items in a row */
            gap: 1rem;
            flex-wrap: wrap; /* Allow items to wrap on smaller screens */
            width: 100%; /* Ensure row takes full width */
        }

        .form-row label {
            flex-basis: 120px; /* Give labels a fixed width */
            min-width: 80px; /* Ensure label doesn't get too small */
            font-weight: 600;
            font-size: 1rem;
            color: #555;
        }

        .form-row .aspNetDisabled { /* Style for disabled textboxes/labels if applicable */
            opacity: 0.7;
        }

        .form-row input[type="text"],
        .form-row textarea { /* Style for textboxes */
            flex-grow: 1; /* Allow textboxes to take remaining space */
            padding: 0.6rem;
            font-size: 1rem;
            border: 1.5px solid #ccc;
            border-radius: 8px;
            transition: border-color 0.3s ease, box-shadow 0.3s ease;
            min-width: 150px; /* Prevent textboxes from becoming too narrow */
        }

        .form-row input[type="text"]:focus,
        .form-row textarea:focus {
            border-color: #5a67d8;
            box-shadow: 0 0 8px rgba(90, 103, 216, 0.5);
            outline: none;
        }

        .form-row input[type="checkbox"] {
            margin-right: 0.5rem; /* Space between checkbox and its text */
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
            white-space: nowrap; /* Prevent button text from wrapping */
        }

        /* Group button container */
        .btn-group {
            display: flex;
            flex-wrap: wrap;
            gap: 1rem;
            margin-top: 1rem; /* Space above button groups */
        }

        asp\:Button:hover, .aspNetButton:hover, button:hover, input[type="button"]:hover, input[type="submit"]:hover {
            background-color: #434190;
            box-shadow: 0 6px 12px rgba(67, 65, 144, 0.6);
            outline: none;
        }

        /* Specific style for the Find button to align it with its input */
        .find-row {
            display: flex;
            align-items: center;
            gap: 1rem;
            width: 100%;
        }
        .find-row .label-and-input {
            display: flex;
            align-items: center;
            gap: 1rem;
            flex-grow: 1;
        }
        .find-row .label-and-input label {
            flex-basis: 120px; /* Consistent label width */
            min-width: 80px;
        }
        .find-row .label-and-input input[type="text"] {
            flex-grow: 1; /* Allow input to fill space */
        }
        .find-row .aspNetButton { /* Style for the Find button within this row */
            margin-left: auto; /* Push Find button to the right if needed */
        }


        /* Error Label */
        #<%= lblError.ClientID %> {
            color: #e53e3e; /* red-ish */
            font-weight: 600;
            font-size: 1rem;
            min-height: 1.25rem; /* reserve space */
            text-align: center;
            width: 100%;
            margin-top: 0.5rem;
        }

        .logo-container {
            text-align: center;
            margin-bottom: 2rem;
        }

        .logo-container img {
            max-width: 180px; /* Adjust size as needed */
            height: auto;
            filter: brightness(0) invert(0); /* keep it black, no changes */
            user-select: none;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server" autocomplete="off">

        <div class="logo-container">
            <img src="logo.png" alt="Company Logo" />
        </div>

        <div class="find-row">
            <div class="label-and-input">
                <asp:Label ID="lblAgentId" runat="server" Text="Agent ID"></asp:Label>
                <asp:TextBox ID="txtAgentId" runat="server" OnTextChanged="TextBox1_TextChanged"></asp:TextBox>
            </div>
            <asp:Button ID="btnFind" runat="server" OnClick="btnFind_Click" Text="Find" />
        </div>

        <div class="form-row">
            <asp:Label ID="lblAgentName" runat="server" Text="Agent Name"></asp:Label>
            <asp:TextBox ID="txtAgentName" runat="server"></asp:TextBox>
        </div>

        <div class="form-row">
            <asp:Label ID="lblDescription" runat="server" Text="Description"></asp:Label>
            <asp:TextBox ID="txtDescription" runat="server"></asp:TextBox>
        </div>

        <div class="form-row">
            <asp:Label ID="lblCategory" runat="server" Text="Category"></asp:Label>
            <asp:TextBox ID="txtCategory" runat="server"></asp:TextBox>
        </div>

        <div class="form-row">
            <asp:Label ID="lblIntegration" runat="server" Text="Integration Type"></asp:Label>
            <asp:TextBox ID="txtIntegration" runat="server"></asp:TextBox>
        </div>

        <div class="form-row">
            <asp:Label ID="lblStatus" runat="server" Text="Status"></asp:Label>
            <asp:CheckBox ID="chkActive" runat="server" Text="Active" />
        </div>

        <div class="form-row">
            <asp:Label ID="lblUpdatedAt" runat="server" Text="Updated At"></asp:Label>
            <asp:TextBox ID="txtUpdatedAt" runat="server"></asp:TextBox>
        </div>

        <div class="form-row">
            <asp:Label ID="lblPrice" runat="server" Text="Price"></asp:Label>
            <asp:TextBox ID="txtPrice" runat="server"></asp:TextBox>
        </div>

        <asp:Label ID="lblError" runat="server"></asp:Label>

        <div class="btn-group">
            <asp:Button ID="btnOk" runat="server" OnClick="btnOk_Click" Text="OK" />
            <asp:Button ID="btnCancel" runat="server" OnClick="btnCancel_Click" Text="Cancel" />
            <asp:Button ID="btnRetourMenu" runat="server" OnClick="btnRetourMenu_Click" Text="Return to Main Menu" />
        </div>

    </form>
</body>
</html>
