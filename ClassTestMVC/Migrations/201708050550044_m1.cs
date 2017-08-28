namespace ClassTestMVC.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class m1 : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Cities",
                c => new
                    {
                        CityId = c.Int(nullable: false, identity: true),
                        CityName = c.String(),
                        StateId = c.Int(nullable: false),
                        ste_SteId = c.Int(),
                    })
                .PrimaryKey(t => t.CityId)
                .ForeignKey("dbo.Stes", t => t.ste_SteId)
                .Index(t => t.ste_SteId);
            
            CreateTable(
                "dbo.Stes",
                c => new
                    {
                        SteId = c.Int(nullable: false, identity: true),
                        SteName = c.String(),
                    })
                .PrimaryKey(t => t.SteId);
            
            CreateTable(
                "dbo.Emps",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(nullable: false),
                        Email = c.String(nullable: false),
                        Phone = c.String(nullable: false),
                        MaritalStatus = c.Boolean(nullable: false),
                        StateId = c.Int(nullable: false),
                        cityId = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Cities", t => t.cityId, cascadeDelete: true)
                .Index(t => t.cityId);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Emps", "cityId", "dbo.Cities");
            DropForeignKey("dbo.Cities", "ste_SteId", "dbo.Stes");
            DropIndex("dbo.Emps", new[] { "cityId" });
            DropIndex("dbo.Cities", new[] { "ste_SteId" });
            DropTable("dbo.Emps");
            DropTable("dbo.Stes");
            DropTable("dbo.Cities");
        }
    }
}
