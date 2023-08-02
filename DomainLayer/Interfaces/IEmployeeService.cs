using DAL.Entities;
using Domain.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace Domain.Interfaces
{
    public interface IEmployeeService
    {
        IEnumerable<EmployeeModel> GetEmployees();
        Employee GetEmployeeById(int id);
        void CreateEmployee(EmployeeModel employee);
        void UpdateEmployee(EmployeeModel employee);
        void DeleteEmployee(int id);
    }
}
