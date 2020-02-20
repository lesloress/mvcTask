using AutoMapper;
using Blog.DAL.Entities;
using HomeTask.Models;

namespace HomeTask.Mapping
{
    public static class ArticleMapper
    {
        public static ArticleDetails GetArticleDetails(this Article article)
        {
            var articleconfig = new MapperConfiguration
                        (cfg => cfg.CreateMap<Article, ArticleDetails>()
                        .ForMember("AuthorName", opt => opt.MapFrom(a => a.User.Username))
                        .ForMember("AuthorId", opt => opt.MapFrom(a => a.User.Id))
                        .ForMember("Date", opt => opt.MapFrom(a => a.Date.ToShortDateString()))
                        .ForMember("Comments", opt => opt.MapFrom(a => CommentMapper.GetCommentVM(a.Comments)))
                        .ForMember("Tags", opt => opt.MapFrom(a => TagMapper.GetTagVM(a.Tags))));
            var articlemapper = articleconfig.CreateMapper();
            ArticleDetails details = articlemapper.Map<ArticleDetails>(article);
            return details;
        }
    }
}