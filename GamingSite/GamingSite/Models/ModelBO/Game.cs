using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;

namespace GamingSite.Models.ModelBO
{
    public class Game
    {
        public int GameId { get; set; }
        public string Name { get; set; }
        public int ReleaseYear { get; set; }
        public string Genre { get; set; }
        public decimal Rating { get; set; }
        public string ImageUrl { get; set; }
        public DateTime CreationDate { get; set; }
        public string GameInfo { get; set; }

    }
}