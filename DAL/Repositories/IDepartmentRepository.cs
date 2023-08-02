using DAL.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace Domain.Interfaces
{
    public interface IDepartmentRepository
    {
        IEnumerable<Department> GetAll();
        Department GetById(int id);
        void Insert(Department obj);
        void Update(Department obj);
        void Delete(int id);
        void Save();
    }
}
