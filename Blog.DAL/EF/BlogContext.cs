using Blog.DAL.Entities;
using System.Data.Entity;

namespace Blog.DAL.EF
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
        public DbSet<User> Users { get; set; }
    }
}
