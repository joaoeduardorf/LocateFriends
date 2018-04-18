using System;
using System.Collections.Generic;
using System.Text;

namespace LocateFriend.Application.Interfaces
{
    public interface IMapAppService
    {
        int GetDistance(uint from, uint to);
        IEnumerable<uint> GetPath(uint from, uint to);
    }
}
