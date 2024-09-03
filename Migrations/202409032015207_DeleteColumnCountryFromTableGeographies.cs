namespace Traveling.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class DeleteColumnCountryFromTableGeographies : DbMigration
    {
        public override void Up()
        {
            DropColumn("dbo.Geographies", "Country");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Geographies", "Country", c => c.String(nullable: false));
        }
    }
}
