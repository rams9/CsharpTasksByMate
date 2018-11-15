<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="GetTwoouts.aspx.cs" Inherits="smaplepro.GetTwoouts" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <label>Input One</label>
            <asp:TextBox runat="server" ID="txtInputOne" ></asp:TextBox>
             <label>Input TWO</label>
            <asp:TextBox runat="server" ID="txtInputTwo"></asp:TextBox>

            <asp:Button ID="btnGet" Text="Get Two OUts" OnClick="btnGet_Click"  runat="server" />

            <span>Interger Output is: </span>
            <asp:Label ID="lblInteger" runat="server"></asp:Label>
            <span>string Output is : </span>
            <asp:Label ID="lblstring" runat="server"></asp:Label>
        </div>
    </form>
</body>
</html>
