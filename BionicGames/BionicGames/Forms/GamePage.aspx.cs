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
    public partial class GamePage : System.Web.UI.Page,IGamePage
    {
        GamePageController _controller;

        public GamePage() 
        {
            _controller = new GamePageController(this);
        }
        protected void Page_Load(object sender, EventArgs e)
        {
            _controller.LoadGamePage();
            this.Title = Server.UrlDecode(Request.QueryString["Parameter"].ToString());
        }

        public Image GameImage
        {
            get
            {
                return gameImage;
            }
            set
            {
                gameImage = value;
            }
        }

        public Label LblGameInfo
        {
            get
            {
                return lblGameInfo;
            }
            set
            {
                lblGameInfo = value;
            }
        }

        public Label LblGenre
        {
            get
            {
                return lblGenre;
            }
            set
            {
                lblGenre = value;
            }
        }

        public Label LblReleaseYear
        {
            get
            {
                return lblReleaseYear;
            }
            set
            {
                lblReleaseYear = value;
            }
        }

        public Label LblName
        {
            get
            {
                return lblName;
            }
            set
            {
                lblName = value;
            }
        }
    }
}