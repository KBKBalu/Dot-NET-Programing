<% @ Page Language="C#" AutoEventWireup="true" CodeBehind="WebForm1.aspx.cs" Inherits="WebApplication1.WebForm1" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>myapplication</title>
</head>
    <center>
<body>
    <form id="form1" runat="server" >
        <h1>User Details</h1>
    <div>
        <asp:TextBox ID="TextBox1" runat="server" style="margin-left: 43px" Width="167px" ToolTip="Plz Enter the Name" ></asp:TextBox>
        <br /><br />
        <asp:DropDownList ID="DropDownList1" runat="server">
        </asp:DropDownList>
        <br /><br />
        <asp:Button ID="Button1" runat="server" OnClick="Button1_Click" Text="Submit" />
    </div>
    </form>
  </body>
</center>
</html>
