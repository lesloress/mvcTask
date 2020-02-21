using Blog.DAL.Entities;
using System;
using System.Collections.Generic;
using System.Data.Entity;

namespace Blog.DAL.EF
{
    //Custom db initializer
    public class BlogDbInitializer : DropCreateDatabaseIfModelChanges<BlogContext>
    {
        protected override void Seed(BlogContext context)
        {
            IList<User> defaultUsers = new List<User>();
            IList<Article> defaultArticles = new List<Article>();
            IList<Comment> defaultComments = new List<Comment>();
            IList<Tag> defaultTags = new List<Tag>();

            defaultUsers.Add(new User()
            {
                Username = "firstUser",
                Email = "firstUser@gmail.com",
                Password = "1234"
            });
            defaultUsers.Add(new User()
            {
                Username = "prodesigner",
                Email = "prodesigner@gmail.com",
                Password = "4321"
            });

            defaultTags.Add(new Tag() {Name = "Интерьер" });
            defaultTags.Add(new Tag() {Name = "Архитектура" });
            defaultTags.Add(new Tag() {Name = "Графический дизайн" });
            defaultTags.Add(new Tag() {Name = "Искусство" });
            defaultTags.Add(new Tag() {Name = "Экологический дизайн" });

            defaultArticles.Add(new Article()
            {
                Title = "Главное о дизайне в 2020",
                Text = "Эклектичные решения прочно закрепились в современном дизайне как один из самых практичных и " +
                "жизнеспособных трендов. Особым обаянием покорило дизайнеров сочетание минимализма и легкого гранжа. " +
                "Для спальни это отличное решение: с одной стороны — ничего лишнего, с другой — искусно воспроизведенные " +
                "«несовершенства» расслабляют человека, позволяют ему чувствовать себя непринужденно. Воплотить такое решение " +
                "нетрудно: декоративная штукатурка с эффектом шероховатого бетона или разводов, кирпичная кладка на стене, " +
                "грубый текстиль и искусственно состаренный металл, винтажная мебель — и так далее, и тому подобное.\n" +
                "Морские» тона, то есть практически вся сине-зеленая гамма, обещают быть в 2020 году на гребне волны — " +
                "извините за каламбур. В спальне они особенно уместны, так как освежают, позволяют глазам отдохнуть, " +
                "расслабляют. Конечно, лучше всего отдавать предпочтение мягким оттенкам — глубоким, слегла припыленным, " +
                "линялым. Одну стену можно сделать акцентной — лучше всего ту, которая за изголовьем кровати: так вы не " +
                "будете видеть ее, отходя ко сну, и яркие краски не помешают вам расслабиться.",
                Date = DateTime.Now.Date,
                User = defaultUsers[0],
                Comments = new List<Comment> 
                {
                    new Comment {
                        Name = "имя фамилия",
                        Text = "Где ссылка на оригинал?",
                        Date = DateTime.Now.Date
                    },
                    new Comment {
                        Name = "Геральт из Ривии",
                        Text = "шевелись плотва",
                        Date = DateTime.Now.Date
                    }
                },
                Tags = new List<Tag> 
                { 
                    defaultTags[2], 
                    defaultTags[3]
                }
            }) ;
            defaultArticles.Add(new Article()
            {
                Title = "Теренс Конран: дизайнер, который заново изобрел удобство",
                Text = "Будущий основатель Лондонского Музея дизайна родился в 1931 году в семье бизнесмена из Южной Африки. " +
                "В 21 год Теренс заканчивает Центральную школу Искусства и Дизайна. В 1951 году принимает участие в своём первом " +
                "профессиональном проекте — создании интерьера гидросамолета. Ещё через год открывает мебельную студию Conran & Company. "+
                "\n1955 год отмечен одним из первых заметных проектов Конрана — дизайном бутика женской одежды Bazaar для законодательницы " +
                "вкусов Мэри Куант.Уже в этой ранней работе прослеживается позиция автора, которая вскоре оформится в трёх «китов» его " +
                "дизайнерской идеологии: удобство, лаконичность,доступность.",
                Date = DateTime.Now.Date,
                User = defaultUsers[1],
                Comments = new List<Comment> 
                {
                    new Comment 
                    {
                        Name = "first last",
                        Text = "Сложно( слишком много букв",
                        Date = DateTime.Now.Date
                    }
                },
                Tags = new List<Tag> 
                {
                    defaultTags[0]
                }
            });
            defaultArticles.Add(new Article()
            {
                Title = "Что такое графический дизайн в 2020?",
                Text = "Графический дизайн – это средство визуальной коммуникации. " +
                "Если сказать проще – это выражение идей, смыслов и ценностей через образы, изображения, " +
                "шрифты, видео и т.п. Интереснейшая современная специализация.\n" +
                "Графический дизайн решает множество разных задач при помощи цветов, форм, изображений, " +
                "композиций и типографики. Решать любые задачи одним способом или инструментом невозможно, " +
                "поэтому существует несколько видов графического дизайна. Обычно дизайнеры специализируются " +
                "на одном виде, но сегодня нужно быть гибким и вникать во все отрасли сферы.",
                Date = DateTime.Now.Date,
                User = defaultUsers[0],
                Tags = new List<Tag> 
                {
                    defaultTags[2]
                }
            });


            defaultComments.Add(new Comment()
            {
                Name = "Иван",
                Text = "Отличные статьи",
                Date = DateTime.Now.Date
            });
            defaultComments.Add(new Comment()
            {
                Name = "Анна",
                Text = "много лишних статей, не по теме",
                Date = DateTime.Now.Date
            });
            defaultComments.Add(new Comment()
            {
                Name = "Игорь",
                Text = "где адаптивность???????",
                Date = DateTime.Now.Date
            });

            

            context.Users.AddRange(defaultUsers);
            context.Tags.AddRange(defaultTags);
            context.Articles.AddRange(defaultArticles);
            context.Comments.AddRange(defaultComments);
            

            base.Seed(context);
        }
    }
}
