namespace Traveling.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class PopulateTravelCategoriesTable : DbMigration
    {
        public override void Up()
        {
            Sql("INSERT INTO TravelCategories (Name) VALUES ('Historical Sites')");
            Sql("INSERT INTO TravelCategories (Name) VALUES ('Natural Wonders')");
            Sql("INSERT INTO TravelCategories (Name) VALUES ('Urban Destinations')");
            Sql("INSERT INTO TravelCategories (Name) VALUES ('Beach Destinations')");
            Sql("INSERT INTO TravelCategories (Name) VALUES ('Adventure Destinations')");
        }

        public override void Down()
        {
            Sql("DELETE FROM TravelCategories WHERE Name IS NOT NULL");
            Sql("TRUNCATE TABLE TravelCategories");
        }
    }
}
