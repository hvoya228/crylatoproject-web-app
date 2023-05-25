using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Comments.Data.Dtos
{
    public class ReplyDto
    {
        public Guid ID { get; set; }
        public string ReplyText { get; set; } = null!;
        public DateTime ReplyPostDate { get; set; }
        public Guid ReplyCommentId { get; set; }
    }
}
