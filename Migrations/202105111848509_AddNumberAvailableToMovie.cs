namespace MRent.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddNumberAvailableToMovie : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Rentals", "NumberAvailable", c => c.Byte(nullable: false));
           
        }
        
        public override void Down()
        {
            DropColumn("dbo.Rentals", "NumberAvailable");
        }
    }
}
