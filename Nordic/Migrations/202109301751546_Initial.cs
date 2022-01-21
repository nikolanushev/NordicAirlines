namespace Nordic.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Initial : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Clients",
                c => new
                    {
                        ClientId = c.Int(nullable: false, identity: true),
                        ClientName = c.String(nullable: false),
                        Address = c.String(nullable: false),
                        Number = c.String(nullable: false),
                        DateOfBirth = c.String(nullable: false),
                        DateOfDeparture = c.DateTime(nullable: false),
                    })
                .PrimaryKey(t => t.ClientId);
            
            CreateTable(
                "dbo.Destinations",
                c => new
                    {
                        DestinationId = c.Int(nullable: false, identity: true),
                        DestinationName = c.String(nullable: false),
                        ImageUrl = c.String(nullable: false),
                        Description = c.String(nullable: false),
                        Client_ClientId = c.Int(),
                    })
                .PrimaryKey(t => t.DestinationId)
                .ForeignKey("dbo.Clients", t => t.Client_ClientId)
                .Index(t => t.Client_ClientId);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Destinations", "Client_ClientId", "dbo.Clients");
            DropIndex("dbo.Destinations", new[] { "Client_ClientId" });
            DropTable("dbo.Destinations");
            DropTable("dbo.Clients");
        }
    }
}
