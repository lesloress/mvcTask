namespace Blog.DAL.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddIsDeletedToArticle : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Articles", "isDeleted", c => c.Boolean(nullable: false));
        }
        
        public override void Down()
        {
            DropColumn("dbo.Articles", "isDeleted");
        }
    }
}
