using System;
using System.Collections.Generic;
using System.Text;

namespace Locate.Domain.Interfaces.Repositories
{
    public interface IMapRepository
    {
        int GetDistance(uint from, uint to);
        IEnumerable<uint> GetPath(uint from, uint to);
    }
}
