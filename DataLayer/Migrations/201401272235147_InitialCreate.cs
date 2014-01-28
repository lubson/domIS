namespace DataLayer.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class InitialCreate : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Ucastnik",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Jmeno = c.String(),
                        Prijmeni = c.String(nullable: false, maxLength: 35),
                        Narozen = c.DateTime(nullable: false),
                        DateCreated = c.DateTime(nullable: false, defaultValueSql: "GETDATE()"),
                    })
                .PrimaryKey(t => t.Id);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.Ucastnik");
        }
    }
}
