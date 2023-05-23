namespace Phrases.Data.Models
{
    public class Phrase : BaseModel
    {
        public string Name { get; set; } = null!;
        public string Description { get; set; } = null!;
        public int Likes { get; set; }
        public Guid TagId { get; set; }
        public Guid RegionId { get; set; }
    }
}
