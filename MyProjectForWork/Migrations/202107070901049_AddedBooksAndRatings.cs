namespace MyProjectForWork.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddedBooksAndRatings : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Books",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Title = c.String(),
                        CoverImage = c.String(),
                        Description = c.String(),
                        ReleaseDate = c.DateTime(nullable: false),
                        RatingId = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Ratings", t => t.RatingId, cascadeDelete: true)
                .Index(t => t.RatingId);
            
            CreateTable(
                "dbo.Ratings",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Books", "RatingId", "dbo.Ratings");
            DropIndex("dbo.Books", new[] { "RatingId" });
            DropTable("dbo.Ratings");
            DropTable("dbo.Books");
        }
    }
}
