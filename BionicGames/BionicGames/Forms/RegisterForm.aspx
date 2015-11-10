<%@ Page Language="C#" AutoEventWireup="true" MasterPageFile="~/Forms/MainPage.Master" CodeBehind="RegisterForm.aspx.cs" Inherits="BionicGames.Forms.RegisterForm" ClientIDMode="Static"%>


<asp:Content ID="Content" ContentPlaceHolderID="MainPagePlaceHolder" runat="server">
    <link rel="stylesheet" href="../../Content/Reg.css" />

    <%ScriptManager.ScriptResourceMapping.AddDefinition("jquery", 
    new ScriptResourceDefinition {
        Path = "~/scripts/jquery-1.4.1.min.js",
        DebugPath = "~/scripts/jquery-1.4.1.js",
        CdnPath = "http://ajax.microsoft.com/ajax/jQuery/jquery-1.4.1.min.js",
        CdnDebugPath = "http://ajax.microsoft.com/ajax/jQuery/jquery-1.4.1.js"
    }); %>
    <script src="https://ajax.googleapis.com/ajax/libs/jquery/1.11.3/jquery.min.js"></script>
    <div class="col-sm-8">
            <div class="login">
                <legend id="l1">Register Informations:</legend>
            </div>

            <div class="form">
                 <label for="Email">Email:</label>
                 <asp:TextBox ID="EmailBox" runat="server"></asp:TextBox>

            </div>

             <div class="form">
                 <label for="password">Password:</label>
                 <asp:TextBox ID="PasswordBox" runat="server"  TextMode="Password"></asp:TextBox>
             </div>

             <div class="form">
                <label for="ConfirmPassword">ConfirmPassword:</label>
                <asp:TextBox ID="ConfirmPasswordBox" runat="server" TextMode="Password"></asp:TextBox>
                 <asp:CompareValidator ID="CompareValidator" runat="server"
                      ErrorMessage="Password must be the same" Type ="string"
                     ControlToValidate ="ConfirmPasswordBox" ControlToCompare ="PasswordBox" ForeColor="Red">
                 </asp:CompareValidator>
                 <div class = "form">
                 <asp:Button ID="SubmitButton" runat="server" Text="Submit" OnClick="SubmitButton_Click" />
                 </div>
            </div>
        </div>
        </div>
</asp:Content>