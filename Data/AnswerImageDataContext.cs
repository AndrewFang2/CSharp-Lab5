using Microsoft.EntityFrameworkCore;
using Lab5.Models;

namespace Lab5.Data
{
    public class AnswerImageDataContext : DbContext
    {
        public AnswerImageDataContext(DbContextOptions<AnswerImageDataContext> options) : base(options){ }
        public DbSet<AnswerImage> Images { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<AnswerImage>().ToTable("Images");
        }

    }
}
