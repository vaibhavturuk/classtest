namespace ClassTestMVC.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class m2 : DbMigration
    {
        public override void Up()
        {
            DropIndex("dbo.Cities", new[] { "ste_SteId" });
            CreateIndex("dbo.Cities", "Ste_SteId");
        }
        
        public override void Down()
        {
            DropIndex("dbo.Cities", new[] { "Ste_SteId" });
            CreateIndex("dbo.Cities", "ste_SteId");
        }
    }
}
