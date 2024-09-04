namespace Traveling.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class MadeColumnGeographyOptionalOnTableDestinations : DbMigration
    {
        public override void Up()
        {
            DropForeignKey("dbo.Destinations", "GeographyId", "dbo.Geographies");
            AddForeignKey("dbo.Destinations", "GeographyId", "dbo.Geographies", "Id", cascadeDelete: false);// modified cascadeDelete
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Destinations", "GeographyId", "dbo.Geographies");
            AddForeignKey("dbo.Destinations", "GeographyId", "dbo.Geographies", "Id");
        }
    }
}
