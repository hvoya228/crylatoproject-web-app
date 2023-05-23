using Comments.DAL.Entities;
using Comments.DAL.Seeding;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Comments.DAL.Configuration
{
    public class CommentConfiguration : IEntityTypeConfiguration<Comment>
    {
        public void Configure(EntityTypeBuilder<Comment> builder)
        {
            builder.Property(comment => comment.Id)
                   .UseIdentityColumn()
                   .IsRequired();

            builder.Property(comment => comment.Text)
                   .HasMaxLength(100)
                   .IsRequired();

            new CommentSeeder().Seed(builder);
        }
    }
}
