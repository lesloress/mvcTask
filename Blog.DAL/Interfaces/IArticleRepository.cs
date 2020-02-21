using Blog.DAL.Entities;
using System.Collections.Generic;

namespace Blog.DAL.Interfaces
{
    public interface IArticleRepository : IRepository<Article>
    {
        Article GetArticleWithComments(int id);
        Article GetArticleWithTags(int id);
        IEnumerable<Article> GetAllArticlesWithTags();
        IEnumerable<Article> GetAllArticlesWithSpecialTags(string name);
    }
}
