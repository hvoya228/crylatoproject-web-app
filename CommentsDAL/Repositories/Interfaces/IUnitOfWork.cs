using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Comments.DAL.Repositories.Interfaces
{
    public interface IUnitOfWork
    {
        ICommentRepository CommentRepository { get; }
        IReplyRepository ReplyRepository { get; }
        IFeedbackRepository FeedbackRepository { get; }

        Task SaveChangesAsync();
    }
}
