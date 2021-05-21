namespace MyProjectForWork.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddDefaultValue : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Jobs", "JobActive", c => c.Boolean(nullable: false, defaultValue:true));
        }
        
        public override void Down()
        {
            DropColumn("dbo.Jobs", "JobActive");
        }
    }
}
