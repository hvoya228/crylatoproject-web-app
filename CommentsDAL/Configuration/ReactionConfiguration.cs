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
    public class ReactionConfiguration : IEntityTypeConfiguration<Reaction>
    {
        public void Configure(EntityTypeBuilder<Reaction> builder)
        {
            builder.Property(reaction => reaction.Id)
                   .UseIdentityColumn()
                   .IsRequired();

            builder.Property(reaction => reaction.Type)
                   .HasMaxLength(50);

            builder.Property(reaction => reaction.Count)
                   .HasDefaultValue(0);

            builder.HasOne(reaction => reaction.Comment)
                   .WithMany(comment => comment.Reactions)
                   .HasForeignKey(reaction => reaction.CommentId)
                   .OnDelete(DeleteBehavior.Cascade)
                   .HasConstraintName("FK_Reactions_CommentId");

            new ReactionSeeder().Seed(builder);
        }
    }
}
