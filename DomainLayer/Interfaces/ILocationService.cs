using DAL.Entities;
using Domain.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace Domain.Interfaces
{
    public interface ILocationService
    {
        IEnumerable<LocationModel> GetLocation();
        LocationModel GetLocationById(int id);
    }
}
