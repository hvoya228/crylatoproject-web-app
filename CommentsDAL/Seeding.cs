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
                .RuleFor(x => x.Theme, f => f.Lorem.Word())
                .RuleFor(x => x.Text, f => f.Lorem.Text())
                .RuleFor(x => x.PostDate, f => f.Date.Past())
                .Generate(30);

            Replies = new Faker<Reply>()
            .RuleFor(x => x.Text, f => f.Lorem.Text())
            .RuleFor(x => x.PostDate, f => f.Date.Past())
            .Generate(30);

            Feedbacks = new Faker<Feedback>()
                .RuleFor(x => x.FeedbackTheme, f => f.PickRandom<FeedbackTheme>())
                .Generate(30);

            var commentIds = Comments.Select(x => x.ID).ToList();

            for(var i = 0; i < Replies.Count; i++)
            {
                Replies[i].CommentId = commentIds[i];
            }

            for(var i = 0; i < Feedbacks.Count; i++)
            {
                Feedbacks[i].CommentId = commentIds[i];
            }
        }
    }
}
