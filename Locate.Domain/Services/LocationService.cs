using Locate.Domain.Entities;
using Locate.Domain.Interfaces.Repositories;
using Locate.Domain.Interfaces.Services;
using System;
using System.Collections.Generic;
using System.Text;

namespace Locate.Domain.Services
{
    public class LocationService : ILocationService
    {
        private readonly ILocationRepository _locationRepository;

        public LocationService(ILocationRepository locationRepository)
        {
            _locationRepository = locationRepository;
        }

        public Location GetByCoordinate(int x, int y)
        {
            return _locationRepository.GetByCoordinate(x, y);
        }

        public Location GetById(int id)
        {
            return _locationRepository.GetById(id);
        }

        public void Dispose()
        {
            _locationRepository.Dispose();
        }

        public Location Update(Location location)
        {
            return _locationRepository.Update(location);
        }

        public Location GetByFriendId(int friendId)
        {
            return _locationRepository.GetByFriendId(friendId);
        }
    }
}
