<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="OddEvenWebserviceClient.aspx.cs" Inherits="WEB_Service_Odd_Even_Client.OddEvenWebserviceClient" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div style="height: 149px">
            Odd Even Web Service Client Client<br />
            <br />
            Enter Number:<asp:TextBox ID="txtnum" runat="server"></asp:TextBox>
            <asp:Button ID="btncheck" runat="server" OnClick="btncheck_Click" Text="Check" />
            <br />
            <asp:Label ID="lbloutput" runat="server" Text="Label"></asp:Label>
        </div>
    </form>
</body>
</html>
