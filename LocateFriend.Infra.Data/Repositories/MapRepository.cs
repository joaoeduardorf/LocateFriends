using Dijkstra.NET.Contract;
using Dijkstra.NET.Model;
using Dijkstra.NET.ShortestPath;
using Locate.Domain.Interfaces.Repositories;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;

namespace LocateFriend.Infra.Data.Repositories
{
    public class MapRepository : IMapRepository
    {
        //private MapSingleton _mapSingleton;
        public MapRepository()
        {
            //_mapSingleton = new MapSingleton();
        }

        public int GetDistance(uint from, uint to)
        {
            return MapSingleton.Instance().GetDistance(from, to);
        }

        public IEnumerable<uint> GetPath(uint from, uint to)
        {
            return MapSingleton.Instance().GetPath(from, to);
        }
    }
}