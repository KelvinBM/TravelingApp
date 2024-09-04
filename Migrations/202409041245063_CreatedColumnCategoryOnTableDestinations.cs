namespace Traveling.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class CreatedColumnCategoryOnTableDestinations : DbMigration
    {
        public override void Up()
        {
            DropForeignKey("dbo.Destinations", "TravelCategory_Id", "dbo.TravelCategories");
            DropIndex("dbo.Destinations", new[] { "TravelCategory_Id" });
            RenameColumn(table: "dbo.Destinations", name: "TravelCategory_Id", newName: "CategoryId");
            AlterColumn("dbo.Destinations", "CategoryId", c => c.Int(nullable: false));
            CreateIndex("dbo.Destinations", "CategoryId");
            AddForeignKey("dbo.Destinations", "CategoryId", "dbo.TravelCategories", "Id", cascadeDelete: true);
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Destinations", "CategoryId", "dbo.TravelCategories");
            DropIndex("dbo.Destinations", new[] { "CategoryId" });
            AlterColumn("dbo.Destinations", "CategoryId", c => c.Int());
            RenameColumn(table: "dbo.Destinations", name: "CategoryId", newName: "TravelCategory_Id");
            CreateIndex("dbo.Destinations", "TravelCategory_Id");
            AddForeignKey("dbo.Destinations", "TravelCategory_Id", "dbo.TravelCategories", "Id");
        }
    }
}
