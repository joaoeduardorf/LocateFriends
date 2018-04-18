using Locate.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace LocateFriend.Application.Interfaces
{
    public interface ILocationAppService
    {
        Location Update(Location location);
        Location GetById(int id);
        Location GetByCoordinate(int x, int y);
        void Dispose();
    }
}
