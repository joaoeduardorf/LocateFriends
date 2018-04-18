using Locate.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace Locate.Domain.Interfaces.Services
{
    public interface IFriendService
    {
        Friend Add(Friend friend, Location location);
        Friend GetById(int id);
        IEnumerable<Friend> GetAll();
        //IEnumerable<Friend> LocateFriend(int id);
        Friend Update(Friend friend);
        void Remove(Friend friend);
        void Dispose();
    }
}
