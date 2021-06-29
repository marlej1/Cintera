namespace Cintera.DAL.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddSighting : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Sightging",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Address = c.String(nullable: false, maxLength: 256),
                        CaseId = c.Int(nullable: false),
                        Date = c.DateTime(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Case", t => t.CaseId, cascadeDelete: true)
                .Index(t => t.CaseId);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Sightging", "CaseId", "dbo.Case");
            DropIndex("dbo.Sightging", new[] { "CaseId" });
            DropTable("dbo.Sightging");
        }
    }
}
