namespace DataLayer.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Initial : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Ucastnik",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        NarodnostId = c.Int(nullable: false),
                        Jmeno = c.String(),
                        Prijmeni = c.String(nullable: false, maxLength: 35),
                        Narozen = c.DateTime(nullable: false),
                        DateCreated = c.DateTime(nullable: false, defaultValueSql: "GETDATE()"),
                        Pohlavi = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.CNarodnost", t => t.NarodnostId, cascadeDelete: true)
                .Index(t => t.NarodnostId);
            
            CreateTable(
                "dbo.CNarodnost",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Kod = c.String(nullable: false, maxLength: 3),
                        Nazev = c.String(nullable: false, maxLength: 30),
                    })
                .PrimaryKey(t => t.Id);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Ucastnik", "NarodnostId", "dbo.CNarodnost");
            DropIndex("dbo.Ucastnik", new[] { "NarodnostId" });
            DropTable("dbo.CNarodnost");
            DropTable("dbo.Ucastnik");
        }
    }
}
