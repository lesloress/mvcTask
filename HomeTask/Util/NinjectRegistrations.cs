using Blog.DAL.Entities;
using Blog.DAL.Interfaces;
using Blog.DAL.Repositories;
using Ninject.Modules;

namespace HomeTask.Util
{
    public class NinjectRegistrations : NinjectModule
    {
        public override void Load()
        {
            Bind<IArticleRepository>().To<ArticleRepository>();
            Bind<ITagRepository>().To<TagRepository>();
            Bind<IRepository<Comment>>().To<Repository<Comment>>();
            Bind<IRepository<User>>().To<Repository<User>>();
        }
    }
}