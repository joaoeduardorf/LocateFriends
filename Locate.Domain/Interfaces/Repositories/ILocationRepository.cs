using Locate.Domain.Entities;
using System.Collections.Generic;

namespace Locate.Domain.Interfaces.Repositories
{
    public interface ILocationRepository
    {
        Location Update(Location location);
        Location GetById(int id);
        Location GetByFriendId(int friendId);
        Location GetByCoordinate(int x, int y);
        void Dispose();
    }
}
