using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Comments.Data.Models
{
    [Table("Replies", Schema = "Comments")]
    public class Reply : BaseCommentModel
    {
        public Guid CommentId { get; set; }
        public Comment Comment { get; set; } = null!;
    }
}
