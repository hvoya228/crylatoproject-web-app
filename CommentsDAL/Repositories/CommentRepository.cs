using Comments.DAL.Repositories.Interfaces;
using Comments.Data.Models;
using Microsoft.Data.SqlClient;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.WebSockets;
using System.Text;
using System.Threading.Tasks;

namespace Comments.DAL.Repositories
{
    public class CommentRepository : GenericRepository<Comment>, ICommentRepository
    {
        public CommentRepository(CommentsContext databaseContext) : base(databaseContext) {}

        public async Task<List<CompleteComment>> GetAllComplete()
        {
            var result = new List<CompleteComment>();

            var comments = await databaseContext
                .Comments
                .AsNoTracking()
                .ToListAsync();

            var feedbacks = await databaseContext
                .Feedbacks
                .AsNoTracking()
                .ToListAsync();

            for(int i = 0; i < comments.Count; i++)
            {
                CompleteComment completeComment = new CompleteComment();
                completeComment.ID = comments[i].ID;
                completeComment.CommentTheme = comments[i].CommentTheme;
                completeComment.CommentText = comments[i].CommentText;
                completeComment.CommentPostDate = comments[i].CommentPostDate;

                for(int j = 0; j < feedbacks.Count; j++)
                {
                    if (comments[i].CommentFeedbackId == feedbacks[j].ID)
                    {
                        completeComment.FeedbackTheme = feedbacks[j].FeedbackTheme;
                    }
                }

                result.Add(completeComment);
            }

            return result;
        }
    }
}
