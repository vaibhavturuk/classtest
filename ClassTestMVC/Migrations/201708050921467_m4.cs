namespace ClassTestMVC.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class m4 : DbMigration
    {
        public override void Up()
        {
            MoveTable(name: "dbo.Cities", newSchema: "Week_5");
            MoveTable(name: "dbo.Stes", newSchema: "Week_5");
            MoveTable(name: "dbo.Emps", newSchema: "Week_5");
        }
        
        public override void Down()
        {
            MoveTable(name: "Week_5.Emps", newSchema: "dbo");
            MoveTable(name: "Week_5.Stes", newSchema: "dbo");
            MoveTable(name: "Week_5.Cities", newSchema: "dbo");
        }
    }
}
