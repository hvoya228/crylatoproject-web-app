using CommentsDAL.Entities;
using CommentsDAL.Interfaces;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CommentsDAL.Seeding
{
    public class ReactionSeeder : ISeeder<Reaction>
    {
        private static readonly List<Reaction> reactions = new()
        {
            new Reaction
            {
                Type = "Smile",
                Count = 5,
                Id = 1,
                CommentId = 1
            },
            new Reaction
            {
                Type = "FingerUp",
                Count = 10,
                Id = 2,
                CommentId = 1
            },
            new Reaction
            {
                Type = "Smile",
                Count = 6,
                Id = 3,
                CommentId = 2
            },
            new Reaction
            {
                Type = "FingerUp",
                Count = 7,
                Id = 4,
                CommentId = 2
            },
        };

        public void Seed(EntityTypeBuilder<Reaction> builder) => builder.HasData(reactions);
    }
}
