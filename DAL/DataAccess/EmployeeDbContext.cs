using System.Collections.Generic;
using System;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL.Entities;

namespace DAL.DataAccess
{
    public class EmployeeDBContext : DbContext
    {
        public EmployeeDBContext() : base("EmployeeDBContext")
        {
        }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
        }

        public DbSet<Employee> Employees { get; set; }
        public DbSet<Location> Locations { get; set; }
        public DbSet<Department> Departments { get; set; }
    }


    //public class EmployeeDbInitializer : DropCreateDatabaseAlways<EmployeeDBContext>
    //{

    //    protected override void Seed(EmployeeDBContext context)
    //    {
    //    var Department = new List<Department>() {
    //      new Department { DepartmentId = 1, DepartmentName = "IT",},
    //      new Department { DepartmentId = 2, DepartmentName = "Sales"},
    //      new Department { DepartmentId = 3, DepartmentName = "HR"},
    //    };
    //    var Location = new List<Location>() {
    //      new Location { LocationId = 1, LocationName = "London",},
    //      new Location { LocationId = 2, LocationName = "Manchester"},
    //      new Location { LocationId = 3, LocationName = "Liverpool"},
    //      new Location { LocationId = 4,LocationName= "Leeds"},
    //    };
    //        context.Locations.AddRange(Location);
    //        context.Departments.AddRange(Department);
    //        context.SaveChanges();
    //    }
    //}
}