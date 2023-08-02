using DAL.Entities;
using Domain.Interfaces;
using Domain.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace Domain.Services
{
    public class LocationService : ILocationService
    {
        ILocationRepository genericRepository;
        public LocationService(ILocationRepository iGenericRepository)
        {
             genericRepository= iGenericRepository;
        }

        public IEnumerable<LocationModel> GetLocation()
        {
            var listdata = genericRepository.GetAll();
            var locationlist = new List<LocationModel>();
            foreach (var data in listdata)
            {
                var location = new LocationModel();
                location.LocationId = data.LocationId;
                location.LocationName = data.LocationName;
                locationlist.Add(location);
            }
            return locationlist;
        }

        public LocationModel GetLocationById(int id)
        {
            var data = genericRepository.GetById(id);
            var location = new LocationModel();
            location.LocationId = data.LocationId;
            location.LocationName = data.LocationName;
            return location;

        }
    }
}
