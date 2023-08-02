using DAL.Entities;
using Domain.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace Domain.Interfaces
{
    public interface IDepartmentService
    {
        IEnumerable<DepartmentModel> GetDepartment();
        DepartmentModel GetDepartmentByID(int id);
    }
}
