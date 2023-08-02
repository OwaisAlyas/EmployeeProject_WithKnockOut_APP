namespace DAL.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class initial1 : DbMigration
    {
        public override void Up()
        {
            RenameTable(name: "dbo.Departments", newName: "Department");
            RenameTable(name: "dbo.Employees", newName: "Employee");
            RenameTable(name: "dbo.Locations", newName: "Location");
        }
        
        public override void Down()
        {
            RenameTable(name: "dbo.Location", newName: "Locations");
            RenameTable(name: "dbo.Employee", newName: "Employees");
            RenameTable(name: "dbo.Department", newName: "Departments");
        }
    }
}
