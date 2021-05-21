namespace MyProjectForWork.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddJobActiveBoolToJob : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Jobs", "JobActive", c => c.Boolean(nullable: false));
        }
        
        public override void Down()
        {
            DropColumn("dbo.Jobs", "JobActive");
        }
    }
}
