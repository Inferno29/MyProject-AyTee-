namespace MyProjectForWork.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class SeedUsers : DbMigration
    {
        public override void Up()
        {
            Sql(@"
INSERT INTO [dbo].[AspNetUsers] ([Id], [Email], [EmailConfirmed], [PasswordHash], [SecurityStamp], [PhoneNumber], [PhoneNumberConfirmed], [TwoFactorEnabled], [LockoutEndDateUtc], [LockoutEnabled], [AccessFailedCount], [UserName]) VALUES (N'091d1d4f-f436-47a0-bc5c-e606cc478475', N'dejan29_kuzmanovic@live.de', 0, N'AJjkHtA8MjjlcXE/pn/F2mMRpHIOBf4DjFfi8DjZmESdMKeJFo6WmNUntjTFoQiorA==', N'bba42a36-44e6-4403-924a-7e2bfd953002', NULL, 0, 0, NULL, 1, 0, N'dejan29_kuzmanovic@live.de')
INSERT INTO [dbo].[AspNetUsers] ([Id], [Email], [EmailConfirmed], [PasswordHash], [SecurityStamp], [PhoneNumber], [PhoneNumberConfirmed], [TwoFactorEnabled], [LockoutEndDateUtc], [LockoutEnabled], [AccessFailedCount], [UserName]) VALUES (N'e79134e0-0cab-4744-a7bf-e8c17eafb396', N'dejan04_kuzmanovic@outlook.de', 0, N'AAdabcNtwj8yHoaE34ppUs2wTmfFAVFLq+nuo+3AtLFnPJJoHunsqtWxHbnF/hCJyQ==', N'516f7c97-9631-4b90-a21b-72f47bdea359', NULL, 0, 0, NULL, 1, 0, N'dejan04_kuzmanovic@outlook.de')

INSERT INTO [dbo].[AspNetRoles] ([Id], [Name]) VALUES (N'40b7c414-7c10-4f10-b90d-1a59329df624', N'CanEditData')

INSERT INTO [dbo].[AspNetUserRoles] ([UserId], [RoleId]) VALUES (N'091d1d4f-f436-47a0-bc5c-e606cc478475', N'40b7c414-7c10-4f10-b90d-1a59329df624')
");
        }
        
        public override void Down()
        {
        }
    }
}
