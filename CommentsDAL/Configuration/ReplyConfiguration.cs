using Comments.Data.Models;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Comments.DAL.Configuration
{
    public class ReplyConfiguration : IEntityTypeConfiguration<Reply>
    {
        public void Configure(EntityTypeBuilder<Reply> builder)
        {
            builder.Property(r => r.ID)
                .HasDefaultValueSql("NEWID()"); ;

            builder.Property(r => r.ReplyText)
                .HasMaxLength(500)
                .IsRequired(true);

            builder.Property(f => f.ReplyPostDate)
                .IsRequired(true)
                .HasDefaultValue(DateTime.Now);

            builder.HasOne(r => r.Comment)
                .WithMany(c => c.Replies)
                .HasForeignKey(r => r.ReplyCommentId);
        }
    }
}
