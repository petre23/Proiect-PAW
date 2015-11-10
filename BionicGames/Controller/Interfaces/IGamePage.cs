using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web.UI.WebControls;

namespace Controller.Interfaces
{
    public interface IGamePage
    {
        Image GameImage { get; set; }
        Label LblGameInfo { get; set; }
        Label LblGenre { get; set; }
        Label LblReleaseYear { get; set; }
        Label LblName { get; set; }
    }
}
