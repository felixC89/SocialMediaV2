using Microsoft.EntityFrameworkCore;
using SocialMedia.Core.Entities;
using SocialMedia.InfraStructure.Data.Configurations;

namespace SocialMedia.InfraStructure.Data
{
    public partial class SocialMediadbContext : DbContext
    {
        public SocialMediadbContext()
        {
        }

        public SocialMediadbContext(DbContextOptions<SocialMediadbContext> options)
            : base(options)
        {
        }

        public virtual DbSet<Comment> Comments { get; set; }
        public virtual DbSet<Post> Posts { get; set; }
        public virtual DbSet<User> Users { get; set; }
        
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfiguration(new CommentConfiguration());
            modelBuilder.ApplyConfiguration(new PostConfiguration());
            modelBuilder.ApplyConfiguration(new UserConfiguration());
        }
    }
}
