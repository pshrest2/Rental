namespace MRent.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddUpdateAdditionalAttributes : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Rentals", "DateRented", c => c.DateTime(nullable: false));
            AddColumn("dbo.Rentals", "NumberInStock", c => c.Byte(nullable: false));
            DropColumn("dbo.Rentals", "Date");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Rentals", "Date", c => c.DateTime(nullable: false));
            DropColumn("dbo.Rentals", "NumberInStock");
            DropColumn("dbo.Rentals", "DateRented");
        }
    }
}
