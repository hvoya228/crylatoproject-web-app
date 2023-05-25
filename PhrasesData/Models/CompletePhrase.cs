using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Phrases.Data.Models
{
    public class CompletePhrase : BaseModel
    {
        public string PhraseName { get; set; } = null!;
        public string PhraseDescription { get; set; } = null!;
        public int PhraseLikes { get; set; }
        public string TagName { get; set; } = null!;
        public string RegionName { get; set; } = null!;
    }
}
