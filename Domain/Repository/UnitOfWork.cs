using Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Repository
{
    public class UnitOfWork : IUnitOfWork
    {
        private readonly BlogContext _context;

        public IArticleRepository Articles { get; private set; }
        public IRepository<Comment> Comments { get; private set; }
        public IRepository<Tag> Tags { get; private set; }

        public UnitOfWork(BlogContext context)
        {
            _context = context;
            Articles = new ArticleRepository(context);
            Comments = new Repository<Comment>(context);
            Tags = new Repository<Tag>(context);
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
