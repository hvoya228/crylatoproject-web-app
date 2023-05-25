using Comments.Data.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace Comments.DAL
{
    public class CommentsContext : DbContext
    {
        public CommentsContext(DbContextOptions<CommentsContext> options) : base(options) { }

        public DbSet<Comment> Comments { get; set; }
        public DbSet<Reply> Replies { get; set; }
        public DbSet<Feedback> Feedbacks { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfigurationsFromAssembly(Assembly.GetExecutingAssembly());

            Seeding.SeedingInit();
            modelBuilder.Entity<Comment>().HasData(Seeding.Comments);
            modelBuilder.Entity<Reply>().HasData(Seeding.Replies);
            modelBuilder.Entity<Feedback>().HasData(Seeding.Feedbacks);
        }
    }
}
