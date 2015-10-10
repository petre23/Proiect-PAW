using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace GamingSite.Models.ModelBO
{
    public class User
    {
        public bool IsAdmin { get; set; }
        public string Username { get; set; }
        public string Password { get; set; }
    }
}