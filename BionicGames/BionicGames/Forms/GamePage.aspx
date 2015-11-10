<%@ Page Language="C#" AutoEventWireup="true" MasterPageFile="~/Forms/MainPage.Master" CodeBehind="GamePage.aspx.cs" Inherits="BionicGames.Forms.GamePage" ClientIDMode="Static" %>

<asp:Content ID="Content" ContentPlaceHolderID="MainPagePlaceHolder" runat="server">

    <div>
        <asp:Image ID="gameImage" runat="server" />
    </div>
    <div>
        <asp:Label ID="lblName" runat="server" Text="Label"></asp:Label>
    </div>
    <div>
        <asp:Label ID="lblGenre" runat="server" Text="Label"></asp:Label>
    </div>
    <div>
        <asp:Label ID="lblReleaseYear" runat="server" Text="Label"></asp:Label>
    </div>
    <div>
        <asp:Label ID="lblGameInfo" runat="server" Text="Label"></asp:Label>
    </div>
</asp:Content>
