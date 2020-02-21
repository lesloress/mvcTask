namespace Blog.DAL.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class ChangeTagPK : DbMigration
    {
        public override void Up()
        {
            DropForeignKey("dbo.TagArticles", "Tag_Id", "dbo.Tags");
            DropIndex("dbo.TagArticles", new[] { "Tag_Id" });
            RenameColumn(table: "dbo.TagArticles", name: "Tag_Id", newName: "Tag_Name");
            DropPrimaryKey("dbo.Tags");
            DropPrimaryKey("dbo.TagArticles");
            AlterColumn("dbo.TagArticles", "Tag_Name", c => c.String(nullable: false, maxLength: 24));
            AddPrimaryKey("dbo.Tags", "Name");
            AddPrimaryKey("dbo.TagArticles", new[] { "Tag_Name", "Article_Id" });
            CreateIndex("dbo.TagArticles", "Tag_Name");
            AddForeignKey("dbo.TagArticles", "Tag_Name", "dbo.Tags", "Name", cascadeDelete: true);
            DropColumn("dbo.Tags", "Id");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Tags", "Id", c => c.Int(nullable: false, identity: true));
            DropForeignKey("dbo.TagArticles", "Tag_Name", "dbo.Tags");
            DropIndex("dbo.TagArticles", new[] { "Tag_Name" });
            DropPrimaryKey("dbo.TagArticles");
            DropPrimaryKey("dbo.Tags");
            AlterColumn("dbo.TagArticles", "Tag_Name", c => c.Int(nullable: false));
            AddPrimaryKey("dbo.TagArticles", new[] { "Tag_Id", "Article_Id" });
            AddPrimaryKey("dbo.Tags", "Id");
            RenameColumn(table: "dbo.TagArticles", name: "Tag_Name", newName: "Tag_Id");
            CreateIndex("dbo.TagArticles", "Tag_Id");
            AddForeignKey("dbo.TagArticles", "Tag_Id", "dbo.Tags", "Id", cascadeDelete: true);
        }
    }
}
