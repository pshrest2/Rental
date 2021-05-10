namespace MRent.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class SeedUsers : DbMigration
    {
        public override void Up()
        {
            Sql(@"
INSERT INTO [dbo].[AspNetUsers] ([Id], [Email], [EmailConfirmed], [PasswordHash], [SecurityStamp], [PhoneNumber], [PhoneNumberConfirmed], [TwoFactorEnabled], [LockoutEndDateUtc], [LockoutEnabled], [AccessFailedCount], [UserName]) VALUES (N'978d1b6d-cc66-420f-b566-7364fc37caec', N'guest@mrent.com', 0, N'AAUwEw3D/cKR4s9Zn5GbLvzkpSBFegAnFrIuExBxguWqS6+aRdp9t8hTmQlL4/aOaA==', N'5cdeeac1-f98b-499a-9a7d-67026be67386', NULL, 0, 0, NULL, 1, 0, N'guest@mrent.com')
INSERT INTO [dbo].[AspNetUsers] ([Id], [Email], [EmailConfirmed], [PasswordHash], [SecurityStamp], [PhoneNumber], [PhoneNumberConfirmed], [TwoFactorEnabled], [LockoutEndDateUtc], [LockoutEnabled], [AccessFailedCount], [UserName]) VALUES (N'a477d1a5-4839-40a4-96ab-c7d94cd4e1af', N'admin@mrent.com', 0, N'AKmT6oXK+VzPRJV0Q4HanGlLQzL752gfRUOASYFOPG9UaRkMnAfbSGj36JmFGv+yKQ==', N'eced7e48-84f8-45cc-998e-50d5703e6b04', NULL, 0, 0, NULL, 1, 0, N'admin@mrent.com')

INSERT INTO [dbo].[AspNetRoles] ([Id], [Name]) VALUES (N'6e18e321-24ff-4f52-91e5-d32457c5ee47', N'CanManageMovies')

INSERT INTO [dbo].[AspNetUserRoles] ([UserId], [RoleId]) VALUES (N'a477d1a5-4839-40a4-96ab-c7d94cd4e1af', N'6e18e321-24ff-4f52-91e5-d32457c5ee47')
");
        }
        
        public override void Down()
        {
        }
    }
}
