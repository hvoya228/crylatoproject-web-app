using Comments.Data.Enums;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Comments.Data.Models
{
    [Table("Feedbacks", Schema = "Comments")]
    public class Feedback : BaseModel
    {
        public FeedbackTheme FeedbackTheme { get; set; }
        public Guid CommentId { get; set; }
        public Comment Comment { get; set; } = null!;
    }
}
