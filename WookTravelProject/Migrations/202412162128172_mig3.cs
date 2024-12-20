namespace WookTravelProject.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class mig3 : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Reservations", "DestinationNameId", c => c.Int(nullable: false));
            DropColumn("dbo.Reservations", "DestinationId");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Reservations", "DestinationId", c => c.Int(nullable: false));
            DropColumn("dbo.Reservations", "DestinationNameId");
        }
    }
}
