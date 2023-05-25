using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Phrases.Data.Dtos
{
    public class PhraseDto
    {
        public Guid ID { get; set; }
        public string PhraseName { get; set; } = null!;
        public string PhraseDescription { get; set; } = null!;
        public int PhraseLikes { get; set; }
    }
}
