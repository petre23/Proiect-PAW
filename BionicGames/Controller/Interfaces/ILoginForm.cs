using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web.UI.WebControls;

namespace Controller.Interfaces
{
    public interface ILoginForm
    {
        Label UserNameLbl { get; set; }
        Label PasswordLbl { get; set; }
        TextBox UserNameTextBox { get; set; }
        TextBox PasswordTextBox { get; set; }
        Button LoginButton { get; set; }
    }
}
