using Comments.DAL.Repositories.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Comments.DAL.Repositories
{
    public class UnitOfWork : IUnitOfWork
    {
        protected readonly CommentsContext databaseContext;

        public ICommentRepository CommentRepository { get; }

        //public IReactionsRepository ReactionsRepository { get; }

        public async Task SaveChangesAsync()
        {
            await databaseContext.SaveChangesAsync();
        }

        public UnitOfWork(
        CommentsContext databaseContext,
        ICommentRepository commentRepository)
        //IReactionsRepository reactionsRepository)
        {
            this.databaseContext = databaseContext;
            CommentRepository = commentRepository;
            //ReactionsRepository = reactionsRepository;
        }
    }
}
