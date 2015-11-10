using Controller.Interfaces;
using Controller.ModelBL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace BionicGames.Forms
{
    public partial class RegisterForm : System.Web.UI.Page, IRegisterForm
    {
        private RegisterFormController _controller ;
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        public RegisterForm() 
        {
            _controller = new RegisterFormController(this);
        }



        public TextBox EmailTextBox
        {
            get
            {
                return EmailBox;
            }
            set
            {
                EmailBox = value;
            }
        }

        public TextBox PasswordTextBox
        {
            get
            {
                return PasswordBox;
            }
            set
            {
                PasswordBox = value;
            }
        }

        protected void SubmitButton_Click(object sender, EventArgs e)
        {
            if (_controller.RegisterUser())
                Response.Redirect("Index.aspx");
        }

        public TextBox ConfirmPasswordTextBox
        {
            get
            {
                return ConfirmPasswordBox;
            }
            set
            {
                ConfirmPasswordBox = value;
            }
        }


        Button IRegisterForm.SubmitButton
        {
            get
            {
                return SubmitButton;
            }
            set
            {
                SubmitButton = value;
            }
        }
    }
}