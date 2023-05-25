using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Phrases.Data.Dtos
{
    public class TagDto
    {
        public Guid ID { get; set; }
        public string TagName { get; set; } = null!;
    }
}
