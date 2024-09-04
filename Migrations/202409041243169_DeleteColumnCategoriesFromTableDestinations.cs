namespace Traveling.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class DeleteColumnCategoriesFromTableDestinations : DbMigration
    {
        public override void Up()
        {
            DropForeignKey("dbo.DestinationCategories", "DestinationId", "dbo.Destinations");
            DropForeignKey("dbo.DestinationCategories", "CategoryId", "dbo.TravelCategories");
            DropIndex("dbo.DestinationCategories", new[] { "DestinationId" });
            DropIndex("dbo.DestinationCategories", new[] { "CategoryId" });
            AddColumn("dbo.Destinations", "TravelCategory_Id", c => c.Int());
            CreateIndex("dbo.Destinations", "TravelCategory_Id");
            AddForeignKey("dbo.Destinations", "TravelCategory_Id", "dbo.TravelCategories", "Id");
            DropTable("dbo.DestinationCategories");
        }
        
        public override void Down()
        {
            CreateTable(
                "dbo.DestinationCategories",
                c => new
                    {
                        DestinationId = c.Int(nullable: false),
                        CategoryId = c.Int(nullable: false),
                    })
                .PrimaryKey(t => new { t.DestinationId, t.CategoryId });
            
            DropForeignKey("dbo.Destinations", "TravelCategory_Id", "dbo.TravelCategories");
            DropIndex("dbo.Destinations", new[] { "TravelCategory_Id" });
            DropColumn("dbo.Destinations", "TravelCategory_Id");
            CreateIndex("dbo.DestinationCategories", "CategoryId");
            CreateIndex("dbo.DestinationCategories", "DestinationId");
            AddForeignKey("dbo.DestinationCategories", "CategoryId", "dbo.TravelCategories", "Id", cascadeDelete: true);
            AddForeignKey("dbo.DestinationCategories", "DestinationId", "dbo.Destinations", "Id", cascadeDelete: true);
        }
    }
}
