<%@ Page Language="C#" AutoEventWireup="true" CodeFile="AgnConfirmDelete.aspx.cs" Inherits="_1_ConfirmDelete" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml" lang="en">
<head runat="server">
    <meta charset="utf-8" />
    <meta name="viewport" content="width=device-width, initial-scale=1" />
    <title>Confirm Delete</title>
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
            align-items: center; /* Center form vertically in the middle */
            min-height: 100vh;
            padding: 2rem;
            color: #333;
        }

        form {
            background: #fff;
            padding: 2.5rem 3rem;
            border-radius: 12px;
            box-shadow: 0 10px 30px rgba(0, 0, 0, 0.15);
            width: 400px; /* Adjusted width for a confirmation box */
            max-width: 100%;
            display: flex;
            flex-direction: column;
            gap: 1.5rem; /* Space between elements */
            align-items: center; /* Center content horizontally within the form */
            text-align: center; /* Center text within the form */
        }

        /* Label for confirmation message */
        #<%= lblDelete.ClientID %> {
            font-size: 1.3rem;
            font-weight: 600;
            color: #4a5568; /* Slightly darker grey for prominence */
            margin-bottom: 1rem; /* Space below the message */
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
            gap: 1.5rem; /* More space between Yes/No buttons */
            margin-top: 1rem;
            justify-content: center; /* Center buttons within the group */
        }

        /* Specific style for No button to make it visually distinct */
        #<%= btnNo.ClientID %> {
            background-color: #e53e3e; /* Red for 'No' to indicate caution/cancellation */
            box-shadow: 0 4px 6px rgba(229, 62, 62, 0.4);
        }

        #<%= btnNo.ClientID %>:hover {
            background-color: #c53030; /* Darker red on hover */
            box-shadow: 0 6px 12px rgba(197, 48, 48, 0.6);
        }

        asp\:Button:hover, .aspNetButton:hover, button:hover, input[type="button"]:hover, input[type="submit"]:hover {
            background-color: #434190;
            box-shadow: 0 6px 12px rgba(67, 65, 144, 0.6);
            outline: none;
        }

        .logo-container {
            text-align: center;
            margin-bottom: 2rem;
        }

        .logo-container img {
            max-width: 150px; /* Slightly smaller logo for confirmation */
            height: auto;
            filter: brightness(0) invert(0); /* keep it black, no changes */
            user-select: none;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">

        <div class="logo-container">
            <img src="logo.png" alt="Company Logo" />
        </div>

        <div>
            <asp:Label ID="lblDelete" runat="server" Text="Are you sure you want to delete this record?"></asp:Label>
        </div>

        <div class="btn-group">
            <asp:Button ID="btnYes" runat="server" OnClick="btnYes_Click" Text="Yes" />
            <asp:Button ID="btnNo" runat="server" OnClick="btnNo_Click" Text="No" />
        </div>

    </form>
</body>
</html>
