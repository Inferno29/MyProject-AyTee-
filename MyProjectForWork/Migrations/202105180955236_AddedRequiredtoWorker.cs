namespace MyProjectForWork.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddedRequiredtoWorker : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.Workers", "Name", c => c.String(nullable: false));
            AlterColumn("dbo.Workers", "SurName", c => c.String(nullable: false));
            AlterColumn("dbo.Workers", "UName", c => c.String(nullable: false));
        }
        
        public override void Down()
        {
            AlterColumn("dbo.Workers", "UName", c => c.String());
            AlterColumn("dbo.Workers", "SurName", c => c.String());
            AlterColumn("dbo.Workers", "Name", c => c.String());
        }
    }
}
