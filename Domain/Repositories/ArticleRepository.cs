using Domain.EF;
using Domain.Entities;
using System.Data.Entity;
using System.Linq;

namespace Domain.Repositories
{
    public class ArticleRepository : Repository<Article>, IArticleRepository
    {
        public BlogContext blogContext
        {
            get { return context as BlogContext; }
        }
        public ArticleRepository(BlogContext context) : base(context) { }

        public Article GetArticleWithComments(int id)
        {
            Article article = blogContext.Articles
                .Include(a => a.Comments)
                .Include(a => a.Tags)
                .Where(a => a.Id == id)
                .FirstOrDefault();

            if (article != null)
                article.Comments = article.Comments.OrderByDescending(c => c.Date).ToList();

            return article;
        }


    }
}
