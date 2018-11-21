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
            <asp:RangeValidator runat="server" ID="rngDays" ControlToValidate="txtDays" MaximumValue="14" MinimumValue="1" ErrorMessage="Please Enter should be 1 to 14" Type="Integer" ></asp:RangeValidator> 
            <asp:CompareValidator runat="server" ID="cmpDays" Operator="DataTypeCheck" Type="Integer" ControlToValidate="txtDays" ErrorMessage="only accept numbers"></asp:CompareValidator>

            <asp:Button ID="btnGetDay" OnClick="btnGetDay_Click" Text="Get Future Day Name" runat="server" />
            <asp:Button ID="btnPastDay" OnClick="btnPastDay_Click" Text="Get Past Day Name"  runat="server" />
            <asp:Label ID="errorMsg" runat="server"></asp:Label>

        </div>
    </form>
</body>
</html>
