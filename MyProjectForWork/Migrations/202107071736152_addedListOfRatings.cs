namespace MyProjectForWork.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class addedListOfRatings : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Books", "ListOfRatings", c => c.Int(nullable: false));
        }
        
        public override void Down()
        {
            DropColumn("dbo.Books", "ListOfRatings");
        }
    }
}
