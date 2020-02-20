using Blog.DAL.Entities;
using System.Collections.Generic;

namespace Blog.DAL.Interfaces
{
    public interface IArticleRepository : IRepository<Article>
    {
        Article GetArticleWithComments(int id);
        IEnumerable<Article> GetArticlesWithTags();
        IEnumerable<Article> GetArticlesWithSpecialTags(int tagId);
    }
}
