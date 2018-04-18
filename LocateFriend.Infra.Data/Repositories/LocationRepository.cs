using Locate.Domain.Entities;
using Locate.Domain.Interfaces.Repositories;
using LocateFriend.Infra.Data.Context;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace LocateFriend.Infra.Data.Repositories
{
    public class LocationRepository : ILocationRepository
    {
        private readonly LocateFriendContext _locateFriendContext;

        public LocationRepository(LocateFriendContext locateFriendContext)
        {
            _locateFriendContext = locateFriendContext;
        }
        public void Dispose()
        {
            _locateFriendContext.Dispose();
        }

        public Location GetByCoordinate(int x, int y)
        {
            return _locateFriendContext.Locations.FirstOrDefault(f => f.X == x && f.Y == y);
        }

        public Location GetByFriendId(int friendId)
        {
            return _locateFriendContext.Locations.FirstOrDefault(f => f.FriendId == friendId);
        }

        public Location GetById(int id)
        {
            return _locateFriendContext.Locations.Find(id);
        }

        public Location Update(Location location)
        {
            _locateFriendContext.Entry<Location>(location).State = EntityState.Modified;
            _locateFriendContext.SaveChanges();
            return location;
        }
    }
}
