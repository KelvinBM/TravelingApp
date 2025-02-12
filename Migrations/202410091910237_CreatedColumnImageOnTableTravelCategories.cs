namespace Traveling.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class CreatedColumnImageOnTableTravelCategories : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Destinations", "Image", c => c.String());
        }
        
        public override void Down()
        {
            DropColumn("dbo.Destinations", "Image");
        }
    }
}
