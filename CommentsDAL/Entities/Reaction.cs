using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Comments.DAL.Entities
{
    public class Reaction
    {
        public string? Type { get; set; }
        public int Count { get; set; }
        public int Id { get; set; }
        public int CommentId { get; set; }
        public Comment? Comment { get; set; }
    }
}
