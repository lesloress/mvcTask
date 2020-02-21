using Blog.DAL.EF;
using Blog.DAL.Entities;
using Blog.DAL.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Blog.DAL.Repositories
{
    public class TagRepository : Repository<Tag>, ITagRepository
    {
        public BlogContext blogContext
        {
            get { return context as BlogContext; }
        }

        public TagRepository(BlogContext context) : base(context) { }
        public void AddOrUpdateTags(IList<Tag> entities)
        {
            var tagsExist = from tag in blogContext.Tags
                                where entities.Any(e => tag.Name == e.Name)
                                select tag;
            blogContext.Tags.AddRange(entities.Except(tagsExist));
        }
        public IList<Tag> GetTagsByNames(IList<Tag> entities)
        {
            return (from tag in blogContext.Tags
                   where entities.Any(add => tag.Name.Equals(add.Name))
                   select tag).ToList();
        }
    }
}
