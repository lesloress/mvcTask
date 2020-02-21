using Blog.DAL.Entities;
using System.Collections.Generic;
namespace Blog.DAL.Interfaces
{
    public interface ITagRepository : IRepository<Tag>
    {
        void AddOrUpdateTags(IList<Tag> entities);
        IList<Tag> GetTagsByNames(IList<Tag> entities);
    }
}
