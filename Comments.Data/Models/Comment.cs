using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Comments.Data.Models
{
    [Table("Comments", Schema = "Comments")]
    public class Comment : BaseCommentModel
    {
        public string Theme { get; set; } = null!;
        public ICollection<Reply> Replies { get; set; } = null!;
        public Guid FeedbackId { get; set; }
        public Feedback Feedback { get; set; } = null!;
    }
}
