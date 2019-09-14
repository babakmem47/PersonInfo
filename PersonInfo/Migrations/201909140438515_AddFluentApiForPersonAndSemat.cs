namespace PersonInfo.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddFluentApiForPersonAndSemat : DbMigration
    {
        public override void Up()
        {
            DropForeignKey("dbo.Person", "SematId", "dbo.Semats");
            DropIndex("dbo.Person", new[] { "SematId" });
            AlterColumn("dbo.Person", "FirstName", c => c.String(nullable: false, maxLength: 20));
            AlterColumn("dbo.Person", "LastName", c => c.String(nullable: false, maxLength: 30));
            AlterColumn("dbo.Person", "TelDirect", c => c.String(maxLength: 11, fixedLength: true));
            AlterColumn("dbo.Person", "TelDakheli", c => c.String(maxLength: 4));
            AlterColumn("dbo.Person", "Mobile", c => c.String(maxLength: 11, fixedLength: true));
            AlterColumn("dbo.Person", "SematId", c => c.Byte());
            AlterColumn("dbo.Semats", "Name", c => c.String(nullable: false, maxLength: 50));
            CreateIndex("dbo.Person", "SematId");
            AddForeignKey("dbo.Person", "SematId", "dbo.Semats", "Id");
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Person", "SematId", "dbo.Semats");
            DropIndex("dbo.Person", new[] { "SematId" });
            AlterColumn("dbo.Semats", "Name", c => c.String());
            AlterColumn("dbo.Person", "SematId", c => c.Byte(nullable: false));
            AlterColumn("dbo.Person", "Mobile", c => c.String());
            AlterColumn("dbo.Person", "TelDakheli", c => c.String());
            AlterColumn("dbo.Person", "TelDirect", c => c.String());
            AlterColumn("dbo.Person", "LastName", c => c.String());
            AlterColumn("dbo.Person", "FirstName", c => c.String());
            CreateIndex("dbo.Person", "SematId");
            AddForeignKey("dbo.Person", "SematId", "dbo.Semats", "Id", cascadeDelete: true);
        }
    }
}
