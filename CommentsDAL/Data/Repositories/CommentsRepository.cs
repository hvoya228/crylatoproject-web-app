using Comments.DAL.Interfaces.Repositories;
using Comments.Data.Models;

namespace Comments.DAL.Data.Repositories
{
    public class CommentsRepository : GenericRepository<Comment>, ICommentsRepository
    {
        public CommentsRepository(CommentsContext databaseContext) : base(databaseContext)
        {
        }

        public override Task<Comment> GetCompleteEntityAsync(int id)
        {
            throw new NotImplementedException();
        }
    }
}
