using Controller.Interfaces;
using Model.ModelBO;
using Model.ModelDAO;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Controller.ModelBL
{
    public class RegisterFormController
    {
        private IRegisterForm _form;
        private UserDAO userDAO;
        private User user;

        public RegisterFormController(IRegisterForm form)
        {
            _form = form;
            user = new User();
            userDAO = new UserDAO(); 
        }

        public bool RegisterUser()
        {
            user.Username = _form.EmailTextBox.Text;
            user.Password = _form.PasswordTextBox.Text;
            return userDAO.InsertUser(user);
        }

    }
}
