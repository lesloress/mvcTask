using Domain.Entities;
using System.Data.Entity;

namespace Domain.Repository
{
    public class BlogContext : DbContext
    {
        public BlogContext() : base("BlogDb") 
        {
            Database.SetInitializer(new BlogDbInitializer());
        }

        public DbSet<Article> Articles { get; set; }
        public DbSet<Comment> Comments { get; set; }
        public DbSet<Tag> Tags { get; set; }
    }
}
