using Comments.DAL.Entities;
using Comments.DAL.Interfaces;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Comments.DAL.Seeding
{
    public class CommentSeeder : ISeeder<Comment>
    {
        private static readonly List<Comment> comments = new()
        {
            new Comment
            {
                Id = 1,
                Text = "Wow!"
            },

            new Comment
            {
                Id = 2,
                Text = "Amazing!"
            }
        };

        public void Seed(EntityTypeBuilder<Comment> builder) => builder.HasData(comments);
    }
}
