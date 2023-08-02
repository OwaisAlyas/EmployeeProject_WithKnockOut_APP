using DAL.DataAccess;
using DAL.Entities;
using Domain.Interfaces;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Repositories
{
    public class DepartmentRepository : IDepartmentRepository
    {
        private EmployeeDBContext _context = null;
        private DbSet<Department> table = null;

        public DepartmentRepository()
        {
            this._context = new EmployeeDBContext();
            table = _context.Set<Department>();
        }

        public DepartmentRepository(EmployeeDBContext _context)
        {
            this._context = _context;
            table = _context.Set<Department>();
        }

        public IEnumerable<Department> GetAll()
        {
            return table.ToList();
        }

        public Department GetById(int id)
        {
            return table.Find(id);
        }

        public void Insert(Department obj)
        {
            table.Add(obj);
        }

        public void Update(Department obj)
        {
            table.Attach(obj);
            _context.Entry(obj).State = EntityState.Modified;
        }

        public void Delete(int id)
        {
            Department existing = table.Find(id);
            table.Remove(existing);
        }

        public void Save()
        {
            _context.SaveChanges();
        }

        //public void Insert(Employee obj)
        //{
        //    throw new NotImplementedException();
        //}

        //public void Update(Employee obj)
        //{
        //    throw new NotImplementedException();
        //}
    }
}
