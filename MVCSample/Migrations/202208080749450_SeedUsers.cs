namespace MVCSample.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class SeedUsers : DbMigration
    {
        public override void Up()
        {
            Sql(@"
            INSERT INTO [dbo].[AspNetUsers] ([Id], [Email], [EmailConfirmed], [PasswordHash], [SecurityStamp], [PhoneNumber], [PhoneNumberConfirmed], [TwoFactorEnabled], [LockoutEndDateUtc], [LockoutEnabled], [AccessFailedCount], [UserName]) VALUES (N'3ad4851f-4cc2-47f3-a0d6-ad125eb65f83', N'admin@gmail.com', 0, N'AFYMjWfKQQ0fQX+lF8RaWqA+FEAXOqGwuz+4Ft3pzi9Pml9ly3mk6gyZ983+/UnRbQ==', N'd578fe8a-7aed-41d7-9549-97470f57c29d', NULL, 0, 0, NULL, 1, 0, N'admin@gmail.com')
            INSERT INTO [dbo].[AspNetUsers] ([Id], [Email], [EmailConfirmed], [PasswordHash], [SecurityStamp], [PhoneNumber], [PhoneNumberConfirmed], [TwoFactorEnabled], [LockoutEndDateUtc], [LockoutEnabled], [AccessFailedCount], [UserName]) VALUES (N'7f1ad341-8b71-4782-9c9b-ec557919e080', N'benjamindavid023@gmail.com', 0, N'ACuvORaNxA1wicoFFTVTAdBcV142PgjFDmlQtZrVZ2sZ3b6th4tdC6VSlqYehZ5GPA==', N'db547c1c-ed68-4cd4-b721-0ccbc11055ab', NULL, 0, 0, NULL, 1, 0, N'benjamindavid023@gmail.com')
            INSERT INTO [dbo].[AspNetUsers] ([Id], [Email], [EmailConfirmed], [PasswordHash], [SecurityStamp], [PhoneNumber], [PhoneNumberConfirmed], [TwoFactorEnabled], [LockoutEndDateUtc], [LockoutEnabled], [AccessFailedCount], [UserName]) VALUES (N'a3d0e12c-506a-4066-a949-84b4ccdbefc2', N'davidraje@gmail.com', 0, N'ACrHqUCM20zOwucR1EQDqUAsiBLmEJJY7qTTh+P/X9KTmtTfiDk0GAPXJq/ud6z9hw==', N'c7306f6e-4566-415f-b496-751238bbeda0', NULL, 0, 0, NULL, 1, 0, N'davidraje@gmail.com')
            INSERT INTO [dbo].[AspNetRoles] ([Id], [Name]) VALUES (N'3dc68eb8-35ba-478c-85af-f1d48561d747', N'CanManageMovies')
            INSERT INTO [dbo].[AspNetUserRoles] ([UserId], [RoleId]) VALUES (N'3ad4851f-4cc2-47f3-a0d6-ad125eb65f83', N'3dc68eb8-35ba-478c-85af-f1d48561d747')
            ");
        }
        
        public override void Down()
        {
        }
    }
}
