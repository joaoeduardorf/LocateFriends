using Locate.Domain.Interfaces.Repositories;
using Locate.Domain.Interfaces.Services;
using System;
using System.Collections.Generic;
using System.Text;

namespace Locate.Domain.Services
{
    public class MapService : IMapService
    {
        private readonly IMapRepository _mapRepository;

        public MapService(IMapRepository mapRepository)
        {
            _mapRepository = mapRepository;
        }

        public int GetDistance(uint from, uint to)
        {
            return _mapRepository.GetDistance(from, to);
        }

        public IEnumerable<uint> GetPath(uint from, uint to)
        {
            return _mapRepository.GetPath(from, to);
        }
    }
}
