<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="GetDay.aspx.cs" Inherits="smaplepro.GetDay" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <asp:Label runat="server"> Enter Days </asp:Label>
                <asp:TextBox ID="txtDays" runat="server"></asp:TextBox>
            <asp:Button ID="btnGetDay" OnClick="btnGetDay_Click" Text="Get Future Day Name" runat="server" />
            <asp:Button ID="btnPastDay" OnClick="btnPastDay_Click" Text="Get Past Day Name"  runat="server" />
            <asp:Label ID="errorMsg" runat="server"></asp:Label>

        </div>
    </form>
</body>
</html>
