namespace Traveling.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class InsertDataIntoTableTips : DbMigration
    {
        public override void Up()
        {
            Sql("INSERT INTO dbo.Tips (Title, TipText) VALUES ('Plan for the trip','Learn about your destination, book accommodations, and create an itinerary.')");
            Sql("INSERT INTO dbo.Tips (Title, TipText) VALUES ('Pack Lightly','Only bring essentials and versatile clothing.')");
            Sql("INSERT INTO dbo.Tips (Title, TipText) VALUES ('Stay safe','Be aware of your surroundings, keep your belongings secure, and follow local customs.')");
            Sql("INSERT INTO dbo.Tips (Title, TipText) VALUES ('Stay healthy','Stay hydrated, get enough rest, and take necessary medications.')");
            Sql("INSERT INTO dbo.Tips (Title, TipText) VALUES ('Be flexible','Embrace unexpected changes and enjoy the journey.')");
            Sql("INSERT INTO dbo.Tips (Title, TipText) VALUES ('Interact with locals','Learn about their culture and try local food.')");
            Sql("INSERT INTO dbo.Tips (Title, TipText) VALUES ('Capture memories','Take photos and create lasting memories.')");
            Sql("INSERT INTO dbo.Tips (Title, TipText) VALUES ('Have patience','Travel can be unpredictable, so stay calm and adaptable.')");
        }

        public override void Down()
        {
            Sql("TRUNCATE TABLE dbo.Tips");
        }
    }
}
