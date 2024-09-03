namespace Traveling.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class DeleteColumnContinentFromTableGeographies : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Geographies", "Country", c => c.String(nullable: false));
            DropColumn("dbo.Geographies", "Continent");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Geographies", "Continent", c => c.String(nullable: false));
            DropColumn("dbo.Geographies", "Country");
        }
    }
}
