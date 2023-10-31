<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="DefaultWebForm.aspx.cs" Inherits="Assignment_1ASP.DefaultWebForm" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
        </div>
        <h2><i>Welcome to Stationary Store!!!!</i></h2>
        <asp:DropDownList ID="listItems" runat="server" AutoPostBack="true" OnSelectedIndexChanged="listItems_SelectedIndexChanged">
            <asp:ListItem Text="Select an item" Value="" />
            <asp:ListItem Text="Notebook" Value="Notebook.jpg" />
            <asp:ListItem Text="Pen" Value="Pen.jpg" />
            <asp:ListItem Text="Color Pencils" Value="Colorpencils.jpg" />
            <asp:ListItem Text="Eraser" Value="Eraser.jpg" />
            <asp:ListItem Text="Whitener" Value="Whitener.jpg" />
            <asp:ListItem Text="Stapler" Value="Stapler.webp" />

        </asp:DropDownList>

        <br /><br />

        <asp:Image ID="imageItem" runat="server" Width="200px" Height="150px" />
                    
        <br /><br />

         <asp:Button ID="ShowDetail" runat="server" Text="Show Details" OnClick="getItemDetails" />
        <br /><br />
        <asp:Label ID="ItemDetail" runat="server" Text=""></asp:Label>

      
        <br /><br />
        <asp:Button ID="ShowCost" runat="server" Text="Show Cost" OnClick="getItemCost" />

        <br /><br />

        <asp:Label ID="ItemCost" runat="server" Text=""></asp:Label>
    </form>
</body>
</html>
