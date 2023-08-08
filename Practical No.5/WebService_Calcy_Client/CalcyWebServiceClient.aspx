<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="CalcyWebServiceClient.aspx.cs" Inherits="WebService_Calcy_Client.CalcyWebServiceClient" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            Calcy Web Service client<br />
            <br />
            Num1:<asp:TextBox ID="txtnum1" runat="server" style="margin-left: 53px"></asp:TextBox>
            <br />
            Num2:<asp:TextBox ID="txtnum2" runat="server" style="margin-left: 53px"></asp:TextBox>
            <br />
            <br />
            <asp:Button ID="btnadd" runat="server" OnClick="btnadd_Click" Text="Addition" Height="32px" Width="116px" />
            <asp:Button ID="btnsub" runat="server" Text="Subtraction" Height="32px" OnClick="btnsub_Click" style="margin-left: 6px" Width="116px" />
            <asp:Button ID="btnmul" runat="server" Text="Multiplication" Height="32px" OnClick="btnmul_Click" style="margin-left: 5px" Width="116px" />
            <asp:Button ID="btndiv" runat="server" Text="Divide" Height="32px" OnClick="btndiv_Click" style="margin-left: 7px" Width="116px" />
            <br />
            Result: <asp:Label ID="lblresult" runat="server" Text="Label"></asp:Label>
            <br />
        </div>
    </form>
</body>
</html>
