using CommentsDAL.Entities;
using CommentsDAL.Interfaces.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CommentsDAL.Data.Repositories
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
