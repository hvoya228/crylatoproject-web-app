using Comments.Data.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Comments.Data.Dtos
{
    public class FeedbackDto
    {
        public Guid ID { get; set; }
        public FeedbackTheme FeedbackTheme { get; set; }
    }
}
