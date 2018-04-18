using LocateFriend.Application.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace LocateFriend.Application
{
    public class MapAppService : IMapAppService
    {
        private readonly IMapAppService _mapAppService;

        public MapAppService(IMapAppService mapAppService)
        {
            _mapAppService = mapAppService;
        }

        public int GetDistance(uint from, uint to)
        {
            return _mapAppService.GetDistance(from, to);
        }

        public IEnumerable<uint> GetPath(uint from, uint to)
        {
            return _mapAppService.GetPath(from, to);
        }
    }
}
