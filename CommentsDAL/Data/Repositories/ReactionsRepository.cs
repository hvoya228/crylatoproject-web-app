using CommentsDAL.Entities;
using CommentsDAL.Interfaces.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CommentsDAL.Data.Repositories
{
    public class ReactionsRepository : GenericRepository<Reaction>, IReactionsRepository
    {
        public ReactionsRepository(CommentsContext databaseContext) : base(databaseContext)
        {
        }

        public override Task<Reaction> GetCompleteEntityAsync(int id)
        {
            throw new NotImplementedException();
        }
    }
}
