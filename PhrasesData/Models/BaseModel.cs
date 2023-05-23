namespace Phrases.Data.Models
{
    public abstract class BaseModel
    {
        public Guid ID { get; set; }
        public BaseModel() { ID = Guid.NewGuid(); }
    }
}
