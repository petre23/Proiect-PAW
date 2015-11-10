using Controller.Interfaces;
using Model.ModelBO;
using Model.ModelDAO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Controller.ModelBL
{
    public class GamePageController
    {
        IGamePage _form;
        GameDAO _gameDAO;
        Game _game;

        public GamePageController(IGamePage form) 
        {
            _form = form;
            _gameDAO = new GameDAO();
            _game = new Game();
        }

        private void SetGame() 
        {
            _game = _gameDAO.GetGameById(2);
        }

        public void LoadGamePage() 
        {
            SetGame();
            _form.GameImage.ImageUrl = _game.ImageUrl;
            _form.LblGameInfo.Text = _game.GameInfo;
            _form.LblGenre.Text = _game.Genre;
            _form.LblName.Text = _game.Name;
            _form.LblReleaseYear.Text = _game.ReleaseYear.ToString();
        }
    }
}
