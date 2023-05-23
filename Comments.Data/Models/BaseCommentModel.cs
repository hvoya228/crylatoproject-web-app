using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Comments.Data.Models
{
    public abstract class BaseCommentModel : BaseModel
    {
        public string Text { get; set; } = null!;
        public DateTime PostDate { get; set; }
    }
}
