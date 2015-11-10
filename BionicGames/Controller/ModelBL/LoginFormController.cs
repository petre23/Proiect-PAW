using Controller.Interfaces;
using Model.ModelBO;
using Model.ModelDAO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Controller.ModelBL
{
    public class LoginFormController
    {
        private ILoginForm _form;
        private UserDAO userDAO;
        private User user;

        public LoginFormController(ILoginForm form)
        {
            _form = form;
            user = new User();
            userDAO = new UserDAO(); 
        }

        public bool LoginToWebsite()
        {
            user.Username = _form.UserNameTextBox.Text;
            user.Password = _form.PasswordTextBox.Text;
            if (userDAO.SuccesfullLogin(user))
            {
                return true;
            }
            else
                return false;
        }

        public void LoadTable() 
        {
            List<User> userList = userDAO.GetAllUsers();
            _form.GridDataView.DataSource = userList;
            _form.GridDataView.DataBind();
        }

    }
}
