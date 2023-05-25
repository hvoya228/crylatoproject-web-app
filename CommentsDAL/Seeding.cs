using Bogus;
using Comments.Data.Enums;
using Comments.Data.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Comments.DAL
{
    public static class Seeding
    {
        public static List<Comment> Comments { get; set; } = new();
        public static List<Reply> Replies { get; set; } = new();
        public static List<Feedback> Feedbacks { get; set; } = new();

        public static void SeedingInit()
        {
            Comments = new Faker<Comment>()
                .RuleFor(x => x.CommentTheme, f => f.Lorem.Word())
                .RuleFor(x => x.CommentText, f => f.Lorem.Text())
                .RuleFor(x => x.CommentPostDate, f => f.Date.Past())
                .Generate(30);

            Replies = new Faker<Reply>()
            .RuleFor(x => x.ReplyText, f => f.Lorem.Text())
            .RuleFor(x => x.ReplyPostDate, f => f.Date.Past())
            .Generate(30);

            Feedbacks = new List<Feedback>()
            {
                new Feedback
                {
                   FeedbackTheme = FeedbackTheme.Comment
                },

                new Feedback
                {
                    FeedbackTheme = FeedbackTheme.LoveIt
                },

                new Feedback
                {
                    FeedbackTheme = FeedbackTheme.Issue
                },

                new Feedback
                {
                    FeedbackTheme = FeedbackTheme.Suggestion
                }
            };

            var commentIds = Comments.Select(x => x.ID).ToList();
            var feedbackIds = Feedbacks.Select(x => x.ID).ToList();
            var random = new Random();

            for(var i = 0; i < Replies.Count; i++)
            {
                Replies[i].ReplyCommentId = commentIds[i];
            }

            for(var i = 0; i < Comments.Count; i++)
            {
                int randomIndex = random.Next(0, feedbackIds.Count);
                Comments[i].CommentFeedbackId = feedbackIds[randomIndex];
            }
        }
    }
}
