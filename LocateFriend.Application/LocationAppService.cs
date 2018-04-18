using Locate.Domain.Entities;
using LocateFriend.Application.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace LocateFriend.Application
{
    public class LocationAppService : ILocationAppService
    {
        private readonly ILocationAppService _locationAppService;

        public LocationAppService(ILocationAppService locationAppService)
        {
            _locationAppService = locationAppService;
        }
        public void Dispose()
        {
            _locationAppService.Dispose();
        }

        public Location GetByCoordinate(int x, int y)
        {
            return _locationAppService.GetByCoordinate(x, y);
        }

        public Location GetById(int id)
        {
            return _locationAppService.GetById(id);
        }

        public Location Update(Location location)
        {
            return _locationAppService.Update(location);
        }
    }
}
