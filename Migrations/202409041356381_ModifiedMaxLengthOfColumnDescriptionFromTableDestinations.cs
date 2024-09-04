namespace Traveling.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class ModifiedMaxLengthOfColumnDescriptionFromTableDestinations : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.Destinations", "Description", c => c.String(nullable: false, maxLength: 190));
        }
        
        public override void Down()
        {
            AlterColumn("dbo.Destinations", "Description", c => c.String(nullable: false, maxLength: 260));
        }
    }
}
