using Comments.DAL.Repositories.Interfaces;
using Comments.Data.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Comments.DAL.Repositories
{
    public class ReplyRepository : GenericRepository<Reply>, IReplyRepository
    {
        public ReplyRepository(CommentsContext databaseContext) : base(databaseContext) { }
    }
}
