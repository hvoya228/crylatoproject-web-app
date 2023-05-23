using Phrases.Data.Models;

namespace Phrases.DAL.Repositories.Intefaces
{
    public interface IPhraseRepository : IGenericRepository<Phrase>
    {
        Task<IEnumerable<Phrase>> GetAllByTagIdOrderByIdAsync(Guid tagId);
        Task<IEnumerable<Phrase>> GetAllByTagIdOrderByLikesAsync(Guid tagId);
        Task UpdateLikesAsync(Guid id, int likes);
    }
}
