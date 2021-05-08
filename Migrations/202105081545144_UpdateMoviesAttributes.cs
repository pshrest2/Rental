namespace MRent.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class UpdateMoviesAttributes : DbMigration
    {
        public override void Up()
        {
            Sql("UPDATE Movies SET Genre = 'Comedy', ReleaseDate = GETDATE(), DateAdded = '2015-12-7', Stock = 10 WHERE Id = 1");
            Sql("UPDATE Movies SET Genre = 'Romance', ReleaseDate = '2007-11-1', DateAdded ='2009-11-1', Stock = 2 WHERE Id = 2");
            Sql("UPDATE Movies SET Genre = 'Action', ReleaseDate = '1998-06-17', DateAdded = '2001-1-3', Stock = 9 WHERE Id = 3");
            Sql("UPDATE Movies SET Genre = 'Horror', ReleaseDate = GETDATE(), DateAdded = '2013-4-6', Stock = 7 WHERE Id = 4");
        }
        
        public override void Down()
        {
        }
    }
}
