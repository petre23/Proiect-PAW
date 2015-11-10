<%@ Page Language="C#" AutoEventWireup="true" MasterPageFile="~/Forms/MainPage.Master" CodeBehind="LoginForm.aspx.cs" Inherits="BionicGames.View.Forms.LoginForm" ClientIDMode="Static" %>

    <asp:Content ID="Content" ContentPlaceHolderID="MainPagePlaceHolder" runat="server">

        <link rel="stylesheet" href="../../Content/Log.css" />

        <div class="col-sm-8">
            <div class="login">
                <legend id="l1">Personal information:</legend>
            </div>
            
            <div class="form">

                <asp:Label ID="userNameLbl" runat="server" Text="User Name"></asp:Label>
                <asp:TextBox ID="userTextBox" runat="server"></asp:TextBox>
                
            </div>
            <div class="form1">
                 <asp:Label ID="passwordLbl" runat="server" Text="Password"></asp:Label>
                 <asp:TextBox ID="passwordTextBox" runat="server" TextMode ="Password"></asp:TextBox>

            </div>
            <br /><br /><br/>
            <asp:Button ID="LogInBtn" runat="server"
                    onclick="LogInBtn_Click" Text="Login" />
            <br/><br/>
            <asp:HyperLink ID="HyperLink1" runat="server" 
                            NavigateUrl="~/RegisterForm.aspx">Click here to make a new user</asp:HyperLink>
        </div>
        <asp:GridView ID="gridDataView" runat="server" Height="19px" style="margin-top: 28px; margin-bottom: 0px" Width="297px">
        </asp:GridView>
    </asp:Content>
