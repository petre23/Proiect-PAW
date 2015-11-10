using Controller.Interfaces;
using Controller.ModelBL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace BionicGames.View.Forms
{
    public partial class LoginForm : Page,ILoginForm
    {
        private LoginFormController _controller;
        private bool _isLoggedIn;

        public LoginForm() 
        {
            _controller = new LoginFormController(this);
        }

        protected void Page_Load(object sender, EventArgs e)
        {
            passwordTextBox.TextMode = (TextBoxMode)2;
            _controller.LoadTable();
        }

        protected void LogInBtn_Click(object sender, EventArgs e)
        {
            _isLoggedIn = _controller.LoginToWebsite();
            if (_isLoggedIn)
                Response.Redirect("Index.aspx");
        }

        public Label UserNameLbl
        {
            get
            {
                return userNameLbl;
            }
            set
            {
                userNameLbl = value;
            }
        }

        public Label PasswordLbl
        {
            get
            {
                return passwordLbl;
            }
            set
            {
                passwordLbl = value;
            }
        }

        public TextBox UserNameTextBox
        {
            get
            {
                return userTextBox;
            }
            set
            {
                userTextBox = value;
            }
        }

        public TextBox PasswordTextBox
        {
            get
            {
                return this.passwordTextBox;
            }
            set
            {
                this.passwordTextBox = value;
            }
        }

        public Button LoginButton
        {
            get
            {
                return LogInBtn;
            }
            set
            {
                LogInBtn = value;
            }
        }
        public GridView GridDataView 
        {
            get { return gridDataView; }
            set { gridDataView = value; }
        }
    }
}