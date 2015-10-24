using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model.ModelBO
{
    public class Comment
    {
        public int CommentId { get; set; }
        public string UserId { get; set; }
        public int GameId{get;set;}
        public string CommentText { get; set; }
    }
}
