using Locate.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace Locate.Domain.Interfaces.Services
{
    public interface ILocationService
    {
        Location Update(Location location);
        Location GetById(int id);
        Location GetByFriendId(int friendId);
        Location GetByCoordinate(int x, int y);
        void Dispose();
    }
}
