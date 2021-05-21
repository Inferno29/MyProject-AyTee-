namespace MyProjectForWork.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddDefaultValueToJobActive : DbMigration
    {
        public override void Up()
        {
            DropColumn("dbo.Jobs", "JobActive");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Jobs", "JobActive", c => c.Boolean(nullable: false));
        }
    }
}
