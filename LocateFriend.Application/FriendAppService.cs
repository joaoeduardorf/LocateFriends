using Locate.Domain.Entities;
using Locate.Domain.Interfaces.Services;
using LocateFriend.Application.Interfaces;
using LocateFriend.Application.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace LocateFriend.Application
{
    public class FriendAppService : IFriendAppService
    {
        private readonly IFriendService _friendService;
        private readonly ILocationService _locationService;
        private readonly IMapService _mapService;

        public FriendAppService(IFriendService friendService, ILocationService locationService, IMapService mapService)
        {
            _friendService = friendService;
            _locationService = locationService;
            _mapService = mapService;
        }

        public Friend Add(Friend friend, Location location)
        {
            location = _locationService.GetByCoordinate(location.X, location.Y);
            return _friendService.Add(friend, location);
        }

        public void Dispose()
        {
            _friendService.Dispose();
            _locationService.Dispose();
        }

        public IEnumerable<Friend> GetAll()
        {
            return _friendService.GetAll();
        }

        public Friend GetById(int id)
        {
            return _friendService.GetById(id);
        }

        public IEnumerable<Friend> GetFriendsAround(int myX, int myY)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<FriendLocatedViewModel> LocateFriends(int id)
        {
            IList<FriendLocatedViewModel> resultFriends = new List<FriendLocatedViewModel>();

            var friends = _friendService.GetAll().Where(w => w.Id != id);
            var rootLocation = _locationService.GetByFriendId(id);


            foreach (var friend in friends)
            {

                var friendLocation = _locationService.GetByFriendId(friend.Id);
                int distance = _mapService.GetDistance((uint)rootLocation.Id, (uint)friendLocation.Id);
                IEnumerable<uint> path = _mapService.GetPath((uint)rootLocation.Id, (uint)friendLocation.Id);
                IList<Location> locations = new List<Location>();
                foreach (var item in path)
                {
                    locations.Add(_locationService.GetById((int)item));
                }
                string pathString = String.Join('-', path.Select(s => s));
                string coordinatePathhString = String.Join('\t', locations.Select(s => "(" + s.X + "," + s.Y + ")"));


                resultFriends.Add(new FriendLocatedViewModel { Id = friend.Id, Name = friend.Name, Distance = distance, Path = pathString, Coordinates = coordinatePathhString });
            }


            return resultFriends.OrderBy(o => o.Distance).Take(3);
        }

        public void Remove(Friend friend)
        {
            _friendService.Remove(friend);
        }

        public Friend Update(Friend friend)
        {
            return _friendService.Update(friend);
        }
    }
}
