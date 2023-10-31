<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="ASP.aspx.cs" Inherits="ASP_ASSIGNMENT.ASP" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
   <form id="form1" runat="server">
        <div>
            
            <asp:DropDownList ID="ddlItems" runat="server" AutoPostBack="true" OnSelectedIndexChanged="ddlItems_SelectedIndexChanged">
                <asp:ListItem Text="Select Item"/>
                <asp:ListItem Text="DELL" Value="1"  />
                <asp:ListItem Text="HP" Value="2"  />
                <asp:ListItem Text="MAC" Value="3"  />
                

            </asp:DropDownList>
            <br /><br />

            <asp:Image ID="imgItem"  runat="server" ImageUrl="Images/default.jpg" Width="300" Height="300" />

            <br /><br />

            <asp:Button ID="btnShowCost" runat="server" Text="Show Cost" OnClick="btnShowCost_Click" />
            <br /><br />

            <asp:Label ID="lblCost" runat="server" Text="" />
        </div>
    </form>
</body>
</html>