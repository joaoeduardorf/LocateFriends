using System;
using System.Collections.Generic;
using System.Text;

namespace Locate.Domain.Interfaces.Services
{
    public interface IMapService
    {
        int GetDistance(uint from, uint to);
        IEnumerable<uint> GetPath(uint from, uint to);
    }
}
