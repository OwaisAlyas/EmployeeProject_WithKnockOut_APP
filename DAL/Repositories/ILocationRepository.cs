using DAL.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace Domain.Interfaces
{
    public interface ILocationRepository
    {
        IEnumerable<Location> GetAll();
        Location GetById(int id);
        void Insert(Location obj);
        void Update(Location obj);
        void Delete(int id);
        void Save();
    }
}
