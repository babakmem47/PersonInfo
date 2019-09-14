namespace PersonInfo.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddPersonAndSemat : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Person",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        FirstName = c.String(),
                        LastName = c.String(),
                        Gender = c.Boolean(nullable: false),
                        TelDirect = c.String(),
                        TelDakheli = c.String(),
                        Mobile = c.String(),
                        Description = c.String(),
                        SematId = c.Byte(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Semats", t => t.SematId, cascadeDelete: true)
                .Index(t => t.SematId);
            
            CreateTable(
                "dbo.Semats",
                c => new
                    {
                        Id = c.Byte(nullable: false),
                        Name = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Person", "SematId", "dbo.Semats");
            DropIndex("dbo.Person", new[] { "SematId" });
            DropTable("dbo.Semats");
            DropTable("dbo.Person");
        }
    }
}
