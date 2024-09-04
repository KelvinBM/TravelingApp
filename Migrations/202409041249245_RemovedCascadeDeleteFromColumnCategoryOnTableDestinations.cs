namespace Traveling.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class RemovedCascadeDeleteFromColumnCategoryOnTableDestinations : DbMigration
    {
        public override void Up()
        {
            DropForeignKey("dbo.Destinations", "CategoryId", "dbo.TravelCategories");
            AddForeignKey("dbo.Destinations", "CategoryId", "dbo.TravelCategories", "Id");
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Destinations", "CategoryId", "dbo.TravelCategories");
            AddForeignKey("dbo.Destinations", "CategoryId", "dbo.TravelCategories", "Id", cascadeDelete: true);
        }
    }
}
