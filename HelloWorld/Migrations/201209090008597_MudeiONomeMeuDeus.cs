namespace HelloWorld.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class MudeiONomeMeuDeus : DbMigration
    {
        public override void Up()
        {
            DropTable("dbo.GuestbookEntries");
            CreateTable(
                "dbo.GuestbookEntries",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                        Message = c.String(),
                        DateAdded = c.DateTime(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
        }
        
        public override void Down()
        {           
            DropTable("dbo.GuestbookEntries");
        }
    }
}
