namespace Domain.Migrations
{
    using Domain.Entities;
    using System.Data.Entity.Migrations;

    internal sealed class Configuration : DbMigrationsConfiguration<Domain.EF.BlogContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = false;
            ContextKey = "Domain.Repository.BlogContext";
        }

        protected override void Seed(Domain.EF.BlogContext context)
        {
            //  This method will be called after migrating to the latest version.

            //  You can use the DbSet<T>.AddOrUpdate() helper extension method
            //  to avoid creating duplicate seed data.
            context.Tags.AddOrUpdate(t => t.Id,
                new Tag() { Id = 1, Name = "Интерьер" },
                new Tag() { Id = 2, Name = "Архитектура" },
                new Tag() { Id = 3, Name = "Графический дизайн" },
                new Tag() { Id = 4, Name = "Искусство" });
        }
    }
}
