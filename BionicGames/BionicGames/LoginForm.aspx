<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="LoginForm.aspx.cs" Inherits="BionicGames.LoginForm" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <style type="text/css">
        #Password1 {
            width: 194px;
            margin-left: 32px;
        }
        #PasswordTextBox {
            width: 195px;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
    <div style="width: 477px">
       &nbsp;&nbsp;&nbsp;
        <asp:Label ID="userNameLbl" runat="server" Text="User Name"></asp:Label>
        <asp:TextBox ID="userTextBox" runat="server" style="margin-left: 0px" Width="197px"></asp:TextBox>
    </div>
        <div style="height: 39px; width: 475px">
            <asp:Label ID="passwordLbl" runat="server" Text="Password"></asp:Label>
            <asp:TextBox ID="passwordTextBox" runat="server" style="margin-left: 3px" Width="193px"></asp:TextBox>
        </div>
        <div style="width: 475px; height: 26px">
            <asp:Button ID="LogInBtn" runat="server" OnClick="LogInBtn_Click" Text="LogIn" Width="86px" />
        </div>
    </form>
</body>
</html>
