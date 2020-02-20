using Blog.DAL.EF;
using Blog.DAL.Entities;
using Blog.DAL.Interfaces;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;

namespace Blog.DAL.Repositories
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

        public IEnumerable<Article> GetArticlesWithTags()
        {
            return blogContext.Articles
                .Include(a => a.Tags)
                .ToList();
        }

        public IEnumerable<Article> GetArticlesWithSpecialTags(int tagId)
        {
            return blogContext.Articles
                .Include(a => a.Tags)
                .Where(a => a.Tags.Any(t => t.Id == tagId))
                .ToList();
        }


    }
}
