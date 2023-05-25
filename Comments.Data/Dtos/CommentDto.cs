using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Comments.Data.Dtos
{
    public class CommentDto
    {
        public Guid ID { get; set; }
        public string CommentTheme { get; set; } = null!;
        public string CommentText { get; set; } = null!;
        public DateTime CommentPostDate { get; set; }
        public Guid CommentFeedbackId { get; set; }
    }
}
