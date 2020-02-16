using Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Repository
{
    public interface IUnitOfWork : IDisposable
    {
        IArticleRepository Articles { get; }
        IRepository<Comment> Comments { get; }
        IRepository<Tag> Tags { get; }
        int Complete();
    }
}
