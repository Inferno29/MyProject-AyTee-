namespace MyProjectForWork.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class addedNumberOfRatingsColumn : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Books", "NumberOfRatings", c => c.Int(nullable: false));
        }
        
        public override void Down()
        {
            DropColumn("dbo.Books", "NumberOfRatings");
        }
    }
}
