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
    public class EmployeeRepository : IEmployeeRepository
    {
        private EmployeeDBContext _context = null;
        private DbSet<Employee> table = null;

        public EmployeeRepository()
        {
            this._context = new EmployeeDBContext();
            table = _context.Set<Employee>();
        }

        public IEnumerable<Employee> GetAll()
        {
            return table.ToList();
        }

        public Employee GetById(int id)
        {
            return table.Find(id);
        }

        public void Insert(Employee obj)
        {
            table.Add(obj);
            Save();
        }

        public void Update(Employee obj)
        {
            table.Attach(obj);
            _context.Entry(obj).State = EntityState.Modified;
            Save();
        }

        public void Delete(int id)
        {
            Employee existing = table.Find(id);
            table.Remove(existing);
            Save();
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
