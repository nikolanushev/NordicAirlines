namespace Nordic.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class addedClientDestination : DbMigration
    {
        public override void Up()
        {
            DropForeignKey("dbo.Destinations", "Client_ClientId", "dbo.Clients");
            DropIndex("dbo.Destinations", new[] { "Client_ClientId" });
            CreateTable(
                "dbo.DestinationClients",
                c => new
                    {
                        Destination_DestinationId = c.Int(nullable: false),
                        Client_ClientId = c.Int(nullable: false),
                    })
                .PrimaryKey(t => new { t.Destination_DestinationId, t.Client_ClientId })
                .ForeignKey("dbo.Destinations", t => t.Destination_DestinationId, cascadeDelete: true)
                .ForeignKey("dbo.Clients", t => t.Client_ClientId, cascadeDelete: true)
                .Index(t => t.Destination_DestinationId)
                .Index(t => t.Client_ClientId);
            
            DropColumn("dbo.Destinations", "Client_ClientId");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Destinations", "Client_ClientId", c => c.Int());
            DropForeignKey("dbo.DestinationClients", "Client_ClientId", "dbo.Clients");
            DropForeignKey("dbo.DestinationClients", "Destination_DestinationId", "dbo.Destinations");
            DropIndex("dbo.DestinationClients", new[] { "Client_ClientId" });
            DropIndex("dbo.DestinationClients", new[] { "Destination_DestinationId" });
            DropTable("dbo.DestinationClients");
            CreateIndex("dbo.Destinations", "Client_ClientId");
            AddForeignKey("dbo.Destinations", "Client_ClientId", "dbo.Clients", "ClientId");
        }
    }
}
