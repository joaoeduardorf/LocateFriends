using Locate.Domain.Entities;
using Locate.Domain.Interfaces.Repositories;
using Locate.Domain.Interfaces.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Locate.Domain.Services
{
    public class FriendService : IFriendService
    {
        private readonly IFriendRepository _friendRepository;
        private readonly ILocationRepository _locationRepository;
        private readonly IMapService _mapService;

        public FriendService(IFriendRepository friendRepository, ILocationRepository locationRepository, IMapService mapService)
        {
            _friendRepository = friendRepository;
            _locationRepository = locationRepository;
            _mapService = mapService;
        }

        public Friend Add(Friend friend, Location location)
        {
            if (location.FriendId == null)
            {
                friend.Location = location;
                friend = _friendRepository.Add(friend);
                location.FriendId = friend.Id;
                _locationRepository.Update(location);
            }
            else
            {
                throw new ArgumentException("Location invalid!");
            }

            return friend;
        }

        public void Dispose()
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Friend> GetAll()
        {
            return _friendRepository.GetAll();
        }

        public Friend GetById(int id)
        {
            throw new NotImplementedException();
        }

        public void Remove(Friend friend)
        {
            throw new NotImplementedException();
        }

        public Friend Update(Friend friend)
        {
            throw new NotImplementedException();
        }
    }
}
