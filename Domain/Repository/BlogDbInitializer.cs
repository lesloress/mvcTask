﻿using Domain.Entities;
using System;
using System.Collections.Generic;
using System.Data.Entity;

namespace Domain.Repository
{
    //Custom db initializer
    public class BlogDbInitializer : CreateDatabaseIfNotExists<BlogContext>
    {
        protected override void Seed(BlogContext context)
        {
            IList<Article> defaultArticles = new List<Article>();
            IList<Comment> defaultComments = new List<Comment>();

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
                Date = DateTime.Now.Date
            });

            defaultArticles.Add(new Article()
            {
                Title = "Теренс Конран: дизайнер, который заново изобрел удобство",
                Text = "Будущий основатель Лондонского Музея дизайна родился в 1931 году в семье бизнесмена из Южной Африки. " +
                "В 21 год Теренс заканчивает Центральную школу Искусства и Дизайна. В 1951 году принимает участие в своём первом " +
                "профессиональном проекте — создании интерьера гидросамолета. Ещё через год открывает мебельную студию Conran & Company. "+
                "\n1955 год отмечен одним из первых заметных проектов Конрана — дизайном бутика женской одежды Bazaar для законодательницы " +
                "вкусов Мэри Куант.Уже в этой ранней работе прослеживается позиция автора, которая вскоре оформится в трёх «китов» его " +
                "дизайнерской идеологии: удобство, лаконичность,доступность.",
                Date = DateTime.Now.Date
            });

            defaultComments.Add(new Comment()
            {
                Name = "Иван",
                Text = "Отличные статьи",
                Date = DateTime.Now.Date
            });

            defaultComments.Add(new Comment()
            {
                Name = "Иван",
                Text = "А вам имя Ибрагим о чем нибудь говорит?",
                Date = DateTime.Now.Date
            });

            defaultComments.Add(new Comment()
            {
                Name = "Игорь",
                Text = "Прекрасное имя!",
                Date = DateTime.Now.Date
            });

            context.Articles.AddRange(defaultArticles);
            context.Comments.AddRange(defaultComments);

            base.Seed(context);
        }
    }
}
