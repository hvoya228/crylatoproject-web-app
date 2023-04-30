using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CommentsDAL.Entities
{
    public class Comment
    {
        public string? Text { get; set; }
        public int Id { get; set; }
        public List<Reaction>? Reactions { get; set; }
    }
}
