using Blog.DAL.Entities;
using System;

namespace Blog.DAL.Interfaces
{
    public interface IUnitOfWork : IDisposable
    {
        IArticleRepository Articles { get; }
        IRepository<Comment> Comments { get; }
        IRepository<Tag> Tags { get; }
        IRepository<User> Users { get; }
        int Complete();
    }
}
