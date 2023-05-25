using Phrases.Data.Models;

namespace Phrases.DAL.Repositories.Intefaces
{
    public interface IPhraseRepository : IGenericRepository<Phrase>
    {
        Task<List<CompletePhrase>> GetAllComplete();
        Task<List<CompletePhrase>> GetAllCompleteOrderedByLikes();
        Task<List<CompletePhrase>> GetAllCompleteByTagId(Guid tagId);
        Task<List<CompletePhrase>> GetAllCompleteByRegionId(Guid regionId);
        Task UpdateLikesById(Guid id, int likes);
    }
}
