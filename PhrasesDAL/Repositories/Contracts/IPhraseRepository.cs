using PhrasesDAL.Entities;

namespace PhrasesDAL.Repositories.Contracts
{
    public interface IPhraseRepository : IGenericRepository<Phrase>
    {
        Task<IEnumerable<Phrase>> GetAllByTagIdOrderByIdAsync(int tagId);
        Task<IEnumerable<Phrase>> GetAllByTagIdOrderByLikesAsync(int tagId);
        Task UpdateLikesAsync(int id, int likes);
    }
}
