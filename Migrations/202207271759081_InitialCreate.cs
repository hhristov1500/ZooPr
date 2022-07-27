namespace Zoo.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class InitialCreate : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Animals",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                        Description = c.String(),
                        Picture = c.Binary(),
                        IdCat = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Categories", t => t.IdCat, cascadeDelete: true)
                .Index(t => t.IdCat);
            
            CreateTable(
                "dbo.Categories",
                c => new
                    {
                        IdCat = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                    })
                .PrimaryKey(t => t.IdCat);
            
            CreateTable(
                "dbo.Events",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                        Date = c.DateTime(nullable: false),
                        IdType = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.EventsTypes", t => t.IdType, cascadeDelete: true)
                .Index(t => t.IdType);
            
            CreateTable(
                "dbo.EventsTypes",
                c => new
                    {
                        IdType = c.Int(nullable: false, identity: true),
                        Type = c.String(),
                    })
                .PrimaryKey(t => t.IdType);
            
            CreateTable(
                "dbo.TicketsTypes",
                c => new
                    {
                        IdTypeTicket = c.Int(nullable: false, identity: true),
                        Type = c.String(),
                    })
                .PrimaryKey(t => t.IdTypeTicket);
            
            CreateTable(
                "dbo.Users",
                c => new
                    {
                        IdUser = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                        Password = c.String(),
                    })
                .PrimaryKey(t => t.IdUser);
            
            CreateTable(
                "dbo.UserOrdercs",
                c => new
                    {
                        IdUser = c.Int(nullable: false),
                        IdTypeTicket = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.IdUser)
                .ForeignKey("dbo.TicketsTypes", t => t.IdTypeTicket, cascadeDelete: true)
                .ForeignKey("dbo.Users", t => t.IdUser)
                .Index(t => t.IdUser)
                .Index(t => t.IdTypeTicket);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.UserOrdercs", "IdUser", "dbo.Users");
            DropForeignKey("dbo.UserOrdercs", "IdTypeTicket", "dbo.TicketsTypes");
            DropForeignKey("dbo.Events", "IdType", "dbo.EventsTypes");
            DropForeignKey("dbo.Animals", "IdCat", "dbo.Categories");
            DropIndex("dbo.UserOrdercs", new[] { "IdTypeTicket" });
            DropIndex("dbo.UserOrdercs", new[] { "IdUser" });
            DropIndex("dbo.Events", new[] { "IdType" });
            DropIndex("dbo.Animals", new[] { "IdCat" });
            DropTable("dbo.UserOrdercs");
            DropTable("dbo.Users");
            DropTable("dbo.TicketsTypes");
            DropTable("dbo.EventsTypes");
            DropTable("dbo.Events");
            DropTable("dbo.Categories");
            DropTable("dbo.Animals");
        }
    }
}
