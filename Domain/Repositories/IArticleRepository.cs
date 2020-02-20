using Domain.Entities;
using System.Collections.Generic;

namespace Domain.Repositories
{
    public interface IArticleRepository : IRepository<Article>
    {
        Article GetArticleWithComments(int id);
        //IList<Article> GetAnnotations(int page, int pageSize = 3);
    }
}
