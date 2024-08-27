namespace Traveling.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class InitialModel : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Destinations",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(nullable: false, maxLength: 60),
                        Description = c.String(nullable: false, maxLength: 120),
                        GeographyId = c.Int(nullable: false),
                        DateAdded = c.DateTime(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Geographies", t => t.GeographyId)
                .Index(t => t.GeographyId);
            
            CreateTable(
                "dbo.TravelCategories",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(nullable: false, maxLength: 30),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.Geographies",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Country = c.String(nullable: false),
                        Continent = c.String(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.Tips",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Title = c.String(nullable: false, maxLength: 35),
                        TipText = c.String(nullable: false, maxLength: 90),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.DestinationCategories",
                c => new
                    {
                        DestinationId = c.Int(nullable: false),
                        CategoryId = c.Int(nullable: false),
                    })
                .PrimaryKey(t => new { t.DestinationId, t.CategoryId })
                .ForeignKey("dbo.Destinations", t => t.DestinationId, cascadeDelete: true)
                .ForeignKey("dbo.TravelCategories", t => t.CategoryId, cascadeDelete: true)
                .Index(t => t.DestinationId)
                .Index(t => t.CategoryId);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Destinations", "GeographyId", "dbo.Geographies");
            DropForeignKey("dbo.DestinationCategories", "CategoryId", "dbo.TravelCategories");
            DropForeignKey("dbo.DestinationCategories", "DestinationId", "dbo.Destinations");
            DropIndex("dbo.DestinationCategories", new[] { "CategoryId" });
            DropIndex("dbo.DestinationCategories", new[] { "DestinationId" });
            DropIndex("dbo.Destinations", new[] { "GeographyId" });
            DropTable("dbo.DestinationCategories");
            DropTable("dbo.Tips");
            DropTable("dbo.Geographies");
            DropTable("dbo.TravelCategories");
            DropTable("dbo.Destinations");
        }
    }
}
