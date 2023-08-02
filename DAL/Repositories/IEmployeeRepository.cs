using DAL.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace Domain.Interfaces
{
    public interface IEmployeeRepository 
    {
        IEnumerable<Employee> GetAll();
        Employee GetById(int id);
        void Insert(Employee obj);
        void Update(Employee obj);
        void Delete(int id);
        void Save();
    }
}
