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
        public IReplyRepository ReplyRepository { get; }
        public IFeedbackRepository FeedbackRepository { get; }

        /// <summary>
        /// Saves already implemneted changes in database
        /// </summary>
        /// <returns>Nothing</returns>
        public async Task SaveChangesAsync()
        {
            await databaseContext.SaveChangesAsync();
        }

        public UnitOfWork(
        CommentsContext databaseContext,
        ICommentRepository commentRepository,
        IReplyRepository replyRepository,
        IFeedbackRepository feedbackRepository)
        {
            this.databaseContext = databaseContext;
            CommentRepository = commentRepository;
            ReplyRepository = replyRepository;
            FeedbackRepository = feedbackRepository;
        }
    }
}
