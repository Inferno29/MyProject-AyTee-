namespace MyProjectForWork.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class RemovedProperty : DbMigration
    {
        public override void Up()
        {
            DropColumn("dbo.Books", "Mean");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Books", "Mean", c => c.Decimal(nullable: false, precision: 18, scale: 2));
        }
    }
}
