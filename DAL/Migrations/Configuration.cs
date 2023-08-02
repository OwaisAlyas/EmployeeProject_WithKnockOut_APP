namespace DAL.Migrations
{
    using System;
    using DAL.Entities;
    using System.Collections.Generic;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;

    internal sealed class Configuration : DbMigrationsConfiguration<DAL.DataAccess.EmployeeDBContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = false;
        }

        protected override void Seed(DAL.DataAccess.EmployeeDBContext context)
        {
            var Department = new List<Department>() {
          new Department { DepartmentId = 1, DepartmentName = "IT",},
          new Department { DepartmentId = 2, DepartmentName = "Sales"},
          new Department { DepartmentId = 3, DepartmentName = "HR"},
        };
            var Location = new List<Location>() {
          new Location { LocationId = 1, LocationName = "London",},
          new Location { LocationId = 2, LocationName = "Manchester"},
          new Location { LocationId = 3, LocationName = "Liverpool"},
          new Location { LocationId = 4,LocationName= "Leeds"},
        };
            context.Locations.AddRange(Location);
            context.Departments.AddRange(Department);
            context.SaveChanges();
        }
    }
}
