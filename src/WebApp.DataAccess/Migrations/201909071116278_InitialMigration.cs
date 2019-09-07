namespace WebApp.DataAccess.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class InitialMigration : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.ContactUs",
                c => new
                    {
                        Id = c.Guid(nullable: false, identity: true),
                        Name = c.String(nullable: false, maxLength: 50),
                        Email = c.String(nullable: false, maxLength: 50),
                        Mobile = c.String(nullable: false, maxLength: 11),
                        Message = c.String(nullable: false, maxLength: 500),
                        FilePath = c.String(maxLength: 200),
                        MessageTypeId = c.Int(nullable: false),
                        CreateDate = c.DateTime(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.MessageTypes", t => t.MessageTypeId, cascadeDelete: true)
                .Index(t => t.MessageTypeId);
            
            CreateTable(
                "dbo.MessageTypes",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Type = c.String(nullable: false, maxLength: 20),
                        CreateDate = c.DateTime(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.ContactUs", "MessageTypeId", "dbo.MessageTypes");
            DropIndex("dbo.ContactUs", new[] { "MessageTypeId" });
            DropTable("dbo.MessageTypes");
            DropTable("dbo.ContactUs");
        }
    }
}
