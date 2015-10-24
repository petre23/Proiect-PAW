using Controller.Interfaces;
using Controller.ModelBL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace BionicGames
{
    public partial class LoginForm : System.Web.UI.Page, ILoginForm
    {
        private LoginFormController _controller;

        public LoginForm() 
        {
            _controller = new LoginFormController(this);
 
        }

        protected void Page_Load(object sender, EventArgs e)
        {
            passwordTextBox.TextMode = (TextBoxMode)2;
        }

        protected void LogInBtn_Click(object sender, EventArgs e)
        {
            
            Label info = new Label();
            info.Text = _controller.LoginToWebsite();
            info.Visible = true;
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
                return passwordTextBox;
            }
            set
            {
                passwordTextBox = value;
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
    }
}