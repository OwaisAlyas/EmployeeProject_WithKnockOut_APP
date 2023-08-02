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
    public class LocationRepository : ILocationRepository
    {
        private EmployeeDBContext _context = null;
        private DbSet<Location> table = null;

        public LocationRepository()
        {
            this._context = new EmployeeDBContext();
            table = _context.Set<Location>();
        }

        public LocationRepository(EmployeeDBContext _context)
        {
            this._context = _context;
            table = _context.Set<Location>();
        }

        public IEnumerable<Location> GetAll()
        {
            return table.ToList();
        }

        public Location GetById(int id)
        {
            return table.Find(id);
        }

        public void Insert(Location obj)
        {
            table.Add(obj);
        }

        public void Update(Location obj)
        {
            table.Attach(obj);
            _context.Entry(obj).State = EntityState.Modified;
        }

        public void Delete(int id)
        {
            Location existing = table.Find(id);
            table.Remove(existing);
        }

        public void Save()
        {
            _context.SaveChanges();
        }
    }
}
