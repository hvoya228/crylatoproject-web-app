using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Phrases.Data.Dtos
{
    public class RegionDto
    {
        public Guid ID { get; set; }
        public string RegionName { get; set; } = null!;
    }
}
