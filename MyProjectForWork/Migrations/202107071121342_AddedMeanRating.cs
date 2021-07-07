namespace MyProjectForWork.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddedMeanRating : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Books", "MeanRatingValue", c => c.Double(nullable: false));
        }
        
        public override void Down()
        {
            DropColumn("dbo.Books", "MeanRatingValue");
        }
    }
}
