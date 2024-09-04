namespace Traveling.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class DeleteColumnGeographyFromTableDesntinationsAndColumnDestinationsFromTableGeographies : DbMigration
    {
        public override void Up()
        {
            DropForeignKey("dbo.Destinations", "GeographyId", "dbo.Geographies");
            DropIndex("dbo.Destinations", new[] { "GeographyId" });
            DropColumn("dbo.Destinations", "GeographyId");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Destinations", "GeographyId", c => c.Int(nullable: false));
            CreateIndex("dbo.Destinations", "GeographyId");
            AddForeignKey("dbo.Destinations", "GeographyId", "dbo.Geographies", "Id", cascadeDelete: true);
        }
    }
}
