using Dijkstra.NET.Contract;
using Dijkstra.NET.Model;
using Dijkstra.NET.ShortestPath;
using System;
using System.Collections.Generic;
using System.Text;

namespace LocateFriend.Infra.Data.Repositories
{
    public class MapSingleton
    {
        private static MapSingleton _instance;
        private readonly Graph<uint, string> graph;
        //private readonly Dijkstra<uint, string> dijkstra;

        private MapSingleton()
        {
            graph = new Graph<uint, string>();

            for (uint i = 0; i < 10000; i++)
            {
                graph.AddNode(i);

            }

            for (uint i = 0; i < 100; i++)
            {
                for (uint j = 1; j < 100; j++)
                {
                    graph.Connect(((i * 100) + j - 1), ((i * 100) + j), 1, "");
                    graph.Connect(((i * 100) + j), ((i * 100) + j - 1), 1, "");

                    if (i > 0)
                    {
                        graph.Connect(((i * 100) - 100 + j - 1), ((i * 100) + j - 1), 1, "");
                        graph.Connect(((i * 100) + j - 1), ((i * 100) - 100 + j - 1), 1, "");
                    }

                }
            }
        }

        public static MapSingleton Instance()
        {
            if (_instance == null)
            {
                _instance = new MapSingleton();
            }

            return _instance;
        }

        public int GetDistance(uint from, uint to)
        {

            var dijkstra = new Dijkstra<uint, string>(graph.Clone());
            IShortestPathResult result = dijkstra.Process(from, to);
            return result.Distance;
        }

        public IEnumerable<uint> GetPath(uint from, uint to)
        {

            var dijkstra = new Dijkstra<uint, string>(graph.Clone());
            IShortestPathResult result = dijkstra.Process(from, to);
            return result.GetPath();
        }
    }
}
