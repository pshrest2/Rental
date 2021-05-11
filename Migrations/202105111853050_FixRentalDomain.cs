namespace MRent.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class FixRentalDomain : DbMigration
    {
        public override void Up()
        {
            DropColumn("dbo.Rentals", "NumberInStock");
            DropColumn("dbo.Rentals", "NumberAvailable");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Rentals", "NumberAvailable", c => c.Byte(nullable: false));
            AddColumn("dbo.Rentals", "NumberInStock", c => c.Byte(nullable: false));
        }
    }
}
