using Blog.DAL.EF;
using Blog.DAL.Entities;
using Blog.DAL.Interfaces;

namespace Blog.DAL.Repositories
{
    public class UnitOfWork : IUnitOfWork
    {
        private readonly BlogContext _context;

        public IArticleRepository Articles { get; private set; }
        public IRepository<Comment> Comments { get; private set; }
        public ITagRepository Tags { get; private set; }
        public IRepository<User> Users { get; private set; }

        public UnitOfWork(BlogContext context)
        {
            _context = context;
            Articles = new ArticleRepository(context);
            Comments = new Repository<Comment>(context);
            Tags = new TagRepository(context);
            Users = new Repository<User>(context);
        }

        public int Complete()
        {
            return _context.SaveChanges();
        }

        public void Dispose()
        {
            _context.Dispose();
        }
    }
}
