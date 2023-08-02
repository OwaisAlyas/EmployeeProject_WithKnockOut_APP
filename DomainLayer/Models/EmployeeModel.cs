using System;
using System.Collections.Generic;
using System.Text;

namespace Domain.Models
{
    public class EmployeeModel
    {
        public int Id { get; set; }
        public string EmployeeNo { get; set; }
        public string FullName { get; set; }
        public int DepartmentId { get; set; }
        public  DepartmentModel Department { get; set; }
        public int LocationId { get; set; }
        public  LocationModel Location { get; set; }
    }
}
