using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Comments.Data.Models
{
    [Table("Comments", Schema = "Comments")]
    public class Comment : BaseModel
    {
        public string CommentTheme { get; set; } = null!;
        public string CommentText { get; set; } = null!;
        public DateTime CommentPostDate { get; set; }
        public ICollection<Reply> Replies { get; set; } = null!;
        public Guid CommentFeedbackId { get; set; }
        public Feedback Feedback { get; set; } = null!;
    }
}
