namespace Phrases.Data.Models
{
    public class Phrase : BaseModel
    {
        public string PhraseName { get; set; } = null!;
        public string PhraseDescription { get; set; } = null!;
        public int PhraseLikes { get; set; }
        public Guid PhraseTagId { get; set; }
        public Guid PhraseRegionId { get; set; }
    }
}
