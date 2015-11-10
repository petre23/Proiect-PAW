using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web.UI.WebControls;

namespace Controller.Interfaces
{
    public interface IRegisterForm
    {
        TextBox EmailTextBox { get; set; }
        TextBox PasswordTextBox { get; set; }
        TextBox ConfirmPasswordTextBox { get; set; }
        Button SubmitButton { get; set; }
    }
}
