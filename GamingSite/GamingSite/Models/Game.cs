using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace GamingSite.Models
{
    public class Game
    {
        public string Name { get; set; }
        public int ReleaseYear { get; set; }
        public string Genre { get; set; }
        public float Rating { get; set; }
        public string ImageUrl { get; set; }
    }
}